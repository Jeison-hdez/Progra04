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
            string nombreNivel = txtNivel.Text.Trim();
            DialogResult result = MessageBox.Show("Desea agregar este nivel ?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int resultado = 0;
                int addNivel = Clases.NivelesUsuariosDAL.addNivel(nombreNivel);
                if (addNivel > 0) 
                {
                    MessageBox.Show("Nivel Agregado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Niveles();
                    Opciones();
                }
            }
            else
            {
                MessageBox.Show("Nivel no se agregó!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Niveles();
                Opciones();
            }
        }

        public void Niveles()
        {
            DataTable dt = new DataTable();
            cbNivel.ValueMember = "nivel";
            cbNivel.DisplayMember = "nombre";

            cbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            dt = Clases.NivelesUsuariosDAL.getNiveles();

            if (dt.Rows.Count > 0)
            {
                cbNivel.DataSource = new BindingSource(dt, null);
                cbNivel.DisplayMember = "descripcion";
                cbNivel.ValueMember = "nivel";
            }
        }

        private void Opciones()
        {
            DataTable dt = new DataTable();
            dt = Clases.NivelesUsuariosDAL.getbotones();
            chkPermisos.ValueMember = "id";
            chkPermisos.DisplayMember = "descripcion";

            if (dt.Rows.Count > 0)
            {
                chkPermisos.DataSource = new BindingSource(dt, null);
                chkPermisos.DisplayMember = "descripcion";
                chkPermisos.ValueMember = "id";
            }
        }

        private void frmPermisosUsuarios_Load(object sender, EventArgs e)
        {
            Niveles();
            Opciones();
        }

        private void cbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkPermisos.Visible)
                getcheck();
        }

        private void getcheck() //revisar
        {
            try
            {
                Clases.Usuarios usu = new Clases.Usuarios();
                usu.idPerfil = Convert.ToInt32(cbNivel.SelectedValue);
                DataTable bt = Clases.NivelesUsuariosDAL.getPermisos(usu);

                CheckedListBox desc = new CheckedListBox();
                int idNivel;

                int check;

                bool chequear = false;
                int ii = 0;
                string val;


                foreach (DataRow rows in bt.Rows)
                {

                    val = Convert.ToString(rows["boton"]);
                    if (rows["boton"].ToString() == "")
                    {
                        chkPermisos.SetItemCheckState(ii, CheckState.Unchecked);
                        check = 0; // activo
                        chequear = Convert.ToBoolean(check);
                        if (chequear == true)
                        { chkPermisos.SetItemCheckState(ii, CheckState.Checked); }
                        else if (chequear == false)
                        { chkPermisos.SetItemCheckState(ii, CheckState.Unchecked); }
                    }
                    else
                    {
                        idNivel = Convert.ToInt32(rows["id_nivel"]);   // Nivel
                        check = Convert.ToInt32(rows["activo"]); // activo
                        chequear = Convert.ToBoolean(check);


                        if (chequear == true)
                        { chkPermisos.SetItemCheckState(ii, CheckState.Checked); }
                        else if (chequear == false)
                        { chkPermisos.SetItemCheckState(ii, CheckState.Unchecked); }

                    }
                    ii++;
                    if (bt.Rows.Count == 0)
                    {
                        for (int i = 0; i < chkPermisos.Items.Count; i++)
                        {
                            chkPermisos.SetItemChecked(i, false);
                        }
                    }
                }
            }
            catch { }
        }

    }
}
