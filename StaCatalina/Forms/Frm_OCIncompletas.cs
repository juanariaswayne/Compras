using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
namespace StaCatalina.Forms
{
    public partial class Frm_OCIncompletas : Plantilla
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
            EMPRESA,
            NRO_OC,            
            SECTORREQ,
            ESTADO_ID,
            TIPOOC_ID,
            MODIFICACOSTO,
            CONDPAGO_ID,
            USUARIO,
            USUARIO_AUTORIZA,
            FECHA,
            PROVEEDOR,
            OBSERVACIONES,
            COMPLETA,
            ANULAR,
            SECTOR_ENTREGA_ID
        }
        private enum Col_OCItem
        {
            CODEMP = 0,
            ARTICULO_ID,
            NRO_OC,
            NRO_ITEM,
            ARTICULO,
            UNIDAD_DE_MEDIDA,
            PRECIO,
            CANTIDADPEDIDA,
            CANTIDADENTREGADA,
            CANTIDADADEUDADA,
            MARCA,
            FECHA_ENTREGA
        }
        #endregion

        #region Funciones
        public Frm_OCIncompletas()
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
                BLL.Procedures.ORDENCOMPRA_PENDIENTES_DE_ENTREGA _detalle = new BLL.Procedures.ORDENCOMPRA_PENDIENTES_DE_ENTREGA();
                this.dataGridViewOCCab.Rows.Clear();
                //FILTRO LAS OC DE LA EMPRESA DONDE INGRESO EL USUARIO.....
                var q = (dynamic)null;

                q = (from _item in _detalle.ItemList(this.dateTimeFechaDesde.Value, this.dateTimeFechaHasta.Value)
                     where _item.codemp.Trim() == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim()
                     select _item);
                
                int indice;
                foreach (Entities.Procedures.ORDENCOMPRA_PENDIENTES_DE_ENTREGA item in q)
                {
                    indice = dataGridViewOCCab.Rows.Add();
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.EMPRESA].Value = item.codemp; //EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.NRO_OC].Value = item.ordencompra_id; //NRO OC
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.SECTORREQ].Value = item.sectorrequerimiento_id; //SECTOR REQUERIMIENTO
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.ESTADO_ID].Value = item.estado_id; //ESTADI ID
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.TIPOOC_ID].Value = item.tipooc_id; //TIPO DE OC
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.MODIFICACOSTO].Value = item.modificacosto; //MODIFICA COSTO
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.CONDPAGO_ID].Value = item.condicionpago_id; //CONDICION PAGO ID
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.USUARIO].Value = item.usuario; //USUARIO
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.USUARIO_AUTORIZA].Value = item.usuarioautoriza; //USUARIO AUTORIZA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.FECHA].Value = item.fecha.ToShortDateString();//FECHA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.PROVEEDOR].Value = item.razonsocial;//PROVEEDOR
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.OBSERVACIONES].Value = item.obs;//OBSERVACIONES
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.SECTOR_ENTREGA_ID].Value = item.SectroEntrega_id;//SECTOR DE ENTREGA

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion

        #region Eventos
        private void Frm_OCIncompletas_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            this.dateTimeFechaDesde.Value = DateTime.Today;
            this.dateTimeFechaHasta.Value = DateTime.Today;
            this.Text = "Ordenes de Compra con Pendientes de Entrega de la Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
        }

        private void dateTimeFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            TraeOCPendientes();
        }

        private void dateTimeFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            TraeOCPendientes();
        }


        private void dataGridViewOCCab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BLL.Procedures.TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR _item = new BLL.Procedures.TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR();


                this.dataGridViewOCItem.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR item in _item.ItemList(dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.NRO_OC].Value), 2))
                {
                    indice = dataGridViewOCItem.Rows.Add();
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CODEMP].Value = item.codemp;//CODIGO EMPRESA
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.ARTICULO_ID].Value = item.articulo_id;//ARTICULO
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.NRO_OC].Value = item.ordencompra_id; //OC
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.NRO_ITEM].Value = item.nroitem; //NRO ITEM
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.ARTICULO].Value = item.art_descgen.ToString();//DESCRIP ARTICULO
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.UNIDAD_DE_MEDIDA].Value = item.unimed;//TRAE UNIMED
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.PRECIO].Value = item.precio;//PRECIO
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CANTIDADPEDIDA].Value = item.cantidad.ToString().Replace(",", "."); ;//CANTIDAD PEDIDA   
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CANTIDADADEUDADA].Value = item.cantidadadeudada.ToString().Replace(",", "."); ;//CANTIDAD ADEUDADA  
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CANTIDADENTREGADA].Value = (item.cantidad - item.cantidadadeudada).ToString().Replace(",", "."); //CANTIDAD ENTREGADA
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.MARCA].Value = item.marca;//MARCA
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.FECHA_ENTREGA].Value = item.fechaentrega;//FECHA ENTREGA
                    if (item.cantidadadeudada > 0)
                    {
                       dataGridViewOCItem.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;
                    }

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
                Boolean _selecciono = false;
                bool _finaliza = false;
               
                Entities.Tables.COMORDENCOMPRA _itemCab = new Entities.Tables.COMORDENCOMPRA();
                BLL.Procedures.FINALIZA_ANULA_OC _Actu = new BLL.Procedures.FINALIZA_ANULA_OC();

               
                for (int i = 0; i < this.dataGridViewOCCab.Rows.Count; i++)
                {
                    _itemCab = new Entities.Tables.COMORDENCOMPRA();

                    DataGridViewCheckBoxCell cellSelecion = dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.COMPLETA] as DataGridViewCheckBoxCell;//FINALIZAR
                    DataGridViewCheckBoxCell cellSelecionAnular = dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.ANULAR] as DataGridViewCheckBoxCell;//ANULAR
                    string _motivo = string.Empty;

                    //VERIFICA SI ESTA FINALIZANDO LA OC
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        if(this.textBoxObs.Text == string.Empty )
                        {
                            MessageBox.Show("Debe ingresar un Motivo por el cual está finalizando esta Orden de Compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        _itemCab.CODEMP = dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.CODEMP].Value.ToString(); 
                        _itemCab.ORDENCOMPRA_ID = Convert.ToInt32(dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.NRO_OC].Value);
                        //EL SECTOR LO NECESITO PARA CREAR UN NUEVO REQUERIMIENTO
                        _itemCab.SECTORENTREGA_ID = (dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.SECTOR_ENTREGA_ID].Value != null) ? Convert.ToInt32(dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.SECTOR_ENTREGA_ID].Value.ToString()): 0 ;
                        _motivo = this.textBoxObs.Text.Trim();

                        _Actu.Items("F",_itemCab.CODEMP,_itemCab.ORDENCOMPRA_ID,_motivo );
                        _selecciono = true;
                        _finaliza = true;

                    }

                    //VERIFICA SI ESTA ANULANDO LA OC *************** NO SE UTILIZA MAS.. HAY OTRO FORMULARIO PARA ANULAR LAS OC *****************************
                    //if (Convert.ToBoolean(cellSelecionAnular.Value))
                    //{

                    //    if (this.textBoxObs.Text == string.Empty)
                    //    {
                    //        MessageBox.Show("Debe ingresar un Motivo por el cual está anulando esta Orden de Compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //        return;
                    //    }
                    //    _itemCab.CODEMP = dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.CODEMP].Value.ToString();  //Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
                    //    _itemCab.ORDENCOMPRA_ID = Convert.ToInt32(dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.NRO_OC].Value);
                    //    _motivo = this.textBoxObs.Text.Trim();

                    //    _Actu.Items("A", _itemCab.CODEMP, _itemCab.ORDENCOMPRA_ID, _motivo);
                    //    _selecciono = true;

                    //}

                }
                if (_selecciono)
                {
                    
                    MessageBox.Show("Orden de Compra Finalizada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                    // **** LUEGO DE FINALIZAR LA ORDE DE COMPRA... VERIFICO SI TIENE ARTICULOS PENDIENTES DE ENTREGAR, DE TAL MANERA DE PROPONER AL USUARIO
                    //      SI QUIERE HACER UN NUEVO REQUERIMIENTO
                    if (_finaliza)
                    {
                        List<Frm_ArticulosParaNuevoRequerimiento.nuevosArticulos> _articulos = new List<Frm_ArticulosParaNuevoRequerimiento.nuevosArticulos>();
                        Frm_ArticulosParaNuevoRequerimiento.nuevosArticulos _itemNew = new Frm_ArticulosParaNuevoRequerimiento.nuevosArticulos();
                        CultureInfo culture = new CultureInfo("en-US");
                        bool _existenArticulos = false;
                        for (int i = 0; i < this.dataGridViewOCItem.Rows.Count; i++)
                        {
                            //SOLO LOS QUE TIENEN DIFERENCIAS DE ENTREGA... ES DECIR ENTREGARON DE MENOS O NO ENTREGARON NADA Y TIENEN EL TILDE DE GENERA NUEVO REQ
                            if (Convert.ToDecimal(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.CANTIDADADEUDADA].Value.ToString(),culture)>0)
                            {
                                _itemNew = new Frm_ArticulosParaNuevoRequerimiento.nuevosArticulos();
                                _existenArticulos = true;
                                _itemNew.CodEmp = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.CODEMP].Value.ToString();
                                _itemNew.Articulo = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.ARTICULO_ID].Value.ToString();
                                _itemNew.Cantidad = Convert.ToDecimal(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.CANTIDADADEUDADA].Value.ToString(),culture);
                                _itemNew.UniMed = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.UNIDAD_DE_MEDIDA].Value.ToString();
                                _itemNew.Marca = (dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.MARCA].Value != null) ? dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.MARCA].Value.ToString(): string.Empty ; 
                                _itemNew.Descripcion = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.ARTICULO].Value.ToString(); //DESCRIPCION ARTICULO
                                _articulos.Add(_itemNew);//AGREGO A LA COLECCIÓN
                               
                            }

                        }

                        if(_existenArticulos)
                        {
                            DialogResult _result = MessageBox.Show("Desea generar un nuevo requerimiento con los artículos pendientes de entrega ?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (_result == DialogResult.OK)
                            {
                                //GENERO OBJETOS PARA EL NUEVO REQUERIMIENTO
                                Frm_ArticulosParaNuevoRequerimiento _newReq = new Frm_ArticulosParaNuevoRequerimiento();
                                _newReq._itemReq = _articulos; //PASO EL OBJETO COMPLETO AL FORMULARIO QUE CREA EL REQUERIMIENOT
                                _newReq._OrdenCompra = _itemCab; //TAMBIEN PASO LA CABECERA DE LA OC PORQUE NECESITO ALGUNOS DATOS.. COMO SER EL SECTOR DE ENTREGA
                                _newReq.ShowDialog();
                            }

                        }


                    }
                    dataGridViewOCItem.Rows.Clear();
                    TraeOCPendientes();
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

        private void dataGridViewOCCab_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewOCCab.IsCurrentCellDirty)
                dataGridViewOCCab.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
       

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewOCCab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               if(e.ColumnIndex == Convert.ToUInt32(Col_OCCab.COMPLETA) || e.ColumnIndex == Convert.ToUInt32(Col_OCCab.ANULAR))
               {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.COMPLETA] as DataGridViewCheckBoxCell;
                    DataGridViewCheckBoxCell cellSelecionAnular = dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.ANULAR] as DataGridViewCheckBoxCell;
                    //NO PERMITE SELECCIONAR LOS DOS AL MISMO TIEMPO
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {

                        if (Convert.ToBoolean(cellSelecionAnular.Value))
                        {
                            cellSelecionAnular.Value = false;
                            cellSelecion.Value = false;

                        }

                    }


                    if (Convert.ToBoolean(cellSelecionAnular.Value))
                    {

                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            cellSelecionAnular.Value = false;
                            cellSelecion.Value = false;
                        }

                    }

                    //VERIFICO SI ESTA POR ANULAR LA OC, DE SER ASÍ SOLO LA PUEDE ANULAR EL QUE LA AUTORIZÓ
                    if (e.ColumnIndex == Convert.ToUInt32(Col_OCCab.ANULAR))
                    {
                        if(dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.USUARIO_AUTORIZA].Value.ToString().Trim() != Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString().Trim())
                        {
                            cellSelecionAnular.Value = false;
                            MessageBox.Show("Ud. no puede anular esta Orden de Compra, la debe anular la persona que la autorizó", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            
                        }
                        else
                        {
                            //ES EL USUARIO QUE LA AUTORIZO, VERIFICO QUE ESTA OC NO TENGA ALGUN INGRESO DE MERCADERIA
                            BLL.Tables.STKMOVIOC _oc = new BLL.Tables.STKMOVIOC();
                            int _nroOc = Convert.ToInt32(dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.NRO_OC].Value.ToString());
                            string _codEmp = dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.CODEMP].Value.ToString();
                            _oc.WhereParameter.Add(DAL.Tables.STKMOVIOC.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, _codEmp);
                            _oc.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, DAL.Tables.STKMOVIOC.ColumnEnum.ordenCompra_id, DAL.SqlEnums.OperandEnum.Equal, _nroOc);
                            if(_oc.Items().Count > 0)
                            {
                                cellSelecionAnular.Value = false;
                                MessageBox.Show("Esta Orden de Compra no se puede anular porque tiene al menos un ingreso de mercadería", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                    }


                    this.textBoxObs.Focus();
                    /// CONTROLO QUE NO TILDE MAS DE UNA O.C.
                    for (int i = 0; i < dataGridViewOCCab.Rows.Count-1; i++)
                    {
                        if (i != e.RowIndex)
                            dataGridViewOCCab.Rows[i].Cells[(int)Col_OCCab.COMPLETA].Value = 0;
                       

                    }
                   

                    //

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewOCItem_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewOCItem.IsCurrentCellDirty)
                dataGridViewOCItem.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion

        private void textBoxOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxOC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOCCab.Rows.Count > 0)
                {


                    string busqueda = this.textBoxOC.Text.Trim();
                    List<DataGridViewRow> rows = (from item in dataGridViewOCCab.Rows.Cast<DataGridViewRow>()
                                                  let descripcion = Convert.ToString(item.Cells[(int)Col_OCCab.NRO_OC].Value ?? string.Empty).ToLower()
                                                  where descripcion.Contains(busqueda.ToLower())
                                                  select item).ToList<DataGridViewRow>();

                    foreach (DataGridViewRow row in rows)
                    {
                        List<DataGridViewCell> cells = (from item in row.Cells.Cast<DataGridViewCell>()
                                                        let cell = Convert.ToString(item.Value).ToLower()
                                                        where cell.Contains(busqueda.ToLower())
                                                        select item).ToList<DataGridViewCell>();


                        row.Selected = true;
                        dataGridViewOCCab.Rows[row.Index].Cells[(int)Col_OCCab.NRO_OC].Selected = true;

                        break;

                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxOC_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && textBoxOC.Text != string.Empty )
            {
                StaCatalinaEntities _Mod = new StaCatalinaEntities();
                var _varObj = (from L in _Mod.ORDENCOMPRA_PENDIENTES_DE_ENTREGA_BUSCADOR(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim(), Convert.ToInt32(textBoxOC.Text))
                               select L).SingleOrDefault();

                this.dataGridViewOCCab.Rows.Clear();
                int indice = 0;

                if (_varObj == null)
                {
                    MessageBox.Show("Orden de Compra no encontrada, verifique si la misma no está anulada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {

                    indice = dataGridViewOCCab.Rows.Add();
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.CODEMP].Value = _varObj.codEmp;//CODIGO DE EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.EMPRESA].Value = _varObj.codEmp; //EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.NRO_OC].Value = _varObj.ordenCompra_id; //NRO OC
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.SECTORREQ].Value = _varObj.sectorRequerimiento_id; //SECTOR REQUERIMIENTO
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.ESTADO_ID].Value = _varObj.estado_id; //ESTADI ID
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.TIPOOC_ID].Value = _varObj.tipoOc_id; //TIPO DE OC
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.MODIFICACOSTO].Value = _varObj.modificaCosto; //MODIFICA COSTO
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.CONDPAGO_ID].Value = _varObj.condicionPago_id; //CONDICION PAGO ID
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.USUARIO].Value = _varObj.usuario; //USUARIO
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.USUARIO_AUTORIZA].Value = _varObj.usuarioAutoriza; //USUARIO AUTORIZA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.FECHA].Value = _varObj.fecha.ToShortDateString();//FECHA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.PROVEEDOR].Value = _varObj.RazonSocial;//PROVEEDOR
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.OBSERVACIONES].Value = _varObj.obs;//OBSERVACIONES
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.SECTOR_ENTREGA_ID].Value = _varObj.sectorEntrega_id;//SECTOR DE ENTREGA



                }

            }


        }
    }
}
