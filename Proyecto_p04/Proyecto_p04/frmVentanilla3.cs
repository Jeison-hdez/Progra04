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
    public partial class frmVentanilla3 : Form
    {
        public frmVentanilla3()
        {
            InitializeComponent();
        }

        

        private void frmVentanilla3_Load(object sender, EventArgs e)
        {

            //conexionBD.conectarBD();
            //MessageBox.Show("Conexion Exitosa!!!");
            //dataGridView1.DataSource = LLenar_grid();

        }

        public DataTable LLenar_grid()
        {
            //se llena el grid con la tabla de vuelos

            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_vuelos";
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDestino.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Codigo Guardar
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Codigo Modificar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //Codigo Eliminar
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar_txt();
        }

        public void limpiar_txt()
        {
            txtCedula.Clear();
            txtDestino.Clear();
            txtHoraFecha.Clear();
            txtId.Clear();
            txtNV.Clear();
            txtUsuario.Clear();
            txtNombre.Clear();

        }
    }
}
