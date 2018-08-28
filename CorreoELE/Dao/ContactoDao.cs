using Datos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class ContactoDao
    {
        private String conexion;
        private SqlConnection conn;
        private SqlCommand comando;
        private SqlDataReader reader;

        public ContactoDao()
        {
            this.conexion = ConfigurationManager.ConnectionStrings["DatosConexion"].ConnectionString;
            this.conn = new SqlConnection(conexion);
            this.comando = null;
            this.reader = null;
        }

        public string Conexion { get => conexion; set => conexion = value; }
        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlCommand Comando { get => comando; set => comando = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }

        public List<Contacto> selectContactosEmisor(int idusuario) //ID del usuario emisor
        {
            List<Contacto> contactos = null;
            try
            {
                Conn.Open();
                //Instanciando en la tabla usuario y guardando el ID
                String sql_usuario = "SELECT * from Vista_emisores WHERE idusuario=" + idusuario + ";";
                Comando = new SqlCommand(sql_usuario, Conn);
                Reader = Comando.ExecuteReader();
                //Instanciando los datos del registro
                contactos = new List<Contacto>();//Inicializando lista
                Contacto contacto = new Contacto();
                Usuario usuario = new Usuario();
                Detalle detalle = new Detalle();
                while (Reader.Read())
                {
                    contacto.Idcontacto = Convert.ToInt32(Reader["idcontacto"].ToString());
                    usuario.Idusuario = Convert.ToInt32(Reader["idusuario_emisor"].ToString());
                    usuario.Direccion = Reader["direccion"].ToString();
                    detalle.Nick = Reader["nick"].ToString();
                    detalle.Nombre = Reader["nombre"].ToString();
                    detalle.Apellido = Reader["apellido"].ToString();
                    contacto.Aceptado = Convert.ToBoolean(Reader["aceptado"].ToString());
                    contacto.Fecha_agregado = Convert.ToDateTime(Reader["fecha_agregado"].ToString());
                    //Agregando datos a contacto
                    usuario.Detalle = detalle;
                    contacto.Usuario = usuario;
                    contactos.Add(contacto);
                    contacto = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
                Comando = null;
                Reader = null;
            }
            return contactos;
        }

        public List<Contacto> selectContactosReceptor(int idusuario) //ID del usuario receptor, Vista_solicitudes=receptores, idusuario=el de la sesion
        {
            List<Contacto> contactos = null;
            try
            {
                Conn.Open();
                //Instanciando en la tabla usuario y guardando el ID
                String sql_usuario = "SELECT * from Vista_solicitudes WHERE idusuario=" + idusuario + ";";
                Comando = new SqlCommand(sql_usuario, Conn);
                Reader = Comando.ExecuteReader();
                //Instanciando los datos del registro
                contactos = new List<Contacto>();//Inicializando lista
                Contacto contacto = new Contacto();
                Usuario usuario = new Usuario();
                Detalle detalle = new Detalle();
                while (Reader.Read())
                {
                    contacto.Idcontacto = Convert.ToInt32(Reader["idcontacto"].ToString());
                    usuario.Idusuario = Convert.ToInt32(Reader["idusuario_solicitud"].ToString());
                    usuario.Direccion = Reader["direccion"].ToString();
                    detalle.Nick = Reader["nick"].ToString();
                    detalle.Nombre = Reader["nombre"].ToString();
                    detalle.Apellido = Reader["apellido"].ToString();
                    contacto.Aceptado = Convert.ToBoolean(Reader["aceptado"].ToString());
                    contacto.Fecha_agregado = Convert.ToDateTime(Reader["fecha_agregado"].ToString());
                    //Agregando datos a contacto
                    usuario.Detalle = detalle;
                    contacto.Usuario = usuario;
                    contactos.Add(contacto);
                    contacto = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
                Comando = null;
                Reader = null;
            }
            return contactos;
        }


        public int InsertContacto(Usuario usuario, Contacto contacto) //El usuario es el emisor y el contacto el receptor
        {
            int insertCorrecto = -1; //Falso por defecto
            try
            {
                Conn.Open();
                String sql_detalle = "INSERT INTO contacto (idusuario_emisor, idusuario_receptor) VALUES ("+usuario.Idusuario+", " + contacto.Usuario.Idusuario + ") SELECT SCOPE_IDENTITY();";
                Comando = new SqlCommand(sql_detalle, Conn);
                //Instanciando en la tabla usuario_detalle, devuelve 1 si se insertó correctamente
                insertCorrecto = Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
                Comando = null;
                Reader = null;
            }
            return insertCorrecto;
        }

        public int updateAceptado(Usuario usuario, Contacto contacto, bool aceptado) //Usuario=Receptor (usuarioSesion) , Contacto=emisor, dado a que se utiliza para aceptar solicitudes
        {
            int updateCorrecto = -1; //Falso por defecto
            try
            {
                Conn.Open();
                String sql_detalle = "UPDATE contacto SET aceptado=" + Convert.ToInt32(aceptado) + " WHERE idusuario_emisor=" + contacto.Usuario.Idusuario + " AND idusuario_receptor=" + usuario.Idusuario + ";";
                Comando = new SqlCommand(sql_detalle, Conn);
                //Eliminando de la tabla contacto, devuelve 1 si se insertó correctamente
                updateCorrecto = Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
                Comando = null;
                Reader = null;
            }
            return updateCorrecto;
        }

        public int deleteContacto(Contacto contacto)
        {
            int deleteCorrecto = -1; //Falso por defecto
            try
            {
                Conn.Open();
                String sql_detalle = "DELETE FROM contacto WHERE idcontacto=" + contacto.Idcontacto + ";";
                Comando = new SqlCommand(sql_detalle, Conn);
                //Eliminando de la tabla contacto, devuelve 1 si se insertó correctamente
                deleteCorrecto = Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
                Comando = null;
                Reader = null;
            }
            return deleteCorrecto;
        }

    }
}
