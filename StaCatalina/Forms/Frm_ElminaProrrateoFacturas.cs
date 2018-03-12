using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace StaCatalina.Forms
{
    public partial class Frm_ElminaProrrateoFacturas : StaCatalina.Plantilla
    {
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private enum Col_Fact
        {
            CODEMP = 0,
            SELECCIONA,
            SCC_ID,
            SCCSUC_ID,
            SCCEMO_CODIGO,
            TIPOPRORRATEO,
            FEMISION,
            LETRA,
            CODIGO,
            DESCRIP_COMPROB,
            COMPROBANTE,
            CODPROVEED,
            RAZONSOCIAL

        }


        public Frm_ElminaProrrateoFacturas()
        {
            InitializeComponent();
        }

        private void TraerFactueras()
        {
            try
            {
                BLL.Procedures.USR_TRAEFACTURASPRORRATEADAS _detalle = new BLL.Procedures.USR_TRAEFACTURASPRORRATEADAS();
                this.dataGridViewFacturas.Rows.Clear();
               
                var q = (dynamic)null;

                if (radioButtonTodas.Checked)
                {
                    q = (from item in _detalle.ItemList(dateTimeDesde.Value, dateTimeHasta.Value)
                         select item);
                }
                if (radioButtonEmpresa.Checked)
                {
                    q = (from item in _detalle.ItemList(dateTimeDesde.Value, dateTimeHasta.Value)
                         select item).Where(m => m.tipoprorrateo == "Empresa");
                }

                if (radioButtonCuotas.Checked)
                {
                    q = (from item in _detalle.ItemList(dateTimeDesde.Value, dateTimeHasta.Value)
                         select item).Where(m => m.tipoprorrateo == "Cuotas");
                }

                int indice;
                foreach (Entities.Procedures.USR_TRAEFACTURASPRORRATEADAS item in q) 
                {
                    indice = dataGridViewFacturas.Rows.Add();
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.CODEMP].Value = item.emp;//CODIGO DE EMPRESA
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.SCC_ID].Value = item.scc_id;
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.SCCSUC_ID].Value = item.sccsuc_cod; 
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.SCCEMO_CODIGO].Value = item.sccemp_codigo;
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.TIPOPRORRATEO].Value = item.tipoprorrateo;
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.FEMISION].Value = Convert.ToDateTime(item.femision).ToShortDateString();
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.LETRA].Value = item.letra;
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.CODIGO].Value = item.codigocomprob;
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.DESCRIP_COMPROB].Value = item.descripcomprob;
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.COMPROBANTE].Value = item.comprobante;
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.CODPROVEED].Value = item.codproveed;
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Fact.RAZONSOCIAL].Value = item.razonsocial;
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Frm_ElminaProrrateoFacturas_Load(object sender, EventArgs e)
        {
            this.dateTimeDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.dateTimeHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {
            TraerFactueras();
        }

        private void dateTimeHasta_ValueChanged(object sender, EventArgs e)
        {
            TraerFactueras();
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewFacturas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewFacturas.IsCurrentCellDirty)
                dataGridViewFacturas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean _selecciono = false;
                BLL.Procedures.ELIMINAPRORRATEO _itemFactura = new BLL.Procedures.ELIMINAPRORRATEO();
                string _codEmp = string.Empty;
                Int32 scc_ID = 0;
                string sccsuc_Cod = string.Empty;
                string sccemp_Codigo = string.Empty;

                for (int i = 0; i < this.dataGridViewFacturas.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewFacturas.Rows[i].Cells[(int)Col_Fact.SELECCIONA] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _selecciono = true;
                        _codEmp = dataGridViewFacturas.Rows[i].Cells[(int)Col_Fact.CODEMP].Value.ToString();
                        scc_ID = Convert.ToInt32(dataGridViewFacturas.Rows[i].Cells[(int)Col_Fact.SCC_ID].Value);
                        sccsuc_Cod = dataGridViewFacturas.Rows[i].Cells[(int)Col_Fact.SCCSUC_ID].Value.ToString();
                        sccemp_Codigo = dataGridViewFacturas.Rows[i].Cells[(int)Col_Fact.SCCEMO_CODIGO].Value.ToString();

                        _itemFactura.ItemList(_codEmp, scc_ID, sccsuc_Cod, sccemp_Codigo);

                       _codEmp = string.Empty;
                       scc_ID = 0;
                       sccsuc_Cod = string.Empty;
                       sccemp_Codigo = string.Empty;
                    }
                }

                if(_selecciono)
                {
                    TraerFactueras();
                    MessageBox.Show("Facturas Eliminadas correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("NO ha seleccionado ninguna Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonCuotas_CheckedChanged(object sender, EventArgs e)
        {
            TraerFactueras();
        }

        private void radioButtonEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            TraerFactueras();
        }

        private void radioButtonTodas_CheckedChanged(object sender, EventArgs e)
        {
            TraerFactueras();
        }
    }
}
