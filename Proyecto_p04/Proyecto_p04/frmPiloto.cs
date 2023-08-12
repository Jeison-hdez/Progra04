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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_p04
{
    public partial class frmPiloto : Form
    {
        public frmPiloto()
        {
            InitializeComponent();
        }

        private void frmPiloto_Load(object sender, EventArgs e)
        {
            conexionBD.conectarBD();
            MessageBox.Show("Conexion Exitosa!!!");
            dgvPiloto.DataSource = LLenar_grid1();
            paises();
        }
        public DataTable LLenar_grid1()
        {
            //se llena el grid con la tabla de aerolina

            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_pilotos"; //Crear la tabla en BD para lenar el grid
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Codigo Guardar
            conexionBD.conectarBD();
            string insertar = "INSERT INTO tbl_pilotos(Identificacion,Nombre,AñosExpe,Nacionalidad) " +
                "VALUES(@Identificacion,@Nombre,@AñosExpe,@Nacionalidad)";
            SqlCommand cmd = new SqlCommand(insertar, conexionBD.conectarBD());
            
            cmd.Parameters.AddWithValue("@Identificacion", txtIdentidicacion.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@AñosExpe", txtAñosE.Text);
            cmd.Parameters.AddWithValue("@Nacionalidad", cbPaises.SelectedIndex);
            cmd.ExecuteNonQuery();


            MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
            dgvPiloto.DataSource = LLenar_grid1();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Codigo Modificar
            conexionBD.conectarBD();
            string actualizar = "UPDATE tbl_pilotos SET Identificacion=@Identificacion,Nombre=@Nombre," +
                "@AñosExpe=AñosExpe,@Nacionalidad=Nacionalidad" +
            "WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(actualizar, conexionBD.conectarBD());
            
            cmd.Parameters.AddWithValue("@Identificacion", txtIdentidicacion.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@AñosExpe", txtAñosE.Text);
            cmd.Parameters.AddWithValue("@Nacionalidad", cbPaises.SelectedIndex);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
            dgvPiloto.DataSource = LLenar_grid1();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Codigo Eliminar
            conexionBD.conectarBD();
            string eliminar = "DELETE FROM tbl_pilotos WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(eliminar, conexionBD.conectarBD());
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Los datosfueron Eliminados!!!");
            dgvPiloto.DataSource = LLenar_grid1();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            limpiar_txt();
            
        }

        public void limpiar_txt()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtIdentidicacion.Clear();
            txtAñosE.Clear();
            cbPaises.SelectedItem = "- Seleccione Nacionalidad";
        } 

        private void dgvAerolinea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvPiloto.CurrentRow.Cells[0].Value.ToString();
            txtIdentidicacion.Text = dgvPiloto.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvPiloto.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = dgvPiloto.CurrentRow.Cells[3].Value.ToString();
            txtAñosE.Text = dgvPiloto.CurrentRow.Cells[4].Value.ToString();
        }

        public void paises() 
        {
            DataTable dt = new DataTable();
            cbPaises.ValueMember = "id";
            cbPaises.DisplayMember = "pais";
            cbPaises.Items.Insert(0, " - Seleccione Nacionalidad");
            dt = Clases.pilotosDAL.getPaises();
            int i = 0;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    cbPaises.Items.Insert(Convert.ToInt32(dt.Rows[i]["id"]), dt.Rows[i]["nombre"].ToString());
                    i++;
                }
            }
        }
    }
}
