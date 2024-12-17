using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsProyectoBase
{
    public partial class Bajitas : Form
    {
        private int id;
        public Bajitas(int id)
        {
            InitializeComponent();
            this.id = id;
            this.info();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eso pense");
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            AdmonBD admonBD = new AdmonBD();
            admonBD.eliminar(this.id);
            MessageBox.Show("El producto ha sido removido de la base de datos :)");
            this.Close();
        }

        private void info()
        {
            AdmonBD admonBD = new AdmonBD();
            Productos p = admonBD.consultaUnRegistro(id);
            string aux = string.Empty;

            this.pictureBoxListado.Image = Image.FromStream(new MemoryStream(p.Imagen));
            this.textBoxId.Text = "Id: " + Convert.ToString(p.Id);
            this.textBoxNombre.Text = "Nombre: " + (p.Nombre);
            this.textBoxPrecio.Text = "Precio: " + Convert.ToString(p.Precio);
            this.textBoxExistencias.Text = "Existencias: " + Convert.ToString(p.Existencias);
            this.textBoxDescripcion.Text = "Descripción: " + (p.Descripcion);
        }
    }
}
