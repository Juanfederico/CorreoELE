using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Contacto
    {
        private int idcontacto;
        private Usuario usuario;
        private Boolean aceptado;
        private DateTime fecha_agregado;

        public Contacto() { }

        public Contacto(Usuario usuario, bool aceptado)
        {
            this.Usuario = usuario;
            this.Aceptado = aceptado;
        }

        public int Idcontacto { get => idcontacto; set => idcontacto = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public bool Aceptado { get => aceptado; set => aceptado = value; }
        public DateTime Fecha_agregado { get => fecha_agregado; set => fecha_agregado = value; }
    }
}
