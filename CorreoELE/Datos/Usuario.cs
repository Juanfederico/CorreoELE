using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        private int idusuario;
        private Detalle detalle;
        private String direccion;
        private String password;
        private String telefono;
        private List<Contacto> contactos;
        private List<Contacto> solicitudes;
        private List<Mail> mails;

        public Usuario() { }

        public Usuario(Detalle detalle, string direccion, string password, string telefono)
        {
            this.Detalle = detalle;
            this.Direccion = direccion;
            this.Password = password;
            this.Telefono = telefono;
        }

        public int Idusuario { get => idusuario; set => idusuario = value; }
        public Detalle Detalle { get => detalle; set => detalle = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Password { get => password; set => password = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<Contacto> Contactos { get => contactos; set => contactos = value; }
        public List<Contacto> Solicitudes { get => solicitudes; set => solicitudes = value; }
        public List<Mail> Mails { get => mails; set => mails = value; }
    }
}
