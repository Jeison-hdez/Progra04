using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_p04.Clases
{
    class reportesDAL
    {
        public static DataTable repVuelos(string fechaI, string fechaF)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(string.Format("exec sp_rep_vuelos '{0}','{1}','{2}';", fechaI,fechaF, 1), conexionBD.conectarBD());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            if (dt.Rows.Count > 0)
            {
            }
            adap.Fill(dt);
            return dt;
        }

        public static DataTable repVuelosMonetario(string vuelo, int tipo)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(string.Format("exec sp_rep_vuelos_monetario '{0}','{1}';", vuelo, tipo), conexionBD.conectarBD());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            if (dt.Rows.Count > 0)
            {
            }
            adap.Fill(dt);
            return dt;
        }

        public static DataTable repVuelosPasajeros(string vuelo, int tipo)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(string.Format("exec sp_rep_vuelos_pasajeros '{0}','{1}';", vuelo, tipo), conexionBD.conectarBD());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            if (dt.Rows.Count > 0)
            {
            }
            adap.Fill(dt);
            return dt;
        }

        public static DataTable getVuelos()
        {
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_vuelos";
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable getVuelosCerrados()
        {
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_vuelos where estadoV=0";
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable getDatosVuelo(int id)
        {
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_vuelos where id={0}";
            SqlCommand cmd = new SqlCommand(string.Format(consultar,id), conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable getDatosVueloEscala(int id)
        {
            DataTable dt = new DataTable();
            string consultar = "select * from tbl_ventanilla where Destino = '{0}' and EscalaC=1";
            SqlCommand cmd = new SqlCommand(string.Format(consultar, id), conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
