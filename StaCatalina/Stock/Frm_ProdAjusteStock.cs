using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Stock
{
    public partial class Frm_ProdAjusteStock : Form
    {
        private List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        private List<Entities.Procedures.RUBROARTICULOS> _rubroItem = new List<Entities.Procedures.RUBROARTICULOS>();
        #region varibles publicas
            public List<Entities.Procedures.H_ARTICULOSDEPOSITO> Articulos
            {
                get { return _articulosItem; }
                set { _articulosItem = value; }

            }

            public List<Entities.Procedures.RUBROARTICULOS> Rubros
            {
                get { return _rubroItem; }
                set { _rubroItem = value; }

            }
            public IAddItemAjusteStock Opener { get; set; }
        #endregion
        
        public Frm_ProdAjusteStock()
        {
            InitializeComponent();
        }

        private void CargarRubros()
        {
            try
            {
                Entities.Procedures.RUBROARTICULOS _itemSeleccion = new Entities.Procedures.RUBROARTICULOS();

                //Limpia el combo
                this.comboBoxrubro.SuspendLayout();
                this.comboBoxrubro.DataSource = null;
                this.comboBoxrubro.Items.Clear();


                //Carga el item de Seleccion
                //_itemSeleccion.pro_razsoc = "<Seleccione un Rubro>";
                //_itemSeleccion.pro_cod = "0";
                //_rubroItem.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxrubro.DisplayMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_DESC;
                this.comboBoxrubro.ValueMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_COD;
                this.comboBoxrubro.DataSource = _rubroItem;
                this.comboBoxrubro.SelectedIndex = 0;

                this.comboBoxrubro.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Frm_ProdAjusteStock_Load(object sender, EventArgs e)
        {
            this.bindingSourceIngStock.DataSource = _articulosItem;
            CargarRubros();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var q = (dynamic)null;

            q = (from item in _articulosItem
                 where item.art_descgen.Contains(textBoxBuscar.Text.Trim().ToUpper()) && item.rubro.Contains(this.comboBoxrubro.SelectedValue.ToString())
                 select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();
            this.bindingSourceIngStock.DataSource = q;
        }

        private void dataGridViewProdIngStock_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Opener.AddNewItemAjusteStock(this.dataGridViewProdAjusteStock.Rows[e.RowIndex].Cells[0].Value.ToString(), this.dataGridViewProdAjusteStock.Rows[e.RowIndex].Cells[1].Value.ToString(), this.dataGridViewProdAjusteStock.Rows[e.RowIndex].Cells[2].Value.ToString(), Convert.ToBoolean(this.dataGridViewProdAjusteStock.Rows[e.RowIndex].Cells[4].Value));
            this.Close();
            this.Dispose();
        }

        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonSearch.PerformClick();
            }
        }

        private void dataGridViewProdAjusteStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.dataGridViewProdAjusteStock.CurrentCell.ColumnIndex > 0 && this.dataGridViewProdAjusteStock.CurrentCell.ColumnIndex < 3)
                {
                    this.Opener.AddNewItemAjusteStock(this.dataGridViewProdAjusteStock.Rows[this.dataGridViewProdAjusteStock.CurrentCell.RowIndex].Cells[0].Value.ToString(), this.dataGridViewProdAjusteStock.Rows[this.dataGridViewProdAjusteStock.CurrentCell.RowIndex].Cells[1].Value.ToString(), this.dataGridViewProdAjusteStock.Rows[this.dataGridViewProdAjusteStock.CurrentCell.RowIndex].Cells[2].Value.ToString(), Convert.ToBoolean(this.dataGridViewProdAjusteStock.Rows[this.dataGridViewProdAjusteStock.CurrentCell.RowIndex].Cells[4].Value));
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
                this.buttonSearch.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
