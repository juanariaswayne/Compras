using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using System.Globalization;
using StaCatalina.Clases;

namespace StaCatalina.Forms
{
    public partial class Frm_IngresoStockSegunOC : Plantilla
    {
        #region Var
            private enum Col_OCCabecera
            {
                CODEMP = 0,
                ORDENCOMPRA_ID,
                FECHA,
                PROVEED_ID,
                OBS
            }
            private enum Col_DetalleOC
            {
                CODIGO=0,
                NROITEM,
                DESCRIPCION,
                UNIMED,
                CANT_ORIGINAL,
                CANT_ADEUDADA,
                CANT_RECIBIDA,
                GENERA_ETIQUETA,
                CANT_ETIQUETAS,
                UNIBULTO,
                PORCTOLERANCIA,
                LLEVA_VENCIMIENTO,
                VTOS
            }
            //Int32 _indexRow;
            private enum eTiposCodigo
            {
                Codabar = 0,
                Ean13,
                Ean13Nochecksum,
                Code39,
                Code128,
                PDF417,
                Datamatrix
            }
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;
            //VARIABLE PARA PASAR CON ENTER A OTRA COLUMNA
            private DataGridViewCell _celWasEndEdit;
            CultureInfo culture = new CultureInfo("en-US");
            private List<Entities.Tables.STKVENCIMIENTO> _ArtsVtos = new List<Entities.Tables.STKVENCIMIENTO>();
        //2|0MCD164|0000001|Partida
        //- Primero se imprime un 2, fijo.
        //- Código de barras del artículo, 7 caracteres. En caso de no alcanzar los 7 caracteres se completa con ceros a la izquierda.
        //- Cantidad, 7 caracteres. Se completa con ceros a la izquierda hasta completar los 7 caracteres.
        //- Partida. No tiene una cantidad de caracteres fija, sale la partida del artículo, independientemente de la cantidad de caracteres que tenga el mismo.


        #endregion

        #region GridBotton
        public class DataGridViewDisableButtonCell : DataGridViewButtonCell
        {
            private bool enabledValue;
            public bool Enabled
            {
                get
                {
                    return enabledValue;
                }
                set
                {
                    enabledValue = value;
                }
            }
        }
        public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
        {
            public DataGridViewDisableButtonColumn()
            {
                this.CellTemplate = new DataGridViewDisableButtonCell();
            }
        }
   
        #endregion

        #region Function
        private void OperacionesDelUsuario()
            {
                try
                {
                    if (!escritura) { this.toolStripButtonPrint.Enabled = false; }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        public Frm_IngresoStockSegunOC()
            {
                InitializeComponent();
            }
 

        private void CargarProveedores(string codEmp)
            {
                try
                {
                    BLL.Procedures._H_PROVEEDORES _prov = new BLL.Procedures._H_PROVEEDORES();
                    _prov.ItemList(codEmp);
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

            private void TraerOrdenCompraDisponibles(string _proveed)
            {

                try
                {
                    BLL.Procedures.ORDENCOMPRA_DISPONIBLES_PROVEEDOR _OCDisp = new BLL.Procedures.ORDENCOMPRA_DISPONIBLES_PROVEEDOR();
                    string _codEmp = (comboBoxcodEmp.SelectedIndex == 0) ? "EGES" : "RSC"; 
                    this.bindingSourceFacturas.DataSource = null;
                    this.bindingSourceFacturas.Clear();
                    this.bindingSourceFacturas.DataSource = _OCDisp.ItemList(_proveed, _codEmp);
                    this.dataGridViewDetalle.Rows.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            private void TraerDetalleOC(string _codEmp,int _ordenCompra_id,int _nivel_aut)
            {
                try
                {
                    BLL.Procedures.TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR _detalle = new BLL.Procedures.TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR();
                    this.dataGridViewDetalle.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.TRAEORDENCOMPRAITEM_PENDIENTE_DE_ENTREGAR item in _detalle.ItemList(_codEmp, _ordenCompra_id, _nivel_aut))
                    {
                        indice = dataGridViewDetalle.Rows.Add();
                        dataGridViewDetalle.Rows[indice].Cells[(int)Col_DetalleOC.CODIGO].Value = item.articulo_id;//CODIGO PRODUCTO
                        dataGridViewDetalle.Rows[indice].Cells[(int)Col_DetalleOC.NROITEM].Value = item.nroitem; //NRO ITEM
                        dataGridViewDetalle.Rows[indice].Cells[(int)Col_DetalleOC.DESCRIPCION].Value = item.art_descgen; //DESCRIPCION PRODUCTO
                        dataGridViewDetalle.Rows[indice].Cells[(int)Col_DetalleOC.UNIMED].Value = item.unimed;//UNIDAD DE MEDIDA
                        dataGridViewDetalle.Rows[indice].Cells[(int)Col_DetalleOC.CANT_ORIGINAL].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD PEDIDA
                        dataGridViewDetalle.Rows[indice].Cells[(int)Col_DetalleOC.CANT_ADEUDADA].Value = item.cantidadadeudada.ToString().Replace(",", ".");//CANTIDAD ADEUDADA
                        dataGridViewDetalle.Rows[indice].Cells[(int)Col_DetalleOC.PORCTOLERANCIA].Value = item.porctoleranciareposicion.ToString().Replace(",", ".");//PORCENTAJE DE TOLERANCIA PARA RECEPCIÓN
                        dataGridViewDetalle.Rows[indice].Cells[(int)Col_DetalleOC.LLEVA_VENCIMIENTO].Value = item.llevavencimiento;//LLEVA VENCIMIENTO
                        if (Convert.ToBoolean(dataGridViewDetalle.Rows[indice].Cells[(int)Col_DetalleOC.LLEVA_VENCIMIENTO].Value))
                        {
                            DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)dataGridViewDetalle.Rows[indice].Cells[(int)Col_DetalleOC.VTOS];
                            //HABILITRO LA CELDA... LE CAMBIO EL VALOR A TRUE
                            buttonCell.Enabled = true;
                        }
                    }
                        labelNumeroFactura.Text = _ordenCompra_id.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        
            private void CargarDepositos()
            {
                try
                {
                    string _codEmp = (this.comboBoxcodEmp.SelectedIndex == 0) ? "EGES" : "RSC";
                    BLL.Tables.STKDEPOSITO _dep = new BLL.Tables.STKDEPOSITO();
                    _dep.WhereParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, _codEmp);
                    _dep.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.OR, DAL.Tables.STKDEPOSITO.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, "AMBA");//TAMBIEN TRAIGO LA EMPRESA AMBA
                    _dep.OrderByParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.descripcion);
                    _dep.ItemList();
                    Entities.Tables.STKDEPOSITO _itemSeleccion = new Entities.Tables.STKDEPOSITO();

                    //Limpia el combo
                    this.comboBoxDeposito.SuspendLayout();
                    this.comboBoxDeposito.DataSource = null;
                    this.comboBoxDeposito.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.DESCRIPCION = "<Seleccione un Depósito>";
                    _itemSeleccion.DEPOSITO_ID = 0;
                    _dep.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxDeposito.DisplayMember = BLL.Tables.STKDEPOSITO.ColumnNames.DESCRIPCION;
                    this.comboBoxDeposito.ValueMember = BLL.Tables.STKDEPOSITO.ColumnNames.DEPOSITO_ID;
                    this.comboBoxDeposito.DataSource = _dep.Result.ToArray();

                    this.comboBoxDeposito.ResumeLayout();
                    
                 //SETEO EL DEPOSITO MERCADO CENTRAL ////
                 if (Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToUpper().ToString().Trim() == "DEPOSITO")
                {
                    this.comboBoxDeposito.SelectedValue =  1;

                }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

            private void CargarSectoresDeposito(string _codEmp, int _dep)
            {
                try
                {
                    BLL.Tables.STKSECTOR _sec = new BLL.Tables.STKSECTOR();
                    _sec.OrderByParameter.Add(DAL.Tables.STKSECTOR.ColumnEnum.descripcion);
                    _sec.ItemList(_codEmp, _dep);

                    Entities.Tables.STKSECTOR _itemSeleccion = new Entities.Tables.STKSECTOR();

                    //Limpia el combo
                    this.comboBoxSector.SuspendLayout();
                    this.comboBoxSector.DataSource = null;
                    this.comboBoxSector.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.DESCRIPCION = "<Seleccione un Sector>";
                    _itemSeleccion.SECTOR_ID = 0;
                    _sec.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxSector.DisplayMember = BLL.Tables.STKSECTOR.ColumnNames.DESCRIPCION;
                    this.comboBoxSector.ValueMember = BLL.Tables.STKSECTOR.ColumnNames.SECTOR_ID;
                    this.comboBoxSector.DataSource = _sec.Result.ToArray();

                    this.comboBoxSector.ResumeLayout();

                    //SETEO EL DEPOSITO SEGUN LA EMPRESA ////
                    if (Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToUpper().ToString().Trim() == "DEPOSITO")
                    {
                        this.comboBoxSector.SelectedValue = (_codEmp == "EGES") ? 1 : 0;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

            private bool VerificaIngreso()
            {
                try
                {
                    if (this.comboBoxProveed.SelectedIndex == 0)
                    {
                        this.errorProvider1.SetError(this.comboBoxProveed, "Debe seleccionar un Proveedor");
                        this.comboBoxProveed.Focus();
                        return false;
                    }

                    if (this.comboBoxDeposito.SelectedIndex == 0)
                    {
                        this.errorProvider1.SetError(this.comboBoxDeposito, "Debe seleccionar un Depóstio");
                        this.comboBoxDeposito.Focus();
                        return false;
                    }

                    //if (this.comboBoxSector.SelectedIndex == 0)
                    //{
                    //    this.errorProvider1.SetError(this.comboBoxSector, "Debe seleccionar un Sector");
                    //    this.comboBoxSector.Focus();
                    //    return false;
                    //}

             
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


            }

        private void ImprimirEtiquetas()
        {
            try
            {
                
                // solo imprimo etiquetas, si tiene tilde en Genera Etiqueta
                Int32 _cantidad;
                string _codProd;
                Bitmap bm = null;
                char pad = '0';
                string _texto;
                string _descripProd;
                string _uniBulto;

                for (int i = 0; i < this.dataGridViewDetalle.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.GENERA_ETIQUETA] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {

                        if (dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value != null && dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value.ToString() != string.Empty && dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value.ToString() != "0")
                        {
                           
                            _codProd = dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CODIGO].Value.ToString().Trim(); //CODIGO PRODUCTO
                            _cantidad = Convert.ToInt32(dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CANT_ETIQUETAS].Value.ToString()); //CANT DE ETIQUETAS A IMPRIMIR 
                            _descripProd = dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.DESCRIPCION].Value.ToString();//DESCRIPCION DEL PRODUCTO
                            //UNIDADES POR BULTO, ES LA CANTIDAD QUE SE DARA DE BAJA CUNADO SE LEE ESTA ETIQUETA
                            _uniBulto = (dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.UNIBULTO].Value == null) ? dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value.ToString(): dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.UNIBULTO].Value.ToString(); 
                            _texto = _codProd.PadLeft(7, pad) + _uniBulto.PadLeft(7, pad);

                            //bm = BarCode.BarCode.Code128(_texto, (int)BarCode.BarCode.Code128SubTypes.CODE128_UCC, true, 50);
                            //if (bm != null)
                            //{
                            //    pictureBox1.Image = bm;

                                //pictureBox1.Image.Save("\\\\192.168.5.10\\Bejerman\\compartida\\Reporting\\Santa Catalina\\codbar.Bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                Imprime(_cantidad, _descripProd,_texto);

                            //}
                           
                        }
                    }
                }

            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion
        
        #region Eventos
            private void IngresoDetalleFacturas_Load(object sender, EventArgs e)
            {
                //this.dateTimeDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                //this.dateTimeHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();

                comboBox1.Items.Add(BarCode.BarCode.Code128SubTypes.CODE128_UCC);
                comboBox1.SelectedIndex = comboBox1.FindString("CODE128");

                //SETEO LA EMPRESA

                if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                {
                    this.comboBoxcodEmp.SelectedIndex = 0;
                    CargarProveedores("EGES");
                   
                }

                else
                {
                    this.comboBoxcodEmp.SelectedIndex = 1;
                    CargarProveedores("RSC");
                    
                }

                //carga los depósitos
                CargarDepositos();

            //CREO LA COLUMNA DE TIPO BUTTON
            DataGridViewDisableButtonColumn column = new DataGridViewDisableButtonColumn();
            column.Name = "Fvto";
            column.HeaderText = "Fecha Vtos.";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            dataGridViewDetalle.Columns.Insert((int)Col_DetalleOC.VTOS, column);
           
            //FIN CREAR COLUMNA

            }

            private void comboBoxProveed_SelectedIndexChanged(object sender, EventArgs e)
            {
                //TRAE LAS FACTURAS DISPONIBLES DE ESTE PROVEEDOR
                if (this.comboBoxProveed.SelectedIndex > 0)
                {
                    TraerOrdenCompraDisponibles(this.comboBoxProveed.SelectedValue.ToString());
                    this.dataGridView1.ClearSelection();
                }

            }


            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        //_indexRow = e.RowIndex; //GUARDO LA FILA SELECCIONADA
                        TraerDetalleOC(dataGridView1.Rows[e.RowIndex].Cells[(int)Col_OCCabecera.CODEMP].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[(int)Col_OCCabecera.ORDENCOMPRA_ID].Value.ToString()),2);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            //CONTROLO ELINGRESO DE SOLO NUMERO
            private void dataGridViewDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
            {
                int iColumn = dataGridViewDetalle.CurrentCell.ColumnIndex;
                if (iColumn == (int)Col_DetalleOC.CANT_RECIBIDA)
                {
                    TextBox txt = e.Control as TextBox;
                    txt.KeyPress += OnlyNumbers_KeyPress;
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

            private void toolStripButtonPrint_Click(object sender, EventArgs e)
            {
                
                try
                {
                    if (VerificaIngreso())
                    {
                        //OBJETOS STKINVENTARIO
                        Entities.Tables.STKINVENTARIO _itemInventario = new Entities.Tables.STKINVENTARIO();
                        List<Entities.Tables.STKINVENTARIO> _itemsInv = new List<Entities.Tables.STKINVENTARIO>();

                        //OBJETOS STKMOVIMIENTOSITEM
                        Entities.Tables.STKMOVIMIENTOITEM _itemMov = new Entities.Tables.STKMOVIMIENTOITEM();
                        List<Entities.Tables.STKMOVIMIENTOITEM> _itemsMov = new List<Entities.Tables.STKMOVIMIENTOITEM>();

                        //VARIABLES STKMOVIMIENTOS
                        Entities.Tables.STKMOVIMIENTO _itemMovimiento = new Entities.Tables.STKMOVIMIENTO();
                        BLL.Tables.STKMOVIMIENTO _stk = new BLL.Tables.STKMOVIMIENTO();

                        CultureInfo culture = new CultureInfo("en-US");
                        Boolean _selecciono = false;
                        //LA EMPRESA LA RECUPERO DEL DEPOSITO QUE SELECCIONO, CON EL DEPOSITO_ID BUSCO LA EMPRESA DE ESTE DEPOSTIO EN UNA LISTA 
                        //int _deposito_id = Convert.ToInt32(comboBoxDeposito.SelectedValue);
                        //string _codEmpresa = _itemsDepositos.Find(x => x.DEPOSITO_ID == _deposito_id).CODEMP.ToString();
                        //FIN RECUPERA DEPOSITO
                       
                        for (int i = 0; i < this.dataGridViewDetalle.Rows.Count ; i++)
                        {
                            //SOLO INGRESO LOS ARTICULOS QUE SE RECIBEN
                            if (dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value != null && dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value.ToString() != string.Empty && dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value.ToString() != "0")
                            {
                                _itemInventario = new Entities.Tables.STKINVENTARIO();
                                _itemInventario.ARTICULO_ID = dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CODIGO].Value.ToString();//COD ARTICULO
                                _itemInventario.CANTIDAD = Convert.ToDecimal(dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value.ToString(), culture); //cantidad
                                _itemInventario.DEPOSITO_ID = Convert.ToInt32(this.comboBoxDeposito.SelectedValue);//DEPOSITO
                                _itemInventario.SECTOR_ID = 1; //SECTOR NO SE UTILIZA... SIEMPRE ENVIO UNO... NO SE LLEVA EL STOCK POR SECTOR
                                _itemInventario.UNIMED = dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.UNIMED].Value.ToString();//UNIDAD MEDIDA
                                //VOY AGREGANDO A LA COLECCION
                                _itemsInv.Add(_itemInventario);

                                //AHORA CARGO EL OBJETO STKMOVIMIENTOITEM
                                _itemMov = new Entities.Tables.STKMOVIMIENTOITEM();
                                _itemMov.ARTICULO_ID = dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CODIGO].Value.ToString();//COD ARTICULO
                                _itemMov.CANTIDAD = Convert.ToDecimal(dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value.ToString(), culture); //cantidad
                                _itemMov.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(); //EL MOVIMIENTO SE REGISTRA CON LA EMPRESA INGRESADA
                                _itemMov.UNIMED = dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.UNIMED].Value.ToString();//UNIDAD MEDIDA
                                _itemMov.NROITEM = Convert.ToInt32( dataGridViewDetalle.Rows[i].Cells[(int)Col_DetalleOC.NROITEM].Value.ToString());//NRO ITEM DE LA ORDEN DE COMPRA, LO NECESITO PARA LA TABLA STKMOVIOC
                                //VOY AGREGANDO A LA COLECCION
                                _itemsMov.Add(_itemMov);

                                _selecciono = true;
                            }

                        }

                        if (_selecciono)
                        {
                            //CARGO LOS OBJETOS DE STKMOVIMIENTOS
                            _itemMovimiento.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(); //EL MOVIMIENTO SE REGISTRA CON LA EMPRESA INGRESADA
                            _itemMovimiento.ANULADO = 0;
                            _itemMovimiento.FECHAMOV = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            _itemMovimiento.TIPOMOV_ID = 1; //OJO VER ESTO SI SE PUEDE CAMBIAR...... EL 1 ES ENTRADA
                            _itemMovimiento.SUBTIPOMOV_ID = 4; //ojo ver SI SE PUEDE CAMBIAR...... EL 1 ES INGRESO DE STOCK POR ORDEN DE COMPRA
                            _itemMovimiento.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();
                            _itemMovimiento.OBS = "";
                            _itemMovimiento.DEPOSITOORIGEN_ID = Convert.ToInt32(this.comboBoxDeposito.SelectedValue);//DEPOSITO
                            _itemMovimiento.SECTORORIGEN_ID = 1;  // OJO ***** NO SE LLEVA EL STOCK POR SECTOR.. EL ORIGEN SOLO SE UTILZA PARA ENVIAR MERCADERIA //Convert.ToInt32(this.comboBoxSector.SelectedValue); //SECTOR
              
                            string _remSucursal = (this.textBoxSucRemito.Text.ToString() == string.Empty) ? "" : this.textBoxSucRemito.Text.Trim();
                            Int32 _remComprobante = (this.textBoxNroRemito.Text.ToString() == string.Empty) ? 0 : Convert.ToInt32(this.textBoxNroRemito.Text.Trim());

                            if (_stk.IngresoStockDepositoPorOC(_itemsInv, _itemMovimiento, _itemsMov, Convert.ToInt32(dataGridView1.CurrentRow.Cells[(int)Col_OCCabecera.ORDENCOMPRA_ID].Value.ToString()), dataGridView1.CurrentRow.Cells[(int)Col_OCCabecera.CODEMP].Value.ToString(), _remSucursal, _remComprobante, _ArtsVtos))
                            {
                                MessageBox.Show("El ingreso se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //IMPRIMO LAS ETIQUETAS QUE HAYA SELECCIONADO

                                ImprimirEtiquetas();
                                //LIMPIO LA GRILLA DE DETALLE
                                dataGridViewDetalle.Rows.Clear();
                                this.comboBoxDeposito.SelectedIndex = 0;
                                //this.comboBoxSector.SelectedIndex = 0;
                                //cargo de nuevo las OC DE este proveedor
                                TraerOrdenCompraDisponibles(this.comboBoxProveed.SelectedValue.ToString());
                               
                            }

                            else
                            {
                                MessageBox.Show("Error al ingresar Stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar al menos una cantidad en algún artículo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            private void Imprime(int _cantCopias, string _descripcion,string _codigoBarra)
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "Etiquetas.rpt";
                objReport.Load(reportPath);
                objReport.Refresh();
                objReport.ReportOptions.EnableSaveDataWithReport = false;
                       
                _Reporte.Reporte = objReport;
                objReport.SetParameterValue("DescripProd", _descripcion);

                //objReport.SetParameterValue("Vto", this.dateTimeVto.Value);
                //if (labelVto.Visible)
                //{
                //    objReport.SetParameterValue("ImprimeVto", true);
                //}
                //else
                //{
                //    objReport.SetParameterValue("ImprimeVto", false);
                //}
                objReport.SetParameterValue("CodigoBarra", _codigoBarra);


                objReport.PrintToPrinter(_cantCopias, false, 0, 0); // cantidad de copias, si se intercalan, primera página, segunda página
              
                pictureBox1.Dispose();

            }

            private void dataGridViewDetalle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
            {
                //try
                //{

                //    if (e.ColumnIndex == (int)Col_DetalleOC.CANT_RECIBIDA && e.ColumnIndex >= 0)
                //    {

                //        if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                //        {
                //            dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value = "0";

                //        }

                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}
            }

            //private Boolean EsNumerico(String numero)
            //{
            //    try
            //    {
            //        int.Parse(numero);
            //        return true;
            //    }
            //    catch
            //    {
            //        return false;
            //    }
            //}

            private void dataGridViewDetalle_CellValidated(object sender, DataGridViewCellEventArgs e)
            {
               // 
            }

            private void dataGridViewDetalle_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewDetalle.IsCurrentCellDirty)
                    dataGridViewDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            private void comboBoxcodEmp_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (this.comboBoxcodEmp.SelectedIndex == 0)
                {
                    CargarProveedores("EGES");
                    CargarDepositos();
                }
                else
                {
                    CargarProveedores("RSC");
                    CargarDepositos();
                }
            }

            private void dataGridViewDetalle_SelectionChanged(object sender, EventArgs e)
            {
                //PASO CON ENTER A LA OTRA COLUMNA
                if (MouseButtons != 0) return;

                if (_celWasEndEdit != null && dataGridViewDetalle.CurrentCell != null)
                {
                    // if we are currently in the next line of last edit cell
                    if (dataGridViewDetalle.CurrentCell.RowIndex == _celWasEndEdit.RowIndex + 1 &&
                        dataGridViewDetalle.CurrentCell.ColumnIndex == _celWasEndEdit.ColumnIndex)
                    {
                        int iColNew;
                        int iRowNew = 0;
                        if (_celWasEndEdit.ColumnIndex >= dataGridViewDetalle.ColumnCount - 1)
                        {
                            iColNew = (int) Col_DetalleOC.CANT_ORIGINAL; //seteo para que siempre empieze por la columna de cantidad recibida
                            iRowNew = dataGridViewDetalle.CurrentCell.RowIndex;
                        }
                        else
                        {
                            iColNew = _celWasEndEdit.ColumnIndex + 1;
                            iRowNew = _celWasEndEdit.RowIndex;
                        }
                        dataGridViewDetalle.CurrentCell = dataGridViewDetalle[iColNew, iRowNew];
                    }
                }
                _celWasEndEdit = null;
               
        }

            private void dataGridViewDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
            {
                _celWasEndEdit = dataGridViewDetalle[e.ColumnIndex, e.RowIndex];

                try
                {
                    if (e.ColumnIndex == (int)Col_DetalleOC.CANT_RECIBIDA && dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value != null && dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value != string.Empty)
                    {
                        //VALIDO LA CANTIDAD INGRESADA PARA QUE NO SUPERE EL % DE TOLERANCIA PERMITIDO ///
                        decimal _cantIngresada = Convert.ToDecimal(dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value.ToString(), culture);
                        decimal _PorctTolerancia  = Convert.ToDecimal(dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.PORCTOLERANCIA].Value.ToString(), culture);
                        decimal _cantAdeudada = Convert.ToDecimal(dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.CANT_ADEUDADA].Value.ToString(), culture);
                        if ( _cantIngresada >  (_cantAdeudada + (_cantAdeudada * _PorctTolerancia/100)) &&  _PorctTolerancia > 0)
                        {
                            MessageBox.Show("Atención, ud está recibiendo una cantidad mayor al valor de tolerancia de este artículo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void comboBoxDeposito_SelectedIndexChanged(object sender, EventArgs e)
            {
                // NO SE UTILIZA SECTOR PARA LLEVAR EL STOCK FISICO
                //if (this.comboBoxDeposito.SelectedIndex > 0)
                //{
                //    string _codEmp = (this.comboBoxcodEmp.SelectedValue.ToString());
                //    CargarSectoresDeposito(_codEmp, Convert.ToInt32(this.comboBoxDeposito.SelectedValue));
                //}
            }

        private void textBoxSucRemito_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = culture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxNroRemito_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = culture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxSucRemito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxNroRemito.Focus();
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (int)Col_DetalleOC.VTOS && e.RowIndex >= 0)
            {
                try
                {

                    DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.VTOS];

                   if(!buttonCell.Enabled)
                    {
                        MessageBox.Show("Este artículo no tiene el atributo Trabaja con Fecha de Vto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return; //SI EL BUTTON TIENE ENEBLE = FALSE NO PERMITO MOSTRAR EL OTRO FORMULARIO
                    }


                    Frm_Vtos _vto = new Frm_Vtos();
                    string _art = dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.CODIGO].Value.ToString();
                    string _descripArt = dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.DESCRIPCION].Value.ToString();
                    //RECUPERO LA LISTA DE VTOS DE ESTE ARTICULO PARA PASARLO AL FORMULARIO DE VTOS
                    List<Entities.Tables.STKVENCIMIENTO> _listObj = _ArtsVtos.FindAll(item => item.ARTICULO_ID == _art);

                    //ACA BORRAR DE LA LISTA ESTE ARTICULO CON TODOS SUS VTOS. PORQUE CARGO TODO DE NUEVO CADA VEZ QUE SE EDITA... 
                    //ESTO PORQUE PUEDE ESTAR AGREGANDO O ELIMINANDO VTOS.
                    _ArtsVtos.RemoveAll(item => item.ARTICULO_ID == _art);
                    //PASO LA LISTA AL FORMULARIO DE VTOS
                    _vto.ListVto = _listObj;
                    Entities.Tables.STKVENCIMIENTO _newVto;
                    _vto.CodigoArticuloVto = _art;
                    _vto.DescripArticuloVto = _descripArt;
                    decimal _cantIngresada = 0;
                    int _cantidadFechaVto = 0;
                    if (_vto.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var item in _vto.ListVto)
                        {
                            _newVto = new Entities.Tables.STKVENCIMIENTO();
                            _newVto.ARTICULO_ID = item.ARTICULO_ID;
                            _newVto.CANTIDAD = item.CANTIDAD;
                            _newVto.VTO = item.VTO;
                            //VOY SUMANDO LAS CANTIDADES
                            _cantIngresada += item.CANTIDAD;
                            _cantidadFechaVto++; //ME DICE CUANTAS FECHAS DE VTOS DISTINTAS TENGO, ES PARA SABER CUANTAS ETIQUETAS DEBO IMPRIMIR
                            _ArtsVtos.Add(_newVto);
                        }
                        //COLOCO LA CANTIDAD TOTAL RECIBIDA DE ESTE ARTICULO
                        dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.CANT_RECIBIDA].Value = _cantIngresada.ToString().Replace(",", ".");
                        dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.CANT_ETIQUETAS].Value = _cantidadFechaVto.ToString().Replace(",", ".");

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewDetalle_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.ColumnIndex >= 0 && this.dataGridViewDetalle.Columns[e.ColumnIndex].Index == (int)Col_DetalleOC.VTOS && e.RowIndex >= 0)
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    DataGridViewButtonCell celBoton = this.dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.VTOS ] as DataGridViewButtonCell;
            //    Icon icoCalendar = new Icon("\\\\192.168.5.10\\Bejerman\\compartida\\Reporting\\Santa Catalina\\image\\calendar.ico");
            //    e.Graphics.DrawIcon(icoCalendar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
            //    this.dataGridViewDetalle.Rows[e.RowIndex].Height = icoCalendar.Height + 10;
            //    this.dataGridViewDetalle.Columns[e.ColumnIndex].Width = icoCalendar.Width + 10;

            //    e.Handled = true;
            //}

            if (e.ColumnIndex >= 0 && this.dataGridViewDetalle.Columns[e.ColumnIndex].Index == (int)Col_DetalleOC.VTOS && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_DetalleOC.VTOS] as DataGridViewButtonCell;

                e.Graphics.DrawString("Ingresar", new Font("Verdana", 8), new SolidBrush(Color.Black),
                e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                e.Handled = true;
            }
        }

        #endregion

        //private void dataGridViewDetalle_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter )
        //    {

        //            if (dataGridViewDetalle.CurrentCell.ColumnIndex == (int)Col_DetalleOC.UNIBULTO)
        //            {
        //        if (dataGridViewDetalle.CurrentCell.RowIndex == _celWasEndEdit.RowIndex + 1 &&
        //            dataGridViewDetalle.CurrentCell.ColumnIndex == _celWasEndEdit.ColumnIndex)
        //        {

        //                int iColNew;
        //                int iRowNew = 0;

        //                iColNew = (int)Col_DetalleOC.CANT_RECIBIDA; //seteo para que siempre empieze por la columna de cantidad recibida

        //                iRowNew = _celWasEndEdit.RowIndex;

        //                dataGridViewDetalle.CurrentCell = dataGridViewDetalle[iColNew, iRowNew];
        //            }
        //        }
        //    }
        //}



    }
}
