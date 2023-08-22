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
                MessageBox.Show("El avion a llegado al destino final.\nGracias");
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

            if (progressBar1.Value > 90)
            {
                quitarAsientosCH();
                
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

        public void quitarAsientosCH()
        {
            /////checkBox////////

            a1.Checked = false;
            a2.Checked = false;
            a3.Checked = false;
            a4.Checked = false;
            a7.Checked = false;
            a8.Checked = false;
            a10.Checked = false;
            a11.Checked = false;
            a12.Checked = false;
            a14.Checked = false;
            a15.Checked = false;
            a20.Checked = false;
            a21.Checked = false;
            a22.Checked = false;
            a23.Checked = false;
            a24.Checked = false;
            a25.Checked = false;
            a26.Checked = false;
            a27.Checked = false;
            a28.Checked = false;
            a29.Checked = false;
            a30.Checked = false;
            a31.Checked = false;
            a32.Checked = false;
            a34.Checked = false;
            a35.Checked = false;
            a36.Checked = false;
            a37.Checked = false;
            a38.Checked = false;



            b1.Checked = false;
            b2.Checked = false;
            b3.Checked = false;
            b4.Checked = false;
            b7.Checked = false;
            b8.Checked = false;
            b10.Checked = false;
            b11.Checked = false;
            b12.Checked = false;
            b14.Checked = false;
            b15.Checked = false;
            b20.Checked = false;
            b21.Checked = false;
            b22.Checked = false;
            b23.Checked = false;
            b24.Checked = false;
            b25.Checked = false;
            b26.Checked = false;
            b27.Checked = false;
            b28.Checked = false;
            b29.Checked = false;
            b30.Checked = false;
            b31.Checked = false;
            b32.Checked = false;
            b34.Checked = false;
            b35.Checked = false;
            b36.Checked = false;
            b37.Checked = false;
            b38.Checked = false;


            
            c7.Checked = false;
            c8.Checked = false;
            c10.Checked = false;
            c11.Checked = false;
            c12.Checked = false;
            c14.Checked = false;
            c15.Checked = false;
            c20.Checked = false;
            c21.Checked = false;
            c22.Checked = false;
            c23.Checked = false;
            c24.Checked = false;
            c25.Checked = false;
            c26.Checked = false;
            c27.Checked = false;
            c28.Checked = false;
            c29.Checked = false;
            c30.Checked = false;
            c31.Checked = false;
            c32.Checked = false;
            c34.Checked = false;
            c35.Checked = false;
            c36.Checked = false;
            c37.Checked = false;
            c38.Checked = false;



            d7.Checked = false;
            d8.Checked = false;
            d10.Checked = false;
            d11.Checked = false;
            d12.Checked = false;
            d14.Checked = false;
            d15.Checked = false;
            d20.Checked = false;
            d21.Checked = false;
            d22.Checked = false;
            d23.Checked = false;
            d24.Checked = false;
            d25.Checked = false;
            d26.Checked = false;
            d27.Checked = false;
            d28.Checked = false;
            d29.Checked = false;
            d30.Checked = false;
            d31.Checked = false;
            d32.Checked = false;
            d34.Checked = false;
            d35.Checked = false;
            d36.Checked = false;
            d37.Checked = false;
            d38.Checked = false;


            e1.Checked = false;
            e2.Checked = false;
            e3.Checked = false;
            e4.Checked = false;
            e7.Checked = false;
            e8.Checked = false;
            e10.Checked = false;
            e11.Checked = false;
            e12.Checked = false;
            e14.Checked = false;
            e15.Checked = false;
            e20.Checked = false;
            e21.Checked = false;
            e22.Checked = false;
            e23.Checked = false;
            e24.Checked = false;
            e25.Checked = false;
            e26.Checked = false;
            e27.Checked = false;
            e28.Checked = false;
            e29.Checked = false;
            e30.Checked = false;
            e31.Checked = false;
            e32.Checked = false;
            e34.Checked = false;
            e35.Checked = false;
            e36.Checked = false;
            e37.Checked = false;
            e38.Checked = false;


            f1.Checked = false;
            f2.Checked = false;
            f3.Checked = false;
            f4.Checked = false;
            f7.Checked = false;
            f8.Checked = false;
            f10.Checked = false;
            f11.Checked = false;
            f12.Checked = false;
            f14.Checked = false;
            f15.Checked = false;
            f20.Checked = false;
            f21.Checked = false;
            f22.Checked = false;
            f23.Checked = false;
            f24.Checked = false;
            f25.Checked = false;
            f26.Checked = false;
            f27.Checked = false;
            f28.Checked = false;
            f29.Checked = false;
            f30.Checked = false;
            f31.Checked = false;
            f32.Checked = false;
            f34.Checked = false;
            f35.Checked = false;
            f36.Checked = false;
            f37.Checked = false;
            f38.Checked = false;

            /////color/////////
           
            a1.BackColor = Color.Transparent;
            a2.BackColor = Color.Transparent;
            a3.BackColor = Color.Transparent;
            a4.BackColor = Color.Transparent;
            a7.BackColor = Color.Transparent;
            a8.BackColor = Color.Transparent;
            a10.BackColor = Color.Transparent;
            a11.BackColor = Color.Transparent;
            a12.BackColor = Color.Transparent;
            a14.BackColor = Color.Transparent;
            a15.BackColor = Color.Transparent;
            a20.BackColor = Color.Transparent;
            a21.BackColor = Color.Transparent;
            a22.BackColor = Color.Transparent;
            a23.BackColor = Color.Transparent;
            a24.BackColor = Color.Transparent;
            a25.BackColor = Color.Transparent;
            a26.BackColor = Color.Transparent;
            a27.BackColor = Color.Transparent;
            a28.BackColor = Color.Transparent;
            a29.BackColor = Color.Transparent;
            a30.BackColor = Color.Transparent;
            a31.BackColor = Color.Transparent;
            a32.BackColor = Color.Transparent;
            a34.BackColor = Color.Transparent;
            a35.BackColor = Color.Transparent;
            a36.BackColor = Color.Transparent;
            a37.BackColor = Color.Transparent;
            a38.BackColor = Color.Transparent;

            b1.BackColor = Color.Transparent;
            b2.BackColor = Color.Transparent;
            b3.BackColor = Color.Transparent;
            b4.BackColor = Color.Transparent;
            b7.BackColor = Color.Transparent;
            b8.BackColor = Color.Transparent;
            b10.BackColor = Color.Transparent;
            b11.BackColor = Color.Transparent;
            b12.BackColor = Color.Transparent;
            b14.BackColor = Color.Transparent;
            b15.BackColor = Color.Transparent;
            b20.BackColor = Color.Transparent;
            b21.BackColor = Color.Transparent;
            b22.BackColor = Color.Transparent;
            b23.BackColor = Color.Transparent;
            b24.BackColor = Color.Transparent;
            b25.BackColor = Color.Transparent;
            b26.BackColor = Color.Transparent;
            b27.BackColor = Color.Transparent;
            b28.BackColor = Color.Transparent;
            b29.BackColor = Color.Transparent;
            b30.BackColor = Color.Transparent;
            b31.BackColor = Color.Transparent;
            b32.BackColor = Color.Transparent;
            b34.BackColor = Color.Transparent;
            b35.BackColor = Color.Transparent;
            b36.BackColor = Color.Transparent;
            b37.BackColor = Color.Transparent;
            b38.BackColor = Color.Transparent;


            c7.BackColor = Color.Transparent;
            c8.BackColor = Color.Transparent;
            c10.BackColor = Color.Transparent;
            c11.BackColor = Color.Transparent;
            c12.BackColor = Color.Transparent;
            c14.BackColor = Color.Transparent;
            c15.BackColor = Color.Transparent;
            c20.BackColor = Color.Transparent;
            c21.BackColor = Color.Transparent;
            c22.BackColor = Color.Transparent;
            c23.BackColor = Color.Transparent;
            c24.BackColor = Color.Transparent;
            c25.BackColor = Color.Transparent;
            c26.BackColor = Color.Transparent;
            c27.BackColor = Color.Transparent;
            c28.BackColor = Color.Transparent;
            c29.BackColor = Color.Transparent;
            c30.BackColor = Color.Transparent;
            c31.BackColor = Color.Transparent;
            c32.BackColor = Color.Transparent;
            c34.BackColor = Color.Transparent;
            c35.BackColor = Color.Transparent;
            c36.BackColor = Color.Transparent;
            c37.BackColor = Color.Transparent;
            c38.BackColor = Color.Transparent;


            d7.BackColor = Color.Transparent;
            d8.BackColor = Color.Transparent;
            d10.BackColor = Color.Transparent;
            d11.BackColor = Color.Transparent;
            d12.BackColor = Color.Transparent;
            d14.BackColor = Color.Transparent;
            d15.BackColor = Color.Transparent;
            d20.BackColor = Color.Transparent;
            d21.BackColor = Color.Transparent;
            d22.BackColor = Color.Transparent;
            d23.BackColor = Color.Transparent;
            d24.BackColor = Color.Transparent;
            d25.BackColor = Color.Transparent;
            d26.BackColor = Color.Transparent;
            d27.BackColor = Color.Transparent;
            d28.BackColor = Color.Transparent;
            d29.BackColor = Color.Transparent;
            d30.BackColor = Color.Transparent;
            d31.BackColor = Color.Transparent;
            d32.BackColor = Color.Transparent;
            d34.BackColor = Color.Transparent;
            d35.BackColor = Color.Transparent;
            d36.BackColor = Color.Transparent;
            d37.BackColor = Color.Transparent;
            d38.BackColor = Color.Transparent;


            e1.BackColor = Color.Transparent;
            e2.BackColor = Color.Transparent;
            e3.BackColor = Color.Transparent;
            e4.BackColor = Color.Transparent;
            e7.BackColor = Color.Transparent;
            e8.BackColor = Color.Transparent;
            e10.BackColor = Color.Transparent;
            e11.BackColor = Color.Transparent;
            e12.BackColor = Color.Transparent;
            e14.BackColor = Color.Transparent;
            e15.BackColor = Color.Transparent;
            e20.BackColor = Color.Transparent;
            e21.BackColor = Color.Transparent;
            e22.BackColor = Color.Transparent;
            e23.BackColor = Color.Transparent;
            e24.BackColor = Color.Transparent;
            e25.BackColor = Color.Transparent;
            e26.BackColor = Color.Transparent;
            e27.BackColor = Color.Transparent;
            e28.BackColor = Color.Transparent;
            e29.BackColor = Color.Transparent;
            e30.BackColor = Color.Transparent;
            e31.BackColor = Color.Transparent;
            e32.BackColor = Color.Transparent;
            e34.BackColor = Color.Transparent;
            e35.BackColor = Color.Transparent;
            e36.BackColor = Color.Transparent;
            e37.BackColor = Color.Transparent;
            e38.BackColor = Color.Transparent;


            f1.BackColor = Color.Transparent;
            f2.BackColor = Color.Transparent;
            f3.BackColor = Color.Transparent;
            f4.BackColor = Color.Transparent;
            f7.BackColor = Color.Transparent;
            f8.BackColor = Color.Transparent;
            f10.BackColor = Color.Transparent;
            f11.BackColor = Color.Transparent;
            f12.BackColor = Color.Transparent;
            f14.BackColor = Color.Transparent;
            f15.BackColor = Color.Transparent;
            f20.BackColor = Color.Transparent;
            f21.BackColor = Color.Transparent;
            f22.BackColor = Color.Transparent;
            f23.BackColor = Color.Transparent;
            f24.BackColor = Color.Transparent;
            f25.BackColor = Color.Transparent;
            f26.BackColor = Color.Transparent;
            f27.BackColor = Color.Transparent;
            f28.BackColor = Color.Transparent;
            f29.BackColor = Color.Transparent;
            f30.BackColor = Color.Transparent;
            f31.BackColor = Color.Transparent;
            f32.BackColor = Color.Transparent;
            f34.BackColor = Color.Transparent;
            f35.BackColor = Color.Transparent;
            f36.BackColor = Color.Transparent;
            f37.BackColor = Color.Transparent;
            f38.BackColor = Color.Transparent;


            
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            quitarAsientosCH();
        }
    }
}
