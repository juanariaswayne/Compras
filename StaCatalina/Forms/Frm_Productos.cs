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
   
    public partial class Frm_Productos : Form
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
            public IAddItem Opener { get; set; }
        #endregion
        
        public Frm_Productos()
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

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.bindingSourceProd.DataSource = _articulosItem;
            CargarRubros();
        }

        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Opener.AddNewItem(this.dataGridViewProductos.Rows[e.RowIndex].Cells[0].Value.ToString(), this.dataGridViewProductos.Rows[e.RowIndex].Cells[1].Value.ToString(), this.dataGridViewProductos.Rows[e.RowIndex].Cells[2].Value.ToString());
            this.Close();
            this.Dispose();
   
        }

        private void textBoxBuscarProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonSearch.PerformClick();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var q = (dynamic)null;

            q = (from item in _articulosItem
                 where item.art_descgen.Contains(textBoxBuscarProd.Text.Trim().ToUpper()) && item.rubro.Contains(this.comboBoxrubro.SelectedValue.ToString())
                 select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();
            this.bindingSourceProd.DataSource = q;
        }

        private void dataGridViewProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.dataGridViewProductos.CurrentCell.ColumnIndex > 0 && this.dataGridViewProductos.CurrentCell.ColumnIndex < 3)
                {
                    this.Opener.AddNewItem(this.dataGridViewProductos.Rows[this.dataGridViewProductos.CurrentCell.RowIndex].Cells[0].Value.ToString(), this.dataGridViewProductos.Rows[this.dataGridViewProductos.CurrentCell.RowIndex].Cells[1].Value.ToString(), this.dataGridViewProductos.Rows[this.dataGridViewProductos.CurrentCell.RowIndex].Cells[2].Value.ToString());
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
