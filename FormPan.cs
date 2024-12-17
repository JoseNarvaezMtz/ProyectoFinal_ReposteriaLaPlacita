using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsProyectoBase
{
    public partial class FormPan : Form
    {
        //public int[] panDisp;
        public int[] posicion = new int[FormBaseUsuario.listaPanes.Count];
        public FormPan()
        {
            InitializeComponent();

            //Mostrar los paneles de acuerdo a los productos en Base de Datos
            int opcion = 0;
            for (int i = 0; i < FormBaseUsuario.listaPanes.Count; i++)
            {
                if (FormBaseUsuario.listaPanes.Count == 0)
                {
                    MessageBox.Show("No hay productos");
                }
                else
                {
                    opcion++;
                    switch (opcion)
                    {
                        case 1:
                            panelPan1.Visible = true;
                            btnComprarPan1.Visible = true;
                            btnDescPan1.Visible = true;
                            pictureBoxPan1.Visible = true;
                            //this.posicion[0] = i;
                            //cargar la imagen desde el dato de la lista
                            pictureBoxPan1.Image = Image.FromStream(new MemoryStream(FormBaseUsuario.listaPanes[0].Imagen));
                            pictureBoxPan1.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case 2:
                            panelPan2.Visible = true;
                            btnComprarPan2.Visible = true;
                            btnDescPan2.Visible = true;
                            pictureBoxPan2.Visible = true;
                            //cargar la imagen desde el dato de la lista
                            pictureBoxPan2.Image = Image.FromStream(new MemoryStream(FormBaseUsuario.listaPanes[1].Imagen));
                            pictureBoxPan2.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case 3:
                            panelPan3.Visible = true;
                            btnComprarPan3.Visible = true;
                            btnDescPan3.Visible = true;
                            pictureBoxPan3.Visible = true;
                            //cargar la imagen desde el dato de la lista
                            pictureBoxPan3.Image = Image.FromStream(new MemoryStream(FormBaseUsuario.listaPanes[2].Imagen));
                            pictureBoxPan3.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case 4:
                            panelPan4.Visible = true;
                            btnComprarPan4.Visible = true;
                            btnDescPan4.Visible = true;
                            pictureBoxPan4.Visible = true;
                            //cargar la imagen desde el dato de la lista
                            pictureBoxPan4.Image = Image.FromStream(new MemoryStream(FormBaseUsuario.listaPanes[3].Imagen));
                            pictureBoxPan4.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case 5:
                            panelPan5.Visible = true;
                            btnComprarPan5.Visible = true;
                            btnDescPan5.Visible = true;
                            pictureBoxPan5.Visible = true;
                            //cargar la imagen desde el dato de la lista
                            pictureBoxPan5.Image = Image.FromStream(new MemoryStream(FormBaseUsuario.listaPanes[4].Imagen));
                            pictureBoxPan5.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                    }
                }
            }
            this.verificarProdPan();
        }

        /* public FormPan(int[] panDisp)
         {
             InitializeComponent();
             this.panDisp = panDisp;

             verificarProdPan();

         }*/

        public void verificarProdPan()
        {

            Button[] botonesPan = {
                btnComprarPan1,
                btnComprarPan2,
                btnComprarPan3,
                btnComprarPan4,
                btnComprarPan5
            };

            for (int i = 0; i < FormBaseUsuario.listaPanes.Count; i++)
            {
                if (FormBaseUsuario.listaPanes[i].Existencias == 0)
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
            //int pos = posicion[1];
            int id = FormBaseUsuario.listaPanes[0].Id;
            string nombre = FormBaseUsuario.listaPanes[0].Nombre;
            int categoria = FormBaseUsuario.listaPanes[0].Categoria;
            float precio = FormBaseUsuario.listaPanes[0].Precio;
            int existencias = FormBaseUsuario.listaPanes[0].Existencias;
            FormCantidadComprar form = new FormCantidadComprar(0, id, nombre, categoria, precio, existencias);
            form.ShowDialog();
            verificarProdPan();
        }

        private void btnComprarPanNuez_Click(object sender, EventArgs e)
        {
            //pendiente ver la dinamica de la compra
            int id = FormBaseUsuario.listaPanes[1].Id;
            string nombre = FormBaseUsuario.listaPanes[1].Nombre;
            int categoria = FormBaseUsuario.listaPanes[1].Categoria;
            float precio = FormBaseUsuario.listaPanes[1].Precio;
            int existencias = FormBaseUsuario.listaPanes[1].Existencias;
            FormCantidadComprar form = new FormCantidadComprar(1, id, nombre, categoria, precio, existencias);
            //FormMetodosPago form = new FormMetodosPago(panDisp, 1);
            form.ShowDialog();
            verificarProdPan();
        }

        private void btnComprarPanPay_Click(object sender, EventArgs e)
        {
            int id = FormBaseUsuario.listaPanes[2].Id;
            string nombre = FormBaseUsuario.listaPanes[2].Nombre;
            int categoria = FormBaseUsuario.listaPanes[2].Categoria;
            float precio = FormBaseUsuario.listaPanes[2].Precio;
            int existencias = FormBaseUsuario.listaPanes[2].Existencias;
            FormCantidadComprar form = new FormCantidadComprar(2, id, nombre, categoria, precio, existencias);
            //FormMetodosPago form = new FormMetodosPago(panDisp, 2);
            form.ShowDialog();
            verificarProdPan();
        }

        private void btnComprarPanRol_Click(object sender, EventArgs e)
        {
            int id = FormBaseUsuario.listaPanes[3].Id;
            string nombre = FormBaseUsuario.listaPanes[3].Nombre;
            int categoria = FormBaseUsuario.listaPanes[3].Categoria;
            float precio = FormBaseUsuario.listaPanes[3].Precio;
            int existencias = FormBaseUsuario.listaPanes[3].Existencias;
            FormCantidadComprar form = new FormCantidadComprar(3, id, nombre, categoria, precio, existencias);
            //FormMetodosPago form = new FormMetodosPago(panDisp, 3);
            form.ShowDialog();
            verificarProdPan();
        }

        private void btnComprarPanIndef_Click(object sender, EventArgs e)
        {
            int id = FormBaseUsuario.listaPanes[4].Id;
            string nombre = FormBaseUsuario.listaPanes[4].Nombre;
            int categoria = FormBaseUsuario.listaPanes[4].Categoria;
            float precio = FormBaseUsuario.listaPanes[4].Precio;
            int existencias = FormBaseUsuario.listaPanes[4].Existencias;
            FormCantidadComprar form = new FormCantidadComprar(4, id, nombre, categoria, precio, existencias);
            //FormMetodosPago form = new FormMetodosPago(panDisp, 4);
            form.ShowDialog();
            verificarProdPan();
        }

        private void FormPan_Load(object sender, EventArgs e)
        {

        }

        private void btnDescPan1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{FormBaseUsuario.listaPanes[0].Descripcion} \n\t\t Precio: {FormBaseUsuario.listaPanes[0].Precio}");
        }

        private void btnDescPan2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{FormBaseUsuario.listaPanes[1].Descripcion} \n\t\t Precio: {FormBaseUsuario.listaPanes[1].Precio}");
        }

        private void btnDescPan3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{FormBaseUsuario.listaPanes[2].Descripcion} \n\t\t Precio: {FormBaseUsuario.listaPanes[2].Precio}");
        }

        private void btnDescPan4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{FormBaseUsuario.listaPanes[3].Descripcion} \n\t\t Precio: {FormBaseUsuario.listaPanes[3].Precio}");
        }

        private void btnDescPan5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{FormBaseUsuario.listaPanes[4].Descripcion} \n\t\t Precio: {FormBaseUsuario.listaPanes[4].Precio}");
        }
    }

}
