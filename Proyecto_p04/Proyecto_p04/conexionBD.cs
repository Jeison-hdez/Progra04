using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_p04
{
    class conexionBD
    {
        public static SqlConnection conectarBD()
        {
            SqlConnection cmd = new SqlConnection("SERVER=DESKTOP-MPLP2PA\\SQLEXPRESS;DATABASE=planilla;Integrated security=true");
            cmd.Open();
            return cmd;
        }
    }
}
