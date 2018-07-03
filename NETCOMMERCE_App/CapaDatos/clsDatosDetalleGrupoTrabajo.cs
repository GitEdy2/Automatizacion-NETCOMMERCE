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
    public class clsDatosDetalleGrupoTrabajo
    {

        public List<clsDetalleGrupoTrabajo> ListarGruposTrabajo()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("select * from tbl_DetalleGrupoTrabajo", con);

            List<clsDetalleGrupoTrabajo> listagrupotrabajo = new List<clsDetalleGrupoTrabajo>();


            con.Open();


            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsDetalleGrupoTrabajo grupotrabajo = new clsDetalleGrupoTrabajo();

                grupotrabajo.Nombregrupotrabajo = lector.GetString(0);
                grupotrabajo.Numerogrupotrabajo = lector.GetInt32(1);
                grupotrabajo.Idintegrantegrupo = lector.GetInt32(2);

                listagrupotrabajo.Add(grupotrabajo);
            }


            con.Close();

            return listagrupotrabajo;
        }


        public DataTable ListaElementosGrupoTrabajo()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT nombre_grupotrabajo,numero_grupotrabajo FROM tbl_DetalleGrupoTrabajo";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable ListaLinieros()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT idtbl_IntegranteGrupo,nombre_integrantegrupo,cargo_tipointegrante" +
                         "FROM tbl_IntegranteGrupo INNER JOIN tbl_TipoIntegranteGrupo" +
                         "ON tbl_TipoIntegranteGrupo_id = idtbl_TipoIntegranteGrupo AND cargo_tipointegrante = 'LINIERO'";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable ListaJefeGrupo()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT idtbl_IntegranteGrupo,nombre_integrantegrupo,cargo_tipointegrante " +
                         "FROM tbl_IntegranteGrupo INNER JOIN tbl_TipoIntegranteGrupo " +
                         "ON tbl_TipoIntegranteGrupo_id = idtbl_TipoIntegranteGrupo AND cargo_tipointegrante = 'JEFE DE GRUPO'";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable ListaAyudantes()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT idtbl_IntegranteGrupo,nombre_integrantegrupo,cargo_tipointegrante" +
                         "FROM tbl_IntegranteGrupo INNER JOIN tbl_TipoIntegranteGrupo" +
                         "ON tbl_TipoIntegranteGrupo_id = idtbl_TipoIntegranteGrupo AND cargo_tipointegrante = 'AYUDANTE'";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable ListaChofer()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT idtbl_IntegranteGrupo,nombre_integrantegrupo,cargo_tipointegrante" +
                         "FROM tbl_IntegranteGrupo INNER JOIN tbl_TipoIntegranteGrupo" +
                         "ON tbl_TipoIntegranteGrupo_id = idtbl_TipoIntegranteGrupo AND cargo_tipointegrante = 'CHOFER'";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public bool IngresarJefeGrupoTrabajo(clsDetalleGrupoTrabajo grupotrabajo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleGrupoTrabajo(nombre_grupotrabajo,numero_grupotrabajo,tbl_IntegranteGrupo_id,tbl_TipoIntegranteGrupo_id)" +
                                                "values(@nombregrupotrabajo,@numerogrupotrabajo,@integrantegrupoid,@tipointegranteid)", con);


            cmd.Parameters.Add("@nombregrupotrabajo", MySqlDbType.VarChar).Value = grupotrabajo.Nombregrupotrabajo;
            cmd.Parameters.Add("@numerogrupotrabajo", MySqlDbType.Int32).Value = grupotrabajo.Numerogrupotrabajo;
            cmd.Parameters.Add("@integrantegrupoid", MySqlDbType.Int32).Value = grupotrabajo.Idintegrantegrupo;
            cmd.Parameters.AddWithValue("@tipointegranteid", 1);

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

        public bool IngresarLinieroGrupoTrabajo(clsDetalleGrupoTrabajo grupotrabajo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleGrupoTrabajo(nombre_grupotrabajo,numero_grupotrabajo,tbl_IntegranteGrupo_id,tbl_TipoIntegranteGrupo_id)" +
                                                "values(@nombregrupotrabajo,@numerogrupotrabajo,@integrantegrupoid,@tipointegranteid)", con);


            cmd.Parameters.Add("@nombregrupotrabajo", MySqlDbType.VarChar).Value = grupotrabajo.Nombregrupotrabajo;
            cmd.Parameters.Add("@numerogrupotrabajo", MySqlDbType.Int32).Value = grupotrabajo.Numerogrupotrabajo;
            cmd.Parameters.Add("@integrantegrupoid", MySqlDbType.Int32).Value = grupotrabajo.Idintegrantegrupo;
            cmd.Parameters.AddWithValue("@tipointegranteid", 2);

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

        public bool IngresarAyudanteGrupoTrabajo(clsDetalleGrupoTrabajo grupotrabajo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleGrupoTrabajo(nombre_grupotrabajo,numero_grupotrabajo,tbl_IntegranteGrupo_id,tbl_TipoIntegranteGrupo_id)" +
                                                "values(@nombregrupotrabajo,@numerogrupotrabajo,@integrantegrupoid,@tipointegranteid)", con);


            cmd.Parameters.Add("@nombregrupotrabajo", MySqlDbType.VarChar).Value = grupotrabajo.Nombregrupotrabajo;
            cmd.Parameters.Add("@numerogrupotrabajo", MySqlDbType.Int32).Value = grupotrabajo.Numerogrupotrabajo;
            cmd.Parameters.Add("@integrantegrupoid", MySqlDbType.Int32).Value = grupotrabajo.Idintegrantegrupo;
            cmd.Parameters.AddWithValue("@tipointegranteid", 3);

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


        public bool IngresarChoferGrupoTrabajo(clsDetalleGrupoTrabajo grupotrabajo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleGrupoTrabajo(nombre_grupotrabajo,numero_grupotrabajo,tbl_IntegranteGrupo_id,tbl_TipoIntegranteGrupo_id)" +
                                                "values(@nombregrupotrabajo,@numerogrupotrabajo,@integrantegrupoid,@tipointegranteid)", con);


            cmd.Parameters.Add("@nombregrupotrabajo", MySqlDbType.VarChar).Value = grupotrabajo.Nombregrupotrabajo;
            cmd.Parameters.Add("@numerogrupotrabajo", MySqlDbType.Int32).Value = grupotrabajo.Numerogrupotrabajo;
            cmd.Parameters.Add("@integrantegrupoid", MySqlDbType.Int32).Value = grupotrabajo.Idintegrantegrupo;
            cmd.Parameters.AddWithValue("@tipointegranteid", 4);

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
