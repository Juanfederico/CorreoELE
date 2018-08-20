using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioABM usuarioAbm = new UsuarioABM();
            Usuario usuario = usuarioAbm.LoginUsuario(direccion.Text, password.Text);
            if(usuario == null) MessageBox.Show("Direccion o contraseña incorrecta");
            else
            {
                this.Hide();
                InicioUsuario ini_usuario = new InicioUsuario(usuario);
                ini_usuario.ShowDialog();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro reg = new Registro();
            reg.ShowDialog();
        }
    }
}
