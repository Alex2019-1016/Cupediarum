
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
        private readonly Form formularioAnterior;

        public FrmCapturaProductos(int idCuentaRecibida, Form anterior)
        {
            InitializeComponent();
            idCuenta = idCuentaRecibida;
            formularioAnterior = anterior;
        }

        private void FrmCapturaProductos_Load_1(object sender, EventArgs e)
        {
            ConfigurarDgv();
            CargarCategoriasPrincipales();
            CargarDetalleExistente();
        }

        // =============================
        // CONFIGURAR DGV
        // =============================
        private void ConfigurarDgv()
        {
            DgvComanda.Rows.Clear();
            DgvComanda.AllowUserToAddRows = false;
        }

        // =============================
        // CARGAR CATEGORÍAS PRINCIPALES
        // =============================

        private void CargarDetalleExistente()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(@"
        SELECT Id_Producto, Cantidad, Precio, Subtotal
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
                    decimal subtotal = reader.GetDecimal(3);

                    string nombre = ObtenerNombreProducto(idProducto);

                    DgvComanda.Rows.Add(
                        idProducto,
                        "1",
                        cantidad,
                        nombre,
                        subtotal,
                        0
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
                "SELECT Nomb_Producto FROM PRODUCTOS WHERE IdProducto = @Id", conn))
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
                    string nombre = reader.GetString(1).ToLower();

                    if (nombre == "postres")
                        BtnPostres.Tag = id;

                    else if (nombre == "bebidas")
                        BtnBebidas.Tag = id;

                    else if (nombre == "comidas")
                        BtnComida.Tag = id;

                    else if (nombre == "otros")
                        BtnOtros.Tag = id;

                    BtnPostres.Click += BtnCategoria_Click;
                    BtnBebidas.Click += BtnCategoria_Click;
                    BtnComida.Click += BtnCategoria_Click;
                    BtnOtros.Click += BtnCategoria_Click;
                }
            }
        }

        // =============================
        // CLICK CATEGORÍA
        // =============================
        private void BtnCategoria_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            idCategoriaSeleccionada = (int)btn.Tag;

            CargarSubCategorias(idCategoriaSeleccionada);

        }

        // =============================
        // CARGAR SUBCATEGORÍAS
        // =============================
        private void CargarSubCategorias(int idCategoria)
        {
            FlpSubCategorias.Controls.Clear();
            FlpProductos.Controls.Clear();

            string query = @"SELECT Id_Categoria, Nomb_Categoria
                     FROM CATEGORIAS
                     WHERE Id_CategoriaPadre = @IdCategoria";

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
                        BackgroundImage = Properties.Resources.FBAzul,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        FlatStyle = FlatStyle.Flat
                    };

                    btnSub.Click += BtnSubCategoria_Click;

                    FlpSubCategorias.Controls.Add(btnSub);
                }
            }
        }

        // =============================
        // CLICK SUBCATEGORÍA
        // =============================
        private void BtnSubCategoria_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            idSubCategoriaSeleccionada = (int)btn.Tag;

            CargarProductos(idSubCategoriaSeleccionada);
        }

        // =============================
        // CARGAR PRODUCTOS
        // =============================
        private void CargarProductos(int idSubCategoria)
        {
            FlpProductos.Controls.Clear();

            string query = @"SELECT IdProducto, Nomb_Producto, Precio
                     FROM PRODUCTOS
                     WHERE Id_Categoria = @IdCategoria";

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
                        BackgroundImage = Properties.Resources.FBNaranja,
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

        // =============================
        // AGREGAR PRODUCTO A COMANDA
        // =============================
        private void BtnProducto_Click(object sender, EventArgs e)
        {
            ProductoTemp producto = (ProductoTemp)((Button)sender).Tag;

            bool encontrado = false;

            foreach (DataGridViewRow row in DgvComanda.Rows)
            {
                if (row.Cells["IDPRODUCTO"].Value != null &&
                    Convert.ToInt32(row.Cells["IDPRODUCTO"].Value) == producto.Id)
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
                    producto.Id,          // IDPRODUCTO
                    "1",                  // COMANDA
                    1,                    // CANT
                    producto.Nombre,      // DESCRIPCION
                    producto.Precio,      // PRECIO
                    0                     // DESCUENTO
                );
            }

            CalcularTotal();
        }

        private void GuardarDetalleCuenta()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // 🔥 Primero borramos lo que ya exista
                using (SqlCommand deleteCmd = new SqlCommand(
                    "DELETE FROM DETALLE_CUENTA WHERE Id_Cuenta = @IdCuenta", conn))
                {
                    deleteCmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
                    deleteCmd.ExecuteNonQuery();
                }

                // 🔥 Luego insertamos lo actual
                foreach (DataGridViewRow row in DgvComanda.Rows)
                {
                    if (row.Cells["IDPRODUCTO"].Value == null)
                        continue;

                    int idProducto = Convert.ToInt32(row.Cells["IDPRODUCTO"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["CANT"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["PRECIO"].Value);

                    decimal precioUnitario = subtotal / cantidad;

                    string query = @"INSERT INTO DETALLE_CUENTA
                             (Id_Cuenta, Id_Producto, Cantidad, Precio, Comentarios)
                             VALUES
                             (@IdCuenta, @IdProducto, @Cantidad, @Precio, @Comentarios)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@Precio", precioUnitario);
                        cmd.Parameters.AddWithValue("@Comentarios", DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // =============================
        // CALCULAR TOTAL
        // =============================
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

        // =============================
        // ACEPTAR
        // =============================
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

                MessageBox.Show("Comanda guardada correctamente ✔");

                FrmCuentas frm = new FrmCuentas(this);
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        // =============================
        // CANCELAR
        // =============================
        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            formularioAnterior.Show();
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

            // Refrescar pantalla
            DgvComanda.Rows.Clear();
            CargarDetalleExistente();
        }

        private void BtnBorrarProducto_Click_1(object sender, EventArgs e)
        {
            if (DgvComanda.CurrentRow == null)
                return;

            int idProducto = Convert.ToInt32(
                DgvComanda.CurrentRow.Cells["IDPRODUCTO"].Value);

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
    }

    // Clase temporal para guardar producto en botón
    public class ProductoTemp
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}