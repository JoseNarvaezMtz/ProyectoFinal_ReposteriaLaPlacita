using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoBase
{
    public partial class FormMetodosPago : Form
    {
        //PARA BASE DE DATOOOOOOOOOOOOOOOOOOOOOOOOS SE NECESITA ESTOOOOOOO
        private int Id;
        private string Nombre;
        private float Precio;

        public int[] Disp;
        public int indice;
        public FormMetodosPago()
        {
            InitializeComponent();
        }

        public FormMetodosPago(int[] Disp, int indice/*int id, string nombre, float precio*/)
        {
            InitializeComponent();
            this.Disp = Disp;
            this.indice = indice;
            this.btnDismCompra.Enabled = false;
            this.buttonPagoCaja.Enabled = false;
            this.buttonPagoOxxo.Enabled = false;
            this.buttonPagoTarjeta.Enabled = false;

            //IMPORTANTEEEEEEEEEEEEEEEEEEEEEEEEE
            //this.Id = id;
            //this.Nombre = nombre;
            //thos.Precio = precio;
        }

        public void metCompra()
        {
            MessageBox.Show("Aqui se deberia abrir o descargar el recibo" +
                            "\ncreo no estoy seguro de como sea la verdad" +
                            "\npero bueno es funcional por ahora         " +
                            "\n                                          " +
                            "\n\n\t\t¡¡Compra Exitosa!! ");
        }

        private void buttonPagoCaja_Click(object sender, EventArgs e)
        {
            //ReproducirSonido("Tecla.wav");
            this.Disp[this.indice] -= Convert.ToInt32(labelNumPorComprar.Text);
            FormPagoCaja caja = new FormPagoCaja(/*MANDAS LA LISTA Y LO QUE NECEISTES Y CREAS EL CONSTRUCTOR EN EL FORM*/);
            //OJO IMPORTANTE, TENEMOS QUE CERRAR ESTE FORM CUANDO LE DEN CLICK AL BOTTON, AÚN NO SE SI CON HIDDE O CLOSE
            caja.Show();
        }

        private void buttonPagoTarjeta_Click(object sender, EventArgs e)
        {
            int totalSeleccionado;
            //ReproducirSonido("Tecla.wav");
            this.Disp[this.indice] -= Convert.ToInt32(labelNumPorComprar.Text);
            //IMPORTANTEEEEEEEEEEEEEEEEEEEE AQUI DEBE DE RECIBIR COMO OTRO PARAMETRO LA ID DEL PRODUCTO, SU NOMBRE Y EL PRECIO
            //SE NECESITA LA BASE DE DATOS PARA QUE SE PUEDAN UTILIZAR ESOS DATOS
            //IMPORTANTE AJUSTE A LISTA, esto ya no se va a manejar con this.id,nombre,precio, si no ahora tienes que mandar
            //al constructor del form metodo de pago una lista con los productos que ya contienen cada uno de los datos
            //osea solo manda la lista la cual ya contiene todos los datos
            totalSeleccionado = Convert.ToInt32(labelNumPorComprar.Text);
            FormPagoTarjeta tarjeta = new FormPagoTarjeta(totalSeleccionado /*,this.ID, this.Nombre, this.Precio */);
            //OJO IMPORTANTE, TENEMOS QUE CERRAR ESTE FORM CUANDO LE DEN CLICK AL BOTTON, AÚN NO SE SI CON HIDDE O CLOSE
            tarjeta.Show();
        }

        private void buttonPagoOxxo_Click(object sender, EventArgs e)
        {
            //ReproducirSonido("Tecla.wav");
            this.Disp[this.indice] -= Convert.ToInt32(labelNumPorComprar.Text);
            //OJO IMPORTANTE, TENEMOS QUE CERRAR ESTE FORM CUANDO LE DEN CLICK AL BOTTON, AÚN NO SE SI CON HIDDE O CLOSE
        }

        private void btnAumCompra_Click(object sender, EventArgs e)
        {
            //ReproducirSonido("Tecla.wav");
            int nuevo = 0;
            nuevo = Convert.ToInt32(labelNumPorComprar.Text) + 1;
            labelNumPorComprar.Text = Convert.ToString(nuevo);
            verificarProd();

        }

        private void btnDismCompra_Click(object sender, EventArgs e)
        {
            //ReproducirSonido("Tecla.wav");
            int nuevo = 0;
            nuevo = Convert.ToInt32(labelNumPorComprar.Text) - 1;
            labelNumPorComprar.Text = Convert.ToString(nuevo);
            verificarProd();
        }

        private void btnSalirMetPago_Click(object sender, EventArgs e)
        {
            //ReproducirSonido("Tecla.wav");
            //EXPLICACIÓOOOOOON IMPORTANTEEEEEEEEEEEEE
            //Como estamos manejando toda la informacíón dentro de los botones de confirmación de producto
            //ya no es necesario vaciar la lista o eliminar el producto seleccionado de la misma por que solo se agregan cuando ya
            //se confirmó la selección
            this.Close();
        }

        public void verificarProd()
        {
            if (Convert.ToInt32(labelNumPorComprar.Text) == 0)
            {
                this.btnDismCompra.Enabled = false;
                this.buttonPagoCaja.Enabled = false;
                this.buttonPagoOxxo.Enabled = false;
                this.buttonPagoTarjeta.Enabled = false;
            }
            else
            {
                this.btnDismCompra.Enabled = true;
                this.buttonPagoCaja.Enabled = true;
                this.buttonPagoOxxo.Enabled = true;
                this.buttonPagoTarjeta.Enabled = true;
            }

            if (Convert.ToInt32(labelNumPorComprar.Text) == Disp[indice])
            {
                this.btnAumCompra.Enabled = false;
            }
            else
            {
                this.btnAumCompra.Enabled = true;
            }
        }
        private void ReproducirSonido(string nombreArchivo)
        {
            SoundPlayer ReproducirSonido = new SoundPlayer();
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Music", nombreArchivo);
            ReproducirSonido.SoundLocation = ruta;
            ReproducirSonido.Play();
        }

        private void buttonOtroProducto_Click(object sender, EventArgs e)
        {
            // Aqui tienes que hacer que se agreguen los productos a la lista, ademas que disminuya
            // el numero del producto disponible que se seleccionó y eso si quieres lo guardas en un vector que también se mande como parámetro
            //ooooo tambien no se si la base de datos cuente con un campo cantidad seleccionada o algo así que solo se utilizaría para el usuario
            // y funcionaría como un auxiliar, creo que esta manera sería la mas correcta y comoda, pero no se que tengan q modificar en base de datos
        }
    }
}
