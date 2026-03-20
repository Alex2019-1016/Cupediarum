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
        private Form formularioPadre;

        public FrmDatosCuenta(int idCuentaRecibida, Form anterior, Form formularioPadre)
        {
            InitializeComponent();
            idCuenta = idCuentaRecibida;
            formularioAnterior = anterior;
            CargarDatosCuenta();
            this.formularioPadre = formularioPadre;
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
                            BtnCuenta.Text = reader["Nomb_Cuenta"].ToString();

                            BtnPersonas.Text = reader["Cantidad_Personas"].ToString();

                            TxtNombMesero.Text = reader["Nomb_Usuario"].ToString();

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


                            if (reader["FechaApertura"] != DBNull.Value)
                            {
                                DateTime fecha = Convert.ToDateTime(reader["FechaApertura"]);
                                DtpFecha.Value = fecha;
                            }

                            TxtNombMesero.ReadOnly = true;
                            TxtIDArea.ReadOnly = true;
                            
                        }
                    }
                }
            }
        }

        private void BtnAbrirMesa_Click(object sender, EventArgs e)
        {
            FrmCapturaProductos frm = new FrmCapturaProductos(idCuenta,formularioPadre);
            frm.ShowDialog();
            this.Close();
        }
    }
}
