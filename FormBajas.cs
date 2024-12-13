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
        List<Productos> list;
        AdmonBD conexion;
        Productos[] panes, postres;
        int cant;
        private bool Modo;
        public FormBajas(bool modo)
        {
            InitializeComponent();
            List<Productos> list = new List<Productos>();
            this.panes = new Productos[5];
            this.postres = new Productos[5];
            this.conexion = new AdmonBD();
            this.Modo= modo;
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
            cant = cont;
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
                        break;
                    case 1:
                        if (panes[contpan] != null)
                            this.button2.Text = "" + aux;
                        break;
                    case 2:
                        if (panes[contpan] != null)
                            this.button3.Text = "" + aux;
                        break;
                    case 3:
                        if (panes[contpan] != null)
                            this.button4.Text = "" + aux;
                        break;
                    case 4:
                        if (panes[contpan] != null)
                            this.button5.Text = "" + aux;
                        break;
                }
                contpan++;
            }
            for (int i = contpan; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        this.button1.Text = "Nada que eliminar";
                        this.button1.ForeColor = Color.Red;
                        this.button1.Enabled = false;
                        break;
                    case 1:
                        this.button2.Text = "Nada que eliminar";
                        this.button2.ForeColor = Color.Red;
                        this.button2.Enabled = false;
                        break;
                    case 2:
                        this.button3.Text = "Nada que eliminar";
                        this.button3.ForeColor = Color.Red;
                        this.button3.Enabled = false;
                        break;
                    case 3:
                        this.button4.Text = "Nada que eliminar";
                        this.button4.ForeColor = Color.Red;
                        this.button4.Enabled = false;
                        break;
                    case 4:
                        this.button5.Text = "Nada que eliminar";
                        this.button5.ForeColor = Color.Red;
                        this.button5.Enabled = false;
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
                        break;
                    case 1:
                        if (postres[contpos] != null)
                            this.button7.Text = "" + aux;
                        break;
                    case 2:
                        if (postres[contpos] != null)
                            this.button8.Text = "" + aux;
                        break;
                    case 3:
                        if (postres[contpos] != null)
                            this.button9.Text = "" + aux;
                        break;
                    case 4:
                        if (postres[contpos] != null)
                            this.button10.Text = "" + aux;
                        break;
                }
                contpos++;
            }
            for (int i = contpos; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        this.button6.Text = "Nada que eliminar";
                        this.button6.ForeColor = Color.Red;
                        this.button6.Enabled = false;
                        break;
                    case 1:
                        this.button7.Text = "Nada que eliminar";
                        this.button7.ForeColor = Color.Red;
                        this.button7.Enabled = false;
                        break;
                    case 2:
                        this.button8.Text = "Nada que eliminar";
                        this.button8.ForeColor = Color.Red;
                        this.button8.Enabled = false;
                        break;
                    case 3:
                        this.button9.Text = "Nada que eliminar";
                        this.button9.ForeColor = Color.Red;
                        this.button9.Enabled = false;
                        break;
                    case 4:
                        this.button10.Text = "Nada que eliminar";
                        this.button10.ForeColor = Color.Red;
                        this.button10.Enabled = false;
                        break;
                }
            }
        }

        private void Bajas(int pos)
        {
            if (this.cant == 6)
            {
                MessageBox.Show("No se pueden eliminar mas productos, porfavor no seguir intentando");
                return;
            }

            int id = 0;
            if (pos < 5)
            {
                if (panes[pos] != null)
                {
                    id = panes[pos].Id;
                }
            }
            else
            {
                if (postres[pos] != null)
                {
                    id = postres[pos % 5].Id;
                }
            }

            //MessageBox.Show("Mandando id: " + id);
            Bajitas form = new Bajitas(id);
            form.ShowDialog();
            for (int i=0; i<5; i++)
            {
                this.panes[i] = null;
                this.postres[i] = null;
            }
            this.Llenar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Bajas(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Bajas(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Bajas(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Bajas(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Bajas(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Bajas(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Bajas(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Bajas(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Bajas(8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Bajas(9);
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
