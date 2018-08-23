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
        private Usuario remitente;
        private Usuario destinatario;
        private String asunto;
        private String contenido;
        private DateTime fechaenvio;

        public Mail() { }

        public Mail(Usuario remitente, Usuario destinatario, string asunto, string contenido)
        {
            this.Remitente = remitente;
            this.Destinatario = destinatario;
            this.Asunto = asunto;
            this.Contenido = contenido;
        }

        public int Idmail { get => idmail; set => idmail = value; }
        public Usuario Remitente { get => remitente; set => remitente = value; }
        public Usuario Destinatario { get => destinatario; set => destinatario = value; }
        public string Asunto { get => asunto; set => asunto = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public DateTime Fechaenvio { get => fechaenvio; set => fechaenvio = value; }
    }
}
