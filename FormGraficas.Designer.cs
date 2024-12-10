namespace WinFormsProyectoBase
{
    partial class FormGraficas
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
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panelBase = new Panel();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(396, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 237);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(56, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 237);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(56, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(152, 54);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(254, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(152, 54);
            panel4.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Location = new Point(481, 45);
            panel5.Name = "panel5";
            panel5.Size = new Size(152, 54);
            panel5.TabIndex = 5;
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.FromArgb(46, 51, 73);
            panelBase.Location = new Point(0, -8);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(729, 504);
            panelBase.TabIndex = 12;
            // 
            // FormGraficas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(729, 489);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panelBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGraficas";
            Text = "FormGraficas";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panelBase;
    }
}