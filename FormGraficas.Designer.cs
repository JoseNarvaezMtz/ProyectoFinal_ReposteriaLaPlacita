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
            labelEjeX = new Label();
            labelTituloGrafica = new Label();
            labelEjeY = new Label();
            panelBase = new Panel();
            formsPlotGrafica = new ScottPlot.FormsPlot();
            panelBase.SuspendLayout();
            SuspendLayout();
            // 
            // labelEjeX
            // 
            labelEjeX.AutoSize = true;
            labelEjeX.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEjeX.ForeColor = Color.FromArgb(64, 64, 64);
            labelEjeX.Location = new Point(727, 573);
            labelEjeX.Name = "labelEjeX";
            labelEjeX.Size = new Size(94, 23);
            labelEjeX.TabIndex = 8;
            labelEjeX.Text = "Encargado";
            // 
            // labelTituloGrafica
            // 
            labelTituloGrafica.AutoSize = true;
            labelTituloGrafica.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloGrafica.ForeColor = Color.SaddleBrown;
            labelTituloGrafica.Location = new Point(304, 48);
            labelTituloGrafica.Name = "labelTituloGrafica";
            labelTituloGrafica.Size = new Size(253, 25);
            labelTituloGrafica.TabIndex = 0;
            labelTituloGrafica.Text = "Gráfica del Total de Ventas";
            // 
            // labelEjeY
            // 
            labelEjeY.AutoSize = true;
            labelEjeY.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEjeY.ForeColor = Color.FromArgb(64, 64, 64);
            labelEjeY.Location = new Point(69, 101);
            labelEjeY.Name = "labelEjeY";
            labelEjeY.Size = new Size(62, 23);
            labelEjeY.TabIndex = 7;
            labelEjeY.Text = "Ventas";
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.FromArgb(46, 51, 73);
            panelBase.Controls.Add(labelEjeX);
            panelBase.Controls.Add(labelEjeY);
            panelBase.Controls.Add(labelTituloGrafica);
            panelBase.Controls.Add(formsPlotGrafica);
            panelBase.Location = new Point(0, -11);
            panelBase.Margin = new Padding(3, 4, 3, 4);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(833, 672);
            panelBase.TabIndex = 12;
            // 
            // formsPlotGrafica
            // 
            formsPlotGrafica.Location = new Point(139, 86);
            formsPlotGrafica.Margin = new Padding(5, 4, 5, 4);
            formsPlotGrafica.Name = "formsPlotGrafica";
            formsPlotGrafica.Size = new Size(565, 519);
            formsPlotGrafica.TabIndex = 6;
            // 
            // FormGraficas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(833, 652);
            Controls.Add(panelBase);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGraficas";
            Text = "FormGraficas";
            panelBase.ResumeLayout(false);
            panelBase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBase;
        private ScottPlot.FormsPlot formsPlotGrafica;
        private Label labelTituloGrafica;
        private Label labelEjeX;
        private Label labelEjeY;
    }
}