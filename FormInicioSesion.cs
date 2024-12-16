using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        /* public int[] panDisp = { 0, 2, 3, 5, 0 }; //base de datos
         public int[] postreDisp = { 0, 2, 3, 5, 0 }; //base de datos*/
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        //Función para validar el inicio de sesión del usuario desde la Base de Datos
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AdmonBDUsuario obj = new AdmonBDUsuario();
            Usuarios aux = obj.consultaUnRegistro(this.textBoxNomUsuario.Text);

            //Validación en el llenado de los campos
            if (string.IsNullOrEmpty(textBoxNomUsuario.Text) || string.IsNullOrEmpty(textBoxContraseña.Text))
            {
                MessageBox.Show("Llene los espacios solicitados");
                return;
            }

            if (aux != null) //Se hace una excepción en caso de que no se encuentre el dato en la base de datos
            {
                if (aux.Contrasena == textBoxContraseña.Text && aux.Categoria == 2)
                {
                    MessageBox.Show("Registro Localizado en la Base de Datos");
                }
                else
                {
                    MessageBox.Show("Datos de acceso incorrectos o categoría no válida");
                    return;
                }
            }
            else
            {
                MessageBox.Show("No se encontró al usuario en la Base de Datos");
                return;
            }

            limpiar();
            obj.Disconnect();
            FormBaseUsuario fU = new FormBaseUsuario(aux.NombreCompleto); //sujeto a cambios por verificacion en base de datos
            //FormBaseUsuario fU = new FormBaseUsuario(aux.NombreCompleto, panDisp, postreDisp);
            this.Hide();
            SoundPlayer ReproducirMusica = new SoundPlayer();
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Music", "Musica2.wav");
            ReproducirMusica.SoundLocation = ruta;
            ReproducirMusica.Play();
            fU.ShowDialog();
            this.Show();

        }
        //Función para validar el inicio de sesión del administrador desde la Base de Datos
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdmonBDUsuario obj = new AdmonBDUsuario();
            Usuarios aux = obj.consultaUnRegistro(this.textBoxNomUsuario.Text);

            //Validación en el llenado de los campos
            if (string.IsNullOrEmpty(textBoxNomUsuario.Text) || string.IsNullOrEmpty(textBoxContraseña.Text))
            {
                MessageBox.Show("Llene los espacios solicitados");
                return;
            }

            if (aux != null) //Se hace una excepción en caso de que no se encuentre el dato en la base de datos
            {
                if (aux.Contrasena == textBoxContraseña.Text && aux.Categoria == 1)
                {
                    MessageBox.Show("Registro Localizado en la Base de Datos");
                    //MessageBox.Show("aux=" + aux.Id + " " + aux.NombreCompleto + " " + aux.Categoria + " " + aux.Cuenta + " " + aux.Contrasena + " " + aux.Monto);
                }
                else
                {
                    MessageBox.Show("Datos de acceso incorrectos o categoría no válida");
                    return;
                }
            }
            else
            {
                MessageBox.Show("No se encontró al usuario en la Base de Datos");
                return;
            }
            limpiar();
            //FormBaseAdmin fA = new FormBaseAdmin(aux.NombreCompleto, panDisp, postreDisp);
            FormBaseAdmin fA = new FormBaseAdmin(aux.NombreCompleto);
            this.Hide();
            fA.ShowDialog();
            this.Show();
        }

        public void limpiar()
        {
            this.textBoxNomUsuario.Text = "";
            this.textBoxContraseña.Text = "";
            this.textBoxNomUsuario.PlaceholderText = "Max. 25 caracteres";
            this.textBoxContraseña.PlaceholderText = "Max. 20 caracteres";
        }
        //Función para mostrar la fecha y hora en tiempo real al iniciar sesión
        private void timerHoraFechaInicioSesion_Tick(object sender, EventArgs e)
        {
            label1FechaHora.Text = DateTime.Now.ToString();
        }

        private void buttonInvitado_Click(object sender, EventArgs e)
        {
            AdmonBDUsuario obj = new AdmonBDUsuario();
            Usuarios aux = obj.consultaUnRegistro(this.textBoxNomUsuario.Text);

            //Validación en el llenado de los campos
            if (string.IsNullOrEmpty(textBoxNomUsuario.Text) || string.IsNullOrEmpty(textBoxContraseña.Text))
            {
                MessageBox.Show("Llene los espacios solicitados");
                return;
            }

            if (aux != null) //Se hace una excepción en caso de que no se encuentre el dato en la base de datos
            {
                if (aux.Contrasena == textBoxContraseña.Text && aux.Categoria == 3)
                {
                    MessageBox.Show("Registro Localizado en la Base de Datos");
                }
                else
                {
                    MessageBox.Show("Datos de acceso incorrectos o categoría no válida");
                    return;
                }
            }
            else
            {
                MessageBox.Show("No se encontró al usuario en la Base de Datos");
                return;
            }

            limpiar();
            obj.Disconnect();
            FormBaseUsuario fU = new FormBaseUsuario(aux.NombreCompleto); //sujeto a cambios por verificacion en base de datos
            //FormBaseUsuario fU = new FormBaseUsuario(aux.NombreCompleto, panDisp, postreDisp);
            this.Hide();
            SoundPlayer ReproducirMusica = new SoundPlayer();
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Music", "Musica2.wav");
            ReproducirMusica.SoundLocation = ruta;
            ReproducirMusica.Play();
            fU.ShowDialog();
            this.Show();
        }

        private void btnRedSocial1_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/cafe.placita?igsh=YzljYTk1ODg3Zg=="; 
            abrirEnlace(url);
        }

        private void btnRedSocial2_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/share/19VPjX8Haa/"; 
            abrirEnlace(url);
        }

        private void btnRedSocial3_Click(object sender, EventArgs e)
        {
            string url = "https://www.tiktok.com/@cafe_placita?is_from_webapp=1&sender_device=pc"; 
            abrirEnlace(url);
        }
        private void abrirEnlace(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true //Para abrir el navegador predeterminado
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el enlace: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalirUs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
