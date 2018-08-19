using Dao;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioABM
    {
        UsuarioDao dao = new UsuarioDao();

        public int RegistrarUsuario(Usuario usuario)
        {
            int idDetalle = dao.InsertUsuarioDetalle(usuario.Detalle);
            usuario.Detalle.Iddetalle = idDetalle;
            int idUsuario = dao.InsertUsuario(usuario);
            return idUsuario;
        }
    }
}
