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

namespace Proyecto_p04
{
    public partial class frmAerolina : Form
    {
        public frmAerolina()
        {
            InitializeComponent();
        }

        private void frmAerolina_Load(object sender, EventArgs e)
        {
            conexionBD.conectarBD();
            MessageBox.Show("Conexion Exitosa!!!");
            dgvAerolinea.DataSource = LLenar_grid();
            
        }


        public DataTable LLenar_grid()
        {
            //se llena el grid con la tabla de de la informacion del avion, esta es para los 3 grid

            
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_aerolineas"; //Crear la tabla en BD para llenar el grid
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void dgvAerolinea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //para llenar los textBox= codigo, nombre, identificacion, pais de Origen, con la informacion de los grid=Aerolinea
            txtID.Text = dgvAerolinea.CurrentRow.Cells[0].Value.ToString();
            txtIdentidicacion.Text = dgvAerolinea.CurrentRow.Cells[1].Value.ToString();
            txtEstado.Text = dgvAerolinea.CurrentRow.Cells[3].Value.ToString();
            txtNombre.Text = dgvAerolinea.CurrentRow.Cells[4].Value.ToString();
            txtPaisOrigen.Text = dgvAerolinea.CurrentRow.Cells[5].Value.ToString();
        }
    


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //Codigo Guardar
            conexionBD.conectarBD();
            string insertar = "INSERT INTO tbl_aerolineas(Identificacion,Estado,Descripcion,PaisOrigen) VALUES(@Identificacion,@Estado,@Descripcion,@PaisOrigen)";
            SqlCommand cmd = new SqlCommand(insertar, conexionBD.conectarBD());
            
            cmd.Parameters.AddWithValue("@Identificacion", txtIdentidicacion.Text);
            cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
            cmd.Parameters.AddWithValue("@Descripcion", txtNombre.Text);
            cmd.Parameters.AddWithValue("@PaisOrigen", txtPaisOrigen.Text);
            cmd.ExecuteNonQuery();


            MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
            dgvAerolinea.DataSource = LLenar_grid();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Codigo Modificar
            conexionBD.conectarBD();
            string actualizar = "UPDATE tbl_aerolineas SET Identificacion=@Identificacion,Estado=@Estado,Nombre=@Nombre,PaisOrigen=@PaisOrigen," +
            "WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(actualizar, conexionBD.conectarBD());
            
            cmd.Parameters.AddWithValue("@Identificacion", txtIdentidicacion);
            cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@PaisOrigen", txtPaisOrigen.Text);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
            dgvAerolinea.DataSource = LLenar_grid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Codigo Eliminar
            conexionBD.conectarBD();
            string eliminar = "DELETE FROM tbl_aerolineas WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(eliminar, conexionBD.conectarBD());
            cmd.Parameters.AddWithValue("@Id", txtID.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Los datosfueron Eliminados!!!");
            dgvAerolinea.DataSource = LLenar_grid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
         limpiar_txt();
        }

         public void limpiar_txt()
         {
            txtID.Clear();  
            txtNombre.Clear();
            txtEstado.Clear();
            txtIdentidicacion.Clear();
            txtPaisOrigen.Clear();
            
        }

        private void dgvAerolinea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmAerolina frmAerolina = new frmAerolina();
            frmAerolina.Close();
        }

   
    }
}
