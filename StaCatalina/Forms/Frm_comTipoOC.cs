using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_comTipoOC : StaCatalina.Plantilla
    {
        #region Variables
            //PERMISOS
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;
            //fin PERMISOS
            private int _idTipo;

            private enum Col_Tipos
            {
                ID = 0,
                DESCRIPCION
            }
        #endregion
        #region Funciones
            public Frm_comTipoOC()
            {
                InitializeComponent();
            }
            //PERMISOS
            private void OperacionesDelUsuario()
            {
                try
                {
                    if (!escritura) { this.toolStripButtonSave.Enabled = false; }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //FIN PERMISOS

            private void CargarTipos()
            {

                try
                {
                    BLL.Tables.COMTIPOOC _tipo = new BLL.Tables.COMTIPOOC();
                    _tipo.OrderByParameter.Add(DAL.Tables.COMTIPOOC.ColumnEnum.descripcion);
                    this.bindingSourceTipoOC.DataSource = _tipo.ItemList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        #endregion

        #region Eventos
            private void Frm_comTipoOC_Load(object sender, EventArgs e)
            {
                //PERMISOS
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
                //FIN PERMISOS
                _idTipo = 0;
                CargarTipos();
            }

            private void toolStripButtonSave_Click(object sender, EventArgs e)
            {
                try
                {
                    Entities.Tables.COMTIPOOC _item = new Entities.Tables.COMTIPOOC();
                    BLL.Tables.COMTIPOOC _tipo = new BLL.Tables.COMTIPOOC();

                     _item.TIPOOC_ID = _idTipo;
                    _item.DESCRIPCION = this.textBoxDescrip.Text.Trim();
                    //verifico si la variable es distinta de cero
                    if (_idTipo != 0)
                    {
                       //ESTOY ACTUALIZANDO UN TIPO
                        if (this.textBoxDescrip.Text.Trim() != string.Empty)
                        {
                            _tipo.Update(_item);
                            _idTipo = 0;
                            this.textBoxDescrip.Text = string.Empty;
                            MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar una descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.textBoxDescrip.Focus();
                        }
                    }
                    else
                    {
                        //ES UN NUEVO INGRESO
                        if (this.textBoxDescrip.Text.Trim() != string.Empty)
                        {
                            _tipo.Add(_item);
                            _idTipo = 0;
                            this.textBoxDescrip.Text = string.Empty;
                            MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar una descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.textBoxDescrip.Focus();
                        }
                    }
                    CargarTipos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void toolStripButtonNew_Click(object sender, EventArgs e)
            {
                this.textBoxDescrip.Text = string.Empty;
                _idTipo = 0;
                this.textBoxDescrip.Focus();
            }

            private void dataGridViewTipoOC_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                //RECUPERO EL ID DE TIPO
                _idTipo = Convert.ToInt32(this.dataGridViewTipoOC.Rows[e.RowIndex].Cells[(int)Col_Tipos.ID].Value);
                //PASO LA DESCRIPCION
                this.textBoxDescrip.Text = this.dataGridViewTipoOC.Rows[e.RowIndex].Cells[(int)Col_Tipos.DESCRIPCION].Value.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
