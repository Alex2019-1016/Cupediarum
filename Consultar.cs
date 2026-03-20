using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Cupediarum
{
    public partial class FrmConsultar : Form
    {
        private int idCuenta;

        public FrmConsultar(int idCuentaRecibida)
        {
            InitializeComponent();
            idCuenta = idCuentaRecibida;
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            CargarDatosCuenta();
            DiseñarTabla(DgvConsulta);

        }
        public void CargarDatosCuenta()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            decimal subtotal = 0;
            decimal descuentoTotal = 0;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
        SELECT 
            c.Nomb_Cuenta,
            c.FechaApertura,
            c.Cantidad_Personas,
            c.Impresa,
            c.Comentario,
            u.Nomb_Usuario AS Mesero,
            a.Nomb_Area,
            p.Nomb_Producto AS Producto,
            d.Cantidad,
            d.Precio,
            d.Descuento,
            d.Subtotal,
            d.Comentario AS Comentario
        FROM CUENTAS c
        INNER JOIN USUARIOS u ON c.Id_Usuario = u.Id_Usuario
        INNER JOIN AREAS a ON c.Id_Area = a.Id_Area
        INNER JOIN DETALLE_CUENTA d ON c.Id_Cuenta = d.Id_Cuenta
        INNER JOIN PRODUCTOS p ON d.Id_Producto = p.Id_Producto
        WHERE c.Id_Cuenta = @IdCuenta";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                    SqlDataReader dr = cmd.ExecuteReader();

                    DgvConsulta.Rows.Clear();

                    while (dr.Read())
                    {
                        LblCuenta.Text = dr["Nomb_Cuenta"].ToString();
                        LblNombMesero.Text = dr["Mesero"].ToString();
                        LblNombArea.Text = dr["Nomb_Area"].ToString();
                        LblPersonas.Text = dr["Cantidad_Personas"].ToString();
                        DtpFecha.Value = Convert.ToDateTime(dr["FechaApertura"]);
                        checkBox1.Checked = Convert.ToBoolean(dr["Impresa"]);
                        RtbComentario.Text = dr["Comentario"]?.ToString();

                        DgvConsulta.Rows.Add(
                            dr["Cantidad"],
                            dr["Producto"],
                            dr["Descuento"],
                            dr["Precio"],
                            dr["Subtotal"],
                            dr["Comentario"]
                        );

                        subtotal += Convert.ToDecimal(dr["Subtotal"]);
                        descuentoTotal += Convert.ToDecimal(dr["Descuento"]);
                    }
                }
            }

            decimal itbis = subtotal * 0.18m;
            decimal totalFinal = subtotal + itbis;

            LblSubTotal.Text = subtotal.ToString("N2");
            LblDescuento.Text = descuentoTotal.ToString("N2");
            LblImpuesto.Text = itbis.ToString("N2");
            LblImp.Text = "18%";
            LblTotal.Text = totalFinal.ToString("N2");
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

        private void BtnPrecio_Click(object sender, EventArgs e)
        {
            FrmPrecios frm = new FrmPrecios(this);
            frm.ShowDialog();
        }

        private void BtnAbrirCuenta_Click(object sender, EventArgs e)
        {
            FrmCuentas frm = new FrmCuentas(this, this);
            frm.Show();
            this.Hide();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmCapturaProductos frm = new FrmCapturaProductos(idCuenta, this);
            frm.ShowDialog();

            CargarDatosCuenta();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            string logoPath = Application.StartupPath + @"\Img\Logo.png";

            TicketHelper.Imprimir(idCuenta, logoPath);
        }
    }
}

