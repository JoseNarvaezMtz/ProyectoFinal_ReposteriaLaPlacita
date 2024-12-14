namespace WinFormsProyectoBase
{
    partial class FormBaseUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            buttonCancelar = new Button();
            buttonPagar = new Button();
            label2FechaHoraUsuario = new Label();
            btnSonido = new Button();
            btnInformacion = new Button();
            pictureBox1 = new PictureBox();
            btnSalirUs = new Button();
            btnCerrarSesionUs = new Button();
            labelNomUsuario = new Label();
            panel2 = new Panel();
            label2 = new Label();
            btnPostres = new Button();
            btnPan = new Button();
            PanelPrincipal = new Panel();
            timer2FechaHoraUsuario = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(110, 80, 50);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonPagar);
            panel1.Controls.Add(label2FechaHoraUsuario);
            panel1.Controls.Add(btnSonido);
            panel1.Controls.Add(btnInformacion);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSalirUs);
            panel1.Controls.Add(btnCerrarSesionUs);
            panel1.Controls.Add(labelNomUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 95);
            panel1.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Tempus Sans ITC", 10F, FontStyle.Bold);
            buttonCancelar.ForeColor = Color.AntiqueWhite;
            buttonCancelar.Location = new Point(737, 57);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(79, 28);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonPagar
            // 
            buttonPagar.FlatStyle = FlatStyle.Flat;
            buttonPagar.Font = new Font("Tempus Sans ITC", 10F, FontStyle.Bold);
            buttonPagar.ForeColor = Color.AntiqueWhite;
            buttonPagar.Location = new Point(646, 57);
            buttonPagar.Margin = new Padding(3, 2, 3, 2);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(79, 27);
            buttonPagar.TabIndex = 5;
            buttonPagar.Text = "Pagar";
            buttonPagar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPagar.UseVisualStyleBackColor = true;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // label2FechaHoraUsuario
            // 
            label2FechaHoraUsuario.AutoSize = true;
            label2FechaHoraUsuario.Font = new Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2FechaHoraUsuario.ForeColor = Color.AntiqueWhite;
            label2FechaHoraUsuario.Location = new Point(716, 8);
            label2FechaHoraUsuario.Name = "label2FechaHoraUsuario";
            label2FechaHoraUsuario.Size = new Size(46, 18);
            label2FechaHoraUsuario.TabIndex = 4;
            label2FechaHoraUsuario.Text = "Fecha";
            // 
            // btnSonido
            // 
            btnSonido.FlatStyle = FlatStyle.Flat;
            btnSonido.Image = Properties.Resources.Sonido1;
            btnSonido.Location = new Point(646, 8);
            btnSonido.Name = "btnSonido";
            btnSonido.Size = new Size(44, 38);
            btnSonido.TabIndex = 0;
            btnSonido.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSonido.UseVisualStyleBackColor = true;
            btnSonido.Click += btnSonido_Click;
            // 
            // btnInformacion
            // 
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInformacion.ForeColor = Color.AntiqueWhite;
            btnInformacion.Image = Properties.Resources.Logo;
            btnInformacion.Location = new Point(10, 24);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(291, 52);
            btnInformacion.TabIndex = 3;
            btnInformacion.Text = "C a f é   l a   p l a c i t a";
            btnInformacion.TextAlign = ContentAlignment.MiddleRight;
            btnInformacion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInformacion.UseVisualStyleBackColor = true;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photoBase;
            pictureBox1.Location = new Point(329, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 95);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnSalirUs
            // 
            btnSalirUs.FlatStyle = FlatStyle.Flat;
            btnSalirUs.Font = new Font("Tempus Sans ITC", 8F, FontStyle.Bold);
            btnSalirUs.ForeColor = Color.AntiqueWhite;
            btnSalirUs.Location = new Point(925, 0);
            btnSalirUs.Name = "btnSalirUs";
            btnSalirUs.Size = new Size(25, 25);
            btnSalirUs.TabIndex = 2;
            btnSalirUs.Text = "X";
            btnSalirUs.TextAlign = ContentAlignment.MiddleRight;
            btnSalirUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalirUs.UseVisualStyleBackColor = true;
            btnSalirUs.Click += btnSalirUs_Click;
            // 
            // btnCerrarSesionUs
            // 
            btnCerrarSesionUs.FlatStyle = FlatStyle.Flat;
            btnCerrarSesionUs.Font = new Font("Tempus Sans ITC", 10F, FontStyle.Bold);
            btnCerrarSesionUs.ForeColor = Color.AntiqueWhite;
            btnCerrarSesionUs.Location = new Point(829, 57);
            btnCerrarSesionUs.Name = "btnCerrarSesionUs";
            btnCerrarSesionUs.Size = new Size(112, 28);
            btnCerrarSesionUs.TabIndex = 1;
            btnCerrarSesionUs.Text = "Cerrar sesion";
            btnCerrarSesionUs.TextAlign = ContentAlignment.MiddleRight;
            btnCerrarSesionUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesionUs.UseVisualStyleBackColor = true;
            btnCerrarSesionUs.Click += btnCerrarSesionUs_Click;
            // 
            // labelNomUsuario
            // 
            labelNomUsuario.AutoSize = true;
            labelNomUsuario.Font = new Font("Tempus Sans ITC", 11F, FontStyle.Bold);
            labelNomUsuario.ForeColor = Color.AntiqueWhite;
            labelNomUsuario.Location = new Point(770, 36);
            labelNomUsuario.Name = "labelNomUsuario";
            labelNomUsuario.Size = new Size(159, 19);
            labelNomUsuario.TabIndex = 0;
            labelNomUsuario.Text = "Nombre Del Usuario";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(110, 80, 50);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnPostres);
            panel2.Controls.Add(btnPan);
            panel2.Location = new Point(0, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 40);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Tempus Sans ITC", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(110, 80, 50);
            label2.Location = new Point(436, 6);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 3;
            label2.Text = "Disfruta";
            // 
            // btnPostres
            // 
            btnPostres.Dock = DockStyle.Right;
            btnPostres.FlatAppearance.BorderSize = 2;
            btnPostres.FlatStyle = FlatStyle.Flat;
            btnPostres.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostres.ForeColor = Color.AntiqueWhite;
            btnPostres.Image = Properties.Resources.IconoPostre;
            btnPostres.Location = new Point(526, 0);
            btnPostres.Name = "btnPostres";
            btnPostres.Size = new Size(425, 40);
            btnPostres.TabIndex = 1;
            btnPostres.Text = "P o s t r e s";
            btnPostres.TextAlign = ContentAlignment.MiddleRight;
            btnPostres.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPostres.UseVisualStyleBackColor = true;
            btnPostres.Click += btnPostres_Click;
            // 
            // btnPan
            // 
            btnPan.Dock = DockStyle.Left;
            btnPan.FlatAppearance.BorderSize = 2;
            btnPan.FlatStyle = FlatStyle.Flat;
            btnPan.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPan.ForeColor = Color.AntiqueWhite;
            btnPan.Image = Properties.Resources.IconoPan;
            btnPan.Location = new Point(0, 0);
            btnPan.Name = "btnPan";
            btnPan.Size = new Size(425, 40);
            btnPan.TabIndex = 0;
            btnPan.Text = "P a n";
            btnPan.TextAlign = ContentAlignment.MiddleRight;
            btnPan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPan.UseVisualStyleBackColor = true;
            btnPan.Click += btnPan_Click;
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = Color.AntiqueWhite;
            PanelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            PanelPrincipal.Location = new Point(0, 135);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(951, 444);
            PanelPrincipal.TabIndex = 3;
            // 
            // timer2FechaHoraUsuario
            // 
            timer2FechaHoraUsuario.Enabled = true;
            timer2FechaHoraUsuario.Interval = 1000;
            timer2FechaHoraUsuario.Tag = "timer2FechaHoraUsuario";
            timer2FechaHoraUsuario.Tick += timer2FechaHoraUsuario_Tick;
            // 
            // FormBaseUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(951, 577);
            Controls.Add(PanelPrincipal);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBaseUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnPan;
        private Button btnPostres;
        private Label labelNomUsuario;
        private Button btnCerrarSesionUs;
        private PictureBox pictureBox1;
        private Panel PanelPrincipal;
        private Label label2;
        private Button btnSalirUs;
        private Button btnInformacion;
        private Button btnSonido;
        private Label label2FechaHoraUsuario;
        private System.Windows.Forms.Timer timer2FechaHoraUsuario;
        private Button buttonCancelar;
        private Button buttonPagar;
    }
}
