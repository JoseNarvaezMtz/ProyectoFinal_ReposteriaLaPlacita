namespace WinFormsProyectoBase
{
    partial class FormBaseAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnSalir = new Button();
            panelSalir = new Panel();
            btnCerrarSesion = new Button();
            btnAltas = new Button();
            btnBajas = new Button();
            btnGraficas = new Button();
            panelBotones = new Panel();
            btnModificaciones = new Button();
            panelUsuario = new Panel();
            pictureBoxLogo = new PictureBox();
            label3FechaHoraAdmin = new Label();
            btnModoImagen = new Button();
            labelCorreo = new Label();
            labelNomAdm = new Label();
            pictureBoxAdmin = new PictureBox();
            panelBase = new Panel();
            timer3FechaHoraAdmin = new System.Windows.Forms.Timer(components);
            panelSalir.SuspendLayout();
            panelBotones.SuspendLayout();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdmin).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Tempus Sans ITC", 8F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(50, 150, 250);
            btnSalir.Location = new Point(925, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(26, 27);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "X";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelSalir
            // 
            panelSalir.BackColor = Color.FromArgb(24, 30, 54);
            panelSalir.Controls.Add(btnSalir);
            panelSalir.Dock = DockStyle.Top;
            panelSalir.Location = new Point(0, 0);
            panelSalir.Name = "panelSalir";
            panelSalir.Size = new Size(951, 27);
            panelSalir.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(24, 30, 54);
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.None;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = Color.FromArgb(0, 126, 249);
            btnCerrarSesion.Location = new Point(3, 211);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(216, 27);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnAltas
            // 
            btnAltas.BackColor = Color.FromArgb(24, 30, 54);
            btnAltas.BackgroundImageLayout = ImageLayout.None;
            btnAltas.FlatAppearance.BorderSize = 2;
            btnAltas.FlatStyle = FlatStyle.Flat;
            btnAltas.ForeColor = Color.FromArgb(70, 150, 250);
            btnAltas.Image = Properties.Resources.IconoAltasBajas;
            btnAltas.Location = new Point(14, 13);
            btnAltas.Name = "btnAltas";
            btnAltas.Size = new Size(151, 43);
            btnAltas.TabIndex = 1;
            btnAltas.Text = "Altas";
            btnAltas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAltas.UseVisualStyleBackColor = false;
            btnAltas.Click += btnAltasYBajas_Click;
            // 
            // btnBajas
            // 
            btnBajas.BackColor = Color.FromArgb(24, 30, 54);
            btnBajas.BackgroundImageLayout = ImageLayout.None;
            btnBajas.FlatAppearance.BorderSize = 2;
            btnBajas.FlatStyle = FlatStyle.Flat;
            btnBajas.ForeColor = Color.FromArgb(70, 150, 250);
            btnBajas.Location = new Point(533, 13);
            btnBajas.Name = "btnBajas";
            btnBajas.Size = new Size(151, 43);
            btnBajas.TabIndex = 2;
            btnBajas.Text = "Bajas";
            btnBajas.UseVisualStyleBackColor = false;
            btnBajas.Click += btnBajas_Click;
            // 
            // btnGraficas
            // 
            btnGraficas.BackColor = Color.FromArgb(24, 30, 54);
            btnGraficas.BackgroundImageLayout = ImageLayout.None;
            btnGraficas.FlatAppearance.BorderSize = 2;
            btnGraficas.FlatStyle = FlatStyle.Flat;
            btnGraficas.ForeColor = Color.FromArgb(70, 150, 250);
            btnGraficas.Image = Properties.Resources.IconoGrafica;
            btnGraficas.Location = new Point(356, 13);
            btnGraficas.Name = "btnGraficas";
            btnGraficas.Size = new Size(151, 43);
            btnGraficas.TabIndex = 3;
            btnGraficas.Text = "Graficas";
            btnGraficas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGraficas.UseVisualStyleBackColor = false;
            btnGraficas.Click += btnGraficas_Click_1;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(36, 41, 63);
            panelBotones.Controls.Add(btnModificaciones);
            panelBotones.Controls.Add(btnBajas);
            panelBotones.Controls.Add(btnGraficas);
            panelBotones.Controls.Add(btnAltas);
            panelBotones.Location = new Point(222, 27);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(729, 68);
            panelBotones.TabIndex = 6;
            // 
            // btnModificaciones
            // 
            btnModificaciones.BackColor = Color.FromArgb(24, 30, 54);
            btnModificaciones.BackgroundImageLayout = ImageLayout.None;
            btnModificaciones.FlatAppearance.BorderSize = 2;
            btnModificaciones.FlatStyle = FlatStyle.Flat;
            btnModificaciones.ForeColor = Color.FromArgb(70, 150, 250);
            btnModificaciones.Image = Properties.Resources.IconoModificaciones;
            btnModificaciones.Location = new Point(185, 13);
            btnModificaciones.Name = "btnModificaciones";
            btnModificaciones.Size = new Size(151, 43);
            btnModificaciones.TabIndex = 3;
            btnModificaciones.Text = "Modificaciones";
            btnModificaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificaciones.UseVisualStyleBackColor = false;
            btnModificaciones.Click += btnModificaciones_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.FromArgb(24, 30, 54);
            panelUsuario.Controls.Add(pictureBoxLogo);
            panelUsuario.Controls.Add(label3FechaHoraAdmin);
            panelUsuario.Controls.Add(btnModoImagen);
            panelUsuario.Controls.Add(labelCorreo);
            panelUsuario.Controls.Add(labelNomAdm);
            panelUsuario.Controls.Add(pictureBoxAdmin);
            panelUsuario.Controls.Add(btnCerrarSesion);
            panelUsuario.Dock = DockStyle.Left;
            panelUsuario.Location = new Point(0, 27);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(222, 550);
            panelUsuario.TabIndex = 7;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logoOscuro;
            pictureBoxLogo.Location = new Point(54, 267);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(118, 145);
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // label3FechaHoraAdmin
            // 
            label3FechaHoraAdmin.AutoSize = true;
            label3FechaHoraAdmin.ForeColor = Color.FromArgb(0, 126, 249);
            label3FechaHoraAdmin.Location = new Point(43, 446);
            label3FechaHoraAdmin.Name = "label3FechaHoraAdmin";
            label3FechaHoraAdmin.Size = new Size(38, 15);
            label3FechaHoraAdmin.TabIndex = 5;
            label3FechaHoraAdmin.Text = "Fecha";
            // 
            // btnModoImagen
            // 
            btnModoImagen.BackColor = Color.FromArgb(24, 30, 54);
            btnModoImagen.BackgroundImageLayout = ImageLayout.None;
            btnModoImagen.FlatAppearance.BorderSize = 2;
            btnModoImagen.FlatStyle = FlatStyle.Flat;
            btnModoImagen.ForeColor = Color.FromArgb(70, 150, 250);
            btnModoImagen.Location = new Point(33, 497);
            btnModoImagen.Name = "btnModoImagen";
            btnModoImagen.Size = new Size(151, 43);
            btnModoImagen.TabIndex = 4;
            btnModoImagen.Text = "Cambiar a modo claro";
            btnModoImagen.UseVisualStyleBackColor = false;
            btnModoImagen.Click += btnModoImagen_Click;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Segoe UI", 9F);
            labelCorreo.ForeColor = Color.FromArgb(100, 130, 250);
            labelCorreo.Location = new Point(33, 175);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(160, 15);
            labelCorreo.TabIndex = 3;
            labelCorreo.Text = "Correo Electronico (Revision)";
            // 
            // labelNomAdm
            // 
            labelNomAdm.AutoSize = true;
            labelNomAdm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNomAdm.ForeColor = Color.FromArgb(70, 150, 250);
            labelNomAdm.Location = new Point(78, 143);
            labelNomAdm.Name = "labelNomAdm";
            labelNomAdm.Size = new Size(69, 21);
            labelNomAdm.TabIndex = 2;
            labelNomAdm.Text = "Usuario";
            // 
            // pictureBoxAdmin
            // 
            pictureBoxAdmin.Image = Properties.Resources.IconoAdmin;
            pictureBoxAdmin.Location = new Point(43, 15);
            pictureBoxAdmin.Name = "pictureBoxAdmin";
            pictureBoxAdmin.Size = new Size(140, 125);
            pictureBoxAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAdmin.TabIndex = 1;
            pictureBoxAdmin.TabStop = false;
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.FromArgb(46, 51, 73);
            panelBase.Location = new Point(222, 88);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(729, 489);
            panelBase.TabIndex = 7;
            // 
            // timer3FechaHoraAdmin
            // 
            timer3FechaHoraAdmin.Enabled = true;
            timer3FechaHoraAdmin.Interval = 1000;
            timer3FechaHoraAdmin.Tag = "timer3FechaHoraAdmin";
            timer3FechaHoraAdmin.Tick += timer3FechaHoraAdmin_Tick;
            // 
            // FormBaseAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(panelBase);
            Controls.Add(panelBotones);
            Controls.Add(panelUsuario);
            Controls.Add(panelSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBaseAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelSalir.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Panel panelSalir;
        private Button btnCerrarSesion;
        private Button btnGraficas;
        private Button btnBajas;
        private Button btnAltas;
        private Panel panelBotones;
        private Button btnModificaciones;
        private Panel panelUsuario;
        private Panel panelBase;
        private Label labelCorreo;
        private Label labelNomAdm;
        private PictureBox pictureBoxAdmin;
        private Button btnModoImagen;
        private Label label3FechaHoraAdmin;
        private System.Windows.Forms.Timer timer3FechaHoraAdmin;
        private PictureBox pictureBoxLogo;
    }
}