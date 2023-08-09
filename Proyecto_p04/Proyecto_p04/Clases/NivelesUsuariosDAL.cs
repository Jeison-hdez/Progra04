using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_p04.Clases
{
    class NivelesUsuariosDAL
    {
        public static int addNivel (string nombre)
        {
            int resultado = 0;
            try
            {
                //AGREGO NUEVO NIVEL
                SqlCommand cmd = new SqlCommand(string.Format("insert into tbl_usuario_nivel(Nivel,Descripcion,Estado) values(SCOPE_IDENTITY(),'{0}',1)", nombre), conexionBD.conectarBD());
                resultado = cmd.ExecuteNonQuery();

                //ACTUALIZO EL NIVEL CON EL ULTIMO ID
                SqlCommand cmd1 = new SqlCommand(string.Format("update tbl_usuario_nivel set Nivel = SCOPE_IDENTITY() where Id= SCOPE_IDENTITY();"), conexionBD.conectarBD());
                resultado = cmd1.ExecuteNonQuery();
            }
            catch { }
            return resultado;
        }

        public static DataTable getNiveles()
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_usuario_nivel order by Id asc"), conexionBD.conectarBD());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            if (dt.Rows.Count > 0)
            {
            }
            adap.Fill(dt);
            return dt;
        }

        public static DataTable getbotones()
        {
            //OBTENER MENUS
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_botonesPermisos where estado = 1 order by id asc"), conexionBD.conectarBD());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            if (dt.Rows.Count > 0)
            {
            }
            adap.Fill(dt);
            return dt;
        }

        internal static DataTable getPermisos(Usuarios usu)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT u.id,p.id_nivel,p.descripcion,p.boton,p.activo,IFNULL(u.boton,'No Existe') AS valor from u_botones u left JOIN usuarios_permisos p ON u.boton = p.boton and p.id_nivel = {0} where u.activo=1  ORDER BY u.id ASC", usu.idPerfil), conexionBD.conectarBD());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            if (dt.Rows.Count > 0)
            {
            }
            adap.Fill(dt);
            return dt;
        }
    }
}
