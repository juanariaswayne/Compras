using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_stkDeposito : StaCatalina.Plantilla
    {

        #region Variables
        //PERMISOS
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        //fin PERMISOS
        private int _idDeposito;

        private enum Col_Autorizacion
        {
            CODEMP = 0,
            DEPOSITO_ID,
            DESCRIPCION,
            STOCKNEGATIVO
        }

        #endregion

        #region Funciones
        public Frm_stkDeposito()
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


        private void CargarDepositos()
        {

            try
            {
                BLL.Tables.STKDEPOSITO _tipo = new BLL.Tables.STKDEPOSITO();
                _tipo.OrderByParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.descripcion);
                this.bindingSource_stkDeposito.DataSource = _tipo.ItemList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos

        private void stkInventario_Load(object sender, EventArgs e)
                {
                    {

                        //PERMISOS
                        MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                        menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                        this.OperacionesDelUsuario();
                        //FIN PERMISOS
                        _idDeposito = 0;
                        CargarDepositos();

                    }

                }


        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.Tables.STKDEPOSITO _item = new Entities.Tables.STKDEPOSITO();
                BLL.Tables.STKDEPOSITO _deposito = new BLL.Tables.STKDEPOSITO();

                _item.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
                _item.DEPOSITO_ID = _idDeposito;
                _item.DESCRIPCION = this.textBoxDescrip.Text.Trim();
                _item.STOCKNEGATIVO = 1;
                //verifico si la variable es distinta de cero
                if (_idDeposito != 0)
                {
                    //ESTOY ACTUALIZANDO UN ESTADO
                    if (this.textBoxDescrip.Text.Trim() != string.Empty)
                    {
                        _deposito.Update(_item);
                        _idDeposito = 0;
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
                        _deposito.Add(_item);
                        _idDeposito = 0;
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

        private void dataGridViewMovimientoStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //RECUPERO EL ID DE TIPO
                _idDeposito = Convert.ToInt32(this.dataGridViewDepositos.Rows[e.RowIndex].Cells[(int)Col_Autorizacion.DEPOSITO_ID].Value);
                //PASO LA DESCRIPCION
                this.textBoxDescrip.Text = this.dataGridViewDepositos.Rows[e.RowIndex].Cells[(int)Col_Autorizacion.DESCRIPCION].Value.ToString();
                //PASO SI ACEPTA SIGNO NEGATIVO
             

               
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
