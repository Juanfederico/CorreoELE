using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaDesktop
{
    public partial class InicioUsuario : Form
    {
        Usuario usuarioSesion = new Usuario();

        public InicioUsuario(Usuario usuario)
        {
            InitializeComponent();
            label_bienvenido.Text += usuario.Detalle.Nick;
            cargarDatosContacto(usuario);
            usuarioSesion = usuario;
        }

        public void cargarDatosContacto(Usuario usuario)
        {
            tabla_contactos.Rows.Clear();
            ContactoABM contactoAbm = new ContactoABM();
            DataGridViewRow fila;
            //Trayendo lista de contactos del usuario y cargando la tabla
            List<Contacto> contactos = contactoAbm.traerContactosUsuario(usuario.Idusuario);
            foreach (Contacto contacto in contactos)
            {
                fila = (DataGridViewRow)tabla_contactos.Rows[0].Clone();
                fila.Cells[0].Value = contacto.Usuario.Detalle.Nick;
                fila.Cells[1].Value = contacto.Usuario.Detalle.Nombre;
                fila.Cells[2].Value = contacto.Usuario.Direccion;
                tabla_contactos.Rows.Add(fila);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void layout_contactos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contactos_Click(object sender, EventArgs e)
        {
            layout_contactos.Visible = true;
            tabla_contactos.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregarContacto_Click(object sender, EventArgs e)
        {
            AgregarContacto form_agregar = new AgregarContacto(usuarioSesion);
            form_agregar.ShowDialog();
            this.cargarDatosContacto(usuarioSesion); //Cuando sale de la pestaña se actualizan los contactos agregados
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void verSolicitudes_Click(object sender, EventArgs e)
        {
            SolicitudesUsuario solicitudes = new SolicitudesUsuario(usuarioSesion);
            solicitudes.ShowDialog();
            cargarDatosContacto(usuarioSesion);
        }
    }
}
