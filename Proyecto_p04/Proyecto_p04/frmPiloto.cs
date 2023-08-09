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
    public partial class frmPiloto : Form
    {
        public frmPiloto()
        {
            InitializeComponent();
        }

        private void frmPiloto_Load(object sender, EventArgs e)
        {
            //conexionBD.conectarBD();
            //MessageBox.Show("Conexion Exitosa!!!");
            //dgvAerolinea.DataSource = LLenar_grid1();

        }
        public DataTable LLenar_grid1()
        {
            //se llena el grid con la tabla de aerolina

            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_Piloto"; //Crear la tabla en BD para lenar el grid
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
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
            txtCodigo.Clear();
            txtNombre.Clear();
            txtIdentidicacion.Clear();
            txtAñosE.Clear();
        }

        private void dgvAerolinea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvPiloto.CurrentRow.Cells[0].Value.ToString();
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
