﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_p04.Clases
{
    class pilotosDAL
    {
        public static DataTable getPaises()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_paises order by Id asc"), conexionBD.conectarBD());
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(dt);
            return dt;
        }
    }
}
