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
    public partial class SolicitudesUsuario : Form
    {
        Usuario usuarioSesion = null;
        String direccionAEliminar = "";


        public SolicitudesUsuario(Usuario usuario)
        {
            InitializeComponent();
            usuarioSesion = usuario;
            cargarDatosContacto(usuario);
        }

        public void cargarDatosContacto(Usuario usuario)
        {
            tabla_solicitudes.Rows.Clear();
            ContactoABM contactoAbm = new ContactoABM();
            DataGridViewRow fila;
            //Trayendo lista de contactos del usuario y cargando la tabla
            List<Contacto> contactos = contactoAbm.traerSolicitudesUsuario(usuario.Idusuario);
            foreach (Contacto contacto in contactos)
            {
                fila = (DataGridViewRow)tabla_solicitudes.Rows[0].Clone();
                fila.Cells[0].Value = contacto.Usuario.Detalle.Nick;
                fila.Cells[1].Value = contacto.Usuario.Detalle.Nombre;
                fila.Cells[2].Value = contacto.Usuario.Direccion; //Del contacto (hay que cambiar el diseño)
                fila.Cells[3].Value = "aceptar";
                fila.Cells[4].Value = "denegar";
                tabla_solicitudes.Rows.Add(fila);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ContactoABM contactoAbm = new ContactoABM();

            if (e.ColumnIndex == tabla_solicitudes.Columns["aceptar"].Index)
            {
                String direccion = tabla_solicitudes.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                int respuesta = contactoAbm.aceptarContacto(usuarioSesion.Idusuario, direccion);
                MessageBox.Show("Usuario aceptado ("+direccion+")");
            }

            if (e.ColumnIndex == tabla_solicitudes.Columns["aceptar"].Index)
            {
                MessageBox.Show("toco denegar");
            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
