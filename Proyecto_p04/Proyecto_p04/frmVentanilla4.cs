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
using static Proyecto_p04.frmLogin;

namespace Proyecto_p04
{
    public partial class frmVentanilla4 : Form
    {
        public frmVentanilla4()
        {
            InitializeComponent();
        }


        private void frmVentanilla4_Load(object sender, EventArgs e)
        {
            // Accede a la variable global Usuario desde GlobalVariables
            string usuario = Globales.Usuario;

            //Muestra en un txtUsuario el usuario 
            txtUsuario.Text = usuario;



            conexionBD.conectarBD();
            MessageBox.Show("Conexion Exitosa!!!");
            dataGridView1.DataSource = LLenar_grid1();
            dataGridView2.DataSource = LLenar_grid2();
            paises();

            DateTime fecha = DateTime.Now;
            txtEntrada.Text = fecha.ToString();

            cbNacionalidad.SelectedIndex = 0;

            //txtUsuario.Text = Usuario.ToString();   //Es parea poner el ususario automatico

        }
        public DataTable LLenar_grid1()
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

        public DataTable LLenar_grid2()
        {
            //se llena el grid con la tabla de ventanilla

            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_ventanilla";
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            Asientos();

            DateTime fecha = DateTime.Now;
            txtSalida.Text = fecha.ToString();



            if (txtEstadoV.Text == "1")
            {

                try
                {
                    if (txtNombre.TextLength > 0 && txtId.TextLength > 0 && txtIdentificacion.TextLength > 0 && txtNPasaporte.TextLength > 0 && txtBoleto.TextLength > 0 && txtHoraFecha.TextLength > 0 && txtSalida.TextLength > 0 && txtEntrada.TextLength > 0 && txtVuelo.TextLength > 0 && txtEstadoV.TextLength > 0 &&
                        cbNacionalidad.SelectedIndex != -1 && cbNacionalidad.SelectedIndex != 0 && control != null)
                    {

                        DialogResult result = MessageBox.Show("¿Desea guardar los datos?", "Confirmar Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {

                            //Codigo Guardar
                            conexionBD.conectarBD();
                            string insertar = "INSERT INTO tbl_ventanilla(Id,Nombre,Identificacion,HoraFecha,Usuario,Destino,Asiento,NumeroV,Boleto,Nacionalidad,NPasaporte,HoraEntrada,HoraSalida,EscalaV,EscalaC) VALUES(@Id,@Nombre,@Identificacion,@HoraFecha,@Usuario,@Destino,@Asiento,@NumeroV,@Boleto,@Nacionalidad,@NPasaporte,@HoraEntrada,@HoraSalida,@EscalaV,@EscalaC)";
                            SqlCommand cmd = new SqlCommand(insertar, conexionBD.conectarBD());
                            cmd.Parameters.AddWithValue("@Id", txtId.Text);
                            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@Identificacion", txtIdentificacion.Text);
                            cmd.Parameters.AddWithValue("@HoraFecha", txtHoraFecha.Text);
                            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                            cmd.Parameters.AddWithValue("@Destino", txtVuelo.Text);
                            cmd.Parameters.AddWithValue("@NumeroV", txtNumeroVentanilla.Text);
                            cmd.Parameters.AddWithValue("@Boleto", txtBoleto.Text);
                            cmd.Parameters.AddWithValue("@Nacionalidad", cbNacionalidad.SelectedIndex);
                            cmd.Parameters.AddWithValue("@NPasaporte", txtNPasaporte.Text);
                            cmd.Parameters.AddWithValue("@HoraEntrada", txtEntrada.Text);
                            cmd.Parameters.AddWithValue("@HoraSalida", txtSalida.Text);
                            cmd.Parameters.AddWithValue("@EscalaV", txtEscala.Text);
                            cmd.Parameters.AddWithValue("@EscalaC", txtEscalaC.Text);

                            cmd.Parameters.AddWithValue("@Asiento", control.ToString()); //esta es la variable para los nombres de los chbt
                            MessageBox.Show(control);

                            cmd.ExecuteNonQuery();


                            MessageBox.Show("Los datos fueron agregados de forma exitosa!!!");
                            dataGridView1.DataSource = LLenar_grid1();
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
            else
            {
                MessageBox.Show("El vuelo ya no está disponible, selecione otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.TextLength > 0 && txtId.TextLength > 0 && txtIdentificacion.TextLength > 0 && txtNPasaporte.TextLength > 0 && txtBoleto.TextLength > 0 && txtHoraFecha.TextLength > 0 && txtSalida.TextLength > 0 && txtEntrada.TextLength > 0 && txtVuelo.TextLength > 0 && txtEstadoV.TextLength > 0 &&
                        cbNacionalidad.SelectedIndex != -1 && cbNacionalidad.SelectedIndex != 0 && control != null)
                {

                    DialogResult result = MessageBox.Show("¿Desea guardar los datos?", "Confirmar Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //Codigo Modificar

                        conexionBD.conectarBD();
                        string actualizar = "UPDATE tbl_ventanilla SET Id=@Id,Nombre=@Nombre,Identificacion=@Identificacion,HoraFecha=@HoraFecha,Usuario=@Usuario,Destino=@Destino,NumeroV=@NumeroV,Asiento=@Asiento,Boleto=@Boleto,Nacionalidad=@Nacionalidad,NPasaporte=@NPasaporte,HoraEntrada=@HoraEntrada,HoraSalida=@HoraSalida,EscalaV=@EscalaV,EscalaC=@EscalaC" +
                        "WHERE Id=@Id";
                        SqlCommand cmd = new SqlCommand(actualizar, conexionBD.conectarBD());
                        cmd.Parameters.AddWithValue("@Id", txtId.Text);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Identificacion", txtIdentificacion.Text);
                        cmd.Parameters.AddWithValue("@HoraFecha", txtHoraFecha.Text);
                        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@Destino", txtVuelo.Text);
                        cmd.Parameters.AddWithValue("@NumeroV", txtNumeroVentanilla.Text);
                        cmd.Parameters.AddWithValue("@Boleto", txtBoleto.Text);
                        cmd.Parameters.AddWithValue("@Nacionalidad", cbNacionalidad.SelectedIndex);
                        cmd.Parameters.AddWithValue("@NPasaporte", txtNPasaporte.Text);
                        cmd.Parameters.AddWithValue("@HoraEntrada", txtEntrada.Text);
                        cmd.Parameters.AddWithValue("@HoraSalida", txtSalida.Text);
                        cmd.Parameters.AddWithValue("@EscalaV", txtEscala.Text);
                        cmd.Parameters.AddWithValue("@EscalaC", txtEscalaC.Text);

                        cmd.Parameters.AddWithValue("@Asiento", control.ToString()); //esta es la variable para los nombres de los chbt

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
                        dataGridView1.DataSource = LLenar_grid1();
                    }
                }
                else
                {
                    MessageBox.Show("Necesita completar los datos para Modificar Correctamente");
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
                DialogResult result = MessageBox.Show("¿Desea guardar los datos?", "Confirmar Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //Codigo Eliminar
                    conexionBD.conectarBD();
                    string eliminar = "DELETE FROM tbl_ventanilla WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(eliminar, conexionBD.conectarBD());
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datos fueron Eliminados!!!");
                    dataGridView1.DataSource = LLenar_grid1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            limpiar_txt();

        }

        public void paises()
        {
            DataTable dt = new DataTable();
            cbNacionalidad.ValueMember = "id";
            cbNacionalidad.DisplayMember = "pais";
            cbNacionalidad.Items.Insert(0, " - Seleccione Nacionalidad");
            dt = Clases.ventanillasDAL.getPaises();
            int i = 0;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    cbNacionalidad.Items.Insert(Convert.ToInt32(dt.Rows[i]["id"]), dt.Rows[i]["nombre"].ToString());
                    i++;
                }
            }
        }



        public void limpiar_txt()
        {
            txtIdentificacion.Clear();
            txtHoraFecha.Clear();
            txtId.Clear();
            txtVuelo.Clear();
            txtUsuario.Clear();
            txtNombre.Clear();
            txtBoleto.Clear();
            txtNPasaporte.Clear();
            cbNacionalidad.SelectedIndex = 0;
            txtSalida.Clear();

        }



        //Esta es el metodo para asignar los numero de los chBoton para la Base de Datos
        string control;
        int numero = 0;
        public void Asientos()
        {
            //Parte F. Guardar el numero del asiento.



            if (f1.Checked && f1.Enabled == true)
            {
                control = "f1";
                numero++;
                f1.BackColor = Color.Red;
                f1.Enabled = false;
                control.ToString();
            }
            else if (f2.Checked && f2.Enabled == true)
            {
                control = "f2";
                numero++;
                f2.BackColor = Color.Red;
                f2.Enabled = false;
                control.ToString();
            }
            else if (f3.Checked && f3.Enabled == true)
            {
                control = "f3";
                numero++;
                f3.BackColor = Color.Red;
                f3.Enabled = false;
                control.ToString();
            }
            else if (f4.Checked && f4.Enabled == true)
            {
                control = "f4";
                numero++;
                f4.BackColor = Color.Red;
                f4.Enabled = false;
                control.ToString();
            }

            else if (f7.Checked && f7.Enabled == true)
            {
                control = "f7";
                numero++;
                f7.BackColor = Color.Red;
                f7.Enabled = false;
                control.ToString();
            }
            else if (f8.Checked && f8.Enabled == true)
            {
                control = "f8";
                numero++;
                f8.BackColor = Color.Red;
                f8.Enabled = false;
                control.ToString();
            }

            else if (f10.Checked && f10.Enabled == true)
            {
                control = "f10";
                numero++;
                f10.BackColor = Color.Red;
                f10.Enabled = false;
                control.ToString();
            }
            else if (f11.Checked && f11.Enabled == true)
            {
                control = "f11";
                numero++;
                f11.BackColor = Color.Red;
                f11.Enabled = false;
                control.ToString();
            }
            else if (f12.Checked && f12.Enabled == true)
            {
                control = "f12";
                numero++;
                f12.BackColor = Color.Red;
                f12.Enabled = false;
                control.ToString();
            }

            else if (f14.Checked && f14.Enabled == true)
            {
                control = "f14";
                numero++;
                f14.BackColor = Color.Red;
                f14.Enabled = false;
                control.ToString();
            }
            else if (f15.Checked && f15.Enabled == true)
            {
                control = "f15";
                numero++;
                f15.BackColor = Color.Red;
                f15.Enabled = false;
                control.ToString();
            }
            else if (f20.Checked && f20.Enabled == true)
            {
                control = "f20";
                numero++;
                f20.BackColor = Color.Red;
                f20.Enabled = false;
                control.ToString();
            }
            else if (f21.Checked && f21.Enabled == true)
            {
                control = "f21";
                numero++;
                f21.BackColor = Color.Red;
                f21.Enabled = false;
                control.ToString();
            }
            else if (f22.Checked && f22.Enabled == true)
            {
                control = "f22";
                numero++;
                f22.BackColor = Color.Red;
                f22.Enabled = false;
                control.ToString();
            }
            else if (f23.Checked && f23.Enabled == true)
            {
                control = "f23";
                numero++;
                f23.BackColor = Color.Red;
                f23.Enabled = false;
                control.ToString();
            }
            else if (f24.Checked && f24.Enabled == true)
            {
                control = "f24";
                numero++;
                f24.BackColor = Color.Red;
                f24.Enabled = false;
                control.ToString();
            }
            else if (f25.Checked && f25.Enabled == true)
            {
                control = "f25";
                numero++;
                f25.BackColor = Color.Red;
                f25.Enabled = false;
                control.ToString();
            }
            else if (f26.Checked && f26.Enabled == true)
            {
                control = "f26";
                numero++;
                f26.BackColor = Color.Red;
                f26.Enabled = false;
                control.ToString();
            }
            else if (f27.Checked && f27.Enabled == true)
            {
                control = "f27";
                numero++;
                f27.BackColor = Color.Red;
                f27.Enabled = false;
                control.ToString();
            }
            else if (f28.Checked && f28.Enabled == true)
            {
                control = "f28";
                numero++;
                f28.BackColor = Color.Red;
                f28.Enabled = false;
                control.ToString();
            }
            else if (f29.Checked && f29.Enabled == true)
            {
                control = "f29";
                numero++;
                f29.BackColor = Color.Red;
                f29.Enabled = false;
                control.ToString();
            }
            else if (f30.Checked && f30.Enabled == true)
            {
                control = "f30";
                numero++;
                f30.BackColor = Color.Red;
                f30.Enabled = false;
                control.ToString();
            }
            else if (f31.Checked && f31.Enabled == true)
            {
                control = "f31";
                numero++;
                f31.BackColor = Color.Red;
                f31.Enabled = false;
                control.ToString();
            }
            else if (f32.Checked && f32.Enabled == true)
            {
                control = "f32";
                numero++;
                f32.BackColor = Color.Red;
                f32.Enabled = false;
                control.ToString();
            }
            else if (f34.Checked && f34.Enabled == true)
            {
                control = "f34";
                numero++;
                f34.BackColor = Color.Red;
                f34.Enabled = false;
                control.ToString();
            }
            else if (f35.Checked && f35.Enabled == true)
            {
                control = "f35";
                numero++;
                f35.BackColor = Color.Red;
                f35.Enabled = false;
                control.ToString();
            }
            else if (f36.Checked && f36.Enabled == true)
            {
                control = "f36";
                numero++;
                f36.BackColor = Color.Red;
                f36.Enabled = false;
                control.ToString();
            }
            else if (f37.Checked && f37.Enabled == true)
            {
                control = "f37";
                numero++;
                f37.BackColor = Color.Red;
                f37.Enabled = false;
                control.ToString();
            }
            else if (f38.Checked && f38.Enabled == true)
            {
                control = "f38";
                numero++;
                f38.BackColor = Color.Red;
                f38.Enabled = false;
                control.ToString();
            }


            ///////////// parte E

            if (e1.Checked && e1.Enabled == true)
            {
                control = "e1";
                numero++;
                e1.BackColor = Color.Red;
                e1.Enabled = false;
            }
            else if (e2.Checked && e2.Enabled == true)
            {
                control = "e2";
                numero++;
                e2.BackColor = Color.Red;
                e2.Enabled = false;
            }
            else if (e3.Checked && e3.Enabled == true)
            {
                control = "e3";
                numero++;
                e3.BackColor = Color.Red;
                e3.Enabled = false;
            }
            else if (e4.Checked && e3.Enabled == true)
            {
                control = "e4";
                numero++;
                e4.BackColor = Color.Red;
                e4.Enabled = false;
            }

            else if (e7.Checked && e7.Enabled == true)
            {
                control = "e7";
                numero++;
                e7.BackColor = Color.Red;
                e7.Enabled = false;
            }
            else if (e8.Checked && e8.Enabled == true)
            {
                control = "e8";
                numero++;
                e8.BackColor = Color.Red;
                e8.Enabled = false;
            }

            else if (e10.Checked && e10.Enabled == true)
            {
                control = "e10";
                numero++;
                e10.BackColor = Color.Red;
                e10.Enabled = false;
            }
            else if (e11.Checked && e11.Enabled == true)
            {
                control = "e11";
                numero++;
                e11.BackColor = Color.Red;
                e11.Enabled = false;
            }
            else if (e12.Checked && e12.Enabled == true)
            {
                control = "e12";
                numero++;
                e12.BackColor = Color.Red;
                e12.Enabled = false;
            }

            else if (e14.Checked && e14.Enabled == true)
            {
                control = "e14";
                numero++;
                e14.BackColor = Color.Red;
                e14.Enabled = false;
            }
            else if (e15.Checked && e15.Enabled == true)
            {
                control = "e15";
                numero++;
                e15.BackColor = Color.Red;
                e15.Enabled = false;
            }
            else if (e20.Checked && e20.Enabled == true)
            {
                control = "e20";
                numero++;
                e20.BackColor = Color.Red;
                e20.Enabled = false;
            }
            else if (e21.Checked && e21.Enabled == true)
            {
                control = "e21";
                numero++;
                e21.BackColor = Color.Red;
                e21.Enabled = false;
            }
            else if (e22.Checked && e22.Enabled == true)
            {
                control = "e22";
                numero++;
                e22.BackColor = Color.Red;
                e22.Enabled = false;
            }
            else if (e23.Checked && e23.Enabled == true)
            {
                control = "e23";
                numero++;
                e23.BackColor = Color.Red;
                e23.Enabled = false;
            }
            else if (e24.Checked && e24.Enabled == true)
            {
                control = "e24";
                numero++;
                e24.BackColor = Color.Red;
                e24.Enabled = false;
            }
            else if (e25.Checked && e25.Enabled == true)
            {
                control = "e25";
                numero++;
                e25.BackColor = Color.Red;
                e25.Enabled = false;
            }
            else if (e26.Checked && e26.Enabled == true)
            {
                control = "e26";
                numero++;
                e26.BackColor = Color.Red;
                e26.Enabled = false;
            }
            else if (e27.Checked && e27.Enabled == true)
            {
                control = "e27";
                numero++;
                e27.BackColor = Color.Red;
                e27.Enabled = false;
            }
            else if (e28.Checked && e28.Enabled == true)
            {
                control = "e28";
                numero++;
                e28.BackColor = Color.Red;
                e28.Enabled = false;
            }
            else if (e29.Checked && e29.Enabled == true)
            {
                control = "e29";
                numero++;
                e29.BackColor = Color.Red;
                e29.Enabled = false;
            }
            else if (e30.Checked && e30.Enabled == true)
            {
                control = "e30";
                numero++;
                e30.BackColor = Color.Red;
                e30.Enabled = false;
            }
            else if (e31.Checked && e31.Enabled == true)
            {
                control = "e31";
                numero++;
                e31.BackColor = Color.Red;
                e31.Enabled = false;
            }
            else if (e32.Checked && e32.Enabled == true)
            {
                control = "e32";
                numero++;
                e32.BackColor = Color.Red;
                e32.Enabled = false;
            }
            else if (e34.Checked && e34.Enabled == true)
            {
                control = "e34";
                numero++;
                e34.BackColor = Color.Red;
                e34.Enabled = false;
            }
            else if (e35.Checked && e35.Enabled == true)
            {
                control = "e35";
                numero++;
                e35.BackColor = Color.Red;
                e35.Enabled = false;
            }
            else if (e36.Checked && e36.Enabled == true)
            {
                control = "e36";
                numero++;
                e36.BackColor = Color.Red;
                e36.Enabled = false;
            }
            else if (e37.Checked && e37.Enabled == true)
            {
                control = "e37";
                numero++;
                e37.BackColor = Color.Red;
                e37.Enabled = false;
            }
            else if (e38.Checked && e38.Enabled == true)
            {
                control = "e38";
                numero++;
                e38.BackColor = Color.Red;
                e38.Enabled = false;
            }




            //////////// Parte D

            if (d7.Checked && d7.Enabled == true)
            {
                control = "d7";
                numero++;
                d7.BackColor = Color.Red;
                d7.Enabled = false;
            }
            else if (d8.Checked && d8.Enabled == true)
            {
                control = "d8";
                numero++;
                d8.BackColor = Color.Red;
                d8.Enabled = false;
            }

            else if (d10.Checked && d10.Enabled == true)
            {
                control = "d10";
                numero++;
                d10.BackColor = Color.Red;
                d10.Enabled = false;
            }
            else if (d11.Checked && d11.Enabled == true)
            {
                control = "d11";
                numero++;
                d11.BackColor = Color.Red;
                d11.Enabled = false;
            }
            else if (d12.Checked && d12.Enabled == true)
            {
                control = "d12";
                numero++;
                d12.BackColor = Color.Red;
                d12.Enabled = false;
            }

            else if (d14.Checked && d14.Enabled == true)
            {
                control = "d14";
                numero++;
                d14.BackColor = Color.Red;
                d14.Enabled = false;
            }
            else if (d15.Checked && d15.Enabled == true)
            {
                control = "d15";
                numero++;
                d15.BackColor = Color.Red;
                d15.Enabled = false;
            }
            else if (d20.Checked && d20.Enabled == true)
            {
                control = "d20";
                numero++;
                d20.BackColor = Color.Red;
                d20.Enabled = false;
            }
            else if (d21.Checked && d21.Enabled == true)
            {
                control = "d21";
                numero++;
                d21.BackColor = Color.Red;
                d21.Enabled = false;
            }
            else if (d22.Checked && d22.Enabled == true)
            {
                control = "d22";
                numero++;
                d22.BackColor = Color.Red;
                d22.Enabled = false;
            }
            else if (d23.Checked && d23.Enabled == true)
            {
                control = "d23";
                numero++;
                d23.BackColor = Color.Red;
                d23.Enabled = false;
            }
            else if (d24.Checked && d24.Enabled == true)
            {
                control = "d24";
                numero++;
                d24.BackColor = Color.Red;
                d24.Enabled = false;
            }
            else if (d25.Checked && d25.Enabled == true)
            {
                control = "d25";
                numero++;
                d25.BackColor = Color.Red;
                d25.Enabled = false;
            }
            else if (d26.Checked && d26.Enabled == true)
            {
                control = "d26";
                numero++;
                d26.BackColor = Color.Red;
                d26.Enabled = false;
            }
            else if (d27.Checked && d27.Enabled == true)
            {
                control = "d27";
                numero++;
                d27.BackColor = Color.Red;
                d27.Enabled = false;
            }
            else if (d28.Checked && d28.Enabled == true)
            {
                control = "d28";
                numero++;
                d28.BackColor = Color.Red;
                d28.Enabled = false;
            }
            else if (d29.Checked && d29.Enabled == true)
            {
                control = "d29";
                numero++;
                d29.BackColor = Color.Red;
                d29.Enabled = false;
            }
            else if (d30.Checked && d30.Enabled == true)
            {
                control = "d30";
                numero++;
                d30.BackColor = Color.Red;
                d30.Enabled = false;
            }
            else if (d31.Checked && d31.Enabled == true)
            {
                control = "d31";
                numero++;
                d31.BackColor = Color.Red;
                d31.Enabled = false;
            }
            else if (d32.Checked && d32.Enabled == true)
            {
                control = "d32";
                numero++;
                d32.BackColor = Color.Red;
                d32.Enabled = false;
            }
            else if (d34.Checked && d34.Enabled == true)
            {
                control = "d34";
                numero++;
                d34.BackColor = Color.Red;
                d34.Enabled = false;
            }
            else if (d35.Checked && d35.Enabled == true)
            {
                control = "d35";
                numero++;
                d35.BackColor = Color.Red;
                d35.Enabled = false;
            }
            else if (d36.Checked && d36.Enabled == true)
            {
                control = "d36";
                numero++;
                d36.BackColor = Color.Red;
                d36.Enabled = false;
            }
            else if (d37.Checked && d37.Enabled == true)
            {
                control = "d37";
                numero++;
                d37.BackColor = Color.Red;
                d37.Enabled = false;
            }
            else if (d38.Checked && d38.Enabled == true)
            {
                control = "d38";
                numero++;
                d38.BackColor = Color.Red;
                d38.Enabled = false;
            }





            /////////// parte C

            if (c7.Checked && c7.Enabled == true)
            {
                control = "c7";
                numero++;
                c7.BackColor = Color.Red;
                c7.Enabled = false;
            }
            else if (c8.Checked && c8.Enabled == true)
            {
                control = "c8";
                numero++;
                c8.BackColor = Color.Red;
                c8.Enabled = false;
            }
            else if (c10.Checked && c10.Enabled == true)
            {
                control = "c10";
                numero++;
                c10.BackColor = Color.Red;
                c10.Enabled = false;
            }
            else if (c11.Checked && c11.Enabled == true)
            {
                control = "c11";
                numero++;
                c11.BackColor = Color.Red;
                c11.Enabled = false;
            }
            else if (c12.Checked && c12.Enabled == true)
            {
                control = "c12";
                numero++;
                c12.BackColor = Color.Red;
                c12.Enabled = false;
            }

            else if (c14.Checked && c14.Enabled == true)
            {
                control = "c14";
                numero++;
                c14.BackColor = Color.Red;
                c14.Enabled = false;
            }
            else if (c15.Checked && c15.Enabled == true)
            {
                control = "c15";
                numero++;
                c15.BackColor = Color.Red;
                c15.Enabled = false;
            }
            else if (c20.Checked && c20.Enabled == true)
            {
                control = "c20";
                numero++;
                c20.BackColor = Color.Red;
                c20.Enabled = false;
            }
            else if (c21.Checked && c21.Enabled == true)
            {
                control = "c21";
                numero++;
                c21.BackColor = Color.Red;
                c21.Enabled = false;
            }
            else if (c22.Checked && c22.Enabled == true)
            {
                control = "c22";
                numero++;
                c22.BackColor = Color.Red;
                c22.Enabled = false;
            }
            else if (c23.Checked && c23.Enabled == true)
            {
                control = "c23";
                numero++;
                c23.BackColor = Color.Red;
                c23.Enabled = false;
            }
            else if (c24.Checked && c24.Enabled == true)
            {
                control = "c24";
                numero++;
                c24.BackColor = Color.Red;
                c24.Enabled = false;
            }
            else if (c25.Checked && c25.Enabled == true)
            {
                control = "c25";
                numero++;
                c25.BackColor = Color.Red;
                c25.Enabled = false;
            }
            else if (c26.Checked && c26.Enabled == true)
            {
                control = "c26";
                numero++;
                c26.BackColor = Color.Red;
                c26.Enabled = false;
            }
            else if (c27.Checked && c27.Enabled == true)
            {
                control = "c27";
                numero++;
                c27.BackColor = Color.Red;
                c27.Enabled = false;
            }
            else if (c28.Checked && c28.Enabled == true)
            {
                control = "c28";
                numero++;
                c28.BackColor = Color.Red;
                c28.Enabled = false;
            }
            else if (c29.Checked && c29.Enabled == true)
            {
                control = "c29";
                numero++;
                c29.BackColor = Color.Red;
                c29.Enabled = false;
            }
            else if (c30.Checked && c30.Enabled == true)
            {
                control = "c30";
                numero++;
                c30.BackColor = Color.Red;
                c30.Enabled = false;
            }
            else if (c31.Checked && c31.Enabled == true)
            {
                control = "c31";
                numero++;
                c31.BackColor = Color.Red;
                c31.Enabled = false;
            }
            else if (c32.Checked && c32.Enabled == true)
            {
                control = "c32";
                numero++;
                c32.BackColor = Color.Red;
                c32.Enabled = false;
            }
            else if (c34.Checked && c34.Enabled == true)
            {
                control = "c34";
                numero++;
                c34.BackColor = Color.Red;
                c34.Enabled = false;
            }
            else if (c35.Checked && c35.Enabled == true)
            {
                control = "c35";
                numero++;
                c35.BackColor = Color.Red;
                c35.Enabled = false;
            }
            else if (c36.Checked && c36.Enabled == true)
            {
                control = "c36";
                numero++;
                c36.BackColor = Color.Red;
                c36.Enabled = false;
            }
            else if (c37.Checked && c37.Enabled == true)
            {
                control = "c37";
                numero++;
                c37.BackColor = Color.Red;
                c37.Enabled = false;
            }
            else if (c38.Checked && c38.Enabled == true)
            {
                control = "c38";
                numero++;
                c38.BackColor = Color.Red;
                c38.Enabled = false;
            }


            ///////// parte B

            if (b1.Checked && b1.Enabled == true)
            {
                control = "b1";
                numero++;
                b1.BackColor = Color.Red;
                b1.Enabled = false;
            }
            else if (b2.Checked && b2.Enabled == true)
            {
                control = "b2";
                numero++;
                b2.BackColor = Color.Red;
                b2.Enabled = false;
            }
            else if (b3.Checked && b3.Enabled == true)
            {
                control = "b3";
                numero++;
                b3.BackColor = Color.Red;
                b3.Enabled = false;
            }
            else if (b4.Checked && b4.Enabled == true)
            {
                control = "b4";
                numero++;
                b4.BackColor = Color.Red;
                b4.Enabled = false;
            }

            else if (b7.Checked && b7.Enabled == true)
            {
                control = "b7";
                numero++;
                b7.BackColor = Color.Red;
                b7.Enabled = false;
            }
            else if (b8.Checked && b8.Enabled == true)
            {
                control = "b8";
                numero++;
                b8.BackColor = Color.Red;
                b8.Enabled = false;
            }

            else if (b10.Checked && b10.Enabled == true)
            {
                control = "b10";
                numero++;
                b10.BackColor = Color.Red;
                b10.Enabled = false;
            }
            else if (b11.Checked && b11.Enabled == true)
            {
                control = "b11";
                numero++;
                b11.BackColor = Color.Red;
                b11.Enabled = false;
            }
            else if (b12.Checked && b12.Enabled == true)
            {
                control = "b12";
                numero++;
                b12.BackColor = Color.Red;
                b12.Enabled = false;
            }

            else if (b14.Checked && b14.Enabled == true)
            {
                control = "b14";
                numero++;
                b14.BackColor = Color.Red;
                b14.Enabled = false;
            }
            else if (b15.Checked && b15.Enabled == true)
            {
                control = "b15";
                numero++;
                b15.BackColor = Color.Red;
                b15.Enabled = false;
            }
            else if (b20.Checked && b20.Enabled == true)
            {
                control = "b20";
                numero++;
                b20.BackColor = Color.Red;
                b20.Enabled = false;
            }
            else if (b21.Checked && b21.Enabled == true)
            {
                control = "b21";
                numero++;
                b21.BackColor = Color.Red;
                b21.Enabled = false;
            }
            else if (b22.Checked && b22.Enabled == true)
            {
                control = "b22";
                numero++;
                b22.BackColor = Color.Red;
                b22.Enabled = false;
            }
            else if (b23.Checked && b23.Enabled == true)
            {
                control = "b23";
                numero++;
                b23.BackColor = Color.Red;
                b23.Enabled = false;
            }
            else if (b24.Checked && b24.Enabled == true)
            {
                control = "b24";
                numero++;
                b24.BackColor = Color.Red;
                b24.Enabled = false;
            }
            else if (b25.Checked && b25.Enabled == true)
            {
                control = "b25";
                numero++;
                b25.BackColor = Color.Red;
                b25.Enabled = false;
            }
            else if (b26.Checked && b26.Enabled == true)
            {
                control = "b26";
                numero++;
                b26.BackColor = Color.Red;
                b26.Enabled = false;
            }
            else if (b27.Checked && b7.Enabled == true)
            {
                control = "b27";
                numero++;
                b27.BackColor = Color.Red;
                b27.Enabled = false;
            }
            else if (b28.Checked && b28.Enabled == true)
            {
                control = "b28";
                numero++;
                b28.BackColor = Color.Red;
                b28.Enabled = false;
            }
            else if (b29.Checked && b29.Enabled == true)
            {
                control = "b29";
                numero++;
                b29.BackColor = Color.Red;
                b29.Enabled = false;
            }
            else if (b30.Checked && b30.Enabled == true)
            {
                control = "b30";
                numero++;
                b30.BackColor = Color.Red;
                b30.Enabled = false;
            }
            else if (b31.Checked && b31.Enabled == true)
            {
                control = "b31";
                numero++;
                b31.BackColor = Color.Red;
                b31.Enabled = false;
            }
            else if (b32.Checked && b32.Enabled == true)
            {
                control = "b32";
                numero++;
                b32.BackColor = Color.Red;
                b32.Enabled = false;
            }
            else if (b34.Checked && b34.Enabled == true)
            {
                control = "b34";
                numero++;
                b34.BackColor = Color.Red;
                b34.Enabled = false;
            }
            else if (b35.Checked && b35.Enabled == true)
            {
                control = "b35";
                numero++;
                b35.BackColor = Color.Red;
                b35.Enabled = false;
            }
            else if (b36.Checked && b36.Enabled == true)
            {
                control = "b36";
                numero++;
                b36.BackColor = Color.Red;
                b36.Enabled = false;
            }
            else if (b37.Checked && b37.Enabled == true)
            {
                control = "b37";
                numero++;
                b37.BackColor = Color.Red;
                b37.Enabled = false;
            }
            else if (b38.Checked && b38.Enabled == true)
            {
                control = "b38";
                numero++;
                b38.BackColor = Color.Red;
                b38.Enabled = false;
            }




            /////////// Parte A

            if (a1.Checked && a1.Enabled == true)
            {
                control = "a1";
                numero++;
                a1.BackColor = Color.Red;
                a1.Enabled = false;
            }
            else if (a2.Checked && a2.Enabled == true)
            {
                control = "a2";
                numero++;
                a2.BackColor = Color.Red;
                a2.Enabled = false;
            }
            else if (a3.Checked && a3.Enabled == true)
            {
                control = "a3";
                numero++;
                a3.BackColor = Color.Red;
                a3.Enabled = false;
            }
            else if (a4.Checked && a4.Enabled == true)
            {
                control = "a4";
                numero++;
                a4.BackColor = Color.Red;
                a4.Enabled = false;
            }

            else if (a7.Checked && a7.Enabled == true)
            {
                control = "a7";
                numero++;
                a7.BackColor = Color.Red;
                a7.Enabled = false;
            }
            else if (a8.Checked && a8.Enabled == true)
            {
                control = "a8";
                numero++;
                a8.BackColor = Color.Red;
                a8.Enabled = false;
            }

            else if (a10.Checked && a10.Enabled == true)
            {
                control = "a10";
                numero++;
                a10.BackColor = Color.Red;
                a10.Enabled = false;
            }
            else if (a11.Checked && a11.Enabled == true)
            {
                control = "a11";
                numero++;
                a11.BackColor = Color.Red;
                a11.Enabled = false;
            }
            else if (a12.Checked && a12.Enabled == true)
            {
                control = "a12";
                numero++;
                a12.BackColor = Color.Red;
                a12.Enabled = false;
            }

            else if (a14.Checked && a14.Enabled == true)
            {
                control = "a14";
                numero++;
                a14.BackColor = Color.Red;
                a14.Enabled = false;
            }
            else if (a15.Checked && a15.Enabled == true)
            {
                control = "a15";
                numero++;
                a15.BackColor = Color.Red;
                a15.Enabled = false;
            }
            else if (a20.Checked && a20.Enabled == true)
            {
                control = "a20";
                numero++;
                a20.BackColor = Color.Red;
                a20.Enabled = false;
            }
            else if (a21.Checked && a21.Enabled == true)
            {
                control = "a21";
                numero++;
                a21.BackColor = Color.Red;
                a21.Enabled = false;
            }
            else if (a22.Checked && a22.Enabled == true)
            {
                control = "a22";
                numero++;
                a22.BackColor = Color.Red;
                a22.Enabled = false;
            }
            else if (a23.Checked && a23.Enabled == true)
            {
                control = "a23";
                numero++;
                a23.BackColor = Color.Red;
                a23.Enabled = false;
            }
            else if (a24.Checked && a24.Enabled == true)
            {
                control = "a24";
                numero++;
                a24.BackColor = Color.Red;
                a24.Enabled = false;
            }
            else if (a25.Checked && a25.Enabled == true)
            {
                control = "a25";
                numero++;
                a25.BackColor = Color.Red;
                a25.Enabled = false;
            }
            else if (a26.Checked && a26.Enabled == true)
            {
                control = "a26";
                numero++;
                a26.BackColor = Color.Red;
                a26.Enabled = false;
            }
            else if (a27.Checked && a27.Enabled == true)
            {
                control = "a27";
                numero++;
                a27.BackColor = Color.Red;
                a27.Enabled = false;
            }
            else if (a28.Checked && a28.Enabled == true)
            {
                control = "a28";
                numero++;
                a28.BackColor = Color.Red;
                a28.Enabled = false;
            }
            else if (a29.Checked && a29.Enabled == true)
            {
                control = "a29";
                numero++;
                a29.BackColor = Color.Red;
                a29.Enabled = false;
            }
            else if (a30.Checked && a30.Enabled == true)
            {
                control = "a30";
                numero++;
                a30.BackColor = Color.Red;
                a30.Enabled = false;
            }
            else if (a31.Checked && a31.Enabled == true)
            {
                control = "a31";
                numero++;
                a31.BackColor = Color.Red;
                a31.Enabled = false;
            }
            else if (a32.Checked && a32.Enabled == true)
            {
                control = "a32";
                numero++;
                a32.BackColor = Color.Red;
                a32.Enabled = false;
            }
            else if (a34.Checked && a34.Enabled == true)
            {
                control = "a34";
                numero++;
                a34.BackColor = Color.Red;
                a34.Enabled = false;
            }
            else if (a35.Checked && a35.Enabled == true)
            {
                control = "a35";
                numero++;
                a35.BackColor = Color.Red;
                a35.Enabled = false;
            }
            else if (a36.Checked && a36.Enabled == true)
            {
                control = "a36";
                numero++;
                a36.BackColor = Color.Red;
                a36.Enabled = false;
            }
            else if (a37.Checked && a37.Enabled == true)
            {
                control = "a37";
                numero++;
                a37.BackColor = Color.Red;
                a37.Enabled = false;
            }
            else if (a38.Checked && a38.Enabled == true)
            {
                control = "a38";
                numero++;
                a38.BackColor = Color.Red;
                a38.Enabled = false;
            }



        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtNumeroVentanilla.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtIdentificacion.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtHoraFecha.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txtUsuario.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtVuelo.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            //falta el asiento  [7]  //////////////////////////////////////////////////////////////////
            txtBoleto.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            cbNacionalidad.SelectedItem = dataGridView2.CurrentRow.Cells[9].Value.ToString();
            txtNPasaporte.Text = dataGridView2.CurrentRow.Cells[10].Value.ToString();
            txtEntrada.Text = dataGridView2.CurrentRow.Cells[11].Value.ToString();
            txtSalida.Text = dataGridView2.CurrentRow.Cells[12].Value.ToString();
            txtEscala.Text = dataGridView2.CurrentRow.Cells[13].Value.ToString();
            txtEscalaC.Text = dataGridView2.CurrentRow.Cells[14].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            txtHoraFecha.Text = fecha.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            string vuelo;
            txtVuelo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            vuelo = txtVuelo.Text;
            dt = Clases.ventanillasDAL.getAsientoV(vuelo);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    string descripcion = item["Asiento"].ToString();
                    // Buscar el control checkbox por su nombre en el formulario
                    CheckBox checkBox = this.Controls[descripcion] as CheckBox;

                    // Verificar si se encontró el checkbox y luego seleccionarlo
                    if (checkBox != null)
                    {
                        checkBox.Checked = true;
                        checkBox.Enabled = false;
                        checkBox.BackColor = Color.Red;
                    }
                    else
                    {
                        checkBox.Checked = false;
                        checkBox.Enabled = true;

                    }
                }
            }


            if (txtEscala.Text == "1")
            {
                cbEscala.Enabled = false;
            }
            if (txtEscala.Text == "0")
            {
                cbEscala.Checked = false;
                txtEscalaC.Text = "0";
                cbEscala.Enabled = true;


            }


            txtEstadoV.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtEscala.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void txtEscalaC_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbEscala_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEscala.Checked)
            {

                txtEscalaC.Text = "1";

            }
            else
            {
                txtEscalaC.Text = "0";
            }


        }
    }
}

