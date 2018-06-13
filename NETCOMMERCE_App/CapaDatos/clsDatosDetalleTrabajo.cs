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
    public class clsDatosDetalleTrabajo
    {
        //private string cadenaConexion;

        /*
        public clsDatosDetalleTrabajo()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["protocol=Socket;server=localhost;port=3306;user id=root;persistsecurityinfo=True;database=dbcoordinacion;sslmode=Prefered;certificatestorelocation=None;compress=False;allowuservariables=True;allowzerodatetime=False;Integrated Security=False;treattinyasboolean=False;defaultcommandtimeout=30;connectiontimeout=60"].ConnectionString;
        }
        */

        clsConexionBD conBD = new clsConexionBD();


        public List<clsDetalleTrabajo> ListarTrabajos()
        {
            //MySqlConnection con = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("select * from tbl_DetalleTrabajo", conBD.ConexionBaseDatos());

            List<clsDetalleTrabajo> listatrabajos = new List<clsDetalleTrabajo>();

            conBD.AbrirConexion();
            conBD.ConexionBaseDatos().Open();
            //con.Open();


            MySqlDataReader lector = cmd.ExecuteReader();

            while(lector.Read())
            {
                clsDetalleTrabajo trabajo = new clsDetalleTrabajo();

                trabajo.Detalletrabajoid = lector.GetInt32(0);
                trabajo.Fibraid = lector.GetInt32(1);
                trabajo.Retenidasid = lector.GetInt32(2);
                trabajo.Postesid = lector.GetInt32(3);
                trabajo.Tipotrabajoid = lector.GetInt32(4);

                listatrabajos.Add(trabajo);                
            }

            conBD.CerrarConexion();
            conBD.ConexionBaseDatos().Close();
            //con.Close();

            return listatrabajos;
        }


        public List<clsDetalleTrabajo> ListarTipoTrabajos()
        {
            //MySqlConnection con = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("select * from tbl_TipoTrabajo", conBD.ConexionBaseDatos());

            List<clsDetalleTrabajo> listatipotrabajos = new List<clsDetalleTrabajo>();


            conBD.AbrirConexion();
            conBD.ConexionBaseDatos().Open();
            //con.Open();


            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsDetalleTrabajo tipotrabajo = new clsDetalleTrabajo();

                tipotrabajo.Tipotrabajoid = lector.GetInt32(0);
                tipotrabajo.Descripcion1tipotrabajo = lector.GetString(1);
                tipotrabajo.Descripcion2tipotrabajo = lector.GetString(2);

                listatipotrabajos.Add(tipotrabajo);
            }

            conBD.CerrarConexion();
            conBD.ConexionBaseDatos().Close();
            //con.Close();

            return listatipotrabajos;
        }


        public List<clsDetalleTrabajo> ListarFibra()
        {
            //MySqlConnection con = new MySqlConnection(cadenaConexion);

            MySqlCommand cmd = new MySqlCommand("select * from tbl_Fibra", conBD.ConexionBaseDatos());

            List<clsDetalleTrabajo> listafibra = new List<clsDetalleTrabajo>();

            conBD.AbrirConexion();
            conBD.ConexionBaseDatos().Open();
            //con.Open();

            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsDetalleTrabajo fibra = new clsDetalleTrabajo();

                fibra.Fibraid = lector.GetInt32(0);
                fibra.Detallefibra = lector.GetString(1);
                fibra.Metrosfibra = lector.GetInt32(2);

                listafibra.Add(fibra);
            }

            conBD.CerrarConexion();
            conBD.ConexionBaseDatos().Close();
            //con.Close();

            return listafibra;
        }


        public List<clsDetalleTrabajo> ListarRetenidas()
        {
            //MySqlConnection con = new MySqlConnection(cadenaConexion);

            MySqlCommand cmd = new MySqlCommand("select * from tbl_KitsRetenidas", conBD.ConexionBaseDatos());

            List<clsDetalleTrabajo> listaretenidas = new List<clsDetalleTrabajo>();

            conBD.AbrirConexion();
            conBD.ConexionBaseDatos().Open();
            //con.Open();

            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsDetalleTrabajo retenidas = new clsDetalleTrabajo();

                retenidas.Retenidasid = lector.GetInt32(0);
                retenidas.Detalleretenidas = lector.GetString(1);
                retenidas.Numeroretenidas = lector.GetInt32(2);

                listaretenidas.Add(retenidas);
            }

            conBD.CerrarConexion();
            conBD.ConexionBaseDatos().Close();
            //con.Close();

            return listaretenidas;
        }


        public List<clsDetalleTrabajo> ListarPostes()
        {
            //MySqlConnection con = new MySqlConnection(cadenaConexion);

            MySqlCommand cmd = new MySqlCommand("select * from tbl_KitsRetenidas", conBD.ConexionBaseDatos());

            List<clsDetalleTrabajo> listarpostes = new List<clsDetalleTrabajo>();

            conBD.AbrirConexion();
            conBD.ConexionBaseDatos().Open();
            //con.Open();

            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsDetalleTrabajo postes = new clsDetalleTrabajo();

                postes.Postesid = lector.GetInt32(0);
                postes.Detallepostes = lector.GetString(1);
                postes.Numeropostes = lector.GetInt32(2);

                listarpostes.Add(postes);
            }

            conBD.CerrarConexion();
            conBD.ConexionBaseDatos().Close();
            //con.Close();

            return listarpostes;
        }


        public bool IngresarDetalleTrabajo(clsDetalleTrabajo trabajo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());


            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleTrabajo(idtbl_DetalleTrabajo,tbl_Fibra_id,tbl_KitsRetenida_id,tbl_Postes_id,tbl_TipoTrabajo_id)" +
                                                "values(@trabajoid,@fibraid,@retenidasid,@postesid,@tipotrabajoid)", con);

            cmd.Parameters.Add("@trabajoid", MySqlDbType.Int32).Value = trabajo.Detalletrabajoid;
            cmd.Parameters.Add("@fibraid", MySqlDbType.Int32).Value = trabajo.Fibraid;
            cmd.Parameters.Add("@retenidasid", MySqlDbType.Int32).Value = trabajo.Retenidasid;
            cmd.Parameters.Add("@postesid", MySqlDbType.Int32).Value = trabajo.Postesid;
            cmd.Parameters.Add("@tipotrabajoid", MySqlDbType.Int32).Value = trabajo.Tipotrabajoid;

            con.Open();

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


        public bool IngresarTipoTrabajo(clsDetalleTrabajo tipotrabajo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());


            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleTrabajo(idtbl_TipoTrabajo,descripcion_tipotrabajo,descripcion2_tipotrabajo)" +
                                                "values(@tipotrabajoid,@descripcion1,@descripcion2)", con);

            cmd.Parameters.Add("@tipotrabajoid", MySqlDbType.Int32).Value = tipotrabajo.Tipotrabajoid;
            cmd.Parameters.Add("@descripcion1", MySqlDbType.VarChar).Value = tipotrabajo.Descripcion1tipotrabajo;
            cmd.Parameters.Add("@descripcion2", MySqlDbType.VarChar).Value = tipotrabajo.Descripcion2tipotrabajo;
            
            con.Open();

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


        public bool IngresarFibra(clsDetalleTrabajo fibra)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());


            MySqlCommand cmd = new MySqlCommand("insert into tbl_Fibra(idtbl_Fibra,detalle_fibra,metros_fibra)" +
                                                "values(@fibraid,@detallefibra,@metrosfibra)", con);

            cmd.Parameters.Add("@fibraid", MySqlDbType.Int32).Value = fibra.Fibraid;
            cmd.Parameters.Add("@detallefibra", MySqlDbType.VarChar).Value = fibra.Detallefibra;
            cmd.Parameters.Add("@metrosfibra", MySqlDbType.Int32).Value = fibra.Metrosfibra;

            con.Open();

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

        public bool IngresarPostes(clsDetalleTrabajo postes)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());


            MySqlCommand cmd = new MySqlCommand("insert into tbl_Postes(idtbl_Postes,detalle_postes,numero_postes)" +
                                                "values(@postesid,@detallepostes,@numeropostes)", con);

            cmd.Parameters.Add("@postesid", MySqlDbType.Int32).Value = postes.Postesid;
            cmd.Parameters.Add("@detallepostes", MySqlDbType.VarChar).Value = postes.Detallepostes;
            cmd.Parameters.Add("@numeropostes", MySqlDbType.Int32).Value = postes.Numeropostes;


            con.Open();

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


        public bool IngresarRetenidas(clsDetalleTrabajo retenidas)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());


            MySqlCommand cmd = new MySqlCommand("insert into tbl_KitsRetenida(idtbl_KitsRetenida,detalle_retenidas,numero_retenidas)" +
                                                "values(@retenidasid,@detalleretenidas,@numeroretenidas)", con);

            cmd.Parameters.Add("@retenidasid", MySqlDbType.Int32).Value = retenidas.Retenidasid;
            cmd.Parameters.Add("@detalleretenidas", MySqlDbType.VarChar).Value = retenidas.Detalleretenidas;
            cmd.Parameters.Add("@numeroretenidas", MySqlDbType.Int32).Value = retenidas.Numeroretenidas;


            con.Open();

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












    }
}
