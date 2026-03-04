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
        }

        private void CargarAreas()
        {
            string query = @"SELECT Id_Area, Nomb_Area
                     FROM AREAS
                     WHERE Estado = 1
                     ORDER BY Nomb_Area ASC";

            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["ConexionRestaurante"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                CbArea.DataSource = dt;
                CbArea.DisplayMember = "Nomb_Area";
                CbArea.ValueMember = "Id_Area";
                CbArea.SelectedIndex = -1;
            }
        }

        private void CbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbArea.SelectedValue == null)
                return;

            if (int.TryParse(CbArea.SelectedValue.ToString(), out int idArea))
            {
                CargarCuentas(idArea, TxtBuscarCuentas.Text);
            }
        }
        private void CargarCuentas(int idArea, string filtro)
        {
            string query = @"
        SELECT 
            C.Id_Cuenta,
            C.Nomb_Cuenta AS CUENTA,
            U.Nomb_Usuario AS MESERO,
            C.Impresa
        FROM CUENTAS C
        INNER JOIN USUARIOS U 
            ON C.Id_Usuario = U.Id_Usuario
        WHERE C.Id_Area = @IdArea
        AND C.Nomb_Cuenta LIKE @Filtro
        ORDER BY C.Nomb_Cuenta ASC";

            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["ConexionRestaurante"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdArea", idArea);
                cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DgvCuentas.AutoGenerateColumns = true;
                DgvCuentas.DataSource = dt;

                DgvCuentas.Columns["Id_Cuenta"].Visible = false;

                DgvCuentas.Columns["CUENTA"].HeaderText = "Nombre Cuenta";
                DgvCuentas.Columns["MESERO"].HeaderText = "Mesero";
                DgvCuentas.Columns["Impresa"].HeaderText = "Impresa";

                LblCantCuentas.Text = "Cuentas: " + dt.Rows.Count.ToString();
            }
        }

        private void TxtBuscarCuentas_TextChanged(object sender, EventArgs e)
        {
            if (CbArea.SelectedValue == null ||
        CbArea.SelectedValue is DataRowView)
                return;

            if (int.TryParse(CbArea.SelectedValue.ToString(), out int idArea))
            {
                CargarCuentas(idArea, TxtBuscarCuentas.Text);
            }
        }

        private void DgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (DgvCuentas.Columns[e.ColumnIndex].Name == "Impresa")
            {
                int idCuenta = Convert.ToInt32(
                    DgvCuentas.Rows[e.RowIndex].Cells["Id_Cuenta"].Value);

                bool impresa = Convert.ToBoolean(
                    DgvCuentas.Rows[e.RowIndex].Cells["Impresa"].Value);

                ActualizarImpresa(idCuenta, impresa);
            }
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
    }
}
