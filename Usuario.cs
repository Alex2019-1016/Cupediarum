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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
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
                            int idUsuario = reader.GetInt32(0);
                            string nombreUsuario = reader.GetString(1);
                            int idRol = reader.GetInt32(2);

                            if (idRol == 3)
                            {
                                MessageBox.Show("Los meseros no tienen acceso a este módulo",
                                                "Acceso denegado",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                return;
                            }

                            Sesion.IdUsuario = idUsuario;
                            Sesion.NombreUsuario = nombreUsuario;
                            Sesion.IdRol = idRol;

                            MessageBox.Show("Usuario autenticado ✔",
                                            "Correcto",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            TxtClave.Enabled = false;

                            FrmMesas frm = new FrmMesas();
                            frm.ShowDialog();
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
            this.Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            TxtClave.Focus();
        }
    }
}
