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
                        btn.FlatAppearance.BorderSize = 3;
                        btn.BackColor = Color.DarkGray;
                        btn.Font = new Font("Times New Roman", 10, FontStyle.Bold);

                        
                        btn.Text = nombreCuenta;

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
            cuentaSeleccionada = (int) btn.Tag;

            FrmCapturaProductos frm = new FrmCapturaProductos(cuentaSeleccionada, this);
            frm.Show();
            this.Hide();
        }

        private void CargarAreas()
        {
            if (cuentaSeleccionada == 0)
                return;

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                int? areaActualId = null;
                string nombreAreaActual = "";


                string queryAreaActual = @"
            SELECT A.Id_Area, A.Nomb_Area
            FROM CUENTAS C
            LEFT JOIN MESAS M ON C.Id_Mesa = M.Id_Mesa
            LEFT JOIN AREAS A ON M.Id_Area = A.Id_Area
            WHERE C.Id_Cuenta = @IdCuenta";

                using (SqlCommand cmd = new SqlCommand(queryAreaActual, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCuenta", cuentaSeleccionada);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            areaActualId = reader.GetInt32(0);
                            nombreAreaActual = reader.GetString(1);
                        }
                    }
                }

                RtbNombArea.Text = areaActualId == null ? "TO GO" : nombreAreaActual;

              
                string queryAreas = "SELECT Id_Area, Nomb_Area FROM AREAS WHERE Estado = 1";

                using (SqlCommand cmd = new SqlCommand(queryAreas, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Button[] botones = { BtnArea1, BtnArea2, BtnArea3, BtnArea4 };
                    int i = 0;

                    while (reader.Read() && i < botones.Length)
                    {
                        int idArea = reader.GetInt32(0);
                        string nombre = reader.GetString(1);

                        botones[i].Text = nombre;
                        botones[i].Tag = idArea;
                        botones[i].BackColor = Color.DarkGray;

                        if (areaActualId != null && idArea == areaActualId)
                            botones[i].BackColor = Color.LightGreen;

                        botones[i].Click -= BtnArea_Click;
                        botones[i].Click += BtnArea_Click;

                        i++;
                    }
                }
            }
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            if (cuentaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una cuenta primero");
                return;
            }

            Button btn = sender as Button;
            int idArea = (int)btn.Tag;

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int? mesaAnterior = null;

                 
                    string queryMesaAnterior = @"
                SELECT Id_Mesa
                FROM CUENTAS
                WHERE Id_Cuenta = @IdCuenta";

                    using (SqlCommand cmdPrev = new SqlCommand(queryMesaAnterior, conn, transaction))
                    {
                        cmdPrev.Parameters.AddWithValue("@IdCuenta", cuentaSeleccionada);
                        object result = cmdPrev.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                            mesaAnterior = Convert.ToInt32(result);
                    }

         
                    string queryMesaNueva = @"
                SELECT TOP 1 Id_Mesa
                FROM MESAS
                WHERE Id_Area = @IdArea
                  AND Estado = 'Disponible'";

                    int idMesaNueva;

                    using (SqlCommand cmdNueva = new SqlCommand(queryMesaNueva, conn, transaction))
                    {
                        cmdNueva.Parameters.AddWithValue("@IdArea", idArea);
                        object result = cmdNueva.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("No hay mesas disponibles en esta área");
                            transaction.Rollback();
                            return;
                        }

                        idMesaNueva = Convert.ToInt32(result);
                    }


                    if (mesaAnterior != null)
                    {
                        string liberar = @"
                    UPDATE MESAS
                    SET Estado = 'Disponible'
                    WHERE Id_Mesa = @IdMesa";

                        using (SqlCommand cmd = new SqlCommand(liberar, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@IdMesa", mesaAnterior);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    
                    string updateCuenta = @"
                UPDATE CUENTAS
                SET Id_Mesa = @IdMesa
                WHERE Id_Cuenta = @IdCuenta";

                    using (SqlCommand cmd = new SqlCommand(updateCuenta, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@IdMesa", idMesaNueva);
                        cmd.Parameters.AddWithValue("@IdCuenta", cuentaSeleccionada);
                        cmd.ExecuteNonQuery();
                    }

                    
                    string ocuparMesa = @"
                UPDATE MESAS
                SET Estado = 'Ocupada'
                WHERE Id_Mesa = @IdMesa";

                    using (SqlCommand cmd = new SqlCommand(ocuparMesa, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@IdMesa", idMesaNueva);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    CargarAreas();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            FrmAgregarCuenta frm = new FrmAgregarCuenta(this);
            frm.Show();
            this.Hide();
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            FrmMesero frm = new FrmMesero(this);
            frm.Show();
            this.Hide();
        }
    }
}
