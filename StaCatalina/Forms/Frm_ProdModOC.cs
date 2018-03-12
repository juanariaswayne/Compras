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
    public partial class Frm_ProdModOc : Form
    {
        private List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();

        #region varibles publicas
        public List<Entities.Procedures.H_ARTICULOSDEPOSITO> Articulos
        {
            get { return _articulosItem; }
            set { _articulosItem = value; }

        }

        public IAddItemModOC Opener { get; set; }
        #endregion
        
        public Frm_ProdModOc()
        {
            InitializeComponent();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var q = (dynamic)null;

            q = (from item in _articulosItem
                 where item.art_descgen.Contains(textBoxBuscar.Text.Trim().ToUpper())
                 select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();
            this.bindingSourceModOC.DataSource = q;
        }


     
        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonSearch.PerformClick();
            }
        }

        private void dataGridViewProdOCDirecta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.dataGridViewProdModOc.CurrentCell.ColumnIndex > 0 && this.dataGridViewProdModOc.CurrentCell.ColumnIndex < 3)
                {
                    this.Opener.AddNewItemModOC(this.dataGridViewProdModOc.Rows[this.dataGridViewProdModOc.CurrentCell.RowIndex].Cells[0].Value.ToString(), this.dataGridViewProdModOc.Rows[this.dataGridViewProdModOc.CurrentCell.RowIndex].Cells[1].Value.ToString(), this.dataGridViewProdModOc.Rows[this.dataGridViewProdModOc.CurrentCell.RowIndex].Cells[2].Value.ToString());
                    this.Close();
                    this.Dispose();

                }

            }
        }

        private void Frm_ProdModOc_Load(object sender, EventArgs e)
        {
            this.bindingSourceModOC.DataSource = _articulosItem;
        }

        private void dataGridViewProdModOc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Opener.AddNewItemModOC(this.dataGridViewProdModOc.Rows[e.RowIndex].Cells[0].Value.ToString(), this.dataGridViewProdModOc.Rows[e.RowIndex].Cells[1].Value.ToString(), this.dataGridViewProdModOc.Rows[e.RowIndex].Cells[2].Value.ToString());
            this.Close();
            this.Dispose();
        }
    }
}
