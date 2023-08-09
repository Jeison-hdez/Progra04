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
            dgvAerolinea.DataSource = LLenar_grid2();
            
        }


        public DataTable LLenar_grid2()
        {
            //se llena el grid con la tabla de de la informacion del avion, esta es para los 3 grid

            conexionBD.conectarBD();
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
        }

        

       
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //Codigo Guardar



            Clases.aerolinea aero = new Clases.aerolinea();
            aero.Identificacion = txtIdentidicacion.Text;
            aero.Descripcion = txtNombre.Text;
            aero.Estado = "1";
            aero.PaisOrigen = txtPaisOrigen.Text;

            int resultado = Clases.aerolineaDAL.InserAerolinea(aero);

            if (resultado > 0)
            {
                MessageBox.Show("Los datos fueron agregados de forma exitosa!!!");
                dgvAerolinea.DataSource = LLenar_grid2();
            }
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
            
            txtNombre.Clear();
            txtIdentidicacion.Clear();
            txtPaisOrigen.Clear();
            

        }

        private void dgvAerolinea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
