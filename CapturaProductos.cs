using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupediarum
{
    public partial class FrmCapturaProductos : Form
    {

        private int idCuenta;
        private Form formularioAnterior;
        public FrmCapturaProductos(int idCuentaRecibida, Form anterior)
        {
            InitializeComponent();
            idCuenta = idCuentaRecibida;
            formularioAnterior = anterior;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FrmCuentas frm = new FrmCuentas();
            frm.Show();
            this.Hide();
        }

        private void BtnBebidas_Click(object sender, EventArgs e)
        {

        }

        private void BtnComida_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            formularioAnterior.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

       
