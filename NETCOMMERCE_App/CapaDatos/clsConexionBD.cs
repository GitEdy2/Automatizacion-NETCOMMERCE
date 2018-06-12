using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class clsConexionBD
    {
        //public MySqlConnection conBD = new MySqlConnection("protocol = Socket; server=localhost;port=3306;user id = root; persistsecurityinfo=True;database=dbcoordinacion;sslmode=Prefered;certificatestorelocation=None;compress=False;allowuservariables=True;allowzerodatetime=False;Integrated Security = False; treattinyasboolean=False;defaultcommandtimeout=30;connectiontimeout=60");
        
        

        public MySqlConnection ConexionBaseDatos()
        {            
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";           
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";
           

            MySqlConnection conexion = new MySqlConnection(builder.ToString());

            return conexion;
        }


        public bool AbrirConexion()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection conBD = new MySqlConnection(builder.ToString());

            try
            {              
                if (conBD.State == ConnectionState.Closed)
                    conBD.Open();

                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }


        public bool CerrarConexion()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection conBD = new MySqlConnection(builder.ToString());

            try
            {
                if (conBD.State == ConnectionState.Open)

                    conBD.Close();

                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }
}
