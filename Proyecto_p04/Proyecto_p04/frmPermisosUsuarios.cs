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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.NivelesdeUsuarios glevel = new Clases.NivelesdeUsuarios();
            glevel.id_nivel = Convert.ToInt32(cbNivel.SelectedValue);
            glevel.id_boton = Convert.ToInt32(chkPermisos.SelectedValue);

            int resultado = Clases.NivelesdeUsuariosDAL.getNivel(glevel);

            DataTable dt = Clases.NivelesdeUsuariosDAL.getNivelTot(glevel);

            if (dt.Rows.Count >= 1)
            {

                //if (resultado > 0)
                //{
                //SI EXISTE, ACUALIZAR
                DialogResult result = MessageBox.Show(this, "Desea Actualizar este nivel? ", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    int ii = 0;
                    foreach (DataRowView item in chkPermisos.Items)
                    {
                        string descripcion = item["informacion"].ToString();
                        string boton = item["boton"].ToString();
                        string id = item["id"].ToString();

                        glevel.id_boton = Convert.ToInt32(id);
                        glevel.informacion = descripcion.ToString();
                        glevel.boton = boton.ToString();

                        if (chkPermisos.GetItemChecked(ii))
                        //guardar valor en la tabla usuarios_permisos 1/0
                        {
                            glevel.activo = 1;
                        }
                        else
                        {
                            glevel.activo = 0;
                        }

                        int agregar = Clases.NivelesdeUsuariosDAL.updaPerm(glevel);
                        if (agregar == 0)
                        {  
                        }
                        ii++;
                    }
                }
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, "Proceso terminado!", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //SI NO EXISTE, AGREGAR
                DialogResult result = MessageBox.Show(this, "Desea Agregar este nivel? ", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    int ii = 0;
                    DataTable dt2 = new DataTable();
                    dt2 = Clases.NivelesdeUsuariosDAL.bot();
                    foreach (DataRow Row in dt2.Rows)
                    {
                        string descripcion = Row["informacion"].ToString();
                        string boton = Row["boton"].ToString();
                        string id = Row["id"].ToString();

                        glevel.id_boton = Convert.ToInt32(id);
                        glevel.informacion = descripcion.ToString();
                        glevel.boton = boton.ToString();

                     
                        glevel.activo = Convert.ToInt32(Row["activo"].ToString());
                      

                        if (boton == "btnAdd" && glevel.id_nivel <= 6 || boton == "btnFacCierre" && glevel.id_nivel <= 6)
                        {
                        }
                        else
                        {
                            int agregar = Clases.NivelesdeUsuariosDAL.addRegistro(glevel);
                        }
                        ii++;
                    }
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(this, "Proceso terminado!", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Niveles();
                Opciones();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.NivelesdeUsuarios delete = new Clases.NivelesdeUsuarios();
            delete.Nombre = cbNivel.Text.Trim();
            int resultado = Clases.NivelesdeUsuariosDAL.getlevels(delete);
            if (resultado > 0)
            {
                DialogResult result = MessageBox.Show(this, "Desea eliminar este Usuario? ", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int prodDel = Clases.NivelesdeUsuariosDAL.Deletelevel(delete);
                    if (prodDel > 0)
                    {
                        MessageBox.Show(this, "Usuario Eliminado!", "Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Niveles();
                        Opciones();
                    }
                }
            }
        }
    }
}
