namespace WinFormsProyectoBase
{
    partial class FormModificaciones
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
            textBoxId = new TextBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            pictureBoxOldImg = new PictureBox();
            textBoxOldCat = new TextBox();
            textBoxOldNom = new TextBox();
            textBoxOldDes = new TextBox();
            textBoxOldPre = new TextBox();
            textBoxOldEx = new TextBox();
            panel1 = new Panel();
            textBoxNombre = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxEx = new TextBox();
            textBoxDes = new TextBox();
            textBoxCat = new TextBox();
            buttonLoad = new Button();
            pictureBoxNew = new PictureBox();
            buttonMod = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOldImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNew).BeginInit();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(40, 57);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Introduzca ID";
            textBoxId.Size = new Size(267, 23);
            textBoxId.TabIndex = 1;
            textBoxId.TextChanged += textBoxId_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Enabled = false;
            textBox2.Location = new Point(40, 83);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 341);
            textBox2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(pictureBoxOldImg);
            panel2.Controls.Add(textBoxOldCat);
            panel2.Controls.Add(textBoxOldNom);
            panel2.Controls.Add(textBoxOldDes);
            panel2.Controls.Add(textBoxOldPre);
            panel2.Controls.Add(textBoxOldEx);
            panel2.Location = new Point(360, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 307);
            panel2.TabIndex = 1;
            // 
            // pictureBoxOldImg
            // 
            pictureBoxOldImg.BackColor = SystemColors.ScrollBar;
            pictureBoxOldImg.Location = new Point(44, 189);
            pictureBoxOldImg.Margin = new Padding(3, 2, 3, 2);
            pictureBoxOldImg.Name = "pictureBoxOldImg";
            pictureBoxOldImg.Size = new Size(229, 106);
            pictureBoxOldImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOldImg.TabIndex = 16;
            pictureBoxOldImg.TabStop = false;
            // 
            // textBoxOldCat
            // 
            textBoxOldCat.Location = new Point(12, 86);
            textBoxOldCat.Name = "textBoxOldCat";
            textBoxOldCat.PlaceholderText = "Antigua Categoria";
            textBoxOldCat.Size = new Size(291, 23);
            textBoxOldCat.TabIndex = 15;
            // 
            // textBoxOldNom
            // 
            textBoxOldNom.Location = new Point(12, 7);
            textBoxOldNom.Name = "textBoxOldNom";
            textBoxOldNom.PlaceholderText = "Antiguo Nombre";
            textBoxOldNom.Size = new Size(291, 23);
            textBoxOldNom.TabIndex = 11;
            // 
            // textBoxOldDes
            // 
            textBoxOldDes.Location = new Point(12, 112);
            textBoxOldDes.Multiline = true;
            textBoxOldDes.Name = "textBoxOldDes";
            textBoxOldDes.PlaceholderText = "Antigua Descripcion";
            textBoxOldDes.Size = new Size(291, 72);
            textBoxOldDes.TabIndex = 14;
            // 
            // textBoxOldPre
            // 
            textBoxOldPre.Location = new Point(12, 33);
            textBoxOldPre.Name = "textBoxOldPre";
            textBoxOldPre.PlaceholderText = "Antiguo Precio";
            textBoxOldPre.Size = new Size(291, 23);
            textBoxOldPre.TabIndex = 12;
            // 
            // textBoxOldEx
            // 
            textBoxOldEx.Location = new Point(12, 59);
            textBoxOldEx.Name = "textBoxOldEx";
            textBoxOldEx.PlaceholderText = "Antiguas Existencias";
            textBoxOldEx.Size = new Size(291, 23);
            textBoxOldEx.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(411, 76);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 409);
            panel1.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(54, 92);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Introduzca Nombre";
            textBoxNombre.Size = new Size(230, 23);
            textBoxNombre.TabIndex = 3;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(54, 118);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Introduzca Precio";
            textBoxPrecio.Size = new Size(230, 23);
            textBoxPrecio.TabIndex = 4;
            // 
            // textBoxEx
            // 
            textBoxEx.Location = new Point(54, 144);
            textBoxEx.Name = "textBoxEx";
            textBoxEx.PlaceholderText = "Introduzca Existencias";
            textBoxEx.Size = new Size(230, 23);
            textBoxEx.TabIndex = 5;
            // 
            // textBoxDes
            // 
            textBoxDes.Location = new Point(54, 196);
            textBoxDes.Multiline = true;
            textBoxDes.Name = "textBoxDes";
            textBoxDes.PlaceholderText = "Introduzca Descripcion";
            textBoxDes.Size = new Size(230, 72);
            textBoxDes.TabIndex = 6;
            // 
            // textBoxCat
            // 
            textBoxCat.Location = new Point(54, 170);
            textBoxCat.Name = "textBoxCat";
            textBoxCat.PlaceholderText = "Introduzca Categoria";
            textBoxCat.Size = new Size(230, 23);
            textBoxCat.TabIndex = 7;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.Window;
            buttonLoad.Location = new Point(78, 273);
            buttonLoad.Margin = new Padding(3, 2, 3, 2);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(179, 32);
            buttonLoad.TabIndex = 8;
            buttonLoad.Text = "Cargar Imagen";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // pictureBoxNew
            // 
            pictureBoxNew.BackColor = SystemColors.ScrollBar;
            pictureBoxNew.Location = new Point(78, 309);
            pictureBoxNew.Margin = new Padding(3, 2, 3, 2);
            pictureBoxNew.Name = "pictureBoxNew";
            pictureBoxNew.Size = new Size(179, 106);
            pictureBoxNew.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNew.TabIndex = 9;
            pictureBoxNew.TabStop = false;
            // 
            // buttonMod
            // 
            buttonMod.Location = new Point(404, 377);
            buttonMod.Margin = new Padding(3, 2, 3, 2);
            buttonMod.Name = "buttonMod";
            buttonMod.Size = new Size(229, 46);
            buttonMod.TabIndex = 10;
            buttonMod.Text = "Realizar Modificacion";
            buttonMod.UseVisualStyleBackColor = true;
            buttonMod.Click += buttonMod_Click;
            // 
            // FormModificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(729, 489);
            Controls.Add(buttonMod);
            Controls.Add(pictureBoxNew);
            Controls.Add(buttonLoad);
            Controls.Add(textBoxCat);
            Controls.Add(textBoxDes);
            Controls.Add(textBoxEx);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxId);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificaciones";
            Text = "FormModificaciones";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOldImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNew).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxId;
        private TextBox textBox2;
        private Panel panel2;
        private TextBox textBoxNombre;
        private TextBox textBoxPrecio;
        private TextBox textBoxEx;
        private TextBox textBoxDes;
        private TextBox textBoxCat;
        private Button buttonLoad;
        private PictureBox pictureBoxNew;
        private Button buttonMod;
        private PictureBox pictureBoxOldImg;
        private TextBox textBoxOldCat;
        private TextBox textBoxOldNom;
        private TextBox textBoxOldDes;
        private TextBox textBoxOldPre;
        private TextBox textBoxOldEx;
    }
}