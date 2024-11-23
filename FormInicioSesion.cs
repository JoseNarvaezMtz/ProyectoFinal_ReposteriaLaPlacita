using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsProyectoBase
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormBaseUsuario fU = new FormBaseUsuario();
            this.Hide();
            fU.ShowDialog();
            this.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormBaseAdmin fA = new FormBaseAdmin();
            this.Hide();
            fA.ShowDialog();
            this.Show();
        }
    }
}
