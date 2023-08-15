using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public DataTable dt;

        private void frmReporte_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            DateTime fecha2 = DateTime.Now;
            dtpFechaI.Format = DateTimePickerFormat.Custom;
            dtpFechaF.Format = DateTimePickerFormat.Custom;
            dtpFechaI.CustomFormat = fecha.ToString("dd/MM/yyyy HH:mm");
            dtpFechaF.CustomFormat = fecha2.ToString("dd/MM/yyyy HH:mm");
            vuelos();
        }

        private void rbPasajeros_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPasajeros.Checked == true)
            {
                cbPasajeros.Visible = false;
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
                cbVuelosNombres.Visible = true;
            }
            else
            {
                cbMonetario.Visible = false;
                cbVentanilla.Visible = false;
                cbVuelosNombres.Visible = false;
            }
        }

        private void rbVuelos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVuelos.Checked == true)
            {
                cbVentanilla.Visible = false;
            }
            else
            {
                cbVentanilla.Visible = false;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //DataTable dt = new DataTable();
            dataGridView1.DataSource = null;
            string fechaI = dtpFechaI.Text;
            string fechaF = dtpFechaF.Text;
            DateTime fechai = Convert.ToDateTime(fechaI);
            DateTime fechaf = Convert.ToDateTime(fechaF);
            string _fechai = "";
            string _fechaf = "";
            _fechai = fechai.ToString("yyyy-MM-dd");
            _fechaf = fechaf.ToString("yyyy-MM-dd");
            if (rbVuelos.Checked == true) 
            {
                dt = Clases.reportesDAL.repVuelos(_fechai,_fechaf);
            }
            if (rbMoneda.Checked == true) 
            {
                string vuelo = cbVuelosNombres.SelectedValue.ToString();
                int cb = cbVentanilla.SelectedIndex;
                int tipo = 0;
                if (cb == 0) //VUELO
                {
                    tipo = 1;
                }

                dt = Clases.reportesDAL.repVuelosMonetario(vuelo,tipo);
            }
            if (rbCortes.Checked == true) 
            {
            
            }
            if (rbPasajeros.Checked == true) 
            {
                string vuelo = cbVuelosNombres.SelectedValue.ToString();
                int cb = cbVentanilla.SelectedIndex;
                int tipo = 0;


                dt = Clases.reportesDAL.repVuelosPasajeros(vuelo, tipo);
            }
            dataGridView1.DataSource = dt;
            btnExcel.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void rbCortes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbMonetario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMonetario.SelectedIndex == 1)
            {
                cbVentanilla.Visible = true;
            }
            else 
            {
                cbVentanilla.Visible = false;
            }
        }

        public void vuelos() 
        {
            DataTable dt = new DataTable();
            cbVuelosNombres.ValueMember = "id";
            cbVuelosNombres.DisplayMember = "nombre";

            cbVuelosNombres.DropDownStyle = ComboBoxStyle.DropDownList;
            dt = Clases.reportesDAL.getVuelos();

            if (dt.Rows.Count > 0)
            {
                cbVuelosNombres.DataSource = new BindingSource(dt, null);
                cbVuelosNombres.DisplayMember = "destino";
                cbVuelosNombres.ValueMember = "id";
            }
        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                int ii = 0;
                Cursor.Current = Cursors.WaitCursor;
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null; 
                worksheet = workbook.Sheets[1];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Reporte";
                worksheet.Cells[3, 2] = "Reporte";
                worksheet.Cells[3, 2].Font.Bold = true;
                worksheet.Cells[4, 2] = "Fecha de Emisión: " + DateTime.Now.ToString();
                worksheet.Cells[4, 2] = "DEL: " + dtpFechaI.Text + " AL " + dtpFechaF.Text;

                worksheet.get_Range("A7", " J7").Font.Bold = true;
                worksheet.get_Range("A7", " J7").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                 
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[7, i] = dataGridView1.Columns[i - 1].HeaderText;
                }


                if (dt.Rows.Count > 0) 
                {
                    for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            
                                worksheet.Cells[i + 8, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            
                        }
                        ii = i;
                    }
                }
                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();
                app.Visible = true;
            }
            catch (Exception ex) 
            {
            
            }
        }
    }
}
