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
    public partial class FrmAgregarCuenta : Form
    {
        public FrmAgregarCuenta()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void AbrirCuenta_Load(object sender, EventArgs e)
        {

        }

        private void PnlLetras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FrmCantidadPersonas frm = new FrmCantidadPersonas();
            frm.Show();
            this.Hide();
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            FrmCantidadPersonas frm = new FrmCantidadPersonas();
            frm.Show();
            this.Hide();
        }
    }
}
