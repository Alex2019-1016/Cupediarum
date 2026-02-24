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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnMesero_Click(object sender, EventArgs e)
        {
            FrmMesero frm = new FrmMesero(this);
            frm.Show();
            this.Hide();
        }
        
        private void BtnMesas_Click(object sender, EventArgs e)
        {
            FrmMesas frm = new FrmMesas();
            frm.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmInicioSesion frm = new FrmInicioSesion();
            frm.Show();
            this.Hide();
        }
    }
}
