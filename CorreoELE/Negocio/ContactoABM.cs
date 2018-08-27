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
            Contacto contactoSeleccionado = new Contacto();
            List<Contacto> contactos = dao.selectContactosEmisor(idusuario);
            contactos.AddRange(dao.selectContactosReceptor(idusuario));
            foreach(Contacto contacto in contactos)
            {
                if (contacto.Usuario.Direccion.Equals(direccion))
                {
                    contactoSeleccionado = contacto;
                }
            }
            return contactoSeleccionado;
        }


        public int aceptarContacto(int idusuarioSesion, String direccion) //El idsuario NO es del del contacto, sino del usuario de la sesión 
        {
            UsuarioDao usuarioDao = new UsuarioDao();
            Contacto contactoAAceptar = traerContacto(idusuarioSesion, direccion);
            Usuario usuarioSesion = usuarioDao.SelectUsuario(idusuarioSesion); //Agrego el de la sesión al contacto
            return dao.updateAceptado(usuarioSesion, contactoAAceptar, true);
        }

        public int enviarSolicitud(Usuario usuarioEmisor, String direccion) //usuario=quien envía la solicitud, direccion=email del destinatario
        {

            UsuarioDao usuarioDao = new UsuarioDao();
            Usuario usuarioReceptor = usuarioDao.SelectUsuario(direccion); //Se trae al usuario que se quiere agregar

            //Condiciones para manejo de excepciones
            if (usuarioEmisor.Direccion.Equals(direccion+"@correoele.com")) throw new Exception("No puede agregarse a usted mismo como contacto");
            if (usuarioReceptor == null) throw new Exception("La dirección ingresada no corresponde a un usuario valido");
            Contacto contacto = new Contacto(usuarioReceptor, true);
            return dao.InsertContacto(usuarioEmisor, contacto); //1=Agregado correctamente, 0 o -1= Error
        }

        public List<Contacto> traerContactosUsuario(int idusuario)
        {
            List<Contacto> contactosAceptados = new List<Contacto>();
            List<Contacto> contactos = dao.selectContactosEmisor(idusuario);
            contactos.AddRange(dao.selectContactosReceptor(idusuario));

            foreach (Contacto contacto in contactos){
                if (contacto.Aceptado) contactosAceptados.Add(contacto);
            }
            return contactosAceptados;
        }

        public List<Contacto> traerSolicitudesUsuario(int idusuario) //Usuario sesion (para el contexto que aplica es para el Receptor)
        {
            List<Contacto> contactosAceptados = new List<Contacto>();
            List<Contacto> contactos = dao.selectContactosReceptor(idusuario);
            foreach (Contacto contacto in contactos)
            {
                if (!contacto.Aceptado) contactosAceptados.Add(contacto);
            }
            return contactosAceptados;
        }

        public int eliminarContacto(int idusuario, String direccion)
        {
            Contacto contactoAEliminar = traerContacto(idusuario, direccion);
            dao.deleteContactoEmisor
            return dao.deleteContacto(contactoAEliminar);
        }
    }
}
