namespace WinFormsProyectoBase
{
    partial class FormCantidadComprar
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
            buttonOtroProducto = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            btnSalirMetPago = new Button();
            btnDismCompra = new Button();
            btnAumCompra = new Button();
            labelNumPorComprar = new Label();
            labelSeleccionCant = new Label();
            buttonPago = new Button();
            SuspendLayout();
            // 
            // buttonOtroProducto
            // 
            buttonOtroProducto.BackColor = Color.FromArgb(110, 80, 50);
            buttonOtroProducto.FlatAppearance.BorderSize = 0;
            buttonOtroProducto.FlatStyle = FlatStyle.Flat;
            buttonOtroProducto.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonOtroProducto.ForeColor = Color.AntiqueWhite;
            buttonOtroProducto.Location = new Point(43, 152);
            buttonOtroProducto.Margin = new Padding(3, 2, 3, 2);
            buttonOtroProducto.Name = "buttonOtroProducto";
            buttonOtroProducto.Size = new Size(326, 44);
            buttonOtroProducto.TabIndex = 42;
            buttonOtroProducto.Text = "Continuar Comprando";
            buttonOtroProducto.UseVisualStyleBackColor = false;
            buttonOtroProducto.Click += buttonOtroProducto_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SaddleBrown;
            panel4.Location = new Point(8, 269);
            panel4.Name = "panel4";
            panel4.Size = new Size(406, 18);
            panel4.TabIndex = 41;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SaddleBrown;
            panel3.Location = new Point(21, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(393, 15);
            panel3.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Location = new Point(399, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(15, 249);
            panel2.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Location = new Point(8, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(13, 264);
            panel1.TabIndex = 38;
            // 
            // btnSalirMetPago
            // 
            btnSalirMetPago.BackColor = Color.FromArgb(110, 80, 50);
            btnSalirMetPago.FlatAppearance.BorderSize = 0;
            btnSalirMetPago.FlatStyle = FlatStyle.Flat;
            btnSalirMetPago.Font = new Font("Sans Serif Collection", 10F, FontStyle.Bold);
            btnSalirMetPago.ForeColor = Color.AntiqueWhite;
            btnSalirMetPago.Location = new Point(355, 29);
            btnSalirMetPago.Margin = new Padding(3, 2, 3, 2);
            btnSalirMetPago.Name = "btnSalirMetPago";
            btnSalirMetPago.Size = new Size(37, 37);
            btnSalirMetPago.TabIndex = 37;
            btnSalirMetPago.Text = "X";
            btnSalirMetPago.UseVisualStyleBackColor = false;
            btnSalirMetPago.Click += btnSalirMetPago_Click;
            // 
            // btnDismCompra
            // 
            btnDismCompra.Font = new Font("Sans Serif Collection", 15F, FontStyle.Bold);
            btnDismCompra.ForeColor = Color.Black;
            btnDismCompra.Location = new Point(102, 85);
            btnDismCompra.Name = "btnDismCompra";
            btnDismCompra.Size = new Size(49, 56);
            btnDismCompra.TabIndex = 36;
            btnDismCompra.Text = "<";
            btnDismCompra.UseVisualStyleBackColor = true;
            btnDismCompra.Click += btnDismCompra_Click;
            // 
            // btnAumCompra
            // 
            btnAumCompra.Font = new Font("Sans Serif Collection", 15F, FontStyle.Bold);
            btnAumCompra.ForeColor = Color.Black;
            btnAumCompra.Location = new Point(248, 85);
            btnAumCompra.Name = "btnAumCompra";
            btnAumCompra.Size = new Size(49, 56);
            btnAumCompra.TabIndex = 35;
            btnAumCompra.Text = ">";
            btnAumCompra.UseVisualStyleBackColor = true;
            btnAumCompra.Click += btnAumCompra_Click;
            // 
            // labelNumPorComprar
            // 
            labelNumPorComprar.AutoSize = true;
            labelNumPorComprar.Font = new Font("Script MT Bold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumPorComprar.ForeColor = Color.FromArgb(110, 80, 50);
            labelNumPorComprar.Location = new Point(179, 88);
            labelNumPorComprar.Name = "labelNumPorComprar";
            labelNumPorComprar.Size = new Size(41, 48);
            labelNumPorComprar.TabIndex = 34;
            labelNumPorComprar.Text = "0";
            // 
            // labelSeleccionCant
            // 
            labelSeleccionCant.AutoSize = true;
            labelSeleccionCant.Font = new Font("Script MT Bold", 20F, FontStyle.Bold);
            labelSeleccionCant.ForeColor = Color.FromArgb(110, 80, 50);
            labelSeleccionCant.Location = new Point(60, 36);
            labelSeleccionCant.Name = "labelSeleccionCant";
            labelSeleccionCant.Size = new Size(289, 33);
            labelSeleccionCant.TabIndex = 33;
            labelSeleccionCant.Text = "¿Cuántos desea comprar?";
            // 
            // buttonPago
            // 
            buttonPago.BackColor = Color.FromArgb(110, 80, 50);
            buttonPago.FlatAppearance.BorderSize = 0;
            buttonPago.FlatStyle = FlatStyle.Flat;
            buttonPago.Font = new Font("Sans Serif Collection", 12F, FontStyle.Bold);
            buttonPago.ForeColor = Color.AntiqueWhite;
            buttonPago.Location = new Point(43, 209);
            buttonPago.Margin = new Padding(3, 2, 3, 2);
            buttonPago.Name = "buttonPago";
            buttonPago.Size = new Size(326, 44);
            buttonPago.TabIndex = 43;
            buttonPago.Text = "Pagar";
            buttonPago.UseVisualStyleBackColor = false;
            buttonPago.Click += buttonPago_Click;
            // 
            // FormCantidadComprar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(426, 298);
            Controls.Add(buttonPago);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCantidadComprar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCantidadComprar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOtroProducto;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button btnSalirMetPago;
        private Button btnDismCompra;
        private Button btnAumCompra;
        private Label labelNumPorComprar;
        private Label labelSeleccionCant;
        private Button buttonPago;
    }
}