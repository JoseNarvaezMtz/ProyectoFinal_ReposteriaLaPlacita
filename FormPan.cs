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
    public partial class FormPan : Form
    {
        public int[] panDisp;
        public FormPan()
        {
            InitializeComponent();
        }

        public FormPan(int[] panDisp)
        {
            InitializeComponent();
            this.panDisp = panDisp;
            verificarProdPan();

        }

        public void verificarProdPan()
        {

            Button[] botonesPan = {
                btnComprarPanElote,
                btnComprarPanNuez,
                btnComprarPanEmpanada,
                btnComprarPanRol,
                btnComprarPanCuernitos
            };

            for (int i = 0; i < this.panDisp.Length; i++)
            {
                if (this.panDisp[i] == 0)
                {
                    botonesPan[i].Enabled = false;
                    botonesPan[i].Text = "No disponible";
                    botonesPan[i].BackColor = Color.Tan;
                }
                else
                {
                    botonesPan[i].Enabled = true;
                    botonesPan[i].Text = "Comprar";
                    botonesPan[i].Font = new Font(botonesPan[i].Font, FontStyle.Regular);
                    botonesPan[i].BackColor = Color.Sienna;
                }
            }
        }

        private void btnComprarPanElote_Click(object sender, EventArgs e)
        {
            //pendiente ver la dinamica de la compra
            FormMetodosPago form = new FormMetodosPago(panDisp,0);
            form.ShowDialog();
            verificarProdPan();
        }

        private void btnComprarPanNuez_Click(object sender, EventArgs e)
        {
            //pendiente ver la dinamica de la compra
            FormMetodosPago form = new FormMetodosPago(panDisp, 1);
            form.ShowDialog();
            verificarProdPan();
        }

        private void btnComprarPanPay_Click(object sender, EventArgs e)
        {
            FormMetodosPago form = new FormMetodosPago(panDisp, 2);
            form.ShowDialog();
            verificarProdPan();
        }

        private void btnComprarPanRol_Click(object sender, EventArgs e)
        {
            FormMetodosPago form = new FormMetodosPago(panDisp, 3);
            form.ShowDialog();
            verificarProdPan();
        }

        private void btnComprarPanIndef_Click(object sender, EventArgs e)
        {
            FormMetodosPago form = new FormMetodosPago(panDisp, 4);
            form.ShowDialog();
            verificarProdPan();
        }
    }

}
