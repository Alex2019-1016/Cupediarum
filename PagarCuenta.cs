using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Cupediarum
{
    public partial class FrmPagarCuenta : Form
    {
        decimal totalCuenta = 0;
        decimal totalPagado = 0;
        string metodoSeleccionado = "";
        int idCuenta;
        int filaSeleccionada = -1;

        string entrada = "";


        public FrmPagarCuenta(int idCuentaRecibida, decimal total)
        {
            InitializeComponent();

            idCuenta = idCuentaRecibida;
            totalCuenta = total;

            TxtTotal.Text = totalCuenta.ToString("0.00");
            TxtSaldo.Text = totalCuenta.ToString("0.00");

            CargarMetodos();
            DiseñarGrid();


            filaSeleccionada = 0;
            DgvPagos.Rows[0].Selected = true;
            metodoSeleccionado = "EFECTIVO";
        }

        private void CargarMetodos()
        {
            DgvPagos.Rows.Clear();

            DgvPagos.Rows.Add("EF", "EFECTIVO", 0, 0, 0);
            DgvPagos.Rows.Add("VISA", "VISA", 0, 0, 0);
            DgvPagos.Rows.Add("MC", "MASTERCARD", 0, 0, 0);
            DgvPagos.Rows.Add("AMEX", "AMERICAN EXPRESS", 0, 0, 0);
        }

        private void BtnMetodo_Click(object sender, EventArgs e)
        {
           
            Button btn = (Button)sender;
            metodoSeleccionado = btn.Text;

            foreach (DataGridViewRow row in DgvPagos.Rows)
            {
                if (row.Cells[1].Value.ToString() == metodoSeleccionado)
                {
                    filaSeleccionada = row.Index;
                    DgvPagos.ClearSelection();
                    row.Selected = true;
                    DgvPagos.CurrentCell = row.Cells[1];
                    break;
                }
            }

            if (metodoSeleccionado == "VISA" ||
                metodoSeleccionado == "MASTERCARD" ||
                metodoSeleccionado == "AMERICAN EXPRESS")
            {
                TxtTarjeta.Text = metodoSeleccionado;
            }
            else
            {
                TxtTarjeta.Clear();
            }
        }

        private void BtnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            entrada += btn.Text;
            TxtMonto.Text = entrada;
        }

        private void BtnEnter_Click_1(object sender, EventArgs e)
        {
            if (totalPagado >= totalCuenta)
            {
                MessageBox.Show("La cuenta ya está saldada");
                return;
            }

            if (DgvPagos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un método de pago");
                return;
            }

            DataGridViewRow row = DgvPagos.CurrentRow;

            decimal monto = 0;
            decimal propina = 0;

            decimal.TryParse(TxtMonto.Text, out monto);

            if (!string.IsNullOrWhiteSpace(TxtPropina.Text))
                decimal.TryParse(TxtPropina.Text, out propina);

            if (monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido");
                return;
            }

            decimal montoActual = 0;
            decimal.TryParse(row.Cells[2].Value?.ToString(), out montoActual);
            montoActual += monto;

            decimal propinaActual = 0;
            decimal.TryParse(row.Cells[3].Value?.ToString(), out propinaActual);
            propinaActual += propina;

            decimal totalLinea = montoActual + propinaActual;

            row.Cells[2].Value = montoActual;
            row.Cells[3].Value = propinaActual;
            row.Cells[4].Value = totalLinea;

            DgvPagos.Refresh();

            CalcularTotales();

            TxtImporte.Text = montoActual.ToString("0.00");
            TxtProp.Text = propinaActual.ToString("0.00");
            TxtTot.Text = totalLinea.ToString("0.00");

            entrada = "";
            TxtMonto.Clear();
            TxtPropina.Text = "0.00";
            TxtMonto.Focus();
        }

        private void CalcularTotales()
        {
            totalPagado = 0;
            decimal totalPropinas = 0;

            foreach (DataGridViewRow row in DgvPagos.Rows)
            {
                if (row.IsNewRow) continue;

                decimal total = 0;
                decimal propina = 0;

                decimal.TryParse(row.Cells[4].Value?.ToString(), out total);
                decimal.TryParse(row.Cells[3].Value?.ToString(), out propina);

                totalPagado += total;
                totalPropinas += propina;
            }

            decimal totalFinal = totalCuenta + totalPropinas;

            TxtConsumo.Text = totalCuenta.ToString("0.00");
            TxtTotal.Text = totalFinal.ToString("0.00");

            decimal cambio = 0;

            if (totalPagado > totalFinal)
                cambio = totalPagado - totalFinal;

            TxtCambio.Text = cambio.ToString("0.00");

            decimal saldo = totalFinal - totalPagado;
            if (saldo < 0) saldo = 0;

            TxtSaldo.Text = saldo.ToString("0.00");
        }

        private void GuardarPagos()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    foreach (DataGridViewRow row in DgvPagos.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string metodo = row.Cells[0].Value?.ToString() ?? "";

                        decimal monto = 0;
                        decimal.TryParse(row.Cells[2].Value?.ToString(), out monto);

                        if (monto <= 0) continue;

                        decimal propina = 0;
                        decimal.TryParse(row.Cells[3].Value?.ToString(), out propina);

                        decimal total = 0;
                        decimal.TryParse(row.Cells[4].Value?.ToString(), out total);

                        string query = @"INSERT INTO Pagos
                            (Id_Cuenta, MetodoPago, Monto, Propina, Total)
                            VALUES
                            (@IdCuenta, @Metodo, @Monto, @Propina, @Total)";

                        using (SqlCommand cmd = new SqlCommand(query, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
                            cmd.Parameters.AddWithValue("@Metodo", metodo);
                            cmd.Parameters.AddWithValue("@Monto", monto);
                            cmd.Parameters.AddWithValue("@Propina", propina);
                            cmd.Parameters.AddWithValue("@Total", total);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    string update = @"UPDATE CUENTAS 
                                      SET Estado = 'PAGADA' 
                                      WHERE Id_Cuenta = @IdCuenta";

                    using (SqlCommand cmd = new SqlCommand(update, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            decimal totalPropinas = 0;

            foreach (DataGridViewRow row in DgvPagos.Rows)
            {
                if (row.IsNewRow) continue;

                decimal propina = 0;
                decimal.TryParse(row.Cells[3].Value?.ToString(), out propina);

                totalPropinas += propina;
            }

            decimal totalFinal = totalCuenta + totalPropinas;

            if (totalPagado < totalFinal)
            {
                MessageBox.Show("El pago no cubre el total con propina");
                return;
            }

            GuardarPagos();

            MessageBox.Show("Cuenta pagada correctamente");
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (entrada.Length > 0)
            {
                entrada = entrada.Substring(0, entrada.Length - 1);
                TxtMonto.Text = entrada;
            }
        }

        private void DiseñarGrid()
        {
            // CABECERAS
            DgvPagos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            DgvPagos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            DgvPagos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold);
            DgvPagos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvPagos.ColumnHeadersHeight = 35;

            // FILAS
            DgvPagos.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10);
            DgvPagos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCoral;
            DgvPagos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            DgvPagos.RowTemplate.Height = 30;

            // COLORES ALTERNOS
            DgvPagos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            // CONFIG
            DgvPagos.RowHeadersVisible = false;
            DgvPagos.AllowUserToAddRows = false;
            DgvPagos.AllowUserToResizeRows = false;
            DgvPagos.AllowUserToResizeColumns = false;
            DgvPagos.MultiSelect = false;
            DgvPagos.ReadOnly = true;
            DgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // TAMAÑOS
            DgvPagos.Columns[0].Width = 60;
            DgvPagos.Columns[1].Width = 180;
            DgvPagos.Columns[2].Width = 130;
            DgvPagos.Columns[3].Width = 130;
            DgvPagos.Columns[4].Width = 130;

            // FORMATO DINERO
            DgvPagos.Columns[2].DefaultCellStyle.Format = "N2";
            DgvPagos.Columns[3].DefaultCellStyle.Format = "N2";
            DgvPagos.Columns[4].DefaultCellStyle.Format = "N2";

            // ALINEACIÓN
            DgvPagos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvPagos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvPagos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void DgvPagos_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvPagos.CurrentRow == null) return;

            DataGridViewRow row = DgvPagos.CurrentRow;

            decimal importe = 0;
            decimal propina = 0;
            decimal total = 0;

            decimal.TryParse(row.Cells[2].Value?.ToString(), out importe);
            decimal.TryParse(row.Cells[3].Value?.ToString(), out propina);
            decimal.TryParse(row.Cells[4].Value?.ToString(), out total);

            TxtImporte.Text = importe.ToString("0.00");
            TxtProp.Text = propina.ToString("0.00");
            TxtTot.Text = total.ToString("0.00");
        }

        private void BtnPropina_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
            "Ingrese el % de propina:", "Propina", "10");

            if (decimal.TryParse(input, out decimal porcentaje))
            {
                decimal propina = totalCuenta * (porcentaje / 100);

                TxtPropina.Text = propina.ToString("0.00");
                TxtProp.Text = propina.ToString("0.00");
            }
        }
    }
}