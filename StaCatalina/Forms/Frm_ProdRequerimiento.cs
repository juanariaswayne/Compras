using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_ProdRequerimiento : Form
    {
        private List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        private List<Entities.Procedures.TRAESUBRUBROSDELUSUARIO> _rubroItem = new List<Entities.Procedures.TRAESUBRUBROSDELUSUARIO>();
        
        #region varibles publicas
            public List<Entities.Procedures.H_ARTICULOSDEPOSITO> Articulos
            {
                get { return _articulosItem; }
                set { _articulosItem = value; }

            }

            public List<Entities.Procedures.TRAESUBRUBROSDELUSUARIO> Rubros
            {
                get { return _rubroItem; }
                set { _rubroItem = value; }

            }

            public IAddItemReq Opener { get; set; }
        #endregion
        #region Funciones


            public Frm_ProdRequerimiento()
            {
                InitializeComponent();
            }

            private void CargarRubros()
            {
                try
                {
                    Entities.Procedures.TRAESUBRUBROSDELUSUARIO _itemSeleccion = new Entities.Procedures.TRAESUBRUBROSDELUSUARIO();

                    //Limpia el combo
                    this.comboBoxrubro.SuspendLayout();
                    this.comboBoxrubro.DataSource = null;
                    this.comboBoxrubro.Items.Clear();


                   // Carga el item de Seleccion
                    _itemSeleccion.da2_desc = "<Seleccione un Sub Rubro>";
                    _itemSeleccion.artda2_cod = "0";
                    _rubroItem.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxrubro.DisplayMember = BLL.Procedures.TRAESUBRUBROSDELUSUARIO.ColumnNames.DA2_DESC;
                    this.comboBoxrubro.ValueMember = BLL.Procedures.TRAESUBRUBROSDELUSUARIO.ColumnNames.ARTDA2_COD;
                    this.comboBoxrubro.DataSource = _rubroItem;
                    this.comboBoxrubro.SelectedIndex = 0;

                    this.comboBoxrubro.ResumeLayout();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        #endregion
            private void Frm_ProdRequerimiento_Load(object sender, EventArgs e)
        {
           // this.bindingSourceReq.DataSource = _articulosItem;
            CargarRubros();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var q = (dynamic)null;

            q = (from item in _articulosItem
                 where item.art_descgen.Contains(textBoxBuscar.Text.Trim().ToUpper()) && item.subrubro.Contains(this.comboBoxrubro.SelectedValue.ToString())
                 select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();
            this.bindingSourceReq.DataSource = q;
        }

        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonSearch.PerformClick();
            }
        }

        private void dataGridViewProdReq_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Opener.AddNewItemReq(this.dataGridViewProdReq.Rows[e.RowIndex].Cells[0].Value.ToString(), this.dataGridViewProdReq.Rows[e.RowIndex].Cells[1].Value.ToString(), this.dataGridViewProdReq.Rows[e.RowIndex].Cells[2].Value.ToString());
            this.Close();
            this.Dispose();
        }

        private void dataGridViewProdReq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.dataGridViewProdReq.CurrentCell.ColumnIndex > 0 && this.dataGridViewProdReq.CurrentCell.ColumnIndex < 3)
                {
                    this.Opener.AddNewItemReq(this.dataGridViewProdReq.Rows[this.dataGridViewProdReq.CurrentCell.RowIndex].Cells[0].Value.ToString(), this.dataGridViewProdReq.Rows[this.dataGridViewProdReq.CurrentCell.RowIndex].Cells[1].Value.ToString(), this.dataGridViewProdReq.Rows[this.dataGridViewProdReq.CurrentCell.RowIndex].Cells[2].Value.ToString());
                    this.Close();
                    this.Dispose();

                }

            }
        }

        private void comboBoxrubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MUESTRA LOS ARTICULOS DE ESE RUBRO
            try
            {
                if (this.comboBoxrubro.SelectedIndex > 0)
                {
                    this.buttonSearch.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

     
    }
}
