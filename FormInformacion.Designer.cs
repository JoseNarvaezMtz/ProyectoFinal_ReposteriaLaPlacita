﻿namespace WinFormsProyectoBase
{
    partial class FormInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacion));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelBienvenida = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.photoBase;
            pictureBox3.Location = new Point(805, 104);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(87, 264);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.photoBase;
            pictureBox2.Location = new Point(56, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 264);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // labelBienvenida
            // 
            labelBienvenida.AutoSize = true;
            labelBienvenida.Font = new Font("Script MT Bold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenida.ForeColor = Color.FromArgb(110, 80, 50);
            labelBienvenida.Location = new Point(158, 43);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(636, 48);
            labelBienvenida.TabIndex = 8;
            labelBienvenida.Text = "¡ ¡ Bienvenid@ a nuestra aplicación ! !";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Script MT Bold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(110, 80, 50);
            label1.Location = new Point(214, 159);
            label1.Name = "label1";
            label1.Size = new Size(520, 165);
            label1.TabIndex = 12;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(110, 80, 50);
            label2.Location = new Point(279, 104);
            label2.Name = "label2";
            label2.Size = new Size(388, 22);
            label2.TabIndex = 15;
            label2.Text = "\"Delicia tras delicia para endulzar tu pancita\"";
            // 
            // FormInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(951, 444);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(labelBienvenida);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInformacion";
            Text = "FormInformacion";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label labelBienvenida;
        private Label label1;
        private Label label2;
    }
}