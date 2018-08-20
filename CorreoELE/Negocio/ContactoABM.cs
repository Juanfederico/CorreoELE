using Dao;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ContactoABM
    {
        ContactoDao dao = new ContactoDao();

        public int enviarSolicitud(Usuario usuarioEmisor, String direccion) //usuario=quien envía la solicitud, direccion=email del destinatario
        {

            UsuarioDao usuarioDao = new UsuarioDao();
            Usuario usuarioReceptor = usuarioDao.SelectUsuario(direccion); //Se trae al usuario que se quiere agregar
            //Condiciones para manejo de excepciones
            if (usuarioEmisor.Direccion.Equals(direccion+"@correoele.com")) throw new Exception("No puede agregarse a usted mismo como contacto");
            if (usuarioReceptor == null) throw new Exception("La dirección ingresada no corresponde a un usuario valido");
            Contacto contacto = new Contacto(usuarioEmisor, usuarioReceptor.Detalle, false);
            return dao.InsertContacto(contacto); //1=Agregado correctamente, 0 o -1= Error
        }

        public List<Contacto> traerContactosUsuario(int idusuario)
        {
            return dao.selectContactos(idusuario);
        }
    }
}
