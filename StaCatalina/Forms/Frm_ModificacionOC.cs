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
    public interface IAddItemModOC
    {
        void AddNewItemModOC(string cod, string descrip, string uniMed);
    }
    public partial class Frm_ModificacionOC : StaCatalina.Plantilla, IAddItemModOC
    {
        #region Variables

        private enum Col_OCCab
        {
            CODEMP = 0,
            USUARIO_AUTORIZA,
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
            BUSCADOR = 0,
            CODEMP,
            NROORDENCOMPRA,
            NROITEM,
            CODIGO,
            DESCRIPCION,
            UNIDAD,
            PRECIO,
            CANTIDAD,
            FENTREGA
            
            
        }

        protected int _indexSeleccionado;
        protected List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        protected string _condPagoProveed = null;
        
        //VARIABLE PARA PASAR CON ENTER A OTRA COLUMNA
        private DataGridViewCell _celWasEndEdit;

        protected int OC_ID;
        protected string _codemp;

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        int _nivelAutorizacion;

        public int _Grabo { get; set; }

        CultureInfo culture = new CultureInfo("en-US");
        string _usuarioQueAutorizo;

        #endregion

        #region Funciones

        public Frm_ModificacionOC()
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
                this.dataGridViewOCCab.Rows.Clear();
                int indice;

                BLL.Procedures.ORDENCOMPRA_PARA_MODIFICAR _detalle = new BLL.Procedures.ORDENCOMPRA_PARA_MODIFICAR();

                this.dataGridViewOCCab.Rows.Clear();
                //FILTRO LAS OC DE LA EMPRESA LOGEADA Y ME DEVUELVE LAS ORDENES QUE ESTE USUARIO AUTORIZO
                var q = (dynamic)null;

                q = (from item in _detalle.ItemList(1) // 1 = OPRDEN DE COMPRA DIRECTA
                     where item.codemp == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString()
                     select item);

                foreach (Entities.Procedures.ORDENCOMPRA_PARA_MODIFICAR item in q)
                {
                    indice = dataGridViewOCCab.Rows.Add();
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.EMPRESA].Value = item.codemp; //EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.NRO_OC].Value = item.ordencompra_id; //NRO OC
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.FECHA].Value = item.fecha.ToShortDateString();//FECHA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.PROVEEDOR].Value = item.razonsocial;//PROVEEDOR
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.OBSERVACIONES].Value = item.obs;//PROVEEDOR
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.USUARIO_AUTORIZA].Value = item.usuarioautoriza;//usuario autoriza
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

        //private int TraeCondPagoProveed
        //{


        //}

        private bool ValidarDatos()
        {
            try
            {

                

               
                for (int i = 0; i < this.dataGridViewOCItems.Rows.Count - 1; i++)
                {
                    if (dataGridViewOCItems.Rows[i].Cells[(int)Col_OCItem.CANTIDAD].Value == null || dataGridViewOCItems.Rows[i].Cells[(int)Col_OCItem.CANTIDAD].Value == string.Empty)
                    {
                        MessageBox.Show("Debe Ingresar un valor en Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                        
                    }

                    if (Convert.ToDecimal(dataGridViewOCItems.Rows[i].Cells[(int)Col_OCItem.CANTIDAD].Value) == 0)
                    {
                        MessageBox.Show("Debe Ingresar una Cantidad mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (dataGridViewOCItems.Rows[i].Cells[(int)Col_OCItem.PRECIO].Value == null || dataGridViewOCItems.Rows[i].Cells[(int)Col_OCItem.PRECIO].Value == string.Empty)
                    {
                        MessageBox.Show("Debe Ingresar un valor en precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                    if (Convert.ToDecimal(dataGridViewOCItems.Rows[i].Cells[(int)Col_OCItem.PRECIO].Value) < 0)
                    {
                        MessageBox.Show("El precio debe ser mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
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

        private void CargarItemsOC(int _index, int _nivelAutorizacion)
        {
            try
            {
                BLL.Procedures.TRAEORDENCOMPRAITEM _item = new BLL.Procedures.TRAEORDENCOMPRAITEM();

                this.dataGridViewOCItems.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.TRAEORDENCOMPRAITEM item in _item.ItemList(dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.NRO_OC].Value), _nivelAutorizacion))
                {
                    indice = dataGridViewOCItems.Rows.Add();
                    dataGridViewOCItems.Rows[indice].Cells[(int)Col_OCItem.CODEMP].Value = item.codemp;//CODIGO EMPRESA
                    dataGridViewOCItems.Rows[indice].Cells[(int)Col_OCItem.CODIGO].Value = item.articulo_id;//ARTICULO
                    dataGridViewOCItems.Rows[indice].Cells[(int)Col_OCItem.NROORDENCOMPRA].Value = item.ordencompra_id; //OC
                    dataGridViewOCItems.Rows[indice].Cells[(int)Col_OCItem.NROITEM].Value = item.nroitem; //NRO ITEM
                    dataGridViewOCItems.Rows[indice].Cells[(int)Col_OCItem.DESCRIPCION].Value = item.art_descgen.ToString();//DESCRIP ARTICULO
                    dataGridViewOCItems.Rows[indice].Cells[(int)Col_OCItem.UNIDAD].Value = item.unimed;//TRAE UNIMED
                    dataGridViewOCItems.Rows[indice].Cells[(int)Col_OCItem.PRECIO].Value = item.precio.ToString().Replace(",", ".");//CANTIDAD;//CANTIDAD 
                    dataGridViewOCItems.Rows[indice].Cells[(int)Col_OCItem.CANTIDAD].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD;//CANTIDAD   
                    dataGridViewOCItems.Rows[indice].Cells[(int)Col_OCItem.FENTREGA].Value = item.fechaentrega;//FECHA ENTREGA 
                    

                }
                OC_ID = Convert.ToInt32(dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.NRO_OC].Value); // Salvo Orden de compra ID
                _codemp = dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.CODEMP].Value.ToString(); // Salvo el CODEMP
                //TRAIGO LAS OBSERVACIOENS EN EL TEXT.. POR SI LA QUIERE MODIFICAR
                this.textBoxObs.Text = dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.OBSERVACIONES].Value.ToString();
                this.comboBoxProveed.Text = dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.PROVEEDOR].Value.ToString();
                this.comboBoxLugarEntrega.SelectedValue = Convert.ToInt32(dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.SECTORENTREGA_ID].Value);//SECTOR DE ENTREGA
                this.checkBoxdiaria.Checked = (Convert.ToInt32(dataGridViewOCCab.Rows[_index].Cells[(int)Col_OCCab.PEDIDO_NO_PREVISTO].Value) == 0) ? false:true;
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
        private void CargarLugaresEntrega(string _CodEmp)
        {
            try
            {
                //también cargo los RUBROS por única vez
                BLL.Procedures.TRAELUGARESENTREGA _rubro = new BLL.Procedures.TRAELUGARESENTREGA();
                List<Entities.Procedures.TRAELUGARESENTREGA> _rubroItem = new List<Entities.Procedures.TRAELUGARESENTREGA>();
                Entities.Procedures.TRAELUGARESENTREGA _itemSeleccion = new Entities.Procedures.TRAELUGARESENTREGA();

                _rubroItem = _rubro.ItemList(_CodEmp);//le paso la colección de Lugares

                //Limpia el combo
                this.comboBoxLugarEntrega.SuspendLayout();
                this.comboBoxLugarEntrega.DataSource = null;
                this.comboBoxLugarEntrega.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione un lugar>";
                _itemSeleccion.lugar_id = 0;
                _rubroItem.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxLugarEntrega.DisplayMember = BLL.Tables.COMLUGARENTREGA.ColumnNames.DESCRIPCION;
                this.comboBoxLugarEntrega.ValueMember = BLL.Tables.COMLUGARENTREGA.ColumnNames.LUGAR_ID;
                this.comboBoxLugarEntrega.DataSource = _rubroItem;
                this.comboBoxLugarEntrega.SelectedIndex = 0;

                this.comboBoxLugarEntrega.ResumeLayout();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        #endregion

        #region IAddItemModOC Members

        public void AddNewItemModOC(string cod, string descrip, string uniMed)
        {
            this.dataGridViewOCItems.Rows[_indexSeleccionado].Cells[(int)Col_OCItem.CODIGO].Value = cod;
            this.dataGridViewOCItems.Rows[_indexSeleccionado].Cells[(int)Col_OCItem.DESCRIPCION].Value = descrip;
            this.dataGridViewOCItems.Rows[_indexSeleccionado].Cells[(int)Col_OCItem.UNIDAD].Value = uniMed;
            this.dataGridViewOCItems.CurrentCell = this.dataGridViewOCItems.CurrentRow.Cells[(int)Col_OCItem.PRECIO];
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
      
               
        #region Eventos

        private void Frm_ModificacionOC_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();       

            //FIN PERMISOS


            //calendar
            CalendarColumn col = new CalendarColumn();

            this.dataGridViewOCItems.Columns.Add(col);
            this.dataGridViewOCItems.Columns[(int)Col_OCItem.FENTREGA].HeaderText = "Fecha Entrega";
            this.dataGridViewOCItems.Columns[(int)Col_OCItem.FENTREGA].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewOCItems.AutoGenerateColumns = false;
            

            // cargo en una coleccion los productos por unica vez
            BLL.Procedures.H_ARTICULOSDEPOSITO _art = new BLL.Procedures.H_ARTICULOSDEPOSITO();
            _articulosItem = _art.ItemList();//le paso la colección de artículos
            this.Text = "Modificación Orden de Compra Directa Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();

            TraeOCPendientes();
            CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);

            CargarLugaresEntrega(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);
        }

        private void dataGridViewOCCab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    //VERIFICO SI ESTA OC ESTA AUTORIZADA, DE SER ASÍ SOLO EL USUARIO QUE LA AUTORIZO LA PUEDE MODIFICAR
                    if (dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.USUARIO_AUTORIZA].Value != null)
                    {
                        _usuarioQueAutorizo = dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.USUARIO_AUTORIZA].Value.ToString(); //SALVO EL USUARIO QUE AUTORIZO
                    }
                    else
                    {
                        _usuarioQueAutorizo = string.Empty; //SALVO EL USUARIO QUE AUTORIZO
                    }

                    

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
                            this.dataGridViewOCItems.Rows.Clear();
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

        private void dataGridViewOCItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    Frm_ProdModOc _prod = new Frm_ProdModOc();
                    _prod.Articulos = _articulosItem;//le paso la colección de artículos
                    _indexSeleccionado = e.RowIndex; //establezco el index
                    _prod.MdiParent = this.MdiParent; // esto porque estoy utiliando MDI
                    _prod.Opener = this; // es para el formulario hijo
                    _prod.Show();
                    _prod.StartPosition = FormStartPosition.CenterScreen;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        
        private void dataGridViewOCItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewOCItems.IsCurrentCellDirty)
                this.dataGridViewOCItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        
        private void dataGridViewOCItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewOCItems.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_OCItem.CANTIDAD)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }

        }

        private void dataGridViewOCItems_KeyDown(object sender, KeyEventArgs e)
        {
            //MUESTRO PRODUCTOS CUANDO LE DOY UN ENTER EN EL BOTON DE LA PRIMER COLUMNA
            var senderGrid = (DataGridView)sender;
            if (e.KeyCode == Keys.Enter && senderGrid.Columns[this.dataGridViewOCItems.CurrentCell.ColumnIndex].Index == (int)Col_OCItem.BUSCADOR && this.dataGridViewOCItems.CurrentCell.RowIndex >= 0)
            {
                Frm_ProdModOc _prod = new Frm_ProdModOc();
                _prod.Articulos = _articulosItem;//le paso la colección de artículos
                _indexSeleccionado = this.dataGridViewOCItems.CurrentCell.RowIndex; //establezco el index
                _prod.MdiParent = this.MdiParent; // esto porque estoy utiliando MDI
                _prod.Opener = this; // es para el formulario hijo
                _prod.Show();
                _prod.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void dataGridViewOCItems_SelectionChanged(object sender, EventArgs e)
        {
            //PASO CON ENTER A LA OTRA COLUMNA
            if (MouseButtons != 0) return;

            if (_celWasEndEdit != null && dataGridViewOCItems.CurrentCell != null)
            {
                // if we are currently in the next line of last edit cell
                if (dataGridViewOCItems.CurrentCell.RowIndex == _celWasEndEdit.RowIndex + 1 &&
                    dataGridViewOCItems.CurrentCell.ColumnIndex == _celWasEndEdit.ColumnIndex)
                {
                    int iColNew;
                    int iRowNew = 0;
                    if (_celWasEndEdit.ColumnIndex >= dataGridViewOCItems.ColumnCount - 1)
                    {
                        iColNew = 0;
                        iRowNew = dataGridViewOCItems.CurrentCell.RowIndex;
                    }
                    else
                    {
                        iColNew = _celWasEndEdit.ColumnIndex + 1;
                        iRowNew = _celWasEndEdit.RowIndex;
                    }
                    dataGridViewOCItems.CurrentCell = dataGridViewOCItems[iColNew, iRowNew];
                }
            }
            _celWasEndEdit = null;
        }

        private void dataGridViewOCItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _celWasEndEdit = dataGridViewOCItems[e.ColumnIndex, e.RowIndex];
        }
       
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    if (this.dataGridViewOCItems.Rows.Count < 2)
                    {
                        MessageBox.Show("No esta permitido eliminar todos los Items de una orden de Compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    BLL.Tables.COMORDENCOMPRAITEM _OCItems = new BLL.Tables.COMORDENCOMPRAITEM();
                    Entities.Tables.COMORDENCOMPRAITEM _OCItem = new Entities.Tables.COMORDENCOMPRAITEM();
                    List<Entities.Tables.COMORDENCOMPRAITEM> _OCItemsListAdd = new List<Entities.Tables.COMORDENCOMPRAITEM>();

                    _Grabo = 0;
               
                   

                    int _nroItem = 1;
                    for (int i = 0; i < this.dataGridViewOCItems.Rows.Count - 1; i++)
                    {
                        _OCItem = new Entities.Tables.COMORDENCOMPRAITEM();
                        _OCItem.CODEMP = _codemp;
                        _OCItem.ORDENCOMPRA_ID = OC_ID;
                        _OCItem.NROITEM = _nroItem;
                        _OCItem.ARTICULO_ID = dataGridViewOCItems.Rows[i].Cells[(int)Col_OCItem.CODIGO].Value.ToString();
                        _OCItem.UNIMED = dataGridViewOCItems.Rows[i].Cells[(int)Col_OCItem.UNIDAD].Value.ToString();
                        _OCItem.CANTIDAD = Convert.ToDecimal(dataGridViewOCItems.Rows[i].Cells[(int)Col_OCItem.CANTIDAD].Value,culture);
                        _OCItem.PRECIO = Convert.ToDecimal(dataGridViewOCItems.Rows[i].Cells[(int)Col_OCItem.PRECIO].Value,culture);
                        _OCItem.NIVELAUT_ID = _nivelAutorizacion;
                        _OCItem.FECHAENTREGA = Convert.ToDateTime(dataGridViewOCItems.Rows[i].Cells[(int)Col_OCItem.FENTREGA].Value);
                       
                        _OCItemsListAdd.Add(_OCItem);
                        _nroItem++;
                        _Grabo = 1;
                    }
                    string _obs = this.textBoxObs.Text;
                    string _Proveed = (this.comboBoxProveed.SelectedValue == null) ? "0" : this.comboBoxProveed.SelectedValue.ToString(); 
                    bool _pedidoDiario = (this.checkBoxdiaria.Checked) ? true : false;
                    int _sectorEntrega = Convert.ToInt32(this.comboBoxLugarEntrega.SelectedValue);

                    if (this.comboBoxProveed.SelectedIndex <= 0 || _Proveed == "0")
                    {
                        MessageBox.Show("Debe seleccionar un Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _OCItems.RemoveItem(_codemp, OC_ID, _OCItemsListAdd, _obs, _Proveed, _pedidoDiario, _sectorEntrega);


                    if (_Grabo == 1)
                    {

                        MessageBox.Show("Los cambios se realizaron correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewOCItems.Rows.Clear();
                        this.textBoxObs.Text = string.Empty;
                        this.comboBoxProveed.SelectedIndex = 0;
                        TraeOCPendientes();

                    }
                    else
                    {
                        MessageBox.Show("Error al grabar Orden de Compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewOCCab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
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
    }
}
