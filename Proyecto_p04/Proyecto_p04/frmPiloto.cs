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
            cbPaises.SelectedIndex = 0;
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

            try
            {
                if (txtNombre.TextLength > 0 && txtId.TextLength > 0 && txtIdentificacion.TextLength > 0 && txtAnosE.TextLength > 0 && cbPaises.SelectedIndex != -1 && cbPaises.SelectedIndex != 0)
                {

                    DialogResult result = MessageBox.Show("¿Desea guardar los datos?", "Confirmar Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        ///Codigo Guardar
                        conexionBD.conectarBD();
                        string insertar = "INSERT INTO tbl_pilotos(Identificacion,Nombre,AnosExpe,Nacionalidad) " +
                            "VALUES(@Identificacion,@Nombre,@AnosExpe,@Nacionalidad)";
                        SqlCommand cmd = new SqlCommand(insertar, conexionBD.conectarBD());

                        cmd.Parameters.AddWithValue("@Identificacion", txtIdentificacion.Text);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@AnosExpe", txtAnosE.Text);
                        cmd.Parameters.AddWithValue("@Nacionalidad", cbPaises.SelectedIndex);
                        cmd.ExecuteNonQuery();


                       
                        MessageBox.Show("Datos guardados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvPiloto.DataSource = LLenar_grid1();
                    }
                }
                else
                {
                    MessageBox.Show("Necesita completar los datos para guardar el usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea aplicar los cambios?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string Id = txtId.Text;
                    string nombre = txtNombre.Text;
                    string Identificacion = txtIdentificacion.Text;
                    string AnosExpe = txtAnosE.Text;
                    int Nacionalidad = cbPaises.SelectedIndex;
                    int resultado = Clases.pilotosDAL.updaPiloto(nombre, Identificacion,AnosExpe,Nacionalidad.ToString(),Id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Los datos fueron agregados de forma exitosa!!!");
                        limpiar_txt();
                        dgvPiloto.DataSource = LLenar_grid1();
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar los datos?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //Codigo Eliminar
                    conexionBD.conectarBD();
                    string eliminar = "DELETE FROM tbl_pilotos WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(eliminar, conexionBD.conectarBD());
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datosfueron Eliminados!!!");
                    dgvPiloto.DataSource = LLenar_grid1();

                    MessageBox.Show("Datos eliminados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPiloto.DataSource = LLenar_grid1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea limpiar los datos?", "Confirmar Limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    limpiar_txt();

                    MessageBox.Show("Datos limpiados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
            
        }

        public void limpiar_txt()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtAnosE.Clear();
            cbPaises.SelectedIndex = 0;
        } 

        private void dgvAerolinea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvPiloto.CurrentRow.Cells[0].Value.ToString();
            txtIdentificacion.Text = dgvPiloto.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvPiloto.CurrentRow.Cells[2].Value.ToString();
            txtAnosE.Text = dgvPiloto.CurrentRow.Cells[3].Value.ToString();
            cbPaises.SelectedItem = dgvPiloto.CurrentRow.Cells[4].Value.ToString();
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

        private void cbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
