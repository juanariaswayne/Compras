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
    public partial class Frm_ExcluirItemsOC : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        string _usuarioQueAutorizo;
        int OC_ID = 0;
        string _codEmp;
        private enum Col_OCCab
        {
            USUARIO_AUTORIZO = 0,
            CODEMP,
            EMPRESA,
            NRO_OC,
            FECHA,
            PROVEEDOR,
            OBSERVACIONES

        }

        private enum Col_OCItem
        {
            EXCLUIDO,
            NROITEM,
            ARTICULO,
            DESCRIPCION,
            UNIMED,
            MOTIVO

        }
        #endregion
        #region Funciones
        public Frm_ExcluirItemsOC()
        {
            InitializeComponent();
        }
        //PERMISOS
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

        private void TraeOCPendientes(DateTime _fechaDesde, DateTime _fechaHasta)
        {

            try
            {
                BLL.Procedures.ORDENCOMPRA_PARA_MODIFICAR_FECHA _detalle = new BLL.Procedures.ORDENCOMPRA_PARA_MODIFICAR_FECHA();

                this.dataGridViewOCCab.Rows.Clear();
                //FILTRO LAS OC DE LA EMPRESA LOGEADA Y ME DEVUELVE LAS ORDENES QUE ESTE USUARIO AUTORIZO
                var q = (dynamic)null;

                q = (from item in _detalle.ItemList(_fechaDesde, _fechaHasta) //  SI BIEN LE PASO SEGUN REQUE.. EL STORED ME TRAE TODAS LAS DE BIONEXO TAMBIEN 3 = OPRDEN DE COMPRA SEGUN REQUERIMIENTO
                     where item.codemp == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString()
                     select item);

                int indice;
                foreach (Entities.Procedures.ORDENCOMPRA_PARA_MODIFICAR_FECHA item in q)
                {
                    indice = dataGridViewOCCab.Rows.Add();
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.EMPRESA].Value = item.codemp; //EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.NRO_OC].Value = item.ordencompra_id; //NRO OC
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.FECHA].Value = item.fecha.ToShortDateString();//FECHA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.PROVEEDOR].Value = item.razonsocial;//PROVEEDOR
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.OBSERVACIONES].Value = item.obs;//PROVEEDOR
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.USUARIO_AUTORIZO].Value = item.usuarioautoriza;//USUARIO QUE AUTORIZO
                    dataGridViewOCCab.Rows[indice].DefaultCellStyle.BackColor = (item.pedidodiario) ? Color.YellowGreen : Color.White;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarItemsOC(int _index, int _nivelAutorizacion)
        {
            try
            {
                BLL.Procedures.TRAEORDENCOMPRAITEM _item = new BLL.Procedures.TRAEORDENCOMPRAITEM();

                this.dataGridViewOCItem.Rows.Clear();
                int indice;
                //TRAIGO LOS ITEMS QUE SOLO ESTÁN AUTORIZADAS
                foreach (Entities.Procedures.TRAEORDENCOMPRAITEM item in _item.ItemList(dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.NRO_OC].Value), _nivelAutorizacion))
                {
                    indice = dataGridViewOCItem.Rows.Add();
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.ARTICULO].Value = item.articulo_id;//ARTICULO
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.NROITEM].Value = item.nroitem; //ITEM OC
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.DESCRIPCION].Value = item.art_descgen.ToString();//DESCRIP ARTICULO
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.UNIMED].Value = item.unimed.ToString();//DESCRIP ARTICULO
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.EXCLUIDO].Value = item.excluido;//excluido
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.MOTIVO].Value = item.motivoexclusion;//excluido

                }
                OC_ID = Convert.ToInt32(dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.NRO_OC].Value); // Salvo Orden de compra ID
                _codEmp = dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.CODEMP].Value.ToString(); // Salvo el CODEMP


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion
        //FIN PERMISOS
        #region Eventos

        private void Frm_ExcluirItemsOC_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            //FIN PERMISOS
            this.dateTimeDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.dateTimeHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            this.Text = "Excluir Artículos de Orden de Compra, Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();

            TraeOCPendientes(Convert.ToDateTime(this.dateTimeDesde.Value.ToString("yyyy-MM-dd 00:00:00")), Convert.ToDateTime(this.dateTimeHasta.Value.ToString("yyyy-MM-dd 23:59:59")));
        }



        private void dataGridViewOCItem_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewOCItem.IsCurrentCellDirty)
                this.dataGridViewOCItem.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewOCCab_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewOCCab.IsCurrentCellDirty)
                this.dataGridViewOCCab.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion

        private void dataGridViewOCItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimeHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TraeOCPendientes(Convert.ToDateTime(this.dateTimeDesde.Value.ToString("yyyy-MM-dd 00:00:00")), Convert.ToDateTime(this.dateTimeHasta.Value.ToString("yyyy-MM-dd 23:59:59")));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TraeOCPendientes(Convert.ToDateTime(this.dateTimeDesde.Value.ToString("yyyy-MM-dd 00:00:00")), Convert.ToDateTime(this.dateTimeHasta.Value.ToString("yyyy-MM-dd 23:59:59")));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewOCCab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    //VERIFICO SI ESTA OC ESTA AUTORIZADA, DE SER ASÍ SOLO EL USUARIO QUE LA AUTORIZO LA PUEDE MODIFICAR
                    if (dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.USUARIO_AUTORIZO].Value != null)
                    {
                        _usuarioQueAutorizo = dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.USUARIO_AUTORIZO].Value.ToString(); //SALVO EL USUARIO QUE AUTORIZO
                    }
                    else
                    {
                        _usuarioQueAutorizo = string.Empty; //SALVO EL USUARIO QUE AUTORIZO
                    }

                    int _nivelAutorizacion;

                    if (_usuarioQueAutorizo.Trim() == string.Empty)
                    {
                        _nivelAutorizacion = 1; //NO ESTA AUTORIZADO
                        CargarItemsOC(e.RowIndex, _nivelAutorizacion); //ESTA OC NO ESTA AUTORIZADA. LA PUEDE MODIFICAR EL USUARIO CON PERMISOS
                        return;
                    }

                    if (_usuarioQueAutorizo.Trim() != string.Empty)
                    {
                        if (_usuarioQueAutorizo.Trim().ToUpper() == Clases.Usuario.UsuarioLogeado.usuario_Logeado.Trim().ToUpper())
                        {
                            _nivelAutorizacion = 2; //ESTA AUTORIZADO
                            CargarItemsOC(e.RowIndex, _nivelAutorizacion); //ESTA OC NO ESTA AUTORIZADA. LA PUEDE MODIFICAR PORQUE EL USARIO LOGRADO ES EL MISMO QUE AUTORIZÓ
                            return;
                        }
                        else
                        {
                            this.dataGridViewOCItem.Rows.Clear();
                            MessageBox.Show("Usted no puede Excluir items de esta Orden de Compra, porque la misma está autorizada, solo puede hacerlo el usuario: " + _usuarioQueAutorizo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
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

                int _cantidaditems = this.dataGridViewOCItem.Rows.Count;
                int _cantExcluidos = 0;
                bool _excluyoAlMenosUno = false;
                Entities.Tables.COMORDENCOMPRAITEM _item = new Entities.Tables.COMORDENCOMPRAITEM();
                List<Entities.Tables.COMORDENCOMPRAITEM> _Items = new List<Entities.Tables.COMORDENCOMPRAITEM>();
                BLL.Procedures.EXCLUYEITEMSOC _excluye = new BLL.Procedures.EXCLUYEITEMSOC();

                for (int i = 0; i < this.dataGridViewOCItem.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.EXCLUIDO] as DataGridViewCheckBoxCell;

                    _item = new Entities.Tables.COMORDENCOMPRAITEM();
                    _item.CODEMP = _codEmp;
                    _item.ORDENCOMPRA_ID = OC_ID;
                    _item.NROITEM = Convert.ToInt32(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.NROITEM].Value);
                    if (dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.MOTIVO].Value == null)
                    {
                        _item.MOTIVOEXCLUSION = "";
                    }
                    else
                    {
                        _item.MOTIVOEXCLUSION = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.MOTIVO].Value.ToString().ToUpper();
                    }
                    _item.USUARIOEXCLUYE = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();

                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _item.EXCLUIDO = true;
                        _cantExcluidos++;
                        _Items.Add(_item);
                        _excluyoAlMenosUno = true;
                    }
                    else  //ESTO PORQUE PUEDE VOLVER A TRAS UN ARTICULO EXLUIDO... ES DECIR LO PUEDO INCLUR DE NUEVO
                    {
                        _item.EXCLUIDO = false;
                        _item.MOTIVOEXCLUSION = "";
                        _item.USUARIOEXCLUYE = "";
                        _Items.Add(_item);
                       
                    }

                }

                if (_Items.Count > 0)
                {
                    if (_cantExcluidos == _cantidaditems)
                    {
                        MessageBox.Show("No se puede excluir la totalidad de Items de la O.C.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        _excluye.ExcluyeItem(_Items);
                    }
                }
                //ACA PREGUNTAR SI SE HACE UN REQUERIMIENTO NUEVO


                if (_excluyoAlMenosUno)
                {
                  
                        // ****** PREGUNTO SI QUIERE VOLVER A GENERAR NUEVOS REQ
                        BLL.Tables.COMREQUERIMIENTO _genera = new BLL.Tables.COMREQUERIMIENTO();
                        DialogResult _result = MessageBox.Show("Desea generar un nuevo requerimiento para la orden de compra: " + _Items.First().ORDENCOMPRA_ID + " ?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (_result == System.Windows.Forms.DialogResult.OK)
                        {
                                
                              if (_genera.GeneraNuevosRequerimientos(_codEmp, OC_ID, "EXC"))//Fuerzo el tipo EXC porque estoy excluyendo items y genero un nuevo Requerimiento
                                    MessageBox.Show("Requerimiento generado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          
                        }  // ***** FIN GENERA NUEVOS REQ
                        else // no quiere generar un nuevo req
                        {
                            MessageBox.Show("Items excluidos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        dataGridViewOCItem.Rows.Clear();
                        OC_ID = 0;
                        _codEmp = string.Empty;
                    
                }
                else
                {
                    MessageBox.Show("Items incluidos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
            if (e.KeyCode == Keys.Enter && textBoxOC.Text != string.Empty)
            {

                StaCatalinaEntities _Mod = new StaCatalinaEntities();
                var _varObj = (from L in _Mod.ORDENCOMPRA_PARA_MODIFICAR_FECHA_BUSCADOR(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim(), Convert.ToInt32(textBoxOC.Text))
                               select L).SingleOrDefault();

                this.dataGridViewOCCab.Rows.Clear();
                int indice = 0;

                if (_varObj == null)
                {
                    MessageBox.Show("Orden de Compra no disponible para Excluir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {

                    indice = dataGridViewOCCab.Rows.Add();
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.CODEMP].Value = _varObj.codEmp;//CODIGO DE EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.EMPRESA].Value = _varObj.codEmp; //EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.NRO_OC].Value = _varObj.ordenCompra_id; //NRO OC
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.FECHA].Value = _varObj.fecha.ToShortDateString();//FECHA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.PROVEEDOR].Value = _varObj.RazonSocial;//PROVEEDOR
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.OBSERVACIONES].Value = _varObj.obs;//PROVEEDOR
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.USUARIO_AUTORIZO].Value = _varObj.usuarioAutoriza;//USUARIO QUE AUTORIZO
                    dataGridViewOCCab.Rows[indice].DefaultCellStyle.BackColor = (Convert.ToBoolean(_varObj.pedidoDiario)) ? Color.YellowGreen : Color.White;



                }

            }
        }
    }
}
