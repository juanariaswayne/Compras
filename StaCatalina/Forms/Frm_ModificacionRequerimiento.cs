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
     public interface IAddItemModReq
    {
        void AddNewItemModReq(string cod, string descrip, string uniMed);
    }

     public partial class Frm_ModificacionRequerimiento : Plantilla, IAddItemModReq
    {
        #region Variables

        private enum Col_ReqCab
        {
            CODEMP = 0,
            USUARIO_AUTORIZA,
            EMPRESA,
            REQ_ID,
            FECHA,
            SECTOR_ID,
            SECTOR,
            OBSERVACIONES,
            ENTREGA_ID,
            LUGARENTREGA

        }

        private enum Col_ReqItem
        {
            BUSCADOR = 0,
            CODEMP,
            NROREQ,
            NROITEM,
            CODIGO,
            DESCRIPCION,
            UNIDAD,            
            CANTIDAD,
            FENTREGA


        }

        private enum col_Provisorios
        {
            ID=0,
            CODPROVISORIO,
            CODEMP,
            REQUERIMIENTO_ID,
            NROITEM,
            PENDIENTEENBEJERMAN,
            DESCRIPCION,
            PRESENTACION,
            UNIDAD,
            MARCA,
            EMBALAJE,
            CANTIDAD,


        }

        protected int _indexSeleccionado;
        protected List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        protected string _condPagoProveed = null;

        //VARIABLE PARA PASAR CON ENTER A OTRA COLUMNA
        private DataGridViewCell _celWasEndEdit;

        protected int REQ_ID;
        protected string _codemp;
        protected int NroProvisorio;

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        public int _Grabo { get; set; }

        CultureInfo culture = new CultureInfo("en-US");
        string _usuarioQueAutorizo;
        #endregion

        #region IAddItemModReq Members

        public void AddNewItemModReq(string cod, string descrip, string uniMed)
        {
            this.dataGridViewReqItems.Rows[_indexSeleccionado].Cells[(int)Col_ReqItem.CODIGO].Value = cod;
            this.dataGridViewReqItems.Rows[_indexSeleccionado].Cells[(int)Col_ReqItem.DESCRIPCION].Value = descrip;
            this.dataGridViewReqItems.Rows[_indexSeleccionado].Cells[(int)Col_ReqItem.UNIDAD].Value = uniMed;
            
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

        #region Funciones

        public Frm_ModificacionRequerimiento()
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

        private void TraeItemsPendientes()
        {

            try
            {
                BLL.Procedures.REQUERIMIENTOS_PARA_MODIFICAR _detalle = new BLL.Procedures.REQUERIMIENTOS_PARA_MODIFICAR();


                this.dataGridViewReqCab.Rows.Clear();
                int indice;
               
                var q = (dynamic)null;

                q = (from item in _detalle.ItemList(Clases.Usuario.UsuarioLogeado.Id_Sector,Clases.Usuario.UsuarioLogeado.id_usuario_Logeado)
                     where item.codemp == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString()
                     select item);

                foreach (Entities.Procedures.REQUERIMIENTOS_PARA_MODIFICAR item in q)
                {
                    indice = dataGridViewReqCab.Rows.Add();
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.EMPRESA].Value = item.codemp; //EMPRESA
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.REQ_ID].Value = item.requerimiento_id; //NRO OC
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.FECHA].Value = item.fecha.ToShortDateString();//FECHA
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.SECTOR_ID].Value = item.sectorrequerimiento_id;//PROVEEDOR
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.SECTOR].Value = item.descripcion;//PROVEEDOR
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.OBSERVACIONES].Value = (item.obs == string.Empty) ? "": item.obs;//PROVEEDOR
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.USUARIO_AUTORIZA].Value = item.usuarioautoriza; //USUARIO AUTORIZA
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.LUGARENTREGA].Value = item.Lugarentrega; //LUGAR DE ENTRERGA
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.ENTREGA_ID].Value = item.Entrega_id; //ENTREGA ID
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CargarItemsRequerimiento(int _index, int _nivelAutorizazion)
        {
            try
            {
                
                BLL.Procedures.TRAEREQUERIMIENTOITEM _item = new BLL.Procedures.TRAEREQUERIMIENTOITEM();

                this.dataGridViewReqItems.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.TRAEREQUERIMIENTOITEM item in _item.ItemList(dataGridViewReqCab.Rows[_index].Cells[(int)Col_ReqCab.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewReqCab.Rows[_index].Cells[(int)Col_ReqCab.REQ_ID].Value), _nivelAutorizazion))
                {
                    indice = dataGridViewReqItems.Rows.Add();
                    dataGridViewReqItems.Rows[indice].Cells[(int)Col_ReqItem.CODEMP].Value = item.codemp;//CODIGO EMPRESA
                    dataGridViewReqItems.Rows[indice].Cells[(int)Col_ReqItem.CODIGO].Value = item.articulo_id;//ARTICULO
                    dataGridViewReqItems.Rows[indice].Cells[(int)Col_ReqItem.NROREQ].Value = item.requerimiento_id; //OC
                    dataGridViewReqItems.Rows[indice].Cells[(int)Col_ReqItem.NROITEM].Value = item.nroitem; //NRO ITEM
                    dataGridViewReqItems.Rows[indice].Cells[(int)Col_ReqItem.DESCRIPCION].Value = item.art_descgen.ToString();//DESCRIP ARTICULO
                    dataGridViewReqItems.Rows[indice].Cells[(int)Col_ReqItem.UNIDAD].Value = item.unimed;//TRAE UNIMED                   
                    dataGridViewReqItems.Rows[indice].Cells[(int)Col_ReqItem.CANTIDAD].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD   
                    dataGridViewReqItems.Rows[indice].Cells[(int)Col_ReqItem.FENTREGA].Value = item.fechaentrega;//FECHA ENTREGA 

                }
                REQ_ID = Convert.ToInt32(dataGridViewReqCab.Rows[_index].Cells[(int)Col_ReqCab.REQ_ID].Value); // Salvo Orden de compra ID
                _codemp = dataGridViewReqCab.Rows[_index].Cells[(int)Col_ReqCab.CODEMP].Value.ToString(); // Salvo el CODEMP

                //TRAIGO LAS OBSERVACIOENS EN EL TEXT.. POR SI LA QUIERE MODIFICAR
                this.textBoxObs.Text = dataGridViewReqCab.Rows[_index].Cells[(int)Col_ReqCab.OBSERVACIONES].Value.ToString();

                //TRAIGO ARTICULOS PROVISORIOS SI LOS TIVIERA DE ESTE REQUERIMIENTO
                BLL.Tables.COMARTICULOSPROVISORIOS _provisorios = new BLL.Tables.COMARTICULOSPROVISORIOS();
                indice = 0;
                this.dataGridViewProvisorios.Rows.Clear();
                _provisorios.WhereParameter.Add(DAL.Tables.COMARTICULOSPROVISORIOS.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, _codemp);
                _provisorios.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, DAL.Tables.COMARTICULOSPROVISORIOS.ColumnEnum.requerimiento_id, DAL.SqlEnums.OperandEnum.Equal, REQ_ID);
                _provisorios.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, DAL.Tables.COMARTICULOSPROVISORIOS.ColumnEnum.pendienteEnBejerman, DAL.SqlEnums.OperandEnum.Equal, 1);

                foreach (Entities.Tables.COMARTICULOSPROVISORIOS itemprov in _provisorios.Items())
                {
                    indice = dataGridViewProvisorios.Rows.Add();
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.DESCRIPCION].Value = itemprov.DESCRIPCION;
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.PRESENTACION].Value = itemprov.PRESENTACION;
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.UNIDAD].Value = itemprov.UNIMED;
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.MARCA].Value = itemprov.MARCA;
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.EMBALAJE].Value = itemprov.EMBALAJE;
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.CANTIDAD].Value = itemprov.CANTIDAD;
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.ID].Value = itemprov.ID;
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.CODPROVISORIO].Value = itemprov.CODPROVISORIO;
                    NroProvisorio = itemprov.CODPROVISORIO; //GUARDO ESTE NUMERO PARA HACR MODIFICACIONES EN ESA TABLA
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.CODEMP].Value = itemprov.CODEMP;
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.REQUERIMIENTO_ID].Value = itemprov.REQUERIMIENTO_ID;
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.NROITEM].Value = itemprov.NROITEM;
                    dataGridViewProvisorios.Rows[indice].Cells[(int)col_Provisorios.PENDIENTEENBEJERMAN].Value = itemprov.PENDIENTEENBEJERMAN;
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
                for (int i = 0; i < this.dataGridViewReqItems.Rows.Count - 1; i++)
                 {
                     if (dataGridViewReqItems.Rows[i].Cells[(int)Col_ReqItem.CANTIDAD].Value == null || dataGridViewReqItems.Rows[i].Cells[(int)Col_ReqItem.CANTIDAD].Value == string.Empty)
                     {
                         MessageBox.Show("Debe Ingresar un valor en Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         return false;

                     }

                     if (Convert.ToDecimal(dataGridViewReqItems.Rows[i].Cells[(int)Col_ReqItem.CANTIDAD].Value) == 0)
                     {
                         MessageBox.Show("Debe Ingresar una Cantidad mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region Eventos

        private void Frm_ModificacionRequerimiento_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            this.Text = "Modificación de Requerimientos de la empresa: ";
            //FIN PERMISOS


            //calendar
            CalendarColumn col = new CalendarColumn();

            this.dataGridViewReqItems.Columns.Add(col);
            this.dataGridViewReqItems.Columns[(int)Col_ReqItem.FENTREGA].HeaderText = "Fecha Entrega";
            this.dataGridViewReqItems.Columns[(int)Col_ReqItem.FENTREGA].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewReqItems.AutoGenerateColumns = false;


            // cargo en una coleccion los productos por unica vez
            BLL.Procedures.H_ARTICULOSDEPOSITO _art = new BLL.Procedures.H_ARTICULOSDEPOSITO();
            _articulosItem = _art.ItemList();//le paso la colección de artículos

            this.CargarLugaresEntrega(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());

            TraeItemsPendientes();

        }

        private void dataGridViewOCCab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    this.comboBoxLugarEntrega.SelectedValue = dataGridViewReqCab.Rows[e.RowIndex].Cells[(int)Col_ReqCab.ENTREGA_ID].Value;


                    //VERIFICO SI ESTE REQ ESTA AUTORIZADO, DE SER ASÍ SOLO EL USUARIO QUE LO AUTORIZO LO PUEDE MODIFICAR
                    if (dataGridViewReqCab.Rows[e.RowIndex].Cells[(int)Col_ReqCab.USUARIO_AUTORIZA].Value != null)
                    {
                        _usuarioQueAutorizo = dataGridViewReqCab.Rows[e.RowIndex].Cells[(int)Col_ReqCab.USUARIO_AUTORIZA].Value.ToString(); //SALVO EL USUARIO QUE AUTORIZO
                    }
                    else
                    {
                        _usuarioQueAutorizo = string.Empty; //SALVO EL USUARIO QUE AUTORIZO
                    }

                    int _nivelAutorizacion;

                    if (_usuarioQueAutorizo.Trim() == string.Empty)
                    {
                        _nivelAutorizacion = 1; //NO ESTA AUTORIZADO
                        this.CargarItemsRequerimiento(e.RowIndex, _nivelAutorizacion); //ESTE REQ. NO ESTA AUTORIZADO. LA PUEDE MODIFICAR EL USUARIO CON PERMISOS
                        return;
                    }

                    if (_usuarioQueAutorizo.Trim() != string.Empty)
                    {
                        if (_usuarioQueAutorizo.Trim().ToUpper() == Clases.Usuario.UsuarioLogeado.usuario_Logeado.Trim().ToUpper())
                        {
                            _nivelAutorizacion = 2; //ESTA AUTORIZADO
                            this.CargarItemsRequerimiento(e.RowIndex, _nivelAutorizacion); //ESTE REQ NO ESTA AUTORIZADO. LO PUEDE MODIFICAR PORQUE EL USARIO LOGEADO ES EL MISMO QUE AUTORIZÓ
                            return;
                        }
                        else
                        {
                            this.dataGridViewReqItems.Rows.Clear();
                            dataGridViewProvisorios.Rows.Clear();
                            MessageBox.Show("Usted no puede modificar este Requerimiento, porque el mismo está autorizado, solo puede modifcarlo el usuario: " + _usuarioQueAutorizo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                    Frm_ProdModReq _prod = new Frm_ProdModReq();
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
            if (this.dataGridViewReqItems.IsCurrentCellDirty)
                this.dataGridViewReqItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewOCItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewReqItems.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_ReqItem.CANTIDAD)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }


        }

            

        private void dataGridViewOCItems_KeyDown(object sender, KeyEventArgs e)
        {
            //MUESTRO PRODUCTOS CUANDO LE DOY UN ENTER EN EL BOTON DE LA PRIMER COLUMNA
            var senderGrid = (DataGridView)sender;
            if (e.KeyCode == Keys.Enter && senderGrid.Columns[this.dataGridViewReqItems.CurrentCell.ColumnIndex].Index == (int)Col_ReqItem.BUSCADOR && this.dataGridViewReqItems.CurrentCell.RowIndex >= 0)
            {
                Frm_ProdModReq _prod = new Frm_ProdModReq();
                _prod.Articulos = _articulosItem;//le paso la colección de artículos
                _indexSeleccionado = this.dataGridViewReqItems.CurrentCell.RowIndex; //establezco el index
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

            if (_celWasEndEdit != null && dataGridViewReqItems.CurrentCell != null)
            {
                // if we are currently in the next line of last edit cell
                if (dataGridViewReqItems.CurrentCell.RowIndex == _celWasEndEdit.RowIndex + 1 &&
                    dataGridViewReqItems.CurrentCell.ColumnIndex == _celWasEndEdit.ColumnIndex)
                {
                    int iColNew;
                    int iRowNew = 0;
                    if (_celWasEndEdit.ColumnIndex >= dataGridViewReqItems.ColumnCount - 1)
                    {
                        iColNew = 0;
                        iRowNew = dataGridViewReqItems.CurrentCell.RowIndex;
                    }
                    else
                    {
                        iColNew = _celWasEndEdit.ColumnIndex + 1;
                        iRowNew = _celWasEndEdit.RowIndex;
                    }
                    dataGridViewReqItems.CurrentCell = dataGridViewReqItems[iColNew, iRowNew];
                }
            }
            _celWasEndEdit = null;
        }

        private void dataGridViewOCItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _celWasEndEdit = dataGridViewReqItems[e.ColumnIndex, e.RowIndex];
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (ValidarDatos())
                {
                    if (this.dataGridViewReqItems.Rows.Count < 2 && this.dataGridViewProvisorios.Rows.Count < 2)
                    {
                        MessageBox.Show("No esta permitido eliminar todos los Items de un requerimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    BLL.Tables.COMREQUERIMIENTOITEM _ReqItems = new BLL.Tables.COMREQUERIMIENTOITEM();
                    Entities.Tables.COMREQUERIMIENTOITEM _ReqItem = new Entities.Tables.COMREQUERIMIENTOITEM();
                    List<Entities.Tables.COMREQUERIMIENTOITEM> _reqItemsListAdd = new List<Entities.Tables.COMREQUERIMIENTOITEM>();

                    _Grabo = 0;

                    int _nroItem = 1;
                    //POR SI MODIFICO LA DIRECCION DE ENTREGA
                    int _entrega_id = Convert.ToInt32(dataGridViewReqCab.Rows[dataGridViewReqCab.CurrentRow.Index].Cells[(int)Col_ReqCab.ENTREGA_ID].Value.ToString());


                    for (int i = 0; i < this.dataGridViewReqItems.Rows.Count - 1; i++)
                    {
                        _ReqItem = new Entities.Tables.COMREQUERIMIENTOITEM();
                        _ReqItem.CODEMP = _codemp;
                        _ReqItem.REQUERIMIENTO_ID = REQ_ID;
                        _ReqItem.NROITEM = _nroItem;
                        _ReqItem.ARTICULO_ID = dataGridViewReqItems.Rows[i].Cells[(int)Col_ReqItem.CODIGO].Value.ToString();
                        _ReqItem.UNIMED = dataGridViewReqItems.Rows[i].Cells[(int)Col_ReqItem.UNIDAD].Value.ToString();
                        _ReqItem.CANTIDAD = Convert.ToDecimal(dataGridViewReqItems.Rows[i].Cells[(int)Col_ReqItem.CANTIDAD].Value.ToString(),culture);
                        _ReqItem.NIVELAUT_ID = 1;
                        _ReqItem.FECHAENTREGA = Convert.ToDateTime(dataGridViewReqItems.Rows[i].Cells[(int)Col_ReqItem.FENTREGA].Value);
                        _reqItemsListAdd.Add(_ReqItem);
                        _nroItem++;
                        _Grabo = 1;
                    }

                    string _obs = this.textBoxObs.Text;

                    //AHORA VERIFICO SI EXISTEN ARTICULOS PROVISORIOS
                    List<Entities.Tables.COMARTICULOSPROVISORIOS> _ItemsProvisorios = new List<Entities.Tables.COMARTICULOSPROVISORIOS>();
                    Entities.Tables.COMARTICULOSPROVISORIOS _ItemProvis = new Entities.Tables.COMARTICULOSPROVISORIOS();
                    for (int i = 0; i < this.dataGridViewProvisorios.Rows.Count - 1; i++)
                    {
                        if (dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.DESCRIPCION].Value != null && dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.DESCRIPCION].Value != string.Empty && dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.CANTIDAD].Value != null && dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.CANTIDAD].Value != string.Empty)
                        {
                            if (dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.UNIDAD].Value == string.Empty || dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.UNIDAD].Value == null)
                            {
                                MessageBox.Show("Debe ingresar unidad de medida, para los artículos que no estén en Bejerman", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; //SALGO DEL PROCESO.......
                            }
                            else
                            {
                                _ItemProvis = new Entities.Tables.COMARTICULOSPROVISORIOS();
                                _ItemProvis.DESCRIPCION = dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.DESCRIPCION].Value.ToString();
                                _ItemProvis.PRESENTACION = (dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.PRESENTACION].Value == string.Empty || dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.PRESENTACION].Value == null) ? string.Empty : dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.PRESENTACION].Value.ToString();
                                _ItemProvis.UNIMED = dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.UNIDAD].Value.ToString();
                                _ItemProvis.MARCA = (dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.MARCA].Value == string.Empty || dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.MARCA].Value == null) ? string.Empty : dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.MARCA].Value.ToString();
                                _ItemProvis.EMBALAJE = (dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.EMBALAJE].Value == string.Empty || dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.EMBALAJE].Value == null) ? string.Empty : dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.EMBALAJE].Value.ToString();
                                _ItemProvis.CANTIDAD = Convert.ToDecimal(dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.CANTIDAD].Value.ToString(), culture);

                                _ItemsProvisorios.Add(_ItemProvis);
                            }



                        }

                    }
                    //FIN ARTICULOS PROVISORIOS

                    _ReqItems.RemoveItem(_codemp, REQ_ID, _reqItemsListAdd, _ItemsProvisorios, _obs,_entrega_id);
                     MessageBox.Show("Los cambios se realizaron correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     dataGridViewReqItems.Rows.Clear();
                    this.textBoxObs.Text = string.Empty;
                    dataGridViewProvisorios.Rows.Clear();
                     TraeItemsPendientes();


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
            this.Close();
        }
    }
}
