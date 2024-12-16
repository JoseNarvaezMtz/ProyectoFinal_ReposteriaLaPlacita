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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
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
            pictureBoxCodigoBarras = new PictureBox();
            pictureBox2 = new PictureBox();
            richTextBoxPrecio = new RichTextBox();
            labelPrecio = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCodigoBarras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(labelEslogan);
            panel1.Controls.Add(btnSalirUs);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 95);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OxxoLogo;
            pictureBox1.Location = new Point(14, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Sans Serif Collection", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(864, 0);
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
            labelEslogan.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelEslogan.ForeColor = Color.Black;
            labelEslogan.Location = new Point(305, 9);
            labelEslogan.Name = "labelEslogan";
            labelEslogan.Size = new Size(508, 62);
            labelEslogan.TabIndex = 4;
            labelEslogan.Text = "\"A la vuelta de tu vida\"";
            // 
            // buttonDescargar
            // 
            buttonDescargar.BackColor = Color.Gray;
            buttonDescargar.FlatAppearance.BorderSize = 0;
            buttonDescargar.FlatStyle = FlatStyle.Flat;
            buttonDescargar.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonDescargar.ForeColor = Color.Black;
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
            buttonPagar.BackColor = Color.Silver;
            buttonPagar.FlatAppearance.BorderSize = 0;
            buttonPagar.FlatStyle = FlatStyle.Flat;
            buttonPagar.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonPagar.ForeColor = Color.Black;
            buttonPagar.Location = new Point(14, 634);
            buttonPagar.Margin = new Padding(3, 2, 3, 2);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(297, 44);
            buttonPagar.TabIndex = 71;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = false;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.Silver;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonCancelar.ForeColor = Color.Black;
            buttonCancelar.Location = new Point(588, 634);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(297, 44);
            buttonCancelar.TabIndex = 72;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // richTextBoxProductosSelec
            // 
            richTextBoxProductosSelec.BackColor = Color.FromArgb(224, 224, 224);
            richTextBoxProductosSelec.Enabled = false;
            richTextBoxProductosSelec.Location = new Point(44, 167);
            richTextBoxProductosSelec.Name = "richTextBoxProductosSelec";
            richTextBoxProductosSelec.Size = new Size(396, 240);
            richTextBoxProductosSelec.TabIndex = 80;
            richTextBoxProductosSelec.Text = "";
            // 
            // richTextBoxCantidadSelecc
            // 
            richTextBoxCantidadSelecc.BackColor = Color.FromArgb(224, 224, 224);
            richTextBoxCantidadSelecc.Enabled = false;
            richTextBoxCantidadSelecc.Location = new Point(472, 167);
            richTextBoxCantidadSelecc.Name = "richTextBoxCantidadSelecc";
            richTextBoxCantidadSelecc.Size = new Size(151, 240);
            richTextBoxCantidadSelecc.TabIndex = 79;
            richTextBoxCantidadSelecc.Text = "";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCantidad.ForeColor = Color.Black;
            labelCantidad.Location = new Point(472, 107);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(151, 47);
            labelCantidad.TabIndex = 78;
            labelCantidad.Text = "Cantidad";
            // 
            // labelProductosSelec
            // 
            labelProductosSelec.AutoSize = true;
            labelProductosSelec.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProductosSelec.ForeColor = Color.Black;
            labelProductosSelec.Location = new Point(44, 107);
            labelProductosSelec.Name = "labelProductosSelec";
            labelProductosSelec.Size = new Size(396, 47);
            labelProductosSelec.TabIndex = 77;
            labelProductosSelec.Text = "Productos Seleccionados:\r\n";
            // 
            // labelTotalCompra
            // 
            labelTotalCompra.AutoSize = true;
            labelTotalCompra.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalCompra.ForeColor = Color.Black;
            labelTotalCompra.Location = new Point(690, 412);
            labelTotalCompra.Name = "labelTotalCompra";
            labelTotalCompra.Size = new Size(110, 39);
            labelTotalCompra.TabIndex = 82;
            labelTotalCompra.Text = "TOTAL";
            // 
            // textBoxTotalCompra
            // 
            textBoxTotalCompra.BackColor = Color.Silver;
            textBoxTotalCompra.BorderStyle = BorderStyle.None;
            textBoxTotalCompra.Enabled = false;
            textBoxTotalCompra.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTotalCompra.Location = new Point(662, 454);
            textBoxTotalCompra.Name = "textBoxTotalCompra";
            textBoxTotalCompra.Size = new Size(151, 28);
            textBoxTotalCompra.TabIndex = 81;
            textBoxTotalCompra.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBoxCodigoBarras
            // 
            pictureBoxCodigoBarras.Image = Properties.Resources.CodigoBarras;
            pictureBoxCodigoBarras.Location = new Point(44, 444);
            pictureBoxCodigoBarras.Name = "pictureBoxCodigoBarras";
            pictureBoxCodigoBarras.Size = new Size(237, 156);
            pictureBoxCodigoBarras.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCodigoBarras.TabIndex = 83;
            pictureBoxCodigoBarras.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.QR;
            pictureBox2.Location = new Point(317, 444);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 84;
            pictureBox2.TabStop = false;
            // 
            // richTextBoxPrecio
            // 
            richTextBoxPrecio.BackColor = Color.FromArgb(224, 224, 224);
            richTextBoxPrecio.Enabled = false;
            richTextBoxPrecio.Location = new Point(662, 169);
            richTextBoxPrecio.Name = "richTextBoxPrecio";
            richTextBoxPrecio.Size = new Size(151, 240);
            richTextBoxPrecio.TabIndex = 85;
            richTextBoxPrecio.Text = "";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio.ForeColor = Color.Black;
            labelPrecio.Location = new Point(686, 107);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(114, 47);
            labelPrecio.TabIndex = 86;
            labelPrecio.Text = "Precio";
            // 
            // FormPagoOxxo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(914, 771);
            Controls.Add(labelPrecio);
            Controls.Add(richTextBoxPrecio);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBoxCodigoBarras);
            Controls.Add(labelTotalCompra);
            Controls.Add(textBoxTotalCompra);
            Controls.Add(richTextBoxProductosSelec);
            Controls.Add(richTextBoxCantidadSelecc);
            Controls.Add(labelCantidad);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonPagar);
            Controls.Add(progressBarDescargarTicket);
            Controls.Add(buttonDescargar);
            Controls.Add(panel1);
            Controls.Add(labelProductosSelec);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPagoOxxo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTicket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCodigoBarras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalirUs;
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
        private PictureBox pictureBoxCodigoBarras;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RichTextBox richTextBoxPrecio;
        private Label labelPrecio;
    }
}