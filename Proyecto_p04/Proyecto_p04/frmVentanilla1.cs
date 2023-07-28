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
    public partial class frmVentanilla1 : Form
    {
        public frmVentanilla1()
        {
            InitializeComponent();
        }

        private void frmVentanilla1_Load(object sender, EventArgs e)
        {
            
                conexionBD.conectarBD();
                MessageBox.Show("Conexion Exitosa!!!");
                dataGridView1.DataSource = LLenar_grid();
            
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

        private void btnHoraFecha_Click(object sender, EventArgs e)
        {
            //Es el boton para extraer la fecha y hora
            DateTime fecha = DateTime.Now;
            txtHoraFecha.Text = fecha.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Es la instrucion para guardar la informacio de los clientes de la ventanilla
        }
    }
}
