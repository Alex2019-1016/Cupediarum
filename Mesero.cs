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
    public partial class FrmMesero : Form
    {
        public FrmMesero()
        {
            InitializeComponent();
        }

        private void Mesero_Load(object sender, EventArgs e)
        {

        }

        private void Cuentas_Click(object sender, EventArgs e)
        {
            FrmCuentas frm = new FrmCuentas();
            frm.Show();
            this.Hide();
        }
    }
}
