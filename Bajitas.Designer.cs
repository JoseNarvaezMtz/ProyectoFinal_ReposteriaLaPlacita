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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 27);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 1;
            label1.Text = "Eliminacion del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 80);
            label2.Name = "label2";
            label2.Size = new Size(384, 20);
            label2.TabIndex = 2;
            label2.Text = "Esta usted seguro que desea eliminar el producto con id:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(74, 153);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(179, 85);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "No";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(366, 153);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(179, 85);
            buttonConfirm.TabIndex = 4;
            buttonConfirm.Text = "Si";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // Bajitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 295);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bajitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bajitas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonCancel;
        private Button buttonConfirm;
    }
}