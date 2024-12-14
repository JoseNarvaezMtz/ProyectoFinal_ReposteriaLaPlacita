namespace WinFormsProyectoBase
{
    partial class FormPagoCaja
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
            buttonCancelarCompra = new Button();
            textBoxCambio = new TextBox();
            labelYear = new Label();
            buttonPagar = new Button();
            labelCantidadAPagar = new Label();
            textBoxPagoCliente = new TextBox();
            labelMontoPago = new Label();
            label1 = new Label();
            labelEleccion = new Label();
            labelPagoTarjeta = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            textBoxCantidadPagar = new TextBox();
            textBoxPagoTotal = new TextBox();
            richTextBoxCantidadSelecc = new RichTextBox();
            richTextBoxProductosSelec = new RichTextBox();
            buttonCambio = new Button();
            btnSalirMetPago = new Button();
            SuspendLayout();
            // 
            // buttonCancelarCompra
            // 
            buttonCancelarCompra.BackColor = Color.FromArgb(110, 80, 50);
            buttonCancelarCompra.FlatAppearance.BorderSize = 0;
            buttonCancelarCompra.FlatStyle = FlatStyle.Flat;
            buttonCancelarCompra.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonCancelarCompra.ForeColor = Color.AntiqueWhite;
            buttonCancelarCompra.Location = new Point(580, 575);
            buttonCancelarCompra.Margin = new Padding(3, 2, 3, 2);
            buttonCancelarCompra.Name = "buttonCancelarCompra";
            buttonCancelarCompra.Size = new Size(270, 44);
            buttonCancelarCompra.TabIndex = 67;
            buttonCancelarCompra.Text = "Cancelar compra";
            buttonCancelarCompra.UseVisualStyleBackColor = false;
            buttonCancelarCompra.Click += buttonCancelarCompra_Click;
            // 
            // textBoxCambio
            // 
            textBoxCambio.BackColor = Color.Tan;
            textBoxCambio.BorderStyle = BorderStyle.None;
            textBoxCambio.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCambio.Location = new Point(60, 515);
            textBoxCambio.Name = "textBoxCambio";
            textBoxCambio.PlaceholderText = "$0.00";
            textBoxCambio.Size = new Size(212, 28);
            textBoxCambio.TabIndex = 63;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelYear.ForeColor = Color.FromArgb(110, 80, 50);
            labelYear.Location = new Point(60, 480);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(93, 32);
            labelYear.TabIndex = 61;
            labelYear.Text = "Cambio";
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = Color.FromArgb(110, 80, 50);
            buttonPagar.FlatAppearance.BorderSize = 0;
            buttonPagar.FlatStyle = FlatStyle.Flat;
            buttonPagar.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonPagar.ForeColor = Color.AntiqueWhite;
            buttonPagar.Location = new Point(60, 575);
            buttonPagar.Margin = new Padding(3, 2, 3, 2);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(270, 44);
            buttonPagar.TabIndex = 60;
            buttonPagar.Text = "Pagar Productos";
            buttonPagar.UseVisualStyleBackColor = false;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // labelCantidadAPagar
            // 
            labelCantidadAPagar.AutoSize = true;
            labelCantidadAPagar.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCantidadAPagar.ForeColor = Color.FromArgb(110, 80, 50);
            labelCantidadAPagar.Location = new Point(60, 297);
            labelCantidadAPagar.Name = "labelCantidadAPagar";
            labelCantidadAPagar.Size = new Size(191, 32);
            labelCantidadAPagar.TabIndex = 58;
            labelCantidadAPagar.Text = "Cantidad a Pagar";
            // 
            // textBoxPagoCliente
            // 
            textBoxPagoCliente.BackColor = Color.Tan;
            textBoxPagoCliente.BorderStyle = BorderStyle.None;
            textBoxPagoCliente.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPagoCliente.Location = new Point(66, 439);
            textBoxPagoCliente.Name = "textBoxPagoCliente";
            textBoxPagoCliente.Size = new Size(354, 28);
            textBoxPagoCliente.TabIndex = 57;
            // 
            // labelMontoPago
            // 
            labelMontoPago.AutoSize = true;
            labelMontoPago.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMontoPago.ForeColor = Color.FromArgb(110, 80, 50);
            labelMontoPago.Location = new Point(60, 392);
            labelMontoPago.Name = "labelMontoPago";
            labelMontoPago.Size = new Size(396, 32);
            labelMontoPago.TabIndex = 56;
            labelMontoPago.Text = "Ingrese la cantidad con la que Pagará";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(110, 80, 50);
            label1.Location = new Point(701, 89);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 54;
            label1.Text = "Cantidad";
            // 
            // labelEleccion
            // 
            labelEleccion.AutoSize = true;
            labelEleccion.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEleccion.ForeColor = Color.FromArgb(110, 80, 50);
            labelEleccion.Location = new Point(124, 89);
            labelEleccion.Name = "labelEleccion";
            labelEleccion.Size = new Size(391, 32);
            labelEleccion.TabIndex = 53;
            labelEleccion.Text = "Usted eligió los siguientes productos";
            // 
            // labelPagoTarjeta
            // 
            labelPagoTarjeta.AutoSize = true;
            labelPagoTarjeta.Font = new Font("Script MT Bold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPagoTarjeta.ForeColor = Color.FromArgb(110, 80, 50);
            labelPagoTarjeta.Location = new Point(341, 29);
            labelPagoTarjeta.Name = "labelPagoTarjeta";
            labelPagoTarjeta.Size = new Size(225, 44);
            labelPagoTarjeta.TabIndex = 52;
            labelPagoTarjeta.Text = "Pago En Caja";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SaddleBrown;
            panel4.Location = new Point(884, 29);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 624);
            panel4.TabIndex = 50;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SaddleBrown;
            panel3.Location = new Point(12, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(887, 15);
            panel3.TabIndex = 47;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Location = new Point(12, 641);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 15);
            panel1.TabIndex = 48;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Location = new Point(12, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(15, 624);
            panel2.TabIndex = 49;
            // 
            // textBoxCantidadPagar
            // 
            textBoxCantidadPagar.BackColor = Color.Tan;
            textBoxCantidadPagar.BorderStyle = BorderStyle.None;
            textBoxCantidadPagar.Enabled = false;
            textBoxCantidadPagar.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCantidadPagar.Location = new Point(60, 341);
            textBoxCantidadPagar.Name = "textBoxCantidadPagar";
            textBoxCantidadPagar.PlaceholderText = "Dinero a pagar";
            textBoxCantidadPagar.Size = new Size(360, 28);
            textBoxCantidadPagar.TabIndex = 68;
            textBoxCantidadPagar.TextChanged += textBoxCantidadPagar_TextChanged;
            // 
            // textBoxPagoTotal
            // 
            textBoxPagoTotal.BackColor = Color.Tan;
            textBoxPagoTotal.BorderStyle = BorderStyle.None;
            textBoxPagoTotal.Enabled = false;
            textBoxPagoTotal.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPagoTotal.Location = new Point(60, 439);
            textBoxPagoTotal.Name = "textBoxPagoTotal";
            textBoxPagoTotal.Size = new Size(354, 28);
            textBoxPagoTotal.TabIndex = 69;
            textBoxPagoTotal.TextChanged += textBoxPagoTotal_TextChanged;
            // 
            // richTextBoxCantidadSelecc
            // 
            richTextBoxCantidadSelecc.BackColor = Color.AntiqueWhite;
            richTextBoxCantidadSelecc.Enabled = false;
            richTextBoxCantidadSelecc.Location = new Point(686, 124);
            richTextBoxCantidadSelecc.Name = "richTextBoxCantidadSelecc";
            richTextBoxCantidadSelecc.Size = new Size(142, 155);
            richTextBoxCantidadSelecc.TabIndex = 71;
            richTextBoxCantidadSelecc.Text = "";
            // 
            // richTextBoxProductosSelec
            // 
            richTextBoxProductosSelec.BackColor = Color.AntiqueWhite;
            richTextBoxProductosSelec.Enabled = false;
            richTextBoxProductosSelec.Location = new Point(60, 124);
            richTextBoxProductosSelec.Name = "richTextBoxProductosSelec";
            richTextBoxProductosSelec.Size = new Size(551, 155);
            richTextBoxProductosSelec.TabIndex = 72;
            richTextBoxProductosSelec.Text = "";
            richTextBoxProductosSelec.TextChanged += richTextBoxProductosSelec_TextChanged;
            // 
            // buttonCambio
            // 
            buttonCambio.BackColor = Color.FromArgb(110, 80, 50);
            buttonCambio.FlatAppearance.BorderSize = 0;
            buttonCambio.FlatStyle = FlatStyle.Flat;
            buttonCambio.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCambio.ForeColor = Color.AntiqueWhite;
            buttonCambio.Location = new Point(293, 510);
            buttonCambio.Margin = new Padding(3, 2, 3, 2);
            buttonCambio.Name = "buttonCambio";
            buttonCambio.Size = new Size(127, 36);
            buttonCambio.TabIndex = 73;
            buttonCambio.Text = "Ver Cambio";
            buttonCambio.UseVisualStyleBackColor = false;
            buttonCambio.Click += buttonCambio_Click;
            // 
            // btnSalirMetPago
            // 
            btnSalirMetPago.BackColor = Color.FromArgb(110, 80, 50);
            btnSalirMetPago.FlatAppearance.BorderSize = 0;
            btnSalirMetPago.FlatStyle = FlatStyle.Flat;
            btnSalirMetPago.Font = new Font("Sans Serif Collection", 10F, FontStyle.Bold);
            btnSalirMetPago.ForeColor = Color.AntiqueWhite;
            btnSalirMetPago.Location = new Point(841, 36);
            btnSalirMetPago.Margin = new Padding(3, 2, 3, 2);
            btnSalirMetPago.Name = "btnSalirMetPago";
            btnSalirMetPago.Size = new Size(37, 37);
            btnSalirMetPago.TabIndex = 74;
            btnSalirMetPago.Text = "X";
            btnSalirMetPago.UseVisualStyleBackColor = false;
            btnSalirMetPago.Click += btnSalirMetPago_Click;
            // 
            // FormPagoCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(914, 666);
            ControlBox = false;
            Controls.Add(btnSalirMetPago);
            Controls.Add(buttonCambio);
            Controls.Add(richTextBoxProductosSelec);
            Controls.Add(richTextBoxCantidadSelecc);
            Controls.Add(textBoxPagoTotal);
            Controls.Add(textBoxCantidadPagar);
            Controls.Add(buttonCancelarCompra);
            Controls.Add(textBoxCambio);
            Controls.Add(labelYear);
            Controls.Add(buttonPagar);
            Controls.Add(labelCantidadAPagar);
            Controls.Add(textBoxPagoCliente);
            Controls.Add(labelMontoPago);
            Controls.Add(label1);
            Controls.Add(labelEleccion);
            Controls.Add(labelPagoTarjeta);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPagoCaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago en Caja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelarCompra;
        private TextBox textBoxMes;
        private TextBox textBoxCambio;
        private Label labelMes;
        private Label labelYear;
        private Button buttonPagar;
        private Label labelCantidadAPagar;
        private TextBox textBoxPagoCliente;
        private Label labelMontoPago;
        private Label label1;
        private Label labelEleccion;
        private Label labelPagoTarjeta;
        private Panel panel4;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxCantidadPagar;
        private TextBox textBoxPagoTotal;
        private RichTextBox richTextBoxCantidadSelecc;
        private RichTextBox richTextBoxProductosSelec;
        private Button buttonCambio;
        private Button btnSalirMetPago;
    }
}