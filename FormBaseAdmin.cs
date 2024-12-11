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
        public int[] panDisp;           //base de datos
        public int[] postreDisp;        //base de datos
        private bool Modo = false;      //Variable para cambiar el Modo claro/oscuro del tema
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
            //cargarForm(new FormAltas());
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
        private void btnModificaciones_Click(object sender, EventArgs e)
        {
            cargarForm(new FormModificaciones(this.Modo));
        }
        private void btnAltasYBajas_Click(object sender, EventArgs e)
        {
            cargarForm(new FormAltas(this.Modo));
        }

        private void btnGraficas_Click_1(object sender, EventArgs e)
        {
            cargarForm(new FormGraficas(this.Modo));
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            cargarForm(new FormBajas(this.Modo));
        }

        private void btnModoImagen_Click(object sender, EventArgs e)
        {
            //Modo == false; ES EL MODO OSCURO
            //Modo == true; ES EL MODO CLARO 
            //Cambia el estado de Modo cada que se entra a la función
            if (this.Modo == true)
            {
                this.Modo = false;
            }
            else this.Modo = true;

            if (this.Modo == true)
            {
                //Paneles
                this.panelBase.BackColor = Color.FromArgb(244, 241, 235);
                this.panelSalir.BackColor = Color.FromArgb(212, 200, 175);
                this.panelUsuario.BackColor = Color.FromArgb(212, 200, 175);
                this.panelBotones.BackColor = Color.FromArgb(223, 214, 195);
                //Botones
                this.btnCerrarSesion.BackColor = Color.FromArgb(212, 200, 175);
                this.btnCerrarSesion.ForeColor = Color.FromArgb(78, 78, 78);
                this.btnAltas.BackColor = Color.FromArgb(212, 200, 175);
                this.btnAltas.ForeColor = Color.FromArgb(78, 78, 78);
                this.btnModificaciones.BackColor = Color.FromArgb(212, 200, 175);
                this.btnModificaciones.ForeColor = Color.FromArgb(78, 78, 78);
                this.btnGraficas.BackColor = Color.FromArgb(212, 200, 175);
                this.btnGraficas.ForeColor = Color.FromArgb(78, 78, 78);
                this.btnBajas.BackColor = Color.FromArgb(212, 200, 175);
                this.btnBajas.ForeColor = Color.FromArgb(78, 78, 78);
                this.btnSalir.BackColor = Color.FromArgb(212, 200, 175);
                this.btnSalir.ForeColor = Color.FromArgb(78, 78, 78);
                this.btnModoImagen.BackColor = Color.FromArgb(212, 200, 175);
                this.btnModoImagen.ForeColor = Color.FromArgb(78, 78, 78);
                this.btnModoImagen.Text = "Cambiar a modo oscuro";
                //Labels
                this.labelCorreo.ForeColor = Color.FromArgb(78, 78, 78);
                this.labelNomAdm.ForeColor = Color.FromArgb(78, 78, 78);
            }
            else
            {
                //Paneles
                this.panelBase.BackColor = Color.FromArgb(46, 51, 73);
                this.panelSalir.BackColor = Color.FromArgb(24, 30, 54);
                this.panelUsuario.BackColor = Color.FromArgb(24, 30, 54);
                this.panelBotones.BackColor = Color.FromArgb(36, 41, 63);
                //Botones
                this.btnCerrarSesion.BackColor = Color.FromArgb(24, 30, 54);
                this.btnCerrarSesion.ForeColor = Color.FromArgb(70, 150, 250);
                this.btnAltas.BackColor = Color.FromArgb(24, 30, 54);
                this.btnAltas.ForeColor = Color.FromArgb(70, 150, 250);
                this.btnModificaciones.BackColor = Color.FromArgb(24, 30, 54);
                this.btnModificaciones.ForeColor = Color.FromArgb(70, 150, 250);
                this.btnGraficas.BackColor = Color.FromArgb(24, 30, 54);
                this.btnGraficas.ForeColor = Color.FromArgb(70, 150, 250);
                this.btnBajas.BackColor = Color.FromArgb(24, 30, 54);
                this.btnBajas.ForeColor = Color.FromArgb(70, 150, 250);
                this.btnSalir.BackColor = Color.FromArgb(24, 30, 54);
                this.btnSalir.ForeColor = Color.FromArgb(70, 150, 250);
                this.btnModoImagen.BackColor = Color.FromArgb(24, 30, 54);
                this.btnModoImagen.ForeColor = Color.FromArgb(70, 150, 250);
                this.btnModoImagen.Text = "Cambiar a modo claro";
                //Labels
                this.labelCorreo.ForeColor = Color.FromArgb(70, 150, 250);
                this.labelNomAdm.ForeColor = Color.FromArgb(70, 150, 250);
            }
            if (this.panelBase.Controls.Count > 0)
            {
                Form formularioActual = this.panelBase.Controls[0] as Form;

                if (formularioActual != null)
                {
                    string nombreFormulario = formularioActual.GetType().Name;
                    switch (nombreFormulario)
                    {
                        case "FormAltas":
                            cargarForm(new FormAltas(this.Modo));
                            break;

                        case "FormModificaciones":
                            cargarForm(new FormModificaciones(this.Modo));
                            break;

                        case "FormGraficas":
                            cargarForm(new FormGraficas(this.Modo));
                            break;

                        case "FormBajas":
                            cargarForm(new FormBajas(this.Modo));
                            break;
                    }
                }
            }
        }

        
    }
}