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
    public partial class FormCantidadComprar : Form
    {
        private int Id;
        private string Nombre;
        private float Precio;
        private int Categoria;
        private int existencias;
        private int indice;

        public FormCantidadComprar()
        {
            InitializeComponent();
        }
        public FormCantidadComprar(int indice, int id, string nombre, int categoria, float precio, int existencias)
        {
            InitializeComponent();
            this.indice = indice;
            this.btnDismCompra.Enabled = false;
            this.buttonPago.Enabled = false;
            this.Id = id;
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Precio = precio;
            this.existencias = existencias;
        }
        private void btnAumCompra_Click(object sender, EventArgs e)
        {
            int nuevo = 0;
            nuevo = Convert.ToInt32(labelNumPorComprar.Text) + 1;
            labelNumPorComprar.Text = Convert.ToString(nuevo);
            if (nuevo > 0 && !btnDismCompra.Enabled)
            {
                btnDismCompra.Enabled = true;
            }
            if (nuevo == existencias)
            {
                btnAumCompra.Enabled = false;
            }

        }
        private void btnDismCompra_Click(object sender, EventArgs e)
        {
            int nuevo = 0;
            nuevo = Convert.ToInt32(labelNumPorComprar.Text) - 1;
            labelNumPorComprar.Text = Convert.ToString(nuevo);
            if (nuevo < existencias && !btnAumCompra.Enabled)
            {
                btnAumCompra.Enabled = true;
            }
            if (nuevo == 0)
            {
                btnDismCompra.Enabled = false;
                this.buttonPago.Enabled = false;
            }
        }
        //uwu
        private void buttonOtroProducto_Click(object sender, EventArgs e)
        {
            ClassCompras obj;
            bool flag = false;
            if (this.Categoria == 1)
            {
                obj = new ClassCompras(Convert.ToInt32(labelNumPorComprar.Text), FormBaseUsuario.listaPanes[indice], indice);
                FormBaseUsuario.listaPanes[indice].Existencias -= Convert.ToInt32(labelNumPorComprar.Text);
            }
            else
            {
                obj = new ClassCompras(Convert.ToInt32(labelNumPorComprar.Text), FormBaseUsuario.listaPostres[indice], indice);
                FormBaseUsuario.listaPostres[indice].Existencias -= Convert.ToInt32(labelNumPorComprar.Text);
            }
            foreach (ClassCompras var in FormBaseUsuario.productosSeleccionados)
            {
                if (var.producto == FormBaseUsuario.listaPanes[indice])
                {
                    var.cantidad += Convert.ToInt32(labelNumPorComprar.Text);
                    flag = true;
                    break;
                }
                else if (var.producto == FormBaseUsuario.listaPostres[indice])
                {
                    var.cantidad += Convert.ToInt32(labelNumPorComprar.Text);
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                FormBaseUsuario.productosSeleccionados.Add(obj);
            }
            this.Close();
        }

        private void buttonPago_Click(object sender, EventArgs e)
        {
            ClassCompras obj;
            bool flag = false;
            if (this.Categoria == 1)
            {
                obj = new ClassCompras(Convert.ToInt32(labelNumPorComprar.Text), FormBaseUsuario.listaPanes[indice], indice);
                FormBaseUsuario.listaPanes[indice].Existencias -= Convert.ToInt32(labelNumPorComprar.Text);
            }
            else
            {
                obj = new ClassCompras(Convert.ToInt32(labelNumPorComprar.Text), FormBaseUsuario.listaPostres[indice], indice);
                FormBaseUsuario.listaPostres[indice].Existencias -= Convert.ToInt32(labelNumPorComprar.Text);
            }
            foreach (ClassCompras var in FormBaseUsuario.productosSeleccionados)
            {
                if (var.producto == FormBaseUsuario.listaPanes[indice])
                {
                    var.cantidad += Convert.ToInt32(labelNumPorComprar.Text);
                    flag = true;
                    break;
                }
                else if (var.producto == FormBaseUsuario.listaPostres[indice])
                {
                    var.cantidad += Convert.ToInt32(labelNumPorComprar.Text);
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                FormBaseUsuario.productosSeleccionados.Add(obj);
            }
            FormMetodosPago metodosPago = new FormMetodosPago();
            metodosPago.Show();
            this.Close();
        }

        private void btnSalirMetPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
