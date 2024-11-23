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
    public partial class FormBaseAdmin : Form
    {
        public FormBaseAdmin()
        {
            InitializeComponent();
        }

        public void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
