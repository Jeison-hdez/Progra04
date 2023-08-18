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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int destino = Convert.ToInt32(cbVuelo.SelectedValue);
            dt = Clases.reportesDAL.getDatosVuelo(destino);
            if (dt.Rows.Count > 0) 
            {
                foreach (DataRow row in dt.Rows)
                {
                    int escala = 0;
                    string nombre_escala = "";
                }
                valorX = 12;
                pnlAvion.Location = new Point(45, 165);
                progressBar1.Value = 0;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
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
