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
            btnSalirMetPago = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
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
            labelSeleccionPago.Location = new Point(48, 30);
            labelSeleccionPago.Name = "labelSeleccionPago";
            labelSeleccionPago.Size = new Size(412, 41);
            labelSeleccionPago.TabIndex = 9;
            labelSeleccionPago.Text = "Seleccione el Método de Pago";
            // 
            // buttonPagoCaja
            // 
            buttonPagoCaja.BackColor = Color.FromArgb(110, 80, 50);
            buttonPagoCaja.FlatAppearance.BorderSize = 0;
            buttonPagoCaja.FlatStyle = FlatStyle.Flat;
            buttonPagoCaja.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonPagoCaja.ForeColor = Color.AntiqueWhite;
            buttonPagoCaja.Location = new Point(79, 109);
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
            buttonPagoTarjeta.Location = new Point(79, 183);
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
            buttonPagoOxxo.Location = new Point(79, 257);
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
            picturePagoCaja.Location = new Point(433, 109);
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
            pictureTarjeta.Location = new Point(412, 183);
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
            pictureOxxo.Location = new Point(422, 257);
            pictureOxxo.Margin = new Padding(3, 2, 3, 2);
            pictureOxxo.Name = "pictureOxxo";
            pictureOxxo.Size = new Size(78, 44);
            pictureOxxo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureOxxo.TabIndex = 15;
            pictureOxxo.TabStop = false;
            // 
            // btnSalirMetPago
            // 
            btnSalirMetPago.BackColor = Color.FromArgb(110, 80, 50);
            btnSalirMetPago.FlatAppearance.BorderSize = 0;
            btnSalirMetPago.FlatStyle = FlatStyle.Flat;
            btnSalirMetPago.Font = new Font("Sans Serif Collection", 10F, FontStyle.Bold);
            btnSalirMetPago.ForeColor = Color.AntiqueWhite;
            btnSalirMetPago.Location = new Point(481, 30);
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
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(13, 369);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Location = new Point(524, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(15, 363);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SaddleBrown;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(529, 15);
            panel3.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SaddleBrown;
            panel4.Location = new Point(10, 361);
            panel4.Name = "panel4";
            panel4.Size = new Size(529, 18);
            panel4.TabIndex = 24;
            // 
            // FormMetodosPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(550, 390);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSalirMetPago);
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
        private Button btnSalirMetPago;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}