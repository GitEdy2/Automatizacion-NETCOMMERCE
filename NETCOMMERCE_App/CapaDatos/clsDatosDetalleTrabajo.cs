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
        private string cadenaConexion;


        public clsDatosDetalleTrabajo()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
        }


        public List<clsDetalleTrabajo> ListarTrabajos()
        {
            MySqlConnection con = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("select * from tbl_DetalleTrabajo", con);

            List<clsDetalleTrabajo> listatrabajos = new List<clsDetalleTrabajo>();

            con.Open();
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

            con.Close();

            return listatrabajos;
        }

        public List<clsDetalleTrabajo> ListarTipoTrabajos()
        {
            MySqlConnection con = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("select * from tbl_TipoTrabajo", con);

            List<clsDetalleTrabajo> listatipotrabajos = new List<clsDetalleTrabajo>();

            con.Open();
            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsDetalleTrabajo tipotrabajo = new clsDetalleTrabajo();

                tipotrabajo.Tipotrabajoid = lector.GetInt32(0);
                tipotrabajo.Descripcion1tipotrabajo = lector.GetString(1);
                tipotrabajo.Descripcion2tipotrabajo = lector.GetString(2);

                listatipotrabajos.Add(tipotrabajo);
            }

            con.Close();

            return listatipotrabajos;
        }


        public List<clsDetalleTrabajo> ListarFibra()
        {
            MySqlConnection con = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("select * from tbl_Fibra", con);

            List<clsDetalleTrabajo> listafibra = new List<clsDetalleTrabajo>();

            con.Open();
            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsDetalleTrabajo fibra = new clsDetalleTrabajo();

                fibra.Fibraid = lector.GetInt32(0);
                fibra.Detallefibra = lector.GetString(1);
                fibra.Metrosfibra = lector.GetInt32(2);

                listafibra.Add(fibra);
            }

            con.Close();

            return listafibra;
        }


        public List<clsDetalleTrabajo> ListarRetenidas()
        {
            MySqlConnection con = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("select * from tbl_KitsRetenidas", con);

            List<clsDetalleTrabajo> listaretenidas = new List<clsDetalleTrabajo>();

            con.Open();
            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsDetalleTrabajo retenidas = new clsDetalleTrabajo();

                retenidas.Retenidasid = lector.GetInt32(0);
                retenidas.Detalleretenidas = lector.GetString(1);
                retenidas.Numeroretenidas = lector.GetInt32(2);

                listaretenidas.Add(retenidas);
            }

            con.Close();

            return listaretenidas;
        }


        public List<clsDetalleTrabajo> ListarPostes()
        {
            MySqlConnection con = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("select * from tbl_KitsRetenidas", con);

            List<clsDetalleTrabajo> listarpostes = new List<clsDetalleTrabajo>();

            con.Open();
            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsDetalleTrabajo postes = new clsDetalleTrabajo();

                postes.Postesid = lector.GetInt32(0);
                postes.Detallepostes = lector.GetString(1);
                postes.Numeropostes = lector.GetInt32(2);

                listarpostes.Add(postes);
            }

            con.Close();

            return listarpostes;
        }


        public bool IngresarDetalleTrabajo(clsDetalleTrabajo trabajo)
        {
            MySqlConnection con = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleTrabajo", con);
        }


        

    }
}
