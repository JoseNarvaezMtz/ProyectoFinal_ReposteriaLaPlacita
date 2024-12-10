using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTareaBaseDatos;

namespace WinFormsProyectoBase
{
    public partial class FormModificaciones : Form
    {
        List<Productos> list;
        private int id;
        private string nombre;
        private int categoria;
        private string descripcion;
        private string imagen;
        private float precio;
        private int existencias;
        public FormModificaciones()
        {
            InitializeComponent();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            Productos productos;
            AdmonBD admon = new AdmonBD();

            int aux=-1;
            if (this.textBoxId.Text != string.Empty)
                aux = int.Parse(this.textBoxId.Text);

            productos=admon.consultaUnRegistro(aux);
            if (productos != null)
            {
                this.textBoxOldNom.Text = productos.Nombre;
                this.textBoxOldPre.Text = Convert.ToString(productos.Precio);
                this.textBoxOldEx.Text = Convert.ToString(productos.Existencias);
                this.textBoxOldCat.Text = Convert.ToString(productos.Categoria);
                this.textBoxOldDes.Text = productos.Descripcion;
                this.pictureBoxOldImg.ImageLocation = productos.Imagen;
            }
            else
            {
                this.textBoxOldNom.Text = string.Empty;
                this.textBoxOldPre.Text = string.Empty;
                this.textBoxOldEx.Text = string.Empty;
                this.textBoxOldCat.Text = string.Empty;
                this.textBoxOldDes.Text = string.Empty;
                this.pictureBoxOldImg.Image = null;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBoxNew.ImageLocation = abrirImagen.FileName;
                pictureBoxNew.SizeMode = PictureBoxSizeMode.StretchImage;
                this.imagen = abrirImagen.FileName;
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            AdmonBD admon = new AdmonBD();
            int aux=-1;
            if (this.textBoxId.Text != string.Empty)
                aux = int.Parse(this.textBoxId.Text);
            else
            {
                MessageBox.Show("Porfavor introducir un id");
                return;
            }

            Productos producto=admon.consultaUnRegistro(aux);
            
            if (producto == null)
            {
                MessageBox.Show("El id presentado no es valido, buscar otro");
                return;
            } else
            {
                this.nombre = producto.Nombre;
                this.precio = producto.Precio;
                this.existencias = producto.Existencias;
                this.categoria = producto.Categoria;
                this.descripcion = producto.Descripcion;
                if (this.imagen==string.Empty)
                    this.imagen = producto.Imagen;
            }

            if (this.textBoxNombre.Text != string.Empty)
                this.nombre = this.textBoxNombre.Text;
            if (this.textBoxPrecio.Text != string.Empty)
                this.precio = Convert.ToSingle(this.textBoxPrecio.Text);
            if (this.textBoxEx.Text != string.Empty)
                this.existencias = Convert.ToInt32(this.textBoxEx.Text);
            if (this.textBoxCat.Text != string.Empty)
                this.categoria=Convert.ToInt32(this.textBoxCat.Text);
            if (this.textBoxDes.Text != string.Empty)
                this.descripcion = this.textBoxDes.Text;

            AdmonBD admonBD = new AdmonBD();
            admonBD.actualizar(id, nombre, categoria, descripcion, imagen, precio, existencias);
            MessageBox.Show("El producto ha sido actualizado :)");

            this.textBoxId.Text = string.Empty;
            this.textBoxNombre.Text = string.Empty;
            this.textBoxCat.Text = string.Empty;
            this.textBoxEx.Text = string.Empty;
            this.textBoxPrecio.Text = string.Empty;
            this.textBoxDes.Text = string.Empty;
            this.pictureBoxNew = null;
        }
    }
}
