namespace WinFormsProyectoBase
{
    partial class Altitas
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
            label1 = new Label();
            textBoxId = new TextBox();
            textBoxNom = new TextBox();
            textBoxDes = new TextBox();
            textBoxPre = new TextBox();
            textBoxEx = new TextBox();
            buttonAlta = new Button();
            buttonImage = new Button();
            pictureBoxpreview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxpreview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 21);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduccion de un producto";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(12, 72);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "ID";
            textBoxId.Size = new Size(195, 27);
            textBoxId.TabIndex = 1;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(12, 105);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.PlaceholderText = "Nombre";
            textBoxNom.Size = new Size(195, 27);
            textBoxNom.TabIndex = 2;
            // 
            // textBoxDes
            // 
            textBoxDes.Location = new Point(256, 72);
            textBoxDes.Multiline = true;
            textBoxDes.Name = "textBoxDes";
            textBoxDes.PlaceholderText = "Descripcion";
            textBoxDes.Size = new Size(379, 128);
            textBoxDes.TabIndex = 3;
            // 
            // textBoxPre
            // 
            textBoxPre.Location = new Point(12, 138);
            textBoxPre.Name = "textBoxPre";
            textBoxPre.PlaceholderText = "Precio";
            textBoxPre.Size = new Size(195, 27);
            textBoxPre.TabIndex = 4;
            // 
            // textBoxEx
            // 
            textBoxEx.Location = new Point(12, 173);
            textBoxEx.Name = "textBoxEx";
            textBoxEx.PlaceholderText = "Existencias";
            textBoxEx.Size = new Size(195, 27);
            textBoxEx.TabIndex = 5;
            // 
            // buttonAlta
            // 
            buttonAlta.Location = new Point(466, 240);
            buttonAlta.Name = "buttonAlta";
            buttonAlta.Size = new Size(169, 71);
            buttonAlta.TabIndex = 6;
            buttonAlta.Text = "Dar de Alta";
            buttonAlta.UseVisualStyleBackColor = true;
            buttonAlta.Click += buttonAlta_Click;
            // 
            // buttonImage
            // 
            buttonImage.Location = new Point(256, 240);
            buttonImage.Name = "buttonImage";
            buttonImage.Size = new Size(169, 71);
            buttonImage.TabIndex = 7;
            buttonImage.Text = "Cargar Imagen";
            buttonImage.UseVisualStyleBackColor = true;
            buttonImage.Click += buttonImage_Click;
            // 
            // pictureBoxpreview
            // 
            pictureBoxpreview.Location = new Point(12, 223);
            pictureBoxpreview.Name = "pictureBoxpreview";
            pictureBoxpreview.Size = new Size(194, 109);
            pictureBoxpreview.TabIndex = 8;
            pictureBoxpreview.TabStop = false;
            // 
            // Altitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 354);
            Controls.Add(pictureBoxpreview);
            Controls.Add(buttonImage);
            Controls.Add(buttonAlta);
            Controls.Add(textBoxEx);
            Controls.Add(textBoxPre);
            Controls.Add(textBoxDes);
            Controls.Add(textBoxNom);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Name = "Altitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Altitas";
            ((System.ComponentModel.ISupportInitialize)pictureBoxpreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxId;
        private TextBox textBoxNom;
        private TextBox textBoxDes;
        private TextBox textBoxPre;
        private TextBox textBoxEx;
        private Button buttonAlta;
        private Button buttonImage;
        private PictureBox pictureBoxpreview;
    }
}