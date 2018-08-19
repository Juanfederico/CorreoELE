using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Mail
    {
        private int idmail;
        private Detalle remitente;
        private Detalle destinatario;
        private String asunto;
        private String contenido;
        private DateTime fechaenvio;

        public Mail(Detalle remitente, Detalle destinatario, string asunto, string contenido)
        {
            this.Remitente = remitente;
            this.Destinatario = destinatario;
            this.Asunto = asunto;
            this.Contenido = contenido;
        }

        public int Idmail { get => idmail; set => idmail = value; }
        public string Asunto { get => asunto; set => asunto = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public DateTime Fechaenvio { get => fechaenvio; set => fechaenvio = value; }
        internal Detalle Remitente { get => remitente; set => remitente = value; }
        internal Detalle Destinatario { get => destinatario; set => destinatario = value; }
    }
}
