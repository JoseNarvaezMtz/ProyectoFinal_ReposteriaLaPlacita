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
    public partial class FormPagoCaja : Form
    {
        //creas la variable list que va a usarse en tu constructor
        //y dependiendo de como manejes cantidad seleccionada pones aqui la variable de eso, o si lo manejas en la propia lista ignora esto
        private float total;
        private float PagoCambio;
        public FormPagoCaja()
        {
            InitializeComponent();
        }
        //NO OLVIDES QUE AQUI TIENES QUE CREAR EL CONSTRUCTOR CON LA LISTA Y LO DEMÁS SI ES QUE HAY ALGO MAS

        private void textBoxProducto_TextChanged(object sender, EventArgs e)
        {
            //aqui debe de mostrar los productos seleccionados dentro de un foreach
        }

        private void richTextBoxProductosSelec_TextChanged(object sender, EventArgs e)
        {
            //muestras las cantidades igual con un foreach si es con lista y solo muestras la cantidad, 
            // recuerda el convert.ToString para que se muestre en la richTextBox
        }
        private void textBoxCantidadPagar_TextChanged(object sender, EventArgs e)
        {
            //recorres un foreach que se va sumando a total += (NombreLista.precio + NombreLista.Precio * 0.06);
            //esa multiplicación es por lode intereses, tmb se va a hacer eso en los otros métodos
        }
        private void textBoxPagoTotal_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonCambio_Click(object sender, EventArgs e)
        {
            float PagoCliente;
            float cambio;
            float total;
            PagoCliente = float.Parse(textBoxPagoTotal.Text);
            total = this.total;
            cambio = (total - PagoCliente);
            if (cambio >= 0)
            {
                this.PagoCambio = cambio;
                textBoxCambio.Text = PagoCliente.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un precio válido");
            }
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            //mandas todoooooooooo lo que necesites aqui y creas el constructor en el form de ticket
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            if (FormBaseUsuario.productosSeleccionados.Count == 0)
            {
                MessageBox.Show("No hay ningun producto seleccionado!");
                return;
            }
            foreach (ClassCompras var in FormBaseUsuario.productosSeleccionados)
            {
                if (var.producto.Categoria == 1)
                {
                    FormBaseUsuario.listaPanes[var.indice].Existencias += var.cantidad;
                }
                else FormBaseUsuario.listaPostres[var.indice].Existencias += var.cantidad;
            }
            FormBaseUsuario.productosSeleccionados.Clear();
            MessageBox.Show("Sus productos se han eliminado de la lista correctamente!");
            this.Close();
        }
    }
}
