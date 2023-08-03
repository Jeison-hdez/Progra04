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
            //conexionBD.conectarBD();
            //MessageBox.Show("Conexion Exitosa!!!");
            //dgvAerolinea.DataSource = LLenar_grid1();
            //dgvAvion1.DataSource = LLenar_grid2();
            //dgvAvion2.DataSource = LLenar_grid2();
            //dgvAvion3.DataSource = LLenar_grid2();
        }

        public DataTable LLenar_grid1()
        {
            //se llena el grid con la tabla de aerolina

            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_Aerolinea"; //Crear la tabla en BD para lenar el grid
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public DataTable LLenar_grid2()
        {
            //se llena el grid con la tabla de de la informacion del avion, esta es para los 3 grid

            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_Avion"; //Crear la tabla en BD para llenar el grid
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void dgvAerolinea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //para llenar los textBox= codigo, nombre, identificacion, pais de Origen, con la informacion de los grid=Aerolinea
        }

        private void dgvAvion1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //llenar el texBox=Avion1, con el nombre o codigo del avion(informacion en el grid)
        }

        private void dgvAvion2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //llenar el texBox=Avion2, con el nombre o codigo del avion(informacion en el grid)
        }

        private void dgvAvion3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //llenar el texBox=Avion3, con el nombre o codigo del avion(informacion en el grid)
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Es el boton de guardar

        }
    }
}
