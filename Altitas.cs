using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsProyectoBase
{
    public partial class Altitas : Form
    {
        private int id;
        private string nombre;
        private int categoria;
        private string descripcion;
        private string imagen;
        private float precio;
        private int existencias;
        public Altitas(int pos)
        {
            InitializeComponent();
            this.categoria = pos;
            this.imagen= string.Empty;
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBoxpreview.Image = Image.FromFile(abrirImagen.FileName);
                pictureBoxpreview.SizeMode = PictureBoxSizeMode.StretchImage;
                this.imagen = abrirImagen.FileName;
            }
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            if (this.textBoxId.Text=="" || this.textBoxNom.Text=="" || this.textBoxPre.Text == "" || 
                this.textBoxEx.Text=="" || this.textBoxDes.Text == "" || this.imagen == "")
            {
                MessageBox.Show("Porfavor introduzca todos los valores");
                return;
            }
            this.id=int.Parse(this.textBoxId.Text);
            this.nombre=this.textBoxNom.Text;
            this.precio=Convert.ToSingle(this.textBoxPre.Text);
            this.existencias = int.Parse(this.textBoxEx.Text);
            this.descripcion=this.textBoxDes.Text;
            AdmonBD admonBD = new AdmonBD();
            admonBD.insertar(id, nombre, categoria, descripcion, imagen, precio, existencias);
            MessageBox.Show("El producto ha sido agregado correctamente ;)");

            this.Close();
        }
    }
}
