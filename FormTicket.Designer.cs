namespace WinFormsProyectoBase
{
    partial class FormTicket
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
            btnSalirUs = new Button();
            btnInformacion = new Button();
            panel1 = new Panel();
            btnSalirMetPago = new Button();
            labelEslogan = new Label();
            buttonDescargar = new Button();
            progressBarDescargarTicket = new ProgressBar();
            buttonVerTicket = new Button();
            label1 = new Label();
            panelTicket = new Panel();
            panel1.SuspendLayout();
            panelTicket.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalirUs
            // 
            btnSalirUs.FlatStyle = FlatStyle.Flat;
            btnSalirUs.Font = new Font("Tempus Sans ITC", 8F, FontStyle.Bold);
            btnSalirUs.ForeColor = Color.AntiqueWhite;
            btnSalirUs.Location = new Point(925, 0);
            btnSalirUs.Name = "btnSalirUs";
            btnSalirUs.Size = new Size(25, 25);
            btnSalirUs.TabIndex = 2;
            btnSalirUs.Text = "X";
            btnSalirUs.TextAlign = ContentAlignment.MiddleRight;
            btnSalirUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalirUs.UseVisualStyleBackColor = true;
            // 
            // btnInformacion
            // 
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInformacion.ForeColor = Color.AntiqueWhite;
            btnInformacion.Image = Properties.Resources.Logo;
            btnInformacion.Location = new Point(10, 12);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(291, 64);
            btnInformacion.TabIndex = 3;
            btnInformacion.Text = "C a f é   l a   p l a c i t a";
            btnInformacion.TextAlign = ContentAlignment.MiddleRight;
            btnInformacion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInformacion.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(110, 80, 50);
            panel1.Controls.Add(btnSalirMetPago);
            panel1.Controls.Add(labelEslogan);
            panel1.Controls.Add(btnInformacion);
            panel1.Controls.Add(btnSalirUs);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 95);
            panel1.TabIndex = 1;
            // 
            // btnSalirMetPago
            // 
            btnSalirMetPago.BackColor = Color.FromArgb(110, 80, 50);
            btnSalirMetPago.FlatAppearance.BorderSize = 0;
            btnSalirMetPago.FlatStyle = FlatStyle.Flat;
            btnSalirMetPago.Font = new Font("Sans Serif Collection", 10F, FontStyle.Bold);
            btnSalirMetPago.ForeColor = Color.AntiqueWhite;
            btnSalirMetPago.Location = new Point(877, 2);
            btnSalirMetPago.Margin = new Padding(3, 2, 3, 2);
            btnSalirMetPago.Name = "btnSalirMetPago";
            btnSalirMetPago.Size = new Size(37, 37);
            btnSalirMetPago.TabIndex = 21;
            btnSalirMetPago.Text = "X";
            btnSalirMetPago.UseVisualStyleBackColor = false;
            btnSalirMetPago.Click += btnSalirMetPago_Click;
            // 
            // labelEslogan
            // 
            labelEslogan.AutoSize = true;
            labelEslogan.Font = new Font("Tempus Sans ITC", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelEslogan.ForeColor = Color.AntiqueWhite;
            labelEslogan.Location = new Point(315, 12);
            labelEslogan.Name = "labelEslogan";
            labelEslogan.Size = new Size(390, 38);
            labelEslogan.TabIndex = 4;
            labelEslogan.Text = "\"ESLOGAN DE LA TIENDA\"";
            // 
            // buttonDescargar
            // 
            buttonDescargar.BackColor = Color.FromArgb(110, 80, 50);
            buttonDescargar.FlatAppearance.BorderSize = 0;
            buttonDescargar.FlatStyle = FlatStyle.Flat;
            buttonDescargar.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonDescargar.ForeColor = Color.AntiqueWhite;
            buttonDescargar.Location = new Point(21, 845);
            buttonDescargar.Margin = new Padding(3, 2, 3, 2);
            buttonDescargar.Name = "buttonDescargar";
            buttonDescargar.Size = new Size(297, 44);
            buttonDescargar.TabIndex = 69;
            buttonDescargar.Text = "Descargar Ticket";
            buttonDescargar.UseVisualStyleBackColor = false;
            buttonDescargar.Click += buttonDescargar_Click;
            // 
            // progressBarDescargarTicket
            // 
            progressBarDescargarTicket.Location = new Point(324, 842);
            progressBarDescargarTicket.Name = "progressBarDescargarTicket";
            progressBarDescargarTicket.Size = new Size(568, 47);
            progressBarDescargarTicket.TabIndex = 70;
            // 
            // buttonVerTicket
            // 
            buttonVerTicket.BackColor = Color.FromArgb(110, 80, 50);
            buttonVerTicket.FlatAppearance.BorderSize = 0;
            buttonVerTicket.FlatStyle = FlatStyle.Flat;
            buttonVerTicket.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonVerTicket.ForeColor = Color.AntiqueWhite;
            buttonVerTicket.Location = new Point(315, 756);
            buttonVerTicket.Margin = new Padding(3, 2, 3, 2);
            buttonVerTicket.Name = "buttonVerTicket";
            buttonVerTicket.Size = new Size(297, 44);
            buttonVerTicket.TabIndex = 69;
            buttonVerTicket.Text = "Ver Ticket de compra";
            buttonVerTicket.UseVisualStyleBackColor = false;
            buttonVerTicket.Click += buttonVerTicket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("Tempus Sans ITC", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(314, 280);
            label1.Name = "label1";
            label1.Size = new Size(245, 38);
            label1.TabIndex = 5;
            label1.Text = "prueba solo panel";
            // 
            // panelTicket
            // 
            panelTicket.Controls.Add(label1);
            panelTicket.Location = new Point(33, 121);
            panelTicket.Name = "panelTicket";
            panelTicket.Size = new Size(847, 615);
            panelTicket.TabIndex = 71;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(914, 900);
            Controls.Add(buttonVerTicket);
            Controls.Add(progressBarDescargarTicket);
            Controls.Add(buttonDescargar);
            Controls.Add(panel1);
            Controls.Add(panelTicket);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTicket";
            Text = "FormTicket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTicket.ResumeLayout(false);
            panelTicket.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalirUs;
        private Button btnInformacion;
        private Panel panel1;
        private Label labelEslogan;
        private Button buttonDescargar;
        private ProgressBar progressBarDescargarTicket;
        private Button btnSalirMetPago;
        private Button buttonVerTicket;
        private Label label1;
        private Panel panelTicket;
    }
}