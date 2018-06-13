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
        //private string cadenaConexion;

        /*
        public clsDatosIntegranteGrupo()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["protocol=Socket;server=localhost;port=3306;user id=root;persistsecurityinfo=True;database=dbcoordinacion;sslmode=Prefered;certificatestorelocation=None;compress=False;allowuservariables=True;allowzerodatetime=False;Integrated Security=False;treattinyasboolean=False;defaultcommandtimeout=30;connectiontimeout=60"].ConnectionString;
        }
        */

        clsConexionBD conBD = new clsConexionBD();

        public List<clsIntegranteGrupo> ListarIntegrantesGrupo()
        {
            //MySqlConnection con = new MySqlConnection(cadenaConexion);

            MySqlCommand cmd = new MySqlCommand("select * from tbl_IntegranteGrupo", conBD.ConexionBaseDatos());

            List<clsIntegranteGrupo> listaintegrantes = new List<clsIntegranteGrupo>();


            conBD.AbrirConexion();
            conBD.ConexionBaseDatos().Close();
            //con.Open();


            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsIntegranteGrupo integrante = new clsIntegranteGrupo();

                integrante.Idintegrantegrupo = lector.GetInt32(0);
                integrante.Nombreintegrantegrupo = lector.GetString(1);

                integrante.Idtipointegrante = lector.GetInt32(2);

                listaintegrantes.Add(integrante);              
            }

            conBD.CerrarConexion();
            conBD.ConexionBaseDatos().Close();
            //con.Close();

            return listaintegrantes;
        }


        public bool IngresarTipoIntegrante (clsIntegranteGrupo tipointegrante)
        {
            //MySqlConnection con = new MySqlConnection(cadenaConexion);

            MySqlCommand cmd = new MySqlCommand("insert into tbl_TipoIntegrante(idtbl_TipoIntegrante,descripcion_tipointegrante)" +
                                                "values(@tipointegranteid,@descripciontipointegrante)", conBD.ConexionBaseDatos());

            cmd.Parameters.Add("@tipointegranteid", MySqlDbType.Int32).Value = tipointegrante.Idtipointegrante;
            cmd.Parameters.Add("@descripciontipointegrante", MySqlDbType.VarChar).Value = tipointegrante.Descripciontipointegrante;

            conBD.AbrirConexion();
            conBD.ConexionBaseDatos().Open();
            //con.Open();

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
            //MySqlConnection con = new MySqlConnection(cadenaConexion);

            MySqlCommand cmd = new MySqlCommand("insert into tbl_IntegranteGrupo(idtbl_IntegranteGrupo,nombre_integrantegrupo,tbl_TipoIntegranteGrupo_id)" +
                                                "values(@integranteid,@nombreintegrante,@tipointegrante)", conBD.ConexionBaseDatos());

            cmd.Parameters.Add("@integranteid", MySqlDbType.Int32).Value = integrante.Idintegrantegrupo;
            cmd.Parameters.Add("@nombreintegrante", MySqlDbType.VarChar).Value = integrante.Nombreintegrantegrupo;

            cmd.Parameters.Add("@tipointegrante", MySqlDbType.Int32).Value = integrante.Idtipointegrante;

            conBD.AbrirConexion();
            conBD.ConexionBaseDatos().Open();
            //con.Open();

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
