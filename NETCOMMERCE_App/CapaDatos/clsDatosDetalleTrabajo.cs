﻿using System;
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
        
        public List<clsDetalleTrabajo> ListarTrabajos()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());


            MySqlCommand cmd = new MySqlCommand("select * from tbl_DetalleTrabajo", con);

            List<clsDetalleTrabajo> listatrabajos = new List<clsDetalleTrabajo>();


            con.Open();


            MySqlDataReader lector = cmd.ExecuteReader();

            while(lector.Read())
            {
                clsDetalleTrabajo trabajo = new clsDetalleTrabajo();

                trabajo.Detalletrabajoid = lector.GetInt32(0);
                trabajo.Codigotrabajo = lector.GetString(1);
                trabajo.Fibraid = lector.GetInt32(2);
                trabajo.Retenidasid = lector.GetInt32(3);
                trabajo.Postesid = lector.GetInt32(4);
                trabajo.Tipotrabajoid = lector.GetInt32(5);

                listatrabajos.Add(trabajo);                
            }

           
            con.Close();

            return listatrabajos;
        }


        public List<clsDetalleTrabajo> ListarTipoTrabajos()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());


            MySqlCommand cmd = new MySqlCommand("select * from tbl_TipoTrabajo", con);

            List<clsDetalleTrabajo> listatipotrabajos = new List<clsDetalleTrabajo>();

          
            con.Open();


            MySqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                clsDetalleTrabajo tipotrabajo = new clsDetalleTrabajo();

                tipotrabajo.Tipotrabajoid = lector.GetInt32(0);
                tipotrabajo.Identificadortipotrabajo = lector.GetString(1);
                tipotrabajo.Descripciontipotrabajo = lector.GetString(2);

                listatipotrabajos.Add(tipotrabajo);
            }

            
            con.Close();

            return listatipotrabajos;
        }


        public DataTable ListaTrabajosporCodigo()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT idtbl_DetalleTrabajo,codigo_trabajo FROM tbl_DetalleTrabajo";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable ListaFibra()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT idtbl_Fibra,detalle_fibra FROM tbl_Fibra";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable ListaRetenidas()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT idtbl_KitsRetenida,detalle_retenidas FROM tbl_KitsRetenida";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable ListaPostes()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT idtbl_Postes,detalle_postes FROM tbl_Postes";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable ListaTipoTrabajos()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            string cmd = "SELECT idtbl_TipoTrabajo,identificador_tipotrabajo FROM tbl_TipoTrabajo";

            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
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


            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleTrabajo(codigo_trabajo,tbl_tipotrabajo_id,tbl_Fibra_id,tbl_KitsRetenida_id,tbl_Postes_id)" +
                                                "values(@tipotrabajoid,@fibraid,@retenidasid,@postesid)", con);


            cmd.Parameters.Add("@codigotrabajo", MySqlDbType.VarChar).Value = trabajo.Codigotrabajo;
            cmd.Parameters.Add("@tipotrabajoid", MySqlDbType.Int32).Value = trabajo.Tipotrabajoid;
            cmd.Parameters.Add("@fibraid", MySqlDbType.Int32).Value = trabajo.Fibraid;
            cmd.Parameters.Add("@retenidasid", MySqlDbType.Int32).Value = trabajo.Retenidasid;
            cmd.Parameters.Add("@postesid", MySqlDbType.Int32).Value = trabajo.Postesid;


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


        public bool IngresarDetalleTrabajoFibra(clsDetalleTrabajo trabajo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleTrabajo(tbl_TipoTrabajo_id,codigo_trabajo,tbl_Fibra_id,tbl_Postes_id,tbl_KitsRetenida_id)" +
                                                "values(@tipotrabajoid,@codigotrabajo,@fibraid,NULL,NULL)", con);

           
            cmd.Parameters.Add("@tipotrabajoid", MySqlDbType.Int32).Value = trabajo.Tipotrabajoid;
            cmd.Parameters.Add("@codigotrabajo", MySqlDbType.VarChar).Value = trabajo.Codigotrabajo;
            cmd.Parameters.Add("@fibraid", MySqlDbType.Int32).Value = trabajo.Fibraid;


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


        public bool IngresarDetalleTrabajoPostes(clsDetalleTrabajo trabajo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleTrabajo(tbl_TipoTrabajo_id,codigo_trabajo,tbl_Fibra_id,tbl_Postes_id,tbl_KitsRetenida_id)" +
                                                "values(@tipotrabajoid,@codigotrabajo,NULL,@postesid,NULL)", con);


            cmd.Parameters.Add("@tipotrabajoid", MySqlDbType.Int32).Value = trabajo.Tipotrabajoid;
            cmd.Parameters.Add("@codigotrabajo", MySqlDbType.VarChar).Value = trabajo.Codigotrabajo;
            cmd.Parameters.Add("@postesid", MySqlDbType.Int32).Value = trabajo.Postesid;

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


        public bool IngresarDetalleTrabajoKitsRetenidas(clsDetalleTrabajo trabajo)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "Mysqlwarmachine2";
            builder.SslMode = MySqlSslMode.None;
            builder.Database = "dbcoordinacion";

            MySqlConnection con = new MySqlConnection(builder.ToString());

            MySqlCommand cmd = new MySqlCommand("insert into tbl_DetalleTrabajo(tbl_TipoTrabajo_id,codigo_trabajo,tbl_Fibra_id,tbl_Postes_id,tbl_KitsRetenida_id)" +
                                                "values(@tipotrabajoid,@codigotrabajo,NULL,NULL,@kitsretenidasid)", con);


            cmd.Parameters.Add("@tipotrabajoid", MySqlDbType.Int32).Value = trabajo.Tipotrabajoid;
            cmd.Parameters.Add("@codigotrabajo", MySqlDbType.VarChar).Value = trabajo.Codigotrabajo;
            cmd.Parameters.Add("@kitsretenidasid", MySqlDbType.Int32).Value = trabajo.Retenidasid;

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


            MySqlCommand cmd = new MySqlCommand("insert into tbl_TipoTrabajo(identificador_tipotrabajo,descripcion_tipotrabajo)" +
                                                "values(@identificador,@descripcion)", con);


            cmd.Parameters.Add("@identificador", MySqlDbType.VarChar).Value = tipotrabajo.Identificadortipotrabajo;
            cmd.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = tipotrabajo.Descripciontipotrabajo;

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


            MySqlCommand cmd = new MySqlCommand("insert into tbl_Postes(detalle_postes,numero_postes)" +
                                                "values(@detallepostes,@numeropostes)", con);

           
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


            MySqlCommand cmd = new MySqlCommand("insert into tbl_KitsRetenida(detalle_retenidas,numero_retenidas)" +
                                                "values(@detalleretenidas,@numeroretenidas)", con);

     
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
