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
    public partial class FrmAgregarCuenta : Form
    {
        public FrmAgregarCuenta()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void AbrirCuenta_Load(object sender, EventArgs e)
        {

        }

        private void PnlLetras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FrmCantidadPersonas frm = new FrmCantidadPersonas();
            frm.Show();
            this.Hide();
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {

            string nombreCuenta = RtbCuenta.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreCuenta))
            {
                MessageBox.Show("Ingrese nombre para la cuenta",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            string query = @"INSERT INTO CUENTAS 
                     (Nomb_Cuenta, Cantidad_Personas, Id_Mesa, Id_Usuario)
                     VALUES 
                     (@nombre, @cantidad, @mesa, @usuario)";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", nombreCuenta);
                cmd.Parameters.AddWithValue("@cantidad", 1); // provisional
                cmd.Parameters.AddWithValue("@mesa", DBNull.Value); // ToGo por ahora
                cmd.Parameters.AddWithValue("@usuario", Sesion.IdUsuario);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cuenta creada correctamente ✔",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear cuenta: " + ex.Message);
                }
            }

            
        }

        private void RtbCuenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
