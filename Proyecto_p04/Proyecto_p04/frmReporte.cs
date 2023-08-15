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
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            DateTime fecha2 = DateTime.Now;
            dtpFechaI.Format = DateTimePickerFormat.Custom;
            dtpFechaF.Format = DateTimePickerFormat.Custom;
            dtpFechaI.CustomFormat = fecha.ToString("dd/MM/yyyy HH:mm");
            dtpFechaF.CustomFormat = fecha2.ToString("dd/MM/yyyy HH:mm");
        }

        private void rbPasajeros_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPasajeros.Checked == true)
            {
                cbPasajeros.Visible = true;
            }
            else 
            {
                cbPasajeros.Visible = false;
            }
        }

        private void rbMoneda_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMoneda.Checked == true)
            {
                cbMonetario.Visible = true;
            }
            else
            {
                cbMonetario.Visible = false;
            }
        }

        private void rbVuelos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVuelos.Checked == true)
            {
                cbVuelos.Visible = true;
            }
            else
            {
                cbVuelos.Visible = false;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            
            if (rbVuelos.Checked == true) 
            {
            
            }
            if (rbMoneda.Checked == true) 
            {
            
            }
            if (rbCortes.Checked == true) 
            {
            
            }
            if (rbPasajeros.Checked == true) 
            {
            
            }
        }
    }
}
