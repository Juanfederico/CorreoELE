using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Datos;

namespace Dao
{
    public class UsuarioDao
    {
        private String conexion;
        private SqlConnection conn;
        private SqlCommand comando;
        private SqlDataReader reader;

        public UsuarioDao()
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

        public int InsertUsuario(Usuario usuario)
        {
            int idUsuario = -1;
            try
            {
                Conn.Open();
                //Instanciando en la tabla usuario y guardando el ID
                String sql_usuario = "INSERT INTO usuario VALUES ('" +usuario.Direccion+ "@correoele.com', HASHBYTES('MD5', '" +usuario.Password+ "'), "+usuario.Detalle.Iddetalle+") SELECT SCOPE_IDENTITY();";
                Comando = new SqlCommand(sql_usuario, Conn);
                Reader = Comando.ExecuteReader();
                Reader.Read();
                idUsuario = Convert.ToInt32(Reader.GetValue(0));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
                Comando = null;
                Reader = null;
            }
            return idUsuario;
        }

        public int InsertUsuarioDetalle(Detalle detalle)
        {
            int idDetalle = -1;
            try
            {
                Conn.Open();
                String sql_detalle = "INSERT INTO usuario_detalle (nick, nombre, apellido) VALUES ('" + detalle.Nick + "', '" + detalle.Nombre + "', '" + detalle.Apellido + "') SELECT SCOPE_IDENTITY();";
                Comando = new SqlCommand(sql_detalle, Conn);
                //Instanciando en la tabla usuario_detalle y guardando el ID
                Reader = Comando.ExecuteReader();
                Reader.Read();
                idDetalle = Convert.ToInt32(Reader.GetValue(0));
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
            return idDetalle;
        }

        public Usuario SelectUsuario(String direccion, String password)
        {
            Usuario usuario = null;

            try
            {
                Conn.Open();
                if (!(direccion.Contains("@correoele.com"))) direccion += "@correoele.com";
                //Instanciando en la tabla usuario y guardando el ID
                String sql_usuario = "SELECT * FROM usuario u JOIN usuario_detalle d ON u.iddetalle=d.iddetalle WHERE u.direccion='"+direccion+"' and u.password=HASHBYTES('MD5', '"+password+"');";
                Comando = new SqlCommand(sql_usuario, Conn);
                Reader = Comando.ExecuteReader();
                Reader.Read();
                //Instanciando los datos del registro
                int idUsuario = Convert.ToInt32(Reader["idusuario"].ToString());
                int idDetalle = Convert.ToInt32(Reader["iddetalle"].ToString());
                //Detalle
                String nick = Reader["nick"].ToString();
                String nombre = Reader["nombre"].ToString();
                String apellido = Reader["apellido"].ToString();
                Detalle detalle = new Detalle(nick, nombre, apellido);
                detalle.Iddetalle = idDetalle;
                //Usuario
                usuario = new Usuario(direccion, password, detalle);
                usuario.Idusuario = idUsuario;
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
            return usuario;
        }

        public Usuario SelectUsuario(String direccion)
        {
            Usuario usuario = null;

            try
            {
                Conn.Open();
                if (!(direccion.Contains("@correoele.com"))) direccion += "@correoele.com";
                //Instanciando en la tabla usuario y guardando el ID
                String sql_usuario = "SELECT * FROM usuario u JOIN usuario_detalle d ON u.iddetalle=d.iddetalle WHERE u.direccion='" + direccion + "';";
                Comando = new SqlCommand(sql_usuario, Conn);
                Reader = Comando.ExecuteReader();
                Reader.Read();
                //Instanciando los datos del registro
                int idUsuario = Convert.ToInt32(Reader["idusuario"].ToString());
                int idDetalle = Convert.ToInt32(Reader["iddetalle"].ToString());
                //Detalle
                String nick = Reader["nick"].ToString();
                String nombre = Reader["nombre"].ToString();
                String apellido = Reader["apellido"].ToString();
                String password = Reader["password"].ToString();
                Detalle detalle = new Detalle(nick, nombre, apellido);
                detalle.Iddetalle = idDetalle;
                //Usuario
                usuario = new Usuario(direccion, password, detalle);
                usuario.Idusuario = idUsuario;
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
            return usuario;
        }
    }
}
