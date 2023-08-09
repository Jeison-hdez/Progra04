using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_p04.Clases
{
    class aerolineaDAL
    {


        public static int InserAerolinea(aerolinea aero)
        {
            int resultado = 0;


            SqlCommand cmd = new SqlCommand(string.Format("insert into tbl_aerolineas(Descripcion,Estado,Identificacion,PaisOrigen) values ('{0}',{1},'{2}','{3}')", aero.Descripcion,aero.Estado,aero.Identificacion,aero.PaisOrigen), conexionBD.conectarBD());
            try
            {
                resultado = cmd.ExecuteNonQuery();
            }
            catch { }
            return resultado;
        }

    }
}
