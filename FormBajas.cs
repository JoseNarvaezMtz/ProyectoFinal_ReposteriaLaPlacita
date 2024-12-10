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
    public partial class FormBajas : Form
    {
        private bool Modo;
        public FormBajas()
        {
            InitializeComponent();
        }
        public FormBajas(bool Modo)
        {
            this.Modo = Modo;
            InitializeComponent();
            Fondo();
        }
        public void Fondo()
        {
            if (this.Modo == true)
            {
                //Paneles
                this.panelBase.BackColor = Color.FromArgb(244, 241, 235);
                this.panel1.BackColor = Color.FromArgb(252, 251, 241);
                this.panel2.BackColor = Color.FromArgb(252, 251, 241);
                //botones
                this.button1.BackColor = Color.FromArgb(212, 200, 175);
                this.button1.ForeColor = Color.FromArgb(78, 78, 78);
                this.button2.BackColor = Color.FromArgb(212, 200, 175);
                this.button2.ForeColor = Color.FromArgb(78, 78, 78);
                this.button3.BackColor = Color.FromArgb(212, 200, 175);
                this.button3.ForeColor = Color.FromArgb(78, 78, 78);
                this.button4.BackColor = Color.FromArgb(212, 200, 175);
                this.button4.ForeColor = Color.FromArgb(78, 78, 78);
                this.button5.BackColor = Color.FromArgb(212, 200, 175);
                this.button5.ForeColor = Color.FromArgb(78, 78, 78);
                this.button6.BackColor = Color.FromArgb(212, 200, 175);
                this.button6.ForeColor = Color.FromArgb(78, 78, 78);
                this.button7.BackColor = Color.FromArgb(212, 200, 175);
                this.button7.ForeColor = Color.FromArgb(78, 78, 78);
                this.button8.BackColor = Color.FromArgb(212, 200, 175);
                this.button8.ForeColor = Color.FromArgb(78, 78, 78);
                this.button9.BackColor = Color.FromArgb(212, 200, 175);
                this.button9.ForeColor = Color.FromArgb(78, 78, 78);
                this.button10.BackColor = Color.FromArgb(212, 200, 175);
                this.button10.ForeColor = Color.FromArgb(78, 78, 78);
                //labels
                this.labelBajas.BackColor = Color.FromArgb(244, 241, 235);
                this.labelBajas.ForeColor = Color.Black;
            }
            else
            {
                //Paneles
                this.panelBase.BackColor = Color.FromArgb(46, 51, 73);
                this.panel1.BackColor = Color.Silver;
                this.panel2.BackColor = Color.Silver;
                //botones
                this.button1.BackColor = Color.FromArgb(24, 30, 54);
                this.button1.ForeColor = Color.FromArgb(70, 150, 250);
                this.button2.BackColor = Color.FromArgb(24, 30, 54);
                this.button2.ForeColor = Color.FromArgb(70, 150, 250);
                this.button3.BackColor = Color.FromArgb(24, 30, 54);
                this.button3.ForeColor = Color.FromArgb(70, 150, 250);
                this.button4.BackColor = Color.FromArgb(24, 30, 54);
                this.button4.ForeColor = Color.FromArgb(70, 150, 250);
                this.button5.BackColor = Color.FromArgb(24, 30, 54);
                this.button5.ForeColor = Color.FromArgb(70, 150, 250);
                this.button6.BackColor = Color.FromArgb(24, 30, 54);
                this.button6.ForeColor = Color.FromArgb(70, 150, 250);
                this.button7.BackColor = Color.FromArgb(24, 30, 54);
                this.button7.ForeColor = Color.FromArgb(70, 150, 250);
                this.button8.BackColor = Color.FromArgb(24, 30, 54);
                this.button8.ForeColor = Color.FromArgb(70, 150, 250);
                this.button9.BackColor = Color.FromArgb(24, 30, 54);
                this.button9.ForeColor = Color.FromArgb(70, 150, 250);
                this.button10.BackColor = Color.FromArgb(24, 30, 54);
                this.button10.ForeColor = Color.FromArgb(70, 150, 250);
                //labels
                this.labelBajas.BackColor = Color.FromArgb(46, 51, 73);
                this.labelBajas.ForeColor = Color.Silver;

            }
        }
        private void FormBajas_Load(object sender, EventArgs e)
        {

        }
    }
}
