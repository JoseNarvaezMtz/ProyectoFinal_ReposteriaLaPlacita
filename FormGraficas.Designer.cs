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
            labelSumaVentas = new Label();
            label1 = new Label();
            formsPlotGrafica = new ScottPlot.FormsPlot();
            panelBase.SuspendLayout();
            SuspendLayout();
            // 
            // labelEjeX
            // 
            labelEjeX.AutoSize = true;
            labelEjeX.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEjeX.ForeColor = Color.FromArgb(64, 64, 64);
            labelEjeX.Location = new Point(636, 430);
            labelEjeX.Name = "labelEjeX";
            labelEjeX.Size = new Size(80, 19);
            labelEjeX.TabIndex = 8;
            labelEjeX.Text = "Encargado";
            // 
            // labelTituloGrafica
            // 
            labelTituloGrafica.AutoSize = true;
            labelTituloGrafica.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloGrafica.ForeColor = Color.SaddleBrown;
            labelTituloGrafica.Location = new Point(266, 36);
            labelTituloGrafica.Name = "labelTituloGrafica";
            labelTituloGrafica.Size = new Size(205, 20);
            labelTituloGrafica.TabIndex = 0;
            labelTituloGrafica.Text = "Consulta de Ventas Totales";
            // 
            // labelEjeY
            // 
            labelEjeY.AutoSize = true;
            labelEjeY.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEjeY.ForeColor = Color.FromArgb(64, 64, 64);
            labelEjeY.Location = new Point(60, 76);
            labelEjeY.Name = "labelEjeY";
            labelEjeY.Size = new Size(52, 19);
            labelEjeY.TabIndex = 7;
            labelEjeY.Text = "Ventas";
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.FromArgb(46, 51, 73);
            panelBase.Controls.Add(labelSumaVentas);
            panelBase.Controls.Add(label1);
            panelBase.Controls.Add(labelEjeX);
            panelBase.Controls.Add(labelEjeY);
            panelBase.Controls.Add(labelTituloGrafica);
            panelBase.Controls.Add(formsPlotGrafica);
            panelBase.Location = new Point(0, -8);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(729, 504);
            panelBase.TabIndex = 12;
            // 
            // labelSumaVentas
            // 
            labelSumaVentas.AutoSize = true;
            labelSumaVentas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSumaVentas.ForeColor = Color.White;
            labelSumaVentas.Location = new Point(123, 469);
            labelSumaVentas.Name = "labelSumaVentas";
            labelSumaVentas.Size = new Size(17, 19);
            labelSumaVentas.TabIndex = 10;
            labelSumaVentas.Text = "$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 469);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 9;
            label1.Text = "Total de Ventas:";
            // 
            // formsPlotGrafica
            // 
            formsPlotGrafica.Location = new Point(122, 64);
            formsPlotGrafica.Margin = new Padding(4, 3, 4, 3);
            formsPlotGrafica.Name = "formsPlotGrafica";
            formsPlotGrafica.Size = new Size(494, 389);
            formsPlotGrafica.TabIndex = 6;
            // 
            // FormGraficas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(729, 489);
            Controls.Add(panelBase);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label1;
        private Label labelSumaVentas;
    }
}