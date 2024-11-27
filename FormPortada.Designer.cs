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
            btnAplicacion = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAplicacion
            // 
            btnAplicacion.Location = new Point(864, 509);
            btnAplicacion.Name = "btnAplicacion";
            btnAplicacion.Size = new Size(122, 46);
            btnAplicacion.TabIndex = 0;
            btnAplicacion.Text = "Continuar";
            btnAplicacion.UseVisualStyleBackColor = true;
            btnAplicacion.Click += btnAplicacion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(435, 232);
            label1.Name = "label1";
            label1.Size = new Size(97, 31);
            label1.TabIndex = 1;
            label1.Text = "Portada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 277);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Elementos";
            // 
            // FormPortada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 567);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAplicacion);
            Name = "FormPortada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPortada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAplicacion;
        private Label label1;
        private Label label2;
    }
}