namespace WinFormsProyectoBase
{
    partial class FormPagoTarjeta
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
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            labelPagoTarjeta = new Label();
            labelNumTarjeta = new Label();
            textBoxNumTarjeta = new TextBox();
            textBoxNombreTarjeta = new TextBox();
            labelNombreEnTarjeta = new Label();
            buttonPagar = new Button();
            labelYear = new Label();
            labelMes = new Label();
            textBoxYear = new TextBox();
            textBoxMes = new TextBox();
            label2 = new Label();
            textBoxCodigo = new TextBox();
            buttonCancelarCompra = new Button();
            richTextBoxProductosSelec = new RichTextBox();
            richTextBoxCantidadSelecc = new RichTextBox();
            labelCantidad = new Label();
            labelProductosSelec = new Label();
            textBoxTotalCompra = new TextBox();
            labelTotalCompra = new Label();
            btnSalirMetPago = new Button();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.SaddleBrown;
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(887, 15);
            panel3.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Location = new Point(12, 639);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 15);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Location = new Point(12, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(15, 624);
            panel2.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SaddleBrown;
            panel4.Location = new Point(884, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 624);
            panel4.TabIndex = 27;
            // 
            // labelPagoTarjeta
            // 
            labelPagoTarjeta.AutoSize = true;
            labelPagoTarjeta.Font = new Font("Script MT Bold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPagoTarjeta.ForeColor = Color.FromArgb(110, 80, 50);
            labelPagoTarjeta.Location = new Point(317, 30);
            labelPagoTarjeta.Name = "labelPagoTarjeta";
            labelPagoTarjeta.Size = new Size(278, 44);
            labelPagoTarjeta.TabIndex = 29;
            labelPagoTarjeta.Text = "Pago con Tarjeta";
            // 
            // labelNumTarjeta
            // 
            labelNumTarjeta.AutoSize = true;
            labelNumTarjeta.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumTarjeta.ForeColor = Color.FromArgb(110, 80, 50);
            labelNumTarjeta.Location = new Point(60, 413);
            labelNumTarjeta.Name = "labelNumTarjeta";
            labelNumTarjeta.Size = new Size(353, 32);
            labelNumTarjeta.TabIndex = 35;
            labelNumTarjeta.Text = "Introduzca el número de la tarjeta";
            // 
            // textBoxNumTarjeta
            // 
            textBoxNumTarjeta.BackColor = Color.Tan;
            textBoxNumTarjeta.BorderStyle = BorderStyle.None;
            textBoxNumTarjeta.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNumTarjeta.Location = new Point(66, 448);
            textBoxNumTarjeta.Name = "textBoxNumTarjeta";
            textBoxNumTarjeta.Size = new Size(364, 28);
            textBoxNumTarjeta.TabIndex = 36;
            // 
            // textBoxNombreTarjeta
            // 
            textBoxNombreTarjeta.BackColor = Color.Tan;
            textBoxNombreTarjeta.BorderStyle = BorderStyle.None;
            textBoxNombreTarjeta.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombreTarjeta.Location = new Point(66, 354);
            textBoxNombreTarjeta.Name = "textBoxNombreTarjeta";
            textBoxNombreTarjeta.Size = new Size(364, 28);
            textBoxNombreTarjeta.TabIndex = 38;
            // 
            // labelNombreEnTarjeta
            // 
            labelNombreEnTarjeta.AutoSize = true;
            labelNombreEnTarjeta.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreEnTarjeta.ForeColor = Color.FromArgb(110, 80, 50);
            labelNombreEnTarjeta.Location = new Point(60, 319);
            labelNombreEnTarjeta.Name = "labelNombreEnTarjeta";
            labelNombreEnTarjeta.Size = new Size(353, 32);
            labelNombreEnTarjeta.TabIndex = 37;
            labelNombreEnTarjeta.Text = "Introduzca el nombre en la tarjeta";
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = Color.FromArgb(110, 80, 50);
            buttonPagar.FlatAppearance.BorderSize = 0;
            buttonPagar.FlatStyle = FlatStyle.Flat;
            buttonPagar.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonPagar.ForeColor = Color.AntiqueWhite;
            buttonPagar.Location = new Point(66, 573);
            buttonPagar.Margin = new Padding(3, 2, 3, 2);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(270, 44);
            buttonPagar.TabIndex = 39;
            buttonPagar.Text = "Pagar Productos";
            buttonPagar.UseVisualStyleBackColor = false;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelYear.ForeColor = Color.FromArgb(110, 80, 50);
            labelYear.Location = new Point(59, 489);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(218, 32);
            labelYear.TabIndex = 40;
            labelYear.Text = "Año de Vencimiento";
            // 
            // labelMes
            // 
            labelMes.AutoSize = true;
            labelMes.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMes.ForeColor = Color.FromArgb(110, 80, 50);
            labelMes.Location = new Point(298, 489);
            labelMes.Name = "labelMes";
            labelMes.Size = new Size(221, 32);
            labelMes.TabIndex = 41;
            labelMes.Text = "Mes de Vencimiento";
            // 
            // textBoxYear
            // 
            textBoxYear.BackColor = Color.Tan;
            textBoxYear.BorderStyle = BorderStyle.None;
            textBoxYear.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxYear.Location = new Point(65, 524);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(212, 28);
            textBoxYear.TabIndex = 42;
            // 
            // textBoxMes
            // 
            textBoxMes.BackColor = Color.Tan;
            textBoxMes.BorderStyle = BorderStyle.None;
            textBoxMes.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMes.Location = new Point(305, 524);
            textBoxMes.Name = "textBoxMes";
            textBoxMes.Size = new Size(212, 28);
            textBoxMes.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(110, 80, 50);
            label2.Location = new Point(540, 489);
            label2.Name = "label2";
            label2.Size = new Size(226, 32);
            label2.TabIndex = 44;
            label2.Text = "Código de seguridad";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.BackColor = Color.Tan;
            textBoxCodigo.BorderStyle = BorderStyle.None;
            textBoxCodigo.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCodigo.Location = new Point(546, 524);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(212, 28);
            textBoxCodigo.TabIndex = 45;
            // 
            // buttonCancelarCompra
            // 
            buttonCancelarCompra.BackColor = Color.FromArgb(110, 80, 50);
            buttonCancelarCompra.FlatAppearance.BorderSize = 0;
            buttonCancelarCompra.FlatStyle = FlatStyle.Flat;
            buttonCancelarCompra.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonCancelarCompra.ForeColor = Color.AntiqueWhite;
            buttonCancelarCompra.Location = new Point(580, 573);
            buttonCancelarCompra.Margin = new Padding(3, 2, 3, 2);
            buttonCancelarCompra.Name = "buttonCancelarCompra";
            buttonCancelarCompra.Size = new Size(270, 44);
            buttonCancelarCompra.TabIndex = 46;
            buttonCancelarCompra.Text = "Cancelar compra";
            buttonCancelarCompra.UseVisualStyleBackColor = false;
            buttonCancelarCompra.Click += buttonCancelarCompra_Click;
            // 
            // richTextBoxProductosSelec
            // 
            richTextBoxProductosSelec.BackColor = Color.AntiqueWhite;
            richTextBoxProductosSelec.Enabled = false;
            richTextBoxProductosSelec.Location = new Point(65, 132);
            richTextBoxProductosSelec.Name = "richTextBoxProductosSelec";
            richTextBoxProductosSelec.Size = new Size(551, 155);
            richTextBoxProductosSelec.TabIndex = 76;
            richTextBoxProductosSelec.Text = "";
            // 
            // richTextBoxCantidadSelecc
            // 
            richTextBoxCantidadSelecc.BackColor = Color.AntiqueWhite;
            richTextBoxCantidadSelecc.Enabled = false;
            richTextBoxCantidadSelecc.Location = new Point(697, 130);
            richTextBoxCantidadSelecc.Name = "richTextBoxCantidadSelecc";
            richTextBoxCantidadSelecc.Size = new Size(142, 155);
            richTextBoxCantidadSelecc.TabIndex = 75;
            richTextBoxCantidadSelecc.Text = "";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCantidad.ForeColor = Color.FromArgb(110, 80, 50);
            labelCantidad.Location = new Point(712, 95);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(108, 32);
            labelCantidad.TabIndex = 74;
            labelCantidad.Text = "Cantidad";
            // 
            // labelProductosSelec
            // 
            labelProductosSelec.AutoSize = true;
            labelProductosSelec.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProductosSelec.ForeColor = Color.FromArgb(110, 80, 50);
            labelProductosSelec.Location = new Point(59, 95);
            labelProductosSelec.Name = "labelProductosSelec";
            labelProductosSelec.Size = new Size(391, 32);
            labelProductosSelec.TabIndex = 73;
            labelProductosSelec.Text = "Usted eligió los siguientes productos";
            // 
            // textBoxTotalCompra
            // 
            textBoxTotalCompra.BackColor = Color.Tan;
            textBoxTotalCompra.BorderStyle = BorderStyle.None;
            textBoxTotalCompra.Enabled = false;
            textBoxTotalCompra.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTotalCompra.Location = new Point(697, 319);
            textBoxTotalCompra.Name = "textBoxTotalCompra";
            textBoxTotalCompra.Size = new Size(142, 28);
            textBoxTotalCompra.TabIndex = 77;
            textBoxTotalCompra.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTotalCompra
            // 
            labelTotalCompra.AutoSize = true;
            labelTotalCompra.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalCompra.ForeColor = Color.FromArgb(110, 80, 50);
            labelTotalCompra.Location = new Point(712, 288);
            labelTotalCompra.Name = "labelTotalCompra";
            labelTotalCompra.Size = new Size(108, 32);
            labelTotalCompra.TabIndex = 78;
            labelTotalCompra.Text = "Cantidad";
            // 
            // btnSalirMetPago
            // 
            btnSalirMetPago.BackColor = Color.FromArgb(110, 80, 50);
            btnSalirMetPago.FlatAppearance.BorderSize = 0;
            btnSalirMetPago.FlatStyle = FlatStyle.Flat;
            btnSalirMetPago.Font = new Font("Sans Serif Collection", 10F, FontStyle.Bold);
            btnSalirMetPago.ForeColor = Color.AntiqueWhite;
            btnSalirMetPago.Location = new Point(841, 32);
            btnSalirMetPago.Margin = new Padding(3, 2, 3, 2);
            btnSalirMetPago.Name = "btnSalirMetPago";
            btnSalirMetPago.Size = new Size(37, 37);
            btnSalirMetPago.TabIndex = 79;
            btnSalirMetPago.Text = "X";
            btnSalirMetPago.UseVisualStyleBackColor = false;
            btnSalirMetPago.Click += btnSalirMetPago_Click;
            // 
            // FormPagoTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(914, 666);
            Controls.Add(btnSalirMetPago);
            Controls.Add(labelTotalCompra);
            Controls.Add(textBoxTotalCompra);
            Controls.Add(richTextBoxProductosSelec);
            Controls.Add(richTextBoxCantidadSelecc);
            Controls.Add(labelCantidad);
            Controls.Add(labelProductosSelec);
            Controls.Add(buttonCancelarCompra);
            Controls.Add(textBoxCodigo);
            Controls.Add(label2);
            Controls.Add(textBoxMes);
            Controls.Add(textBoxYear);
            Controls.Add(labelMes);
            Controls.Add(labelYear);
            Controls.Add(buttonPagar);
            Controls.Add(textBoxNombreTarjeta);
            Controls.Add(labelNombreEnTarjeta);
            Controls.Add(textBoxNumTarjeta);
            Controls.Add(labelNumTarjeta);
            Controls.Add(labelPagoTarjeta);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPagoTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPagoTarjeta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label labelPagoTarjeta;
        private Label labelNumTarjeta;
        private TextBox textBoxNumTarjeta;
        private TextBox textBoxNombreTarjeta;
        private Label labelNombreEnTarjeta;
        private Button buttonPagar;
        private Label labelYear;
        private Label labelMes;
        private TextBox textBoxYear;
        private TextBox textBoxMes;
        private Label label2;
        private TextBox textBoxCodigo;
        private Button buttonCancelarCompra;
        private RichTextBox richTextBoxProductosSelec;
        private RichTextBox richTextBoxCantidadSelecc;
        private Label labelCantidad;
        private Label labelProductosSelec;
        private TextBox textBoxTotalCompra;
        private Label labelTotalCompra;
        private Button btnSalirMetPago;
    }
}