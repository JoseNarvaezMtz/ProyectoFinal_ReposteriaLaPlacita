namespace WinFormsProyectoBase
{
    public partial class FormBaseUsuario : Form
    {
        private List<Panel> postresPanels; // Lista de paneles de postres
        private int maxPanelesOcultos = 2; // Máximo de paneles que pueden ocultarse
        private int panelesOcultos = 0;    // Contador de paneles ocultos actualmente

        public FormBaseUsuario()
        {
            InitializeComponent();
            cargarForm(new FormInformacion());
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            cargarForm(new FormPan());
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            cargarForm(new FormPostres());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cargarForm(new FormInformacion());
        }
    }
}
