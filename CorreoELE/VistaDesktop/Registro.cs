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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void label_direccion2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void volver_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (password.Text.Equals(confirmpassword.Text))
            {
                Detalle detalle = new Detalle(nick.Text, nombre.Text, apellido.Text);
                Usuario usuario = new Usuario(direccion.Text, password.Text, detalle);
                UsuarioABM usuarioAbm = new UsuarioABM();
                int ultimoID = usuarioAbm.RegistrarUsuario(usuario);
                MessageBox.Show("Usuario registrado correctamente");
                //MessageBox.Show(ultimoID.ToString());
            }
            else
            {
                MessageBox.Show("La dos contraseñas ingresadas son diferentes");
            }
        }
    }
}
