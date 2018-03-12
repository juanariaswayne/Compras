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
    public partial class Frm_ModificarOCAutorizada : StaCatalina.Plantilla
    {
        #region Variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;
            CultureInfo culture = new CultureInfo("en-US");
            int OC_ID=0;
            string _codEmp;
            string _usuarioQueAutorizo;
        private enum Col_OCCab
        {
            USUARIO_AUTORIZO=0,
            CODEMP,
            EMPRESA,
            NRO_OC,
            FECHA,
            PROVEEDOR,
            OBSERVACIONES,
            SECTORENTREGA_ID,
            PEDIDO_NO_PREVISTO

        }

        private enum Col_OCItem
        {
            CANT_ORIGINAL=0,
            PRECIO_ORIGINAL,
            NROITEM,
            ARTICULO,
            DESCRIPCION,
            UNIMED,
            EMBALAJE,
            MARCA,
            CANTIDAD,
            PRECIO

        }
        #endregion

        #region Funciones
        public Frm_ModificarOCAutorizada()
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
        //FIN PERMISOS

        private void TraeOCPendientes()
        {

            try
            {
                BLL.Procedures.ORDENCOMPRA_PARA_MODIFICAR _detalle = new BLL.Procedures.ORDENCOMPRA_PARA_MODIFICAR();
                
                this.dataGridViewOCCab.Rows.Clear();
                //FILTRO LAS OC DE LA EMPRESA LOGEADA Y ME DEVUELVE LAS ORDENES QUE ESTE USUARIO AUTORIZO
                var q = (dynamic)null;

                q = (from item in _detalle.ItemList(3) //  SI BIEN LE PASO SEGUN REQUE.. EL STORED ME TRAE TODAS LAS DE BIONEXO TAMBIEN 3 = OPRDEN DE COMPRA SEGUN REQUERIMIENTO
                     where item.codemp == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString() //&& item.tipooc_id == 3
                     select item);

                int indice;
                foreach (Entities.Procedures.ORDENCOMPRA_PARA_MODIFICAR item in q)
                {
                    indice = dataGridViewOCCab.Rows.Add();
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.EMPRESA].Value = item.codemp; //EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.NRO_OC].Value = item.ordencompra_id; //NRO OC
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.FECHA].Value = item.fecha.ToShortDateString();//FECHA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.PROVEEDOR].Value = item.razonsocial;//PROVEEDOR
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.OBSERVACIONES].Value = item.obs;//PROVEEDOR
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.USUARIO_AUTORIZO].Value = item.usuarioautoriza;//USUARIO QUE AUTORIZO
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.SECTORENTREGA_ID].Value = item.Sectorentrega_id;//sector de entrega
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.PEDIDO_NO_PREVISTO].Value = item.pedidodiario;//pedido No previsto (pedido diario)

                    dataGridViewOCCab.Rows[indice].DefaultCellStyle.BackColor = (item.pedidodiario) ? Color.YellowGreen : Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46) // Si no es numerico y si no es espacio EL 46 ES EL PUNTO
            {
                // Invalidar la accion
                e.Handled = true;
                // Enviar el sonido de beep de windows
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void  CargarItemsOC(int _index,int _nivelAutorizacion)
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
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.UNIMED].Value = item.unimed;//TRAE UNIMED
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.EMBALAJE].Value = item.embalaje; //EMBALAJE
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.MARCA].Value = item.marca; //MARCA
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.PRECIO].Value = item.precio.ToString().Replace(",", ".");//PRECIO
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.PRECIO_ORIGINAL].Value = item.precio.ToString().Replace(",", ".");//PRECIO ORIGINAL
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CANTIDAD].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD 
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CANT_ORIGINAL].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD ORIGINAL

                }
                OC_ID = Convert.ToInt32(dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.NRO_OC].Value); // Salvo Orden de compra ID
                _codEmp = dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.CODEMP].Value.ToString(); // Salvo el CODEMP
                //TRAIGO LAS OBSERVACIOENS EN EL TEXT.. POR SI LA QUIERE MODIFICAR

                this.textBoxObs.Text = dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.OBSERVACIONES].Value.ToString();
                this.comboBoxProveed.Text = dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.PROVEEDOR].Value.ToString();
                this.checkBoxdiaria.Checked = (Convert.ToInt32(dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.PEDIDO_NO_PREVISTO].Value) == 0) ? false : true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CargarProveedor(string _codEmp)
        {
            try
            {
                BLL.Procedures._H_PROVEEDORES _prov = new BLL.Procedures._H_PROVEEDORES();
                _prov.ItemList(_codEmp);
                Entities.Procedures._H_PROVEEDORES _itemSeleccion = new Entities.Procedures._H_PROVEEDORES();

                //Limpia el combo
                this.comboBoxProveed.SuspendLayout();
                this.comboBoxProveed.DataSource = null;
                this.comboBoxProveed.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.pro_razsoc = "<Seleccione un Proveedor>";
                _itemSeleccion.pro_cod = "0";
                _prov.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxProveed.DisplayMember = BLL.Procedures._H_PROVEEDORES.ColumnNames.PRO_RAZSOC;
                this.comboBoxProveed.ValueMember = BLL.Procedures._H_PROVEEDORES.ColumnNames.PRO_COD;
                this.comboBoxProveed.DataSource = _prov.Result.ToArray();

                this.comboBoxProveed.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #endregion

        private void Frm_ModificarOCAutorizada_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //FIN PERMISOS
            this.Text = "Modificación Orden de Compra según Requerimientos Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();

            TraeOCPendientes();                
            CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);

        }

        private void dataGridViewOCCab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    BLL.Procedures.TRAEORDENCOMPRAITEM _item = new BLL.Procedures.TRAEORDENCOMPRAITEM();

            //    this.dataGridViewOCItem.Rows.Clear();
            //    int indice;
            //    //TRAIGO LOS ITEMS QUE SOLO ESTÁN AUTORIZADAS
            //    foreach (Entities.Procedures.TRAEORDENCOMPRAITEM item in _item.ItemList(dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.NRO_OC].Value), 2))
            //    {
            //        indice = dataGridViewOCItem.Rows.Add();
            //        dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.ARTICULO].Value = item.articulo_id;//ARTICULO
            //        dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.NROITEM].Value = item.nroitem; //ITEM OC
            //        dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.DESCRIPCION].Value = item.art_descgen.ToString();//DESCRIP ARTICULO
            //        dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.UNIMED].Value = item.unimed;//TRAE UNIMED
            //        dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.EMBALAJE].Value = item.embalaje; //EMBALAJE
            //        dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.MARCA].Value = item.marca; //MARCA
            //        dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.PRECIO].Value = item.precio.ToString().Replace(",", ".");//PRECIO
            //        dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.PRECIO_ORIGINAL].Value = item.precio.ToString().Replace(",", ".");//PRECIO ORIGINAL
            //        dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CANTIDAD].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD 
            //        dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CANT_ORIGINAL].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD ORIGINAL

            //    }
            //    OC_ID = Convert.ToInt32(dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.NRO_OC].Value); // Salvo Orden de compra ID
            //    _codEmp = dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.CODEMP].Value.ToString(); // Salvo el CODEMP
            //    //TRAIGO LAS OBSERVACIOENS EN EL TEXT.. POR SI LA QUIERE MODIFICAR
            //    if(dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.USUARIO_AUTORIZO].Value != null)
            //    {
            //        _usuarioQueAutorizo = dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.USUARIO_AUTORIZO].Value.ToString(); //SALVO EL USUARIO QUE AUTORIZO
            //    }
            //    else
            //    {
            //        _usuarioQueAutorizo = string.Empty; //SALVO EL USUARIO QUE AUTORIZO
            //    }
               
            //    this.textBoxObs.Text = dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.OBSERVACIONES].Value.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void dataGridViewOCItem_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewOCItem.IsCurrentCellDirty)
                this.dataGridViewOCItem.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewOCItem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewOCItem.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_OCItem.CANTIDAD || iColumn == (int)Col_OCItem.PRECIO)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {

            try
            {
                BLL.Tables.COMORDENCOMPRAITEM _modifOCItem = new BLL.Tables.COMORDENCOMPRAITEM();
                Entities.Tables.COMORDENCOMPRAITEM _item = new Entities.Tables.COMORDENCOMPRAITEM();
                List<Entities.Tables.COMORDENCOMPRAITEM> newItemList = new List<Entities.Tables.COMORDENCOMPRAITEM>();
                string _obs;
                _obs = this.textBoxObs.Text;
                string _Proveed = (this.comboBoxProveed.SelectedValue == null) ? "0": this.comboBoxProveed.SelectedValue.ToString();
                bool _pedidoNoPrevisto = (this.checkBoxdiaria.Checked) ? true : false;
                int _sectorEntrega = 0; //NO LO USO PORQUE EL SECTOR VIENE DADO POR EL REQUERIMIENTO

                if (this.comboBoxProveed.SelectedIndex <= 0 || _Proveed == "0")
                {
                    MessageBox.Show("Debe seleccionar un Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < this.dataGridViewOCItem.Rows.Count; i++)
                {
                    _item = new Entities.Tables.COMORDENCOMPRAITEM();

                    _item.CANTIDAD = Convert.ToDecimal(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.CANTIDAD].Value.ToString(), culture);
                    _item.CANTIDADORIGINAL = Convert.ToDecimal(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.CANT_ORIGINAL].Value.ToString(), culture);
                    _item.PRECIO = Convert.ToDecimal(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.PRECIO].Value.ToString(), culture);
                    _item.PRECIOORIGINAL = Convert.ToDecimal(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.PRECIO_ORIGINAL].Value.ToString(), culture);
                    _item.EMBALAJE = (dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.EMBALAJE].Value == null)? string.Empty: dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.EMBALAJE].Value.ToString();
                    _item.MARCA = (dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.MARCA].Value == null) ? string.Empty: dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.MARCA].Value.ToString();
                    _item.NROITEM = Convert.ToInt32(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.NROITEM].Value.ToString());
                    newItemList.Add(_item);
                }

                if(_modifOCItem.ActualizaOcItemAutorizada(_codEmp, OC_ID, newItemList, _obs,_Proveed,_pedidoNoPrevisto, _sectorEntrega))
                               
                {
                    MessageBox.Show("Los cambios se realizaron correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewOCItem.Rows.Clear();
                    this.textBoxObs.Text = string.Empty;
                    this.comboBoxProveed.SelectedIndex = 0;
                    TraeOCPendientes();
                }
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

        private void dataGridViewOCCab_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewOCCab.IsCurrentCellDirty)
                this.dataGridViewOCCab.CommitEdit(DataGridViewDataErrorContexts.Commit);
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

                    if (_usuarioQueAutorizo.Trim() != string.Empty )
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
                            MessageBox.Show("Usted no puede modificar esta Orden de Compra, porque la misma está autorizada, solo puede modifcarla el usuario: " + _usuarioQueAutorizo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
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
            //if (e.KeyCode == Keys.Enter)
            //{
            //    string busqueda = this.textBoxOC.Text.Trim();
            //    List<DataGridViewRow> rows = (from item in dataGridViewOCCab.Rows.Cast<DataGridViewRow>()
            //                                  let descripcion = Convert.ToString(item.Cells[(int)Col_OCCab.NRO_OC].Value ?? string.Empty).ToLower()
            //                                  where descripcion.Contains(busqueda.ToLower())
            //                                  select item).ToList<DataGridViewRow>();

            //    foreach (DataGridViewRow row in rows)
            //    {
            //        List<DataGridViewCell> cells = (from item in row.Cells.Cast<DataGridViewCell>()
            //                                        let cell = Convert.ToString(item.Value).ToLower()
            //                                        where cell.Contains(busqueda.ToLower())
            //                                        select item).ToList<DataGridViewCell>();


            //        row.Selected = true;
            //        dataGridViewOCCab.Rows[row.Index].Cells[(int)Col_OCCab.NRO_OC].Selected = true;

            //        break;

            //    }

            //}
        }

        private void textBoxOC_TextChanged(object sender, EventArgs e)
        {
            try
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
    }
}
