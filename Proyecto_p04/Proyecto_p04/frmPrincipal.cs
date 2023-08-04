using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;

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
            DialogResult result = MessageBox.Show("Desea salir del Sistema ?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else 
            {

            }
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
            AbrirFormdentroForm(new frmVentanilla1());
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitutlo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x122, 0xf012, 0);
        }

        private void AbrirFormdentroForm(object formAbrir) 
        {
            if(this.pnlContainer.Controls.Count>0)
                this.pnlContainer.Controls.RemoveAt(0);
            Form frm = formAbrir as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(frm);
            this.pnlContainer.Tag = frm;
            frm.Show();
        }

        private void btnManUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormdentroForm(new frmUsuario());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            AbrirFormdentroForm(new frmPermisosUsuarios());
        }

        private void btnManAerolineas_Click(object sender, EventArgs e)
        {
            //Hacer la redireccion hacia el frm Aerolinas
        }
    }
}
