using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_AsociaCtaContableArticulos : StaCatalina.Plantilla
    {
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private enum col_Grid
        {
            ARTICULO = 0,
            NROCUENTA,
            DESCRIP_CTA

        }
        //VARIABLE COMBO GRILLA
        DataGridViewComboBoxEditingControl dgvCombo;
        #region funciones
        public Frm_AsociaCtaContableArticulos()
        {
            InitializeComponent();
        }

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

        private void CargarCuentasCombo()
        {
            try
            {
                //CARGO LOS DEPOSITOS EN LA COLUMNA COMBO DEL GRID

                DataGridViewComboBoxColumn comboboxColumnCuenta = dataGridViewCuentas.Columns[(int)col_Grid.DESCRIP_CTA] as DataGridViewComboBoxColumn;

                BLL.Procedures.PLAN_DE_CUENTA _tip = new BLL.Procedures.PLAN_DE_CUENTA();
                _tip.ItemList();
                Entities.Procedures.PLAN_DE_CUENTA _itemSeleccion = new Entities.Procedures.PLAN_DE_CUENTA();

                //Limpia el combo
                //this.comboBoxProveed.SuspendLayout();
                comboboxColumnCuenta.DataSource = null;
                comboboxColumnCuenta.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.cta_descrip = "<Seleccione una Cuenta>";
                _itemSeleccion.com_valor = "0";
                _tip.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                comboboxColumnCuenta.DataSource = _tip.Result.ToArray();
                comboboxColumnCuenta.DisplayMember = BLL.Procedures.PLAN_DE_CUENTA.ColumnNames.CTA_DESCRIP;
                comboboxColumnCuenta.ValueMember = BLL.Procedures.PLAN_DE_CUENTA.ColumnNames.COM_VALOR;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46) // Si no es numerico y si no es espacio EL 46 ES EL PUNTO
            {
                // Invalidar la accion
                e.Handled = true;
                // Enviar el sonido de beep de windows
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void dvgCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //es el combo 
            ComboBox combo = sender as ComboBox;
            if (combo.SelectedIndex > 0)
            {
                //PASO EL NRO DE CUENTA A LA COLUMNA QUE MUESTRA LA CUENTA CONTABLE
                DataGridViewRow row = this.dataGridViewCuentas.CurrentRow;
                dataGridViewCuentas.Rows[row.Index].Cells[(int)col_Grid.NROCUENTA].Value = combo.SelectedValue.ToString();
            }
        }
        #endregion

        #region eventos
        private void Frm_AsociaCtaContableArticulos_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            CargarCuentasCombo();
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewCuentas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewCuentas.IsCurrentCellDirty)
                dataGridViewCuentas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion

        private void dataGridViewCuentas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewCuentas.CurrentCell.ColumnIndex;
            if (iColumn == (int)col_Grid.NROCUENTA)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }

            //VERIFICA SI CAMBIA LA CUENTA...
            if (iColumn == (int)col_Grid.DESCRIP_CTA)
            {
                dgvCombo = e.Control as DataGridViewComboBoxEditingControl;
                if (dgvCombo != null)
                {
                    dgvCombo.SelectedIndexChanged += new EventHandler(dvgCombo_SelectedIndexChanged);
                }

            }

            if (e.Control is DataGridViewTextBoxEditingControl && iColumn == (int)col_Grid.ARTICULO)
            {
                DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;
                tb.KeyPress -= dataGridViewCuentas_KeyPress;
                tb.KeyPress += new KeyPressEventHandler(dataGridViewCuentas_KeyPress);
            }

        }

        private void dataGridViewCuentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCombo != null && (e.ColumnIndex == (int)col_Grid.DESCRIP_CTA))
            { dgvCombo.SelectedIndexChanged -= new EventHandler(dvgCombo_SelectedIndexChanged); }

            if(e.ColumnIndex == (int)col_Grid.NROCUENTA)
            {
                
            }
        }

        private void dataGridViewCuentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == e.KeyChar.ToString().ToUpper())
                return;

            e.Handled = true;
            SendKeys.Send(e.KeyChar.ToString().ToUpper());


        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Procedures.ACTUALIZACUENTASCONTABLECOMPRAS_ARTICULOS _cuenta = new BLL.Procedures.ACTUALIZACUENTASCONTABLECOMPRAS_ARTICULOS();
                bool selecciono = false;
                for (int i=0; i< this.dataGridViewCuentas.Rows.Count-1;i++)
                {
                    if (dataGridViewCuentas.Rows[i].Cells[(int)col_Grid.ARTICULO].Value != null && dataGridViewCuentas.Rows[i].Cells[(int)col_Grid.NROCUENTA].Value != null && dataGridViewCuentas.Rows[i].Cells[(int)col_Grid.ARTICULO].Value != string.Empty && dataGridViewCuentas.Rows[i].Cells[(int)col_Grid.NROCUENTA].Value != string.Empty)
                    {
                        _cuenta.ItemList(dataGridViewCuentas.Rows[i].Cells[(int)col_Grid.ARTICULO].Value.ToString(), dataGridViewCuentas.Rows[i].Cells[(int)col_Grid.NROCUENTA].Value.ToString());
                        selecciono = true;
                    }

                }
                if(selecciono)
                    MessageBox.Show("Cuentas actualizadas correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
