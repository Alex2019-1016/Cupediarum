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
using static System.Windows.Forms.MonthCalendar;

namespace Cupediarum
{
    public partial class FrmAgregarCuenta : Form
    {
        private readonly Form formularioAnterior;
        private readonly int idAreaSeleccionada;

        public FrmAgregarCuenta(Form anterior, int idArea)
        {
            InitializeComponent();
            formularioAnterior = anterior;
            idAreaSeleccionada = idArea;
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {

            string nombreCuenta = RtbCuenta.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreCuenta))
            {
                MessageBox.Show("Ingrese nombre para la cuenta",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            string query = @"INSERT INTO CUENTAS 
         (Nomb_Cuenta, Cantidad_Personas, Id_Mesa, Id_Usuario, Id_Area)
         OUTPUT INSERTED.Id_Cuenta
         VALUES 
         (@nombre, @cantidad, @mesa, @usuario, @area)";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", nombreCuenta);
                cmd.Parameters.AddWithValue("@cantidad", 1);
                cmd.Parameters.AddWithValue("@mesa", DBNull.Value);
                cmd.Parameters.AddWithValue("@usuario", Sesion.IdUsuario);
                cmd.Parameters.AddWithValue("@area", idAreaSeleccionada);

                try
                {
                    conn.Open();

                    int idCuentaCreada = (int)cmd.ExecuteScalar();

                    MessageBox.Show("Cuenta creada correctamente ✔",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    FrmCantidadPersonas frm = new FrmCantidadPersonas(idCuentaCreada, this);
                    frm.Show();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear cuenta: " + ex.Message);
                }
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            formularioAnterior.Show();
            this.Close();
        }

        private void EscribirTexto(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            RtbCuenta.Text += btn.Text;
        }

        private void FrmAgregarCuenta_Load(object sender, EventArgs e)
        {
            AsignarEventos(this);
        }

        private void AsignarEventos(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is Button btn)
                {
                    if (btn.Text != "BORRAR" && btn.Text != "Aceptar" && btn.Text != "Cancelar" && btn.Text != "Minuscula")
                    {
                        btn.Click += EscribirTexto;
                    }
                }

                if (ctrl.HasChildren)
                    AsignarEventos(ctrl);
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (RtbCuenta.Text.Length > 0)
                RtbCuenta.Text = RtbCuenta.Text.Substring(0, RtbCuenta.Text.Length - 1);
        }

        bool mayuscula = true;

        private void BtnMinuscula_Click(object sender, EventArgs e)
        {
            mayuscula = !mayuscula;

            CambiarMayusculas(this);
        }

        private void CambiarMayusculas(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is Button btn)
                {
                    if (btn.Text.Length == 1 && char.IsLetter(btn.Text[0]))
                    {
                        btn.Text = mayuscula ? btn.Text.ToUpper() : btn.Text.ToLower();
                    }
                }

                if (ctrl.HasChildren)
                    CambiarMayusculas(ctrl);
            }
        }

        private void BtnEspacio_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Name == "BtnEspacio")
            {
                RtbCuenta.Text += " ";
            }
            else
            {
                RtbCuenta.Text += btn.Text;
            }
        }
    }
}
