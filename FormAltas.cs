using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using WinFormsTareaBaseDatos;

namespace WinFormsProyectoBase
{
    public partial class FormAltas : Form
    {
        List<Productos> list;
        Productos[] panes, postres;
        Button[] buttonsPan, buttonsPos;
        AdmonBD conexion;
        private bool Modo;

        public FormAltas(bool modo)
        {
            InitializeComponent();
            this.panes = new Productos[5];
            this.postres = new Productos[5];
            this.buttonsPan = new Button[5];
            this.buttonsPos = new Button[5];
            this.buttonsPan[0] = button1;
            this.buttonsPan[1] = button2;
            this.buttonsPan[2] = button3;
            this.buttonsPan[3] = button4;
            this.buttonsPan[4] = button5;
            this.buttonsPos[0] = button6;
            this.buttonsPos[1] = button7;
            this.buttonsPos[2] = button8;
            this.buttonsPos[3] = button9;
            this.buttonsPos[4] = button10;
            this.conexion = new AdmonBD();
            this.Modo = modo;
            this.Fondo();
            this.Llenar();
        }

        private void Llenar()
        {
            this.list = conexion.consulta();
            int contpan = 0, contpos = 0, cont = 0;

            foreach (Productos p in list)
            {
                if (p.Categoria == 1)
                {
                    panes[contpan] = p;
                    //MessageBox.Show($"Panes: {panes[contpan].Nombre}, {panes[contpan].Categoria}");
                    contpan++;
                }
                else
                {
                    postres[contpos] = p;
                    //MessageBox.Show($"Postres: {postres[contpos].Nombre}, {postres[contpos].Categoria}");
                    contpos++;
                }
                cont++;
            }

            contpan = 0;
            contpos = 0;
            foreach (Productos p in panes)
            {
                if (p == null) { break; }
                string aux = panes[contpan].Nombre;
                switch (contpan)
                {
                    case 0:
                        if (panes[contpan] != null)
                            this.button1.Text = "" + aux;
                        this.button1.ForeColor = Color.LightBlue;
                        this.button1.Enabled = false;
                        break;
                    case 1:
                        if (panes[contpan] != null)
                            this.button2.Text = "" + aux;
                        this.button2.ForeColor = Color.LightBlue;
                        this.button2.Enabled = false;
                        break;
                    case 2:
                        if (panes[contpan] != null)
                            this.button3.Text = "" + aux;
                        this.button3.ForeColor = Color.LightBlue;
                        this.button3.Enabled = false;
                        break;
                    case 3:
                        if (panes[contpan] != null)
                            this.button4.Text = "" + aux;
                        this.button4.ForeColor = Color.LightBlue;
                        this.button4.Enabled = false;
                        break;
                    case 4:
                        if (panes[contpan] != null)
                            this.button5.Text = "" + aux;
                        this.button5.ForeColor = Color.LightBlue;
                        this.button5.Enabled = false;
                        break;
                }
                contpan++;
            }
            for (int i = contpan; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        this.button1.Text = "Agregar :)";
                        break;
                    case 1:
                        this.button2.Text = "Agregar :)";
                        break;
                    case 2:
                        this.button3.Text = "Agregar :)";
                        break;
                    case 3:
                        this.button4.Text = "Agregar :)";
                        break;
                    case 4:
                        this.button5.Text = "Agregar :)";
                        break;
                }
            }
            foreach (Productos p in postres)
            {
                if (p == null) { break; }
                string aux = postres[contpos].Nombre;
                switch (contpos)
                {
                    case 0:
                        if (postres[contpos] != null)
                            this.button6.Text = "" + aux;
                        this.button6.ForeColor = Color.LightBlue;
                        this.button6.Enabled = false;
                        break;
                    case 1:
                        if (postres[contpos] != null)
                            this.button7.Text = "" + aux;
                        this.button7.ForeColor = Color.LightBlue;
                        this.button7.Enabled = false;
                        break;
                    case 2:
                        if (postres[contpos] != null)
                            this.button8.Text = "" + aux;
                        this.button8.ForeColor = Color.LightBlue;
                        this.button8.Enabled = false;
                        break;
                    case 3:
                        if (postres[contpos] != null)
                            this.button9.Text = "" + aux;
                        this.button9.ForeColor = Color.LightBlue;
                        this.button9.Enabled = false;
                        break;
                    case 4:
                        if (postres[contpos] != null)
                            this.button10.Text = "" + aux;
                        this.button10.ForeColor = Color.LightBlue;
                        this.button10.Enabled = false;
                        break;
                }
                contpos++;
            }
            for (int i = contpos; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        this.button6.Text = "Agregar :)";
                        break;
                    case 1:
                        this.button7.Text = "Agregar :)";
                        break;
                    case 2:
                        this.button8.Text = "Agregar :)";
                        break;
                    case 3:
                        this.button9.Text = "Agregar :)";
                        break;
                    case 4:
                        this.button10.Text = "Agregar :)";
                        break;
                }
            }
        }

        private void Altas(int pos)
        {
            Altitas form = new Altitas(pos);
            form.ShowDialog();
            this.Llenar();
        }

        private void button1_Click(object sender, EventArgs e) //Es el producto 1
        {
            this.Altas(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Altas(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Altas(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Altas(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Altas(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Altas(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Altas(2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Altas(2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Altas(2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Altas(2);
        }
        public void Fondo ()
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
                this.button7.BackColor = Color.FromArgb(212, 200, 175);
                this.button7.ForeColor = Color.FromArgb(78, 78, 78);
                this.button8.BackColor = Color.FromArgb(212, 200, 175);
                this.button8.ForeColor = Color.FromArgb(78, 78, 78);
                this.button6.BackColor = Color.FromArgb(212, 200, 175);
                this.button6.ForeColor = Color.FromArgb(78, 78, 78);
                this.button9.BackColor = Color.FromArgb(212, 200, 175);
                this.button9.ForeColor = Color.FromArgb(78, 78, 78);
                this.button10.BackColor = Color.FromArgb(212, 200, 175);
                this.button10.ForeColor = Color.FromArgb(78, 78, 78);
                //labels
                this.labelAltas.BackColor = Color.FromArgb(244, 241, 235);
                this.labelAltas.ForeColor = Color.Black;
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
                this.button7.BackColor = Color.FromArgb(24, 30, 54);
                this.button7.ForeColor = Color.FromArgb(70, 150, 250);
                this.button8.BackColor = Color.FromArgb(24, 30, 54);
                this.button8.ForeColor = Color.FromArgb(70, 150, 250);
                this.button6.BackColor = Color.FromArgb(24, 30, 54);
                this.button6.ForeColor = Color.FromArgb(70, 150, 250);
                this.button9.BackColor = Color.FromArgb(24, 30, 54);
                this.button9.ForeColor = Color.FromArgb(70, 150, 250);
                this.button10.BackColor = Color.FromArgb(24, 30, 54);
                this.button10.ForeColor = Color.FromArgb(70, 150, 250);
                //labels
                this.labelAltas.BackColor = Color.FromArgb(46, 51, 73);
                this.labelAltas.ForeColor = Color.Silver;
                
            }
        }
    }
}
