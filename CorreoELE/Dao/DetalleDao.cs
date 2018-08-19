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
    public class DetalleDao
    {
        private String conexion;
        private SqlConnection conn;
        private SqlCommand comando;
        private SqlDataReader reader;

        public DetalleDao()
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

    }
}
