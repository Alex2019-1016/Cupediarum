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
        private readonly Form formularioAnterior;
        public FrmOpcionesMesero(int idCuentaRecibida, Form anterior)
        {
            InitializeComponent();
            idCuenta = idCuentaRecibida;
            formularioAnterior = anterior;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmCapturaProductos frm = new FrmCapturaProductos(idCuenta, formularioAnterior);
            frm.Show();
            this.Close();
        }
    }
}
