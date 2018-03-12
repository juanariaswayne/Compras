using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_stkSector : StaCatalina.Plantilla
    {

        #region Variables
        //PERMISOS
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        //fin PERMISOS
        private int _idSector;

        private enum Col_Tipos
        {
            CODEMP = 0,
            DEPOSITO_ID,
            SECTOR_ID,
            DESCRIPCION
            
        }
        #endregion

        #region Funciones

         public Frm_stkSector()
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

         private void CargarSectores( int _deposito)
         {

             try
             {
                 BLL.Tables.STKSECTOR _sector = new BLL.Tables.STKSECTOR();
                _sector.WhereParameter.Add(DAL.Tables.STKSECTOR.ColumnEnum.deposito_id, DAL.SqlEnums.OperandEnum.Equal, _deposito);
                 _sector.OrderByParameter.Add(DAL.Tables.STKSECTOR.ColumnEnum.descripcion);
                 this.bindingSourceStkSector.DataSource = _sector.ItemList();

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

        #endregion

         private void CargarDepositos()
            {
                try
                {
                   
                    //Limpia el combo
                    this.comboBoxN_Deposito.SuspendLayout();
                    this.comboBoxN_Deposito.DataSource = null;
                    this.comboBoxN_Deposito.Items.Clear();

                    BLL.Tables.STKDEPOSITO _deposito = new BLL.Tables.STKDEPOSITO();
                    Entities.Tables.STKDEPOSITO _itemSeleccion = new Entities.Tables.STKDEPOSITO();
                    _deposito.Items();
                    //Carga el item de Seleccion
                    _itemSeleccion.DESCRIPCION = "<Seleccione un Depósito>";
                    _itemSeleccion.DEPOSITO_ID = 0;
                     _deposito.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxN_Deposito.DisplayMember = BLL.Tables.STKDEPOSITO.ColumnNames.DESCRIPCION;
                    this.comboBoxN_Deposito.ValueMember = BLL.Tables.STKDEPOSITO.ColumnNames.DEPOSITO_ID;
                    this.comboBoxN_Deposito.DataSource = _deposito.Result.ToArray();

                    this.comboBoxN_Deposito.ResumeLayout();
                    this.comboBoxN_Deposito.SelectedIndex = 0;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


         #region Eventos

        private void stkSector_Load(object sender, EventArgs e)
                {
                    {

                        //PERMISOS
                        MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                        menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                        this.OperacionesDelUsuario();
                        //FIN PERMISOS
                        _idSector = 0;
                        CargarDepositos();

                    }

                }
 private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
             try
                        {
                            Entities.Tables.STKSECTOR _item = new Entities.Tables.STKSECTOR();
                            BLL.Tables.STKSECTOR _sector = new BLL.Tables.STKSECTOR();

                            _item.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
                            _item.DEPOSITO_ID = Convert.ToInt32(this.comboBoxN_Deposito.SelectedValue);
                            _item.SECTOR_ID = _idSector;                            
                            _item.DESCRIPCION = this.textBoxDescrip.Text.Trim();
                            //verifico si la variable es distinta de cero
                            if (_idSector != 0)
                            {
                                //ESTOY ACTUALIZANDO UN TIPO
                                if (this.textBoxDescrip.Text.Trim() != string.Empty)
                                {
                                    _sector.Update(_item);
                                    _idSector = 0;
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
                                    _sector.Add(_item);
                                    _idSector = 0;
                                    this.textBoxDescrip.Text = string.Empty;
                                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Debe ingresar una descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.textBoxDescrip.Focus();
                                }
                            }
                            CargarDepositos();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }

     private void toolStripButtonNew_Click(object sender, EventArgs e)
                 {
                        this.textBoxDescrip.Text = string.Empty;
                        _idSector = 0;
                        this.textBoxDescrip.Focus();
                 }

     private void dataGridViewStkSubTIpoMov_CellClick(object sender, DataGridViewCellEventArgs e)
             
             {

                 try
                 {
                     //RECUPERO EL ID DE TIPO
                     _idSector = Convert.ToInt32(this.dataGridViewStkSubTIpoMov.Rows[e.RowIndex].Cells[(int)Col_Tipos.SECTOR_ID].Value);
                     //PASO LA DESCRIPCION
                     this.textBoxDescrip.Text = this.dataGridViewStkSubTIpoMov.Rows[e.RowIndex].Cells[(int)Col_Tipos.DESCRIPCION].Value.ToString();
                     this.comboBoxN_Deposito.SelectedValue = Convert.ToInt32 (this.dataGridViewStkSubTIpoMov.Rows[e.RowIndex].Cells[(int)Col_Tipos.DEPOSITO_ID].Value);
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

        private void comboBoxN_Deposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBoxN_Deposito.SelectedIndex > 0)
            {
                CargarSectores(Convert.ToInt32(this.comboBoxN_Deposito.SelectedValue));

            }
        }
    }
}
