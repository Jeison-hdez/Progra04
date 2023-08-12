using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_p04.Clases
{
    class NivelesdeUsuariosDAL
    {
        public static int addRegistro(NivelesdeUsuarios dlevel)
        {
            //ANADIR UN REGISTRO
            int resultado = 0;
            SqlCommand cmd = new SqlCommand(string.Format("insert into tbl_usuarios_permisos(id_nivel,id_boton,descripcion,boton, activo) values('{0}','{1}','{2}','{3}','{4}')", dlevel.id_nivel, dlevel.id_boton, dlevel.informacion, dlevel.boton, dlevel.activo), conexionBD.conectarBD());
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        internal static int getNivel(NivelesdeUsuarios gPermisos)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand(string.Format("select * from tbl_usuarios_permisos where id_nivel = {1} limit 1 ", gPermisos.id_boton, gPermisos.id_nivel, gPermisos.activo), conexionBD.conectarBD());
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Globales.idNivel = Convert.ToInt32(rd["id_nivel"]);
                    Globales.idBotones = Convert.ToInt32(rd["id_boton"]);
                    gPermisos.activo = Convert.ToInt32(rd["activo"]);

                    resultado = 1;
                }
            }
            catch { }
            return resultado;
        }


        internal static DataTable getNivelTot(NivelesdeUsuarios gPermisos)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(string.Format("select * from usuarios_permisos where id_nivel = {1} ORDER BY id_boton ASC ", gPermisos.id_boton, gPermisos.id_nivel, gPermisos.activo), conexionBD.conectarBD());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            if (dt.Rows.Count > 0)
            {
            }
            adap.Fill(dt);
            return dt;
        }

        internal static int updaPerm(NivelesdeUsuarios updaPerm)
        {
            int resultado = 0;
            SqlCommand cmd = new SqlCommand(string.Format("update usuarios_permisos set activo={0},usuario = '{3}',fecha = '{4}' where  id_nivel = {2} and id_boton = {1} ORDER BY id_boton ASC", updaPerm.activo, updaPerm.id_boton, updaPerm.id_nivel, Globales.Usuario, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), conexionBD.conectarBD());
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public static DataTable bot()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(string.Format("select * from u_botones"), conexionBD.conectarBD());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            if (dt.Rows.Count > 0)
            {
            }
            adap.Fill(dt);
            return dt;
        }

        public static int getlevels(NivelesdeUsuarios glevel)
        {
            //OBTENER NVELES
            int resultado = 0;
            SqlCommand cmd = new SqlCommand(string.Format("select * from usuarios_nivel where nombre ='{0}' and activo=1", glevel.Nombre), conexionBD.conectarBD());
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    resultado = 1;
                }
            }
            catch { }
            return resultado;
        }

        internal static int Deletelevel(NivelesdeUsuarios eliminar)
        {
            //ELIMINAR REGISTRO 
            int resultado = 0;
            SqlCommand cmd = new SqlCommand(string.Format("delete from usuarios_nivel where nombre ='{0}' ", eliminar.Nombre), conexionBD.conectarBD());
            resultado = cmd.ExecuteNonQuery();
            return resultado;
        }
    }
}
