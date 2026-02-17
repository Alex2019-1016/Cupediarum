using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Cupediarum
{
    public partial class FrmCantidadPersonas : Form
    {
        private int idCuenta;

        public FrmCantidadPersonas(int idCuentaRecibida)
        {
            InitializeComponent();
            idCuenta = idCuentaRecibida;
        }


        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtCantPersonas.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de personas",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            string query = @"UPDATE CUENTAS
                     SET Cantidad_Personas = @cantidad
                     WHERE Id_Cuenta = @idCuenta";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@idCuenta", idCuenta);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    FrmDatosCuenta frm = new FrmDatosCuenta(idCuenta);
                    frm.Show();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar cantidad: " + ex.Message);
                }
            }
        }
    }
}
