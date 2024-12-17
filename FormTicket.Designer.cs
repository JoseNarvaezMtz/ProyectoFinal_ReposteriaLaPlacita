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
            components = new System.ComponentModel.Container();
            progressBarDescargarTicket = new ProgressBar();
            buttonDescargar = new Button();
            panel1 = new Panel();
            btnSalirUs = new Button();
            labelSloganTienda = new Label();
            btnInformacion = new Button();
            richTextBoxProductos = new RichTextBox();
            richTextBoxCantidad = new RichTextBox();
            richTextBoxPrecioImp = new RichTextBox();
            richTextBoxPrecio = new RichTextBox();
            labelCantidad = new Label();
            labelPrecio = new Label();
            labelPrecioImp = new Label();
            labelProducto = new Label();
            labelTotalCompra = new Label();
            textBoxTotalCompra = new TextBox();
            timerTicket = new System.Windows.Forms.Timer(components);
            labelFechaHoraTicket = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBarDescargarTicket
            // 
            progressBarDescargarTicket.Location = new Point(7, 518);
            progressBarDescargarTicket.Name = "progressBarDescargarTicket";
            progressBarDescargarTicket.Size = new Size(760, 47);
            progressBarDescargarTicket.TabIndex = 74;
            // 
            // buttonDescargar
            // 
            buttonDescargar.BackColor = Color.FromArgb(110, 80, 50);
            buttonDescargar.FlatAppearance.BorderSize = 0;
            buttonDescargar.FlatStyle = FlatStyle.Flat;
            buttonDescargar.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonDescargar.ForeColor = Color.AntiqueWhite;
            buttonDescargar.Location = new Point(12, 469);
            buttonDescargar.Margin = new Padding(3, 2, 3, 2);
            buttonDescargar.Name = "buttonDescargar";
            buttonDescargar.Size = new Size(297, 44);
            buttonDescargar.TabIndex = 73;
            buttonDescargar.Text = "Descargar Ticket";
            buttonDescargar.UseVisualStyleBackColor = false;
            buttonDescargar.Click += buttonDescargar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(110, 80, 50);
            panel1.Controls.Add(btnSalirUs);
            panel1.Controls.Add(labelSloganTienda);
            panel1.Controls.Add(btnInformacion);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 83);
            panel1.TabIndex = 76;
            // 
            // btnSalirUs
            // 
            btnSalirUs.FlatStyle = FlatStyle.Flat;
            btnSalirUs.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalirUs.ForeColor = Color.AntiqueWhite;
            btnSalirUs.Location = new Point(745, 0);
            btnSalirUs.Name = "btnSalirUs";
            btnSalirUs.Size = new Size(34, 34);
            btnSalirUs.TabIndex = 77;
            btnSalirUs.Text = "X";
            btnSalirUs.TextAlign = ContentAlignment.MiddleRight;
            btnSalirUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalirUs.UseVisualStyleBackColor = true;
            btnSalirUs.Click += btnSalirUs_Click;
            // 
            // labelSloganTienda
            // 
            labelSloganTienda.AutoSize = true;
            labelSloganTienda.Font = new Font("Tempus Sans ITC", 16F, FontStyle.Bold);
            labelSloganTienda.ForeColor = Color.AntiqueWhite;
            labelSloganTienda.Location = new Point(267, 28);
            labelSloganTienda.Name = "labelSloganTienda";
            labelSloganTienda.Size = new Size(492, 31);
            labelSloganTienda.TabIndex = 77;
            labelSloganTienda.Text = "\"Delicia tras delicia para endulzar tu pancita\"";
            // 
            // btnInformacion
            // 
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInformacion.ForeColor = Color.AntiqueWhite;
            btnInformacion.Image = Properties.Resources.Logo;
            btnInformacion.Location = new Point(12, 12);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(251, 52);
            btnInformacion.TabIndex = 3;
            btnInformacion.Text = "C a f é   l a   p l a c i t a";
            btnInformacion.TextAlign = ContentAlignment.MiddleRight;
            btnInformacion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInformacion.UseVisualStyleBackColor = true;
            // 
            // richTextBoxProductos
            // 
            richTextBoxProductos.BackColor = Color.AntiqueWhite;
            richTextBoxProductos.Enabled = false;
            richTextBoxProductos.Location = new Point(22, 137);
            richTextBoxProductos.Name = "richTextBoxProductos";
            richTextBoxProductos.Size = new Size(165, 198);
            richTextBoxProductos.TabIndex = 78;
            richTextBoxProductos.Text = "";
            // 
            // richTextBoxCantidad
            // 
            richTextBoxCantidad.BackColor = Color.AntiqueWhite;
            richTextBoxCantidad.Enabled = false;
            richTextBoxCantidad.Location = new Point(205, 137);
            richTextBoxCantidad.Name = "richTextBoxCantidad";
            richTextBoxCantidad.Size = new Size(165, 198);
            richTextBoxCantidad.TabIndex = 77;
            richTextBoxCantidad.Text = "";
            // 
            // richTextBoxPrecioImp
            // 
            richTextBoxPrecioImp.BackColor = Color.AntiqueWhite;
            richTextBoxPrecioImp.Enabled = false;
            richTextBoxPrecioImp.Location = new Point(594, 137);
            richTextBoxPrecioImp.Name = "richTextBoxPrecioImp";
            richTextBoxPrecioImp.Size = new Size(169, 198);
            richTextBoxPrecioImp.TabIndex = 80;
            richTextBoxPrecioImp.Text = "";
            // 
            // richTextBoxPrecio
            // 
            richTextBoxPrecio.BackColor = Color.AntiqueWhite;
            richTextBoxPrecio.Enabled = false;
            richTextBoxPrecio.Location = new Point(388, 137);
            richTextBoxPrecio.Name = "richTextBoxPrecio";
            richTextBoxPrecio.Size = new Size(186, 198);
            richTextBoxPrecio.TabIndex = 79;
            richTextBoxPrecio.Text = "";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCantidad.ForeColor = Color.FromArgb(110, 80, 50);
            labelCantidad.Location = new Point(205, 102);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(108, 32);
            labelCantidad.TabIndex = 81;
            labelCantidad.Text = "Cantidad";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio.ForeColor = Color.FromArgb(110, 80, 50);
            labelPrecio.Location = new Point(388, 102);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(186, 32);
            labelPrecio.TabIndex = 82;
            labelPrecio.Text = "Precio Individual";
            // 
            // labelPrecioImp
            // 
            labelPrecioImp.AutoSize = true;
            labelPrecioImp.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecioImp.ForeColor = Color.FromArgb(110, 80, 50);
            labelPrecioImp.Location = new Point(596, 102);
            labelPrecioImp.Name = "labelPrecioImp";
            labelPrecioImp.Size = new Size(165, 32);
            labelPrecioImp.TabIndex = 83;
            labelPrecioImp.Text = "Total Producto";
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProducto.ForeColor = Color.FromArgb(110, 80, 50);
            labelProducto.Location = new Point(22, 102);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(108, 32);
            labelProducto.TabIndex = 84;
            labelProducto.Text = "Producto";
            // 
            // labelTotalCompra
            // 
            labelTotalCompra.AutoSize = true;
            labelTotalCompra.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalCompra.ForeColor = Color.FromArgb(110, 80, 50);
            labelTotalCompra.Location = new Point(594, 338);
            labelTotalCompra.Name = "labelTotalCompra";
            labelTotalCompra.Size = new Size(150, 32);
            labelTotalCompra.TabIndex = 86;
            labelTotalCompra.Text = "Total a Pagar";
            // 
            // textBoxTotalCompra
            // 
            textBoxTotalCompra.BackColor = Color.Tan;
            textBoxTotalCompra.BorderStyle = BorderStyle.None;
            textBoxTotalCompra.Enabled = false;
            textBoxTotalCompra.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTotalCompra.Location = new Point(571, 373);
            textBoxTotalCompra.Name = "textBoxTotalCompra";
            textBoxTotalCompra.Size = new Size(192, 28);
            textBoxTotalCompra.TabIndex = 85;
            textBoxTotalCompra.TextAlign = HorizontalAlignment.Center;
            // 
            // timerTicket
            // 
            timerTicket.Enabled = true;
            timerTicket.Interval = 1000;
            timerTicket.Tick += timerTicket_Tick;
            // 
            // labelFechaHoraTicket
            // 
            labelFechaHoraTicket.AutoSize = true;
            labelFechaHoraTicket.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFechaHoraTicket.ForeColor = Color.FromArgb(110, 80, 50);
            labelFechaHoraTicket.Location = new Point(531, 416);
            labelFechaHoraTicket.Name = "labelFechaHoraTicket";
            labelFechaHoraTicket.Size = new Size(0, 29);
            labelFechaHoraTicket.TabIndex = 87;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(779, 577);
            Controls.Add(labelFechaHoraTicket);
            Controls.Add(labelTotalCompra);
            Controls.Add(textBoxTotalCompra);
            Controls.Add(labelProducto);
            Controls.Add(labelPrecioImp);
            Controls.Add(labelPrecio);
            Controls.Add(labelCantidad);
            Controls.Add(richTextBoxPrecioImp);
            Controls.Add(richTextBoxPrecio);
            Controls.Add(richTextBoxProductos);
            Controls.Add(richTextBoxCantidad);
            Controls.Add(panel1);
            Controls.Add(progressBarDescargarTicket);
            Controls.Add(buttonDescargar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTicket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar progressBarDescargarTicket;
        private Button buttonDescargar;
        private Panel panel1;
        private Button btnInformacion;
        private Label labelSloganTienda;
        private Button btnSalirUs;
        private RichTextBox richTextBoxProductos;
        private RichTextBox richTextBoxCantidad;
        private RichTextBox richTextBoxPrecioImp;
        private RichTextBox richTextBoxPrecio;
        private Label labelCantidad;
        private Label labelPrecio;
        private Label labelPrecioImp;
        private Label labelProducto;
        private Label labelTotalCompra;
        private TextBox textBoxTotalCompra;
        private System.Windows.Forms.Timer timerTicket;
        private Label labelFechaHoraTicket;
    }
}