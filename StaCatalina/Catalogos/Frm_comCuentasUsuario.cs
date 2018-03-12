using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Catalogos
{
    public partial class Frm_comCuentasUsuario : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        private enum Col_cuentas
        {
            INCLUYE = 0,
            CUENTA,
            AGR_CODIGO,
            CTA_NRO_CTA,
            DESCRIPCION
        }

        #endregion


        #region Funciones
        public Frm_comCuentasUsuario()
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

        private void Frm_comCuentasUsuario_Load(object sender, EventArgs e)
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
                    BLL.Procedures.COM_CUENTAS_USUARIO _subR = new BLL.Procedures.COM_CUENTAS_USUARIO();

                    this.dataGridViewUsuariosRubro.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.COM_CUENTAS_USUARIO _Items in _subR.ItemList(Convert.ToInt32(this.comboBoxUsuario.SelectedValue)))
                    {
                        indice = dataGridViewUsuariosRubro.Rows.Add();
                        dataGridViewUsuariosRubro.Rows[indice].Cells[(int)Col_cuentas.INCLUYE].Value = _Items.incluye;
                        dataGridViewUsuariosRubro.Rows[indice].Cells[(int)Col_cuentas.CUENTA].Value = _Items.com_valor;//CUENTA CONTABLE
                        dataGridViewUsuariosRubro.Rows[indice].Cells[(int)Col_cuentas.AGR_CODIGO].Value = _Items.agr_codigo; //AGR_CODIGO
                        dataGridViewUsuariosRubro.Rows[indice].Cells[(int)Col_cuentas.CTA_NRO_CTA].Value = _Items.cta_nrocta; //CTA_NRO_CTA
                        dataGridViewUsuariosRubro.Rows[indice].Cells[(int)Col_cuentas.DESCRIPCION].Value = _Items.cta_descrip; //DESCRIPCION
                    }

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                BLL.Tables.COMCUENTAUSUARIO _newCuenta = new BLL.Tables.COMCUENTAUSUARIO();
                Entities.Tables.COMCUENTAUSUARIO _item = new Entities.Tables.COMCUENTAUSUARIO();
                Boolean selecciono = false;

                _newCuenta.BeginTransaction();
                //PRIMERO ELIMINO TODAS LAS CUENTAS ASOCIADAS..
                _newCuenta.RemoveItem (Convert.ToInt32(this.comboBoxUsuario.SelectedValue),null,null,0);

                for (int i = 0; i < this.dataGridViewUsuariosRubro.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewUsuariosRubro.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        selecciono = true;
                        _item = new Entities.Tables.COMCUENTAUSUARIO();
                        _item.ID_USUARIO = Convert.ToInt32(this.comboBoxUsuario.SelectedValue);
                        _item.COM_VALOR = dataGridViewUsuariosRubro.Rows[i].Cells[(int)Col_cuentas.CUENTA].Value.ToString(); //CUENTA CONTABLE
                        _item.AGR_CODIGO= dataGridViewUsuariosRubro.Rows[i].Cells[(int)Col_cuentas.AGR_CODIGO].Value.ToString() ; //AGR_CODIGO
                        _item.CTA_NROCTA= Convert.ToInt32(dataGridViewUsuariosRubro.Rows[i].Cells[(int)Col_cuentas.CTA_NRO_CTA].Value.ToString()); //CTA_NRO_CTA

                        _newCuenta.Add(_item);

                    }
                }

                if (selecciono)
                {
                    _newCuenta.EndTransaction(true);
                    MessageBox.Show("Cuenta contable asignada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _newCuenta.EndTransaction(false);
                    MessageBox.Show("Debe asignar al menos una cuenta contable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}
