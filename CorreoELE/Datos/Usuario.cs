using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Usuario
    {
        private int idusuario;
        private String direccion;
        private String password;
        private Detalle detalle;
        private List<Contacto> contactos;
        private List<Mail> mails;

        public Usuario(string direccion, string password, Detalle detalle)
        {
            this.Direccion = direccion;
            this.Password = password;
            this.Detalle = detalle;
        }

        public int Idusuario { get => idusuario; set => idusuario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Password { get => password; set => password = value; }
        internal Detalle Detalle { get => detalle; set => detalle = value; }
        internal List<Contacto> Contactos { get => contactos; set => contactos = value; }
        internal List<Mail> Mails { get => mails; set => mails = value; }
    }
}
