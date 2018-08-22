namespace VistaDesktop
{
    partial class SolicitudesUsuario
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
            this.tabla_solicitudes = new System.Windows.Forms.DataGridView();
            this.label_solicitudes = new System.Windows.Forms.Label();
            this.nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceptar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.denegar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_solicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_solicitudes
            // 
            this.tabla_solicitudes.AllowUserToDeleteRows = false;
            this.tabla_solicitudes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabla_solicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_solicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nick,
            this.nombre,
            this.direccion,
            this.aceptar,
            this.denegar});
            this.tabla_solicitudes.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabla_solicitudes.Location = new System.Drawing.Point(12, 71);
            this.tabla_solicitudes.Name = "tabla_solicitudes";
            this.tabla_solicitudes.ReadOnly = true;
            this.tabla_solicitudes.Size = new System.Drawing.Size(543, 136);
            this.tabla_solicitudes.TabIndex = 0;
            this.tabla_solicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_solicitudes
            // 
            this.label_solicitudes.AutoSize = true;
            this.label_solicitudes.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_solicitudes.Location = new System.Drawing.Point(144, 9);
            this.label_solicitudes.Name = "label_solicitudes";
            this.label_solicitudes.Size = new System.Drawing.Size(273, 32);
            this.label_solicitudes.TabIndex = 1;
            this.label_solicitudes.Text = "Solicitudes pedientes";
            this.label_solicitudes.Click += new System.EventHandler(this.label1_Click);
            // 
            // nick
            // 
            this.nick.HeaderText = "Nick";
            this.nick.Name = "nick";
            this.nick.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // aceptar
            // 
            this.aceptar.HeaderText = "";
            this.aceptar.Name = "aceptar";
            this.aceptar.ReadOnly = true;
            this.aceptar.Text = "aceptar";
            // 
            // denegar
            // 
            this.denegar.HeaderText = "";
            this.denegar.Name = "denegar";
            this.denegar.ReadOnly = true;
            this.denegar.Text = "denegar";
            // 
            // SolicitudesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(577, 258);
            this.Controls.Add(this.label_solicitudes);
            this.Controls.Add(this.tabla_solicitudes);
            this.Name = "SolicitudesUsuario";
            this.Text = "SolicitudesUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_solicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tabla_solicitudes;
        private System.Windows.Forms.Label label_solicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewButtonColumn aceptar;
        private System.Windows.Forms.DataGridViewButtonColumn denegar;
    }
}