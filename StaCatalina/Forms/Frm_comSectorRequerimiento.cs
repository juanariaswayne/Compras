using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_comSectorRequerimiento : StaCatalina.Plantilla
    {
       
        #region Variables
        //PERMISOS
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        //fin PERMISOS
        private int _idTipo;

        private enum Col_Sectores
        {
            ID = 0,
            DESCRIPCION
        }

        #endregion

         #region Funciones
            public Frm_comSectorRequerimiento()
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

            private void CargarSectores()
            {

                try
                {
                    BLL.Tables.COMSECTORREQUERIMIENTO _sector = new BLL.Tables.COMSECTORREQUERIMIENTO();
                    _sector.OrderByParameter.Add(DAL.Tables.COMSECTORREQUERIMIENTO.ColumnEnum.Descripcion);
                    this.bindingSourceSectores.DataSource = _sector.ItemList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        #endregion

      #region Eventos
             
            private void Frm_comSector_Requerimiento_Load(object sender, EventArgs e)
                            {

                                //PERMISOS
                                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                                this.OperacionesDelUsuario();
                                //FIN PERMISOS
                                _idTipo = 0;
                                CargarSectores();

                            }

             private void toolStripButtonSave_Click(object sender, EventArgs e)
                            {

                                try
                                {
                                    Entities.Tables.COMSECTORREQUERIMIENTO _item = new Entities.Tables.COMSECTORREQUERIMIENTO();
                                    BLL.Tables.COMSECTORREQUERIMIENTO _tipo = new BLL.Tables.COMSECTORREQUERIMIENTO();

                                    _item.SECTORREQUERIMIENTO_ID= _idTipo;
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
                                    CargarSectores();
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

               private void dataGridViewComSector_Requerimiento_CellClick(object sender, DataGridViewCellEventArgs e)
               {
                   try
                   {
                       //RECUPERO EL ID DE TIPO
                       _idTipo = Convert.ToInt32(this.dataGridViewComSector_Requerimiento.Rows[e.RowIndex].Cells[(int)Col_Sectores.ID].Value);
                       //PASO LA DESCRIPCION
                       this.textBoxDescrip.Text = this.dataGridViewComSector_Requerimiento.Rows[e.RowIndex].Cells[(int)Col_Sectores.DESCRIPCION].Value.ToString();

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

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {

            try
            { 

                if (_idTipo > 0 && this.textBoxDescrip.Text != string.Empty)
                {
                    DialogResult _result = MessageBox.Show("Está por eliminar el sector: " + this.textBoxDescrip.Text.Trim() + " desea continaur ?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (_result == System.Windows.Forms.DialogResult.OK)
                    {
                        BLL.Tables.COMSECTORREQUERIMIENTO _elimina = new BLL.Tables.COMSECTORREQUERIMIENTO();
                        Entities.Tables.COMSECTORREQUERIMIENTO _item = new Entities.Tables.COMSECTORREQUERIMIENTO();
                        _item.SECTORREQUERIMIENTO_ID = _idTipo;
                        _item.DESCRIPCION = this.textBoxDescrip.Text;

                        _elimina.Remove(_item);
                        MessageBox.Show("La operación se guardó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
