namespace VistaDesktop
{
    partial class Login
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
            this.direccion = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label_registro = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Button();
            this.registrar = new System.Windows.Forms.Button();
            this.label_correoele = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(120, 109);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(121, 145);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 1;
            this.password.UseWaitCursor = true;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_registro
            // 
            this.label_registro.AutoSize = true;
            this.label_registro.Location = new System.Drawing.Point(117, 247);
            this.label_registro.Name = "label_registro";
            this.label_registro.Size = new System.Drawing.Size(98, 13);
            this.label_registro.TabIndex = 2;
            this.label_registro.Text = "¿No tenés cuenta?";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(70, 112);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(52, 13);
            this.label_direccion.TabIndex = 3;
            this.label_direccion.Text = "Dirección";
            this.label_direccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(61, 148);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(61, 13);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Contraseña";
            this.label_password.Click += new System.EventHandler(this.label3_Click);
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(124, 182);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(90, 23);
            this.iniciar.TabIndex = 5;
            this.iniciar.Text = "Iniciar Sesión";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(131, 266);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 6;
            this.registrar.Text = "Registrarte";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // label_correoele
            // 
            this.label_correoele.AutoSize = true;
            this.label_correoele.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correoele.Location = new System.Drawing.Point(40, 37);
            this.label_correoele.Name = "label_correoele";
            this.label_correoele.Size = new System.Drawing.Size(257, 31);
            this.label_correoele.TabIndex = 7;
            this.label_correoele.Text = "CorreoELE - LOGIN";
            this.label_correoele.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 307);
            this.Controls.Add(this.label_correoele);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_registro);
            this.Controls.Add(this.password);
            this.Controls.Add(this.direccion);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label_registro;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Label label_correoele;
    }
}