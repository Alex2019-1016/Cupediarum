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
    public partial class FrmDatosCuenta : Form
    {
        private readonly int idCuenta;
        private readonly Form formularioAnterior;

        public FrmDatosCuenta(int idCuentaRecibida, Form anterior)
        {
            InitializeComponent();
            idCuenta = idCuentaRecibida;
            formularioAnterior = anterior;
            CargarDatosCuenta();
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
                SELECT 
                    C.Nomb_Cuenta,
                    C.Cantidad_Personas,
                    C.FechaApertura,
                    U.Nomb_Usuario,
                    C.Id_Area,
                    A.Nomb_Area,
                    C.Id_Mesa
                FROM CUENTAS C
                INNER JOIN USUARIOS U ON C.Id_Usuario = U.Id_Usuario
                LEFT JOIN AREAS A ON C.Id_Area = A.Id_Area
                WHERE C.Id_Cuenta = @IdCuenta";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Nombre de la cuenta
                            BtnCuenta.Text = reader["Nomb_Cuenta"].ToString();

                            // Cantidad de personas
                            BtnPersonas.Text = reader["Cantidad_Personas"].ToString();

                            // Nombre del mesero
                            TxtNombMesero.Text = reader["Nomb_Usuario"].ToString();

                            // Área
                            if (reader["Id_Area"] != DBNull.Value)
                            {
                                TxtIDArea.Text = reader["Id_Area"].ToString();
                                LblNombArea.Text = reader["Nomb_Area"].ToString();
                            }
                            else
                            {
                                TxtIDArea.Text = "0";
                                LblNombArea.Text = "Sin asignar";
                            }

                            // Mesa
                            if (reader["Id_Mesa"] != DBNull.Value)
                            {
                                TxtIDMesa.Text = reader["Id_Mesa"].ToString();
                            }
                            else
                            {
                                TxtIDMesa.Text = "";
                            }

                            // Fecha
                            if (reader["FechaApertura"] != DBNull.Value)
                            {
                                DateTime fecha = Convert.ToDateTime(reader["FechaApertura"]);
                                DtpFecha.Value = fecha;
                            }

                            // Solo lectura
                            TxtNombMesero.ReadOnly = true;
                            TxtIDArea.ReadOnly = true;
                            TxtIDMesa.ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void BtnAbrirMesa_Click(object sender, EventArgs e)
        {
            FrmCapturaProductos frm = new FrmCapturaProductos(idCuenta, formularioAnterior);
            frm.Show();
            this.Hide();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FrmCuentas frm = new FrmCuentas(formularioAnterior);
            frm.Show();
            this.Close();
        }
    }
}
