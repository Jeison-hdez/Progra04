using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_p04.Clases
{
    class NivelesUsuariosDAL
    {
        public static int addNivel (string nombre, int nivel)
        {
            int resultado = 0;
            try
            {
                //AGREGO NUEVO NIVEL
                SqlCommand cmd = new SqlCommand(string.Format("insert into tbl_usuarioNiveles set nivel = id, descripcion='{0}', estado=1", nombre), conexionBD.conectarBD());
                resultado = cmd.ExecuteNonQuery();

                //ACTUALIZO EL ULTIMO ID
                //long lastNivel = cmd.
            }
            catch { }
            return resultado;
        }


    }
}
