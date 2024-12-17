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

        //public int[] postreDisp;
        public FormPostres()
        {
            InitializeComponent();
            //Mostrar los paneles de acuerdo a los productos en Base de Datos
            int opcion = 0;
            for (int i = 0; i < FormBaseUsuario.listaPostres.Count; i++)
            {
                if (FormBaseUsuario.listaPostres.Count == 0)
                {
                    MessageBox.Show("No hay productos");
                }
                else
                {
                    opcion++;
                    switch (opcion)
                    {
                        case 1:
                            panelPostre1.Visible = true;
                            btnComprarPostre1.Visible = true;
                            btnDescPostre1.Visible = true;
                            pictureBoxPostre1.Visible = true;
                            //this.posicion[0] = i;
                            //cargar la imagen desde el dato de la lista
                            pictureBoxPostre1.Image = Image.FromStream(new MemoryStream(FormBaseUsuario.listaPostres[0].Imagen));
                            pictureBoxPostre1.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case 2:
                            panelPostre2.Visible = true;
                            btnComprarPostre2.Visible = true;
                            btnDescPostre2.Visible = true;
                            pictureBoxPostre2.Visible = true;
                            //cargar la imagen desde el dato de la lista
                            pictureBoxPostre2.Image = Image.FromStream(new MemoryStream(FormBaseUsuario.listaPostres[1].Imagen));
                            pictureBoxPostre2.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case 3:
                            panelPostre3.Visible = true;
                            btnComprarPostre3.Visible = true;
                            btnDescPostre3.Visible = true;
                            pictureBoxPostre3.Visible = true;
                            //cargar la imagen desde el dato de la lista
                            pictureBoxPostre3.Image = Image.FromStream(new MemoryStream(FormBaseUsuario.listaPostres[2].Imagen));
                            pictureBoxPostre3.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case 4:
                            panelPostre4.Visible = true;
                            btnComprarPostre4.Visible = true;
                            btnDescPostre4.Visible = true;
                            pictureBoxPostre4.Visible = true;
                            //cargar la imagen desde el dato de la lista
                            pictureBoxPostre4.Image = Image.FromStream(new MemoryStream(FormBaseUsuario.listaPostres[3].Imagen));
                            pictureBoxPostre4.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case 5:
                            panelPostre5.Visible = true;
                            btnComprarPostre5.Visible = true;
                            btnDescPostre5.Visible = true;
                            pictureBoxPostre5.Visible = true;
                            //cargar la imagen desde el dato de la lista
                            pictureBoxPostre5.Image = Image.FromStream(new MemoryStream(FormBaseUsuario.listaPostres[4].Imagen));
                            pictureBoxPostre5.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                    }
                }
            }
            this.verificarProdPost();
        }

        /*public FormPostres(int[] postreDisp)
        {
            InitializeComponent();
            this.postreDisp = postreDisp;
            verificarProdPost();

        }*/

        public void verificarProdPost()
        {
            Button[] botonesPostre = {
                btnComprarPostre1,
                btnComprarPostre2,
                btnComprarPostre3,
                btnComprarPostre4,
                btnComprarPostre5
            };

            for (int i = 0; i < FormBaseUsuario.listaPostres.Count; i++)
            {
                if (FormBaseUsuario.listaPostres[i].Existencias == 0)
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
            int id = FormBaseUsuario.listaPostres[0].Id;
            string nombre = FormBaseUsuario.listaPostres[0].Nombre;
            int categoria = FormBaseUsuario.listaPostres[0].Categoria;
            float precio = FormBaseUsuario.listaPostres[0].Precio;
            int existencias = FormBaseUsuario.listaPostres[0].Existencias;
            FormCantidadComprar form = new FormCantidadComprar(0, id, nombre, categoria, precio, existencias);
            form.ShowDialog();
            verificarProdPost();
        }

        private void btnComprarPostreCupcake_Click(object sender, EventArgs e)
        {
            int id = FormBaseUsuario.listaPostres[1].Id;
            string nombre = FormBaseUsuario.listaPostres[1].Nombre;
            int categoria = FormBaseUsuario.listaPostres[1].Categoria;
            float precio = FormBaseUsuario.listaPostres[1].Precio;
            int existencias = FormBaseUsuario.listaPostres[1].Existencias;
            FormCantidadComprar form = new FormCantidadComprar(1, id, nombre, categoria, precio, existencias);
            form.ShowDialog();
            verificarProdPost();
        }

        private void btnComprarPostreBrownie_Click(object sender, EventArgs e)
        {
            int id = FormBaseUsuario.listaPostres[2].Id;
            string nombre = FormBaseUsuario.listaPostres[2].Nombre;
            int categoria = FormBaseUsuario.listaPostres[2].Categoria;
            float precio = FormBaseUsuario.listaPostres[2].Precio;
            int existencias = FormBaseUsuario.listaPostres[2].Existencias;
            FormCantidadComprar form = new FormCantidadComprar(2, id, nombre, categoria, precio, existencias);
            form.ShowDialog();
            verificarProdPost();
        }

        private void btnComprarPostreCupcakeKitty_Click(object sender, EventArgs e)
        {
            int id = FormBaseUsuario.listaPostres[3].Id;
            string nombre = FormBaseUsuario.listaPostres[3].Nombre;
            int categoria = FormBaseUsuario.listaPostres[3].Categoria;
            float precio = FormBaseUsuario.listaPostres[3].Precio;
            int existencias = FormBaseUsuario.listaPostres[3].Existencias;
            FormCantidadComprar form = new FormCantidadComprar(3, id, nombre, categoria, precio, existencias);
            form.ShowDialog();
            verificarProdPost();
        }

        private void btnComprarPostreCupcakeNavidad_Click(object sender, EventArgs e)
        {
            int id = FormBaseUsuario.listaPostres[4].Id;
            string nombre = FormBaseUsuario.listaPostres[4].Nombre;
            int categoria = FormBaseUsuario.listaPostres[4].Categoria;
            float precio = FormBaseUsuario.listaPostres[4].Precio;
            int existencias = FormBaseUsuario.listaPostres[4].Existencias;
            FormCantidadComprar form = new FormCantidadComprar(4, id, nombre, categoria, precio, existencias);
            form.ShowDialog();
            verificarProdPost();
        }

        private void btnDescPostre1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"\t\t{FormBaseUsuario.listaPostres[0].Nombre} \n {FormBaseUsuario.listaPostres[0].Descripcion} \n\t Existencias: {FormBaseUsuario.listaPostres[0].Existencias} \t Precio: {FormBaseUsuario.listaPostres[0].Precio}");
        }

        private void btnDescPostre2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"\t\t{FormBaseUsuario.listaPostres[1].Nombre} \n {FormBaseUsuario.listaPostres[1].Descripcion} \n\t Existencias: {FormBaseUsuario.listaPostres[1].Existencias} \t Precio: {FormBaseUsuario.listaPostres[1].Precio}");
        }

        private void btnDescPostre3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"\t\t{FormBaseUsuario.listaPostres[2].Nombre} \n {FormBaseUsuario.listaPostres[2].Descripcion} \n\t Existencias: {FormBaseUsuario.listaPostres[2].Existencias} \t Precio: {FormBaseUsuario.listaPostres[2].Precio}");
        }

        private void btnDescPostre4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"\t\t{FormBaseUsuario.listaPostres[3].Nombre} \n {FormBaseUsuario.listaPostres[3].Descripcion} \n\t Existencias: {FormBaseUsuario.listaPostres[3].Existencias} \t Precio: {FormBaseUsuario.listaPostres[3].Precio}");
        }

        private void btnDescPostre5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"\t\t{FormBaseUsuario.listaPostres[4].Nombre} \n {FormBaseUsuario.listaPostres[4].Descripcion} \n\t Existencias: {FormBaseUsuario.listaPostres[4].Existencias} \t Precio: {FormBaseUsuario.listaPostres[4].Precio}");
        }
    }
}
