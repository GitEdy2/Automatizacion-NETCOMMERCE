using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using CapaNegocios;
using System.Web;
using System.Configuration;
using System.Data;

namespace CapaDatos
{
    public class clsDatosUsuarios
    {
        //MySqlConnection cadenaConexion = new MySqlConnection();

        /*      
        public clsDatosUsuarios()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["protocol=Socket;server=localhost;port=3306;user id=root;persistsecurityinfo=True;database=dbcoordinacion;sslmode=Prefered;certificatestorelocation=None;compress=False;allowuservariables=True;allowzerodatetime=False;Integrated Security=False;treattinyasboolean=False;defaultcommandtimeout=30;connectiontimeout=60"].ConnectionString;
        }
       */
        clsConexionBD conBD = new clsConexionBD();


        public List<clsUsuarios> ListarUsuarios()
        {
            //MySqlConnection con = new MySqlConnection(conBD);
            MySqlCommand cmd = new MySqlCommand("select * from tbl_Usuarios", conBD.ConexionBaseDatos());

            List<clsUsuarios> listaUsuarios = new List<clsUsuarios>();

            conBD.AbrirConexion();
            conBD.ConexionBaseDatos().Open();

            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsUsuarios usuario = new clsUsuarios();

                usuario.IdUsuario = lector.GetInt32(0);
                usuario.Nombreusuario = lector.GetString(1);
                usuario.Passwordusuario = lector.GetString(2);
                usuario.Rolempresa = lector.GetString(3);           
                usuario.Fechaingresoregistro = lector.GetDateTime(4);

                listaUsuarios.Add(usuario);
            }

            conBD.CerrarConexion();
            conBD.ConexionBaseDatos().Close();

            return listaUsuarios;
        }



        public bool IngresarUsuario(clsUsuarios Usuario)
        {
            
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";            

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("insert into tbl_Usuarios(nombre_usuario,password_usuario,rolempresa_usuario,fecharegistro_usuario)" +
                                                "values(@nombreusuario,@passwordusuario,@rolempresa,@registroentrada)", con);

            //cmd.Parameters.Add("@usuarioid", MySqlDbType.Int32).Value = Usuario.IdUsuario;
            cmd.Parameters.Add("@nombreusuario", MySqlDbType.VarChar).Value = Usuario.Nombreusuario;
            cmd.Parameters.Add("@passwordusuario", MySqlDbType.VarChar).Value = Usuario.Passwordusuario;
            cmd.Parameters.Add("@rolempresa", MySqlDbType.VarChar).Value = Usuario.Rolempresa;
            cmd.Parameters.AddWithValue("@registroentrada", DateTime.UtcNow).Value = Usuario.Fechaingresoregistro;


            con.Open();
            //conBD.AbrirConexion();
            //conBD.ConexionBaseDatos().Open();

            int exito = cmd.ExecuteNonQuery();

            if (exito == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }


        /*
        public bool IngresarFechaRegistro (clsUsuarios fecharegistro)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_usuarios(fecharegistro_usuario) VALUES(NOW())", con);

            con.Open();
            //conBD.AbrirConexion();
            //conBD.ConexionBaseDatos().Open();

            int exito = cmd.ExecuteNonQuery();

            if (exito == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */


        public int Autenticar(String nombreusuario, String password, String tipousuario)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            int resultado = -1;

            con.Open();
            //conBD.AbrirConexion();
            //conBD.ConexionBaseDatos().Open();

            MySqlCommand comando = new MySqlCommand(string.Format(
                "select idtbl_Usuarios,nombre_usuario,password_usuario,rolempresa_usuario from tbl_Usuarios" +
                "where nombre_usuario = '"+ nombreusuario +"' and password_usuario = '"+ password +"' and rolempresa_usuario = '"+ tipousuario +"'"), con);

            MySqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                resultado = 50;
            }

            con.Close();
            //conBD.CerrarConexion();
            //conBD.ConexionBaseDatos().Close();

            return resultado;
        }

    }
}
