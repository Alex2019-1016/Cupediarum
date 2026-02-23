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

        private int cuentaSeleccionada = 0;

        public int idMeseroSeleccionado = 0;
        public string nombreMeseroSeleccionado = "";

        public int idAreaSeleccionada = 0;

        string ConexionRestaurante = ConfigurationManager
            .ConnectionStrings["ConexionRestaurante"]
            .ConnectionString;

        private void MostrarDatosMesero()
        {
            TxtIDMesero.Text = idMeseroSeleccionado.ToString();
            TxtNombMesero.Text = nombreMeseroSeleccionado;
        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            MostrarDatosMesero();
            CargarCuentas();
            CargarAreas();
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

                if (Sesion.IdRol == 1) 
                {
                    query = @"SELECT Id_Cuenta, Nomb_Cuenta
                      FROM CUENTAS
                      WHERE EstadoCuenta = 'Abierta'
                      ORDER BY FechaApertura DESC";
                }
                else
                {
                    query = @"SELECT Id_Cuenta, Nomb_Cuenta
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
                        string nombreCuenta = reader.GetString(1);

                        Button btn = new Button();
                        btn.Width = 118;
                        btn.Height = 72;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = Color.Cyan;
                        btn.FlatAppearance.BorderSize = 3;
                        btn.BackColor = Color.LightCoral;
                        btn.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                        btn.BackgroundImage = Properties.Resources.FBAzul;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;

                        // 🔥 SOLO EL NOMBRE DE LA CUENTA
                        btn.Text = nombreCuenta;

                        btn.Tag = idCuenta; // importante para saber qué cuenta se clickeó

                        btn.Click += BtnCuenta_Click;

                        FlpCuentas.Controls.Add(btn);
                    }
                }
            }
        }


        private void BtnCuenta_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            cuentaSeleccionada = (int)btn.Tag;

            FrmCapturaProductos frm = new FrmCapturaProductos(cuentaSeleccionada, this);
            frm.Show();
            this.Hide();
        }

        private void CargarAreas()
        {
            FlpArea.Controls.Clear();

            using (SqlConnection cn = new SqlConnection(ConexionRestaurante))
            {
                cn.Open();
                string query = "SELECT IdArea, NombreArea FROM Areas";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Button btn = new Button();
                    btn.Width = 120;
                    btn.Height = 60;

                    btn.Text = dr["NombreArea"].ToString();
                    btn.Tag = Convert.ToInt32(dr["IdArea"]);

                    btn.BackColor = Color.FromArgb(64, 64, 64);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;

                    btn.Click += BtnArea_Click;

                    FlpArea.Controls.Add(btn);
                }
            }
        }
        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            FrmAgregarCuenta frm = new FrmAgregarCuenta(this);
            frm.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmMesero frm = new FrmMesero();
            frm.Show();
            this.Hide();
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            idAreaSeleccionada = (int)btn.Tag;
            RtbNombArea.Text = btn.Text;
        }
    }
}
