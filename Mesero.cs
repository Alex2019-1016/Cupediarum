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
    public partial class FrmMesero : Form
    {
        private bool meseroAutenticado = false;
        public FrmMesero()
        {
            InitializeComponent();
        }

        private void CargarCuentas()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query;

                if (Sesion.IdRol == 1) // ADMIN
                {
                    query = @"SELECT Id_Cuenta, FechaApertura, EstadoCuenta
                              FROM CUENTAS
                              WHERE EstadoCuenta = 'Abierta'
                              ORDER BY FechaApertura DESC";
                }
                else // MESERO
                {
                    query = @"SELECT Id_Cuenta, FechaApertura, EstadoCuenta
                              FROM CUENTAS
                              WHERE Id_Usuario = @IdUsuario
                                AND EstadoCuenta = 'Abierta'
                              ORDER BY FechaApertura DESC";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (Sesion.IdRol != 1)
                        cmd.Parameters.AddWithValue("@IdUsuario", Sesion.IdUsuario);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //dgvCuentas.DataSource = dt;
                }
            }
        }

        private void Mesero_Load(object sender, EventArgs e)
        {
            ConfigurarPlaceholder(TxtIDMesero, "Ingrese ID del mesero");
            ConfigurarPlaceholderPassword(TxtClave, "Ingrese contraseña");

            label2.Text = "Mesero: " + Sesion.NombreUsuario;
            CargarCuentas();
        }

        private void ConfigurarPlaceholderPassword(TextBox txt, string texto)
        {
            Font fuenteNormal = new Font("Times New Roman", 24, FontStyle.Bold);
            Font fuentePlaceholder = new Font("Times New Roman", 14, FontStyle.Italic);

            txt.Text = texto;
            txt.ForeColor = Color.Gray;
            txt.Font = fuentePlaceholder;
            txt.UseSystemPasswordChar = false;

            txt.Enter += (s, e) =>
            {
                if (txt.Text == texto)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                    txt.Font = fuenteNormal;
                    txt.UseSystemPasswordChar = true;
                }
            };

            txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.UseSystemPasswordChar = false;
                    txt.Text = texto;
                    txt.ForeColor = Color.Gray;
                    txt.Font = fuentePlaceholder;
                }
            };
        }

        private void ConfigurarPlaceholder(TextBox txt, string texto)
        {
            Font fuenteNormal = new Font("Times New Roman", 24, FontStyle.Bold);
            Font fuentePlaceholder = new Font("Times New Roman", 14, FontStyle.Italic);

            txt.Text = texto;
            txt.ForeColor = Color.Gray;
            txt.Font = fuentePlaceholder;

            txt.Enter += (s, e) =>
            {
                if (txt.Text == texto)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                    txt.Font = fuenteNormal;
                }
            };

            txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = texto;
                    txt.ForeColor = Color.Gray;
                    txt.Font = fuentePlaceholder;
                }
            };
        }

        

        private void Cuentas_Click(object sender, EventArgs e)
        {

            if (!meseroAutenticado)
            {
                MessageBox.Show("Debe autenticarse primero",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            FrmCuentas frm = new FrmCuentas();
            frm.ShowDialog();

            /*
            FrmCuentas frm = new FrmCuentas();
            frm.Show();
            this.Hide();
            */
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtIDMesero.ForeColor == Color.Gray || TxtClave.ForeColor == Color.Gray)
            {
                MessageBox.Show("Debe completar los campos",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TxtIDMesero.Text.Trim(), out int idMesero))
            {
                MessageBox.Show("El ID debe ser numérico",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string clave = TxtClave.Text.Trim();

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            string query = @"SELECT Id_Usuario, Nomb_Usuario, Id_Rol
                     FROM USUARIOS
                     WHERE Id_Usuario = @id
                       AND Clave = @clave
                       AND Estado = 1";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", idMesero);
                cmd.Parameters.AddWithValue("@clave", clave);

                try
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Sesion.IdUsuario = reader.GetInt32(0);
                            Sesion.NombreUsuario = reader.GetString(1);
                            Sesion.IdRol = reader.GetInt32(2);

                            meseroAutenticado = true;

                            label2.Text = "Mesero: " + Sesion.NombreUsuario;

                            MessageBox.Show("Mesero autenticado ✔",
                                            "Correcto",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            Cuentas.Enabled = true;
                            BtnMonitor.Enabled = true;

                            TxtIDMesero.Enabled = false;
                            TxtClave.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("ID o contraseña incorrectos",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
