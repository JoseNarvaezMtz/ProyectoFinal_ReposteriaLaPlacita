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
            btnSalir = new Button();
            panelSalir = new Panel();
            btnCerrarSesion = new Button();
            btnProductos = new Button();
            btnExtra = new Button();
            btnGraficas = new Button();
            panelBotones = new Panel();
            btnModificaciones = new Button();
            panelUsuario = new Panel();
            labelCorreo = new Label();
            labelNomAdm = new Label();
            pictureBoxAdmin = new PictureBox();
            panelBase = new Panel();
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
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(24, 30, 54);
            btnProductos.BackgroundImageLayout = ImageLayout.None;
            btnProductos.FlatAppearance.BorderSize = 2;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = Color.FromArgb(70, 150, 250);
            btnProductos.Image = Properties.Resources.IconoAltasBajas;
            btnProductos.Location = new Point(14, 13);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(151, 43);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Altas / Bajas";
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnExtra
            // 
            btnExtra.BackColor = Color.FromArgb(24, 30, 54);
            btnExtra.BackgroundImageLayout = ImageLayout.None;
            btnExtra.FlatAppearance.BorderSize = 2;
            btnExtra.FlatStyle = FlatStyle.Flat;
            btnExtra.ForeColor = Color.FromArgb(70, 150, 250);
            btnExtra.Location = new Point(533, 13);
            btnExtra.Name = "btnExtra";
            btnExtra.Size = new Size(151, 43);
            btnExtra.TabIndex = 2;
            btnExtra.Text = "Etcetera...";
            btnExtra.UseVisualStyleBackColor = false;
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
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(36, 41, 63);
            panelBotones.Controls.Add(btnModificaciones);
            panelBotones.Controls.Add(btnExtra);
            panelBotones.Controls.Add(btnGraficas);
            panelBotones.Controls.Add(btnProductos);
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
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.FromArgb(24, 30, 54);
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
            labelNomAdm.Location = new Point(49, 145);
            labelNomAdm.Name = "labelNomAdm";
            labelNomAdm.Size = new Size(124, 21);
            labelNomAdm.TabIndex = 2;
            labelNomAdm.Text = "Usuario Admin";
            // 
            // pictureBoxAdmin
            // 
            pictureBoxAdmin.Image = Properties.Resources.IconoAdmin;
            pictureBoxAdmin.Location = new Point(48, 15);
            pictureBoxAdmin.Name = "pictureBoxAdmin";
            pictureBoxAdmin.Size = new Size(125, 125);
            pictureBoxAdmin.TabIndex = 1;
            pictureBoxAdmin.TabStop = false;
            // 
            // panelBase
            // 
            panelBase.Location = new Point(222, 101);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(729, 476);
            panelBase.TabIndex = 7;
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Panel panelSalir;
        private Button btnCerrarSesion;
        private Button btnGraficas;
        private Button btnExtra;
        private Button btnProductos;
        private Panel panelBotones;
        private Button btnModificaciones;
        private Panel panelUsuario;
        private Panel panelBase;
        private Label labelCorreo;
        private Label labelNomAdm;
        private PictureBox pictureBoxAdmin;
    }
}