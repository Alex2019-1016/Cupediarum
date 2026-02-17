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
using static System.Collections.Specialized.BitVector32;

namespace Cupediarum
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text.Trim();
            string clave = TxtClave.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Ingrese usuario y contraseña",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            string query = @"SELECT Id_Usuario, Nomb_Usuario, Id_Rol
                     FROM dbo.USUARIOS
                     WHERE Nomb_Usuario = @usuario
                       AND Clave = @clave
                       AND Estado = 1";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                try
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Si ya hay sesión activa
                            if (Sesion.HaySesionActiva())
                            {
                                DialogResult r = MessageBox.Show(
                                    $"Ya hay un usuario logeado: {Sesion.NombreUsuario}\n¿Desea reemplazarlo?",
                                    "Reemplazar sesión",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);

                                if (r == DialogResult.No)
                                    return;
                            }

                            // Guardar sesión
                            Sesion.IdUsuario = reader.GetInt32(0);
                            Sesion.NombreUsuario = reader.GetString(1);
                            Sesion.IdRol = reader.GetInt32(2);

                            MessageBox.Show("Bienvenido ✔",
                                            "Acceso concedido",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            FrmMenuPrincipal frm = new FrmMenuPrincipal();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
    }

}




