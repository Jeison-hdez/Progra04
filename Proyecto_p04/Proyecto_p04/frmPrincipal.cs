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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Proyecto_p04
{
    public partial class frmPrincipal : Form
    {
        private Point _offset;

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


        private void button1_MouseEnter(object sender, EventArgs e)
        {

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
            // BUSCAMOS EL ACCESO QUE TIENE EL USUARIO
            Acceso();
        }

        private void pnlTitutlo_MouseDown(object sender, MouseEventArgs e)
        {
            _offset = new Point(e.X, e.Y);
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
            AbrirFormdentroForm(new frmReporte());
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            AbrirFormdentroForm(new frmPermisosUsuarios());
        }

        private void btnManAerolineas_Click(object sender, EventArgs e)
        {
            AbrirFormdentroForm(new frmAerolina());
        }

        private void btnVentanilla2_Click(object sender, EventArgs e)
        {
            AbrirFormdentroForm(new frmVentanilla2());
        }

        private void btnVentanilla3_Click(object sender, EventArgs e)
        {
            AbrirFormdentroForm(new frmVentanilla3());
        }

        private void btnVentanilla4_Click(object sender, EventArgs e)
        {
            AbrirFormdentroForm(new frmVentanilla4());
        }

        private void btnManPiloto_Click(object sender, EventArgs e)
        {
            AbrirFormdentroForm(new frmPiloto());
        }

        private void btnManAvion_Click(object sender, EventArgs e)
        {

            AbrirFormdentroForm(new frmVuelos());
        }

        private void pnlTitutlo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - _offset.X;
                newLocation.Y += e.Y - _offset.Y;
                this.Location = newLocation;
            }
        }

        public void Acceso()
        {
            Clases.Usuarios usu = new Clases.Usuarios();
            usu.idPerfil = Globales.Nivel;
            // CONSULTAMOS LOS PERMISOS QUE TIENE ESE USUARIO CON RESPECTO AL NIVEL
            DataTable dt = Clases.NivelesdeUsuariosDAL.getPermisos(usu);
            int valor;
            string boton;

            //VALIDAMOS A QUE VA A TENER ACCESO EL USUARIO
            foreach (DataRow items in dt.Rows)
            {

                valor = Convert.ToInt32(items["estado"]);
                boton = items["nombre_boton"].ToString();

                if (boton == "btnVentanilla1" && valor == 0)
                {
                    panel1.Visible = false;
                    btnVentanilla1.Visible = false;
                }
                else if (boton == "btnVentanilla1" && valor == 1)
                {
                    panel1.Visible = true;
                    btnVentanilla1.Visible = true;
                }

                if (boton == "btnVentanilla2" && valor == 0)
                {
                    panel2.Visible = false;
                    btnVentanilla2.Visible = false;
                }
                else if (boton == "btnVentanilla2" && valor == 1)
                {
                    panel2.Visible = true;
                    btnVentanilla2.Visible = true;
                }

                if (boton == "btnVentanilla3" && valor == 0)
                {
                    panel3.Visible = false;
                    btnVentanilla3.Visible = false;
                }
                else if (boton == "btnVentanilla3" && valor == 1)
                {
                    panel3.Visible = true;
                    btnVentanilla3.Visible = true;
                }

                if (boton == "btnVentanilla4" && valor == 0)
                {
                    panel4.Visible = false;
                    btnVentanilla4.Visible = false;
                }
                else if (boton == "btnVentanilla4" && valor == 1)
                {
                    panel4.Visible = true;
                    btnVentanilla4.Visible = true;
                }

                if (boton == "btnManAerolineas" && valor == 0)
                {
                    panel8.Visible = false;
                    btnManAerolineas.Visible = false;
                }
                else if (boton == "btnManAerolineas" && valor == 1)
                {
                    panel8.Visible = true;
                    btnManAerolineas.Visible = true;
                }

                if (boton == "btnManAvion" && valor == 0)
                {
                    panel9.Visible = false;
                    btnManAvion.Visible = false;
                }
                else if (boton == "btnManAvion" && valor == 1)
                {
                    panel9.Visible = true;
                    btnManAvion.Visible = true;
                }

                if (boton == "btnManPiloto" && valor == 0)
                {
                    panel10.Visible = false;
                    btnManPiloto.Visible = false;
                }
                else if (boton == "btnManPiloto" && valor == 1)
                {
                    panel10.Visible = true;
                    btnManPiloto.Visible = true;
                }


                if (boton == "btnManUsuarios" && valor == 0)
                {
                    panel5.Visible = false;
                    btnManUsuarios.Visible = false;
                }
                else if (boton == "btnManUsuarios" && valor == 1)
                {
                    panel5.Visible = true;
                    btnManUsuarios.Visible = true;
                }

                if (boton == "btnPermisos" && valor == 0)
                {
                    panel6.Visible = false;
                    btnPermisos.Visible = false;
                }
                else if (boton == "btnPermisos" && valor == 1)
                {
                    panel6.Visible = true;
                    btnPermisos.Visible = true;
                }
                
                if (boton == "btnReportes" && valor == 0)
                {
                    panel7.Visible = false;
                    btnReportes.Visible = false;
                }
                else if (boton == "btnReportes" && valor == 1)
                {
                    panel7.Visible = true;
                    btnReportes.Visible = true;
                }
            }
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cambiar de usuario ?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
            else
            {

            }
        }
    }
}
