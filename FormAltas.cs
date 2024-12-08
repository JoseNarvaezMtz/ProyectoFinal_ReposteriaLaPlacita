﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTareaBaseDatos;

namespace WinFormsProyectoBase
{
    public partial class FormAltas : Form
    {
        List<Productos> list;
        Productos[] panes, postres;
        AdmonBD conexion;
        public FormAltas()
        {
            InitializeComponent();
            List<Productos> list;
            this.panes = new Productos[5];
            this.postres = new Productos[5];
            this.conexion = new AdmonBD();
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
                            this.btnExtra.Text = "" + aux;
                        this.ForeColor = Color.LightBlue;
                        this.btnExtra.Enabled = false;
                        break;
                    case 1:
                        if (panes[contpan] != null)
                            this.button1.Text = "" + aux;
                        this.ForeColor = Color.LightBlue;
                        this.button1.Enabled = false;
                        break;
                    case 2:
                        if (panes[contpan] != null)
                            this.button2.Text = "" + aux;
                        this.ForeColor = Color.LightBlue;
                        this.button2.Enabled = false;
                        break;
                    case 3:
                        if (panes[contpan] != null)
                            this.button3.Text = "" + aux;
                        this.ForeColor = Color.LightBlue;
                        this.button3.Enabled = false;
                        break;
                    case 4:
                        if (panes[contpan] != null)
                            this.button4.Text = "" + aux;
                        this.ForeColor = Color.LightBlue;
                        this.button4.Enabled = false;
                        break;
                }
                contpan++;
            }
            for (int i = contpan; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        this.btnExtra.Text = "Agregar :)";
                        break;
                    case 1:
                        this.button1.Text = "Agregar :)";
                        break;
                    case 2:
                        this.button2.Text = "Agregar :)";
                        break;
                    case 3:
                        this.button3.Text = "Agregar :)";
                        break;
                    case 4:
                        this.button4.Text = "Agregar :)";
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
                            this.button5.Text = "" + aux;
                        this.button5.Enabled = false;
                        break;
                    case 1:
                        if (postres[contpos] != null)
                            this.button6.Text = "" + aux;
                        this.button6.Enabled = false;
                        break;
                    case 2:
                        if (postres[contpos] != null)
                            this.button7.Text = "" + aux;
                        this.button7.Enabled = false;
                        break;
                    case 3:
                        if (postres[contpos] != null)
                            this.button8.Text = "" + aux;
                        this.button8.Enabled = false;
                        break;
                    case 4:
                        if (postres[contpos] != null)
                            this.button9.Text = "" + aux;
                        this.button9.Enabled = false;
                        break;
                }
                contpos++;
            }
            for (int i = contpos; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        this.button5.Text = "Agregar :)";
                        break;
                    case 1:
                        this.button6.Text = "Agregar :)";
                        break;
                    case 2:
                        this.button7.Text = "Agregar :)";
                        break;
                    case 3:
                        this.button8.Text = "Agregar :)";
                        break;
                    case 4:
                        this.button9.Text = "Agregar :)";
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

        private void btnExtra_Click(object sender, EventArgs e) //Es el producto 1
        {
            this.Altas(1);
        }

        private void button1_Click(object sender, EventArgs e)
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
            this.Altas(2);
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
    }
}
