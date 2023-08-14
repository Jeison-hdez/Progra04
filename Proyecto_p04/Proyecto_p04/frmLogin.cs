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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Variable global de usuario
        public static class GlobalVariables
        {
            public static string Usuario { get; set; }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text != "USUARIO") && (txtPassword.Text != "CLAVE"))
            {
                Login(txtPassword.Text.Trim(), txtUsuario.Text.Trim());
            }

            GlobalVariables.Usuario = txtUsuario.Text;
        }

        public void Login(string pass, string usuario)
        {
            Clases.Usuarios login = new Clases.Usuarios();
            login.Usuario = usuario;
            login.Password = pass;
            int resultado = Clases.UsuariosDAL.LoginUser(login);
            if (resultado > 0)
            {
                this.Hide();
                Globales.Usuario = login.Usuario;
                Globales.Nivel = login.Nivel;
                frmPrincipal frmP = new frmPrincipal();
                frmP.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Password no válido!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
