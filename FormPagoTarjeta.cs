using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsProyectoBase
{
    public partial class FormPagoTarjeta : Form
    {
        private float total;
        private int cantidad;
        //Variables para ticket
        private string NumTarjeta; 
        private string NombreTarjeta;
        private string codigoSeg;
        private int year;
        private int month;

        public FormPagoTarjeta()
        {
            InitializeComponent();
            ConfigurarEventosTextBox();
            ImprimirDatos();
        }
        private void ConfigurarEventosTextBox()
        {
            textBoxNombreTarjeta.TextChanged += ValidarCampos;
            textBoxNumTarjeta.TextChanged += ValidarCampos;
            textBoxCodigo.TextChanged += ValidarCampos;
            textBoxYear.TextChanged += ValidarCampos;
            textBoxMes.TextChanged += ValidarCampos;
            ValidarCampos(null, EventArgs.Empty);
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            buttonPagar.Enabled = !string.IsNullOrWhiteSpace(textBoxNombreTarjeta.Text) && !string.IsNullOrWhiteSpace(textBoxNumTarjeta.Text) && !string.IsNullOrWhiteSpace(textBoxCodigo.Text) &&
                !string.IsNullOrWhiteSpace(textBoxYear.Text) && !string.IsNullOrWhiteSpace(textBoxMes.Text);
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            AdmonBD admonBD = new AdmonBD();
            AdmonBDUsuario admonBDUsuario = new AdmonBDUsuario();
            this.NombreTarjeta = textBoxNombreTarjeta.Text;
            this.NumTarjeta = textBoxNumTarjeta.Text;
            this.codigoSeg = textBoxCodigo.Text;
            this.year = Convert.ToInt32(textBoxYear.Text);
            this.month = Convert.ToInt32(textBoxMes.Text);

            //Validar Información
            if (ValidarNumeroTarjeta(NumTarjeta) && ValidarCodigoSeguridad(codigoSeg) && ValidarFecha(year, month) && NombreTarjeta.Length >= 1)
            {
                Usuarios user = admonBDUsuario.consultaUnRegistro(FormBaseUsuario.account);
                foreach (ClassCompras obj in FormBaseUsuario.productosSeleccionados)
                {
                    Productos aux;
                    if (obj.producto.Categoria == 1)
                        aux = FormBaseUsuario.listaPanes[obj.indice];
                    else
                        aux = FormBaseUsuario.listaPostres[obj.indice];
                    admonBD.actualizar(aux.Id, aux.Nombre, aux.Categoria, aux.Descripcion, aux.Imagen, aux.Precio, aux.Existencias);
                    user.Monto += obj.costo();
                }
                user.Monto *= 1.06f;
                admonBDUsuario.actualizar(user.Id, user.NombreCompleto, user.Categoria, user.Cuenta, user.Contrasena, user.Monto);
                FormTicket ticket = new FormTicket(this.total);
                ticket.ShowDialog();
                FormBaseUsuario.productosSeleccionados.Clear();
                this.Close();
            }
            else if (!ValidarNumeroTarjeta(NumTarjeta))
            {
                MessageBox.Show("Número de tarjeta inválido.");
            }
            else if (!ValidarCodigoSeguridad(codigoSeg))
            {
                MessageBox.Show("Código de seguridad inválido.");
            }
            else if (!ValidarFecha(year, month))
            {
                MessageBox.Show("Fecha inválida.");
            }
            else if (NombreTarjeta.Length < 1)
            {
                MessageBox.Show("Nombre inválido.");
            }
            else
            {
                MessageBox.Show("Error al leer la información, verifica que todo sea correcto.");
            }
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

        private bool ValidarNumeroTarjeta(string numeroTarjeta)
        {
            return !string.IsNullOrEmpty(numeroTarjeta) && numeroTarjeta.Length == 16 && numeroTarjeta.All(char.IsDigit);
        }

        private bool ValidarCodigoSeguridad(string codigoSeg)
        {
            return !string.IsNullOrEmpty(codigoSeg) && codigoSeg.Length == 3 && codigoSeg.All(char.IsDigit);
        }

        private bool ValidarFecha(int year, int month)
        {
            if (year >= 2024 && year <= 2034 && month >= 1 && month <= 12)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            textBoxTotalCompra.Text = this.total.ToString("F2");
        }

        private void btnSalirMetPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
