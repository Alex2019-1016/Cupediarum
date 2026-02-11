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
    public partial class FrmDatosCuenta : Form
    {
        public FrmDatosCuenta()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatosCuenta_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbrirMesa_Click(object sender, EventArgs e)
        {
            FrmCapturaProductos frm = new FrmCapturaProductos();
            frm.Show();
            this.Hide();
        }
    }
}
