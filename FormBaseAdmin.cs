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
        public int[] panDisp; //base de datos
        public int[] postreDisp; //base de datos
        public FormBaseAdmin()
        {
            InitializeComponent();
        }
        public FormBaseAdmin(string nombreUs, int[] panDisp, int[] postreDisp)
        {
            InitializeComponent();
            this.labelNomAdm.Text = nombreUs;
            this.labelNomAdm.Location = new System.Drawing.Point(108 - (((nombreUs.Length) * 8) / 2), 145);
            this.panDisp = panDisp;
            this.postreDisp = postreDisp;
            cargarForm(new FormAltas());
        }
        public void cargarForm(object Form)
        {
            if (this.panelBase.Controls.Count > 0)
                this.panelBase.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelBase.Controls.Add(f);
            this.panelBase.Tag = f;
            f.Show();

        }
        public void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltasYBajas_Click(object sender, EventArgs e)
        {
            cargarForm(new FormAltas());//mandar datos si son necesarios a traves del constructor color etc
        }

        private void btnModificaciones_Click(object sender, EventArgs e)
        {
            cargarForm(new FormModificaciones());//mandar datos si son necesarios a traves del constructor color etc
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            cargarForm(new FormGraficas());//mandar datos si son necesarios a traves del constructor color etc
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            cargarForm(new FormBajas());//mandar datos si son necesarios a traves del constructor color etc
        }
    }
}
