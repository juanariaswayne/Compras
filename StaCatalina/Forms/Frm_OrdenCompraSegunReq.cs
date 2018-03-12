using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using System.IO;
using StaCatalina.Clases;
namespace StaCatalina.Forms
{
    public partial class Frm_OrdenCompraSegunReq : StaCatalina.Plantilla
    {
        #region Variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;

            private enum Col_RequerimientoCab
            {
                CODEMP = 0,
                SECTOR_REQ_ID,
                SELECCIONA,
                NRO_REQUERIMIENTO,
                FECHA_DE_PEDIDO,
                SECTOR_REQUERIMIENTO,
                OBSERVACIONES,
                DIARIO,
                LUGARENTREGA

            }
            private enum Col_RequerimientoItem
            {
                CODEMPRESA = 0,
                INCLUIR,
                NRO_REQUERIMIENTO,
                NRO_ITEM,
                ARTICULO_ID,
                ARTICULO,
                UNIDAD_DE_MEDIDA,
                PRECIO,
                CANTIDAD,
                MARCA,
                FECHA_DE_ENTREGA
            }
            protected string _condPagoProveed = null;
            private string fileName = String.Empty;
            CultureInfo culture = new CultureInfo("en-US");
            bool _pedidoDiario = false;

        List<Entities.Procedures.TRAEMARCAARTICULOS> _itemsMarca = new List<Entities.Procedures.TRAEMARCAARTICULOS>();
        #endregion

        #region Funciones
        public Frm_OrdenCompraSegunReq()
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
                    this.comboBoxProveed.SelectedIndex = 0;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            private void TraeRequerimientosPendientes()
            {

                try
                {
                    BLL.Procedures.REQUERIMIENTOS_PARAORDENDECOMPRA _detalle = new BLL.Procedures.REQUERIMIENTOS_PARAORDENDECOMPRA();
                    this.dataGridViewReqDisponibles.Rows.Clear();
                    //this.labelDiario.Visible = false;
                    this.textBoxLugarEntrega.Text = string.Empty;
                    //REQUERIMIENTOS DE LA EMPRESA QUE INGRESO
                    var q = (dynamic)null;

                    q = (from item in _detalle.ItemList(2)
                         where item.codemp == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString()
                     select item);

                    int indice;
                    foreach (Entities.Procedures.REQUERIMIENTOS_PARAORDENDECOMPRA item in q) //TRAIGO LOS REQUERIMIENTOS CON AUT=2 QUE SON LOS AUTORIZADOS
                    {
                        indice = dataGridViewReqDisponibles.Rows.Add();
                        dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                        dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.SECTOR_REQ_ID].Value = item.codemp;//SECTOR-ID
                        dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.NRO_REQUERIMIENTO].Value = item.requerimiento_id; //TTRAE ID DE REQUERIMIENTO
                        dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.FECHA_DE_PEDIDO].Value = item.fecha.ToShortDateString(); //TRAE FECHA DE PEDIDO
                        dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.SECTOR_REQUERIMIENTO].Value = item.descripcion;//TRAE DESCRIPCION DEL SECTOR
                        dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.OBSERVACIONES].Value = item.obs;//TRAE OBSERVACION
                        dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.DIARIO].Value = item.pedidodiario;//ME DICE SI EL REQUIERIMIENTO ES DIARIO
                        dataGridViewReqDisponibles.Rows[indice].DefaultCellStyle.BackColor = (item.pedidodiario) ? Color.YellowGreen:Color.White;
                        dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.LUGARENTREGA].Value = item.Lugarentrega;//LUGAR DE ENTREGA
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

                    
                    
                    for (int i = 0; i < this.dataGridViewDetalleReqDisponibles.Rows.Count ; i++)
                    {

                        DataGridViewCheckBoxCell cellSelecion = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.INCLUIR] as DataGridViewCheckBoxCell;

                        //SOLO GENERO LA ORDEN DE COMPRA CON LOS ITEMS SELECCIONADOS

                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                           

                            if (dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.CANTIDAD].Value == null || dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.CANTIDAD].Value == string.Empty)
                            {
                                MessageBox.Show("Debe Ingresar un valor en Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;

                            }

                        if (dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.FECHA_DE_ENTREGA].Value == null)
                        {
                            MessageBox.Show("Debe Ingresar una fecha de entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        if (Convert.ToDecimal(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.CANTIDAD].Value) == 0)
                            {
                                MessageBox.Show("Debe Ingresar una Cantidad mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }

                            if (dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.PRECIO].Value == null || dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.PRECIO].Value.ToString() == string.Empty)
                            {
                                MessageBox.Show("Debe Ingresar un valor en precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }


                            if (Convert.ToDecimal(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.PRECIO].Value) < 0)
                            {
                                MessageBox.Show("El precio debe ser mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


            }

        private void TraerMarcasArticulos()
        {
            try
            {
                BLL.Procedures.TRAEMARCAARTICULOS _marca = new BLL.Procedures.TRAEMARCAARTICULOS();
                _itemsMarca = _marca.ItemList("EGES"); //LAS MARCAS SE CARGAN CON LA EMPRESA EGESAC.. LOS ARTICULOS SON LOS MISMOS

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarMarca(string _articulo, DataGridViewComboBoxCell comboboxColumnSector)
        {
            try
            {


                Entities.Procedures.TRAEMARCAARTICULOS _itemSeleccion = new Entities.Procedures.TRAEMARCAARTICULOS();
                List<Entities.Procedures.TRAEMARCAARTICULOS> _miMarca = new List<Entities.Procedures.TRAEMARCAARTICULOS>();

                var q = (dynamic)null;

                _miMarca = (from m in _itemsMarca
                            where m.articulo_id.ToString().Trim() == _articulo.ToString().Trim()
                            select m).ToList<Entities.Procedures.TRAEMARCAARTICULOS>();


                comboboxColumnSector.DataSource = null;
                comboboxColumnSector.Items.Clear();

                //Carga el item de Seleccion
                _itemSeleccion.marca = "<Sin Definir>";// (_miMarca.Count > 0) ? "<Seleccione una Marca>" : "<Sin Definir>";
                _itemSeleccion.articulo_id = "0";
                _miMarca.Insert(0, _itemSeleccion);

                //Carga el combo
                comboboxColumnSector.DataSource = _miMarca.ToArray();
                comboboxColumnSector.DisplayMember = BLL.Procedures.TRAEMARCAARTICULOS.ColumnNames.MARCA;
                comboboxColumnSector.ValueMember = BLL.Procedures.TRAEMARCAARTICULOS.ColumnNames.MARCA;
                comboboxColumnSector.Value = "<Sin Definir>";//(_miMarca.Count > 0) ? "<Seleccione una Marca>" : "<Sin Definir>"; ;

                //FIN CARGO COMBO TIPO RECLAMO

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CalculaImporte()
        {
            try
            {
                //CALUCLO PRECIO x CANTIDAD
                labelImporteOC.Text = ("0").ToString(culture);
                decimal _importeTotal = 0;
                for (int i = 0; i < this.dataGridViewDetalleReqDisponibles.Rows.Count; i++)
                {
                    //SOLO TOMO LAS FILAS SELECCIONADAS
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.INCLUIR] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        //VERIFICO QUE PRECIO Y CANTIDAD SEAN VALORES VALIDOS
                        if (dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.PRECIO].Value != null && dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.CANTIDAD].Value != null && dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.PRECIO].Value != string.Empty && dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.CANTIDAD].Value != string.Empty)
                        {
                            decimal _precio = Convert.ToDecimal(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.PRECIO].Value.ToString(), culture);
                            decimal _cantidad = Convert.ToDecimal(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.CANTIDAD].Value.ToString(), culture);

                            _importeTotal = Convert.ToDecimal(_importeTotal + (_precio * _cantidad), culture);

                        }

                    }

                }
                labelImporteOC.Text = "$ " + _importeTotal.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #region Calendar
        public class CalendarColumn : DataGridViewColumn
            {
                public CalendarColumn()
                    : base(new CalendarCell())
                {
                }

                public override DataGridViewCell CellTemplate
                {
                    get
                    {
                        return base.CellTemplate;
                    }
                    set
                    {
                        // Ensure that the cell used for the template is a CalendarCell.
                        if (value != null &&
                            !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                        {
                            throw new InvalidCastException("Must be a CalendarCell");
                        }
                        base.CellTemplate = value;
                    }
                }
            }

            public class CalendarCell : DataGridViewTextBoxCell
            {

                public CalendarCell()
                    : base()
                {
                    // Use the short date format.
                    this.Style.Format = "d";
                }

                public override void InitializeEditingControl(int rowIndex, object
                    initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
                {
                    // Set the value of the editing control to the current cell value.
                    base.InitializeEditingControl(rowIndex, initialFormattedValue,
                        dataGridViewCellStyle);
                    CalendarEditingControl ctl =
                        DataGridView.EditingControl as CalendarEditingControl;
                    // Use the default row value when Value property is null.
                    if (this.Value == null)
                    {
                        ctl.Value = (DateTime)this.DefaultNewRowValue;
                    }
                    else
                    {
                        ctl.Value = Convert.ToDateTime(this.Value);
                    }
                }

                public override Type EditType
                {
                    get
                    {
                        // Return the type of the editing control that CalendarCell uses.
                        return typeof(CalendarEditingControl);
                    }
                }

                public override Type ValueType
                {
                    get
                    {
                        // Return the type of the value that CalendarCell contains.

                        return typeof(DateTime);
                    }
                }

                public override object DefaultNewRowValue
                {
                    get
                    {
                        // Use the current date and time as the default value.
                        return DateTime.Now;
                    }
                }
            }

            class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
            {
                DataGridView dataGridView;
                private bool valueChanged = false;
                int rowIndex;

                public CalendarEditingControl()
                {
                    this.Format = DateTimePickerFormat.Short;
                }

                // Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
                // property.
                public object EditingControlFormattedValue
                {
                    get
                    {
                        return this.Value.ToShortDateString();
                    }
                    set
                    {
                        if (value is String)
                        {
                            try
                            {
                                // This will throw an exception of the string is 
                                // null, empty, or not in the format of a date.
                                this.Value = DateTime.Parse((String)value);
                            }
                            catch
                            {
                                // In the case of an exception, just use the 
                                // default value so we're not left with a null
                                // value.
                                this.Value = DateTime.Now;
                                this.Show();
                            }
                        }
                    }
                }

                // Implements the 
                // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
                public object GetEditingControlFormattedValue(
                    DataGridViewDataErrorContexts context)
                {
                    return EditingControlFormattedValue;
                }

                // Implements the 
                // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
                public void ApplyCellStyleToEditingControl(
                    DataGridViewCellStyle dataGridViewCellStyle)
                {
                    this.Font = dataGridViewCellStyle.Font;
                    this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
                    this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;

                }

                // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
                // property.
                public int EditingControlRowIndex
                {
                    get
                    {
                        return rowIndex;
                    }
                    set
                    {
                        rowIndex = value;
                    }
                }

                // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
                // method.
                public bool EditingControlWantsInputKey(
                    Keys key, bool dataGridViewWantsInputKey)
                {
                    // Let the DateTimePicker handle the keys listed.
                    switch (key & Keys.KeyCode)
                    {
                        case Keys.Left:
                        case Keys.Up:
                        case Keys.Down:
                        case Keys.Right:
                        case Keys.Home:
                        case Keys.End:
                        case Keys.PageDown:
                        case Keys.PageUp:
                            return true;
                        default:
                            return !dataGridViewWantsInputKey;
                    }
                }

                // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
                // method.
                public void PrepareEditingControlForEdit(bool selectAll)
                {
                    // No preparation needs to be done.
                }

                // Implements the IDataGridViewEditingControl
                // .RepositionEditingControlOnValueChange property.
                public bool RepositionEditingControlOnValueChange
                {
                    get
                    {
                        return false;
                    }
                }

                // Implements the IDataGridViewEditingControl
                // .EditingControlDataGridView property.
                public DataGridView EditingControlDataGridView
                {
                    get
                    {
                        return dataGridView;
                    }
                    set
                    {
                        dataGridView = value;
                    }
                }

                // Implements the IDataGridViewEditingControl
                // .EditingControlValueChanged property.
                public bool EditingControlValueChanged
                {
                    get
                    {
                        return valueChanged;
                    }
                    set
                    {
                        valueChanged = value;
                    }
                }

                // Implements the IDataGridViewEditingControl
                // .EditingPanelCursor property.
                public Cursor EditingPanelCursor
                {
                    get
                    {
                        return base.Cursor;
                    }
                }

                protected override void OnValueChanged(EventArgs eventargs)
                {
                    // Notify the DataGridView that the contents of the cell
                    // have changed.
                    valueChanged = true;
                    this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
                    base.OnValueChanged(eventargs);
                }
            }

            #endregion

  
        #endregion

        #region TXT
            //private void GeneraTXTBinonexo()
            //{
            //    try
            //    {
            //        //-------------- ESTRUCTURA UPLOAD P.TXT ---------------------------
            //        //1-CODIGO DE ITEM VARCHAR(20)
            //        //2-CANTIDAD TOTAL NUMERO(10)
            //        //3-NRO DE NECESIDAD VARCHAR(20)--- ES INTERNO DE STACATALINA
            //        //4-FECHA_01 FECHA(DD/MM//YYYY)
            //        //5-CANTIDAD_01 NUMERO(10)
            //        //6-FECHA_02 FECHA(DD/MM//YYYY) --CAMPO NO OBLIGATORIO
            //        //7-CANTIDAD_02 NUMERO(10) -- CAMPO NO OBLIGATORIO
            //        //HASTA 24 FECHAS POSIBLES DE ENTREGA
            //        string itemTXT = string.Empty;
            //        string codProdTXT = string.Empty;
            //        Int32 cantidadTXT = 0;
            //        string nroNecesidad="99";

            //        if (this.saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            //        {
            //            string SPath = this.saveFileDialog1.FileName;

            //            for (int i = 0; i < this.dataGridViewDetalleReqDisponibles.Rows.Count; i++)
            //            {
            //                codProdTXT = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.ARTICULO_ID].Value.ToString().Trim();
            //                cantidadTXT = Convert.ToInt32(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.CANTIDAD].Value);
            //                itemTXT = codProdTXT + ";" + cantidadTXT + ";" + nroNecesidad;

            //                Clases.Functions.TextFileAppend(SPath + ".txt", itemTXT);
            //            }

            //        }

            //    }

            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }

            //}
        #endregion

        #region Eventos
            private void Frm_OrdenCompraSegunReq_Load(object sender, EventArgs e)
            {
                //PERMISOS
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
                //calendar
                CalendarColumn col = new CalendarColumn();

                this.dataGridViewDetalleReqDisponibles.Columns.Add(col);
                this.dataGridViewDetalleReqDisponibles.Columns[(int)Col_RequerimientoItem.FECHA_DE_ENTREGA].HeaderText = "Fecha Entrega";
                this.dataGridViewDetalleReqDisponibles.Columns[(int)Col_RequerimientoItem.FECHA_DE_ENTREGA].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //TRAE LOS REQUERIMIENTOS
                this.Text = "Generación de Ordenes de Compra según Requerimiento Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                TraeRequerimientosPendientes();
                CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);
                TraerMarcasArticulos();

                labelImporteOC.Text = ("0").ToString(culture);

        }

            private void dataGridViewDetalleReqDisponibles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewDetalleReqDisponibles.IsCurrentCellDirty)
                    dataGridViewDetalleReqDisponibles.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
       
            private void comboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
            {
                //if (this.comboBoxEmpresa.SelectedIndex > 0)
                //{
                //    if (this.comboBoxEmpresa.SelectedIndex == 1)
                //    {
                //        CargarProveedor("EGES");//TRAIGO PROVEEDORES DE EGES
                //    }
                //    else
                //    {
                //        CargarProveedor("RSC"); //TRAIGO PROVEEDORES DE RSC
                //    }
                //}
            }

            private void dataGridViewDetalleReqDisponibles_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
            {
                int iColumn = dataGridViewDetalleReqDisponibles.CurrentCell.ColumnIndex;
                if (iColumn == (int)Col_RequerimientoItem.CANTIDAD || iColumn == (int)Col_RequerimientoItem.PRECIO)
                {
                    TextBox txt = e.Control as TextBox;
                    txt.KeyPress += OnlyNumbers_KeyPress;
                }
            }


            private void toolStripButtonSave_Click(object sender, EventArgs e)
            {
                try
                {
                    if (VerificaIngreso())
                    {
                        Entities.Tables.COMORDENCOMPRA _OCCabecera = new Entities.Tables.COMORDENCOMPRA();
                        BLL.Tables.COMORDENCOMPRA _OCCab = new BLL.Tables.COMORDENCOMPRA();
                        Entities.Tables.COMORDENCOMPRAITEM _OCItem = new Entities.Tables.COMORDENCOMPRAITEM();
                     
                        List<Entities.Tables.COMORDENCOMPRAITEM> _ItemsCab = new List<Entities.Tables.COMORDENCOMPRAITEM>();

                    //    List<Entities.Tables.COMREQUERIMIENTOORDENCOMPRA> _ItemsRequerimiento = new List<Entities.Tables.COMREQUERIMIENTOORDENCOMPRA>();
                    //Entities.Tables.COMREQUERIMIENTOORDENCOMPRA _OCReqIem = new Entities.Tables.COMREQUERIMIENTOORDENCOMPRA();
                    List<Entities.UserObJ.ReqOrdenCompra> _ItemsRequerimiento = new List<Entities.UserObJ.ReqOrdenCompra>();
                    Entities.UserObJ.ReqOrdenCompra _OCReqItem;


                    _OCCabecera.FECHA = Convert.ToDateTime(this.dateTimePickerFecha.Value.ToShortDateString()); //FECHA
                        _OCCabecera.PROVEED_ID = this.comboBoxProveed.SelectedValue.ToString(); // PROVEEDOR
                        _OCCabecera.ESTADO_ID = 1; //Ojo ver que valor se envia despues  //ESTADO
                        _OCCabecera.TIPOOC_ID = 3; //OJO COLOCAR EL VALOR REAL DE ORDEN DE COMPRA SEGUN REQUERIMIENTO
                        _OCCabecera.MODIFICACOSTO = (this.radioButtonNo.Checked) ? 0 : 1; //MODIFICA COSTO
                        _OCCabecera.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada; //EMPRESA PARA LA CUAL SE HACE LA OC
                        _OCCabecera.CONDICIONPAGO_ID = _condPagoProveed; // CONDICIOND DE PAGO
                        _OCCabecera.OBS = this.textBoxObs.Text.Trim(); //OBS
                        _OCCabecera.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                        _OCCabecera.PEDIDODIARIO = (_pedidoDiario) ? true : false;

                        Boolean _selecciono = false;
                        Int32 posicion=-1;
             
                        for (int i = 0; i < this.dataGridViewDetalleReqDisponibles.Rows.Count ; i++)
                        {
                            _OCItem = new Entities.Tables.COMORDENCOMPRAITEM();
                            _OCReqItem = new Entities.UserObJ.ReqOrdenCompra();

                        DataGridViewCheckBoxCell cellSelecion = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.INCLUIR] as DataGridViewCheckBoxCell;
                            
                            //SOLO GENERO LA ORDEN DE COMPRA CON LOS ITEMS SELECCIONADOS
                   
                            if (Convert.ToBoolean(cellSelecion.Value))
                            {
                                _selecciono = true;

                                _OCItem.ARTICULO_ID = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.ARTICULO_ID].Value.ToString();
                                _OCItem.UNIMED = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.UNIDAD_DE_MEDIDA].Value.ToString();
                                _OCItem.PRECIO = Convert.ToDecimal(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.PRECIO].Value.ToString(), culture);
                                _OCItem.CANTIDAD = Convert.ToDecimal(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.CANTIDAD].Value.ToString(), culture);
                                if (dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.MARCA].EditedFormattedValue != null && dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.MARCA].Value != "0" && dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.MARCA].Value != "<Sin Definir>")
                                {
                                _OCItem.MARCA = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.MARCA].EditedFormattedValue.ToString();
                                }

                                _OCItem.FECHAENTREGA = Convert.ToDateTime(Convert.ToDateTime(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.FECHA_DE_ENTREGA].Value));
                                _OCItem.NIVELAUT_ID = 1; //ojo ver como se envia despues
                               
                               
                                //VARIABLES PARA LA TABLA comRequerimientoOrdenCompra
                                _OCItem.CODEMPREQUERIMIENTO = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.CODEMPRESA].Value.ToString(); //EMPRESA DEL REQUERIMIENTO
                                _OCItem.NROITEM = Convert.ToInt32(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.NRO_ITEM].Value); //ES EL NRO DE ITEM ORIGINAL QUE LO NECESITO PARA GUARDAR EN LA TABLA comRequerimientoOrdenCompra
                                _OCItem.REQUERIMIENTO_ID = Convert.ToInt32(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.NRO_REQUERIMIENTO].Value);
                                //VARIABLES PARA LA TABLA COMREQUERIMIENTOORDENCOMPRA, ESTO PORQUE PUEDO ELEGIR VARIOS REQUERIMIENTOS INCLUSIVE ELEGIR EL MISMO ARTICULO, 
                                //ES PARA NO PERDER LA TRAZABILIDAD DEL REQUERIMIENTO
                                _OCReqItem.CodEmp =  Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
                                _OCReqItem.NroItem = Convert.ToInt32(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.NRO_ITEM].Value); //ES EL NRO DE ITEM ORIGINAL QUE LO NECESITO PARA GUARDAR EN LA TABLA comRequerimientoOrdenCompra
                                _OCReqItem.Requerimiento_Id = Convert.ToInt32(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.NRO_REQUERIMIENTO].Value);
                                _OCReqItem.Articulo_id = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoItem.ARTICULO_ID].Value.ToString();
                                _ItemsRequerimiento.Add(_OCReqItem);//AGREGO A LA COLECCION

                                //ANTES DE GUARDAR RECORRO LA COLECCION VERIFICANDO SI YA EXISTE ESTE ARTICULO, DE SER ASÍ SUMO LA CANTIDAD
                                posicion = _ItemsCab.FindIndex((Entities.Tables.COMORDENCOMPRAITEM _miArticulo) => _miArticulo.ARTICULO_ID.Trim() == _OCItem.ARTICULO_ID.Trim());

                                if (posicion == -1)
                                {
                                    _ItemsCab.Add(_OCItem); //EL ARTICULO NO ESTÁ, ENTONCES AGREGO A LA COLECCION
                                }
                                else
                                {
                                    //COMO YA EXISTE, ACTUALIZO LA CANTIDAD... SUMO LO QUE YA TIENE
                                    Entities.Tables.COMORDENCOMPRAITEM query = (from  ItemOC in _ItemsCab
                                                           where ItemOC.ARTICULO_ID.Trim() == _OCItem.ARTICULO_ID.Trim()
                                                           select ItemOC).Single();
                                    query.CANTIDAD = query.CANTIDAD + _OCItem.CANTIDAD;
                                    
                                }

                            }
                                          

                        }

                        if (!_selecciono)
                        {
                            MessageBox.Show("Para generar una Orden de Compra, debe seleccionar al menos un artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //LLAMO A LA FUNCION QUE GUARDA CABECERA E ITEMS
                        int _NroOC;
                        _NroOC  = _OCCab.AddItem(_OCCabecera, _ItemsCab, _ItemsRequerimiento);
                        if (_NroOC > 0)
                        {
                            MessageBox.Show("Se generó la orden de compra Nro:" + " " + _NroOC, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridViewDetalleReqDisponibles.Rows.Clear();
                            this.comboBoxProveed.SelectedIndex = 0;
                            _pedidoDiario = false;
                           // this.labelDiario.Visible = false;
                            TraeRequerimientosPendientes();
                        }
                        else
                        {
                            MessageBox.Show("Error al grabar Orden de Compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }

                    else
                    {
                        MessageBox.Show("Debe completar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            private void comboBoxProveed_SelectedIndexChanged(object sender, EventArgs e)
            {
                try
                {
                    if (this.comboBoxProveed.SelectedIndex > 0)
                    {
                        //recupera condicion de pago
                        BLL.Procedures.H_CONDPAGOPROVEED _condPago = new BLL.Procedures.H_CONDPAGOPROVEED();
                        string _codEmp;

                    _codEmp = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;

                        _condPago.ItemList(_codEmp, this.comboBoxProveed.SelectedValue.ToString());
                        if (_condPago.Resultset.Count > 0)
                        {
                            _condPagoProveed = _condPago.Resultset[0].condpago.ToString();

                        }
                        else
                        {
                            MessageBox.Show("Error al recuperar Condición de pago del proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            private void dataGridViewReqDisponibles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewReqDisponibles.IsCurrentCellDirty)
                    dataGridViewReqDisponibles.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            private void dataGridViewReqDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

                try
                {
                   if(e.ColumnIndex == (int)Col_RequerimientoCab.SELECCIONA)
                   {
                       //CON CADA SELEECCION O DESELECCION, ACTUALIZO LOS ITEMS.... VOY TOMANDO TODOS LOS REQUERIMIENTOS_ITEM PARA PASARLO A STORED
                       string _requerimientos=string.Empty;
                       for (int i = 0; i < this.dataGridViewReqDisponibles.Rows.Count; i++)
                       {
                           DataGridViewCheckBoxCell cellSelecion = dataGridViewReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoCab.SELECCIONA] as DataGridViewCheckBoxCell;
                           if (Convert.ToBoolean(cellSelecion.Value))
                           {

                               _requerimientos = (_requerimientos == string.Empty) ? dataGridViewReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoCab.NRO_REQUERIMIENTO].Value.ToString() : _requerimientos + "," + dataGridViewReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoCab.NRO_REQUERIMIENTO].Value.ToString();

                           }

                       }
                    //MUESTRO LA PALABRA DIARIO PARA QUE EL USUARIO SEPA QUE ES UN REQUERIMIENTO DIARIO
                   // this.labelDiario.Visible =  (Convert.ToBoolean(dataGridViewReqDisponibles.Rows[e.RowIndex].Cells[(int)Col_RequerimientoCab.DIARIO].Value)) ? true : false;
                    _pedidoDiario = (Convert.ToBoolean(dataGridViewReqDisponibles.Rows[e.RowIndex].Cells[(int)Col_RequerimientoCab.DIARIO].Value)) ? true : false;
                    this.textBoxLugarEntrega.Text = dataGridViewReqDisponibles.Rows[e.RowIndex].Cells[(int)Col_RequerimientoCab.LUGARENTREGA].Value.ToString();

                    BLL.Procedures.TRAEREQUERIMIENTOITEMVARIOS _item = new BLL.Procedures.TRAEREQUERIMIENTOITEMVARIOS();

                    this.dataGridViewDetalleReqDisponibles.Rows.Clear();
                    int indice;
                    //TRAIGO LOS ITEMS DE ESTE REQUERIMIENTO CON NIVELAUT = 2  QUE SON LOS AUTORIZADOS
                    foreach (Entities.Procedures.TRAEREQUERIMIENTOITEMVARIOS item in _item.ItemList(dataGridViewReqDisponibles.Rows[e.RowIndex].Cells[(int)Col_RequerimientoCab.CODEMP].Value.ToString(), _requerimientos, 2))
                    {
                        indice = dataGridViewDetalleReqDisponibles.Rows.Add();
                        dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoItem.CODEMPRESA].Value = item.codemp.ToString();//DESCRIPCION DEL ARTICULO
                        dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoItem.NRO_REQUERIMIENTO].Value = item.requerimiento_id;//REQUERIMIENTO_ID
                        dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoItem.NRO_ITEM].Value = item.nroitem;//TRAE NRO ITEM
                        dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoItem.ARTICULO_ID].Value = item.articulo_id; //ID DEL ARTICULO
                        dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoItem.ARTICULO].Value = item.art_descgen;//DESCRIPCION DEL ARTICULO
                        dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoItem.UNIDAD_DE_MEDIDA].Value = item.unimed;//TRAE UNIMED
                        dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoItem.CANTIDAD].Value = item.cantidad.ToString().Replace(",", "."); //TRAE CANTIDAD

                        dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoItem.FECHA_DE_ENTREGA].Value = null;//item.fechaentrega.ToShortDateString();//FECHA DE ENTREGA

                        // ahora recupero la fila del combo, para saber que fila debo llenar con la marca

                        DataGridViewRow row = dataGridViewDetalleReqDisponibles.Rows[indice]; //this.dataGridViewReq.CurrentRow;
                        DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_RequerimientoItem.MARCA] as DataGridViewComboBoxCell;

                        CargarMarca(item.articulo_id, comboboxColumnSector);

                        dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoItem.MARCA].Value = item.Marca;//MARCA

                    }
                   }

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

        private void dataGridViewDetalleReqDisponibles_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridViewDetalleReqDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                if(e.ColumnIndex == Convert.ToInt32(Col_RequerimientoItem.INCLUIR ))
                {
                    CalculaImporte();
                }

            }
        }

        private void checkBoxSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewDetalleReqDisponibles.Rows.Count > 0)
            {


                if (this.checkBoxSeleccionar.Checked)
                {
                    foreach (DataGridViewRow item in dataGridViewDetalleReqDisponibles.Rows)
                    {
                        item.Cells[(int)Col_RequerimientoItem.INCLUIR].Value = 1;
                    }

                }

                else
                {

                    foreach (DataGridViewRow item in dataGridViewDetalleReqDisponibles.Rows)
                    {
                        item.Cells[(int)Col_RequerimientoItem.INCLUIR].Value = 0;
                    }
                }

                CalculaImporte();
            }
        }


        #endregion

     

        private void dataGridViewDetalleReqDisponibles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
             
                    //SIEMPRE Y CUANDO SE INGRESE VALORES EN PRECIO Y CANTIDAD
                    if (e.ColumnIndex == Convert.ToInt32(Col_RequerimientoItem.CANTIDAD) || e.ColumnIndex == Convert.ToInt32(Col_RequerimientoItem.PRECIO))
                    {
                        CalculaImporte();
                    }
           


            }
        }
    }
}
