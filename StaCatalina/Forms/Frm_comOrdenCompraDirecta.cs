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
    public interface IAddItemOCDirecta
    {
        void AddNewItemOCDirecta(string cod, string descrip, string uniMed);
    }
    //StaCatalina.Plantilla
    public partial class Frm_comOrdenCompraDirecta : Plantilla, IAddItemOCDirecta
    {
        #region Calendar2
            private DataGridView dataGridView1 = new DataGridView();

        #endregion

        #region Variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;

            private enum Col_Detalle
            {
                CODIGO=0,
                DESCRIPCION,
                UNIDAD,
                PRECIO,
                CANTIDAD,
                MARCA,
                FENTREGA
            }
            protected int _indexSeleccionado;
            protected  List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        List<Entities.Procedures.TRAEMARCAARTICULOS> _itemsMarca = new List<Entities.Procedures.TRAEMARCAARTICULOS>();
        protected string _condPagoProveed = null;

        CultureInfo culture = new CultureInfo("en-US");
        //VARIABLE PARA PASAR CON ENTER A OTRA COLUMNA
        private DataGridViewCell _celWasEndEdit;

        #endregion
        #region Funciones
            public Frm_comOrdenCompraDirecta()
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

                if (this.comboBoxLugarEntrega.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxLugarEntrega, "Debe seleccionar una dirección de entrega");
                    this.comboBoxLugarEntrega.Focus();
                    return false;
                }

                //if (this.comboBoxrubro.SelectedIndex == 0)
                //{
                //    this.errorProvider1.SetError(this.comboBoxrubro, "Debe seleccionar un sub rubro");
                //    this.comboBoxrubro.Focus();
                //    return false;
                //}

                //for (int i = 0; i < this.dataGridViewOCDirecta.Rows.Count - 1; i++)
                //{
                //    if (dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value == null || dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value == string.Empty)
                //    {
                //        MessageBox.Show("Debe Ingresar un valor en Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return false;

                //    }

                //    if (Convert.ToDecimal(dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value) == 0)
                //    {
                //        MessageBox.Show("Debe Ingresar una Cantidad mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return false;
                //    }

                //    if (dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value == null || dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value == string.Empty)
                //    {
                //        MessageBox.Show("Debe Ingresar un valor en precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return false;
                //    }


                //    if (Convert.ToDecimal(dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value) < 0)
                //    {
                //        MessageBox.Show("El precio debe ser mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return false;
                //    }
                //}

                return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


            }
        private void CargarSubRubros()
        {
            try
            {
                //también cargo los SUB RUBROS por única vez, SOLO TRAIGO LOS QUE EL USUARIO PUEDE VER
                BLL.Procedures.TRAESUBRUBROSDELUSUARIO _rubro = new BLL.Procedures.TRAESUBRUBROSDELUSUARIO();
                List<Entities.Procedures.TRAESUBRUBROSDELUSUARIO> _rubroItem = new List<Entities.Procedures.TRAESUBRUBROSDELUSUARIO>();
                Entities.Procedures.TRAESUBRUBROSDELUSUARIO _itemSeleccion = new Entities.Procedures.TRAESUBRUBROSDELUSUARIO();

                _rubroItem = _rubro.ItemList(Clases.Usuario.UsuarioLogeado.id_usuario_Logeado);//le paso la colección de rubros

                //Limpia el combo
                this.comboBoxrubro.SuspendLayout();
                this.comboBoxrubro.DataSource = null;
                this.comboBoxrubro.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.da2_desc = "<Seleccione un Sub Rubro>";
                _itemSeleccion.artda2_cod = "0";
                _rubroItem.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxrubro.DisplayMember = BLL.Procedures.TRAESUBRUBROSDELUSUARIO.ColumnNames.DA2_DESC;
                this.comboBoxrubro.ValueMember = BLL.Procedures.TRAESUBRUBROSDELUSUARIO.ColumnNames.ARTDA2_COD;
                this.comboBoxrubro.DataSource = _rubroItem;
                this.comboBoxrubro.SelectedIndex = 0;

                this.comboBoxrubro.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarRubros()
        {
            try
            {
                //también cargo los RUBROS por única vez
                BLL.Procedures.RUBROARTICULOS _rubro = new BLL.Procedures.RUBROARTICULOS();
                List<Entities.Procedures.RUBROARTICULOS> _rubroItem = new List<Entities.Procedures.RUBROARTICULOS>();
                Entities.Procedures.RUBROARTICULOS _itemSeleccion = new Entities.Procedures.RUBROARTICULOS();

                _rubroItem = _rubro.ItemList();//le paso la colección de rubros

                //Limpia el combo
                this.comboBoxRubro2.SuspendLayout();
                this.comboBoxRubro2.DataSource = null;
                this.comboBoxRubro2.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.da1_desc = "<Seleccione un Rubro>";
                _itemSeleccion.da1_cod = "0";
                _rubroItem.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxRubro2.DisplayMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_DESC;
                this.comboBoxRubro2.ValueMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_COD;
                this.comboBoxRubro2.DataSource = _rubroItem;
                this.comboBoxRubro2.SelectedIndex = 0;

                this.comboBoxRubro2.ResumeLayout();



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

        private void CalculaImporte()
        {
            try
            {
                //CALUCLO PRECIO x CANTIDAD
                labelImporteOC.Text = ("0").ToString(culture);
                decimal _importeTotal = 0;
                for (int i = 0; i < this.dataGridViewOCDirecta.Rows.Count; i++)
                {
                
                        //VERIFICO QUE PRECIO Y CANTIDAD SEAN VALORES VALIDOS
                        if (dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value != null && dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != null && dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value != string.Empty && dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != string.Empty)
                        {
                            decimal _precio = Convert.ToDecimal(dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value.ToString(), culture);
                            decimal _cantidad = Convert.ToDecimal(dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value.ToString(), culture);

                            _importeTotal = Convert.ToDecimal(_importeTotal + (_precio * _cantidad), culture);

                        }


                }
                labelImporteOC.Text = "$ " + _importeTotal.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        #endregion

        #region IAddItemOCDirecta Members

        public void AddNewItemOCDirecta(string cod, string descrip, string uniMed)
        {
            this.dataGridViewOCDirecta.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.CODIGO].Value = cod;
            this.dataGridViewOCDirecta.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.DESCRIPCION].Value = descrip;
            this.dataGridViewOCDirecta.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.UNIDAD].Value = uniMed;
            this.dataGridViewOCDirecta.CurrentCell = this.dataGridViewOCDirecta.CurrentRow.Cells[(int)Col_Detalle.PRECIO];
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
            private void Frm_comOrdenCompraDirecta_Load(object sender, EventArgs e)
            {
                try
                {
                    MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                    menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                    this.OperacionesDelUsuario();

                    Clases.Empresa.CargarEmpresas(comboBoxcodEmp);
                    // cargo en una coleccion los productos por unica vez
                    BLL.Procedures.H_ARTICULOSDEPOSITO _art = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                    _articulosItem = _art.ItemList();//le paso la colección de artículos

                    CargarRubros();
                    CargarSubRubros();

                    CargarLugaresEntrega(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);
                    TraerMarcasArticulos();

                    comboBoxcodEmp.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();

                //calendar
                CalendarColumn col = new CalendarColumn();

                    this.dataGridViewOCDirecta.Columns.Add(col);
                    this.dataGridViewOCDirecta.Columns[(int)Col_Detalle.FENTREGA].HeaderText = "Fecha Entrega";
                    this.dataGridViewOCDirecta.Columns[(int)Col_Detalle.FENTREGA].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    //calendar

                  
                   CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
                  

                    //cargo proveedores


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            private void dataGridViewOCDirecta_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                //try
                //{
                //    var senderGrid = (DataGridView)sender;

                //    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                //        e.RowIndex >= 0)
                //    {
                //        Frm_ProdOCDirecta _prod = new Frm_ProdOCDirecta();
                //        _prod.Articulos = _articulosItem;//le paso la colección de artículos
                //        //paso los rubros
                //        _prod.Rubros = _rubrositem;
                //        _indexSeleccionado = e.RowIndex; //establezco el index
                //        _prod.MdiParent = this.MdiParent; // esto porque estoy utiliando MDI
                //        _prod.Opener = this; // es para el formulario hijo
                //        _prod.Show();
                //        _prod.StartPosition = FormStartPosition.CenterScreen;

                //    }

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}
            }

            private void comboBoxcodEmp_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (comboBoxcodEmp.SelectedIndex > 0)
                {
                    //SOLO CAMBIO DE EMPRESA SI ESTA AUTORIZADA
                    string _emp = this.comboBoxcodEmp.SelectedValue.ToString();
                    int _index = this.comboBoxcodEmp.SelectedIndex;
                    if (Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != _emp.Trim() && Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != "AMBA")
                    {
                        MessageBox.Show("Ud. no está autorizado a operar con esta empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.comboBoxcodEmp.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                        return;
                    }
                    else
                    {
                        CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
                        CargarLugaresEntrega(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());

                    }
                }
             }

                private void dataGridViewOCDirecta_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewOCDirecta.IsCurrentCellDirty)
                    dataGridViewOCDirecta.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

                private void dataGridViewOCDirecta_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
            {
                int iColumn = dataGridViewOCDirecta.CurrentCell.ColumnIndex;
                if (iColumn == (int)Col_Detalle.CANTIDAD)
                {
                    TextBox txt = e.Control as TextBox;
                    txt.KeyPress += OnlyNumbers_KeyPress;
                }
            }

            private void toolStripButtonNew_Click(object sender, EventArgs e)
            {
                dataGridViewOCDirecta.Rows.Clear();
                this.comboBoxcodEmp.SelectedIndex = 0;
                this.comboBoxrubro.SelectedIndex = 0;
                this.textBoxObs.Text = string.Empty;
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
                       // BLL.Tables.COMORDENCOMPRAITEM _OCIte = new BLL.Tables.COMORDENCOMPRAITEM();
                        List<Entities.Tables.COMORDENCOMPRAITEM> _ItemsCab = new List<Entities.Tables.COMORDENCOMPRAITEM>();
                        CultureInfo culture = new CultureInfo("en-US");

                        _OCCabecera.FECHA = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //FECHA
                        _OCCabecera.PROVEED_ID = this.comboBoxProveed.SelectedValue.ToString(); // PROVEEDOR
                        _OCCabecera.ESTADO_ID = 1; //Ojo ver que valor se envia despues  //ESTADO
                        _OCCabecera.TIPOOC_ID = 1; //OJO COLOCAR EL VALOR REAL DE ORDEN DE COMPRA DIRECTA
                        _OCCabecera.MODIFICACOSTO = (this.radioButtonNo.Checked) ? 0 : 1; //MODIFICA COSTO
                        _OCCabecera.CODEMP = this.comboBoxcodEmp.SelectedValue.ToString(); //EMPRESA PARA LA CUAL SE HACE LA OC
                        _OCCabecera.CONDICIONPAGO_ID = _condPagoProveed; // CONDICIOND DE PAGO

                        _OCCabecera.OBS = this.textBoxObs.Text.Trim();

                        _OCCabecera.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                        _OCCabecera.PEDIDODIARIO = (this.checkBoxdiaria.Checked) ? true : false;
                        if (this.comboBoxLugarEntrega.SelectedIndex > 0)
                        {
                            _OCCabecera.SECTORENTREGA_ID = Convert.ToInt32(this.comboBoxLugarEntrega.SelectedValue);//SECTOR DE ENTREGA
                        }

                        DateTime _fechaEntrega;
                 
                        for (int i = 0; i < this.dataGridViewOCDirecta.Rows.Count; i++)
                        {
                            if (dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != string.Empty && dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != null && dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value != string.Empty && dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value != null)
                            {
                                _OCItem = new Entities.Tables.COMORDENCOMPRAITEM();

                                //_ReqItem.COMEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;                                                
                                _OCItem.ARTICULO_ID = dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.CODIGO].Value.ToString();
                                _OCItem.UNIMED = dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.UNIDAD].Value.ToString();
                                _OCItem.PRECIO = Convert.ToDecimal(dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value.ToString(), culture);
                                _OCItem.CANTIDAD = Convert.ToDecimal(dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value.ToString(), culture);
                                
                                _fechaEntrega = Convert.ToDateTime(Convert.ToDateTime(dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.FENTREGA].Value));
                                if (_fechaEntrega == DateTime.MinValue)
                                {
                                    _OCItem.FECHAENTREGA = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                }
                                else
                                {
                                    _OCItem.FECHAENTREGA = Convert.ToDateTime(Convert.ToDateTime(dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.FENTREGA].Value));
                                }
                                _OCItem.NIVELAUT_ID = 1; //ojo ver como se envia despues
                                _OCItem.CODEMP = this.comboBoxcodEmp.SelectedValue.ToString(); //EMPRESA PARA LA CUAL SE HACE LA OC
                                 //VERIFICO SI SELECCIONO UNA MARCA
                                if (dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.MARCA].EditedFormattedValue != null && dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.MARCA].Value != "0" && dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.MARCA].Value != "<Sin Definir>")
                                {
                                _OCItem.MARCA = dataGridViewOCDirecta.Rows[i].Cells[(int)Col_Detalle.MARCA].EditedFormattedValue.ToString();
                                }
                                _ItemsCab.Add(_OCItem); //Meto en la coleccion todos los elementos de la grilla
                            }                                 
                        }

                        if (_ItemsCab.Count > 0)
                        {
                            //LLAMO A LA FUNCION QUE GUARDA CABECERA E ITEMS
                            int _NroOC;
                            _NroOC = _OCCab.AddItem(_OCCabecera, _ItemsCab);
                            if (_NroOC > 0)
                            {
                                MessageBox.Show("Se generó la orden de compra Nro:" + " " + _NroOC, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridViewOCDirecta.Rows.Clear();
                                this.textBoxObs.Text = "";
                                this.comboBoxProveed.SelectedIndex = 0;
                                this.comboBoxrubro.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Error al grabar Orden de Compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Para todos los items seleccionados, debe ingresar un precio y cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
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
                    if (this.comboBoxProveed.SelectedIndex > 0 )
                    {
                        //recupera condicion de pago
                        BLL.Procedures.H_CONDPAGOPROVEED _condPago = new BLL.Procedures.H_CONDPAGOPROVEED();
                        string _codEmp;

                        _codEmp = this.comboBoxcodEmp.SelectedValue.ToString();
                    
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

            private void dataGridViewOCDirecta_KeyDown(object sender, KeyEventArgs e)
            {

                ////MUESTRO PRODUCTOS CUANDO LE DOY UN ENTER EN EL BOTON DE LA PRIMER COLUMNA
                //var senderGrid = (DataGridView)sender;
                //if (e.KeyCode == Keys.Enter && senderGrid.Columns[this.dataGridViewOCDirecta.CurrentCell.ColumnIndex].Index == (int)Col_Detalle.BUSCADOR && this.dataGridViewOCDirecta.CurrentCell.RowIndex >= 0)
                //{
                //    Frm_ProdOCDirecta _prod = new Frm_ProdOCDirecta();
                //    _prod.Articulos = _articulosItem;//le paso la colección de artículos
                //    //paso los rubros
                //    _prod.Rubros = _rubrositem;
                //    _indexSeleccionado = this.dataGridViewOCDirecta.CurrentCell.RowIndex; //establezco el index
                //    _prod.MdiParent = this.MdiParent; // esto porque estoy utiliando MDI
                //    _prod.Opener = this; // es para el formulario hijo
                //    _prod.Show();
                //    _prod.StartPosition = FormStartPosition.CenterScreen;
                //}
            }

            private void dataGridViewOCDirecta_SelectionChanged(object sender, EventArgs e)
            {
                //PASO CON ENTER A LA OTRA COLUMNA
                if (MouseButtons != 0) return;

                if (_celWasEndEdit != null && dataGridViewOCDirecta.CurrentCell != null)
                {
                    // if we are currently in the next line of last edit cell
                    if (dataGridViewOCDirecta.CurrentCell.RowIndex == _celWasEndEdit.RowIndex + 1 &&
                        dataGridViewOCDirecta.CurrentCell.ColumnIndex == _celWasEndEdit.ColumnIndex)
                    {
                        int iColNew;
                        int iRowNew = 0;
                        if (_celWasEndEdit.ColumnIndex >= dataGridViewOCDirecta.ColumnCount - 1)
                        {
                            iColNew = 0;
                            iRowNew = dataGridViewOCDirecta.CurrentCell.RowIndex;
                        }
                        else
                        {
                            iColNew = _celWasEndEdit.ColumnIndex + 1;
                            iRowNew = _celWasEndEdit.RowIndex;
                        }
                        dataGridViewOCDirecta.CurrentCell = dataGridViewOCDirecta[iColNew, iRowNew];
                    }
                }
                _celWasEndEdit = null;
            }

            private void dataGridViewOCDirecta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
            {
                _celWasEndEdit = dataGridViewOCDirecta[e.ColumnIndex, e.RowIndex];
                if (e.RowIndex >= 0)
                {
                    //SIEMPRE Y CUANDO SE INGRESE VALORES EN PRECIO Y CANTIDAD
                    if (e.ColumnIndex == Convert.ToInt32(Col_Detalle.CANTIDAD) || e.ColumnIndex == Convert.ToInt32(Col_Detalle.PRECIO))
                    {
                        CalculaImporte();
                    }
                }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxrubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MUESTRA LOS ARTICULOS DE ESE RUBRO
            try
            {
                if (this.comboBoxrubro.SelectedIndex > 0)
                {
                    comboBoxRubro2.SelectedIndex = 0; //DESHABILITO EL COMBO DE RUBROS.. ASÍ SOLO TRAE PRODUCTOS DEL SUB RUBRO 
                    var q = (dynamic)null;

                    q = (from item in _articulosItem
                         where item.subrubro.Contains(this.comboBoxrubro.SelectedValue.ToString()) orderby item.art_descgen
                         select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();

                    this.dataGridViewOCDirecta.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.H_ARTICULOSDEPOSITO item in q)
                    {
                        indice = dataGridViewOCDirecta.Rows.Add();
                        dataGridViewOCDirecta.Rows[indice].Cells[(int)Col_Detalle.CODIGO].Value = item.art_codgen; //ARTICULO
                        dataGridViewOCDirecta.Rows[indice].Cells[(int)Col_Detalle.DESCRIPCION].Value = item.art_descgen; // DESCTRIPCION ARTICULO
                        dataGridViewOCDirecta.Rows[indice].Cells[(int)Col_Detalle.UNIDAD].Value = item.unimed; // UNIDAD MEDIDA

                        // ahora recupero la fila del combo, para saber que fila debo llenar con la marca

                        DataGridViewRow row = dataGridViewOCDirecta.Rows[indice];// this.dataGridViewReq.CurrentRow;
                        DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Detalle.MARCA] as DataGridViewComboBoxCell;

                        CargarMarca(item.art_codgen, comboboxColumnSector);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            //dataGridViewOCDirecta.ClearSelection();
            string busqueda = this.textBoxBuscar.Text.Trim();
            List<DataGridViewRow> rows = (from item in dataGridViewOCDirecta.Rows.Cast<DataGridViewRow>()
                                          let descripcion = Convert.ToString(item.Cells[(int)Col_Detalle.DESCRIPCION].Value ?? string.Empty).ToLower()
                                          where descripcion.Contains(busqueda.ToLower())
                                          select item).ToList<DataGridViewRow>();

            foreach (DataGridViewRow row in rows)
            {
                List<DataGridViewCell> cells = (from item in row.Cells.Cast<DataGridViewCell>()
                                                let cell = Convert.ToString(item.Value).ToLower()
                                                where cell.Contains(busqueda.ToLower())
                                                select item).ToList<DataGridViewCell>();


                row.Selected = true;
                dataGridViewOCDirecta.Rows[row.Index].Cells[1].Selected = true;

                break;

            }
        }

        private void comboBoxRubro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MUESTRA LOS ARTICULOS DE ESE RUBRO
            try
            {
                if (this.comboBoxRubro2.SelectedIndex > 0)
                {
                    comboBoxrubro.SelectedIndex = 0; //DESHABILITO EL COMBO DE SUBRUBROS.. ASÍ SOLO TRAE PRODUCTOS DEL RUBRO 

                    var q = (dynamic)null;

                    q = (from item in _articulosItem
                         where item.rubro.Contains(this.comboBoxRubro2.SelectedValue.ToString()) orderby item.art_descgen
                         select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();

                    this.dataGridViewOCDirecta.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.H_ARTICULOSDEPOSITO item in q)
                    {
                        indice = dataGridViewOCDirecta.Rows.Add();
                        dataGridViewOCDirecta.Rows[indice].Cells[(int)Col_Detalle.CODIGO].Value = item.art_codgen; //ARTICULO
                        dataGridViewOCDirecta.Rows[indice].Cells[(int)Col_Detalle.DESCRIPCION].Value = item.art_descgen; // DESCTRIPCION ARTICULO
                        dataGridViewOCDirecta.Rows[indice].Cells[(int)Col_Detalle.UNIDAD].Value = item.unimed; // UNIDAD MEDIDA

                        // ahora recupero la fila del combo, para saber que fila debo llenar con la marca

                        DataGridViewRow row = dataGridViewOCDirecta.Rows[indice];// this.dataGridViewReq.CurrentRow;
                        DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Detalle.MARCA] as DataGridViewComboBoxCell;

                        CargarMarca(item.art_codgen, comboboxColumnSector);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void checkBoxdiaria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        #endregion

        private void dataGridViewOCDirecta_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //solo para que no me muestre el error
        }
    }
}
