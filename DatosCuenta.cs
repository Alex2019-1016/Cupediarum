using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Cupediarum
{
    public partial class FrmDatosCuenta : Form
    {
        private int idCuenta;

        public FrmDatosCuenta(int idCuentaRecibida)
        {
            InitializeComponent();
            idCuenta = idCuentaRecibida;
            CargarDatosCuenta();
            CargarAreas();
        }

        private void CargarAreas()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT Id_Area, Nomb_Area FROM AREAS WHERE Estado = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    CboxAreaSelector.DataSource = dt;
                    CboxAreaSelector.DisplayMember = "Nomb_Area";
                    CboxAreaSelector.ValueMember = "Id_Area";
                }
            }
        }

        private void CargarDatosCuenta()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
            SELECT C.Cantidad_Personas,
                   C.Id_Cuenta,
                   A.Id_Area,
                   A.Nomb_Area
            FROM CUENTAS C
            LEFT JOIN MESAS M ON C.Id_Mesa = M.Id_Mesa
            LEFT JOIN AREAS A ON M.Id_Area = A.Id_Area
            WHERE C.Id_Cuenta = @IdCuenta";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label2.Text = reader["Cantidad_Personas"].ToString();
                            label1.Text = reader["Id_Cuenta"].ToString();

                            if (reader["Id_Area"] != DBNull.Value)
                                TxtIDArea.Text = reader["Id_Area"].ToString();
                            else
                                TxtIDArea.Text = "TO GO";
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatosCuenta_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbrirMesa_Click(object sender, EventArgs e)
        {
            FrmCapturaProductos frm = new FrmCapturaProductos();
            frm.Show();
            this.Hide();
        }

        private void TxtNombMesero_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIDArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNombArea_Click(object sender, EventArgs e)
        {

        }

        private void TxtIDMesa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void CboxAreaSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboxAreaSelector.SelectedValue == null)
                return;

            int idArea = Convert.ToInt32(CboxAreaSelector.SelectedValue);

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Buscar mesa disponible
                    string queryMesa = @"
                SELECT TOP 1 Id_Mesa
                FROM MESAS
                WHERE Id_Area = @IdArea
                  AND Estado = 'Disponible'";

                    int idMesa;

                    using (SqlCommand cmd = new SqlCommand(queryMesa, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@IdArea", idArea);
                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("No hay mesas disponibles en esa área");
                            transaction.Rollback();
                            return;
                        }

                        idMesa = Convert.ToInt32(result);
                    }

                    // Actualizar cuenta
                    string updateCuenta = @"
                UPDATE CUENTAS
                SET Id_Mesa = @IdMesa
                WHERE Id_Cuenta = @IdCuenta";

                    using (SqlCommand cmd = new SqlCommand(updateCuenta, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@IdMesa", idMesa);
                        cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
                        cmd.ExecuteNonQuery();
                    }

                    // Marcar mesa ocupada
                    string ocuparMesa = @"
                UPDATE MESAS
                SET Estado = 'Ocupada'
                WHERE Id_Mesa = @IdMesa";

                    using (SqlCommand cmd = new SqlCommand(ocuparMesa, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@IdMesa", idMesa);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    TxtIDArea.Text = idArea.ToString();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
