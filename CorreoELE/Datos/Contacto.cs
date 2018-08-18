﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Contacto
    {
        private Usuario usuario;
        private Detalle detalleusuario;
        private Detalle detallecontacto;
        private Boolean aceptado;
        private DateTime fecha_agregado;

        public Contacto(Usuario usuario, Detalle detalleusuario, Detalle detallecontacto, bool aceptado)
        {
            this.Usuario = usuario;
            this.Detalleusuario = detalleusuario;
            this.Detallecontacto = detallecontacto;
            this.Aceptado = aceptado;
        }

        public bool Aceptado { get => aceptado; set => aceptado = value; }
        public DateTime Fecha_agregado { get => fecha_agregado; set => fecha_agregado = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
        internal Detalle Detalleusuario { get => detalleusuario; set => detalleusuario = value; }
        internal Detalle Detallecontacto { get => detallecontacto; set => detallecontacto = value; }
    }
}