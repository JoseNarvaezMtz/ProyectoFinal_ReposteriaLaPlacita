namespace WinFormsProyectoBase
{
    partial class FormInicioSesion
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
            btnUsuario = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(450, 185);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(136, 41);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(189, 185);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(136, 41);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Administrador";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdmin);
            Controls.Add(btnUsuario);
            Name = "FormInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInicioSesion";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnAdmin;
    }
}