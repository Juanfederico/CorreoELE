using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Detalle
    {
        private int iddetalle;
        private String nick;
        private String nombre;
        private String apellido;
        private DateTime fechacreacion;

        public Detalle(string nick, string nombre, string apellido)
        {
            this.Nick = nick;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public int Iddetalle { get => iddetalle; set => iddetalle = value; }
        public string Nick { get => nick; set => nick = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Fechacreacion { get => fechacreacion; set => fechacreacion = value; }


    }
}
