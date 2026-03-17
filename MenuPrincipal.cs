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

        private void BtnMesero_Click_1(object sender, EventArgs e)
        {
            FrmMesero frm = new FrmMesero();
            frm.ShowDialog();
        }
        
        private void BtnMesas_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.ShowDialog();
        }

        private void BtnPrecios_Click(object sender, EventArgs e)
        {
            FrmPrecios frm = new FrmPrecios(this);
            frm.Show();
           
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmInicioSesion frm = new FrmInicioSesion();
            frm.Show();
            this.Close();
        }
    }
}
