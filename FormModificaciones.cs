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
    public partial class FormModificaciones : Form
    {
        private bool Modo;
        public FormModificaciones()
        {
            InitializeComponent();
        }
        public FormModificaciones(bool Modo)
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
                this.textBox1.BackColor = Color.FromArgb(252, 251, 241);
                this.textBox2.BackColor = Color.FromArgb(252, 251, 241);
            }
            else
            {
                //Paneles
                this.panelBase.BackColor = Color.FromArgb(46, 51, 73);
                this.panel1.BackColor = Color.Silver;
                this.panel2.BackColor = Color.Silver;
                this.textBox1.BackColor = Color.Silver;
                this.textBox2.BackColor = Color.Silver;
            }
        }
    }
}
