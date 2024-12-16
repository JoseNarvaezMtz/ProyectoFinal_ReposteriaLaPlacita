using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoBase
{
    public partial class FormMetodosPago : Form
    {
        public FormMetodosPago()
        {
            InitializeComponent();
        }
        private void buttonPagoCaja_Click(object sender, EventArgs e)
        {
            FormPagoCaja caja = new FormPagoCaja();
            this.Close();
            caja.Show();
        }

        private void buttonPagoTarjeta_Click(object sender, EventArgs e)
        {
            FormPagoTarjeta tarjeta = new FormPagoTarjeta();
            this.Close();
            tarjeta.Show();
        }

        private void buttonPagoOxxo_Click(object sender, EventArgs e)
        {
            FormPagoOxxo oxxo = new FormPagoOxxo();
            this.Close();
            oxxo.Show();
        }
        private void btnSalirMetPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
