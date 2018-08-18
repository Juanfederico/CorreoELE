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
            String conexion = @"Server=JUAMPI-PC;Database=correoele;Trusted_Connection=True";
            String sql_detalle = "INSERT INTO usuario_detalle (nick, nombre, apellido) VALUES ('"+nick.Text+"', '"+nombre.Text+"', '"+apellido.Text+ "') SELECT SCOPE_IDENTITY();";
            String sql_usuario = "INSERT INTO usuario VALUES ('"+direccion.Text+"@correoele.com', '"+password.Text+"', null);";
            SqlConnection conn = new SqlConnection(conexion);
            SqlCommand comando; //Ejecuta un comando SQL en una conexión
            SqlDataReader reader; //Variable donde se capturan los resultados de la query (filas afectadas o tabla/s)

            try
            {
                conn.Open();
                comando = new SqlCommand(sql_detalle, conn);
                reader = comando.ExecuteReader();
                reader.Read();
                int idpedido_usuario = (Int32)reader.GetSqlValue(0);
                /*while (reader.Read())
                {
                    MessageBox.Show()
                }*/
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión");
            }
        }
    }
}
