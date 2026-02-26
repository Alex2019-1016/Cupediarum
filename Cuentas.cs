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
    public partial class FrmCuentas : Form
    {
        private readonly Form formularioAnterior;
        
        public FrmCuentas(Form anterior)
        {
            InitializeComponent();
            formularioAnterior = anterior;
        }

        private int cuentaSeleccionada = 0;
        private int idAreaSeleccionada = 0;
       

        private void Pedidos_Load(object sender, EventArgs e)
        {
            TxtNombMesero.Text = Sesion.NombreUsuario;
            TxtIDMesero.Text = Sesion.IdUsuario.ToString();

            LblUsuario.Text = Sesion.NombreRol;

            if (Sesion.IdRol == 1) // Admin
                LblUsuario.ForeColor = Color.Red;
            else if (Sesion.IdRol == 2) // Cajero
                LblUsuario.ForeColor = Color.Lime;
            else if(Sesion.IdRol == 3) // Mesero
                LblUsuario.ForeColor = Color.Yellow;

            CargarCuentas();
            CargarAreasEnPanel();
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

                        Button btn = new Button
                        {
                            Width = 118,
                            Height = 72,
                            FlatStyle = FlatStyle.Flat,
                            Font = new Font("Times New Roman", 12, FontStyle.Bold),
                            FlatAppearance = { BorderSize = 3, BorderColor = Color.Cyan },
                            BackgroundImage = Properties.Resources.FBAzul,
                            BackgroundImageLayout = ImageLayout.Stretch,
                            BackColor = Color.LightCoral,
                            Text = nombreCuenta,
                            Tag = idCuenta
                        };

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

            FrmOpcionesMesero frm = new FrmOpcionesMesero(cuentaSeleccionada, this);
            frm.Show();
        }

        private void CargarAreasEnPanel()
        {
            FlpAreas.Controls.Clear();

            string connStr = ConfigurationManager
                .ConnectionStrings["ConexionRestaurante"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"SELECT Id_Area, Nomb_Area 
                         FROM AREAS 
                         WHERE Estado = 1
                         ORDER BY Id_Area";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idArea = reader.GetInt32(0);
                        string nombreArea = reader.GetString(1);

                        Button btnArea = new Button
                        {
                            Width = 120,
                            Height = 60,
                            Text = nombreArea,
                            Tag = idArea,
                            BackgroundImage = Properties.Resources.FBNaranja,
                            BackgroundImageLayout = ImageLayout.Stretch,
                            BackColor = Color.LightCoral,
                            FlatStyle = FlatStyle.Flat,
                            FlatAppearance = { BorderSize = 3, BorderColor = Color.Cyan },
                            Font = new Font("Times New Roman", 12, FontStyle.Bold),
                        };

                        btnArea.Click += BtnAreaPanel_Click;

                        FlpAreas.Controls.Add(btnArea);
                    }
                }
            }
        }

        private void BtnAreaPanel_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            idAreaSeleccionada = (int)btn.Tag;
            string nombreArea = btn.Text;

            
            RtbArea.Text = nombreArea;
            RtbArea.ReadOnly = true;
            RtbArea.SelectionAlignment = HorizontalAlignment.Center;


            foreach (Button b in FlpAreas.Controls)
                b.BackColor = Color.DarkGray;

            btn.BackColor = Color.LightGreen;
        }

        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            if (idAreaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione un área primero",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            FrmAgregarCuenta frm = new FrmAgregarCuenta(this, idAreaSeleccionada);
            frm.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmMesero frm = new FrmMesero(this);
            frm.Show();
            this.Hide();
        }
    }
}
