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
            labelEslogan = new Label();
            buttonCancelarCompra = new Button();
            buttonDescargar = new Button();
            progressBarDescargarTicket = new ProgressBar();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(labelEslogan);
            panel1.Controls.Add(btnInformacion);
            panel1.Controls.Add(btnSalirUs);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 95);
            panel1.TabIndex = 1;
            // 
            // labelEslogan
            // 
            labelEslogan.AutoSize = true;
            labelEslogan.Font = new Font("Tempus Sans ITC", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelEslogan.ForeColor = Color.AntiqueWhite;
            labelEslogan.Location = new Point(382, 23);
            labelEslogan.Name = "labelEslogan";
            labelEslogan.Size = new Size(390, 38);
            labelEslogan.TabIndex = 4;
            labelEslogan.Text = "\"ESLOGAN DE LA TIENDA\"";
            // 
            // buttonCancelarCompra
            // 
            buttonCancelarCompra.BackColor = Color.FromArgb(110, 80, 50);
            buttonCancelarCompra.FlatAppearance.BorderSize = 0;
            buttonCancelarCompra.FlatStyle = FlatStyle.Flat;
            buttonCancelarCompra.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonCancelarCompra.ForeColor = Color.AntiqueWhite;
            buttonCancelarCompra.Location = new Point(321, 110);
            buttonCancelarCompra.Margin = new Padding(3, 2, 3, 2);
            buttonCancelarCompra.Name = "buttonCancelarCompra";
            buttonCancelarCompra.Size = new Size(297, 44);
            buttonCancelarCompra.TabIndex = 68;
            buttonCancelarCompra.Text = "Ver Ticket de compra";
            buttonCancelarCompra.UseVisualStyleBackColor = false;
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
            // 
            // progressBarDescargarTicket
            // 
            progressBarDescargarTicket.Location = new Point(324, 842);
            progressBarDescargarTicket.Name = "progressBarDescargarTicket";
            progressBarDescargarTicket.Size = new Size(568, 47);
            progressBarDescargarTicket.TabIndex = 70;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(914, 900);
            Controls.Add(progressBarDescargarTicket);
            Controls.Add(buttonDescargar);
            Controls.Add(buttonCancelarCompra);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTicket";
            Text = "FormTicket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalirUs;
        private Button btnInformacion;
        private Panel panel1;
        private Label labelEslogan;
        private Button buttonCancelarCompra;
        private Button buttonDescargar;
        private ProgressBar progressBarDescargarTicket;
    }
}