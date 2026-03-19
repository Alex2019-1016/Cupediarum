using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupediarum
{
    public partial class FrmOpcionesMesero : Form
    {
        private readonly int idCuenta;

        public FrmOpcionesMesero(int idCuentaRecibida)
        {
            InitializeComponent();
            idCuenta = idCuentaRecibida;
           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmCapturaProductos frm = new FrmCapturaProductos(idCuenta);
            frm.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            string logoPath = Application.StartupPath + @"\Img\Logo.png";

            TicketHelper.Imprimir(idCuenta, logoPath);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultar frm = new FrmConsultar(idCuenta);
            frm.Show();
            this.Hide();
        }
    }
}
