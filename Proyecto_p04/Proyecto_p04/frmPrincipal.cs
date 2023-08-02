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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            pbMaximizar.Visible = true;
            pbRestaurar.Visible = false;
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVentanilla1_Click(object sender, EventArgs e)
        {
            //Se ridirecciona al frm Ventanilla 1
            frmVentanilla1 frmVentanilla1 = new frmVentanilla1();
            frmVentanilla1.Show();
        }

        private void btnVentanilla2_Click(object sender, EventArgs e)
        {
            //Se ridirecciona al frm Ventanilla 2
            frmVentanilla2 frmVentanilla2 = new frmVentanilla2();
            frmVentanilla2.Show();
        }

        private void btnVentanilla3_Click(object sender, EventArgs e)
        {
            //Se ridirecciona al frm Ventanilla 3
            frmVentanilla3 frmVentanilla3 = new frmVentanilla3();
            frmVentanilla3.Show();
        }

        private void btnVentanilla4_Click(object sender, EventArgs e)
        {
            //Se ridirecciona al frm Ventanilla 4
            frmVentanilla4 frmVentanilla4 = new frmVentanilla4();
            frmVentanilla4.Show();
        }
    }
}
