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
        private readonly Form formularioAnterior;

        public FrmMesero(Form anterior)
        {
            InitializeComponent();
            formularioAnterior = anterior;
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

                if (Sesion.IdRol == 1)
                {
                    query = @"SELECT Id_Cuenta, FechaApertura, EstadoCuenta
                              FROM CUENTAS
                              WHERE EstadoCuenta = 'Abierta'
                              ORDER BY FechaApertura DESC";
                }
                else
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


                }
            }
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtClave.ForeColor == Color.Gray || string.IsNullOrWhiteSpace(TxtClave.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña",
                                "Atención",
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
                     WHERE Clave = @clave
                       AND Estado = 1";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
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


                            MessageBox.Show("Mesero autenticado ✔",
                                            "Correcto",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            TxtClave.Enabled = false;

                            FrmCuentas frm = new FrmCuentas(this);
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta",
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Close();
        }

        private void TecladoNumerico_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TxtClave.Text += btn.Text;
        }

        private void FrmMesero_Load(object sender, EventArgs e)
        {
            AsignarEventosNumericos(this);
        }

        private void AsignarEventosNumericos(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is Button btn)
                {
                    if (btn.Name != "BtnAceptar" && btn.Name != "BtnCancelar" && btn.Name != "BtnBorrar")
                    {
                        btn.Click += TecladoNumerico_Click;
                    }
                }
                if (ctrl.HasChildren)
                    AsignarEventosNumericos(ctrl);
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (TxtClave.Text.Length > 0)
                TxtClave.Text = TxtClave.Text.Substring(0, TxtClave.Text.Length - 1);
        }
    }
}
