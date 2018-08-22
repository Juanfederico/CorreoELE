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

        public Contacto traerContacto(int idusuario, String direccion) //De un usuario determinado, una direccion determinada
        {
            Contacto contactoSeleccionado = null;
            List<Contacto> contactos = dao.selectContactos(idusuario);
            foreach(Contacto contacto in contactos)
            {
                if (contacto.Usuario.Direccion.Equals(direccion))
                {
                    contactoSeleccionado = contacto;
                }
            }
            return contactoSeleccionado;
        }


        public int aceptarContacto(int idusuario, String direccion) //El idsuario NO es del del contacto, sino del usuario de la sesión 
        {
            Contacto contactoAAceptar = traerContacto(idusuario, direccion);
            contactoAAceptar.Usuario.Idusuario = idusuario; //Agrego el de la sesión al contacto
            return dao.updateAceptado(contactoAAceptar, true);
        }

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
            List<Contacto> contactosAceptados = new List<Contacto>();
            foreach (Contacto contacto in dao.selectContactos(idusuario)){
                if (contacto.Aceptado) contactosAceptados.Add(contacto);
            }
            return contactosAceptados;
        }

        public List<Contacto> traerSolicitudesUsuario(int iddetalle_usuario)
        {
            List<Contacto> contactosAceptados = new List<Contacto>();
            foreach (Contacto contacto in dao.selectContactos(iddetalle_usuario))
            {
                if (!contacto.Aceptado) contactosAceptados.Add(contacto);
            }
            return contactosAceptados;
        }

        public int eliminarContacto(int idusuario, String direccion)
        {
            Contacto contactoAEliminar = traerContacto(idusuario, direccion);
            return dao.deleteContacto(contactoAEliminar);
        }
    }
}
