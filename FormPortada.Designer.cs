namespace WinFormsProyectoBase
{
    partial class FormPortada
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
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            btnSalirUs = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label5.Location = new Point(415, 164);
            label5.Name = "label5";
            label5.Size = new Size(168, 30);
            label5.TabIndex = 11;
            label5.Text = "Proyecto Final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(359, 270);
            label3.Name = "label3";
            label3.Size = new Size(281, 133);
            label3.TabIndex = 10;
            label3.Text = "    Julián Emmanuel Hernández ID: 300933\r\n\r\n       José Luis Narváez Martínez ID: 300492\r\n\r\n Lorenzo Antonio Pacheco Leyva ID: 301298\r\n\r\n     Ana Lorena Rosales Delgado ID: 296045\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.Location = new Point(449, 220);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 9;
            label2.Text = "Integrantes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(560, 22);
            label4.Name = "label4";
            label4.Size = new Size(301, 60);
            label4.TabIndex = 14;
            label4.Text = "Programación II\r\nDocente: Dra. Georgina Salazar Partida\r\nFecha de entrega: Martes 17 De Diciembre 2024";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 54, 113);
            panel2.Location = new Point(-2, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 33);
            panel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 22);
            label1.Name = "label1";
            label1.Size = new Size(267, 60);
            label1.TabIndex = 12;
            label1.Text = "Ingeniería en Sistemas Computacionales \r\n           Centro de Ciencias Básicas \r\nDepartamento de Sistemas Electrónicos \r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 54, 113);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(-2, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 68);
            panel1.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 54, 113);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(163, 11);
            button2.Name = "button2";
            button2.Size = new Size(122, 46);
            button2.TabIndex = 2;
            button2.Text = "Aulavirtual";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 54, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 11);
            button1.Name = "button1";
            button1.Size = new Size(122, 46);
            button1.TabIndex = 1;
            button1.Text = "Esiima";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(34, 54, 113);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(850, 11);
            button3.Name = "button3";
            button3.Size = new Size(122, 46);
            button3.TabIndex = 0;
            button3.Text = "Continuar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnSalirUs
            // 
            btnSalirUs.BackColor = SystemColors.Window;
            btnSalirUs.FlatStyle = FlatStyle.Flat;
            btnSalirUs.Font = new Font("Tempus Sans ITC", 8F, FontStyle.Bold);
            btnSalirUs.ForeColor = Color.FromArgb(34, 54, 113);
            btnSalirUs.Location = new Point(971, 1);
            btnSalirUs.Name = "btnSalirUs";
            btnSalirUs.Size = new Size(26, 27);
            btnSalirUs.TabIndex = 16;
            btnSalirUs.Text = "X";
            btnSalirUs.TextAlign = ContentAlignment.MiddleRight;
            btnSalirUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalirUs.UseVisualStyleBackColor = false;
            btnSalirUs.Click += btnSalirUs_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoUAA;
            pictureBox1.Location = new Point(25, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormPortada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(998, 567);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalirUs);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPortada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPortada";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button btnSalirUs;
        private PictureBox pictureBox1;
    }
}