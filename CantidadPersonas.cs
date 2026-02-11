using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Cupediarum
{
    public partial class FrmCantidadPersonas : Form
    {
        public FrmCantidadPersonas(int idCuentaRecibida)
        {
            InitializeComponent();
            idCuenta = idCuentaRecibida;
        }

        private int idCuenta;

        private void TxtPersonas_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FrmDatosCuenta frm = new FrmDatosCuenta();
            frm.Show();
            this.Hide();
        }
    }
}
