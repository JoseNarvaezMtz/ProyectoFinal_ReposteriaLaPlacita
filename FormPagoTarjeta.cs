using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsProyectoBase
{
    public partial class FormPagoTarjeta : Form
    {
        private float total;
        private int cantidad;
        //PARA BASE DE DATOOOOOOOOOOOOOOOOOOOOOOOOS SE NECESITA ESTOOOOOOO
        private int Id;
        private string Nombre;
        private float Precio;  //YA NO SE OCUPA ESTO, RECUERDA QUE AHORA LO HACES CON LISTAS
        //Variables para ticket
        private string NumTarjeta; //así es el numero es un string jshajhsajahjsjaahsjahsj, como quiera no se ocupa para nada, solo se va a mostrar en el ticket
        private string NombreTarjeta;
        private string codigoSeg;
        private int year;
        private int month;

        public FormPagoTarjeta()
        {
            InitializeComponent();
            ConfigurarEventosTextBox();
        }

        public FormPagoTarjeta(int cantidad, int id, string nombre, float precio)
        {
            //IMPORTANTEEEEEEEEEEEEEEEEEEEEEEEEE
            //this.Id = id;
            //this.Nombre = nombre;
            //this.Precio = precio;
            //YA NO SE OCUPA LO DE ARRIBA, O SI LO QUIERES MANEJAR CON ESO TU LO CHECAS, SI NO, ES INICIALIZAR LA LISTA
            InitializeComponent();
            ConfigurarEventosTextBox();
            //esto quitalo nada mas era para que funcionara este constructor ya no debe de estar cantidad
            this.cantidad = cantidad;
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
            //IMPORTANTEEEEEEEEEEEEEE JOSEEEEEEEEE/LORENAAAAAAAA
            //Darle click a esto es que ya se pagó, entonces sube el importe o lo que se necesite a la base de datos y lo de abajo ya es pura estética del ticket
            //IMPORTANTE PARA JULIÁN (YO JIJJIJI) / LORENA
            //Al precionar este botón se abre otro form que muestre el reporte de pago, donde se ven todos los datos de la compra
            //se supone que será el mismo form para los 3 métodos, solo que mandaremos diferentes firmas para que cada caso tenga su propio constructor

            //aqui tienes que ahcer
            //total += (NombreLista.precio + NombreLista.Precio * 0.06);
            this.NombreTarjeta = textBoxNombreTarjeta.Text;
            this.NumTarjeta = textBoxNumTarjeta.Text;
            this.codigoSeg = textBoxCodigo.Text;
            this.year = Convert.ToInt32(textBoxYear.Text);
            this.month = Convert.ToInt32(textBoxMes.Text);

            //Validar Información
            if (ValidarNumeroTarjeta(NumTarjeta) && ValidarCodigoSeguridad(codigoSeg) && ValidarFecha(year, month) && NombreTarjeta.Length >= 1)
            {
                //Entra al siguiente form con los datos que se necesiten para hacer el ticket
                //osea mandas la lista, si manejas cantidad con un vector tambien y el float total 
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
        private void richTextBoxProductosSelec_TextChanged(object sender, EventArgs e)
        {
            //aqui debes de mostrar igual en un foreach cada producto de la lista
        }

        private void richTextBoxCantidadSelecc_TextChanged(object sender, EventArgs e)
        {
            //Muestras en foreach o for dependiendo de como lo hiciste la cantidad
        }

        private void textBoxTotalCompra_TextChanged(object sender, EventArgs e)
        {
            //recorres un foreach que se va sumando a total += (NombreLista.precio + NombreLista.Precio * 0.06);
            //esa multiplicación es por lode intereses, tmb se va a hacer eso en los otros métodos

        }

        private void btnSalirMetPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
