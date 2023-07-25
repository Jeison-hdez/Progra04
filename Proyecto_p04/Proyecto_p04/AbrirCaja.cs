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
    public partial class AbrirCaja : Form
    {
        public AbrirCaja()
        {
            InitializeComponent();
        }

        SqlConnection conectar2 = new SqlConnection("SERVER=LAPTOP-PORRRASC\\SQLEXPRESS;DATABASE=AeropuertoResi;Integrated security=true");

        private void AbrirCaja_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa!!!");
            dataGridView1.DataSource = LLenar_grid();
            //Es para llenar un pequeño grid, con la informacion de los usuarios (hay que tapar la contraseña)

        }

        public DataTable LLenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM abrir";
            SqlCommand cmd = new SqlCommand(consultar, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;


        }

        private void Loging_Click(object sender, EventArgs e)
            //Se supone que la contraseña se va a comparar de la misma extraida de ñla base de datos y puesta en el texBox
            //Hay que corregir, fue para hacer pruebas

        {
            if (comboBox1.SelectedItem.ToString() == "Adolfo Porras" && textBox1.Text.ToString() == "perro")
            {
                MessageBox.Show("Contraseña correcta");
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }

        }
    }
}

