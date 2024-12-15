namespace WinFormsProyectoBase
{
    partial class FormPagoOxxo
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
            btnSalir = new Button();
            labelEslogan = new Label();
            buttonDescargar = new Button();
            progressBarDescargarTicket = new ProgressBar();
            buttonPagar = new Button();
            buttonCancelar = new Button();
            richTextBoxProductosSelec = new RichTextBox();
            richTextBoxCantidadSelecc = new RichTextBox();
            labelCantidad = new Label();
            labelProductosSelec = new Label();
            labelTotalCompra = new Label();
            textBoxTotalCompra = new TextBox();
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
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(labelEslogan);
            panel1.Controls.Add(btnInformacion);
            panel1.Controls.Add(btnSalirUs);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 95);
            panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(110, 80, 50);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Sans Serif Collection", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.AntiqueWhite;
            btnSalir.Location = new Point(864, 2);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(50, 45);
            btnSalir.TabIndex = 80;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
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
            // buttonDescargar
            // 
            buttonDescargar.BackColor = Color.FromArgb(110, 80, 50);
            buttonDescargar.FlatAppearance.BorderSize = 0;
            buttonDescargar.FlatStyle = FlatStyle.Flat;
            buttonDescargar.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonDescargar.ForeColor = Color.AntiqueWhite;
            buttonDescargar.Location = new Point(14, 699);
            buttonDescargar.Margin = new Padding(3, 2, 3, 2);
            buttonDescargar.Name = "buttonDescargar";
            buttonDescargar.Size = new Size(297, 44);
            buttonDescargar.TabIndex = 69;
            buttonDescargar.Text = "Descargar Ticket";
            buttonDescargar.UseVisualStyleBackColor = false;
            buttonDescargar.Click += buttonDescargar_Click_1;
            // 
            // progressBarDescargarTicket
            // 
            progressBarDescargarTicket.Location = new Point(317, 696);
            progressBarDescargarTicket.Name = "progressBarDescargarTicket";
            progressBarDescargarTicket.Size = new Size(568, 47);
            progressBarDescargarTicket.TabIndex = 70;
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = Color.FromArgb(110, 80, 50);
            buttonPagar.FlatAppearance.BorderSize = 0;
            buttonPagar.FlatStyle = FlatStyle.Flat;
            buttonPagar.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonPagar.ForeColor = Color.AntiqueWhite;
            buttonPagar.Location = new Point(14, 634);
            buttonPagar.Margin = new Padding(3, 2, 3, 2);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(276, 44);
            buttonPagar.TabIndex = 71;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(110, 80, 50);
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonCancelar.ForeColor = Color.AntiqueWhite;
            buttonCancelar.Location = new Point(609, 634);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(276, 44);
            buttonCancelar.TabIndex = 72;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // richTextBoxProductosSelec
            // 
            richTextBoxProductosSelec.BackColor = Color.AntiqueWhite;
            richTextBoxProductosSelec.Enabled = false;
            richTextBoxProductosSelec.Location = new Point(50, 224);
            richTextBoxProductosSelec.Name = "richTextBoxProductosSelec";
            richTextBoxProductosSelec.Size = new Size(551, 240);
            richTextBoxProductosSelec.TabIndex = 80;
            richTextBoxProductosSelec.Text = "";
            // 
            // richTextBoxCantidadSelecc
            // 
            richTextBoxCantidadSelecc.BackColor = Color.AntiqueWhite;
            richTextBoxCantidadSelecc.Enabled = false;
            richTextBoxCantidadSelecc.Location = new Point(692, 224);
            richTextBoxCantidadSelecc.Name = "richTextBoxCantidadSelecc";
            richTextBoxCantidadSelecc.Size = new Size(142, 240);
            richTextBoxCantidadSelecc.TabIndex = 79;
            richTextBoxCantidadSelecc.Text = "";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCantidad.ForeColor = Color.FromArgb(110, 80, 50);
            labelCantidad.Location = new Point(703, 189);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(108, 32);
            labelCantidad.TabIndex = 78;
            labelCantidad.Text = "Cantidad";
            // 
            // labelProductosSelec
            // 
            labelProductosSelec.AutoSize = true;
            labelProductosSelec.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProductosSelec.ForeColor = Color.FromArgb(110, 80, 50);
            labelProductosSelec.Location = new Point(50, 189);
            labelProductosSelec.Name = "labelProductosSelec";
            labelProductosSelec.Size = new Size(391, 32);
            labelProductosSelec.TabIndex = 77;
            labelProductosSelec.Text = "Usted eligió los siguientes productos";
            // 
            // labelTotalCompra
            // 
            labelTotalCompra.AutoSize = true;
            labelTotalCompra.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalCompra.ForeColor = Color.FromArgb(110, 80, 50);
            labelTotalCompra.Location = new Point(724, 484);
            labelTotalCompra.Name = "labelTotalCompra";
            labelTotalCompra.Size = new Size(87, 32);
            labelTotalCompra.TabIndex = 82;
            labelTotalCompra.Text = "TOTAL";
            // 
            // textBoxTotalCompra
            // 
            textBoxTotalCompra.BackColor = Color.Tan;
            textBoxTotalCompra.BorderStyle = BorderStyle.None;
            textBoxTotalCompra.Enabled = false;
            textBoxTotalCompra.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTotalCompra.Location = new Point(692, 519);
            textBoxTotalCompra.Name = "textBoxTotalCompra";
            textBoxTotalCompra.Size = new Size(142, 28);
            textBoxTotalCompra.TabIndex = 81;
            textBoxTotalCompra.TextAlign = HorizontalAlignment.Center;
            // 
            // FormPagoOxxo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(914, 771);
            Controls.Add(labelTotalCompra);
            Controls.Add(textBoxTotalCompra);
            Controls.Add(richTextBoxProductosSelec);
            Controls.Add(richTextBoxCantidadSelecc);
            Controls.Add(labelCantidad);
            Controls.Add(labelProductosSelec);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonPagar);
            Controls.Add(progressBarDescargarTicket);
            Controls.Add(buttonDescargar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPagoOxxo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTicket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalirUs;
        private Button btnInformacion;
        private Panel panel1;
        private Label labelEslogan;
        private Button buttonDescargar;
        private ProgressBar progressBarDescargarTicket;
        private Button buttonPagar;
        private Button buttonCancelar;
        private RichTextBox richTextBoxProductosSelec;
        private RichTextBox richTextBoxCantidadSelecc;
        private Label labelCantidad;
        private Label labelProductosSelec;
        private Label labelTotalCompra;
        private TextBox textBoxTotalCompra;
        private Button btnSalir;
    }
}