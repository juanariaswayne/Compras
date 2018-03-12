using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class stkSubTIpoMov : StaCatalina.Plantilla
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

        public stkSubTIpoMov()
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
                BLL.Tables.STKSUBTIPOMOV _sector = new BLL.Tables.STKSUBTIPOMOV();
                _sector.OrderByParameter.Add(DAL.Tables.STKSUBTIPOMOV.ColumnEnum.descripcion);
                this.bindingSourceStkTipoMov.DataSource = _sector.ItemList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion        

        #region Eventos

            private void stkSubTIpoMov_Load(object sender, EventArgs e)
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
                            Entities.Tables.STKSUBTIPOMOV _item = new Entities.Tables.STKSUBTIPOMOV();
                            BLL.Tables.STKSUBTIPOMOV _tipo = new BLL.Tables.STKSUBTIPOMOV();

                            _item.SUBTIPOMOV_ID = _idTipo;
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

            private void dataGridViewComSector_Requerimiento_CellClick(object sender, DataGridViewCellEventArgs e)
                    {
                        try
                        {
                            //RECUPERO EL ID DE TIPO
                            _idTipo = Convert.ToInt32(this.dataGridViewStkSubTIpoMov.Rows[e.RowIndex].Cells[(int)Col_Tipos.ID].Value);
                            //PASO LA DESCRIPCION
                            this.textBoxDescrip.Text = this.dataGridViewStkSubTIpoMov.Rows[e.RowIndex].Cells[(int)Col_Tipos.DESCRIPCION].Value.ToString();

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
