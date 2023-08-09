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
    public partial class frmPermisosUsuarios : Form
    {
        public frmPermisosUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNivel.Clear();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea agregar este nivel ?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int resultado =
                MessageBox.Show("Nivel Agregado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nivel no se agregó!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
