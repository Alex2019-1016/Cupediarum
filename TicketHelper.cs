using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupediarum
{
    public static class TicketHelper
    {
        public static void ImprimirCuentaSaldada(int idCuenta, string logoPath, decimal propina, decimal monto)
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            string cuenta = "", mesero = "", area = "";
            int personas = 0;
            DateTime fecha = DateTime.Now;

            decimal subtotal = 0;

            var productos = new List<(string nombre, int cant, decimal sub)>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
        SELECT 
            c.Nomb_Cuenta,
            c.FechaApertura,
            c.Cantidad_Personas,
            u.Nomb_Usuario,
            a.Nomb_Area,
            p.Nomb_Producto,
            d.Cantidad,
            d.Subtotal
        FROM CUENTAS c
        INNER JOIN USUARIOS u ON c.Id_Usuario = u.Id_Usuario
        INNER JOIN AREAS a ON c.Id_Area = a.Id_Area
        INNER JOIN DETALLE_CUENTA d ON c.Id_Cuenta = d.Id_Cuenta
        INNER JOIN PRODUCTOS p ON d.Id_Producto = p.Id_Producto
        WHERE c.Id_Cuenta = @IdCuenta";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (cuenta == "")
                        {
                            cuenta = dr[0].ToString();
                            fecha = Convert.ToDateTime(dr[1]);
                            personas = Convert.ToInt32(dr[2]);
                            mesero = dr[3].ToString();
                            area = dr[4].ToString();
                        }

                        string nombre = dr[5].ToString();
                        int cant = Convert.ToInt32(dr[6]);
                        decimal sub = Convert.ToDecimal(dr[7]);

                        productos.Add((nombre, cant, sub));
                        subtotal += sub;
                    }
                }
            }

            if (productos.Count == 0)
            {
                MessageBox.Show("Esta cuenta no tiene productos.");
                return;
            }

            decimal itbis = subtotal * 0.18m;
            decimal total = subtotal + itbis + propina;
            decimal cambio = monto - total;

            PrintDocument doc = new PrintDocument();
            int ancho = 300;

            doc.DefaultPageSettings.PaperSize = new PaperSize("Ticket", ancho, 1200);
            doc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            doc.PrintPage += (s, e) =>
            {
                float y = 10;

                Font titulo = new Font("Times New Roman", 12, FontStyle.Bold);
                Font normal = new Font("Consolas", 9);
                Font negrita = new Font("Consolas", 10, FontStyle.Bold);

                StringFormat centro = new StringFormat { Alignment = StringAlignment.Center };
                StringFormat derecha = new StringFormat { Alignment = StringAlignment.Far };

                int colCant = (int)(ancho * 0.6);
                int colTotal = ancho - 5;

                if (System.IO.File.Exists(logoPath))
                {
                    using (Image logo = Image.FromFile(logoPath))
                    {
                        int w = ancho - 40;
                        int h = (int)((float)logo.Height / logo.Width * w);
                        e.Graphics.DrawImage(logo, (ancho - w) / 2, y, w, h);
                        y += h + 5;
                    }
                }

                e.Graphics.DrawString("CUPEDIARUM RESTAURANT", titulo, Brushes.Black, ancho / 2, y, centro);
                y += 20;

                e.Graphics.DrawString("***** CUENTA SALDADA *****", normal, Brushes.Black, ancho / 2, y, centro);
                y += 25;

                e.Graphics.DrawString($"Cuenta: {cuenta}", normal, Brushes.Black, 0, y); y += 15;
                e.Graphics.DrawString($"Mesero: {mesero}", normal, Brushes.Black, 0, y); y += 15;
                e.Graphics.DrawString($"Area: {area}", normal, Brushes.Black, 0, y); y += 15;
                e.Graphics.DrawString($"Personas: {personas}", normal, Brushes.Black, 0, y); y += 15;
                e.Graphics.DrawString($"Fecha: {fecha:dd/MM/yyyy HH:mm}", normal, Brushes.Black, 0, y); y += 20;

                e.Graphics.DrawString("----------------------------------------", normal, Brushes.Black, 0, y);
                y += 15;

                foreach (var p in productos)
                {
                    e.Graphics.DrawString(p.nombre, normal, Brushes.Black, 0, y);
                    e.Graphics.DrawString(p.cant.ToString(), normal, Brushes.Black, colCant, y);
                    e.Graphics.DrawString(p.sub.ToString("N2"), normal, Brushes.Black, colTotal, y, derecha);
                    y += 15;
                }

                y += 10;
                e.Graphics.DrawString("----------------------------------------", normal, Brushes.Black, 0, y);
                y += 20;

                e.Graphics.DrawString("Consumo:", normal, Brushes.Black, 0, y);
                e.Graphics.DrawString(subtotal.ToString("N2"), normal, Brushes.Black, colTotal, y, derecha); y += 15;

                e.Graphics.DrawString("ITBIS: 18%", normal, Brushes.Black, 0, y);
                e.Graphics.DrawString(itbis.ToString("N2"), normal, Brushes.Black, colTotal, y, derecha); y += 15;

                e.Graphics.DrawString("Propina:", normal, Brushes.Black, 0, y);
                e.Graphics.DrawString(propina.ToString("N2"), normal, Brushes.Black, colTotal, y, derecha); y += 15;

                e.Graphics.DrawString("TOTAL:", negrita, Brushes.Black, 0, y);
                e.Graphics.DrawString(total.ToString("N2"), negrita, Brushes.Black, colTotal, y, derecha);
                y += 15;

                e.Graphics.DrawString("PAGADO:", normal, Brushes.Black, 0, y);
                e.Graphics.DrawString(monto.ToString("N2"), normal, Brushes.Black, colTotal, y, derecha);
                y += 15;

                if (cambio > 0)
                {
                    e.Graphics.DrawString("CAMBIO:", negrita, Brushes.Black, 0, y);
                    e.Graphics.DrawString(cambio.ToString("N2"), negrita, Brushes.Black, colTotal, y, derecha);
                    y += 15;
                }

                y += 20;

                e.Graphics.DrawString("Gracias por su visita", normal, Brushes.Black, ancho / 2, y, centro); y += 15;
                e.Graphics.DrawString("Vuelva pronto!", normal, Brushes.Black, ancho / 2, y, centro);
            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;
            preview.ShowDialog();

            doc.Print();
        }

        public static void Imprimir(int idCuenta, string logoPath)
        {
            string connStr = ConfigurationManager
        .ConnectionStrings["ConexionRestaurante"]
        .ConnectionString;

            string cuenta = "", mesero = "", area = "";
            int personas = 0;
            DateTime fecha = DateTime.Now;

            decimal subtotal = 0;

            var productos = new List<(string nombre, int cant, decimal sub)>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
        SELECT 
            c.Nomb_Cuenta,
            c.FechaApertura,
            c.Cantidad_Personas,
            u.Nomb_Usuario,
            a.Nomb_Area,
            p.Nomb_Producto,
            d.Cantidad,
            d.Subtotal
        FROM CUENTAS c
        INNER JOIN USUARIOS u ON c.Id_Usuario = u.Id_Usuario
        INNER JOIN AREAS a ON c.Id_Area = a.Id_Area
        INNER JOIN DETALLE_CUENTA d ON c.Id_Cuenta = d.Id_Cuenta
        INNER JOIN PRODUCTOS p ON d.Id_Producto = p.Id_Producto
        WHERE c.Id_Cuenta = @IdCuenta";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (cuenta == "")
                        {
                            cuenta = dr[0].ToString();
                            fecha = Convert.ToDateTime(dr[1]);
                            personas = Convert.ToInt32(dr[2]);
                            mesero = dr[3].ToString();
                            area = dr[4].ToString();
                        }

                        string nombre = dr[5].ToString();
                        int cant = Convert.ToInt32(dr[6]);
                        decimal sub = Convert.ToDecimal(dr[7]);

                        productos.Add((nombre, cant, sub));
                        subtotal += sub;
                    }
                }
            }

            if (productos.Count == 0)
            {
                MessageBox.Show("Esta cuenta no tiene productos.");
                return;
            }

            decimal itbis = subtotal * 0.18m;
            decimal total = subtotal + itbis;
           
            PrintDocument doc = new PrintDocument();
            int ancho = 300;

            doc.DefaultPageSettings.PaperSize = new PaperSize("Ticket", ancho, 1000);
            doc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            doc.PrintPage += (s, e) =>
            {
                float y = 10;

                Font titulo = new Font("Times New Roman", 12, FontStyle.Bold);
                Font normal = new Font("Consolas", 9);
                Font negrita = new Font("Consolas", 10, FontStyle.Bold);

                StringFormat centro = new StringFormat { Alignment = StringAlignment.Center };
                StringFormat derecha = new StringFormat { Alignment = StringAlignment.Far };

                int colCant = (int)(ancho * 0.6);
                int colTotal = ancho - 5;

                if (System.IO.File.Exists(logoPath))
                {
                    using (Image logo = Image.FromFile(logoPath))
                    {
                        int w = ancho - 40;
                        int h = (int)((float)logo.Height / logo.Width * w);
                        e.Graphics.DrawImage(logo, (ancho - w) / 2, y, w, h);
                        y += h + 5;
                    }
                }

                e.Graphics.DrawString("CUPEDIARUM RESTAURANT", titulo, Brushes.Black, ancho / 2, y, centro);
                y += 20;

                e.Graphics.DrawString("PRECUENTA", normal, Brushes.Black, ancho / 2, y, centro);
                y += 25;

                e.Graphics.DrawString($"Cuenta: {cuenta}", normal, Brushes.Black, 0, y); y += 15;
                e.Graphics.DrawString($"Mesero: {mesero}", normal, Brushes.Black, 0, y); y += 15;
                e.Graphics.DrawString($"Area: {area}", normal, Brushes.Black, 0, y); y += 15;
                e.Graphics.DrawString($"Personas: {personas}", normal, Brushes.Black, 0, y); y += 15;
                e.Graphics.DrawString($"Fecha: {fecha:dd/MM/yyyy HH:mm}", normal, Brushes.Black, 0, y); y += 20;

                e.Graphics.DrawString("----------------------------------------", normal, Brushes.Black, 0, y);
                y += 15;

                foreach (var p in productos)
                {
                    e.Graphics.DrawString(p.nombre, normal, Brushes.Black, 0, y);
                    e.Graphics.DrawString(p.cant.ToString(), normal, Brushes.Black, colCant, y);
                    e.Graphics.DrawString(p.sub.ToString("N2"), normal, Brushes.Black, colTotal, y, derecha);
                    y += 15;
                }

                y += 10;
                e.Graphics.DrawString("----------------------------------------", normal, Brushes.Black, 0, y);
                y += 20;

                e.Graphics.DrawString("Subtotal:", normal, Brushes.Black, 0, y);
                e.Graphics.DrawString(subtotal.ToString("N2"), normal, Brushes.Black, colTotal, y, derecha); y += 15;

                e.Graphics.DrawString("ITBIS:", normal, Brushes.Black, 0, y);
                e.Graphics.DrawString(itbis.ToString("N2"), normal, Brushes.Black, colTotal, y, derecha); y += 15;

                e.Graphics.DrawString("TOTAL:", negrita, Brushes.Black, 0, y);
                e.Graphics.DrawString(total.ToString("N2"), negrita, Brushes.Black, colTotal, y, derecha);

            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;
            preview.ShowDialog();

            doc.Print();
        }
    }
}
