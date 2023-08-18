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
            timer1.Enabled = true;
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
    }
}
