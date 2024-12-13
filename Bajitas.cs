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
    public partial class Bajitas : Form
    {
        private int id;
        public Bajitas(int id)
        {
            InitializeComponent();
            this.id = id;
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
    }
}
