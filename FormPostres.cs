using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoBase
{
    public partial class FormPostres : Form
    {

        public int[] postreDisp;
        public FormPostres()
        {
            InitializeComponent();
        }

        public FormPostres(int[] postreDisp)
        {
            InitializeComponent();
            this.postreDisp = postreDisp;
            verificarProdPost();

        }

        public void verificarProdPost()
        {
            Button[] botonesPostre = {
                btnComprarPostreCarlota,
                btnComprarPostreCupcake,
                btnComprarPostreBrownie,
                btnComprarPostrePay,
                btnComprarPostrePostrePastel
            };

            for (int i = 0; i < this.postreDisp.Length; i++)
            {
                if (this.postreDisp[i] == 0)
                {
                    botonesPostre[i].Enabled = false;
                    botonesPostre[i].Text = "No disponible";
                    //botonesPostre[i].Font = new Font(botonesPostre[i].Font, FontStyle.Strikeout); nose
                    botonesPostre[i].BackColor = Color.Tan;
                }
                else
                {
                    botonesPostre[i].Enabled = true;
                    botonesPostre[i].Text = "Comprar";
                    botonesPostre[i].Font = new Font(botonesPostre[i].Font, FontStyle.Regular);
                    botonesPostre[i].BackColor = Color.Sienna;
                }
            }
        }

        private void btnComprarPostreCarlota_Click(object sender, EventArgs e)
        {
            FormMetodosPago form = new FormMetodosPago(postreDisp, 0);
            form.ShowDialog();
            verificarProdPost();
        }

        private void btnComprarPostreCupcake_Click(object sender, EventArgs e)
        {
            FormMetodosPago form = new FormMetodosPago(postreDisp, 1);
            form.ShowDialog();
            verificarProdPost();
        }

        private void btnComprarPostreBrownie_Click(object sender, EventArgs e)
        {
            FormMetodosPago form = new FormMetodosPago(postreDisp, 2);
            form.ShowDialog();
            verificarProdPost();
        }

        private void btnComprarPostreCupcakeKitty_Click(object sender, EventArgs e)
        {
            FormMetodosPago form = new FormMetodosPago(postreDisp, 3);
            form.ShowDialog();
            verificarProdPost();
        }

        private void btnComprarPostreCupcakeNavidad_Click(object sender, EventArgs e)
        {
            FormMetodosPago form = new FormMetodosPago(postreDisp, 4);
            form.ShowDialog();
            verificarProdPost();
        }
    }
}
