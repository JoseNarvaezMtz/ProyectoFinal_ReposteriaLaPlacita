namespace WinFormsProyectoBase
{
    partial class FormInicioSesion
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
            btnUsuario = new Button();
            btnAdmin = new Button();
            panelInicioSesion = new Panel();
            btnSalirUs = new Button();
            buttonInvitado = new Button();
            label1FechaHora = new Label();
            labelContraseña = new Label();
            labelUsuario = new Label();
            pictureBoxLogoGrande = new PictureBox();
            textBoxContraseña = new TextBox();
            labelNombreEmpresa = new Label();
            textBoxNomUsuario = new TextBox();
            panelFotoYRedes = new Panel();
            panel3 = new Panel();
            btnRedSocial3 = new Button();
            btnRedSocial2 = new Button();
            btnRedSocial1 = new Button();
            pictureBox1 = new PictureBox();
            timerHoraFechaInicioSesion = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            panelInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoGrande).BeginInit();
            panelFotoYRedes.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(229, 372);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(136, 41);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(50, 372);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(136, 41);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Administrador";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // panelInicioSesion
            // 
            panelInicioSesion.BackColor = Color.FromArgb(110, 80, 50);
            panelInicioSesion.Controls.Add(label2);
            panelInicioSesion.Controls.Add(label1);
            panelInicioSesion.Controls.Add(btnSalirUs);
            panelInicioSesion.Controls.Add(buttonInvitado);
            panelInicioSesion.Controls.Add(label1FechaHora);
            panelInicioSesion.Controls.Add(labelContraseña);
            panelInicioSesion.Controls.Add(labelUsuario);
            panelInicioSesion.Controls.Add(pictureBoxLogoGrande);
            panelInicioSesion.Controls.Add(textBoxContraseña);
            panelInicioSesion.Controls.Add(labelNombreEmpresa);
            panelInicioSesion.Controls.Add(textBoxNomUsuario);
            panelInicioSesion.Controls.Add(btnAdmin);
            panelInicioSesion.Controls.Add(btnUsuario);
            panelInicioSesion.Location = new Point(524, 0);
            panelInicioSesion.Name = "panelInicioSesion";
            panelInicioSesion.Size = new Size(404, 531);
            panelInicioSesion.TabIndex = 2;
            // 
            // btnSalirUs
            // 
            btnSalirUs.FlatStyle = FlatStyle.Flat;
            btnSalirUs.Font = new Font("Tempus Sans ITC", 8F, FontStyle.Bold);
            btnSalirUs.ForeColor = Color.AntiqueWhite;
            btnSalirUs.Location = new Point(377, 0);
            btnSalirUs.Name = "btnSalirUs";
            btnSalirUs.Size = new Size(25, 25);
            btnSalirUs.TabIndex = 12;
            btnSalirUs.Text = "X";
            btnSalirUs.TextAlign = ContentAlignment.MiddleRight;
            btnSalirUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalirUs.UseVisualStyleBackColor = true;
            btnSalirUs.Click += btnSalirUs_Click;
            // 
            // buttonInvitado
            // 
            buttonInvitado.Location = new Point(140, 428);
            buttonInvitado.Name = "buttonInvitado";
            buttonInvitado.Size = new Size(136, 41);
            buttonInvitado.TabIndex = 11;
            buttonInvitado.Text = "Invitado";
            buttonInvitado.UseVisualStyleBackColor = true;
            buttonInvitado.Click += buttonInvitado_Click;
            // 
            // label1FechaHora
            // 
            label1FechaHora.AutoSize = true;
            label1FechaHora.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1FechaHora.ForeColor = Color.AntiqueWhite;
            label1FechaHora.Location = new Point(124, 493);
            label1FechaHora.Name = "label1FechaHora";
            label1FechaHora.Size = new Size(0, 16);
            label1FechaHora.TabIndex = 10;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            labelContraseña.ForeColor = Color.AntiqueWhite;
            labelContraseña.Location = new Point(152, 271);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(110, 22);
            labelContraseña.TabIndex = 9;
            labelContraseña.Text = "Contraseña:";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            labelUsuario.ForeColor = Color.AntiqueWhite;
            labelUsuario.Location = new Point(167, 194);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(79, 22);
            labelUsuario.TabIndex = 8;
            labelUsuario.Text = "Usuario:";
            // 
            // pictureBoxLogoGrande
            // 
            pictureBoxLogoGrande.Image = Properties.Resources.Logo_Grande;
            pictureBoxLogoGrande.Location = new Point(13, 16);
            pictureBoxLogoGrande.Name = "pictureBoxLogoGrande";
            pictureBoxLogoGrande.Size = new Size(83, 102);
            pictureBoxLogoGrande.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogoGrande.TabIndex = 7;
            pictureBoxLogoGrande.TabStop = false;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(92, 308);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PasswordChar = '*';
            textBoxContraseña.PlaceholderText = "Max. 20 caracteres";
            textBoxContraseña.Size = new Size(235, 23);
            textBoxContraseña.TabIndex = 6;
            // 
            // labelNombreEmpresa
            // 
            labelNombreEmpresa.AutoSize = true;
            labelNombreEmpresa.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            labelNombreEmpresa.ForeColor = Color.AntiqueWhite;
            labelNombreEmpresa.Location = new Point(103, 37);
            labelNombreEmpresa.Name = "labelNombreEmpresa";
            labelNombreEmpresa.Size = new Size(283, 31);
            labelNombreEmpresa.TabIndex = 5;
            labelNombreEmpresa.Text = "C a f é   l a   p l a c i t a";
            // 
            // textBoxNomUsuario
            // 
            textBoxNomUsuario.Location = new Point(92, 233);
            textBoxNomUsuario.MaxLength = 25;
            textBoxNomUsuario.Name = "textBoxNomUsuario";
            textBoxNomUsuario.PlaceholderText = "Max. 25 caracteres";
            textBoxNomUsuario.Size = new Size(235, 23);
            textBoxNomUsuario.TabIndex = 2;
            // 
            // panelFotoYRedes
            // 
            panelFotoYRedes.BackColor = Color.AntiqueWhite;
            panelFotoYRedes.Controls.Add(panel3);
            panelFotoYRedes.Controls.Add(pictureBox1);
            panelFotoYRedes.Location = new Point(0, 1);
            panelFotoYRedes.Name = "panelFotoYRedes";
            panelFotoYRedes.Size = new Size(525, 533);
            panelFotoYRedes.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(110, 80, 50);
            panel3.Controls.Add(btnRedSocial3);
            panel3.Controls.Add(btnRedSocial2);
            panel3.Controls.Add(btnRedSocial1);
            panel3.Location = new Point(32, 404);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 85);
            panel3.TabIndex = 1;
            // 
            // btnRedSocial3
            // 
            btnRedSocial3.Dock = DockStyle.Left;
            btnRedSocial3.FlatAppearance.BorderSize = 5;
            btnRedSocial3.FlatStyle = FlatStyle.Flat;
            btnRedSocial3.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnRedSocial3.ForeColor = Color.AntiqueWhite;
            btnRedSocial3.Location = new Point(300, 0);
            btnRedSocial3.Name = "btnRedSocial3";
            btnRedSocial3.Size = new Size(150, 85);
            btnRedSocial3.TabIndex = 12;
            btnRedSocial3.Text = "TikTok";
            btnRedSocial3.UseVisualStyleBackColor = true;
            btnRedSocial3.Click += btnRedSocial3_Click;
            // 
            // btnRedSocial2
            // 
            btnRedSocial2.Dock = DockStyle.Left;
            btnRedSocial2.FlatAppearance.BorderSize = 5;
            btnRedSocial2.FlatStyle = FlatStyle.Flat;
            btnRedSocial2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnRedSocial2.ForeColor = Color.AntiqueWhite;
            btnRedSocial2.Location = new Point(150, 0);
            btnRedSocial2.Name = "btnRedSocial2";
            btnRedSocial2.Size = new Size(150, 85);
            btnRedSocial2.TabIndex = 11;
            btnRedSocial2.Text = "Facebook";
            btnRedSocial2.UseVisualStyleBackColor = true;
            btnRedSocial2.Click += btnRedSocial2_Click;
            // 
            // btnRedSocial1
            // 
            btnRedSocial1.Dock = DockStyle.Left;
            btnRedSocial1.FlatAppearance.BorderSize = 5;
            btnRedSocial1.FlatStyle = FlatStyle.Flat;
            btnRedSocial1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnRedSocial1.ForeColor = Color.AntiqueWhite;
            btnRedSocial1.Location = new Point(0, 0);
            btnRedSocial1.Name = "btnRedSocial1";
            btnRedSocial1.Size = new Size(150, 85);
            btnRedSocial1.TabIndex = 10;
            btnRedSocial1.Text = "Instagram";
            btnRedSocial1.UseVisualStyleBackColor = true;
            btnRedSocial1.Click += btnRedSocial1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(110, 80, 50);
            pictureBox1.Image = Properties.Resources.photoBase;
            pictureBox1.Location = new Point(36, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 357);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timerHoraFechaInicioSesion
            // 
            timerHoraFechaInicioSesion.Enabled = true;
            timerHoraFechaInicioSesion.Interval = 1000;
            timerHoraFechaInicioSesion.Tag = "timerHoraFechaInicioSesion";
            timerHoraFechaInicioSesion.Tick += timerHoraFechaInicioSesion_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(140, 81);
            label1.Name = "label1";
            label1.Size = new Size(216, 44);
            label1.TabIndex = 14;
            label1.Text = "\"Delicia tras delicia para\r\n     endulzar tu pancita\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label2.ForeColor = Color.AntiqueWhite;
            label2.Location = new Point(152, 156);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 15;
            label2.Text = "¡Bienvenido!";
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 530);
            Controls.Add(panelFotoYRedes);
            Controls.Add(panelInicioSesion);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FormInicioSesion";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioSesion";
            panelInicioSesion.ResumeLayout(false);
            panelInicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoGrande).EndInit();
            panelFotoYRedes.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnAdmin;
        private Panel panelInicioSesion;
        private TextBox textBoxNomUsuario;
        private TextBox textBoxContraseña;
        private Label labelNombreEmpresa;
        private PictureBox pictureBoxLogoGrande;
        private Panel panelFotoYRedes;
        private PictureBox pictureBox1;
        private Label labelContraseña;
        private Label labelUsuario;
        private Panel panel3;
        private Button btnRedSocial3;
        private Button btnRedSocial2;
        private Button btnRedSocial1;
        private Label label1FechaHora;
        private System.Windows.Forms.Timer timerHoraFechaInicioSesion;
        private Button buttonInvitado;
        private Button btnSalirUs;
        private Label label1;
        private Label label2;
    }
}