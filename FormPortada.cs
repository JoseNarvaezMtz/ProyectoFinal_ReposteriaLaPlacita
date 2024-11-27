using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoBase
{
    public partial class FormPortada : Form
    {
        public FormPortada()
        {
            InitializeComponent();
        }
        private void btnAplicacion_Click(object sender, EventArgs e)
        {
            FormInicioSesion fA = new FormInicioSesion();
            this.Hide();
            fA.ShowDialog();
            this.Close();
        }
    }
}
