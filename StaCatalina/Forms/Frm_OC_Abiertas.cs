using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;

namespace StaCatalina.Forms
{
    public partial class Frm_OC_Abiertas : StaCatalina.Plantilla
    {
        #region Variables
        //Permisos
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        //Fin permisos

        private enum Col_OCCab
        {
            CODEMP = 0,
            FECHA,
            NRO_OC,
            PROVEEDOR,
            FINALIZAR
          
        }
        private enum Col_OCItem
        {
            ARTICULO_ID=0,
            NRO_ITEM,
            ARTICULO,
            UNIDAD_DE_MEDIDA,
            PRECIO,
            CANTIDADPEDIDA,
            NRO_FACT,
            FECHA_FACT,
            CANT_FACT
            
           
        }

        List<OrdenCompraAbierta_SegunFacturaBejerman_Result> _listOCAbiertas = new List<OrdenCompraAbierta_SegunFacturaBejerman_Result>();

        private class groupOC
        {
            private string _codEmp;
            private int _ordenCompra_id;
            private DateTime _fecha;
            private string _proveed_id;
            private string _razonSocial;

            public string CodEmp { get => _codEmp; set => _codEmp = value; }
            public int OrdenCompra_id { get => _ordenCompra_id; set => _ordenCompra_id = value; }
            public DateTime Fecha { get => _fecha; set => _fecha = value; }
            public string Proveed_id { get => _proveed_id; set => _proveed_id = value; }
            public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        }


       
        #endregion

#region Funciones

        public Frm_OC_Abiertas()
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
        private void TraeOCPendientes(string _codEmp, int _dias)
        {

            try
            {
                StaCatalinaEntities _mod = new StaCatalinaEntities();

                Cursor = System.Windows.Forms.Cursors.WaitCursor;

                this.dataGridViewOCCab.Rows.Clear();
               
                _mod.Database.CommandTimeout = 3800;

               
                _listOCAbiertas =  (from _item in _mod.OrdenCompraAbierta_SegunFacturaBejerman(_codEmp,_dias) select _item).ToList();
                // guardo todo el detalle
                               

                var q = (from item in _listOCAbiertas.AsEnumerable()
                          group item by
                                  new
                                  {
                                      codEmp = item.codEmp.ToString(),
                                      ordenCompra_id = item.ordenCompra_id,
                                      fecha = (Convert.ToDateTime(item.fecha) == DateTime.MinValue) ? string.Empty: Convert.ToDateTime(item.fecha).ToShortDateString(),
                                      proveed_id = item.proveed_id.ToString(),
                                      razonSocial = item.razonSocial.ToString()
                                  }
                          into g
                          select new
                          {
                              codEmp = g.Key.codEmp,
                              ordenCompra_id = g.Key.ordenCompra_id,
                              fecha = g.Key.fecha,
                              proveed_id = g.Key.proveed_id,
                              razonSocial = g.Key.razonSocial
                       }).ToList();


           

            int indice;
                int _cant = 0;
                foreach (var item in q)
                {
                    indice = dataGridViewOCCab.Rows.Add();
                    this.dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.CODEMP].Value = item.codEmp;//CODIGO DE EMPRESA
                    this.dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.NRO_OC].Value = item.ordenCompra_id; //NRO OC
                    this.dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.FECHA].Value =  item.fecha;//FECHA
                    this.dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.PROVEEDOR].Value = item.razonSocial;//PROVEEDOR
                    _cant++;                

                }
                labelCantOC.Text = _cant.ToString();

                Cursor = System.Windows.Forms.Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = System.Windows.Forms.Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion


        private void Frm_OC_Abiertas_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            this.textBoxDias.Text = 30.ToString();
           
            this.Text = "Ordenes de Compra con Pendientes de Entrega de la Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
           
        }

        private void dataGridViewOCCab_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewOCCab.IsCurrentCellDirty)
                this.dataGridViewOCCab.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewOCItem_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewOCItem.IsCurrentCellDirty)
                this.dataGridViewOCItem.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewOCCab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var q = (dynamic)null;
                //string _codEmp = this.dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.CODEMP].Value.ToString();
                int _nroOC = Convert.ToInt32(this.dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.NRO_OC].Value);

                //StaCatalinaEntities _mod = new StaCatalinaEntities();

                //q = from _item in _mod.TraeOrdenCompraItem_OC_Abiertas (_codEmp,_nroOC) select _item;

                q = from _item in _listOCAbiertas.Where(x => x.ordenCompra_id == _nroOC).OrderBy(x => x.nroItem) select _item;
                              

                this.dataGridViewOCItem.Rows.Clear();
                int indice;
                foreach (OrdenCompraAbierta_SegunFacturaBejerman_Result item in q )
                {
                    indice = dataGridViewOCItem.Rows.Add();
                    this.dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.ARTICULO_ID].Value = item.articulo_id;//ARTICULO
       
                    this.dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.NRO_ITEM].Value = item.nroItem; //NRO ITEM
                    this.dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.ARTICULO].Value = item.prodDescrip.ToString();//DESCRIP ARTICULO
                    this.dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.UNIDAD_DE_MEDIDA].Value = item.uniMed;//TRAE UNIMED
                    this.dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.PRECIO].Value = item.precio;//PRECIO
                    this.dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CANTIDADPEDIDA].Value = item.cantidad.ToString().Replace(",", "."); ;//CANTIDAD PEDIDA   
                    this.dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.NRO_FACT].Value = item.F_Comprobante;//NRO FACT
                    this.dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.FECHA_FACT].Value = (Convert.ToDateTime(item.F_FEmision) == DateTime.MinValue) ? string.Empty : Convert.ToDateTime(item.F_FEmision).ToShortDateString();//FECHA FACT
                    this.dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CANT_FACT].Value = item.F_Cantidad.ToString().Replace(",", "."); ;//CANTIDAD PEDIDA 

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewOCCab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                    this.textBoxObs.Focus();
                    /// CONTROLO QUE NO TILDE MAS DE UNA O.C.
                    for (int i = 0; i < dataGridViewOCCab.Rows.Count - 1; i++)
                    {
                        if (i != e.RowIndex)
                            dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.FINALIZAR].Value = 0;


                    }


                    //

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean _selecciono = false;
                bool _finaliza = false;

                Entities.Tables.COMORDENCOMPRA _itemCab = new Entities.Tables.COMORDENCOMPRA();
                BLL.Procedures.FINALIZA_ANULA_OC _Actu = new BLL.Procedures.FINALIZA_ANULA_OC();


                for (int i = 0; i < this.dataGridViewOCCab.Rows.Count; i++)
                {
                    _itemCab = new Entities.Tables.COMORDENCOMPRA();

                    DataGridViewCheckBoxCell cellSelecion = this.dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.FINALIZAR] as DataGridViewCheckBoxCell;//FINALIZAR
                  
                    string _motivo = string.Empty;

                    //VERIFICA SI ESTA FINALIZANDO LA OC
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        if (this.textBoxObs.Text == string.Empty)
                        {
                            MessageBox.Show("Debe ingresar un Motivo por el cual está finalizando esta Orden de Compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        _itemCab.CODEMP = this.dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.CODEMP].Value.ToString();
                        _itemCab.ORDENCOMPRA_ID = Convert.ToInt32(this.dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.NRO_OC].Value);
                        _motivo = this.textBoxObs.Text.Trim();

                        _Actu.Items("F", _itemCab.CODEMP, _itemCab.ORDENCOMPRA_ID, _motivo);
                        _selecciono = true;
                        _finaliza = true;

                    }

    

                }

                if (_selecciono)
                {

                    MessageBox.Show("Orden de Compra Finalizada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridViewOCItem.Rows.Clear();
                    TraeOCPendientes(Clases.Usuario.EmpresaLogeada.EmpresaIngresada, Convert.ToInt32(textBoxDias.Text));
                    this.textBoxObs.Text = string.Empty;
                    //FIN ARTICULO PARA NUEVO REQUERIMIENTO

                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos una O.C", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            if (textBoxDias.Text != string.Empty)
            {


                TraeOCPendientes(Clases.Usuario.EmpresaLogeada.EmpresaIngresada, Convert.ToInt32(textBoxDias.Text));
            }
        }
    }
}
