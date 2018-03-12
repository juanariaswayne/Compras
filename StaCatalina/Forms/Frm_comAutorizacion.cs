using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_comAutorizacion : StaCatalina.Plantilla
    {
        #region Variables

        //PERMISOS
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        //fin PERMISOS
        private int _idAutorizacion;

        private enum Col_Estados
        {
            ID = 0,
            DESCRIPCION
        }
        #endregion

        #region Funciones

        public Frm_comAutorizacion()
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

        private void CargarAutorizaciones()
        {

            try
            {
                BLL.Tables.COMAUTORIZACION _tipo = new BLL.Tables.COMAUTORIZACION();
                _tipo.OrderByParameter.Add(DAL.Tables.COMAUTORIZACION.ColumnEnum.descripcion);
                this.bindingSourceAutorizacion.DataSource = _tipo.ItemList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void Frm_comAutorizacion_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //FIN PERMISOS
            _idAutorizacion = 0;
            CargarAutorizaciones();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.Tables.COMAUTORIZACION _item = new Entities.Tables.COMAUTORIZACION();
                BLL.Tables.COMAUTORIZACION _tipo = new BLL.Tables.COMAUTORIZACION();

                _item.NIVEL_ID = _idAutorizacion;
                _item.DESCRIPCION = this.textBoxDescrip.Text.Trim();
                //verifico si la variable es distinta de cero
                if (_idAutorizacion != 0)
                {
                    //ESTOY ACTUALIZANDO UN ESTADO
                    if (this.textBoxDescrip.Text.Trim() != string.Empty)
                    {
                        _tipo.Update(_item);
                        _idAutorizacion = 0;
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
                        _idAutorizacion = 0;
                        this.textBoxDescrip.Text = string.Empty;
                        MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar una descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBoxDescrip.Focus();
                    }
                }
                CargarAutorizaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAutorizacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //RECUPERO EL ID DE TIPO
                _idAutorizacion = Convert.ToInt32(this.dataGridViewAutorizacion.Rows[e.RowIndex].Cells[(int)Col_Estados.ID].Value);
                //PASO LA DESCRIPCION
                this.textBoxDescrip.Text = this.dataGridViewAutorizacion.Rows[e.RowIndex].Cells[(int)Col_Estados.DESCRIPCION].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            this.textBoxDescrip.Text = string.Empty;
            _idAutorizacion = 0;
            this.textBoxDescrip.Focus();
        }






        #region Eventos





        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
