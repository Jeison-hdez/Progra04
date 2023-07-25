using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_p04.Clases
{
    class UsuariosDAL
    {
        public static int LoginUser(Usuarios rUsuarios)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_usuarios where Usuario='{0}' and Contrasena='{1}' and estado=1", rUsuarios.Usuario, rUsuarios.Password), conexionBD.conectarBD());
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    rUsuarios.Nivel = Convert.ToInt32(rd["Id_Nivel"]);
                    Globales.Nivel = Convert.ToInt32(rd["Id_Nivel"]);
                    resultado = 1;
                }
            }
            catch { }
            return resultado;
        }
    }
}
