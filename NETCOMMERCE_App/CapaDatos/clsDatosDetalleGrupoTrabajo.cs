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
using System.Windows.Forms;

namespace CapaDatos
{
    public class clsDatosDetalleGrupoTrabajo
    {

        public List<clsDetalleGrupoTrabajo> ListarGruposTrabajo(string nombregrupo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("SELECT nombre_grupotrabajo,numero_grupotrabajo,nombre_integrantegrupo,cargo_tipointegrante FROM tbl_DetalleGrupoTrabajo LEFT JOIN tbl_IntegranteGrupo ON tbl_DetalleGrupoTrabajo.tbl_IntegranteGrupo_id = tbl_IntegranteGrupo.idtbl_IntegranteGrupo LEFT JOIN tbl_TipoIntegranteGrupo ON tbl_IntegranteGrupo.tbl_TipoIntegranteGrupo_id = tbl_TipoIntegranteGrupo.idtbl_TipoIntegranteGrupo AND tbl_DetalleGrupoTrabajo.tbl_TipoIntegranteGrupo_id = tbl_TipoIntegranteGrupo.idtbl_TipoIntegranteGrupo AND nombre_grupotrabajo =" +nombregrupo, con);

            List<clsDetalleGrupoTrabajo> listagrupotrabajo = new List<clsDetalleGrupoTrabajo>();


            con.Open();


            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsDetalleGrupoTrabajo grupotrabajo = new clsDetalleGrupoTrabajo();
                clsIntegranteGrupo integrante = new clsIntegranteGrupo();

                grupotrabajo.Nombregrupotrabajo = lector.GetString(0);
                grupotrabajo.Numerogrupotrabajo = lector.GetInt32(1);
                integrante.Nombreintegrantegrupo = lector.GetString(2);
                integrante.Cargotipointegrante = lector.GetString(3);
                

                listagrupotrabajo.Add(grupotrabajo);
            }


            con.Close();

            return listagrupotrabajo;
        }


        public DataTable ListaGruposTrabajoporNumero(int numerogrupo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT nombre_grupotrabajo,numero_grupotrabajo,nombre_integrantegrupo,cargo_tipointegrante FROM tbl_DetalleGrupoTrabajo LEFT JOIN tbl_IntegranteGrupo ON tbl_DetalleGrupoTrabajo.tbl_IntegranteGrupo_id = tbl_IntegranteGrupo.idtbl_IntegranteGrupo LEFT JOIN tbl_TipoIntegranteGrupo ON tbl_IntegranteGrupo.tbl_TipoIntegranteGrupo_id = tbl_TipoIntegranteGrupo.idtbl_TipoIntegranteGrupo AND tbl_DetalleGrupoTrabajo.tbl_TipoIntegranteGrupo_id = tbl_TipoIntegranteGrupo.idtbl_TipoIntegranteGrupo AND numero_grupotrabajo = " + numerogrupo;

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable ListaGruposTrabajo()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT DISTINCT idtbl_GrupoTrabajo,nombre_grupotrabajo FROM tbl_GrupoTrabajo";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
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

            string cmd = "SELECT * FROM tbl_GrupoTrabajo";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable ListaIntegrantesGrupoTrabajo(string nombregrupo)
        {
            DataGridView DataView = new DataGridView();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT nombre_integrantegrupo,cargo_tipointegrante FROM tbl_IntegranteGrupo INNER JOIN tbl_TipoIntegranteGrupo " +
                         "ON idtbl_IntegranteGrupo = tbl_IntegranteGrupo_id AND nombre_grupotrabajo = " + nombregrupo;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            con.Open();

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

            string cmd = "SELECT idtbl_IntegranteGrupo,nombre_integrantegrupo,cargo_tipointegrante " +
                         "FROM tbl_IntegranteGrupo INNER JOIN tbl_TipoIntegranteGrupo " +
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

            string cmd = "SELECT idtbl_IntegranteGrupo,nombre_integrantegrupo,cargo_tipointegrante " +
                         "FROM tbl_IntegranteGrupo INNER JOIN tbl_TipoIntegranteGrupo " +
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

            string cmd = "SELECT idtbl_IntegranteGrupo,nombre_integrantegrupo,cargo_tipointegrante " +
                         "FROM tbl_IntegranteGrupo INNER JOIN tbl_TipoIntegranteGrupo " +
                         "ON tbl_TipoIntegranteGrupo_id = idtbl_TipoIntegranteGrupo AND cargo_tipointegrante = 'CHOFER'";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public bool IngresarGrupoTrabajo(clsDetalleGrupoTrabajo grupotrabajo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("insert into tbl_GrupoTrabajo(nombre_grupotrabajo,numero_grupotrabajo)" +
                                                "values(@nombregrupo,@numerogrupo)", con);

            cmd.Parameters.Add("@nombregrupo", MySqlDbType.VarChar).Value = grupotrabajo.Nombregrupotrabajo;
            cmd.Parameters.Add("@numerogrupo", MySqlDbType.Int32).Value = grupotrabajo.Numerogrupotrabajo;

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

            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleGrupoTrabajo(tbl_GrupoTrabajo_id,tbl_IntegranteGrupo_id,tbl_TipoIntegranteGrupo_id)" +
                                                "values(@grupoid,@integrantegrupoid,@tipointegranteid)", con);


            cmd.Parameters.Add("@grupoid", MySqlDbType.Int32).Value = grupotrabajo.Idgrupotrabajo;
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

            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleGrupoTrabajo(tbl_GrupoTrabajo_id,tbl_IntegranteGrupo_id,tbl_TipoIntegranteGrupo_id)" +
                                                "values(@grupoid,@integrantegrupoid,@tipointegranteid)", con);

            
            cmd.Parameters.Add("@grupoid", MySqlDbType.Int32).Value = grupotrabajo.Idgrupotrabajo;
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

            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleGrupoTrabajo(tbl_GrupoTrabajo_id,tbl_IntegranteGrupo_id,tbl_TipoIntegranteGrupo_id)" +
                                                "values(@grupoid,@integrantegrupoid,@tipointegranteid)", con);

           
            cmd.Parameters.Add("@grupoid", MySqlDbType.Int32).Value = grupotrabajo.Idgrupotrabajo;
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

            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleGrupoTrabajo(tbl_GrupoTrabajo_id,tbl_IntegranteGrupo_id,tbl_TipoIntegranteGrupo_id)" +
                                                "values(@grupoid,@integrantegrupoid,@tipointegranteid)", con);

           
            cmd.Parameters.Add("@grupoid", MySqlDbType.Int32).Value = grupotrabajo.Idgrupotrabajo;
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
