using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_p04
{
    internal class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conectar1 = new SqlConnection("SERVER=LAPTOP-PORRRASC\\SQLEXPRESS;DATABASE=AeropuertoResi;Integrated security=true");
            conectar1.Open();
            return conectar1;
        }

    }
}


