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
            panelBase.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(733, 171);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(69, 48);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(645, 171);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 49);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(64, 60);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 72);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(290, 60);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 72);
            panel4.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Location = new Point(550, 60);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(174, 72);
            panel5.TabIndex = 5;
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.FromArgb(46, 51, 73);
            panelBase.Controls.Add(panel2);
            panelBase.Controls.Add(panel1);
            panelBase.Location = new Point(0, -11);
            panelBase.Margin = new Padding(3, 4, 3, 4);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(833, 672);
            panelBase.TabIndex = 12;
            // 
            // FormGraficas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(833, 652);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelBase);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGraficas";
            Text = "FormGraficas";
            panelBase.ResumeLayout(false);
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