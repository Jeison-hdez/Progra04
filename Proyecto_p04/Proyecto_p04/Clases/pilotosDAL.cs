using System;
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
            SqlCommand cmd = new SqlCommand(string.Format("select * from paises order by Id asc"), conexionBD.conectarBD());
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(dt);
            return dt;
        }

        public static int updaPiloto(string nombre, string Identificacion, string AnosExpe, string Nacionalidad, string Id)
        {
            int resultado = 0;
            SqlCommand cmd = new SqlCommand(string.Format("update tbl_pilotos set Nombre='{0}', Identificacion='{1}', AnosExpe='{2}', Nacionalidad='{3}' where Id='{4}'", nombre,Identificacion,AnosExpe,Nacionalidad,Id), conexionBD.conectarBD());
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

    }

   
}
