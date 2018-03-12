using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_comEstado : StaCatalina.Plantilla
    {
        #region Variables
        //PERMISOS
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        //fin PERMISOS
        private int _idEstado;

        private enum Col_Estados
        {
            ID = 0,
            DESCRIPCION
        }
        #endregion
        #region Funciones

        public Frm_comEstado()
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

        private void CargarEstados()
        {

            try
            {
                BLL.Tables.COMESTADO _tipo = new BLL.Tables.COMESTADO();
                _tipo.OrderByParameter.Add(DAL.Tables.COMESTADO.ColumnEnum.descripcion);
                this.bindingSourceEstadoCompra.DataSource = _tipo.ItemList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region Eventos

            private void Frm_comEstado_Load(object sender, EventArgs e)
        {

            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //FIN PERMISOS
            _idEstado = 0;
            CargarEstados();
        }

            private void toolStripButtonSave_Click(object sender, EventArgs e)
             {
                 try
                 {
                     Entities.Tables.COMESTADO _item = new Entities.Tables.COMESTADO();
                     BLL.Tables.COMESTADO _tipo = new BLL.Tables.COMESTADO();

                     _item.ESTADO_ID = _idEstado;
                     _item.DESCRIPCION = this.textBoxDescrip.Text.Trim();
                     //verifico si la variable es distinta de cero
                     if (_idEstado != 0)
                     {
                         //ESTOY ACTUALIZANDO UN ESTADO
                         if (this.textBoxDescrip.Text.Trim() != string.Empty)
                         {
                             _tipo.Update(_item);
                             _idEstado = 0;
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
                             _idEstado = 0;
                             this.textBoxDescrip.Text = string.Empty;
                             MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                         else
                         {
                             MessageBox.Show("Debe ingresar una descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             this.textBoxDescrip.Focus();
                         }
                     }
                     CargarEstados();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }

            private void dataGridViewEstadoCompra_CellClick(object sender, DataGridViewCellEventArgs e)
             {
                 try
                 {
                     //RECUPERO EL ID DE TIPO
                     _idEstado = Convert.ToInt32(this.dataGridViewEstadoCompra.Rows[e.RowIndex].Cells[(int)Col_Estados.ID].Value);
                     //PASO LA DESCRIPCION
                     this.textBoxDescrip.Text = this.dataGridViewEstadoCompra.Rows[e.RowIndex].Cells[(int)Col_Estados.DESCRIPCION].Value.ToString();

                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
            
            private void toolStripButtonNew_Click(object sender, EventArgs e)
            {
                this.textBoxDescrip.Text = string.Empty;
                _idEstado = 0;
                this.textBoxDescrip.Focus();
            }






        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
