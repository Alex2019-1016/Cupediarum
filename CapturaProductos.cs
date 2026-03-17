
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Cupediarum
{
    public partial class FrmCapturaProductos : Form
    {
        private int idCategoriaSeleccionada = 0;
        private int idSubCategoriaSeleccionada = 0;
        private decimal totalCuenta = 0;

        private readonly int idCuenta;

        public FrmCapturaProductos(int idCuentaRecibida)
        {
            InitializeComponent();
            idCuenta = idCuentaRecibida;

        }

        private void FrmCapturaProductos_Load_1(object sender, EventArgs e)
        {
            ConfigurarDgv();
            CargarCategoriasPrincipales();
            CargarDetalleExistente();
            CargarComentarioCuenta();
        }

        private void ConfigurarDgv()
        {
            DgvComanda.Rows.Clear();
            DgvComanda.AllowUserToAddRows = false;
        }

        private void CargarDetalleExistente()
        {
            string connStr = ConfigurationManager
        .ConnectionStrings["ConexionRestaurante"]
        .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(@"
        SELECT Id_Producto, Cantidad, Precio
        FROM DETALLE_CUENTA
        WHERE Id_Cuenta = @IdCuenta", conn))
            {
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idProducto = reader.GetInt32(0);
                    int cantidad = reader.GetInt32(1);
                    decimal precioUnitario = reader.GetDecimal(2);

                    decimal subtotal = precioUnitario * cantidad;

                    string nombre = ObtenerNombreProducto(idProducto);

                    DgvComanda.Rows.Add(
                        idProducto,     // 0
                        "1",            // 1 COMANDA
                        cantidad,       // 2 CANT
                        nombre,         // 3 DESCRIPCION
                        subtotal,       // 4 PRECIO
                        0               // 5 DESCUENTO
                    );
                }
            }

            CalcularTotal();
        }

        private string ObtenerNombreProducto(int idProducto)
        {
            string nombre = "";

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT Nomb_Producto FROM PRODUCTOS WHERE Id_Producto = @Id", conn))
            {
                cmd.Parameters.AddWithValue("@Id", idProducto);
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                    nombre = result.ToString();
            }

            return nombre;
        }

        private void CargarCategoriasPrincipales()
        {

            string query = @"SELECT Id_Categoria, Nomb_Categoria
                     FROM CATEGORIAS
                     WHERE Id_CategoriaPadre IS NULL";

            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["ConexionRestaurante"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1).ToUpper();

                    if (nombre == "POSTRES")
                        BtnPostres.Tag = id;

                    else if (nombre == "BEBIDAS")
                        BtnBebidas.Tag = id;

                    else if (nombre == "COMIDAS")
                        BtnComida.Tag = id;

                    else if (nombre == "OTROS")
                        BtnOtros.Tag = id;
                }
            }

            // Eventos fuera del while
            BtnPostres.Click += BtnCategoria_Click;
            BtnBebidas.Click += BtnCategoria_Click;
            BtnComida.Click += BtnCategoria_Click;
            BtnOtros.Click += BtnCategoria_Click;
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            idCategoriaSeleccionada = (int)btn.Tag;

            CargarSubCategorias(idCategoriaSeleccionada);

        }

        private void CargarSubCategorias(int idCategoria)
        {
            FlpSubCategorias.Controls.Clear();
            FlpProductos.Controls.Clear();

            string query = @"SELECT Id_Categoria, Nomb_Categoria
                     FROM CATEGORIAS
                     WHERE Id_CategoriaPadre = @IdCategoria
                     ORDER BY Nomb_Categoria ASC";

            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["ConexionRestaurante"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idSub = reader.GetInt32(0);
                    string nombreSub = reader.GetString(1);

                    Button btnSub = new Button
                    {
                        Text = nombreSub,
                        Tag = idSub,
                        Width = 133,
                        Height = 55,
                        Margin = new Padding(5),
                        BackColor = Color.LightCoral,
                        Font = new Font("Times New Roman", 10, FontStyle.Bold),
                        BackgroundImage = Properties.Resources.FondoAzul,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        FlatStyle = FlatStyle.Flat
                    };

                    btnSub.Click += BtnSubCategoria_Click;

                    FlpSubCategorias.Controls.Add(btnSub);
                }
            }
        }

        private void BtnSubCategoria_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            idSubCategoriaSeleccionada = (int)btn.Tag;

            CargarProductos(idSubCategoriaSeleccionada);
        }

        private void CargarProductos(int idSubCategoria)
        {
            FlpProductos.Controls.Clear();

            string query = @"SELECT Id_Producto, Nomb_Producto, Precio
                     FROM PRODUCTOS
                     WHERE Id_Categoria = @IdCategoria
                     ORDER BY Nomb_Producto ASC";

            using (SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["ConexionRestaurante"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdCategoria", idSubCategoria);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idProducto = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    decimal precio = reader.GetDecimal(2);

                    Button btn = new Button
                    {
                        Width = 150,
                        Height = 80,
                        Text = nombre + "\n$" + precio.ToString("N2"),
                        BackColor = Color.LightCoral,
                        Font = new Font("Times New Roman", 10, FontStyle.Bold),
                        BackgroundImage = Properties.Resources.FondoNaranja,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = new ProductoTemp
                        {
                            Id = idProducto,
                            Nombre = nombre,
                            Precio = precio
                        }
                    };

                    btn.Click += BtnProducto_Click;

                    FlpProductos.Controls.Add(btn);
                }
            }
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            ProductoTemp producto = (ProductoTemp)((Button)sender).Tag;

            bool encontrado = false;

            foreach (DataGridViewRow row in DgvComanda.Rows)
            {
                if (row.Cells[0].Value != null &&
                    Convert.ToInt32(row.Cells[0].Value) == producto.Id)
                {
                    int cantidad = Convert.ToInt32(row.Cells["CANT"].Value);
                    cantidad++;

                    row.Cells["CANT"].Value = cantidad;
                    row.Cells["PRECIO"].Value = cantidad * producto.Precio;

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                DgvComanda.Rows.Add(
                    producto.Id,
                    "1",
                    1,
                    producto.Nombre,
                    producto.Precio,
                    0
                );
            }

            CalcularTotal();
        }

        private void GuardarDetalleCuenta()
        {
            string comentario = RtbComent.Text;

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand deleteCmd = new SqlCommand(
                    "DELETE FROM DETALLE_CUENTA WHERE Id_Cuenta = @IdCuenta", conn))
                {
                    deleteCmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
                    deleteCmd.ExecuteNonQuery();
                }

                foreach (DataGridViewRow row in DgvComanda.Rows)
                {
                    if (row.Cells[0].Value == null)
                        continue;

                    int idProducto = Convert.ToInt32(row.Cells[0].Value);
                    int cantidad = Convert.ToInt32(row.Cells["CANT"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["PRECIO"].Value);

                    decimal precioUnitario = subtotal / cantidad;

                    string query = @"INSERT INTO DETALLE_CUENTA
                    (Id_Cuenta, Id_Producto, Cantidad, Precio)
                    VALUES
                    (@IdCuenta, @IdProducto, @Cantidad, @Precio)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@Precio", precioUnitario);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void CalcularTotal()
        {
            totalCuenta = 0;

            foreach (DataGridViewRow row in DgvComanda.Rows)
            {
                if (row.Cells["PRECIO"].Value != null)
                {
                    totalCuenta += Convert.ToDecimal(row.Cells["PRECIO"].Value);
                }
            }

            LblTotal.Text = "TOTAL: $" + totalCuenta.ToString("N2");
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            if (DgvComanda.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la comanda.");
                return;
            }

            try
            {
                GuardarDetalleCuenta();
                GuardarComentarioCuenta();

                MessageBox.Show("Comanda guardada correctamente ✔");

                FrmCuentas frm = new FrmCuentas(this);
                frm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            FrmCuentas frm = new FrmCuentas(this);
            frm.Show();
            this.Close();
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            if (DgvComanda.CurrentRow == null)
                return;

            int cantidad = Convert.ToInt32(
                DgvComanda.CurrentRow.Cells["CANT"].Value);

            if (cantidad <= 1)
                return;

            decimal precioUnitario =
                Convert.ToDecimal(DgvComanda.CurrentRow.Cells["PRECIO"].Value) / cantidad;

            cantidad--;

            DgvComanda.CurrentRow.Cells["CANT"].Value = cantidad;
            DgvComanda.CurrentRow.Cells["PRECIO"].Value = cantidad * precioUnitario;

            CalcularTotal();
        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            if (DgvComanda.CurrentRow == null)
                return;

            int cantidad = Convert.ToInt32(
                DgvComanda.CurrentRow.Cells["CANT"].Value);

            decimal precioUnitario =
                Convert.ToDecimal(DgvComanda.CurrentRow.Cells["PRECIO"].Value) / cantidad;

            cantidad++;

            DgvComanda.CurrentRow.Cells["CANT"].Value = cantidad;
            DgvComanda.CurrentRow.Cells["PRECIO"].Value = cantidad * precioUnitario;

            CalcularTotal();

        }

        private void ActualizarCantidad(int idProducto, int nuevaCantidad)
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(@"
        UPDATE DETALLE_CUENTA
        SET Cantidad = @Cantidad
        WHERE Id_Cuenta = @IdCuenta
        AND Id_Producto = @IdProducto", conn))
            {
                cmd.Parameters.AddWithValue("@Cantidad", nuevaCantidad);
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DgvComanda.Rows.Clear();
            CargarDetalleExistente();
        }

        private void BtnBorrarProducto_Click_1(object sender, EventArgs e)
        {
            if (DgvComanda.CurrentRow == null)
                return;

            int idProducto = Convert.ToInt32(
                DgvComanda.CurrentRow.Cells[0].Value);

            EliminarProductoBD(idProducto);

            DgvComanda.Rows.Remove(DgvComanda.CurrentRow);

            CalcularTotal();
        }

        private void EliminarProductoBD(int idProducto)
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(@"
            DELETE FROM DETALLE_CUENTA
            WHERE Id_Cuenta = @IdCuenta
            AND Id_Producto = @IdProducto", conn))
            {
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void BtnBorrarTodo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar toda la comanda?",
                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(@"
            DELETE FROM DETALLE_CUENTA
            WHERE Id_Cuenta = @IdCuenta", conn))
            {
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DgvComanda.Rows.Clear();
            CalcularTotal();
        }

        private void CargarComentarioCuenta()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            string query = @"SELECT Comentario 
                     FROM CUENTAS
                     WHERE Id_Cuenta = @IdCuenta";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    RtbComent.Text = result.ToString();
                }
                else
                {
                    RtbComent.Text = "";
                }
            }
        }

        private void GuardarComentarioCuenta()
        {
            string comentario = RtbComent.Text;

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            string query = @"UPDATE CUENTAS
                     SET Comentario = @Comentario
                     WHERE Id_Cuenta = @IdCuenta";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Comentario", comentario);
                cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public class ProductoTemp
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
        }
    }
}