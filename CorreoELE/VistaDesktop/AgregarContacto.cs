﻿using Datos;
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
    public partial class AgregarContacto : Form
    {
        Usuario usuarioSesion = null;

        public AgregarContacto(Usuario usuario)
        {
            InitializeComponent();
            usuarioSesion = usuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_direccion2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enviarSolicitud_Click(object sender, EventArgs e)
        {
            ContactoABM contactoAbm = new ContactoABM();
            try
            {
                int respuesta = contactoAbm.enviarSolicitud(usuarioSesion, direccion.Text);
                MessageBox.Show(respuesta.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}