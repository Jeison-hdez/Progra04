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
            //MessageBox.Show("Conexion Exitosa!!!");
            dataGridView1.DataSource = LLenar_grid();
            niveles();
        }

        public void niveles() 
        {
            DataTable dt = new DataTable();
            cbNivel.ValueMember = "nivel";
            cbNivel.DisplayMember = "nombre";

            cbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            dt = Clases.NivelesUsuariosDAL.getNiveles();

            if (dt.Rows.Count > 0)
            {
                cbNivel.DataSource = new BindingSource(dt, null);
                cbNivel.DisplayMember = "descripcion";
                cbNivel.ValueMember = "nivel";
            }
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
            cbNivel.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString());
        }


        //Guardar/Registra el nuevo usuario
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los datos?", "Confirmar Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Clases.Usuarios user = new Clases.Usuarios();
                    user.Usuario = txtUsuario.Text;
                    user.Password = txtPassword.Text;
                    user.Nombre = txtNombre.Text;
                    user.identificacion = txtIdentificacion.Text;

                    if (txtNombre.TextLength > 0 && txtPassword.TextLength > 0 && txtNombre.TextLength > 0 && txtIdentificacion.TextLength > 0)
                    {
                        int resultado = Clases.UsuariosDAL.InsertUser(user);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Los datos fueron agregados de forma exitosa!!!");
                            limpiar_txt();
                            dataGridView1.DataSource = LLenar_grid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Necesita completar los datos para guardar el usuario");
                    }

                    MessageBox.Show("Datos guardados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
        }

        //Modificar datos
        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("¿Desea aplicar los cambios?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    if (result == DialogResult.Yes)
                    {
                        conexionBD.conectarBD();
                        string actualizar = "UPDATE tbl_usuarios SET Usuario=@Usuario,Contrasena=@Contrasena,Nombre=@Nombre,Identificacion=@Identificacion," +
                            "Id_Nivel=@ID_Nivel WHERE Id=@Id";
                        SqlCommand cmd = new SqlCommand(actualizar, conexionBD.conectarBD());
                        cmd.Parameters.AddWithValue("@Id", txtID.Text);
                        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@Contrasena", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Identificacion", txtIdentificacion.Text);
                        cmd.Parameters.AddWithValue("@ID_Nivel", cbNivel.SelectedValue);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Los datos fueron agregados de forma exitosa!!!");
                        dataGridView1.DataSource = LLenar_grid();
                        limpiar_txt();
                    }
                    else
                    {

                    }

                    MessageBox.Show("Cambios aplicados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (txtID.TextLength > 0)
                        {
                            conexionBD.conectarBD();
                            string eliminar = "DELETE FROM tbl_usuarios WHERE Id=@Id";
                            SqlCommand cmd = new SqlCommand(eliminar, conexionBD.conectarBD());
                            cmd.Parameters.AddWithValue("@Id", txtID.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Los datos fueron Eliminados!!!");
                            limpiar_txt();
                            dataGridView1.DataSource = LLenar_grid();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un usuario valido!");
                        }
                    }
                    else
                    {

                    }

                    MessageBox.Show("Datos eliminados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
            txtID.Clear();
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.Close();
        }
    }
}
