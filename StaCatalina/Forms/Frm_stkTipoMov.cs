using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_stkTipoMov : StaCatalina.Plantilla
    {

        #region Variables
        //PERMISOS
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        //fin PERMISOS
        private int _idTipoMov;

        private enum Col_Autorizacion
        {
            ID = 0,
            DESCRIPCION,
            SIGNO
        }

        #endregion

        #region Funciones

         public Frm_stkTipoMov()
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


         private void CargarTiposMov()
         {

             try
             {
                 BLL.Tables.STKTIPOMOV _tipo = new BLL.Tables.STKTIPOMOV();
                 _tipo.OrderByParameter.Add(DAL.Tables.STKTIPOMOV.ColumnEnum.descripcion);
                 this.bindingSourceMovimientoStock.DataSource = _tipo.ItemList();

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

        #endregion

         #region Eventos
         private void Frm_stkTipoMov_Load(object sender, EventArgs e)
         {

             //PERMISOS
             MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
             menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
             this.OperacionesDelUsuario();
             //FIN PERMISOS
             _idTipoMov = 0;
             CargarTiposMov();

         }

         private void toolStripButtonSave_Click(object sender, EventArgs e)
         {

             try
             {
                 Entities.Tables.STKTIPOMOV _item = new Entities.Tables.STKTIPOMOV();
                 BLL.Tables.STKTIPOMOV _tipo = new BLL.Tables.STKTIPOMOV();

                 _item.TIPOMOV_ID = _idTipoMov;
                 _item.DESCRIPCION = this.textBoxDescrip.Text.Trim();
                 if (this.radioButtonPositivo.Checked)
                 {
                     _item.SIGNO = 1;
                 }
                 else
                 {
                     _item.SIGNO = -1;
                 }
                 //verifico si la variable es distinta de cero
                 if (_idTipoMov != 0)
                 {
                     //ESTOY ACTUALIZANDO UN ESTADO
                     if (this.textBoxDescrip.Text.Trim() != string.Empty)
                     {
                         _tipo.Update(_item);
                         _idTipoMov = 0;
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
                         _idTipoMov = 0;
                         this.textBoxDescrip.Text = string.Empty;
                         MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                     else
                     {
                         MessageBox.Show("Debe ingresar una descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         this.textBoxDescrip.Focus();
                     }
                 }
                 CargarTiposMov();
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
                 _idTipoMov = Convert.ToInt32(this.dataGridViewMovimientoStock.Rows[e.RowIndex].Cells[(int)Col_Autorizacion.ID].Value);
                 //PASO LA DESCRIPCION
                 this.textBoxDescrip.Text = this.dataGridViewMovimientoStock.Rows[e.RowIndex].Cells[(int)Col_Autorizacion.DESCRIPCION].Value.ToString();
                 string _Signo;
                 _Signo = this.dataGridViewMovimientoStock.Rows[e.RowIndex].Cells[(int)Col_Autorizacion.SIGNO].Value.ToString();

                 if (_Signo == "1")
                 {

                     this.radioButtonPositivo.Checked = true;
                 }

                 else
                 {
                     this.radioButtonNegativo.Checked = true;

                 }

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
