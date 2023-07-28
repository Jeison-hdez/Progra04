using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_p04
{

    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        //conexion a la BD

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            conexionBD.conectarBD();
            MessageBox.Show("Conexion Exitosa!!!");
            dataGridView1.DataSource = LLenar_grid();
        }

        //Llenar y conectar grid
        public DataTable LLenar_grid()
        {
            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_usuarios";
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //LLegar el grid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtIdentificacion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEstado.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtNivel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }


        //Guardar/Registra el nuevo usuario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexionBD.conectarBD();
            string insertar = "INSERT INTO tbl_usuarios(Id,Usuario,Contraseña,Nombre,Identificacion,Id_Nivel,Estado) " +
                "VALUES(@Id,@Usuario,@Contraseña,@Nombre,@Identificacion,@Id_Nivel,@Estado)";
            SqlCommand cmd = new SqlCommand(insertar, conexionBD.conectarBD());
            cmd.Parameters.AddWithValue("@Id", txtID.Text);
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Contraseña", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Identificacion", txtIdentificacion.Text);
            cmd.Parameters.AddWithValue("@Id_Nivel", txtNivel.Text);
            cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
            cmd.ExecuteNonQuery();


            MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
            dataGridView1.DataSource = LLenar_grid();
        }

        //Modificar datos
        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexionBD.conectarBD();
            string actualizar = "UPDATE tbl_usuarios SET Id=@Id,Usuario=@Usuario,Contraseña=@Contraseña,Nombre=@Nombre,Identificacion=@Identififcacion," +
                "Id_Nivel=@ID-Nivel,Estado=@Estado WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(actualizar, conexionBD.conectarBD());
            cmd.Parameters.AddWithValue("@Id", txtID.Text);
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Contraseña", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Identificacion", txtIdentificacion.Text);
            cmd.Parameters.AddWithValue("@Id_Nivel", txtNivel.Text);
            cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
            dataGridView1.DataSource = LLenar_grid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexionBD.conectarBD();
            string eliminar = "DELETE FROM tbl_usuarios WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(eliminar, conexionBD.conectarBD());
            cmd.Parameters.AddWithValue("@Id", txtID.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Los datosfueron Eliminados!!!");
            dataGridView1.DataSource = LLenar_grid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar_txt();
        }

        public void limpiar_txt()
        {
            txtID.Clear();
            txtEstado.Clear();
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtNivel.Clear();
            txtEstado.Clear();
            txtUsuario.Clear();

        }
    }
}
