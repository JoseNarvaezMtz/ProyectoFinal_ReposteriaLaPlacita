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
            btnModoImagen = new Button();
            labelCorreo = new Label();
            labelNomAdm = new Label();
            pictureBoxAdmin = new PictureBox();
            panelBase = new Panel();
            label3FechaHoraAdmin = new Label();
            timer3FechaHoraAdmin = new System.Windows.Forms.Timer(components);
            panelSalir.SuspendLayout();
            panelBotones.SuspendLayout();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdmin).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Tempus Sans ITC", 8F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(50, 150, 250);
            btnSalir.Location = new Point(1057, 0);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(30, 36);
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
            panelSalir.Margin = new Padding(3, 4, 3, 4);
            panelSalir.Name = "panelSalir";
            panelSalir.Size = new Size(1087, 36);
            panelSalir.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(24, 30, 54);
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.None;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = Color.FromArgb(0, 126, 249);
            btnCerrarSesion.Location = new Point(3, 281);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(247, 36);
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
            btnAltas.Location = new Point(16, 17);
            btnAltas.Margin = new Padding(3, 4, 3, 4);
            btnAltas.Name = "btnAltas";
            btnAltas.Size = new Size(173, 57);
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
            btnBajas.Location = new Point(609, 17);
            btnBajas.Margin = new Padding(3, 4, 3, 4);
            btnBajas.Name = "btnBajas";
            btnBajas.Size = new Size(173, 57);
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
            btnGraficas.Location = new Point(407, 17);
            btnGraficas.Margin = new Padding(3, 4, 3, 4);
            btnGraficas.Name = "btnGraficas";
            btnGraficas.Size = new Size(173, 57);
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
            panelBotones.Location = new Point(254, 36);
            panelBotones.Margin = new Padding(3, 4, 3, 4);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(833, 91);
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
            btnModificaciones.Location = new Point(211, 17);
            btnModificaciones.Margin = new Padding(3, 4, 3, 4);
            btnModificaciones.Name = "btnModificaciones";
            btnModificaciones.Size = new Size(173, 57);
            btnModificaciones.TabIndex = 3;
            btnModificaciones.Text = "Modificaciones";
            btnModificaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificaciones.UseVisualStyleBackColor = false;
            btnModificaciones.Click += btnModificaciones_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.FromArgb(24, 30, 54);
            panelUsuario.Controls.Add(label3FechaHoraAdmin);
            panelUsuario.Controls.Add(btnModoImagen);
            panelUsuario.Controls.Add(labelCorreo);
            panelUsuario.Controls.Add(labelNomAdm);
            panelUsuario.Controls.Add(pictureBoxAdmin);
            panelUsuario.Controls.Add(btnCerrarSesion);
            panelUsuario.Dock = DockStyle.Left;
            panelUsuario.Location = new Point(0, 36);
            panelUsuario.Margin = new Padding(3, 4, 3, 4);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(254, 733);
            panelUsuario.TabIndex = 7;
            // 
            // btnModoImagen
            // 
            btnModoImagen.BackColor = Color.FromArgb(24, 30, 54);
            btnModoImagen.BackgroundImageLayout = ImageLayout.None;
            btnModoImagen.FlatAppearance.BorderSize = 2;
            btnModoImagen.FlatStyle = FlatStyle.Flat;
            btnModoImagen.ForeColor = Color.FromArgb(70, 150, 250);
            btnModoImagen.Location = new Point(38, 663);
            btnModoImagen.Margin = new Padding(3, 4, 3, 4);
            btnModoImagen.Name = "btnModoImagen";
            btnModoImagen.Size = new Size(173, 57);
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
            labelCorreo.Location = new Point(38, 233);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(201, 20);
            labelCorreo.TabIndex = 3;
            labelCorreo.Text = "Correo Electronico (Revision)";
            // 
            // labelNomAdm
            // 
            labelNomAdm.AutoSize = true;
            labelNomAdm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNomAdm.ForeColor = Color.FromArgb(70, 150, 250);
            labelNomAdm.Location = new Point(89, 191);
            labelNomAdm.Name = "labelNomAdm";
            labelNomAdm.Size = new Size(84, 28);
            labelNomAdm.TabIndex = 2;
            labelNomAdm.Text = "Usuario";
            // 
            // pictureBoxAdmin
            // 
            pictureBoxAdmin.Image = Properties.Resources.IconoAdmin;
            pictureBoxAdmin.Location = new Point(49, 20);
            pictureBoxAdmin.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAdmin.Name = "pictureBoxAdmin";
            pictureBoxAdmin.Size = new Size(160, 167);
            pictureBoxAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAdmin.TabIndex = 1;
            pictureBoxAdmin.TabStop = false;
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.FromArgb(46, 51, 73);
            panelBase.Location = new Point(254, 117);
            panelBase.Margin = new Padding(3, 4, 3, 4);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(833, 652);
            panelBase.TabIndex = 7;
            // 
            // label3FechaHoraAdmin
            // 
            label3FechaHoraAdmin.AutoSize = true;
            label3FechaHoraAdmin.ForeColor = Color.FromArgb(0, 126, 249);
            label3FechaHoraAdmin.Location = new Point(49, 595);
            label3FechaHoraAdmin.Name = "label3FechaHoraAdmin";
            label3FechaHoraAdmin.Size = new Size(47, 20);
            label3FechaHoraAdmin.TabIndex = 5;
            label3FechaHoraAdmin.Text = "Fecha";
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1087, 769);
            Controls.Add(panelBase);
            Controls.Add(panelBotones);
            Controls.Add(panelUsuario);
            Controls.Add(panelSalir);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormBaseAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelSalir.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
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
    }
}