using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Contacto
    {
        private Usuario usuarioEmisor;
        private Usuario usuarioReceptor;
        private Boolean aceptado;
        private DateTime fecha_agregado;

        public Contacto() { }

        public Contacto(Usuario usuarioEmisor, Usuario usuarioReceptor, bool aceptado)
        {
            this.UsuarioEmisor = usuarioEmisor;
            this.UsuarioReceptor = usuarioReceptor;
            this.Aceptado = aceptado;
        }

        public bool Aceptado { get => aceptado; set => aceptado = value; }
        public DateTime Fecha_agregado { get => fecha_agregado; set => fecha_agregado = value; }
        public Usuario UsuarioEmisor { get => usuarioEmisor; set => usuarioEmisor = value; }
        public Usuario UsuarioReceptor { get => usuarioReceptor; set => usuarioReceptor = value; }
    }
}
