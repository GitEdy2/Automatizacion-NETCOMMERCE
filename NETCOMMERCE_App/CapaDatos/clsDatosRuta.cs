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
    public class clsDatosRuta
    {
        //private string cadenaConexion;

        /*
        public clsDatosRuta()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["protocol=Socket;server=localhost;port=3306;user id=root;persistsecurityinfo=True;database=dbcoordinacion;sslmode=Prefered;certificatestorelocation=None;compress=False;allowuservariables=True;allowzerodatetime=False;Integrated Security=False;treattinyasboolean=False;defaultcommandtimeout=30;connectiontimeout=60"].ConnectionString;
        }
        */

        clsConexionBD conBD = new clsConexionBD();


        public List<clsRuta> ListarRutas()
        {
            //MySqlConnection con = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand("select * from tbl_DetalleRuta", conBD.ConexionBaseDatos());
      
            List<clsRuta> listaruta = new List<clsRuta>();

            conBD.AbrirConexion();
            conBD.ConexionBaseDatos().Open();


            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsRuta ruta = new clsRuta();

                ruta.Idruta = lector.GetInt32(0);
                ruta.Nombreruta = lector.GetString(1);
                ruta.Clienteruta = lector.GetString(2);
                ruta.Provinciaruta = lector.GetString(3);
                ruta.Cantonruta = lector.GetString(4);
                ruta.Referenciaruta = lector.GetString(5);

                listaruta.Add(ruta);
            }

            conBD.CerrarConexion();
            conBD.ConexionBaseDatos().Close();

            return listaruta;          
        }


        public bool IngresarRuta(clsRuta Ruta)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());


            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleRuta(nombre_ruta,cliente_ruta,provincia_ruta,canton_ruta,parroquia_ruta,referencia_ruta)" +
                                                "values(@nombreruta,@clienteruta,@provinciaruta,@cantonruta,@parroquiaruta,@referenciaruta)", con);

            //cmd.Parameters.Add("@idruta", MySqlDbType.Int32).Value = Ruta.Idruta;
            cmd.Parameters.Add("@nombreruta", MySqlDbType.VarChar).Value = Ruta.Nombreruta;
            cmd.Parameters.Add("@clienteruta", MySqlDbType.VarChar).Value = Ruta.Clienteruta;
            cmd.Parameters.Add("@provinciaruta", MySqlDbType.VarChar).Value = Ruta.Provinciaruta;
            cmd.Parameters.Add("@cantonruta", MySqlDbType.VarChar).Value = Ruta.Cantonruta;
            cmd.Parameters.Add("@parroquiaruta", MySqlDbType.VarChar).Value = Ruta.Parroquiaruta;
            cmd.Parameters.Add("@referenciaruta", MySqlDbType.VarChar).Value = Ruta.Referenciaruta;

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


        public DataRow BuscarCliente (string nombreruta)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());


            MySqlDataAdapter da;

            DataSet ds = new DataSet();

            try
            {
                string mysql = "select nombreruta,cliente_ruta,provincia_ruta,canton_ruta,parroquia_ruta from tbl_DetalleRuta where nombre_ruta =" +nombreruta;
                da = new MySqlDataAdapter(mysql, conBD.ConexionBaseDatos());

                da.Fill(ds, "tbl_DetalleRuta");
                da.FillSchema(ds.Tables[0], SchemaType.Mapped);

                DataRow fila = ds.Tables[0].Rows.Find(nombreruta);

                return fila;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conBD.ConexionBaseDatos().Close();
                conBD.CerrarConexion();
                //conBD.Close();
            }
        }
    }
}
