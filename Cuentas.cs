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

namespace Cupediarum
{
    public partial class FrmCuentas : Form
    {
        public FrmCuentas()
        {
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            TxtNombMesero.Text = Sesion.NombreUsuario;
            TxtIDMesero.Text = Sesion.IdUsuario.ToString();

            CargarCuentas();
        }

        private void CargarCuentas()
        {
            FlpCuentas.Controls.Clear();

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query;

                if (Sesion.IdRol == 1) // ADMIN
                {
                    query = @"SELECT Id_Cuenta, FechaApertura
                      FROM CUENTAS
                      WHERE EstadoCuenta = 'Abierta'
                      ORDER BY FechaApertura DESC";
                }
                else
                {
                    query = @"SELECT Id_Cuenta, FechaApertura
                      FROM CUENTAS
                      WHERE Id_Usuario = @IdUsuario
                        AND EstadoCuenta = 'Abierta'
                      ORDER BY FechaApertura DESC";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (Sesion.IdRol != 1)
                        cmd.Parameters.AddWithValue("@IdUsuario", Sesion.IdUsuario);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int idCuenta = reader.GetInt32(0);
                        DateTime fecha = reader.GetDateTime(1);

                        Button btn = new Button();
                        btn.Width = 118;
                        btn.Height = 72;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 3;
                        btn.BackColor = Color.DarkGray;
                        btn.Font = new Font("Times New Roman", 10, FontStyle.Bold);

                        btn.Text = "Cuenta #" + idCuenta +
                                   "\n" + fecha.ToString("HH:mm");

                        btn.Tag = idCuenta;

                        btn.Click += BtnCuenta_Click;

                        FlpCuentas.Controls.Add(btn);
                    }
                }
            }
        }

        private void BtnCuenta_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int idCuenta = (int)btn.Tag;

            MessageBox.Show("Abrir cuenta: " + idCuenta);

            // Aquí luego abrirás FrmPedidos
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            FrmAgregarCuenta frm = new FrmAgregarCuenta();
            frm.Show();
            this.Hide();
        }

        private void TxtNombMesero_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIDMesero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void BtnPrecios_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
