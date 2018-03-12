using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;
using System.IO;
namespace StaCatalina.Forms
{
    public partial class Frm_CotizacionBionexoSegunRequerimiento : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private List<Entities.Procedures.TRAEREQUERIMIENTOITEMVARIOS> _itemsReq = new List<Entities.Procedures.TRAEREQUERIMIENTOITEMVARIOS>();

        private enum Col_GridDetalle
        {
            INCLUIR = 0,
            ARTICULO,
            DESCRIPCION,
            UNIDAD,
            CANTIDAD,
            FENTREGA1,
            CANTIDAD1,
            FENTREGA2,
            CANTIDAD2

        }

        private enum Col_RequerimientoCab
        {
            CODEMP = 0,
            SECTOR_REQ_ID,
            SELECCIONA,
            NRO_REQUERIMIENTO,
            FECHA_DE_PEDIDO,
            SECTOR_REQUERIMIENTO,
            OBSERVACIONES

        }

        CultureInfo culture = new CultureInfo("en-US");
        #endregion

        #region Funciones
        public Frm_CotizacionBionexoSegunRequerimiento()
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

        private void TraeRequerimientosPendientes()
        {

            try
            {
                BLL.Procedures.REQUERIMIENTOS_PARAORDENDECOMPRA _detalle = new BLL.Procedures.REQUERIMIENTOS_PARAORDENDECOMPRA();
                this.dataGridViewReqDisponibles.Rows.Clear();
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
                    dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.SECTOR_REQ_ID].Value = item.sectorrequerimiento_id;//SECTOR-ID
                    dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.NRO_REQUERIMIENTO].Value = item.requerimiento_id; //TTRAE ID DE REQUERIMIENTO
                    dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.FECHA_DE_PEDIDO].Value = item.fecha.ToShortDateString(); //TRAE FECHA DE PEDIDO
                    dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.SECTOR_REQUERIMIENTO].Value = item.descripcion;//TRAE DESCRIPCION DEL SECTOR
                    dataGridViewReqDisponibles.Rows[indice].Cells[(int)Col_RequerimientoCab.OBSERVACIONES].Value = item.obs;//TRAE OBSERVACION

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

        private void DefinirColumnas()
        {
            //dataGridViewConsolidado.DataKeyNames = new string[] { "Id" };
            //*****COLUMNA F.ENTREGA1
            CalendarColumn col = new CalendarColumn();

            this.dataGridViewConsolidado.Columns.Add(col);
            this.dataGridViewConsolidado.Columns[(int)Col_GridDetalle.FENTREGA1].HeaderText = "F.Entrega1";
            this.dataGridViewConsolidado.Columns[(int)Col_GridDetalle.FENTREGA1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewConsolidado.Columns[(int)Col_GridDetalle.FENTREGA1].Width = 90;
            //COLUMNA CANTIDAD F.ENTREGA1
            DataGridViewColumn _col = new DataGridViewColumn();
            _col.HeaderText = "Cantidad";
            _col.Name = "Cantidad";
            _col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            _col.Width = 80;
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            _col.CellTemplate = cell;
            _col.DefaultCellStyle.Format = "N2";
            this.dataGridViewConsolidado.Columns.Add(_col);

            //*****COLUMNA F.ENTREGA2
            //col = new CalendarColumn();

            //this.dataGridViewConsolidado.Columns.Add(col);
            //this.dataGridViewConsolidado.Columns[(int)Col_GridDetalle.FENTREGA2].HeaderText = "F.Entrega2";
            //this.dataGridViewConsolidado.Columns[(int)Col_GridDetalle.FENTREGA2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dataGridViewConsolidado.Columns[(int)Col_GridDetalle.FENTREGA2].Width = 90;
            ////COLUMNA CANTIDAD F.ENTREGA2
            //_col = new DataGridViewColumn();
            //_col.HeaderText = "Cantidad2";
            //_col.Name = "Cantidad2";
            //_col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //_col.Width = 80;
            //cell = new DataGridViewTextBoxCell();
            //_col.CellTemplate = cell;
            //_col.DefaultCellStyle.Format = "N2";
            //this.dataGridViewConsolidado.Columns.Add(_col);

            //*****COLUMNA F.ENTREGA3
            //col = new CalendarColumn();

            //this.dataGridViewConsolidado.Columns.Add(col);
            //this.dataGridViewConsolidado.Columns[(int)Col_GridDetalle.FENTREGA3].HeaderText = "F.Entrega3";
            //this.dataGridViewConsolidado.Columns[(int)Col_GridDetalle.FENTREGA3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dataGridViewConsolidado.Columns[(int)Col_GridDetalle.FENTREGA3].Width = 90;
            ////COLUMNA CANTIDAD F.ENTREGA2
            //_col = new DataGridViewColumn();
            //_col.HeaderText = "Cantidad3";
            //_col.Name = "Cantidad3";
            //_col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //_col.Width = 80;
            //cell = new DataGridViewTextBoxCell();
            //_col.CellTemplate = cell;
            //_col.DefaultCellStyle.Format = "N2";
            //this.dataGridViewConsolidado.Columns.Add(_col);


        }

        #endregion

        #region TXT
        private bool GeneraTXTBinonexo(ref Int32 _NroSolicitud)
        {
            try
            {
                //-------------- ESTRUCTURA UPLOAD P.TXT ---------------------------
                //1-CODIGO DE ITEM VARCHAR(20)
                //2-CANTIDAD TOTAL NUMERO(10)
                //3-NRO DE NECESIDAD VARCHAR(20)--- ES INTERNO DE STACATALINA
                //4-FECHA_01 FECHA(DD/MM//YYYY)
                //5-CANTIDAD_01 NUMERO(10)
                //6-FECHA_02 FECHA(DD/MM//YYYY) --CAMPO NO OBLIGATORIO
                //7-CANTIDAD_02 NUMERO(10) -- CAMPO NO OBLIGATORIO
                //HASTA 24 FECHAS POSIBLES DE ENTREGA
                string itemTXT = string.Empty;
                string codProdTXT = string.Empty;
                Int32 cantidadTXT = 0;
                Int32 nroNecesidad = 99;
                DateTime _fechaEntrega1TXT;
                Int32 cantidad1TXT = 0;
                //DateTime _fechaEntrega2TXT;
                //Int32 cantidad2TXT = 0;
                Boolean _selecciono = false;

                BLL.Procedures.PROXIMONROSOLICITUD _proximoNroNecesidad = new BLL.Procedures.PROXIMONROSOLICITUD();
                _proximoNroNecesidad.Items();
                nroNecesidad = _proximoNroNecesidad.Result[0].nrosolicitud;

                if (this.saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    string SPath = this.saveFileDialog1.FileName;

                    for (int i = 0; i < this.dataGridViewConsolidado.Rows.Count; i++)
                    {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewConsolidado.Rows[i].Cells[(int)Col_GridDetalle.INCLUIR] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            _selecciono = true;
                            codProdTXT = dataGridViewConsolidado.Rows[i].Cells[(int)Col_GridDetalle.ARTICULO].Value.ToString().Trim();
                            cantidadTXT = Convert.ToInt32(Convert.ToDecimal(dataGridViewConsolidado.Rows[i].Cells[(int)Col_GridDetalle.CANTIDAD].Value.ToString(),culture));
                            //por defaul ARMO EL TXT CON LOS DATOS MINIMOS....
                            itemTXT = codProdTXT + ";" + cantidadTXT + ";" + nroNecesidad;

                            //VERIFICO SI TIENE FECHAS DE ENTREGA ADICIONAL
                            if (dataGridViewConsolidado.Rows[i].Cells[(int)Col_GridDetalle.CANTIDAD1].Value != null && dataGridViewConsolidado.Rows[i].Cells[(int)Col_GridDetalle.CANTIDAD1].Value != string.Empty)
                            {
                                //TIENE UNA FECHA ADICIONAL.... AGREGO.. FECHA Y CANTIDAD

                                _fechaEntrega1TXT = Convert.ToDateTime(dataGridViewConsolidado.Rows[i].Cells[(int)Col_GridDetalle.FENTREGA1].Value);
                                cantidad1TXT = Convert.ToInt32(Convert.ToDecimal(dataGridViewConsolidado.Rows[i].Cells[(int)Col_GridDetalle.CANTIDAD1].Value.ToString(), culture));

                                itemTXT = itemTXT + ";" + _fechaEntrega1TXT.ToShortDateString() + ";" + cantidad1TXT;
                            }

                            Clases.Functions.TextFileAppend(SPath + ".txt", itemTXT);
                        }
                    }

                    if (!_selecciono)
                    {
                        MessageBox.Show("Debe seleccionar al menos un artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        _NroSolicitud = nroNecesidad;
                        return true;
                    }
                    //return true;

                }
                else
                {
                    return false;
                }

                //return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }
        #endregion

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
                    ctl.Value = (DateTime)this.Value;
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
                    return Convert.ToDateTime(DateTime.Now.ToShortDateString());
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
                            this.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
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

        #region Eventos
        private void Frm_CotizacionBionexoSegunRequerimiento_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //FIN PERMISOS
            this.Text = "Generar Archivo de cotización para Bionexo, empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
            DefinirColumnas();
            //CargarRubros();
            //CargarSubRubros();
            TraeRequerimientosPendientes();
        }

        private void dataGridViewConsolidado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewConsolidado.IsCurrentCellDirty)
                dataGridViewConsolidado.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewConsolidado_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewConsolidado.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_GridDetalle.CANTIDAD || iColumn == (int)Col_GridDetalle.CANTIDAD1 || iColumn == (int)Col_GridDetalle.CANTIDAD2)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 _nroSolicitud = 0;
                if (GeneraTXTBinonexo(ref _nroSolicitud))
                {
                    //GUARDO EN TABLA COMREQUERIMIENTOBIONEXO, PARA PODER SABER QUE REQUERIMIENTO YA TIENE PEDIDO DE CORIZACIÓN EN BIONEXO
                    Entities.Tables.COMREQUERIMIENTOBIONEXO _itemBionexo = new Entities.Tables.COMREQUERIMIENTOBIONEXO();
                    BLL.Tables.COMREQUERIMIENTOBIONEXO _genera = new BLL.Tables.COMREQUERIMIENTOBIONEXO();
                    //List<Entities.Tables.COMREQUERIMIENTOBIONEXO> _listReq = new List<Entities.Tables.COMREQUERIMIENTOBIONEXO>();

                    string _articulo;
                    //*********************PROCESO
                    //RECUPERO LOS ARTICULOS QUE SELECCIONA PARA BUSCARLOS EN LA COLECCION PORQUE PUEDE ESTAR EN MAS DE UN REQUERIMIENTO

                    for (int i = 0; i < this.dataGridViewConsolidado.Rows.Count; i++)
                    {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewConsolidado.Rows[i].Cells[(int)Col_GridDetalle.INCLUIR] as DataGridViewCheckBoxCell;

                        if (Convert.ToBoolean(cellSelecion.Value))
                        {

                            _articulo = dataGridViewConsolidado.Rows[i].Cells[(int)Col_GridDetalle.ARTICULO].Value.ToString().Trim();

                            //BUSCO ESTE CÓDIGO EN LA COLECCION
                            IEnumerable<Entities.Procedures.TRAEREQUERIMIENTOITEMVARIOS> RequerimientoQuery =
                            from ItemReq in _itemsReq
                            where ItemReq.articulo_id.Trim().ToUpper() == _articulo.Trim().ToUpper()
                            select ItemReq;

                            foreach (Entities.Procedures.TRAEREQUERIMIENTOITEMVARIOS _itemR in RequerimientoQuery)
                            {
                                //VOY GUARDANDO LOS OBJETOS DE CADA REQUERIMIENTO
                                _itemBionexo = new Entities.Tables.COMREQUERIMIENTOBIONEXO();
                                _itemBionexo.CODEMP = _itemR.codemp;
                                _itemBionexo.REQUERIMIENTO_ID = _itemR.requerimiento_id;
                                _itemBionexo.FECHA = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                _itemBionexo.NROSOLICITUD = _nroSolicitud;
                                _itemBionexo.NROITEM = _itemR.nroitem;
                                _itemBionexo.CANTIDAD = _itemR.cantidad;

                                //_listReq.Add(_itemBionexo);
                                //VOY GUARDANDO LOS REQUERIMIENTOS
                                _genera.Add(_itemBionexo);
                            }

                        }
                    }


                    
                    MessageBox.Show("Se generó el archivo: " + this.saveFileDialog1.FileName.ToString() + ", Nro. necesidad: " + _nroSolicitud, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TraeRequerimientosPendientes();
                    dataGridViewConsolidado.Rows.Clear();
                }

            }

            catch (Exception ex)
            {
                File.Delete(this.saveFileDialog1.FileName.ToString()+".Txt");
                MessageBox.Show("Error al generar el Archivo TXT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewConsolidado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == (int)Col_GridDetalle.INCLUIR && e.RowIndex != -1)
                {
                    dataGridViewConsolidado.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    //como no desea pediro.. SACO EL TILDE
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewConsolidado.Rows[e.RowIndex].Cells[(int)Col_GridDetalle.INCLUIR] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        //VERIFICO SI ESTE ARTICULO QUE ESTA PIDIENDO TIENE PENDIENTE DE ENTREGA-....
                        BLL.Procedures.PEDIENTEENTREGAARTICULO _pendiente = new BLL.Procedures.PEDIENTEENTREGAARTICULO();
                        string _codEmp = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim();
                        string _articulo = dataGridViewConsolidado.Rows[e.RowIndex].Cells[(int)Col_GridDetalle.ARTICULO].Value.ToString();

                        _pendiente.Items(_codEmp, _articulo);
                        if (_pendiente.Resultset[0].diferencia > 0)
                        {
                            DialogResult _result = MessageBox.Show("Este artículo tiene pendiente de entrega, desea pedir cotización de todos modos?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (_result == DialogResult.Cancel)
                            {

                                dataGridViewConsolidado.Rows[e.RowIndex].Cells[(int)Col_GridDetalle.INCLUIR].Value = false;
                                //dataGridViewConsolidado.Rows[e.RowIndex].Cells[(int)Col_GridDetalle.INCLUIR].Selected = false;
                                dataGridViewConsolidado.CommitEdit(DataGridViewDataErrorContexts.Commit);



                            }
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

        private void dataGridViewConsolidado_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void checkBoxSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewConsolidado.Rows.Count > 0)
            {

                if (this.checkBoxSeleccionar.Checked)
                {
                    foreach (DataGridViewRow item in dataGridViewConsolidado.Rows)
                    {
                        item.Cells[(int)Col_GridDetalle.INCLUIR].Value = 1;
                    }
                }

                else
                {

                    foreach (DataGridViewRow item in dataGridViewConsolidado.Rows)
                    {
                        item.Cells[(int)Col_GridDetalle.INCLUIR].Value = 0;
                    }
                }

            }
        }

        private void dataGridViewReqDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == (int)Col_RequerimientoCab.SELECCIONA)
                {
                    //CON CADA SELEECCION O DESELECCION, ACTUALIZO LOS ITEMS.... VOY TOMANDO TODOS LOS REQUERIMIENTOS_ITEM PARA PASARLO A STORED
                    string _requerimientos = string.Empty;
                    for (int i = 0; i < this.dataGridViewReqDisponibles.Rows.Count; i++)
                    {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoCab.SELECCIONA] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            //GUARDO TODOS LOS REQUERIMIENTOS ID PARA LUEGO IR A BUSCAR LOS ITEMS 
                            _requerimientos = (_requerimientos == string.Empty) ? dataGridViewReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoCab.NRO_REQUERIMIENTO].Value.ToString() : _requerimientos + "," + dataGridViewReqDisponibles.Rows[i].Cells[(int)Col_RequerimientoCab.NRO_REQUERIMIENTO].Value.ToString();

                        }

                    }

                    BLL.Procedures.TRAEREQUERIMIENTOITEMVARIOS _item = new BLL.Procedures.TRAEREQUERIMIENTOITEMVARIOS();

                   this.dataGridViewConsolidado.Rows.Clear();
                   
                    int indice;
                    this._itemsReq.Clear();
                    //TODOS LOS ITEMS DE TODOS LOS REQUERIMIENTOS SELECCIONADOS, LOS GUARDO EN UNA LISTA..
                    this._itemsReq = _item.ItemList(dataGridViewReqDisponibles.Rows[e.RowIndex].Cells[(int)Col_RequerimientoCab.CODEMP].Value.ToString(), _requerimientos, 2); //traigo todos los requerimientos autorizados

                    //var groupsForIterate = (from item in _itemsReq
                    //                        select item).ToList<Entities.Procedures.TRAEREQUERIMIENTOITEMVARIOS>().GroupBy(x => new { x.articulo_id, x.art_descgen, x.unimed });

                    var groupsForIterate = _itemsReq.GroupBy(x =>
                       new { x.articulo_id, x.art_descgen, x.unimed , x.Marca});

                    //RECORRO LA LISTA AGRUPADA
                    foreach (var categ in groupsForIterate)
                    {
                        indice = dataGridViewConsolidado.Rows.Add();
                        dataGridViewConsolidado.Rows[indice].Cells[(int)Col_GridDetalle.ARTICULO].Value = categ.Key.articulo_id;
                        dataGridViewConsolidado.Rows[indice].Cells[(int)Col_GridDetalle.DESCRIPCION].Value = categ.Key.art_descgen +" "+ categ.Key.Marca;
                        dataGridViewConsolidado.Rows[indice].Cells[(int)Col_GridDetalle.UNIDAD].Value = categ.Key.unimed;
                        //ES LA FORMA DE SUMAR LAS CANTIDADES DE UN MISMO PRODUCTO
                        dataGridViewConsolidado.Rows[indice].Cells[(int)Col_GridDetalle.CANTIDAD].Value = categ.Sum(x => x.cantidad).ToString().Replace(",", ".");
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
    }
}