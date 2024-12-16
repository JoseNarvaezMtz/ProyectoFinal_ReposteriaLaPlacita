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
        private float total;
        private float PagoCambio;
        private float PagoCliente;
        public FormPagoCaja()
        {
            InitializeComponent();
            ImprimirDatos();
            buttonPagar.Enabled = false;
        }
        private void buttonPagar_Click(object sender, EventArgs e)
        {
            FormTicket ticket = new FormTicket(this.total);
            ticket.ShowDialog();
            this.Close();
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

        private void ImprimirDatos()
        {
            Font font = new Font(richTextBoxProductosSelec.Font.FontFamily, 14);
            richTextBoxProductosSelec.Clear();
            richTextBoxCantidadSelecc.Clear();
            richTextBoxProductosSelec.Font = font;
            richTextBoxCantidadSelecc.Font = font;

            foreach (ClassCompras var in FormBaseUsuario.productosSeleccionados)
            {
                richTextBoxProductosSelec.AppendText(var.producto.Nombre + Environment.NewLine);
                richTextBoxCantidadSelecc.AppendText(var.cantidad.ToString() + Environment.NewLine);
                this.total += var.costo() * 1.06f;
            }
            textBoxCantidadPagar.Text = this.total.ToString("F2");
        }
        private void Calcular()
        {
            this.PagoCliente = Convert.ToSingle(textBoxPagoCliente.Text);
            textBoxCambio.Text = Convert.ToString(this.PagoCliente);
        }

        private void btnSalirMetPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPagoCliente_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPagoCliente.Text == string.Empty)
            {
                this.textBoxCambio.Text = "0";
                return;
            }
            float aux;
            aux = Convert.ToSingle(textBoxPagoCliente.Text) - this.total;
            if (aux < 0 )
            {
                this.textBoxCambio.Text = "0";
                this.buttonPagar.Enabled = false;
            }
            else { 
                this.textBoxCambio.Text = Convert.ToString(aux);
                this.buttonPagar.Enabled = true;
            }
        }
    }
}
