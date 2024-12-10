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
            textBoxOldDes = new TextBox();
            textBoxOldCat = new TextBox();
            textBoxOldEx = new TextBox();
            textBoxOldPre = new TextBox();
            textBoxOldNom = new TextBox();
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
            textBoxId.Location = new Point(46, 76);
            textBoxId.Margin = new Padding(3, 4, 3, 4);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Introduzca ID";
            textBoxId.Size = new Size(305, 27);
            textBoxId.TabIndex = 1;
            textBoxId.TextChanged += textBoxId_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Enabled = false;
            textBox2.Location = new Point(46, 111);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 453);
            textBox2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(pictureBoxOldImg);
            panel2.Controls.Add(textBoxOldDes);
            panel2.Controls.Add(textBoxOldCat);
            panel2.Controls.Add(textBoxOldEx);
            panel2.Controls.Add(textBoxOldPre);
            panel2.Controls.Add(textBoxOldNom);
            panel2.Location = new Point(411, 76);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 409);
            panel2.TabIndex = 1;
            // 
            // pictureBoxOldImg
            // 
            pictureBoxOldImg.BackColor = SystemColors.ScrollBar;
            pictureBoxOldImg.Location = new Point(51, 259);
            pictureBoxOldImg.Name = "pictureBoxOldImg";
            pictureBoxOldImg.Size = new Size(262, 141);
            pictureBoxOldImg.TabIndex = 10;
            pictureBoxOldImg.TabStop = false;
            // 
            // textBoxOldDes
            // 
            textBoxOldDes.Location = new Point(14, 157);
            textBoxOldDes.Margin = new Padding(3, 4, 3, 4);
            textBoxOldDes.Multiline = true;
            textBoxOldDes.Name = "textBoxOldDes";
            textBoxOldDes.PlaceholderText = "Antigua Descripcion";
            textBoxOldDes.ReadOnly = true;
            textBoxOldDes.Size = new Size(334, 95);
            textBoxOldDes.TabIndex = 10;
            // 
            // textBoxOldCat
            // 
            textBoxOldCat.Location = new Point(14, 122);
            textBoxOldCat.Margin = new Padding(3, 4, 3, 4);
            textBoxOldCat.Name = "textBoxOldCat";
            textBoxOldCat.PlaceholderText = "Antigua Categoria";
            textBoxOldCat.ReadOnly = true;
            textBoxOldCat.Size = new Size(334, 27);
            textBoxOldCat.TabIndex = 13;
            // 
            // textBoxOldEx
            // 
            textBoxOldEx.Location = new Point(14, 87);
            textBoxOldEx.Margin = new Padding(3, 4, 3, 4);
            textBoxOldEx.Name = "textBoxOldEx";
            textBoxOldEx.PlaceholderText = "Antiguas Existencias";
            textBoxOldEx.ReadOnly = true;
            textBoxOldEx.Size = new Size(334, 27);
            textBoxOldEx.TabIndex = 12;
            // 
            // textBoxOldPre
            // 
            textBoxOldPre.Location = new Point(14, 52);
            textBoxOldPre.Margin = new Padding(3, 4, 3, 4);
            textBoxOldPre.Name = "textBoxOldPre";
            textBoxOldPre.PlaceholderText = "Antiguo Precio";
            textBoxOldPre.ReadOnly = true;
            textBoxOldPre.Size = new Size(334, 27);
            textBoxOldPre.TabIndex = 11;
            // 
            // textBoxOldNom
            // 
            textBoxOldNom.Location = new Point(14, 17);
            textBoxOldNom.Margin = new Padding(3, 4, 3, 4);
            textBoxOldNom.Name = "textBoxOldNom";
            textBoxOldNom.PlaceholderText = "Antiguo Nombre";
            textBoxOldNom.ReadOnly = true;
            textBoxOldNom.Size = new Size(334, 27);
            textBoxOldNom.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(62, 122);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Introduzca Nombre";
            textBoxNombre.Size = new Size(262, 27);
            textBoxNombre.TabIndex = 3;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(62, 157);
            textBoxPrecio.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Introduzca Precio";
            textBoxPrecio.Size = new Size(262, 27);
            textBoxPrecio.TabIndex = 4;
            // 
            // textBoxEx
            // 
            textBoxEx.Location = new Point(62, 192);
            textBoxEx.Margin = new Padding(3, 4, 3, 4);
            textBoxEx.Name = "textBoxEx";
            textBoxEx.PlaceholderText = "Introduzca Existencias";
            textBoxEx.Size = new Size(262, 27);
            textBoxEx.TabIndex = 5;
            // 
            // textBoxDes
            // 
            textBoxDes.Location = new Point(62, 262);
            textBoxDes.Margin = new Padding(3, 4, 3, 4);
            textBoxDes.Multiline = true;
            textBoxDes.Name = "textBoxDes";
            textBoxDes.PlaceholderText = "Introduzca Descripcion";
            textBoxDes.Size = new Size(262, 95);
            textBoxDes.TabIndex = 6;
            // 
            // textBoxCat
            // 
            textBoxCat.Location = new Point(62, 227);
            textBoxCat.Margin = new Padding(3, 4, 3, 4);
            textBoxCat.Name = "textBoxCat";
            textBoxCat.PlaceholderText = "Introduzca Categoria";
            textBoxCat.Size = new Size(262, 27);
            textBoxCat.TabIndex = 7;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.Window;
            buttonLoad.Location = new Point(89, 364);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(205, 42);
            buttonLoad.TabIndex = 8;
            buttonLoad.Text = "Cargar Imagen";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // pictureBoxNew
            // 
            pictureBoxNew.BackColor = SystemColors.ScrollBar;
            pictureBoxNew.Location = new Point(62, 412);
            pictureBoxNew.Name = "pictureBoxNew";
            pictureBoxNew.Size = new Size(262, 141);
            pictureBoxNew.TabIndex = 9;
            pictureBoxNew.TabStop = false;
            // 
            // buttonMod
            // 
            buttonMod.Location = new Point(462, 503);
            buttonMod.Name = "buttonMod";
            buttonMod.Size = new Size(262, 61);
            buttonMod.TabIndex = 10;
            buttonMod.Text = "Realizar Modificacion";
            buttonMod.UseVisualStyleBackColor = true;
            buttonMod.Click += buttonMod_Click;
            // 
            // FormModificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(833, 635);
            Controls.Add(buttonMod);
            Controls.Add(pictureBoxNew);
            Controls.Add(buttonLoad);
            Controls.Add(textBoxCat);
            Controls.Add(textBoxDes);
            Controls.Add(textBoxEx);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxNombre);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(textBoxId);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private PictureBox pictureBoxOldImg;
        private TextBox textBoxOldDes;
        private TextBox textBoxOldCat;
        private TextBox textBoxOldEx;
        private TextBox textBoxOldPre;
        private TextBox textBoxOldNom;
        private Button buttonMod;
    }
}