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
using static System.Windows.Forms.DataFormats;

namespace WinFormsProyectoBase
{
    public partial class FormInicioSesion : Form
    {
        Random Musica = new Random();

        public int[] panDisp = { 0, 2, 3, 5, 0 }; //base de datos
        public int[] postreDisp = { 0, 2, 3, 5, 0 }; //base de datos
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (this.textBoxNomUsuario.Text.Equals(""))//sujeto a cambios por verificacion en base de datos
            {
                this.textBoxNomUsuario.Text = "Usuario";
            }
            FormBaseUsuario fU = new FormBaseUsuario(this.textBoxNomUsuario.Text, panDisp, postreDisp); //sujeto a cambios por verificacion en base de datos
            this.Hide();
            SoundPlayer ReproducirMusica = new SoundPlayer();
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Music", "Musica2.wav");
            ReproducirMusica.SoundLocation = ruta;
            ReproducirMusica.Play();
            fU.ShowDialog();
            this.Show();
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (this.textBoxNomUsuario.Text.Equals(""))//sujeto a cambios por verificacion en base de datos
            {
                this.textBoxNomUsuario.Text = "Usuario";
            }
            FormBaseAdmin fA = new FormBaseAdmin(this.textBoxNomUsuario.Text , panDisp, postreDisp);
            this.Hide();
            fA.ShowDialog();
            this.Show();
        }

    }
}
