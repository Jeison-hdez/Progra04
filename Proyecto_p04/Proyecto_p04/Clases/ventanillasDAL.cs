﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_p04.Clases
{
    class ventanillasDAL
    {
        public static DataTable getPaises()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(string.Format("select * from paises order by Id asc"), conexionBD.conectarBD());
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(dt);
            return dt;
        }

        public static DataTable getAsientoV(string vuelo)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_ventanilla where Id = '{0}'",vuelo), conexionBD.conectarBD());
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(dt);
            return dt;
        }

    }

}
