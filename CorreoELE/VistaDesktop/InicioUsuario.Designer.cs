namespace VistaDesktop
{
    partial class InicioUsuario
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
            this.label_bienvenido = new System.Windows.Forms.Label();
            this.contactos = new System.Windows.Forms.Button();
            this.mails = new System.Windows.Forms.Button();
            this.perfil = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.layout_contactos = new System.Windows.Forms.FlowLayoutPanel();
            this.agregarContacto = new System.Windows.Forms.Button();
            this.verSolicitudes = new System.Windows.Forms.Button();
            this.verBloqueados = new System.Windows.Forms.Button();
            this.panel_contactos = new System.Windows.Forms.Panel();
            this.tabla_contactos = new System.Windows.Forms.DataGridView();
            this.nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.layout_contactos.SuspendLayout();
            this.panel_contactos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_contactos)).BeginInit();
            this.SuspendLayout();
            // 
            // label_bienvenido
            // 
            this.label_bienvenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_bienvenido.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bienvenido.Location = new System.Drawing.Point(0, 0);
            this.label_bienvenido.Name = "label_bienvenido";
            this.label_bienvenido.Size = new System.Drawing.Size(558, 31);
            this.label_bienvenido.TabIndex = 0;
            this.label_bienvenido.Text = "Bienvenido ";
            this.label_bienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_bienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // contactos
            // 
            this.contactos.Location = new System.Drawing.Point(238, 52);
            this.contactos.Name = "contactos";
            this.contactos.Size = new System.Drawing.Size(75, 23);
            this.contactos.TabIndex = 1;
            this.contactos.Text = "Contactos";
            this.contactos.UseVisualStyleBackColor = true;
            this.contactos.Click += new System.EventHandler(this.contactos_Click);
            // 
            // mails
            // 
            this.mails.Location = new System.Drawing.Point(457, 52);
            this.mails.Name = "mails";
            this.mails.Size = new System.Drawing.Size(75, 23);
            this.mails.TabIndex = 2;
            this.mails.Text = "Mails";
            this.mails.UseVisualStyleBackColor = true;
            this.mails.Click += new System.EventHandler(this.button1_Click);
            // 
            // perfil
            // 
            this.perfil.Location = new System.Drawing.Point(30, 52);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(75, 23);
            this.perfil.TabIndex = 3;
            this.perfil.Text = "Perfil";
            this.perfil.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(239, 334);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 23);
            this.logout.TabIndex = 4;
            this.logout.Text = "Cerrar sesión";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelMenu.Location = new System.Drawing.Point(15, 44);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(531, 41);
            this.panelMenu.TabIndex = 5;
            // 
            // layout_contactos
            // 
            this.layout_contactos.Controls.Add(this.agregarContacto);
            this.layout_contactos.Controls.Add(this.verSolicitudes);
            this.layout_contactos.Controls.Add(this.verBloqueados);
            this.layout_contactos.Location = new System.Drawing.Point(101, 95);
            this.layout_contactos.Name = "layout_contactos";
            this.layout_contactos.Size = new System.Drawing.Size(353, 32);
            this.layout_contactos.TabIndex = 7;
            this.layout_contactos.Visible = false;
            this.layout_contactos.Paint += new System.Windows.Forms.PaintEventHandler(this.layout_contactos_Paint);
            // 
            // agregarContacto
            // 
            this.agregarContacto.AutoSize = true;
            this.agregarContacto.Location = new System.Drawing.Point(3, 3);
            this.agregarContacto.Name = "agregarContacto";
            this.agregarContacto.Size = new System.Drawing.Size(125, 23);
            this.agregarContacto.TabIndex = 0;
            this.agregarContacto.Text = "Añadir nuevo contacto";
            this.agregarContacto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.agregarContacto.UseVisualStyleBackColor = true;
            this.agregarContacto.Click += new System.EventHandler(this.agregarContacto_Click);
            // 
            // verSolicitudes
            // 
            this.verSolicitudes.Location = new System.Drawing.Point(134, 3);
            this.verSolicitudes.Name = "verSolicitudes";
            this.verSolicitudes.Size = new System.Drawing.Size(106, 23);
            this.verSolicitudes.TabIndex = 2;
            this.verSolicitudes.Text = "Solicitudes";
            this.verSolicitudes.UseVisualStyleBackColor = true;
            this.verSolicitudes.Click += new System.EventHandler(this.verSolicitudes_Click);
            // 
            // verBloqueados
            // 
            this.verBloqueados.Location = new System.Drawing.Point(246, 3);
            this.verBloqueados.Name = "verBloqueados";
            this.verBloqueados.Size = new System.Drawing.Size(103, 23);
            this.verBloqueados.TabIndex = 3;
            this.verBloqueados.Text = "Bloqueados";
            this.verBloqueados.UseVisualStyleBackColor = true;
            this.verBloqueados.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // panel_contactos
            // 
            this.panel_contactos.Controls.Add(this.tabla_contactos);
            this.panel_contactos.Location = new System.Drawing.Point(18, 140);
            this.panel_contactos.Name = "panel_contactos";
            this.panel_contactos.Size = new System.Drawing.Size(514, 185);
            this.panel_contactos.TabIndex = 8;
            // 
            // tabla_contactos
            // 
            this.tabla_contactos.AllowUserToDeleteRows = false;
            this.tabla_contactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_contactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nick,
            this.direccion,
            this.direccionContacto,
            this.detalle});
            this.tabla_contactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla_contactos.Location = new System.Drawing.Point(0, 0);
            this.tabla_contactos.Name = "tabla_contactos";
            this.tabla_contactos.ReadOnly = true;
            this.tabla_contactos.Size = new System.Drawing.Size(514, 185);
            this.tabla_contactos.TabIndex = 0;
            this.tabla_contactos.Visible = false;
            this.tabla_contactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // nick
            // 
            this.nick.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nick.FillWeight = 77.15736F;
            this.nick.HeaderText = "Nick";
            this.nick.Name = "nick";
            this.nick.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccion.FillWeight = 107.6142F;
            this.direccion.HeaderText = "Nombre";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // direccionContacto
            // 
            this.direccionContacto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccionContacto.FillWeight = 107.6142F;
            this.direccionContacto.HeaderText = "Direccion";
            this.direccionContacto.Name = "direccionContacto";
            this.direccionContacto.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detalle.FillWeight = 107.6142F;
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Text = "Ver detalle";
            this.detalle.ToolTipText = "Ver detalle";
            // 
            // InicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(558, 366);
            this.Controls.Add(this.layout_contactos);
            this.Controls.Add(this.panel_contactos);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.mails);
            this.Controls.Add(this.contactos);
            this.Controls.Add(this.label_bienvenido);
            this.Controls.Add(this.panelMenu);
            this.Name = "InicioUsuario";
            this.Text = "Inicio";
            this.layout_contactos.ResumeLayout(false);
            this.layout_contactos.PerformLayout();
            this.panel_contactos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_contactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_bienvenido;
        private System.Windows.Forms.Button contactos;
        private System.Windows.Forms.Button mails;
        private System.Windows.Forms.Button perfil;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel layout_contactos;
        private System.Windows.Forms.Button agregarContacto;
        private System.Windows.Forms.Button verSolicitudes;
        private System.Windows.Forms.Panel panel_contactos;
        private System.Windows.Forms.DataGridView tabla_contactos;
        private System.Windows.Forms.Button verBloqueados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionContacto;
        private System.Windows.Forms.DataGridViewButtonColumn detalle;
    }
}