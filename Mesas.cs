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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cupediarum
{
    public partial class FrmMesas : Form
    {
        public FrmMesas()
        {
            InitializeComponent();
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            CargarAreas();
            CargarCuentas();

            DiseñarTabla(DgvCuentas);
            DiseñarTabla(DgvComanda);
        }

        private void CargarAreas()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT Id_Area, Nomb_Area FROM AREAS";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow fila = dt.NewRow();
                fila["Id_Area"] = 0;
                fila["Nomb_Area"] = "TODAS LAS AREAS";
                dt.Rows.InsertAt(fila, 0);

                CbArea.DataSource = dt;
                CbArea.DisplayMember = "Nomb_Area";
                CbArea.ValueMember = "Id_Area";
                CbArea.SelectedIndex = 0;
            }
        }

        private void CargarCuentas()
        {
            if (CbArea.SelectedValue == null || CbArea.SelectedValue is DataRowView)
                return;

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            int area = Convert.ToInt32(CbArea.SelectedValue);

            string query = @"SELECT 
                        C.Id_Cuenta,
                        C.Nomb_Cuenta,
                        CASE 
                            WHEN C.Impresa = 1 THEN 'SI'
                            ELSE 'NO'
                        END AS Impresa,
                        U.Nomb_Usuario AS Usuario,
                        R.Nomb_Rol AS Rol
                    FROM CUENTAS C
                    INNER JOIN USUARIOS U 
                        ON U.Id_Usuario = C.Id_Usuario
                    INNER JOIN ROLES R
                        ON R.Id_Rol = U.Id_Rol
                    WHERE C.Estado = 1
                    AND C.Nomb_Cuenta LIKE @buscar";

            if (area != 0)
            {
                query += " AND C.Id_Area = @area";
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue("@buscar", "%" + TxtBuscarCuentas.Text + "%");

                if (area != 0)
                {
                    da.SelectCommand.Parameters.AddWithValue("@area", area);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                DgvCuentas.AutoGenerateColumns = true;
                DgvCuentas.DataSource = dt;
                DgvCuentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DgvCuentas.MultiSelect = false;

                if (DgvCuentas.Columns.Contains("Id_Cuenta"))
                {
                    DgvCuentas.Columns["Id_Cuenta"].Visible = false;
                }

                DgvCuentas.Columns["Nomb_Cuenta"].HeaderText = "CUENTA";
                DgvCuentas.Columns["Impresa"].HeaderText = "IMPRESA";
                DgvCuentas.Columns["Usuario"].HeaderText = "USUARIO";
                DgvCuentas.Columns["Rol"].HeaderText = "ROL";

                LblCantCuentas.Text = dt.Rows.Count.ToString();
            }
        }

        private void TxtBuscarCuentas_TextChanged(object sender, EventArgs e)
        {
            CargarCuentas();
        }
        
        private void ActualizarImpresa(int idCuenta, bool impresa)
        {
            string query = "UPDATE CUENTAS SET Impresa = @Impresa WHERE Id_Cuenta = @IdCuenta";

            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["ConexionRestaurante"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))

            {
                cmd.Parameters.AddWithValue("@Impresa", impresa);
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void CargarDetalleCuenta(int idCuenta)
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            string query = @"SELECT 
                        C.Nomb_Cuenta,
                        C.Cantidad_Personas,
                        C.FechaApertura,
                        A.Nomb_Area,
                        U.Nomb_Usuario
                    FROM CUENTAS C
                    INNER JOIN AREAS A 
                        ON C.Id_Area = A.Id_Area
                    LEFT JOIN MESAS M 
                        ON C.Id_Mesa = M.Id_Mesa
                    INNER JOIN USUARIOS U 
                        ON C.Id_Usuario = U.Id_Usuario
                    WHERE C.Id_Cuenta = @IdCuenta";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    LblCuenta.Text = reader["Nomb_Cuenta"].ToString();
                    LblPersonas.Text = reader["Cantidad_Personas"].ToString();
                    LblNombArea.Text = reader["Nomb_Area"].ToString();
                    LblNombMesero.Text = reader["Nomb_Usuario"].ToString();

                    DtpFecha.Value = Convert.ToDateTime(reader["FechaApertura"]);
                    DtpFecha.Enabled = false;
                }

                reader.Close();
            }
        }
         private void CargarComanda(int idCuenta)
        {
            string connStr = ConfigurationManager
            .ConnectionStrings["ConexionRestaurante"]
            .ConnectionString;

            string query = @"SELECT 
                        P.Nomb_Producto AS Producto,
                        DC.Cantidad,
                        DC.Precio,
                        (DC.Cantidad * DC.Precio) AS Total
                    FROM DETALLE_CUENTA DC
                    INNER JOIN PRODUCTOS P 
                        ON P.Id_Producto = DC.Id_Producto
                    WHERE DC.Id_Cuenta = @IdCuenta";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@IdCuenta", idCuenta);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DgvComanda.DataSource = dt;

                foreach (DataGridViewColumn col in DgvComanda.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                DgvComanda.Columns["Precio"].DefaultCellStyle.Format = "N2";
                DgvComanda.Columns["Total"].DefaultCellStyle.Format = "N2";
            }
        }

        private void CbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCuentas();
        }

        private void DgvCuentas_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvCuentas.CurrentRow == null)
                return;

            if (DgvCuentas.CurrentRow.Cells["Id_Cuenta"].Value == null)
                return;

            int idCuenta = Convert.ToInt32(DgvCuentas.CurrentRow.Cells["Id_Cuenta"].Value);

            CargarDetalleCuenta(idCuenta);
            CargarComanda(idCuenta);
        }

        private void DiseñarTabla(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.FromArgb(64, 64, 64);

            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.DefaultCellStyle.Font = new Font("Times New Roman", 10);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.RowTemplate.Height = 30;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }
    }
}
