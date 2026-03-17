using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupediarum
{
    public partial class FrmPrecios : Form
    {
        private readonly Form formularioAnterior;
        private readonly string cadenaConexion = "Server=localhost;Database=CupediarumDB;Trusted_Connection=True;";
        public FrmPrecios(Form frmAnterior)
        {
            InitializeComponent();
            formularioAnterior = frmAnterior;
        }

        private void Precios_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarProductos();
        }
        private void ConfigurarGrid()
        {
            DgvPrecios.ReadOnly = true;
            DgvPrecios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPrecios.MultiSelect = false;
            DgvPrecios.RowHeadersVisible = false;
            DgvPrecios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPrecios.AllowUserToAddRows = false;

            DgvPrecios.EnableHeadersVisualStyles = false;

            DgvPrecios.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            DgvPrecios.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            DgvPrecios.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            DgvPrecios.DefaultCellStyle.SelectionBackColor = Color.Cyan;
            DgvPrecios.DefaultCellStyle.SelectionForeColor = Color.Black;

        }
        private void CargarProductos(string filtro = "")
        {
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                string query = @"
                SELECT 
                    P.Nomb_Producto AS DESCRIPCION_PRODUCTO,
                    P.Precio AS PRECIO,
                    C.Nomb_Categoria AS SUBCATEGORIA,
                    CP.Nomb_Categoria AS CATEGORIA
                FROM Productos P
                INNER JOIN Categorias C 
                    ON P.Id_Categoria = C.Id_Categoria
                LEFT JOIN Categorias CP 
                    ON C.Id_CategoriaPadre = CP.Id_Categoria
                WHERE P.Nomb_Producto LIKE @filtro
                ORDER BY P.Nomb_Producto ASC";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DgvPrecios.DataSource = dt;

                if (DgvPrecios.Columns.Count > 0)
                {
                    DgvPrecios.Columns["PRECIO"].FillWeight = 30;
                }
            }
        }

        private void TxtProductos_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(TxtBuscar.Text);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            formularioAnterior.Show();
            this.Close();
        }
    }
}
