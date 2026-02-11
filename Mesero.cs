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

        private void Mesero_Load(object sender, EventArgs e)
        {

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
            string idMesero = TxtIDMesero.Text.Trim();
            string clave = TxtClave.Text.Trim();

            if (string.IsNullOrEmpty(idMesero) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Ingrese ID y contraseña",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

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
                            // Guardar sesión
                            Sesion.IdUsuario = reader.GetInt32(0);
                            Sesion.NombreUsuario = reader.GetString(1);
                            Sesion.IdRol = reader.GetInt32(2);

                            meseroAutenticado = true;

                            MessageBox.Show("Mesero autenticado ✔",
                                            "Correcto",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            // Activar botones
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
    }
}
