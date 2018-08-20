using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Contacto
    {
        private Usuario usuario;
        private Detalle detallecontacto;
        private Boolean aceptado;
        private DateTime fecha_agregado;

        public Contacto() { }

        public Contacto(Usuario usuario, Detalle detallecontacto, bool aceptado)
        {
            this.Usuario = usuario;
            this.Detallecontacto = detallecontacto;
            this.Aceptado = aceptado;
        }

        public bool Aceptado { get => aceptado; set => aceptado = value; }
        public DateTime Fecha_agregado { get => fecha_agregado; set => fecha_agregado = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public Detalle Detallecontacto { get => detallecontacto; set => detallecontacto = value; }
    }
}
