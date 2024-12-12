using System.Media;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace WinFormsProyectoBase
{
    public partial class FormBaseUsuario : Form
    {
        public int[] panDisp; //base de datos
        public int[] postreDisp; //base de datos
        public string nombre; //base de datos

        Random Musica = new Random();      // Random para seleccionar musica aleatoriamente
        private int cont = 0;              // Contador de Musica
        private bool[] reproducida = new bool[4]; // Control de canciones reproducidas
        private bool sonido = false; // variable de control de mute/demute

        public FormBaseUsuario(string nombreUs, int[] panDisp, int[] postreDisp)
        {
            InitializeComponent();
            cargarForm(new FormInformacion());
            this.labelNomUsuario.Text = nombreUs;
            this.labelNomUsuario.Location = new System.Drawing.Point(930 - ((nombreUs.Length) * 8), 35);
            this.postreDisp = postreDisp;
            this.panDisp = panDisp;
        }

        public void cargarForm(object Form)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(f);
            this.PanelPrincipal.Tag = f;
            f.Show();

        }

        private void btnCerrarSesionUs_Click(object sender, EventArgs e)
        {
            SoundPlayer ReproducirMusica = new SoundPlayer();
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Music", "Musica1.wav");
            ReproducirMusica.SoundLocation = ruta;
            ReproducirMusica.Stop();
            this.Close();

        }

        private void btnSalirUs_Click(object sender, EventArgs e)
        {
            SoundPlayer ReproducirMusica = new SoundPlayer();
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Music", "Musica1.wav");
            ReproducirMusica.SoundLocation = ruta;
            ReproducirMusica.Stop();
            this.Close();
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            cargarForm(new FormPan(panDisp));
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            cargarForm(new FormPostres(postreDisp));
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            cargarForm(new FormInformacion());
        }

        private void btnPruebaPagos_Click(object sender, EventArgs e)
        {
            cargarForm(new FormMetodosPago());
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {
            if (sonido)
            {
                int rand;
                if (cont >= 3)
                {
                    cont = 0;
                    for (int i = 1; i < 4; i++)
                    {
                        reproducida[i] = false;
                    }
                }
                do
                {
                    rand = Musica.Next(1, 4);
                } while (reproducida[rand]);
                switch (rand)
                {
                    case 1:
                        ReproducirMusica("Musica1.wav");
                        break;
                    case 2:
                        ReproducirMusica("Musica2.wav");
                        break;
                    case 3:
                        ReproducirMusica("Musica3.wav");
                        break;
                }
                reproducida[rand] = true;
                cont++;
                sonido = false;
                btnSonido.Image = Properties.Resources.Sonido;
            }
            else
            {
                SoundPlayer ReproducirMusica = new SoundPlayer();
                string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Music", "Musica1.wav");
                ReproducirMusica.SoundLocation = ruta;
                ReproducirMusica.Stop();
                btnSonido.Image = Properties.Resources.NoSonido;
                sonido = true;
            }
        }
        private void ReproducirMusica(string nombreArchivo)
        {
            SoundPlayer ReproducirMusica = new SoundPlayer();
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Music", nombreArchivo);
            ReproducirMusica.SoundLocation = ruta;
            ReproducirMusica.PlayLooping();
        }

        private void timer2FechaHoraUsuario_Tick(object sender, EventArgs e)
        {
            label2FechaHoraUsuario.Text = DateTime.Now.ToString();
        }
    }
}
