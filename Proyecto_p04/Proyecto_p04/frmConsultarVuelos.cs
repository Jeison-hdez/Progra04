using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_p04
{
    public partial class frmConsultarVuelos : Form
    {
        public frmConsultarVuelos()
        {
            InitializeComponent();
        }
        public int valorX = 12;
        public int valorEscala = 0;
        public int valorDestino = 0;
        public string _nombreEScala= "";

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int escala = 0;
            string nombre_escala = "";
            int destino = Convert.ToInt32(cbVuelo.SelectedValue);
            dt = Clases.reportesDAL.getDatosVuelo(destino);
            if (dt.Rows.Count > 0) 
            {
                foreach (DataRow row in dt.Rows)
                {
                    escala = Convert.ToInt32(row["Escala"].ToString());
                    nombre_escala = row["destinoEscala"].ToString();
                }
                _nombreEScala = nombre_escala; 
                DataTable pasajeros = new DataTable();
                pasajeros = Clases.ventanillasDAL.getAsientoV(destino.ToString());
                // LLENAMOS EL AVION CON LOS PASAJEROS
                if (pasajeros.Rows.Count > 0) 
                {
                    foreach (DataRow item in pasajeros.Rows)
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
                    valorX = 12;
                    pnlAvion.Location = new Point(45, 165);
                    progressBar1.Value = 0;
                    timer1.Enabled = true;
                    //CONSULTAMOS SI EL AVION TIENE ESCALA PARA BAJAR PASAJEROS DE ESCALA SINO EL AVION SIGUE SU DESTINO
                    if (escala > 0)
                    {
                        valorEscala = 1;
                        valorDestino = destino;
                    }
                    else
                    {

                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
            }

            if (progressBar1.Value == 50 && valorEscala == 1) 
            {
                timer1.Enabled = false;
                DataTable pasajerosEscala = new DataTable();
                pasajerosEscala = Clases.reportesDAL.getDatosVueloEscala(valorDestino);
                if (pasajerosEscala.Rows.Count > 0)
                {
                    int pasa = 0;
                    foreach (DataRow item in pasajerosEscala.Rows)
                    {
                        string descripcion = item["Asiento"].ToString();
                        // Buscar el control checkbox por su nombre en el formulario
                        CheckBox checkBox = this.Controls[descripcion] as CheckBox;

                        // Verificar si se encontró el checkbox y luego seleccionarlo
                        if (checkBox != null)
                        {
                            checkBox.Checked = false;
                            checkBox.Enabled = true;
                            checkBox.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            checkBox.Checked = true;
                            checkBox.Enabled = false;

                        }
                        pasa++;
                    }
                    MessageBox.Show("EL avion realiza escala en: " + _nombreEScala + " y se bajan " + pasa + " pasajeros a la escala");
                    MessageBox.Show("EL avion toma su rumbo nuevamente a su destino final");
                    timer1.Enabled = true;
                }
            }

            if (progressBar1.Value <= 90)
            {
                valorX = valorX + 45;
                pnlAvion.Location = new Point(valorX, 165);
                progressBar1.Value = progressBar1.Value + 5;
            }
        }

        private void frmConsultarVuelos_Load(object sender, EventArgs e)
        {
            vuelos();
        }

        public void vuelos()
        {
            DataTable dt = new DataTable();
            cbVuelo.ValueMember = "id";
            cbVuelo.DisplayMember = "nombre";

            cbVuelo.DropDownStyle = ComboBoxStyle.DropDownList;
            dt = Clases.reportesDAL.getVuelosCerrados();

            if (dt.Rows.Count > 0)
            {
                cbVuelo.DataSource = new BindingSource(dt, null);
                cbVuelo.DisplayMember = "destino";
                cbVuelo.ValueMember = "id";
            }
        }

        public void avion() 
        {
            DataTable dt = new DataTable();

        }

        public void asientosVuelo() 
        {
            
        }

        public void asientoEscala()
        {

        }

        public void escala() 
        {
        
        }
    }
}
