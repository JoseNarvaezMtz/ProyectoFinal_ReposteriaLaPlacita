namespace WinFormsProyectoBase
{
    partial class FormMetodosPago
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
            labelSeleccionPago = new Label();
            buttonPagoCaja = new Button();
            buttonPagoTarjeta = new Button();
            buttonPagoOxxo = new Button();
            picturePagoCaja = new PictureBox();
            pictureTarjeta = new PictureBox();
            pictureOxxo = new PictureBox();
            labelSeleccionCant = new Label();
            labelNumPorComprar = new Label();
            btnAumCompra = new Button();
            btnDismCompra = new Button();
            btnSalirMetPago = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            buttonOtroProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)picturePagoCaja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTarjeta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOxxo).BeginInit();
            SuspendLayout();
            // 
            // labelSeleccionPago
            // 
            labelSeleccionPago.AutoSize = true;
            labelSeleccionPago.Font = new Font("Script MT Bold", 25F, FontStyle.Bold);
            labelSeleccionPago.ForeColor = Color.FromArgb(110, 80, 50);
            labelSeleccionPago.Location = new Point(148, 55);
            labelSeleccionPago.Name = "labelSeleccionPago";
            labelSeleccionPago.Size = new Size(570, 41);
            labelSeleccionPago.TabIndex = 9;
            labelSeleccionPago.Text = "Seleccione el Método de Pago a Realizar";
            // 
            // buttonPagoCaja
            // 
            buttonPagoCaja.BackColor = Color.FromArgb(110, 80, 50);
            buttonPagoCaja.FlatAppearance.BorderSize = 0;
            buttonPagoCaja.FlatStyle = FlatStyle.Flat;
            buttonPagoCaja.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonPagoCaja.ForeColor = Color.AntiqueWhite;
            buttonPagoCaja.Location = new Point(409, 149);
            buttonPagoCaja.Margin = new Padding(3, 2, 3, 2);
            buttonPagoCaja.Name = "buttonPagoCaja";
            buttonPagoCaja.Size = new Size(309, 44);
            buttonPagoCaja.TabIndex = 10;
            buttonPagoCaja.Text = "Pago en Caja";
            buttonPagoCaja.UseVisualStyleBackColor = false;
            buttonPagoCaja.Click += buttonPagoCaja_Click;
            // 
            // buttonPagoTarjeta
            // 
            buttonPagoTarjeta.BackColor = Color.FromArgb(110, 80, 50);
            buttonPagoTarjeta.FlatAppearance.BorderSize = 0;
            buttonPagoTarjeta.FlatStyle = FlatStyle.Flat;
            buttonPagoTarjeta.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonPagoTarjeta.ForeColor = Color.AntiqueWhite;
            buttonPagoTarjeta.Location = new Point(409, 223);
            buttonPagoTarjeta.Margin = new Padding(3, 2, 3, 2);
            buttonPagoTarjeta.Name = "buttonPagoTarjeta";
            buttonPagoTarjeta.Size = new Size(309, 44);
            buttonPagoTarjeta.TabIndex = 11;
            buttonPagoTarjeta.Text = "Pago con Tarjeta";
            buttonPagoTarjeta.UseVisualStyleBackColor = false;
            buttonPagoTarjeta.Click += buttonPagoTarjeta_Click;
            // 
            // buttonPagoOxxo
            // 
            buttonPagoOxxo.BackColor = Color.FromArgb(110, 80, 50);
            buttonPagoOxxo.FlatAppearance.BorderSize = 0;
            buttonPagoOxxo.FlatStyle = FlatStyle.Flat;
            buttonPagoOxxo.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonPagoOxxo.ForeColor = Color.AntiqueWhite;
            buttonPagoOxxo.Location = new Point(409, 297);
            buttonPagoOxxo.Margin = new Padding(3, 2, 3, 2);
            buttonPagoOxxo.Name = "buttonPagoOxxo";
            buttonPagoOxxo.Size = new Size(309, 44);
            buttonPagoOxxo.TabIndex = 12;
            buttonPagoOxxo.Text = "Pago en Oxxo";
            buttonPagoOxxo.UseVisualStyleBackColor = false;
            buttonPagoOxxo.Click += buttonPagoOxxo_Click;
            // 
            // picturePagoCaja
            // 
            picturePagoCaja.Image = Properties.Resources.PagoCaja;
            picturePagoCaja.Location = new Point(763, 149);
            picturePagoCaja.Margin = new Padding(3, 2, 3, 2);
            picturePagoCaja.Name = "picturePagoCaja";
            picturePagoCaja.Size = new Size(51, 46);
            picturePagoCaja.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePagoCaja.TabIndex = 13;
            picturePagoCaja.TabStop = false;
            // 
            // pictureTarjeta
            // 
            pictureTarjeta.Image = Properties.Resources.PagoTarjeta;
            pictureTarjeta.Location = new Point(742, 223);
            pictureTarjeta.Margin = new Padding(3, 2, 3, 2);
            pictureTarjeta.Name = "pictureTarjeta";
            pictureTarjeta.Size = new Size(100, 49);
            pictureTarjeta.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTarjeta.TabIndex = 14;
            pictureTarjeta.TabStop = false;
            // 
            // pictureOxxo
            // 
            pictureOxxo.Image = Properties.Resources.PagoOxxo;
            pictureOxxo.Location = new Point(752, 297);
            pictureOxxo.Margin = new Padding(3, 2, 3, 2);
            pictureOxxo.Name = "pictureOxxo";
            pictureOxxo.Size = new Size(78, 44);
            pictureOxxo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureOxxo.TabIndex = 15;
            pictureOxxo.TabStop = false;
            // 
            // labelSeleccionCant
            // 
            labelSeleccionCant.AutoSize = true;
            labelSeleccionCant.Font = new Font("Script MT Bold", 20F, FontStyle.Bold);
            labelSeleccionCant.ForeColor = Color.FromArgb(110, 80, 50);
            labelSeleccionCant.Location = new Point(62, 141);
            labelSeleccionCant.Name = "labelSeleccionCant";
            labelSeleccionCant.Size = new Size(289, 33);
            labelSeleccionCant.TabIndex = 16;
            labelSeleccionCant.Text = "¿Cuántos desea comprar?";
            // 
            // labelNumPorComprar
            // 
            labelNumPorComprar.AutoSize = true;
            labelNumPorComprar.Font = new Font("Script MT Bold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumPorComprar.ForeColor = Color.FromArgb(110, 80, 50);
            labelNumPorComprar.Location = new Point(183, 214);
            labelNumPorComprar.Name = "labelNumPorComprar";
            labelNumPorComprar.Size = new Size(41, 48);
            labelNumPorComprar.TabIndex = 17;
            labelNumPorComprar.Text = "0";
            // 
            // btnAumCompra
            // 
            btnAumCompra.Font = new Font("Sans Serif Collection", 15F, FontStyle.Bold);
            btnAumCompra.ForeColor = Color.Black;
            btnAumCompra.Location = new Point(252, 211);
            btnAumCompra.Name = "btnAumCompra";
            btnAumCompra.Size = new Size(49, 56);
            btnAumCompra.TabIndex = 18;
            btnAumCompra.Text = ">";
            btnAumCompra.UseVisualStyleBackColor = true;
            btnAumCompra.Click += btnAumCompra_Click;
            // 
            // btnDismCompra
            // 
            btnDismCompra.Font = new Font("Sans Serif Collection", 15F, FontStyle.Bold);
            btnDismCompra.ForeColor = Color.Black;
            btnDismCompra.Location = new Point(106, 211);
            btnDismCompra.Name = "btnDismCompra";
            btnDismCompra.Size = new Size(49, 56);
            btnDismCompra.TabIndex = 19;
            btnDismCompra.Text = "<";
            btnDismCompra.UseVisualStyleBackColor = true;
            btnDismCompra.Click += btnDismCompra_Click;
            // 
            // btnSalirMetPago
            // 
            btnSalirMetPago.BackColor = Color.FromArgb(110, 80, 50);
            btnSalirMetPago.FlatAppearance.BorderSize = 0;
            btnSalirMetPago.FlatStyle = FlatStyle.Flat;
            btnSalirMetPago.Font = new Font("Sans Serif Collection", 10F, FontStyle.Bold);
            btnSalirMetPago.ForeColor = Color.AntiqueWhite;
            btnSalirMetPago.Location = new Point(821, 26);
            btnSalirMetPago.Margin = new Padding(3, 2, 3, 2);
            btnSalirMetPago.Name = "btnSalirMetPago";
            btnSalirMetPago.Size = new Size(37, 37);
            btnSalirMetPago.TabIndex = 20;
            btnSalirMetPago.Text = "X";
            btnSalirMetPago.UseVisualStyleBackColor = false;
            btnSalirMetPago.Click += btnSalirMetPago_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Location = new Point(10, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(13, 432);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Location = new Point(864, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(15, 426);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SaddleBrown;
            panel3.Location = new Point(13, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(866, 15);
            panel3.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SaddleBrown;
            panel4.Location = new Point(10, 420);
            panel4.Name = "panel4";
            panel4.Size = new Size(869, 18);
            panel4.TabIndex = 24;
            // 
            // buttonOtroProducto
            // 
            buttonOtroProducto.BackColor = Color.FromArgb(110, 80, 50);
            buttonOtroProducto.FlatAppearance.BorderSize = 0;
            buttonOtroProducto.FlatStyle = FlatStyle.Flat;
            buttonOtroProducto.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonOtroProducto.ForeColor = Color.AntiqueWhite;
            buttonOtroProducto.Location = new Point(47, 278);
            buttonOtroProducto.Margin = new Padding(3, 2, 3, 2);
            buttonOtroProducto.Name = "buttonOtroProducto";
            buttonOtroProducto.Size = new Size(326, 44);
            buttonOtroProducto.TabIndex = 25;
            buttonOtroProducto.Text = "Continuar Comprando";
            buttonOtroProducto.UseVisualStyleBackColor = false;
            buttonOtroProducto.Click += buttonOtroProducto_Click;
            // 
            // FormMetodosPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(891, 450);
            Controls.Add(buttonOtroProducto);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSalirMetPago);
            Controls.Add(btnDismCompra);
            Controls.Add(btnAumCompra);
            Controls.Add(labelNumPorComprar);
            Controls.Add(labelSeleccionCant);
            Controls.Add(pictureOxxo);
            Controls.Add(pictureTarjeta);
            Controls.Add(picturePagoCaja);
            Controls.Add(buttonPagoOxxo);
            Controls.Add(buttonPagoTarjeta);
            Controls.Add(buttonPagoCaja);
            Controls.Add(labelSeleccionPago);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMetodosPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Metodos de Pago";
            ((System.ComponentModel.ISupportInitialize)picturePagoCaja).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTarjeta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOxxo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelSeleccionPago;
        private Button buttonPagoCaja;
        private Button buttonPagoTarjeta;
        private Button buttonPagoOxxo;
        private PictureBox picturePagoCaja;
        private PictureBox pictureTarjeta;
        private PictureBox pictureOxxo;
        private Label labelSeleccionCant;
        private Label labelNumPorComprar;
        private Button btnAumCompra;
        private Button btnDismCompra;
        private Button btnSalirMetPago;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button buttonOtroProducto;
    }
}