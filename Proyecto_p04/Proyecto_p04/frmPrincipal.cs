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

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            //Se redirecciona a el frm Usuario

            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se redirecciona a el frm ventanilla 1
            frmVentanilla1 frmVentanilla1 = new frmVentanilla1();
            frmVentanilla1.Show();
        }

        private void btnVentanilla2_Click(object sender, EventArgs e)
        {
            //Se redirecciona a el frm ventanilla 2
            frmVentanilla2 frmVentanilla2 = new frmVentanilla2();
            frmVentanilla2.Show();
        }

        private void btnVentanilla3_Click(object sender, EventArgs e)
        {
            //Se redirecciona a el frm ventanilla 3
            frmVentanilla3 frmVentanilla3 = new frmVentanilla3();
            frmVentanilla3.Show();
        }

        private void btnVentanilla4_Click(object sender, EventArgs e)
        {
            //Se redirecciona a el frm ventanilla 4
            frmVentanilla4 frmVentanilla4 = new frmVentanilla4();
            frmVentanilla4.Show();
        }
    }
}
