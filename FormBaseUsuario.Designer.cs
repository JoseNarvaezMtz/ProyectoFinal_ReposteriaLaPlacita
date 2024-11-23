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
            panel1 = new Panel();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btnCerrarSesionUs = new Button();
            labelNomUsuario = new Label();
            panel2 = new Panel();
            label2 = new Label();
            btnPostres = new Button();
            btnPan = new Button();
            PanelPrincipal = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(110, 80, 50);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnCerrarSesionUs);
            panel1.Controls.Add(labelNomUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 95);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.AntiqueWhite;
            button4.Image = Properties.Resources.Logo;
            button4.Location = new Point(27, 16);
            button4.Name = "button4";
            button4.Size = new Size(266, 52);
            button4.TabIndex = 3;
            button4.Text = "C a f é   l a   p l a c i t a";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photoBase;
            pictureBox1.Location = new Point(324, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 95);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tempus Sans ITC", 8F, FontStyle.Bold);
            button3.ForeColor = Color.AntiqueWhite;
            button3.Location = new Point(925, 0);
            button3.Name = "button3";
            button3.Size = new Size(25, 25);
            button3.TabIndex = 2;
            button3.Text = "X";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnCerrarSesionUs
            // 
            btnCerrarSesionUs.FlatStyle = FlatStyle.Flat;
            btnCerrarSesionUs.Font = new Font("Tempus Sans ITC", 10F, FontStyle.Bold);
            btnCerrarSesionUs.ForeColor = Color.AntiqueWhite;
            btnCerrarSesionUs.Location = new Point(838, 57);
            btnCerrarSesionUs.Name = "btnCerrarSesionUs";
            btnCerrarSesionUs.Size = new Size(107, 28);
            btnCerrarSesionUs.TabIndex = 1;
            btnCerrarSesionUs.Text = "Cerrar sesion";
            btnCerrarSesionUs.TextAlign = ContentAlignment.MiddleRight;
            btnCerrarSesionUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesionUs.UseVisualStyleBackColor = true;
            btnCerrarSesionUs.Click += button2_Click;
            // 
            // labelNomUsuario
            // 
            labelNomUsuario.AutoSize = true;
            labelNomUsuario.Font = new Font("Tempus Sans ITC", 11F, FontStyle.Bold);
            labelNomUsuario.ForeColor = Color.AntiqueWhite;
            labelNomUsuario.Location = new Point(793, 35);
            labelNomUsuario.Name = "labelNomUsuario";
            labelNomUsuario.Size = new Size(152, 19);
            labelNomUsuario.TabIndex = 0;
            labelNomUsuario.Text = "Nombre de Usuario";
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
        private Button button3;
        private Button button4;
    }
}
