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
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            panelBase = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(40, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(117, 37);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Location = new Point(173, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Location = new Point(40, 134);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 290);
            textBox2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(360, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 367);
            panel2.TabIndex = 1;
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.FromArgb(46, 51, 73);
            panelBase.Location = new Point(0, -8);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(729, 504);
            panelBase.TabIndex = 9;
            // 
            // FormModificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(729, 489);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(panelBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificaciones";
            Text = "FormModificaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel2;
        private Panel panelBase;
    }
}