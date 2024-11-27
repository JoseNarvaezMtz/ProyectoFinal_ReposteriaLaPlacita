using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoBase
{
    public partial class FormMetodosPago : Form
    {
        public int[] Disp;
        public int indice;
        public FormMetodosPago()
        {
            InitializeComponent();
        }

        public FormMetodosPago(int[] Disp, int indice)
        {
            InitializeComponent();
            this.Disp = Disp;
            this.indice = indice;
            this.btnDismCompra.Enabled = false;
            this.buttonPagoCaja.Enabled = false;
            this.buttonPagoOxxo.Enabled = false;
            this.buttonPagoTarjeta.Enabled = false;
        }
        public void metCompra()
        {
            MessageBox.Show("Aqui se deberia abrir o descargar el recibo" +
                            "\ncreo no estoy seguro de como sea la verdad" +
                            "\npero bueno es funcional por ahora         " +
                            "\n                                          " +
                            "\n\n\t\t¡¡Compra Exitosa!! ");
        }

        private void buttonPagoCaja_Click(object sender, EventArgs e)
        {
            this.Disp[this.indice] -= Convert.ToInt32(labelNumPorComprar.Text);
            metCompra();
            this.Close();
        }

        private void buttonPagoTarjeta_Click(object sender, EventArgs e)
        {
            this.Disp[this.indice] -= Convert.ToInt32(labelNumPorComprar.Text);
            metCompra();
            this.Close();
        }

        private void buttonPagoOxxo_Click(object sender, EventArgs e)
        {
            this.Disp[this.indice] -= Convert.ToInt32(labelNumPorComprar.Text);
            metCompra();
            this.Close();
        }

        private void btnAumCompra_Click(object sender, EventArgs e)
        {
            int nuevo = 0;
            nuevo = Convert.ToInt32(labelNumPorComprar.Text) + 1;
            labelNumPorComprar.Text = Convert.ToString(nuevo);
            verificarProd();

        }

        private void btnDismCompra_Click(object sender, EventArgs e)
        {
            int nuevo = 0;
            nuevo = Convert.ToInt32(labelNumPorComprar.Text) - 1;
            labelNumPorComprar.Text = Convert.ToString(nuevo);
            verificarProd();
        }

        private void btnSalirMetPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void verificarProd()
        {
            if (Convert.ToInt32(labelNumPorComprar.Text) == 0)
            {
                this.btnDismCompra.Enabled = false;
                this.buttonPagoCaja.Enabled = false;
                this.buttonPagoOxxo.Enabled = false;
                this.buttonPagoTarjeta.Enabled = false;
            }else{
                this.btnDismCompra.Enabled = true;
                this.buttonPagoCaja.Enabled = true;
                this.buttonPagoOxxo.Enabled = true;
                this.buttonPagoTarjeta.Enabled = true;
            }

            if (Convert.ToInt32(labelNumPorComprar.Text) == Disp[indice])
            {
                this.btnAumCompra.Enabled = false;
            }else{
                this.btnAumCompra.Enabled = true;
            }
        }

    }
}
