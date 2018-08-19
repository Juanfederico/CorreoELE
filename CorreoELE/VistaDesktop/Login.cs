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
            //String conexion = @"Server=JUAMPI-PC;Database=correoele;Trusted_Connection=True";
            //String sql = "INSERT INTO usuario VALUES ('hola@hola.com', '123456', null);";
            //SqlConnection conn = new SqlConnection(conexion);
            //SqlCommand comando; //Ejecuta un comando SQL en una conexión
            //SqlDataReader reader; //Variable donde se capturan los resultados de la query (filas afectadas o tabla/s)
            UsuarioABM usuarioAbm = new UsuarioABM();


            MessageBox.Show("Error al abrir la conexión");
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
