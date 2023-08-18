using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_p04.Clases
{
    class vuelosDAL
    {
        public static DataTable getVuelo(string vuelo)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_vuelos where id={0}", vuelo), conexionBD.conectarBD());
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(dt);
            return dt;
        }
    }
}
