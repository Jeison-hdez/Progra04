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
            
        }

        

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Codigo Guardar

            

            conexionBD.conectarBD();
            string insertar = "INSERT INTO tbl_aerolineas(Id,Nombre,Identificacin,HoraFecha,Usuario,Destino,Asiento) VALUES(@Id,@Nombre,@Identificacin,@HoraFecha,@Usuario,@Destino,@Asiento)";
            SqlCommand cmd = new SqlCommand(insertar, conexionBD.conectarBD());
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Identificacion", txtIdentificacion.Text);
            cmd.Parameters.AddWithValue("@HoraFecha", txtHoraFecha.Text);
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Destino", txtNV.Text);
            //cmd.Parameters.AddWithValue("@Asiento",  control); //esta es la variable para los nombres de los chbt

            cmd.ExecuteNonQuery();


            MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
            dataGridView1.DataSource = LLenar_grid();




        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Codigo Modificar
            conexionBD.conectarBD();
            string actualizar = "UPDATE tbl_aerolineas SET Id=@Id,Identificacion=@Identificacion,Estado=@Estado,Nombre=@Nombre,PaisOrigen=@PaisOrigen," +
            "WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(actualizar, conexionBD.conectarBD());
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Identificacion", txtIdentificacion.Text);
            cmd.Parameters.AddWithValue("@HoraFecha", txtHoraFecha.Text);
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Destino", txtNV.Text);
            //cmd.Parameters.AddWithValue("@Asiento", Asientos()); //esta es la variable para los nombres de los chbt


            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
            dataGridView1.DataSource = LLenar_grid();
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
            txtIdentificacion.Clear();
            txtHoraFecha.Clear();
            txtId.Clear();
            txtNV.Clear();
            txtUsuario.Clear();
            txtNombre.Clear();

        }

        //Esta es la clase para asignar los numero de los chBoton para la Base de Datos
        public void Asientos()
        {
            //Parte F. Guardar el numero del asiento.

            string control;
            int numero = 0; 

            if (f1.Checked)
            {
                control = "f1";
                numero++;
                f1.BackColor = Color.Red;
                f1.Enabled = false;
                control.ToString();
            }
            else if (f2.Checked)
            {
                control = "f2";
                numero++;
                f2.BackColor = Color.Red;
                f2.Enabled = false;
                control.ToString();
            }
            else if (f3.Checked)
            {
                control = "f3";
                numero++;
                f3.BackColor = Color.Red;
                f3.Enabled = false;
                control.ToString();
            }
            else if (f4.Checked)
            {
                control = "f4";
                numero++;
                f4.BackColor = Color.Red;
                f4.Enabled = false;
                control.ToString();
            }

            else if (f7.Checked)
            {
                control = "f7";
                numero++;
                f7.BackColor = Color.Red;
                f7.Enabled = false;
                control.ToString();
            }
            else if (f8.Checked)
            {
                control = "f8";
                numero++;
                f8.BackColor = Color.Red;
                f8.Enabled = false;
                control.ToString();
            }

            else if (f10.Checked)
            {
                control = "f10";
                numero++;
                f10.BackColor = Color.Red;
                f10.Enabled = false;
                control.ToString();
            }
            else if (f11.Checked)
            {
                control = "f11";
                numero++;
                f11.BackColor = Color.Red;
                f11.Enabled = false;
                control.ToString();
            }
            else if (f12.Checked)
            {
                control = "f12";
                numero++;
                f12.BackColor = Color.Red;
                f12.Enabled = false;
                control.ToString();
            }

            else if (f14.Checked)
            {
                control = "f14";
                numero++;
                f14.BackColor = Color.Red;
                f14.Enabled = false;
                control.ToString();
            }
            else if (f15.Checked)
            {
                control = "f15";
                numero++;
                f15.BackColor = Color.Red;
                f15.Enabled = false;
                control.ToString();
            }
            else if (f20.Checked)
            {
                control = "f20";
                numero++;
                f20.BackColor = Color.Red;
                f20.Enabled = false;
                control.ToString();
            }
            else if (f21.Checked)
            {
                control = "f21";
                numero++;
                f21.BackColor = Color.Red;
                f21.Enabled = false;
                control.ToString();
            }
            else if (f22.Checked)
            {
                control = "f22";
                numero++;
                f22.BackColor = Color.Red;
                f22.Enabled = false;
                control.ToString();
            }
            else if (f23.Checked)
            {
                control = "f23";
                numero++;
                f23.BackColor = Color.Red;
                f23.Enabled = false;
                control.ToString();
            }
            else if (f24.Checked)
            {
                control = "f24";
                numero++;
                f24.BackColor = Color.Red;
                f24.Enabled = false;
                control.ToString();
            }
            else if (f25.Checked)
            {
                control = "f25";
                numero++;
                f25.BackColor = Color.Red;
                f25.Enabled = false;
                control.ToString();
            }
            else if (f26.Checked)
            {
                control = "f26";
                numero++;
                f26.BackColor = Color.Red;
                f26.Enabled = false;
                control.ToString();
            }
            else if (f27.Checked)
            {
                control = "f27";
                numero++;
                f27.BackColor = Color.Red;
                f27.Enabled = false;
                control.ToString();
            }
            else if (f28.Checked)
            {
                control = "f28";
                numero++;
                f28.BackColor = Color.Red;
                f28.Enabled = false;
                control.ToString();
            }
            else if (f29.Checked)
            {
                control = "f29";
                numero++;
                f29.BackColor = Color.Red;
                f29.Enabled = false;
                control.ToString();
            }
            else if (f30.Checked)
            {
                control = "f30";
                numero++;
                f30.BackColor = Color.Red;
                f30.Enabled = false;
                control.ToString();
            }
            else if (f31.Checked)
            {
                control = "f31";
                numero++;
                f31.BackColor = Color.Red;
                f31.Enabled = false;
                control.ToString();
            }
            else if (f32.Checked)
            {
                control = "f32";
                numero++;
                f32.BackColor = Color.Red;
                f32.Enabled = false;
                control.ToString();
            }
            else if (f34.Checked)
            {
                control = "f34";
                numero++;
                f34.BackColor = Color.Red;
                f34.Enabled = false;
                control.ToString();
            }
            else if (f35.Checked)
            {
                control = "f35";
                numero++;
                f35.BackColor = Color.Red;
                f35.Enabled = false;
                control.ToString();
            }
            else if (f36.Checked)
            {
                control = "f36";
                numero++;
                f36.BackColor = Color.Red;
                f36.Enabled = false;
                control.ToString();
            }
            else if (f37.Checked)
            {
                control = "f37";
                numero++;
                f37.BackColor = Color.Red;
                f37.Enabled = false;
                control.ToString();
            }
            else if (f38.Checked)
            {
                control = "f38";
                numero++;
                f38.BackColor = Color.Red;
                f38.Enabled = false;
                control.ToString();
            }
            else
            {
                control = "f0";
                control.ToString();
            }

            ///////////// parte E

            if (e1.Checked)
            {
                control = "e1";
                numero++;
                e1.BackColor = Color.Red;
                e1.Enabled = false;
            }
            else if (e2.Checked)
            {
                control = "e2";
                numero++;
                e2.BackColor = Color.Red;
                e2.Enabled = false;
            }
            else if (e3.Checked)
            {
                control = "e3";
                numero++;
                e3.BackColor = Color.Red;
                e3.Enabled = false;
            }
            else if (e4.Checked)
            {
                control = "e4";
                numero++;
                e4.BackColor = Color.Red;
                e4.Enabled = false;
            }

            else if (e7.Checked)
            {
                control = "e7";
                numero++;
                e7.BackColor = Color.Red;
                e7.Enabled = false;
            }
            else if (e8.Checked)
            {
                control = "e8";
                numero++;
                e8.BackColor = Color.Red;
                e8.Enabled = false;
            }

            else if (e10.Checked)
            {
                control = "e10";
                numero++;
                e10.BackColor = Color.Red;
                e10.Enabled = false;
            }
            else if (e11.Checked)
            {
                control = "e11";
                numero++;
                e11.BackColor = Color.Red;
                e11.Enabled = false;
            }
            else if (e12.Checked)
            {
                control = "e12";
                numero++;
                e12.BackColor = Color.Red;
                e12.Enabled = false;
            }

            else if (e14.Checked)
            {
                control = "e14";
                numero++;
                e14.BackColor = Color.Red;
                e14.Enabled = false;
            }
            else if (e15.Checked)
            {
                control = "e15";
                numero++;
                e15.BackColor = Color.Red;
                e15.Enabled = false;
            }
            else if (e20.Checked)
            {
                control = "e20";
                numero++;
                e20.BackColor = Color.Red;
                e20.Enabled = false;
            }
            else if (e21.Checked)
            {
                control = "e21";
                numero++;
                e21.BackColor = Color.Red;
                e21.Enabled = false;
            }
            else if (e22.Checked)
            {
                control = "e22";
                numero++;
                e22.BackColor = Color.Red;
                e22.Enabled = false;
            }
            else if (e23.Checked)
            {
                control = "e23";
                numero++;
                e23.BackColor = Color.Red;
                e23.Enabled = false;
            }
            else if (e24.Checked)
            {
                control = "e24";
                numero++;
                e24.BackColor = Color.Red;
                e24.Enabled = false;
            }
            else if (e25.Checked)
            {
                control = "e25";
                numero++;
                e25.BackColor = Color.Red;
                e25.Enabled = false;
            }
            else if (e26.Checked)
            {
                control = "e26";
                numero++;
                e26.BackColor = Color.Red;
                e26.Enabled = false;
            }
            else if (e27.Checked)
            {
                control = "e27";
                numero++;
                e27.BackColor = Color.Red;
                e27.Enabled = false;
            }
            else if (e28.Checked)
            {
                control = "e28";
                numero++;
                e28.BackColor = Color.Red;
                e28.Enabled = false;
            }
            else if (e29.Checked)
            {
                control = "e29";
                numero++;
                e29.BackColor = Color.Red;
                e29.Enabled = false;
            }
            else if (e30.Checked)
            {
                control = "e30";
                numero++;
                e30.BackColor = Color.Red;
                e30.Enabled = false;
            }
            else if (e31.Checked)
            {
                control = "e31";
                numero++;
                e31.BackColor = Color.Red;
                e31.Enabled = false;
            }
            else if (e32.Checked)
            {
                control = "e32";
                numero++;
                e32.BackColor = Color.Red;
                e32.Enabled = false;
            }
            else if (e34.Checked)
            {
                control = "e34";
                numero++;
                e34.BackColor = Color.Red;
                e34.Enabled = false;
            }
            else if (e35.Checked)
            {
                control = "e35";
                numero++;
                e35.BackColor = Color.Red;
                e35.Enabled = false;
            }
            else if (e36.Checked)
            {
                control = "e36";
                numero++;
                e36.BackColor = Color.Red;
                e36.Enabled = false;
            }
            else if (e37.Checked)
            {
                control = "e37";
                numero++;
                e37.BackColor = Color.Red;
                e37.Enabled = false;
            }
            else if (e38.Checked)
            {
                control = "e38";
                numero++;
                e38.BackColor = Color.Red;
                e38.Enabled = false;
            }
            else
            {
                control = "e0";
            }



            //////////// Parte D

            if (d7.Checked)
            {
                control = "d7";
                numero++;
                d7.BackColor = Color.Red;
                d7.Enabled = false;
            }
            else if (d8.Checked)
            {
                control = "d8";
                numero++;
                d8.BackColor = Color.Red;
                d8.Enabled = false;
            }

            else if (d10.Checked)
            {
                control = "d10";
                numero++;
                d10.BackColor = Color.Red;
                d10.Enabled = false;
            }
            else if (d11.Checked)
            {
                control = "d11";
                numero++;
                d11.BackColor = Color.Red;
                d11.Enabled = false;
            }
            else if (d12.Checked)
            {
                control = "d12";
                numero++;
                d12.BackColor = Color.Red;
                d12.Enabled = false;
            }

            else if (d14.Checked)
            {
                control = "d14";
                numero++;
                d14.BackColor = Color.Red;
                d14.Enabled = false;
            }
            else if (d15.Checked)
            {
                control = "d15";
                numero++;
                d15.BackColor = Color.Red;
                d15.Enabled = false;
            }
            else if (d20.Checked)
            {
                control = "d20";
                numero++;
                d20.BackColor = Color.Red;
                d20.Enabled = false;
            }
            else if (d21.Checked)
            {
                control = "d21";
                numero++;
                d21.BackColor = Color.Red;
                d21.Enabled = false;
            }
            else if (d22.Checked)
            {
                control = "d22";
                numero++;
                d22.BackColor = Color.Red;
                d22.Enabled = false;
            }
            else if (d23.Checked)
            {
                control = "d23";
                numero++;
                d23.BackColor = Color.Red;
                d23.Enabled = false;
            }
            else if (d24.Checked)
            {
                control = "d24";
                numero++;
                d24.BackColor = Color.Red;
                d24.Enabled = false;
            }
            else if (d25.Checked)
            {
                control = "d25";
                numero++;
                d25.BackColor = Color.Red;
                d25.Enabled = false;
            }
            else if (d26.Checked)
            {
                control = "d26";
                numero++;
                d26.BackColor = Color.Red;
                d26.Enabled = false;
            }
            else if (d27.Checked)
            {
                control = "d27";
                numero++;
                d27.BackColor = Color.Red;
                d27.Enabled = false;
            }
            else if (d28.Checked)
            {
                control = "d28";
                numero++;
                d28.BackColor = Color.Red;
                d28.Enabled = false;
            }
            else if (d29.Checked)
            {
                control = "d29";
                numero++;
                d29.BackColor = Color.Red;
                d29.Enabled = false;
            }
            else if (d30.Checked)
            {
                control = "d30";
                numero++;
                d30.BackColor = Color.Red;
                d30.Enabled = false;
            }
            else if (d31.Checked)
            {
                control = "d31";
                numero++;
                d31.BackColor = Color.Red;
                d31.Enabled = false;
            }
            else if (d32.Checked)
            {
                control = "d32";
                numero++;
                d32.BackColor = Color.Red;
                d32.Enabled = false;
            }
            else if (d34.Checked)
            {
                control = "d34";
                numero++;
                d34.BackColor = Color.Red;
                d34.Enabled = false;
            }
            else if (d35.Checked)
            {
                control = "d35";
                numero++;
                d35.BackColor = Color.Red;
                d35.Enabled = false;
            }
            else if (d36.Checked)
            {
                control = "d36";
                numero++;
                d36.BackColor = Color.Red;
                d36.Enabled = false;
            }
            else if (d37.Checked)
            {
                control = "d37";
                numero++;
                d37.BackColor = Color.Red;
                d37.Enabled = false;
            }
            else if (d38.Checked)
            {
                control = "d38";
                numero++;
                d38.BackColor = Color.Red;
                d38.Enabled = false;
            }
            else
            {
                control = "d0";
            }



            /////////// parte C

            if (c7.Checked)
            {
                control = "c7";
                numero++;
                c7.BackColor = Color.Red;
                c7.Enabled = false;
            }
            else if (c8.Checked)
            {
                control = "c8";
                numero++;
                c8.BackColor = Color.Red;
                c8.Enabled = false;
            }
            else if (c10.Checked)
            {
                control = "c10";
                numero++;
                c10.BackColor = Color.Red;
                c10.Enabled = false;
            }
            else if (c11.Checked)
            {
                control = "c11";
                numero++;
                c11.BackColor = Color.Red;
                c11.Enabled = false;
            }
            else if (c12.Checked)
            {
                control = "c12";
                numero++;
                c12.BackColor = Color.Red;
                c12.Enabled = false;
            }

            else if (c14.Checked)
            {
                control = "c14";
                numero++;
                c14.BackColor = Color.Red;
                c14.Enabled = false;
            }
            else if (c15.Checked)
            {
                control = "c15";
                numero++;
                c15.BackColor = Color.Red;
                c15.Enabled = false;
            }
            else if (c20.Checked)
            {
                control = "c20";
                numero++;
                c20.BackColor = Color.Red;
                c20.Enabled = false;
            }
            else if (c21.Checked)
            {
                control = "c21";
                numero++;
                c21.BackColor = Color.Red;
                c21.Enabled = false;
            }
            else if (c22.Checked)
            {
                control = "c22";
                numero++;
                c22.BackColor = Color.Red;
                c22.Enabled = false;
            }
            else if (c23.Checked)
            {
                control = "c23";
                numero++;
                c23.BackColor = Color.Red;
                c23.Enabled = false;
            }
            else if (c24.Checked)
            {
                control = "c24";
                numero++;
                c24.BackColor = Color.Red;
                c24.Enabled = false;
            }
            else if (c25.Checked)
            {
                control = "c25";
                numero++;
                c25.BackColor = Color.Red;
                c25.Enabled = false;
            }
            else if (c26.Checked)
            {
                control = "c26";
                numero++;
                c26.BackColor = Color.Red;
                c26.Enabled = false;
            }
            else if (c27.Checked)
            {
                control = "c27";
                numero++;
                c27.BackColor = Color.Red;
                c27.Enabled = false;
            }
            else if (c28.Checked)
            {
                control = "c28";
                numero++;
                c28.BackColor = Color.Red;
                c28.Enabled = false;
            }
            else if (c29.Checked)
            {
                control = "c29";
                numero++;
                c29.BackColor = Color.Red;
                c29.Enabled = false;
            }
            else if (c30.Checked)
            {
                control = "c30";
                numero++;
                c30.BackColor = Color.Red;
                c30.Enabled = false;
            }
            else if (c31.Checked)
            {
                control = "c31";
                numero++;
                c31.BackColor = Color.Red;
                c31.Enabled = false;
            }
            else if (c32.Checked)
            {
                control = "c32";
                numero++;
                c32.BackColor = Color.Red;
                c32.Enabled = false;
            }
            else if (c34.Checked)
            {
                control = "c34";
                numero++;
                c34.BackColor = Color.Red;
                c34.Enabled = false;
            }
            else if (c35.Checked)
            {
                control = "c35";
                numero++;
                c35.BackColor = Color.Red;
                c35.Enabled = false;
            }
            else if (c36.Checked)
            {
                control = "c36";
                numero++;
                c36.BackColor = Color.Red;
                c36.Enabled = false;
            }
            else if (c37.Checked)
            {
                control = "c37";
                numero++;
                c37.BackColor = Color.Red;
                c37.Enabled = false;
            }
            else if (c38.Checked)
            {
                control = "c38";
                numero++;
                c38.BackColor = Color.Red;
                c38.Enabled = false;
            }
            else
            {
                control = "c0";
            }

            ///////// parte B

            if (b1.Checked)
            {
                control = "b1";
                numero++;
                b1.BackColor = Color.Red;
                b1.Enabled = false;
            }
            else if (b2.Checked)
            {
                control = "b2";
                numero++;
                b2.BackColor = Color.Red;
                b2.Enabled = false;
            }
            else if (b3.Checked)
            {
                control = "b3";
                numero++;
                b3.BackColor = Color.Red;
                b3.Enabled = false;
            }
            else if (b4.Checked)
            {
                control = "b4";
                numero++;
                b4.BackColor = Color.Red;
                b4.Enabled = false;
            }

            else if (b7.Checked)
            {
                control = "b7";
                numero++;
                b7.BackColor = Color.Red;
                b7.Enabled = false;
            }
            else if (b8.Checked)
            {
                control = "b8";
                numero++;
                b8.BackColor = Color.Red;
                b8.Enabled = false;
            }

            else if (b10.Checked)
            {
                control = "b10";
                numero++;
                b10.BackColor = Color.Red;
                b10.Enabled = false;
            }
            else if (b11.Checked)
            {
                control = "b11";
                numero++;
                b11.BackColor = Color.Red;
                b11.Enabled = false;
            }
            else if (b12.Checked)
            {
                control = "b12";
                numero++;
                b12.BackColor = Color.Red;
                b12.Enabled = false;
            }

            else if (b14.Checked)
            {
                control = "b14";
                numero++;
                b14.BackColor = Color.Red;
                b14.Enabled = false;
            }
            else if (b15.Checked)
            {
                control = "b15";
                numero++;
                b15.BackColor = Color.Red;
                b15.Enabled = false;
            }
            else if (b20.Checked)
            {
                control = "b20";
                numero++;
                b20.BackColor = Color.Red;
                b20.Enabled = false;
            }
            else if (b21.Checked)
            {
                control = "b21";
                numero++;
                b21.BackColor = Color.Red;
                b21.Enabled = false;
            }
            else if (b22.Checked)
            {
                control = "b22";
                numero++;
                b22.BackColor = Color.Red;
                b22.Enabled = false;
            }
            else if (b23.Checked)
            {
                control = "b23";
                numero++;
                b23.BackColor = Color.Red;
                b23.Enabled = false;
            }
            else if (b24.Checked)
            {
                control = "b24";
                numero++;
                b24.BackColor = Color.Red;
                b24.Enabled = false;
            }
            else if (b25.Checked)
            {
                control = "b25";
                numero++;
                b25.BackColor = Color.Red;
                b25.Enabled = false;
            }
            else if (b26.Checked)
            {
                control = "b26";
                numero++;
                b26.BackColor = Color.Red;
                b26.Enabled = false;
            }
            else if (b27.Checked)
            {
                control = "b27";
                numero++;
                b27.BackColor = Color.Red;
                b27.Enabled = false;
            }
            else if (b28.Checked)
            {
                control = "b28";
                numero++;
                b28.BackColor = Color.Red;
                b28.Enabled = false;
            }
            else if (b29.Checked)
            {
                control = "b29";
                numero++;
                b29.BackColor = Color.Red;
                b29.Enabled = false;
            }
            else if (b30.Checked)
            {
                control = "b30";
                numero++;
                b30.BackColor = Color.Red;
                b30.Enabled = false;
            }
            else if (b31.Checked)
            {
                control = "b31";
                numero++;
                b31.BackColor = Color.Red;
                b31.Enabled = false;
            }
            else if (b32.Checked)
            {
                control = "b32";
                numero++;
                b32.BackColor = Color.Red;
                b32.Enabled = false;
            }
            else if (b34.Checked)
            {
                control = "b34";
                numero++;
                b34.BackColor = Color.Red;
                b34.Enabled = false;
            }
            else if (b35.Checked)
            {
                control = "b35";
                numero++;
                b35.BackColor = Color.Red;
                b35.Enabled = false;
            }
            else if (b36.Checked)
            {
                control = "b36";
                numero++;
                b36.BackColor = Color.Red;
                b36.Enabled = false;
            }
            else if (b37.Checked)
            {
                control = "b37";
                numero++;
                b37.BackColor = Color.Red;
                b37.Enabled = false;
            }
            else if (b38.Checked)
            {
                control = "b38";
                numero++;
                b38.BackColor = Color.Red;
                b38.Enabled = false;
            }
            else
            {
                control = "b0";
            }



            /////////// Parte A

            if (a1.Checked)
            {
                control = "a1";
                numero++;
                a1.BackColor = Color.Red;
                a1.Enabled = false;
            }
            else if (a2.Checked)
            {
                control = "a2";
                numero++;
                a2.BackColor = Color.Red;
                a2.Enabled = false;
            }
            else if (a3.Checked)
            {
                control = "a3";
                numero++;
                a3.BackColor = Color.Red;
                a3.Enabled = false;
            }
            else if (a4.Checked)
            {
                control = "a4";
                numero++;
                a4.BackColor = Color.Red;
                a4.Enabled = false;
            }

            else if (a7.Checked)
            {
                control = "a7";
                numero++;
                a7.BackColor = Color.Red;
                a7.Enabled = false;
            }
            else if (a8.Checked)
            {
                control = "a8";
                numero++;
                a8.BackColor = Color.Red;
                a8.Enabled = false;
            }

            else if (a10.Checked)
            {
                control = "a10";
                numero++;
                a10.BackColor = Color.Red;
                a10.Enabled = false;
            }
            else if (a11.Checked)
            {
                control = "a11";
                numero++;
                a11.BackColor = Color.Red;
                a11.Enabled = false;
            }
            else if (a12.Checked)
            {
                control = "a12";
                numero++;
                a12.BackColor = Color.Red;
                a12.Enabled = false;
            }

            else if (a14.Checked)
            {
                control = "a14";
                numero++;
                a14.BackColor = Color.Red;
                a14.Enabled = false;
            }
            else if (a15.Checked)
            {
                control = "a15";
                numero++;
                a15.BackColor = Color.Red;
                a15.Enabled = false;
            }
            else if (a20.Checked)
            {
                control = "a20";
                numero++;
                a20.BackColor = Color.Red;
                a20.Enabled = false;
            }
            else if (a21.Checked)
            {
                control = "a21";
                numero++;
                a21.BackColor = Color.Red;
                a21.Enabled = false;
            }
            else if (a22.Checked)
            {
                control = "a22";
                numero++;
                a22.BackColor = Color.Red;
                a22.Enabled = false;
            }
            else if (a23.Checked)
            {
                control = "a23";
                numero++;
                a23.BackColor = Color.Red;
                a23.Enabled = false;
            }
            else if (a24.Checked)
            {
                control = "a24";
                numero++;
                a24.BackColor = Color.Red;
                a24.Enabled = false;
            }
            else if (a25.Checked)
            {
                control = "a25";
                numero++;
                a25.BackColor = Color.Red;
                a25.Enabled = false;
            }
            else if (a26.Checked)
            {
                control = "a26";
                numero++;
                a26.BackColor = Color.Red;
                a26.Enabled = false;
            }
            else if (a27.Checked)
            {
                control = "a27";
                numero++;
                a27.BackColor = Color.Red;
                a27.Enabled = false;
            }
            else if (a28.Checked)
            {
                control = "a28";
                numero++;
                a28.BackColor = Color.Red;
                a28.Enabled = false;
            }
            else if (a29.Checked)
            {
                control = "a29";
                numero++;
                a29.BackColor = Color.Red;
                a29.Enabled = false;
            }
            else if (a30.Checked)
            {
                control = "a30";
                numero++;
                a30.BackColor = Color.Red;
                a30.Enabled = false;
            }
            else if (a31.Checked)
            {
                control = "a31";
                numero++;
                a31.BackColor = Color.Red;
                a31.Enabled = false;
            }
            else if (a32.Checked)
            {
                control = "a32";
                numero++;
                a32.BackColor = Color.Red;
                a32.Enabled = false;
            }
            else if (a34.Checked)
            {
                control = "a34";
                numero++;
                a34.BackColor = Color.Red;
                a34.Enabled = false;
            }
            else if (a35.Checked)
            {
                control = "a35";
                numero++;
                a35.BackColor = Color.Red;
                a35.Enabled = false;
            }
            else if (a36.Checked)
            {
                control = "a36";
                numero++;
                a36.BackColor = Color.Red;
                a36.Enabled = false;
            }
            else if (a37.Checked)
            {
                control = "a37";
                numero++;
                a37.BackColor = Color.Red;
                a37.Enabled = false;
            }
            else if (a38.Checked)
            {
                control = "a38";
                numero++;
                a38.BackColor = Color.Red;
                a38.Enabled = false;
            }
            else
            {
                control = "a0";
            }



        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
