using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WinFormsProyectoBase
{
    public partial class FormTicket : Form
    {
        public FormTicket()
        {
            InitializeComponent();
            panelTicket.Visible = false;
        }
        private void btnSalirMetPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonDescargar_Click(object sender, EventArgs e)
        {
            progressBarDescargarTicket.Minimum = 0;
            progressBarDescargarTicket.Maximum = 100;
            progressBarDescargarTicket.Value = 0;
            Bitmap bitmap = new Bitmap(this.Width, 732);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, 732));
            progressBarDescargarTicket.Value = 50;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Imagen PNG|*.png";
            saveFileDialog.Title = "Descargando Ticket";
            saveFileDialog.FileName = "ticket.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                progressBarDescargarTicket.Value = 100;
                MessageBox.Show("El ticket se descargó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El ticket no se pudo descargar correctamente.");
                progressBarDescargarTicket.Value = 0;
            }
        }
        private void buttonVerTicket_Click(object sender, EventArgs e)
        {
            panelTicket.Visible = true;
        }
    }
}
