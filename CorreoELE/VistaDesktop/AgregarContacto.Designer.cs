namespace VistaDesktop
{
    partial class AgregarContacto
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
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_direccion2 = new System.Windows.Forms.Label();
            this.enviarSolicitud = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(81, 14);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(109, 20);
            this.direccion.TabIndex = 0;
            this.direccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(17, 17);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(52, 13);
            this.label_direccion.TabIndex = 1;
            this.label_direccion.Text = "Dirección";
            this.label_direccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_direccion2
            // 
            this.label_direccion2.AutoSize = true;
            this.label_direccion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion2.Location = new System.Drawing.Point(189, 17);
            this.label_direccion2.Name = "label_direccion2";
            this.label_direccion2.Size = new System.Drawing.Size(99, 13);
            this.label_direccion2.TabIndex = 2;
            this.label_direccion2.Text = "@correoele.com";
            this.label_direccion2.Click += new System.EventHandler(this.label_direccion2_Click);
            // 
            // enviarSolicitud
            // 
            this.enviarSolicitud.Location = new System.Drawing.Point(102, 49);
            this.enviarSolicitud.Name = "enviarSolicitud";
            this.enviarSolicitud.Size = new System.Drawing.Size(100, 23);
            this.enviarSolicitud.TabIndex = 3;
            this.enviarSolicitud.Text = "Enviar solicitud";
            this.enviarSolicitud.UseVisualStyleBackColor = true;
            this.enviarSolicitud.Click += new System.EventHandler(this.enviarSolicitud_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(115, 93);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 4;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            // 
            // AgregarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(294, 122);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.enviarSolicitud);
            this.Controls.Add(this.label_direccion2);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.direccion);
            this.Name = "AgregarContacto";
            this.Text = "AgregarContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_direccion2;
        private System.Windows.Forms.Button enviarSolicitud;
        private System.Windows.Forms.Button volver;
    }
}