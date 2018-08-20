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

        public List<Contacto> selectContactos(int idusuario)
        {
            List <Contacto> contactos = null;
            try
            {
                Conn.Open();
                //Instanciando en la tabla usuario y guardando el ID
                String sql_usuario = "SELECT * FROM contacto c JOIN usuario_detalle d ON c.iddetalle_contacto = d.iddetalle WHERE c.idusuario="+idusuario+";";
                Comando = new SqlCommand(sql_usuario, Conn);
                Reader = Comando.ExecuteReader();
                //Instanciando los datos del registro
                contactos = new List<Contacto>();//Inicializando lista
                Detalle detalle = new Detalle();
                Contacto contacto = new Contacto();
                while (Reader.Read())
                {
                    detalle.Iddetalle = Convert.ToInt32(Reader["iddetalle_contacto"].ToString());
                    detalle.Nick = Reader["nick"].ToString();
                    detalle.Nombre = Reader["apellido"].ToString();
                    contacto.Aceptado = Convert.ToBoolean(Reader["aceptado"].ToString());
                    contacto.Fecha_agregado = Convert.ToDateTime(Reader["fecha_agregado"].ToString());
                    contacto.Detallecontacto = detalle;
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

        public int InsertContacto(Contacto contacto)
        {
            int insertCorrecto = -1; //Falso por defecto
            try
            {
                Conn.Open();
                String sql_detalle = "INSERT INTO contacto (idusuario, iddetalle_usuario, iddetalle_contacto) VALUES ("+contacto.Usuario.Idusuario+", "+contacto.Usuario.Detalle.Iddetalle+", " + contacto.Detallecontacto.Iddetalle + ") SELECT SCOPE_IDENTITY();";
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

    }
}
