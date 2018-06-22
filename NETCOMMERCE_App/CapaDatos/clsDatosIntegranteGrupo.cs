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
    public class clsDatosIntegranteGrupo
    {
        
        public List<clsIntegranteGrupo> ListarIntegrantesGrupo()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("select * from tbl_IntegranteGrupo", con);

            List<clsIntegranteGrupo> listaintegrantes = new List<clsIntegranteGrupo>();

          
            con.Open();


            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsIntegranteGrupo integrante = new clsIntegranteGrupo();

                integrante.Idintegrantegrupo = lector.GetInt32(0);
                integrante.Idtipointegrante = lector.GetInt32(1);
                integrante.Nombreintegrantegrupo = lector.GetString(2);
                integrante.Empresaintegrantegrupo = lector.GetString(3);

               
                listaintegrantes.Add(integrante);              
            }


            con.Close();

            return listaintegrantes;
        }


        public bool IngresarTipoIntegrante (clsIntegranteGrupo tipointegrante)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("insert into tbl_TipoIntegrante(descripcion_tipointegrante)" +
                                                "values(@descripciontipointegrante)", con);

            cmd.Parameters.Add("@descripciontipointegrante", MySqlDbType.VarChar).Value = tipointegrante.Descripciontipointegrante;

           
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


        public bool IngresarIntegranteGrupo (clsIntegranteGrupo integrante)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("insert into tbl_IntegranteGrupo(tbl_TipoIntegranteGrupo_id,nombre_integrantegrupo,empresa_integrantegrupo)" +
                                                "values(@tipointegrante,@nombreintegrante,@empresaintegrante)", con);


            cmd.Parameters.Add("@tipointegrante", MySqlDbType.Int32).Value = integrante.Idtipointegrante;
            cmd.Parameters.Add("@nombreintegrante", MySqlDbType.VarChar).Value = integrante.Nombreintegrantegrupo;
            cmd.Parameters.Add("@empresaintegrante", MySqlDbType.VarChar).Value = integrante.Empresaintegrantegrupo;


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
