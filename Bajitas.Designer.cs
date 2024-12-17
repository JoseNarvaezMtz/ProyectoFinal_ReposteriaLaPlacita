namespace WinFormsProyectoBase
{
    partial class Bajitas
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
            label2 = new Label();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            textBoxId = new TextBox();
            pictureBoxListado = new PictureBox();
            textBoxNombre = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxExistencias = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxListado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 1;
            label1.Text = "Eliminacion del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 44);
            label2.Name = "label2";
            label2.Size = new Size(326, 15);
            label2.TabIndex = 2;
            label2.Text = "¿Está usted seguro que desea eliminar el siguiente producto?";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(97, 329);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(121, 42);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "No";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(290, 329);
            buttonConfirm.Margin = new Padding(3, 2, 3, 2);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(122, 42);
            buttonConfirm.TabIndex = 4;
            buttonConfirm.Text = "Si";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // textBoxId
            // 
            textBoxId.AcceptsTab = true;
            textBoxId.BackColor = SystemColors.Info;
            textBoxId.Location = new Point(24, 76);
            textBoxId.Multiline = true;
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(220, 25);
            textBoxId.TabIndex = 5;
            // 
            // pictureBoxListado
            // 
            pictureBoxListado.Location = new Point(297, 157);
            pictureBoxListado.Name = "pictureBoxListado";
            pictureBoxListado.Size = new Size(220, 136);
            pictureBoxListado.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxListado.TabIndex = 6;
            pictureBoxListado.TabStop = false;
            // 
            // textBoxNombre
            // 
            textBoxNombre.AcceptsTab = true;
            textBoxNombre.BackColor = SystemColors.Info;
            textBoxNombre.Location = new Point(24, 112);
            textBoxNombre.Multiline = true;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(220, 27);
            textBoxNombre.TabIndex = 7;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.AcceptsTab = true;
            textBoxPrecio.BackColor = SystemColors.Info;
            textBoxPrecio.Location = new Point(297, 76);
            textBoxPrecio.Multiline = true;
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.ReadOnly = true;
            textBoxPrecio.Size = new Size(220, 26);
            textBoxPrecio.TabIndex = 8;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.AcceptsTab = true;
            textBoxDescripcion.BackColor = SystemColors.Info;
            textBoxDescripcion.Location = new Point(24, 157);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.ReadOnly = true;
            textBoxDescripcion.Size = new Size(251, 136);
            textBoxDescripcion.TabIndex = 9;
            // 
            // textBoxExistencias
            // 
            textBoxExistencias.AcceptsTab = true;
            textBoxExistencias.BackColor = SystemColors.Info;
            textBoxExistencias.Location = new Point(297, 113);
            textBoxExistencias.Multiline = true;
            textBoxExistencias.Name = "textBoxExistencias";
            textBoxExistencias.ReadOnly = true;
            textBoxExistencias.Size = new Size(220, 26);
            textBoxExistencias.TabIndex = 10;
            // 
            // Bajitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 391);
            Controls.Add(textBoxExistencias);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxNombre);
            Controls.Add(pictureBoxListado);
            Controls.Add(textBoxId);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bajitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bajitas";
            ((System.ComponentModel.ISupportInitialize)pictureBoxListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonCancel;
        private Button buttonConfirm;
        private TextBox textBoxId;
        private PictureBox pictureBoxListado;
        private TextBox textBoxNombre;
        private TextBox textBoxPrecio;
        private TextBox textBoxDescripcion;
        private TextBox textBoxExistencias;
    }
}