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
    public class clsDatosPlantillaTrabajo
    {
        private string cadenaConexion;


        public clsDatosPlantillaTrabajo()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
        }


        public List<clsPlantillaTrabajo> ListarPlantillasTrabajos()
        {
            MySqlConnection con = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("select * from tbl_DetallePlantillaTrabajo", con);

            List<clsPlantillaTrabajo> listaplantillastrabajos = new List<clsPlantillaTrabajo>();

            con.Open();
            MySqlDataReader lector = cmd.ExecuteReader();

            while(lector.Read())
            {
                clsPlantillaTrabajo plantillatrabajo = new clsPlantillaTrabajo();

                plantillatrabajo.Plantillatrabajoid = lector.GetInt32(0);
                plantillatrabajo.Fechatrabajo = lector.GetString(1);
                plantillatrabajo.Empresatrabajo = lector.GetString(2);
                plantillatrabajo.Archivotrabajo = lector.GetString(3);

                plantillatrabajo.Detallerutaid = lector.GetInt32(4);
                plantillatrabajo.Detallegrupotrabajoid = lector.GetInt32(5);
                plantillatrabajo.Usuariosid = lector.GetInt32(6);
                plantillatrabajo.Detalletrabajoid = lector.GetInt32(7);

                listaplantillastrabajos.Add(plantillatrabajo);
            }

            con.Close();

            return listaplantillastrabajos;
        }


        public bool IngresarPlantillaTrabajo(clsPlantillaTrabajo plantillatrabajo)
        {
            MySqlConnection con = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetallePlantillaTrabajo(idtbl_DetallePlantillaTrabajo,fecha_trabajo,empresa_trabajo,archivoplano_trabajo,tbl_DetalleRuta_id,tbl_DetalleGrupoTrabajo_id,tbl_Usuarios_id,tbl_DetalleTrabajo_id)" +
                                                "values(@plantillatrabajoid,@fechatrabajo,@empresatrabajo,@archivoplano,@detallerutaid,@detallegrupotrabajoid,@usuariosid,@detalletrabajoid)");

            cmd.Parameters.Add("@plantillatrabajoid", MySqlDbType.Int32).Value = plantillatrabajo.Plantillatrabajoid;
            cmd.Parameters.Add("@fechatrabajo", MySqlDbType.VarChar).Value = plantillatrabajo.Fechatrabajo;
            cmd.Parameters.Add("@empresatrabajo", MySqlDbType.VarChar).Value = plantillatrabajo.Empresatrabajo;
            cmd.Parameters.Add("@archivoplano", MySqlDbType.VarChar).Value = plantillatrabajo.Archivotrabajo;

            cmd.Parameters.Add("@detallerutaid", MySqlDbType.Int32).Value = plantillatrabajo.Detallerutaid;
            cmd.Parameters.Add("@detallegrupotrabajoid", MySqlDbType.Int32).Value = plantillatrabajo.Detallegrupotrabajoid;
            cmd.Parameters.Add("@usuariosid", MySqlDbType.Int32).Value = plantillatrabajo.Usuariosid;
            cmd.Parameters.Add("@detalletrabajoid", MySqlDbType.Int32).Value = plantillatrabajo.Detalletrabajoid;

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
