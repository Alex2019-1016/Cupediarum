using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cupediarum
{
    public partial class FrmMesas : Form
    {

        private decimal descuentoPorcentaje = 0;
        PrintDocument documento = new PrintDocument();
        int idCuentaImprimir = 0;
        int anchoTicket = 280;

        public FrmMesas()
        {
            InitializeComponent();
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            CargarAreas();
            CargarCuentas();

            DiseñarTabla(DgvCuentas);
            DiseñarTabla(DgvComanda);
        }

        private void CargarAreas()
        {
            string connStr = ConfigurationManager
               .ConnectionStrings["ConexionRestaurante"]
               .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT Id_Area, Nomb_Area FROM AREAS";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow fila = dt.NewRow();
                fila["Id_Area"] = 0;
                fila["Nomb_Area"] = "TODAS LAS AREAS";
                dt.Rows.InsertAt(fila, 0);

                CbArea.DataSource = dt;
                CbArea.DisplayMember = "Nomb_Area";
                CbArea.ValueMember = "Id_Area";
                CbArea.SelectedIndex = 0;
            }
        }

        private void CargarCuentas()
        {
            if (CbArea.SelectedValue == null || CbArea.SelectedValue is DataRowView)
                return;

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            int area = Convert.ToInt32(CbArea.SelectedValue);

            string query = @"SELECT 
                 C.Id_Cuenta,
                 C.Nomb_Cuenta,
                 C.Impresa,
                 U.Nomb_Usuario AS Usuario,
                 R.Nomb_Rol AS Rol
                 FROM CUENTAS C
                 INNER JOIN USUARIOS U 
                 ON U.Id_Usuario = C.Id_Usuario
                 INNER JOIN ROLES R
                 ON R.Id_Rol = U.Id_Rol
                 WHERE C.Estado = 1
                 AND C.Nomb_Cuenta LIKE @buscar";

            if (area != 0)
                query += " AND C.Id_Area = @area";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue("@buscar", "%" + TxtBuscarCuentas.Text + "%");

                if (area != 0)
                    da.SelectCommand.Parameters.AddWithValue("@area", area);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DgvCuentas.DataSource = dt;

                if (DgvCuentas.Columns["Impresa"] is DataGridViewTextBoxColumn)
                {
                    int index = DgvCuentas.Columns["Impresa"].Index;
                    DgvCuentas.Columns.Remove("Impresa");

                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    chk.Name = "Impresa";
                    chk.HeaderText = "IMPRESA";
                    chk.DataPropertyName = "Impresa";

                    DgvCuentas.Columns.Insert(index, chk);
                }

                DgvCuentas.Refresh();

                DgvCuentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DgvCuentas.MultiSelect = false;

                if (DgvCuentas.Columns.Contains("Id_Cuenta"))
                    DgvCuentas.Columns["Id_Cuenta"].Visible = false;

                DgvCuentas.Columns["Nomb_Cuenta"].HeaderText = "CUENTA";
                DgvCuentas.Columns["Usuario"].HeaderText = "USUARIO";
                DgvCuentas.Columns["Rol"].HeaderText = "ROL";

                LblCantCuentas.Text = dt.Rows.Count.ToString();

                if (DgvCuentas.Rows.Count > 0)
                {
                    DgvCuentas.ClearSelection();
                    DgvCuentas.Rows[0].Selected = true;

                    int idCuenta = Convert.ToInt32(DgvCuentas.Rows[0].Cells["Id_Cuenta"].Value);

                    CargarDetalleCuenta(idCuenta);
                    CargarComanda(idCuenta);
                }
            }
        }

        private void TxtBuscarCuentas_TextChanged(object sender, EventArgs e)
        {
            CargarCuentas();
        }

        private void ActualizarImpresa(int idCuenta, bool impresa)
        {
            string query = "UPDATE CUENTAS SET Impresa = @Impresa WHERE Id_Cuenta = @IdCuenta";

            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["ConexionRestaurante"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Impresa", impresa);
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void CargarDetalleCuenta(int idCuenta)
        {
            string connStr = ConfigurationManager
       .ConnectionStrings["ConexionRestaurante"]
       .ConnectionString;

            string query = @"SELECT 
            C.Nomb_Cuenta,
            C.Cantidad_Personas,
            C.FechaApertura,
            C.Comentario, 
            A.Nomb_Area,
            U.Nomb_Usuario
            FROM CUENTAS C
            INNER JOIN AREAS A 
            ON C.Id_Area = A.Id_Area
            INNER JOIN USUARIOS U 
            ON C.Id_Usuario = U.Id_Usuario
            WHERE C.Id_Cuenta = @IdCuenta";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    LblCuenta.Text = reader["Nomb_Cuenta"].ToString();
                    LblPersonas.Text = reader["Cantidad_Personas"].ToString();
                    LblNombArea.Text = reader["Nomb_Area"].ToString();
                    LblNombMesero.Text = reader["Nomb_Usuario"].ToString();

                    if (reader["Comentario"] != DBNull.Value)
                        RtbComentario.Text = reader["Comentario"].ToString();
                    else
                        RtbComentario.Text = "";

                    DtpFecha.Value = Convert.ToDateTime(reader["FechaApertura"]);
                    DtpFecha.Enabled = false;
                }

                reader.Close();
            }
            CalcularTotales();
        }

        private void CargarComanda(int idCuenta)
        {
            string connStr = ConfigurationManager
       .ConnectionStrings["ConexionRestaurante"]
       .ConnectionString;

            string query = @"SELECT 
                        DC.Id_Producto,
                        P.Nomb_Producto AS Producto,
                        DC.Cantidad,
                        DC.Precio,
                        DC.Subtotal AS Total
                     FROM DETALLE_CUENTA DC
                     INNER JOIN PRODUCTOS P 
                         ON P.Id_Producto = DC.Id_Producto
                     WHERE DC.Id_Cuenta = @IdCuenta";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@IdCuenta", idCuenta);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DgvComanda.DataSource = dt;

                if (DgvComanda.Columns.Contains("Id_Producto"))
                    DgvComanda.Columns["Id_Producto"].Visible = false;

                foreach (DataGridViewColumn col in DgvComanda.Columns)
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (DgvComanda.Columns.Contains("Precio"))
                    DgvComanda.Columns["Precio"].DefaultCellStyle.Format = "N2";

                if (DgvComanda.Columns.Contains("Total"))
                    DgvComanda.Columns["Total"].DefaultCellStyle.Format = "N2";

                CalcularTotales();
            }
        }

        private void CalcularTotales()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in DgvComanda.Rows)
                if (row.Cells["Total"].Value != null)
                    subtotal += Convert.ToDecimal(row.Cells["Total"].Value);

            decimal descuento = subtotal * (descuentoPorcentaje / 100);
            decimal subtotalConDesc = subtotal - descuento;
            decimal impuesto = subtotalConDesc * 0.18m;
            decimal total = subtotalConDesc + impuesto;

            LblSubTotal.Text = subtotal.ToString("N2");
            LblDescuento.Text = descuento.ToString("N2");
            LblDesc.Text = $"{descuentoPorcentaje}%";
            LblImp.Text = "18%";
            LblImpuesto.Text = impuesto.ToString("N2");
            LblTotal.Text = total.ToString("N2");
        }

        private void CbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCuentas();
        }

        private void DgvCuentas_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvCuentas.CurrentRow == null)
                return;

            if (DgvCuentas.CurrentRow.Cells["Id_Cuenta"].Value == null)
                return;

            int idCuenta = Convert.ToInt32(DgvCuentas.CurrentRow.Cells["Id_Cuenta"].Value);

            CargarDetalleCuenta(idCuenta);
            CargarComanda(idCuenta);
        }

        private void GuardarComentario(int idCuenta)
        {
            string query = @"UPDATE CUENTAS 
                     SET Comentario = @Comentario
                     WHERE Id_Cuenta = @IdCuenta";

            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["ConexionRestaurante"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Comentario", RtbComentario.Text);
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void DiseñarTabla(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.FromArgb(224, 224, 224);

            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.DefaultCellStyle.Font = new Font("Times New Roman", 10);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.RowTemplate.Height = 30;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }

        private void RtbComentario_Leave(object sender, EventArgs e)
        {
            if (DgvCuentas.CurrentRow == null)
                return;

            int idCuenta = Convert.ToInt32(DgvCuentas.CurrentRow.Cells["Id_Cuenta"].Value);

            GuardarComentario(idCuenta);
        }
        private void FrmMesas_Activated(object sender, EventArgs e)
        {
            CargarCuentas();
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DgvComanda.CurrentRow == null)
                return;

            if (DgvCuentas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cuenta primero.");
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Eliminar este producto?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r != DialogResult.Yes)
                return;

            int idProducto = Convert.ToInt32(
                DgvComanda.CurrentRow.Cells["Id_Producto"].Value);

            int idCuenta = Convert.ToInt32(
                DgvCuentas.CurrentRow.Cells["Id_Cuenta"].Value);

            EliminarProductoBD(idCuenta, idProducto);

            CargarComanda(idCuenta);
        }
        private void EliminarProductoBD(int idCuenta, int idProducto)
        {
            string connStr = ConfigurationManager
        .ConnectionStrings["ConexionRestaurante"]
        .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmdCantidad = new SqlCommand(@"
                SELECT Cantidad 
                FROM DETALLE_CUENTA
                WHERE Id_Cuenta = @IdCuenta 
                AND Id_Producto = @IdProducto", conn);

                cmdCantidad.Parameters.AddWithValue("@IdCuenta", idCuenta);
                cmdCantidad.Parameters.AddWithValue("@IdProducto", idProducto);

                int cantidad = Convert.ToInt32(cmdCantidad.ExecuteScalar());

                if (cantidad > 1)
                {
                    SqlCommand cmdUpdate = new SqlCommand(@"
                    UPDATE DETALLE_CUENTA
                    SET Cantidad = Cantidad - 1
                    WHERE Id_Cuenta = @IdCuenta 
                    AND Id_Producto = @IdProducto", conn);

                    cmdUpdate.Parameters.AddWithValue("@IdCuenta", idCuenta);
                    cmdUpdate.Parameters.AddWithValue("@IdProducto", idProducto);

                    cmdUpdate.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmdDelete = new SqlCommand(@"
                    DELETE FROM DETALLE_CUENTA
                    WHERE Id_Cuenta = @IdCuenta 
                    AND Id_Producto = @IdProducto", conn);

                    cmdDelete.Parameters.AddWithValue("@IdCuenta", idCuenta);
                    cmdDelete.Parameters.AddWithValue("@IdProducto", idProducto);

                    cmdDelete.ExecuteNonQuery();
                }
            }
        }

        private void BtnEliminarCuenta_Click(object sender, EventArgs e)
        {
            if (DgvCuentas.CurrentRow == null)
                return;

            DialogResult r = MessageBox.Show(
                "¿Seguro que desea eliminar esta cuenta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r != DialogResult.Yes)
                return;

            int idCuenta = Convert.ToInt32(
                DgvCuentas.CurrentRow.Cells["Id_Cuenta"].Value);

            EliminarCuentaBD(idCuenta);

            CargarCuentas();
        }

        private void EliminarCuentaBD(int idCuenta)
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmdDetalle = new SqlCommand(@"
                DELETE FROM DETALLE_CUENTA
                WHERE Id_Cuenta = @IdCuenta", conn);

                cmdDetalle.Parameters.AddWithValue("@IdCuenta", idCuenta);
                cmdDetalle.ExecuteNonQuery();

                SqlCommand cmdCuenta = new SqlCommand(@"
                DELETE FROM CUENTAS
                WHERE Id_Cuenta = @IdCuenta", conn);

                cmdCuenta.Parameters.AddWithValue("@IdCuenta", idCuenta);
                cmdCuenta.ExecuteNonQuery();
            }
        }

        private void BtnPrecio_Click(object sender, EventArgs e)
        {
            FrmPrecios frm = new FrmPrecios(this);
            frm.Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAbrirCuenta_Click(object sender, EventArgs e)
        {
            Sesion.IdUsuario = 1;
            Sesion.NombreUsuario = "MARCOS";
            Sesion.IdRol = 2;

            FrmCuentas frm = new FrmCuentas(this);
            frm.Show();
            this.Hide();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (DgvCuentas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cuenta primero",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idCuenta = Convert.ToInt32(
                DgvCuentas.CurrentRow.Cells["Id_Cuenta"].Value);

            FrmCapturaProductos frm = new FrmCapturaProductos(idCuenta);
            frm.ShowDialog();

            CargarComanda(idCuenta);
        }

        private void BtnDescuento_Click(object sender, EventArgs e)
        {
            if (DgvCuentas.CurrentRow == null)
                return;

            int idCuenta = Convert.ToInt32(
                DgvCuentas.CurrentRow.Cells["Id_Cuenta"].Value);

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el porcentaje de descuento:",
                "Descuento",
                "0");

            if (decimal.TryParse(input, out decimal valor))
            {
                if (valor < 0 || valor > 100)
                {
                    MessageBox.Show("Ingrese un valor entre 0 y 100");
                    return;
                }

                descuentoPorcentaje = valor;

                GuardarDescuento(idCuenta, valor);
                CargarComanda(idCuenta);
            }
        }

        private void GuardarDescuento(int idCuenta, decimal porcentaje)
        {
            string query = @"UPDATE DETALLE_CUENTA 
                     SET Descuento = (Cantidad * Precio) * (@Porcentaje / 100)
                     WHERE Id_Cuenta = @IdCuenta";

            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["ConexionRestaurante"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Porcentaje", porcentaje);
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void BtnPagarCuenta_Click(object sender, EventArgs e)
        {

            if (DgvCuentas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cuenta");
                return;
            }

            int idCuenta = Convert.ToInt32(
                DgvCuentas.CurrentRow.Cells["Id_Cuenta"].Value);

            decimal total = Convert.ToDecimal(LblTotal.Text);

            FrmPagarCuenta frm = new FrmPagarCuenta(idCuenta, total);

            frm.NumeroCuenta = LblCuenta.Text;
            frm.NombreMesero = LblNombMesero.Text;
            frm.NombreArea = LblNombArea.Text;
            frm.CantidadPersonas = int.Parse(LblPersonas.Text);
            frm.Impuesto = decimal.Parse(LblImpuesto.Text);
            frm.DgvComanda = DgvComanda;

            frm.ShowDialog();

            CargarCuentas();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (DgvCuentas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cuenta");
                return;
            }

            ConfigurarTicket();

            int idCuenta = Convert.ToInt32(
                DgvCuentas.CurrentRow.Cells["Id_Cuenta"].Value);

            idCuentaImprimir = idCuenta;

            documento.PrintPage -= ImprimirTicket;
            documento.PrintPage += ImprimirTicket;

            PaperSize ps = new PaperSize("Ticket", anchoTicket, 1000);
            documento.DefaultPageSettings.PaperSize = ps;

            PrintPreviewDialog vista = new PrintPreviewDialog
            {
                Document = documento,
                Width = 400,
                Height = 600
            };

            DialogResult r = vista.ShowDialog();

            if (r == DialogResult.OK || r == DialogResult.Yes)
            {
                try
                {
                    documento.Print();

                    ActualizarImpresa(idCuenta, true);

                    CargarCuentas();

                    foreach (DataGridViewRow row in DgvCuentas.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["Id_Cuenta"].Value) == idCuenta)
                        {
                            row.Cells["Impresa"].Value = true;
                            row.Selected = true;
                            break;
                        }
                    }

                    MessageBox.Show("Cuenta impresa correctamente ✔");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al imprimir: " + ex.Message);
                }
            }
        }

        private void ImprimirTicket(object sender, PrintPageEventArgs e)
        {
            float y = 10;
            Font titulo = new Font("Times New Roman", 14, FontStyle.Bold);
            Font subtitulo = new Font("Arial", 9, FontStyle.Bold);
            Font normal = new Font("Consolas", 9);
            Font negrita = new Font("Consolas", 10, FontStyle.Bold);
            StringFormat centro = new StringFormat { Alignment = StringAlignment.Center };
            StringFormat derecha = new StringFormat { Alignment = StringAlignment.Far };

            int colProducto = 0;
            int colCantidad = (int)(anchoTicket * 0.55);
            int colTotal = anchoTicket - 5;

            string logoPath = Application.StartupPath + @"\Img\Logo.png";
            if (System.IO.File.Exists(logoPath))
            {
                using (Image logo = Image.FromFile(logoPath))
                {
                    int maxLogoWidth = anchoTicket - 20;
                    float aspectRatio = (float)logo.Width / logo.Height;
                    int logoWidth = maxLogoWidth;
                    int logoHeight = (int)(logoWidth / aspectRatio);
                    int xLogo = (anchoTicket - logoWidth) / 2;
                    e.Graphics.DrawImage(logo, xLogo, y, logoWidth, logoHeight);
                    y += logoHeight + 5;
                }
            }

            // Encabezado
            e.Graphics.DrawString("CUPEDIARUM RESTAURANT", titulo, Brushes.Black, anchoTicket / 2, y, centro);
            y += 25;
            e.Graphics.DrawString("Fantino, República Dominicana", normal, Brushes.Black, anchoTicket / 2, y, centro);
            y += 18;
            e.Graphics.DrawString("Tel: 809-000-0000", normal, Brushes.Black, anchoTicket / 2, y, centro);
            y += 25;
            e.Graphics.DrawString("********** PRECUENTA **********", negrita, Brushes.Black, anchoTicket / 2, y, centro);
            y += 30;

            // Info de cuenta
            e.Graphics.DrawString("Cuenta: " + LblCuenta.Text, normal, Brushes.Black, 0, y); y += 18;
            e.Graphics.DrawString("Mesero: " + LblNombMesero.Text, normal, Brushes.Black, 0, y); y += 18;
            e.Graphics.DrawString("Area: " + LblNombArea.Text, normal, Brushes.Black, 0, y); y += 18;
            e.Graphics.DrawString("Personas: " + LblPersonas.Text, normal, Brushes.Black, 0, y); y += 18;
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), normal, Brushes.Black, 0, y); y += 25;

            e.Graphics.DrawString("------------------------------------------", normal, Brushes.Black, 0, y); y += 20;

            // Productos
            e.Graphics.DrawString("Producto", subtitulo, Brushes.Black, colProducto, y);
            e.Graphics.DrawString("Cant", subtitulo, Brushes.Black, colCantidad, y);
            e.Graphics.DrawString("Total", subtitulo, Brushes.Black, colTotal, y, derecha); y += 20;
            e.Graphics.DrawString("------------------------------------------", normal, Brushes.Black, 0, y); y += 20;

            foreach (DataGridViewRow row in DgvComanda.Rows)
            {
                if (row.Cells["Producto"].Value == null) continue;
                string producto = row.Cells["Producto"].Value.ToString();
                string cantidad = row.Cells["Cantidad"].Value.ToString();
                string total = Convert.ToDecimal(row.Cells["Total"].Value).ToString("N2");
                e.Graphics.DrawString(producto, normal, Brushes.Black, colProducto, y);
                e.Graphics.DrawString(cantidad, normal, Brushes.Black, colCantidad, y);
                e.Graphics.DrawString(total, normal, Brushes.Black, colTotal, y, derecha);
                y += 20;
                if (y > e.MarginBounds.Bottom) { e.HasMorePages = true; return; }
            }

            y += 10;
            e.Graphics.DrawString("------------------------------------------", normal, Brushes.Black, 0, y); y += 20;

            // Totales
            e.Graphics.DrawString("Subtotal:", normal, Brushes.Black, 0, y);
            e.Graphics.DrawString(LblSubTotal.Text, normal, Brushes.Black, colTotal, y, derecha); y += 20;
            e.Graphics.DrawString("Descuento:", normal, Brushes.Black, 0, y);
            e.Graphics.DrawString(LblDescuento.Text + " (" + LblDesc.Text + ")", normal, Brushes.Black, colTotal, y, derecha); y += 20;
            e.Graphics.DrawString("ITBIS (18%):", normal, Brushes.Black, 0, y);
            e.Graphics.DrawString(LblImpuesto.Text, normal, Brushes.Black, colTotal, y, derecha); y += 25;
            e.Graphics.DrawString("TOTAL:", negrita, Brushes.Black, 0, y);
            e.Graphics.DrawString(LblTotal.Text, negrita, Brushes.Black, colTotal, y, derecha); y += 40;

            // Pie
            e.Graphics.DrawString("ESTO NO ES UNA FACTURA FISCAL", normal, Brushes.Black, anchoTicket / 2, y, centro); y += 18;
            e.Graphics.DrawString("Gracias por su visita", normal, Brushes.Black, anchoTicket / 2, y, centro); y += 18;
            e.Graphics.DrawString("Vuelva pronto!", normal, Brushes.Black, anchoTicket / 2, y, centro);
        }

        private void ConfigurarTicket()
        {
            string tipo = "80mm"; 
            anchoTicket = tipo == "58mm" ? 230 : 300;
        }
    }
}