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

    public partial class Frm_ProdModReq : Form
    {
        private List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();

        #region varibles publicas
        public List<Entities.Procedures.H_ARTICULOSDEPOSITO> Articulos
        {
            get { return _articulosItem; }
            set { _articulosItem = value; }

        }

        public IAddItemModReq Opener { get; set; }
        #endregion

        public Frm_ProdModReq()
        {
            InitializeComponent();
        }


        private void Frm_ProdModReq_Load(object sender, EventArgs e)
        {
            this.bindingSourceModReq.DataSource = _articulosItem;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var q = (dynamic)null;

            q = (from item in _articulosItem
                 where item.art_descgen.Contains(textBoxBuscar.Text.Trim().ToUpper())
                 select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();
            this.bindingSourceModReq.DataSource = q;
        }

       
        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonSearch.PerformClick();
            }
        }

        private void dataGridViewProdModReq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.dataGridViewProdModReq.CurrentCell.ColumnIndex > 0 && this.dataGridViewProdModReq.CurrentCell.ColumnIndex < 3)
                {
                    this.Opener.AddNewItemModReq(this.dataGridViewProdModReq.Rows[this.dataGridViewProdModReq.CurrentCell.RowIndex].Cells[0].Value.ToString(), this.dataGridViewProdModReq.Rows[this.dataGridViewProdModReq.CurrentCell.RowIndex].Cells[1].Value.ToString(), this.dataGridViewProdModReq.Rows[this.dataGridViewProdModReq.CurrentCell.RowIndex].Cells[2].Value.ToString());
                    this.Close();
                    this.Dispose();

                }

            }
        }

        private void dataGridViewProdModReq_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.Opener.AddNewItemModReq(this.dataGridViewProdModReq.Rows[e.RowIndex].Cells[0].Value.ToString(), this.dataGridViewProdModReq.Rows[e.RowIndex].Cells[1].Value.ToString(), this.dataGridViewProdModReq.Rows[e.RowIndex].Cells[2].Value.ToString());
            this.Close();
            this.Dispose();

        }
    }
}
