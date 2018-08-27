namespace VistaDesktop
{
    partial class Registro
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
            this.label_correoele = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_nick = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_password2 = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.nick = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label_direccion2 = new System.Windows.Forms.Label();
            this.registrar = new System.Windows.Forms.Button();
            this.volver_login = new System.Windows.Forms.Button();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label_telefono = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_correoele
            // 
            this.label_correoele.AutoSize = true;
            this.label_correoele.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correoele.Location = new System.Drawing.Point(62, 36);
            this.label_correoele.Name = "label_correoele";
            this.label_correoele.Size = new System.Drawing.Size(315, 31);
            this.label_correoele.TabIndex = 0;
            this.label_correoele.Text = "CorreoELE - REGISTRO";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(48, 103);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(94, 13);
            this.label_direccion.TabIndex = 1;
            this.label_direccion.Text = "Dirección de email";
            this.label_direccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_nick
            // 
            this.label_nick.AutoSize = true;
            this.label_nick.Location = new System.Drawing.Point(47, 131);
            this.label_nick.Name = "label_nick";
            this.label_nick.Size = new System.Drawing.Size(62, 13);
            this.label_nick.TabIndex = 2;
            this.label_nick.Text = "Nick o alias";
            this.label_nick.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(48, 157);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(61, 13);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Contraseña";
            // 
            // label_password2
            // 
            this.label_password2.AutoSize = true;
            this.label_password2.Location = new System.Drawing.Point(48, 183);
            this.label_password2.Name = "label_password2";
            this.label_password2.Size = new System.Drawing.Size(107, 13);
            this.label_password2.TabIndex = 4;
            this.label_password2.Text = "Confirmar contraseña";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(48, 209);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 5;
            this.label_nombre.Text = "Nombre";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(48, 235);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(44, 13);
            this.label_apellido.TabIndex = 6;
            this.label_apellido.Text = "Apellido";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(164, 100);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(149, 20);
            this.direccion.TabIndex = 7;
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(164, 128);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(112, 20);
            this.nick.TabIndex = 8;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(164, 154);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 9;
            this.password.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // confirmpassword
            // 
            this.confirmpassword.Location = new System.Drawing.Point(164, 180);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.PasswordChar = '*';
            this.confirmpassword.Size = new System.Drawing.Size(100, 20);
            this.confirmpassword.TabIndex = 10;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(164, 206);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 11;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(164, 232);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 12;
            // 
            // label_direccion2
            // 
            this.label_direccion2.AutoSize = true;
            this.label_direccion2.Location = new System.Drawing.Point(311, 103);
            this.label_direccion2.Name = "label_direccion2";
            this.label_direccion2.Size = new System.Drawing.Size(85, 13);
            this.label_direccion2.TabIndex = 13;
            this.label_direccion2.Text = "@correoele.com";
            this.label_direccion2.Click += new System.EventHandler(this.label_direccion2_Click);
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(176, 284);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 14;
            this.registrar.Text = "Registrarse";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // volver_login
            // 
            this.volver_login.Location = new System.Drawing.Point(176, 312);
            this.volver_login.Name = "volver_login";
            this.volver_login.Size = new System.Drawing.Size(75, 23);
            this.volver_login.TabIndex = 15;
            this.volver_login.Text = "Volver";
            this.volver_login.UseVisualStyleBackColor = true;
            this.volver_login.Click += new System.EventHandler(this.volver_login_Click);
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(164, 258);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 17;
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(48, 261);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(49, 13);
            this.label_telefono.TabIndex = 16;
            this.label_telefono.Text = "Telefono";
            this.label_telefono.Click += new System.EventHandler(this.label1_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 338);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.volver_login);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.label_direccion2);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_password2);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_nick);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_correoele);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_correoele;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_nick;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_password2;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirmpassword;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label_direccion2;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button volver_login;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label_telefono;
    }
}