using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;

namespace StaCatalina.Forms
{
    public partial class Frm_AutorizaOCSinStock : StaCatalina.Plantilla
    {
        private enum Col_OCCab
        {
            CODEMP = 0,
            EMPRESA,
            NRO_OC,
            FECHA,
            PROVEEDOR,
            OBSERVACIONES,
            EMAIL,
            TIPO_OC

        }

        private enum Col_OCItem
        {
            CODEMP = 0,
            NRO_OC,
            ITEM,
            DETALLE,
            CANTIDAD,
            PRECIO,
           
        }

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        CultureInfo culture = new CultureInfo("en-US");
        bool blnAjustarCeldas = true;
        public Frm_AutorizaOCSinStock()
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

        private void TraeOCPendientes()
        {

            try
            {
                checkBoxAutoriza.Checked = false;
                checkBoxNoAutoriza.Checked = false;
                labelImporteOC.Text = string.Empty;

                BLL.Procedures.ORDENCOMPRA_DISPONIBLES_SINSTOCK _detalle = new BLL.Procedures.ORDENCOMPRA_DISPONIBLES_SINSTOCK();
                this.dataGridViewOCCabSinStock.Rows.Clear();
                //FILTRO LOS DE LA EMPRESA LOGEADA
                var q = (dynamic)null;

                q = (from _item in _detalle.ItemList()
                     where _item.codemp.Trim() == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim()
                     select _item);

                int indice;
                foreach (Entities.Procedures.ORDENCOMPRA_DISPONIBLES_SINSTOCK item in q)
                {
                    indice = dataGridViewOCCabSinStock.Rows.Add();
                    dataGridViewOCCabSinStock.Rows[indice].Cells[(int)Col_OCCab.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewOCCabSinStock.Rows[indice].Cells[(int)Col_OCCab.EMPRESA].Value = item.codemp; //EMPRESA
                    dataGridViewOCCabSinStock.Rows[indice].Cells[(int)Col_OCCab.NRO_OC].Value = item.ordencompra_id; //NRO OC
                    dataGridViewOCCabSinStock.Rows[indice].Cells[(int)Col_OCCab.FECHA].Value = item.fecha.ToShortDateString();//FECHA
                    dataGridViewOCCabSinStock.Rows[indice].Cells[(int)Col_OCCab.PROVEEDOR].Value = item.razonsocial;//PROVEEDOR
                    dataGridViewOCCabSinStock.Rows[indice].Cells[(int)Col_OCCab.OBSERVACIONES].Value = item.obs;//PROVEEDOR
                    dataGridViewOCCabSinStock.Rows[indice].Cells[(int)Col_OCCab.EMAIL].Value = item.email;//EMAIL
                    dataGridViewOCCabSinStock.Rows[indice].Cells[(int)Col_OCCab.TIPO_OC].Value = item.obs;//TIPO OC
                    dataGridViewOCCabSinStock.Rows[indice].DefaultCellStyle.BackColor = (item.pedidodiario) ? Color.YellowGreen : Color.White;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Frm_AutorizaOCSinStock_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

           
            //FIN PERMISOS
            this.Text = "Autorización Orden de Compra Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
            TraeOCPendientes();
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewOCCabSinStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {

                    //this.textBoxDetalleOC.Visible = false;
                    //this.dataGridViewOCItem.Visible = true;

                    BLL.Procedures.TRAEORDENCOMPRADETALLE _item = new BLL.Procedures.TRAEORDENCOMPRADETALLE();

                    this.dataGridViewOCItemSinStock.Rows.Clear();
                    int indice;
                    decimal _totalOC = 0;
                    foreach (Entities.Procedures.TRAEORDENCOMPRADETALLE item in _item.ItemList(dataGridViewOCCabSinStock.Rows[e.RowIndex].Cells[(int)Col_OCCab.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewOCCabSinStock.Rows[e.RowIndex].Cells[(int)Col_OCCab.NRO_OC].Value), 1))
                    {
                        indice = dataGridViewOCItemSinStock.Rows.Add();
                        dataGridViewOCItemSinStock.Rows[indice].Cells[(int)Col_OCItem.CODEMP].Value = item.codemp;//CODIGO EMPRESA
                        dataGridViewOCItemSinStock.Rows[indice].Cells[(int)Col_OCItem.NRO_OC].Value = item.ordencompra_id; //OC
                        dataGridViewOCItemSinStock.Rows[indice].Cells[(int)Col_OCItem.ITEM].Value = item.nroitem; //NRO ITEM
                        dataGridViewOCItemSinStock.Rows[indice].Cells[(int)Col_OCItem.PRECIO].Value = item.importe.ToString().Replace(",", ".");//PRECIO 
                        dataGridViewOCItemSinStock.Rows[indice].Cells[(int)Col_OCItem.CANTIDAD].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD  
                        dataGridViewOCItemSinStock.Rows[indice].Cells[(int)Col_OCItem.DETALLE].Value = item.detalle;//DETALLE
                      

                        decimal _precio = Convert.ToDecimal(item.importe.ToString().Replace(",", ".").ToString(), culture);
                        decimal _cantidad = Convert.ToDecimal(item.cantidad.ToString().Replace(",", ".").ToString(), culture);

                        _totalOC = Convert.ToDecimal(_totalOC + (_precio * _cantidad), culture);
                    }
                    labelImporteOC.Text = "$ " + _totalOC.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOCItemSinStock.Rows.Count > 0)
                {
                    if(checkBoxAutoriza.Checked  || checkBoxNoAutoriza.Checked)
                    {
                        Entities.Tables.COMORDENCOMPRADETALLE _itemOC = new Entities.Tables.COMORDENCOMPRADETALLE();
                        List<Entities.Tables.COMORDENCOMPRADETALLE> _items = new List<Entities.Tables.COMORDENCOMPRADETALLE>();
                        Entities.Tables.COMORDENCOMPRA _itemCab = new Entities.Tables.COMORDENCOMPRA();
                        BLL.Tables.COMORDENCOMPRA _auto = new BLL.Tables.COMORDENCOMPRA();

                        for (int i = 0; i < this.dataGridViewOCItemSinStock.Rows.Count; i++)
                        {

                            _itemOC = new Entities.Tables.COMORDENCOMPRADETALLE();
                            _itemOC.CODEMP = dataGridViewOCItemSinStock.Rows[i].Cells[(int)Col_OCItem.CODEMP].Value.ToString();
                            _itemOC.ORDENCOMPRA_ID = Convert.ToInt32(dataGridViewOCItemSinStock.Rows[i].Cells[(int)Col_OCItem.NRO_OC].Value);
                            _itemOC.IMPORTE = Convert.ToDouble(dataGridViewOCItemSinStock.Rows[i].Cells[(int)Col_OCItem.PRECIO].Value.ToString(), culture);
                            _itemOC.CANTIDAD = Convert.ToDecimal(dataGridViewOCItemSinStock.Rows[i].Cells[(int)Col_OCItem.CANTIDAD].Value.ToString(), culture);
                            _itemOC.NROITEM = Convert.ToInt32(dataGridViewOCItemSinStock.Rows[i].Cells[(int)Col_OCItem.ITEM].Value);
                            _itemOC.DETALLE = dataGridViewOCItemSinStock.Rows[i].Cells[(int)Col_OCItem.DETALLE].Value.ToString();

                            //VERIFICA SI ESTA AUTORIZADO
                            if (checkBoxAutoriza.Checked)
                            {
                                _itemOC.NIVELAUTO_ID = 2;
                                _items.Add(_itemOC); //VOY AGREGANDO A LA COLECCION
                            }
                            //VERIFICA SI LO ESTA RECHAZANDO
                            if (checkBoxNoAutoriza.Checked)
                            {
                                _itemOC.NIVELAUTO_ID = 3;
                                _items.Add(_itemOC); //VOY AGREGANDO A LA COLECCION
                            }

                        }
                            //DATOS PARA LA CABECERA
                            _itemCab.CODEMP = dataGridViewOCCabSinStock.Rows[dataGridViewOCCabSinStock.CurrentRow.Index].Cells[(int)Col_OCCab.CODEMP].Value.ToString();
                            _itemCab.ORDENCOMPRA_ID = Convert.ToInt32(dataGridViewOCCabSinStock.Rows[dataGridViewOCCabSinStock.CurrentRow.Index].Cells[(int)Col_OCCab.NRO_OC].Value);
                            //PASO EL USUARIO LOGEADO
                            _itemCab.USUARIOAUTORIZA = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();

                            //ACTUALIZO CABECERA E ITEMS
                            _auto.AutorizaOrdenCompra(_items, _itemCab);

                           
                                MessageBox.Show("La autorización se guardó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //DialogResult _result = MessageBox.Show("Desea enviar al Proveedor la Orden de Compra por mail?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                //if (_result == System.Windows.Forms.DialogResult.OK)
                                //{

                                //    //ENVIO POR MAIL, SOLO LOS QUE SELECCIONO Y SI ESTE PROVEEDOR TIENE UN MAIL VÁLIDO
                                //    if (dataGridViewOCCabSinStock.Rows[dataGridViewOCCabSinStock.CurrentRow.Index].Cells[(int)Col_OCCab.EMAIL].Value != null && dataGridViewOCCabSinStock.Rows[dataGridViewOCCabSinStock.CurrentRow.Index].Cells[(int)Col_OCCab.EMAIL].Value != string.Empty)
                                //    {
                                //        //ExportToMSMail(_itemCab.CODEMP, _itemCab.ORDENCOMPRA_ID);
                                //        if (GenerarPDFOC(_itemCab.CODEMP, _itemCab.ORDENCOMPRA_ID, dataGridViewOCCabSinStock.Rows[dataGridViewOCCabSinStock.CurrentRow.Index].Cells[(int)Col_OCCab.EMAIL].Value.ToString()))
                                //        {
                                //            MessageBox.Show("Mail enviado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //        }
                                //        else
                                //        {
                                //            MessageBox.Show("No se pudo enviar el mail al proveedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                //        }
                                //    }



                                //}


                                TraeOCPendientes();
                                dataGridViewOCItemSinStock.Rows.Clear();
                           

                        


                    }

                    else
                    {

                        MessageBox.Show("Debe seleccionar al menos una opción de Autorización", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }

            catch(Exception ex)
            {


            }
        }

        private void dataGridViewOCItemSinStock_Paint(object sender, PaintEventArgs e)
        {
            if (blnAjustarCeldas)

            {

                blnAjustarCeldas = false;

                this.dataGridViewOCItemSinStock.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);

            }
        }

        private void dataGridViewOCItemSinStock_Scroll(object sender, ScrollEventArgs e)
        {
            this.dataGridViewOCItemSinStock.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
        }
    }
}
