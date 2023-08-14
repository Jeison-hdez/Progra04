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
    public partial class frmVuelos : Form
    {
        public frmVuelos()
        {
            InitializeComponent();
            CargarDatosEnListBoxes();
        }

        

        private void CargarDatosEnListBoxes()
        {
            lstVuelo.Items.Clear();
            lstMarca.Items.Clear();
            lstModelo.Items.Clear();

            // Agrega datos a los ListBox
            AgregarVuelos();
            AgregarMarcas();
            AgregarModelos();
        }

        private void AgregarVuelos()
        {
            lstVuelo.Items.Add("Vuelo 1 - Costa Rica");
            lstVuelo.Items.Add("Vuelo 2 - España");
            lstVuelo.Items.Add("Vuelo 3 - Francia");
            lstVuelo.Items.Add("Vuelo 4 - Italia");
            lstVuelo.Items.Add("Vuelo 5 - Japón");
            lstVuelo.Items.Add("Vuelo 6 - Australia");
            lstVuelo.Items.Add("Vuelo 7 - Canadá");
            lstVuelo.Items.Add("Vuelo 8 - México");
            lstVuelo.Items.Add("Vuelo 9 - Alemania");
            lstVuelo.Items.Add("Vuelo 10 - Brasil");
            lstVuelo.Items.Add("Vuelo 11 - Argentina");
            lstVuelo.Items.Add("Vuelo 12 - China");
            lstVuelo.Items.Add("Vuelo 13 - Rusia");
            lstVuelo.Items.Add("Vuelo 14 - Sudáfrica");
            lstVuelo.Items.Add("Vuelo 15 - India");
            lstVuelo.Items.Add("Vuelo 16 - Ecuador");
            lstVuelo.Items.Add("Vuelo 17 - Reino Unido");
            lstVuelo.Items.Add("Vuelo 18 - Chile");
            lstVuelo.Items.Add("Vuelo 19 - Egipto");
            lstVuelo.Items.Add("Vuelo 20 - Estados Unidos");
        }

        private void AgregarMarcas()
        {
            lstMarca.Items.Add("Boeing");
            lstMarca.Items.Add("Airbus");
            lstMarca.Items.Add("Embraer");
            lstMarca.Items.Add("Bombardier");
            lstMarca.Items.Add("Cessna");
            lstMarca.Items.Add("Dassault");
            lstMarca.Items.Add("Fokker");
            lstMarca.Items.Add("Gulfstream");
            lstMarca.Items.Add("Hawker");
            lstMarca.Items.Add("Lockheed Martin");
            lstMarca.Items.Add("McDonnell Douglas");
            lstMarca.Items.Add("Piper");
            lstMarca.Items.Add("Saab");
            lstMarca.Items.Add("Sukhoi");
            lstMarca.Items.Add("Tupolev");
            lstMarca.Items.Add("Antonov");
            lstMarca.Items.Add("Beechcraft");
            lstMarca.Items.Add("Emivest Aerospace");
            lstMarca.Items.Add("Ilyushin");
            lstMarca.Items.Add("KAI");
        }

        private void AgregarModelos()
        {
            lstModelo.Items.Add("747");
            lstModelo.Items.Add("A380");
            lstModelo.Items.Add("E190");
            lstModelo.Items.Add("CRJ900");
            lstModelo.Items.Add("Citation X");
            lstModelo.Items.Add("Falcon 7X");
            lstModelo.Items.Add("Fokker 100");
            lstModelo.Items.Add("G650");
            lstModelo.Items.Add("Hawker 800");
            lstModelo.Items.Add("F-35 Lightning II");
            lstModelo.Items.Add("MD-80");
            lstModelo.Items.Add("PA-28 Cherokee");
            lstModelo.Items.Add("Saab 340");
            lstModelo.Items.Add("Su-27");
            lstModelo.Items.Add("Tu-154");
            lstModelo.Items.Add("An-225 Mriya");
            lstModelo.Items.Add("King Air");
            lstModelo.Items.Add("Legacy 600");
            lstModelo.Items.Add("Il-76");
            lstModelo.Items.Add("KUH-1 Surion");
        }

        private void btnVerVuelos_Click_1(object sender, EventArgs e)
        {
            if (lstVuelo.SelectedItem != null && lstMarca.SelectedItem != null && lstModelo.SelectedItem != null)
            {
                string vueloSeleccionado = lstVuelo.SelectedItem.ToString();
                string marcaSeleccionada = lstMarca.SelectedItem.ToString();
                string modeloSeleccionado = lstModelo.SelectedItem.ToString();

                txtVueloSeleccionado.Text = $"{vueloSeleccionado} - {marcaSeleccionada} - {modeloSeleccionado}";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vuelo, una marca y un modelo antes de hacer clic en 'Seleccionar'.");
            }
        }

        private void lstModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Codigo Guardar
            conexionBD.conectarBD();
            string insertar = "INSERT INTO tbl_vuelos(Estado,Destino,Piloto,Aerolinea,HoraSalida,HoraLlegada) VALUES(@Estado,@Destino,@Piloto,@Aerolinea,@HoraSalida,@HoraLlegada)";
            SqlCommand cmd = new SqlCommand(insertar, conexionBD.conectarBD());
            
            cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
            cmd.Parameters.AddWithValue("@Destino", txtVueloSeleccionado.Text);
            cmd.Parameters.AddWithValue("@Piloto", txtpiloto.Text);
            cmd.Parameters.AddWithValue("@Aerolinea", txtAerolinea.Text);
            cmd.Parameters.AddWithValue("@HoraSalida", dateTimePicker1.ToString());
            cmd.Parameters.AddWithValue("@HoraLlegada", dateTimePicker2.ToString());
            cmd.ExecuteNonQuery();


            MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
        }

        private void frmVuelos_Load(object sender, EventArgs e)
        {
            conexionBD.conectarBD();
            MessageBox.Show("Conexion Exitosa!!!");
            dataGridView1.DataSource = LLenar_grid1();
            dataGridView2.DataSource = LLenar_grid2();
            dataGridView3.DataSource = LLenar_grid3();


        }

        public DataTable LLenar_grid1()
        {
            //se llena el grid con la tabla de aerolina

            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_vuelos"; //Crear la tabla en BD para lenar el grid
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable LLenar_grid2()
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

        public DataTable LLenar_grid3()
        {
            //se llena el grid con la tabla de aerolina

            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_aerolineas"; //Crear la tabla en BD para lenar el grid
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Codigo Modificar
            conexionBD.conectarBD();
            string actualizar = "UPDATE tbl_vuelos SET  Id=@Id,Estado=@Estado,Destino=@Destino,Piloto=@Piloto,Aerolinea=@Aerolinea,HoraSalida=@HoraSalida,HoraLlegada=@HoraLlegada WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(actualizar, conexionBD.conectarBD());

            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
            cmd.Parameters.AddWithValue("@Destino", txtVueloSeleccionado.Text);
            cmd.Parameters.AddWithValue("@Piloto", txtpiloto.Text);
            cmd.Parameters.AddWithValue("@Aerolinea", txtAerolinea.Text);
            cmd.Parameters.AddWithValue("@HoraSalida", dateTimePicker1.ToString());
            cmd.Parameters.AddWithValue("@HoraLlegada", dateTimePicker2.ToString());

            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Codigo Eliminar
            conexionBD.conectarBD();
            string eliminar = "DELETE FROM tbl_vuelos WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(eliminar, conexionBD.conectarBD());
            
            cmd.ExecuteNonQuery();

            MessageBox.Show("Los datosfueron Eliminados!!!");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            limpiar_txt();

        }

        public void limpiar_txt()
        {
            
            txtEstado.Clear();
            txtId.Clear();
            txtVueloSeleccionado.Clear();
            txtpiloto.Clear();
            txtAerolinea.Clear();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtVueloSeleccionado.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtEstado.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();  //Es para cuando se seleciona la celda se ponga en el dateTP...
            //dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpiloto.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAerolinea.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
    

