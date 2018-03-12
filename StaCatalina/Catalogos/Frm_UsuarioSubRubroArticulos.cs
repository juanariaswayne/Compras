using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Catalogos
{
    public partial class Frm_UsuarioSubRubroArticulos : Plantilla
    {
        #region Variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;
            private enum Col_Rubros
            {
                INCLUYE = 0,
                COD_RUBRO,
                DESCRIPCION
            }
            
        #endregion

        #region Funciones
            public Frm_UsuarioSubRubroArticulos()
            {
                InitializeComponent();
            }

            private void OperacionesDelUsuario()
            {
                try
                {
                    if (!escritura) { this.cmdGrabarUsuario.Enabled = false; }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void CargarUsuarios()
            {
                try
                {


                    BLL.Tables.TBL_USUARIOS _usuarios = new BLL.Tables.TBL_USUARIOS();
                    _usuarios.OrderByParameter.Add(DAL.Tables.TBL_USUARIOS.ColumnEnum.NombreUsuario, DAL.SqlEnums.DirEnum.ASC);
                    _usuarios.Items();
                    Entities.Tables.TBL_USUARIOS _itemSeleccion = new Entities.Tables.TBL_USUARIOS();
                    //Limpia el combo
                    this.comboBoxUsuario.SuspendLayout();
                    this.comboBoxUsuario.DataSource = null;
                    this.comboBoxUsuario.Items.Clear();

                    //Carga el item de Seleccion.-
                    _itemSeleccion.NOMBREUSUARIO = "<Seleccione un Usuario>";
                    _itemSeleccion.ID_USUARIO = 0;
                    _usuarios.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxUsuario.ValueMember = "Id_Usuario";
                    this.comboBoxUsuario.DisplayMember = "NombreUsuario";
                    this.comboBoxUsuario.DataSource = _usuarios.Result;
                    this.comboBoxUsuario.SelectedValue = 0;
                    this.comboBoxUsuario.ResumeLayout();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        #endregion

            private void Frm_UsuarioRubroArticulos_Load(object sender, EventArgs e)
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);

                this.CargarUsuarios();
                this.OperacionesDelUsuario();
            }

            private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
            {
                try
                {
                    if (this.comboBoxUsuario.SelectedIndex > 0)
                    {
                        BLL.Procedures.SUBRUBROUSUARIOS _subR = new BLL.Procedures.SUBRUBROUSUARIOS();
                        
                        this.dataGridViewUsuariosRubro.Rows.Clear();
                        int indice;
                        foreach (Entities.Procedures.SUBRUBROUSUARIOS _Items in  _subR.ItemList(Convert.ToInt32(this.comboBoxUsuario.SelectedValue)))
                        {
                            indice = dataGridViewUsuariosRubro.Rows.Add();
                            dataGridViewUsuariosRubro.Rows[indice].Cells[0].Value = _Items.incluido;
                            dataGridViewUsuariosRubro.Rows[indice].Cells[1].Value = _Items.artda2_cod;
                            dataGridViewUsuariosRubro.Rows[indice].Cells[2].Value = _Items.da2_desc;
                        }


                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void cmdSalirUsuario_Click(object sender, EventArgs e)
            {
                this.Close();
                this.Dispose();
            }

            private void dataGridViewUsuariosRubro_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewUsuariosRubro.IsCurrentCellDirty)
                    dataGridViewUsuariosRubro.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            private void cmdGrabarUsuario_Click(object sender, EventArgs e)
            {
                try
                {
                    BLL.Procedures.ELIMINASUBRUBROSUSUARIO _elimina = new BLL.Procedures.ELIMINASUBRUBROSUSUARIO();
                    BLL.Tables.USUARIOXSUBRUBRO _newSubRubro = new BLL.Tables.USUARIOXSUBRUBRO();
                    Entities.Tables.USUARIOXSUBRUBRO _item = new Entities.Tables.USUARIOXSUBRUBRO();
                    Boolean selecciono=false;
                    
                    _newSubRubro.BeginTransaction();
                    
                    _elimina.ItemList(Convert.ToInt32(this.comboBoxUsuario.SelectedValue));

                    for (int i = 0; i < this.dataGridViewUsuariosRubro.Rows.Count; i++)
			        {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewUsuariosRubro.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                           selecciono = true;
                            _item = new Entities.Tables.USUARIOXSUBRUBRO();
                            _item.ID_USUARIO = Convert.ToInt32(this.comboBoxUsuario.SelectedValue);
                            _item.ARTDA2_COD = dataGridViewUsuariosRubro.Rows[i].Cells[1].Value.ToString();
                            _newSubRubro.Add(_item);

                        }
			        }

                    if (selecciono)
                    {
                        _newSubRubro.EndTransaction(true);
                        MessageBox.Show("Se asigaron los subrubros correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _newSubRubro.EndTransaction(false);
                        MessageBox.Show("Debe seleccionar al menos un Subrubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
             

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}
