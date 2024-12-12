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
            label1FechaHora = new Label();
            panelInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoGrande).BeginInit();
            panelFotoYRedes.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(269, 540);
            btnUsuario.Margin = new Padding(3, 4, 3, 4);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(155, 55);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(37, 540);
            btnAdmin.Margin = new Padding(3, 4, 3, 4);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(155, 55);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Administrador";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // panelInicioSesion
            // 
            panelInicioSesion.BackColor = Color.FromArgb(110, 80, 50);
            panelInicioSesion.Controls.Add(label1FechaHora);
            panelInicioSesion.Controls.Add(labelContraseña);
            panelInicioSesion.Controls.Add(labelUsuario);
            panelInicioSesion.Controls.Add(pictureBoxLogoGrande);
            panelInicioSesion.Controls.Add(textBoxContraseña);
            panelInicioSesion.Controls.Add(labelNombreEmpresa);
            panelInicioSesion.Controls.Add(textBoxNomUsuario);
            panelInicioSesion.Controls.Add(btnAdmin);
            panelInicioSesion.Controls.Add(btnUsuario);
            panelInicioSesion.Location = new Point(599, 0);
            panelInicioSesion.Margin = new Padding(3, 4, 3, 4);
            panelInicioSesion.Name = "panelInicioSesion";
            panelInicioSesion.Size = new Size(462, 708);
            panelInicioSesion.TabIndex = 2;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            labelContraseña.ForeColor = Color.AntiqueWhite;
            labelContraseña.Location = new Point(174, 377);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(138, 26);
            labelContraseña.TabIndex = 9;
            labelContraseña.Text = "Contraseña:";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            labelUsuario.ForeColor = Color.AntiqueWhite;
            labelUsuario.Location = new Point(191, 247);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(101, 26);
            labelUsuario.TabIndex = 8;
            labelUsuario.Text = "Usuario:";
            // 
            // pictureBoxLogoGrande
            // 
            pictureBoxLogoGrande.Image = Properties.Resources.Logo_Grande;
            pictureBoxLogoGrande.Location = new Point(23, 29);
            pictureBoxLogoGrande.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogoGrande.Name = "pictureBoxLogoGrande";
            pictureBoxLogoGrande.Size = new Size(95, 136);
            pictureBoxLogoGrande.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogoGrande.TabIndex = 7;
            pictureBoxLogoGrande.TabStop = false;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(105, 427);
            textBoxContraseña.Margin = new Padding(3, 4, 3, 4);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PlaceholderText = "Max. 20 caracteres";
            textBoxContraseña.Size = new Size(268, 27);
            textBoxContraseña.TabIndex = 6;
            // 
            // labelNombreEmpresa
            // 
            labelNombreEmpresa.AutoSize = true;
            labelNombreEmpresa.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            labelNombreEmpresa.ForeColor = Color.AntiqueWhite;
            labelNombreEmpresa.Location = new Point(125, 81);
            labelNombreEmpresa.Name = "labelNombreEmpresa";
            labelNombreEmpresa.Size = new Size(352, 38);
            labelNombreEmpresa.TabIndex = 5;
            labelNombreEmpresa.Text = "C a f é   l a   p l a c i t a";
            // 
            // textBoxNomUsuario
            // 
            textBoxNomUsuario.Location = new Point(105, 303);
            textBoxNomUsuario.Margin = new Padding(3, 4, 3, 4);
            textBoxNomUsuario.MaxLength = 25;
            textBoxNomUsuario.Name = "textBoxNomUsuario";
            textBoxNomUsuario.PlaceholderText = "Max. 25 caracteres";
            textBoxNomUsuario.Size = new Size(268, 27);
            textBoxNomUsuario.TabIndex = 2;
            // 
            // panelFotoYRedes
            // 
            panelFotoYRedes.BackColor = Color.AntiqueWhite;
            panelFotoYRedes.Controls.Add(panel3);
            panelFotoYRedes.Controls.Add(pictureBox1);
            panelFotoYRedes.Location = new Point(0, 1);
            panelFotoYRedes.Margin = new Padding(3, 4, 3, 4);
            panelFotoYRedes.Name = "panelFotoYRedes";
            panelFotoYRedes.Size = new Size(600, 711);
            panelFotoYRedes.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(110, 80, 50);
            panel3.Controls.Add(btnRedSocial3);
            panel3.Controls.Add(btnRedSocial2);
            panel3.Controls.Add(btnRedSocial1);
            panel3.Location = new Point(37, 539);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 113);
            panel3.TabIndex = 1;
            // 
            // btnRedSocial3
            // 
            btnRedSocial3.Dock = DockStyle.Left;
            btnRedSocial3.FlatAppearance.BorderSize = 5;
            btnRedSocial3.FlatStyle = FlatStyle.Flat;
            btnRedSocial3.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnRedSocial3.ForeColor = Color.AntiqueWhite;
            btnRedSocial3.Location = new Point(342, 0);
            btnRedSocial3.Margin = new Padding(3, 4, 3, 4);
            btnRedSocial3.Name = "btnRedSocial3";
            btnRedSocial3.Size = new Size(171, 113);
            btnRedSocial3.TabIndex = 12;
            btnRedSocial3.Text = "Red Social3";
            btnRedSocial3.UseVisualStyleBackColor = true;
            // 
            // btnRedSocial2
            // 
            btnRedSocial2.Dock = DockStyle.Left;
            btnRedSocial2.FlatAppearance.BorderSize = 5;
            btnRedSocial2.FlatStyle = FlatStyle.Flat;
            btnRedSocial2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnRedSocial2.ForeColor = Color.AntiqueWhite;
            btnRedSocial2.Location = new Point(171, 0);
            btnRedSocial2.Margin = new Padding(3, 4, 3, 4);
            btnRedSocial2.Name = "btnRedSocial2";
            btnRedSocial2.Size = new Size(171, 113);
            btnRedSocial2.TabIndex = 11;
            btnRedSocial2.Text = "Red Social2";
            btnRedSocial2.UseVisualStyleBackColor = true;
            // 
            // btnRedSocial1
            // 
            btnRedSocial1.Dock = DockStyle.Left;
            btnRedSocial1.FlatAppearance.BorderSize = 5;
            btnRedSocial1.FlatStyle = FlatStyle.Flat;
            btnRedSocial1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnRedSocial1.ForeColor = Color.AntiqueWhite;
            btnRedSocial1.Location = new Point(0, 0);
            btnRedSocial1.Margin = new Padding(3, 4, 3, 4);
            btnRedSocial1.Name = "btnRedSocial1";
            btnRedSocial1.Size = new Size(171, 113);
            btnRedSocial1.TabIndex = 10;
            btnRedSocial1.Text = "Red Social1";
            btnRedSocial1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(110, 80, 50);
            pictureBox1.Image = Properties.Resources.photoBase;
            pictureBox1.Location = new Point(41, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 476);
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
            // label1FechaHora
            // 
            label1FechaHora.AutoSize = true;
            label1FechaHora.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1FechaHora.ForeColor = Color.AntiqueWhite;
            label1FechaHora.Location = new Point(142, 633);
            label1FechaHora.Name = "label1FechaHora";
            label1FechaHora.Size = new Size(49, 19);
            label1FechaHora.TabIndex = 10;
            label1FechaHora.Text = "Fecha";
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 707);
            Controls.Add(panelFotoYRedes);
            Controls.Add(panelInicioSesion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}