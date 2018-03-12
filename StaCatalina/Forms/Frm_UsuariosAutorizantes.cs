using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_UsuariosAutorizantes : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        private enum Col_Sector
        {
            INCLUYE = 0,
            SECTOR_ID,
            DESCRIPCION
        }

        #endregion
        #region Funciones
        public Frm_UsuariosAutorizantes()
        {
            InitializeComponent();
        }
        private void CargarUsuarios()
        {
            try
            {


                BLL.Tables.TBL_USUARIOS _usuarios = new BLL.Tables.TBL_USUARIOS();
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

        private void OperacionesDelUsuario()
        {
            try
            {
                if (!escritura) { this.toolStripButtonClose.Enabled = false; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void Frm_UsuariosAutorizantes_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);

            this.CargarUsuarios();
            this.OperacionesDelUsuario();
        }

        #endregion

        private void dataGridViewSectores_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewSectores.IsCurrentCellDirty)
                dataGridViewSectores.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxUsuario.SelectedIndex > 0)
                {
                    BLL.Procedures.SECTORESAUTORIZAUSUARIO _sectores = new BLL.Procedures.SECTORESAUTORIZAUSUARIO();

                    this.dataGridViewSectores.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.SECTORESAUTORIZAUSUARIO _Items in _sectores.ItemList(Convert.ToInt32(this.comboBoxUsuario.SelectedValue)))
                    {
                        indice = dataGridViewSectores.Rows.Add();
                        dataGridViewSectores.Rows[indice].Cells[(int)Col_Sector.INCLUYE ].Value = _Items.incluido;
                        dataGridViewSectores.Rows[indice].Cells[(int)Col_Sector.SECTOR_ID].Value = _Items.sectorrequerimiento;
                        dataGridViewSectores.Rows[indice].Cells[(int)Col_Sector.DESCRIPCION].Value = _Items.descripcion;
                    }


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Procedures.ELIMINASECTORAUTORIZAUSUARIO _elimina = new BLL.Procedures.ELIMINASECTORAUTORIZAUSUARIO();
                BLL.Procedures.COMUSUARIOAUTORIZAREQUERIMIENTOS_ADD _newSector = new BLL.Procedures.COMUSUARIOAUTORIZAREQUERIMIENTOS_ADD();
                Entities.Procedures.COMUSUARIOAUTORIZAREQUERIMIENTOS_ADD _item = new Entities.Procedures.COMUSUARIOAUTORIZAREQUERIMIENTOS_ADD();
                Boolean selecciono = false;


                //ELIMINO TODOS LOS SECTORES AUTORIZADOS.. Y LOS VUELVO A CREAR DE NUEVO
                _elimina.ItemList(Convert.ToInt32(this.comboBoxUsuario.SelectedValue));

                for (int i = 0; i < this.dataGridViewSectores.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewSectores.Rows[i].Cells[(int)Col_Sector.INCLUYE] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        selecciono = true;
                        _item = new Entities.Procedures.COMUSUARIOAUTORIZAREQUERIMIENTOS_ADD();
                        _item.Idusuario = Convert.ToInt32(this.comboBoxUsuario.SelectedValue);
                        _item.sectorrequerimiento = Convert.ToInt32(dataGridViewSectores.Rows[i].Cells[(int)Col_Sector.SECTOR_ID].Value.ToString());
                        _newSector.Items(_item.Idusuario, _item.sectorrequerimiento);

                    }
                }

                if (selecciono)
                {

                    MessageBox.Show("Se asigaron los sectores correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Debe seleccionar al menos un sectore", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
