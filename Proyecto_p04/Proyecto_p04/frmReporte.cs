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
    }
}
