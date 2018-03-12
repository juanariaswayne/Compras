using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net;

namespace StaCatalina.Forms
{
    public interface IAddItemReq
    {
        void AddNewItemReq(string cod, string descrip, string uniMed);
    }
    public partial class Frm_comRequerimiento : StaCatalina.Plantilla, IAddItemReq
    {

        #region Calendar2
        private DataGridView dataGridView1 = new DataGridView();

        //[STAThreadAttribute()]
        //public static void Main()
        //{
        //    Application.Run(new FrmEntregaDepagos());
        //}


        #endregion
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private enum Col_Detalle
        {
            CODIGO,
            DESCRIPCION,
            UNIDAD,
            CLA_DESC,
            RUBRO,
            DESCRIP_RUBRO,
            PRESENTACION,
            MEDIDA,
            SUB_RUBRO,
            DESCRIP_SUBRUBRO,
            CANTIDAD,
            MARCA,
            FENTREGA
        }

        private enum col_Provisorios
        {
            DESCRIPCION = 0,
            PRESENTACION,
            UNIDAD,
            MARCA,
            EMBALAJE,
            CANTIDAD

        }

        protected int _indexSeleccionado;
        List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        List<Entities.Procedures.TRAEMARCAARTICULOS> _itemsMarca = new List<Entities.Procedures.TRAEMARCAARTICULOS>();
        //protected List<Entities.Procedures.TRAESUBRUBROSDELUSUARIO> _rubrositem = new List<Entities.Procedures.TRAESUBRUBROSDELUSUARIO>();
        //VARIABLE PARA PASAR CON ENTER A OTRA COLUMNA
        private DataGridViewCell _celWasEndEdit;
        int _contOriginalGRid;
        CultureInfo culture = new CultureInfo("en-US");

        #endregion

        #region Funciones
        public Frm_comRequerimiento()
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

        private void HabilitarFunciones()
        {
            try
            {
                if (Clases.Usuario.UsuarioLogeado.Id_Sector == 21 || Clases.Usuario.UsuarioLogeado.Id_Sector == 8)
                {
                    this.comboBoxLugarEntrega.Show();
                    this.labelEntrega.Show();
                }
                else
                {
                    this.comboBoxLugarEntrega.Show();
                    this.labelEntrega.Show();
                }
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

        private void EnviarMail()
        {
            try
            {
                BLL.Procedures.ENVIAMAILARTICULOSPROVISORIOS _enviaMail = new BLL.Procedures.ENVIAMAILARTICULOSPROVISORIOS();
                _enviaMail.ItemList();
            }

            catch (Exception ex)
            {
                //output = "Error enviando correo electrónico: " + ex.Message;
                MessageBox.Show("Error enviando mail", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private StringBuilder htmlMessageBody(DataGridView dg)
        {
            StringBuilder strB = new StringBuilder();
            //create html & table
            strB.AppendLine("<html><body><center><" +
                            "table border='1' cellpadding='0' cellspacing='0'>");
            strB.AppendLine("<tr>");
            //cteate table header
            for (int i = 0; i < dg.Columns.Count; i++)
            {
                strB.AppendLine("<td align='center' valign='middle'>" +
                                dg.Columns[i].HeaderText + "</td>");
            }
            //create table body
            strB.AppendLine("<tr>");
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                strB.AppendLine("<tr>");
                foreach (DataGridViewCell dgvc in dg.Rows[i].Cells)
                {
                    if (dgvc.Value == null)
                    {
                        strB.AppendLine("<td align='center' valign='middle'>" +
                                   "" + "</td>");

                    }
                    else
                    {
                        strB.AppendLine("<td align='center' valign='middle'>" +
                                   dgvc.Value.ToString() + "</td>");
                    }

                }
                strB.AppendLine("</tr>");

            }
            //table footer & end of html file
            strB.AppendLine("</table></center></body></html>");

            strB.Append("<br/>");

            if (this.comboBoxRubro2.SelectedIndex > 0)
            {
                strB.AppendLine("Rubro: " + this.comboBoxRubro2.Text.ToString());
            }

            if (this.comboBoxrubro.SelectedIndex > 0)
            {
                strB.AppendLine("Sub Rubro: " + comboBoxrubro.Text.ToString());
            }

            strB.Append("<br/>");//enter
            strB.Append("<br/>");

            strB.AppendLine("Usuario del Requerimiento: " + Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString());



            return strB;
        }

        #endregion

        #region IAddItemReq Members

        public void AddNewItemReq(string cod, string descrip, string uniMed)
        {
            try
            {
                this.dataGridViewReq.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.CODIGO].Value = cod;
                this.dataGridViewReq.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.DESCRIPCION].Value = descrip;
                this.dataGridViewReq.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.UNIDAD].Value = uniMed;
                this.dataGridViewReq.CurrentCell = this.dataGridViewReq.CurrentRow.Cells[(int)Col_Detalle.CANTIDAD];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Frm_comRequerimiento_Load(object sender, EventArgs e)
            {
                try
                {
                    MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                    menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                    this.OperacionesDelUsuario();

                    Clases.Empresa.CargarEmpresas(comboBoxEmpresa);
                    this.comboBoxEmpresa.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
               
                    // cargo en una coleccion los productos por unica vez
                    BLL.Procedures.H_ARTICULOSDEPOSITO _art = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                    _articulosItem = _art.ItemList();//le paso la colección de artículos

                    CargarRubros();
                    CargarSubRubros();
                    CargarLugaresEntrega(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);
                    TraerMarcasArticulos();

                //calendar
                CalendarColumn col = new CalendarColumn();

                this.dataGridViewReq.Columns.Add(col);
                this.dataGridViewReq.Columns[(int)Col_Detalle.FENTREGA].HeaderText = "Fecha Necesidad";
                this.dataGridViewReq.Columns[(int)Col_Detalle.FENTREGA].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //calendar


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

            private void dataGridViewReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                //EDITO LA CELDA PARA QUE INGRESE ARTICULOS QUE NO ESTEN EN BEJERMAN
               
                    this.dataGridViewReq.CurrentRow.ReadOnly = false;


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
                    //VERIFICO SI SOLAMENTE ESTA CARGANDO ARTICULOS PROVISORRIOS, DE SER ASÍ OBLIGO A SELECCIONAR UN RUBRO O SUBRUBRO ****
                    if(comboBoxrubro.SelectedIndex == 0 && comboBoxRubro2.SelectedIndex == 0)
                    {
                        MessageBox.Show("Si está creando un requerimiento, solo con artículos provisorios, debe seleccionar un Rubro o un Subrubro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // FIN CONTROL ARTICULOS PROVISORIOS
                    //TAMBIÉN OBLIGO A SELECCIONAR UN LUGAR DE ENTREGA //
                     if(comboBoxLugarEntrega.SelectedIndex == 0)
                    {
                        MessageBox.Show("Debe seleccionar un Lugar de Entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //

                    Entities.Tables.COMREQUERIMIENTO _ReqCabecera = new Entities.Tables.COMREQUERIMIENTO();
                    BLL.Tables.COMREQUERIMIENTO _ReqCab = new BLL.Tables.COMREQUERIMIENTO();
                    Entities.Tables.COMREQUERIMIENTOITEM _ReqItem = new Entities.Tables.COMREQUERIMIENTOITEM();
                   // BLL.Tables.COMREQUERIMIENTOITEM _ReqIte = new BLL.Tables.COMREQUERIMIENTOITEM();
                    List<Entities.Tables.COMREQUERIMIENTOITEM> _ItemsReq = new List<Entities.Tables.COMREQUERIMIENTOITEM>();
                    //CultureInfo culture = new CultureInfo("en-US");
                    string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
                                 
                    _ReqCabecera.FECHA = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    _ReqCabecera.ESTADO_ID = 1; //Ojo ver que valor se envia despues 
                    _ReqCabecera.OBS = this.textBoxObs.Text.Trim();
                    _ReqCabecera.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                    _ReqCabecera.SECTORREQUERIMIENTO_ID = Clases.Usuario.UsuarioLogeado.Id_Sector ; // Ojo ver como se envia Despues
                    _ReqCabecera.SECTORENTREGA_ID = Convert.ToInt32(comboBoxLugarEntrega.SelectedValue);

                    for (int i = 0; i < this.dataGridViewReq.Rows.Count ; i++)
                    {

                        if (dataGridViewReq.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != string.Empty && dataGridViewReq.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != null)
                        {
                            _ReqItem = new Entities.Tables.COMREQUERIMIENTOITEM();

                            //_ReqItem.COMEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;                                                
                            _ReqItem.ARTICULO_ID = dataGridViewReq.Rows[i].Cells[(int)Col_Detalle.CODIGO].Value.ToString();
                            _ReqItem.UNIMED = dataGridViewReq.Rows[i].Cells[(int)Col_Detalle.UNIDAD].Value.ToString();
                            _ReqItem.CANTIDAD = Convert.ToDecimal(dataGridViewReq.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value.ToString(),culture);
                            if(dataGridViewReq.Rows[i].Cells[(int)Col_Detalle.FENTREGA].Value == null)
                            {
                                _ReqItem.FECHAENTREGA = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            }
                            else
                            {
                                _ReqItem.FECHAENTREGA = Convert.ToDateTime(Convert.ToDateTime(dataGridViewReq.Rows[i].Cells[(int)Col_Detalle.FENTREGA].Value));
                            }
                            //VERIFICO SI SELECCIONO UNA MARCA
                            if (dataGridViewReq.Rows[i].Cells[(int)Col_Detalle.MARCA].EditedFormattedValue != null && dataGridViewReq.Rows[i].Cells[(int)Col_Detalle.MARCA].Value != "0" && dataGridViewReq.Rows[i].Cells[(int)Col_Detalle.MARCA].Value != "<Sin Definir>")
                            {
                               _ReqItem.MARCA = dataGridViewReq.Rows[i].Cells[(int)Col_Detalle.MARCA].EditedFormattedValue.ToString();                                
                            }
                            
                            _ReqItem.NIVELAUT_ID = 1; //ojo ver como se envia despues
                            //SI LA CANTIDAD ES CERO.. NO LO GRABO.
                            if (_ReqItem.CANTIDAD > 0)
                                _ItemsReq.Add(_ReqItem); //Meto en la coleccion todos los elementos de la grilla
                                        
                        }
                    }
                    //AHORA VERIFICO SI EXISTEN ARTICULOS PROVISORIOS
                    List<Entities.Tables.COMARTICULOSPROVISORIOS> _ItemsProvisorios = new List<Entities.Tables.COMARTICULOSPROVISORIOS>();
                    Entities.Tables.COMARTICULOSPROVISORIOS _ItemProvis = new Entities.Tables.COMARTICULOSPROVISORIOS();
                    for (int i = 0; i < this.dataGridViewProvisorios.Rows.Count -1 ; i++)
                    {
                        if (dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.DESCRIPCION].Value != null && dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.DESCRIPCION].Value != string.Empty  && dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.CANTIDAD].Value != null && dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.CANTIDAD].Value != string.Empty)
                        {
                            if(dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.UNIDAD].Value == string.Empty || dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.UNIDAD].Value == null)
                            {
                                MessageBox.Show("Debe ingresar unidad de medida, para los artículos que no estén en Bejerman", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; //SALGO DEL PROCESO.......
                            }  
                            else
                            {
                                _ItemProvis = new Entities.Tables.COMARTICULOSPROVISORIOS();
                                _ItemProvis.DESCRIPCION = dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.DESCRIPCION].Value.ToString();
                                _ItemProvis.PRESENTACION = (dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.PRESENTACION].Value == string.Empty || dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.PRESENTACION].Value == null) ? string.Empty : dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.PRESENTACION].Value.ToString();
                                _ItemProvis.UNIMED = dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.UNIDAD].Value.ToString().ToUpper();
                                _ItemProvis.MARCA = (dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.MARCA].Value == string.Empty || dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.MARCA].Value == null) ? string.Empty : dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.MARCA].Value.ToString();
                                _ItemProvis.EMBALAJE = (dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.EMBALAJE].Value == string.Empty || dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.EMBALAJE].Value == null) ? string.Empty : dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.EMBALAJE].Value.ToString();
                                _ItemProvis.CANTIDAD = Convert.ToDecimal(dataGridViewProvisorios.Rows[i].Cells[(int)col_Provisorios.CANTIDAD].Value.ToString(),culture);
                                _ItemProvis.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                                _ItemProvis.USUARIO_MAIL = Clases.Usuario.UsuarioLogeado.Email;
                                if (this.comboBoxrubro.SelectedIndex == 0)// subrubro
                                { _ItemProvis.SUB_RUBRO = this.comboBoxRubro2.Text; }
                                else
                                { _ItemProvis.SUB_RUBRO = this.comboBoxrubro.Text; }                               
                                if(_ItemProvis.CANTIDAD > 0)
                                _ItemsProvisorios.Add(_ItemProvis);
                        }                               

                        }

                    }
                    //FIN ARTICULOS PROVISORIOS

                    //PUEDE SER QUE SOLO SE CARGUE ARTICULOS PROVISORIOS.... SE ENVIA LA CABECERA DEL REQUERIMIENTO Y LOS ITEMS DE PROVISORIOS
                    if (_ItemsReq.Count > 0 || _ItemsProvisorios.Count > 0)
                    {
                        int _nroReqGenerado = 0;
                        //LLAMO A LA FUNCION QUE GUARDA CABECERA E ITEMS
                        if (_ReqCab.AddItem(_ReqCabecera, _ItemsReq, _empresa, _ItemsProvisorios, ref _nroReqGenerado))
                        {
                           
                            if (_ItemsProvisorios.Count > 0)
                            {
                                this.labelEnviandomail.Visible = true; 
                                this.progressBar1.Visible = true;
                                EnviarMail();
                               
                            }

                            MessageBox.Show("Se generó el Requerimiento Nro.: " + _nroReqGenerado, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridViewReq.Rows.Clear();
                            this.textBoxObs.Text = "";
                            dataGridViewProvisorios.Rows.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Error al grabar Requerimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                            MessageBox.Show("Debe ingresar al menos una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                           
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        
         private void dataGridViewReq_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {

                if (dataGridViewReq.IsCurrentCellDirty)
                    dataGridViewReq.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }

         private void dataGridViewReq_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewReq.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_Detalle.CANTIDAD)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }

        }

         private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            dataGridViewReq.Rows.Clear();
            this.dataGridViewProvisorios.Rows.Clear();
            this.comboBoxrubro.SelectedIndex = 0;
            this.textBoxObs.Text = "";
        }

         private void dataGridViewReq_CellEndEdit(object sender, DataGridViewCellEventArgs e)
         {
             _celWasEndEdit = dataGridViewReq[e.ColumnIndex, e.RowIndex];

          
        }

         private void dataGridViewReq_KeyDown(object sender, KeyEventArgs e)
         {
             ////MUESTRO PRODUCTOS CUANDO LE DOY UN ENTER EN EL BOTON DE LA PRIMER COLUMNA
             //var senderGrid = (DataGridView)sender;
             //if (e.KeyCode == Keys.Enter && senderGrid.Columns[this.dataGridViewReq.CurrentCell.ColumnIndex].Index == (int)Col_Detalle.BUSCADOR && this.dataGridViewReq.CurrentCell.RowIndex >= 0)
             //{
             //    Frm_ProdRequerimiento _prod = new Frm_ProdRequerimiento();
             //    _prod.Articulos = _articulosItem;//le paso la colección de artículos
             //    //paso los rubros
             //    _prod.Rubros = _rubrositem;
             //    _indexSeleccionado = this.dataGridViewReq.CurrentCell.RowIndex; //establezco el index
             //    _prod.MdiParent = this.MdiParent; // esto porque estoy utiliando MDI
             //    _prod.Opener = this; // es para el formulario hijo
             //    _prod.Show();
             //    _prod.StartPosition = FormStartPosition.CenterScreen;
             //}
         }

         private void dataGridViewReq_SelectionChanged(object sender, EventArgs e)
         {
             //PASO CON ENTER A LA OTRA COLUMNA
             if (MouseButtons != 0) return;

             if (_celWasEndEdit != null && dataGridViewReq.CurrentCell != null)
             {
                 // if we are currently in the next line of last edit cell
                 if (dataGridViewReq.CurrentCell.RowIndex == _celWasEndEdit.RowIndex + 1 &&
                     dataGridViewReq.CurrentCell.ColumnIndex == _celWasEndEdit.ColumnIndex)
                 {
                     int iColNew;
                     int iRowNew = 0;
                     if (_celWasEndEdit.ColumnIndex >= dataGridViewReq.ColumnCount - 1)
                     {
                        //iColNew = 0;
                        iColNew = (int)Col_Detalle.CANTIDAD;
                        iRowNew = dataGridViewReq.CurrentCell.RowIndex;
                     }
                     else
                     {
                         iColNew = _celWasEndEdit.ColumnIndex + 1;
                         iRowNew = _celWasEndEdit.RowIndex;
                     }
                     dataGridViewReq.CurrentCell = dataGridViewReq[iColNew, iRowNew];
                 }
             }
             _celWasEndEdit = null;
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
                         where item.art_descgen.Contains(textBoxBuscar.Text.Trim().ToUpper()) && item.subrubro.ToString().Trim() == this.comboBoxrubro.SelectedValue.ToString().Trim()
                         select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();
                   
                    this.dataGridViewReq.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.H_ARTICULOSDEPOSITO item in q)
                    {
                        indice = dataGridViewReq.Rows.Add();
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.CODIGO].Value = item.art_codgen; //ARTICULO
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.DESCRIPCION].Value = item.art_descgen; // DESCTRIPCION ARTICULO
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.UNIDAD].Value = item.unimed; // UNIDAD MEDIDA
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.CLA_DESC].Value = item.cla_desc; // DESCRIPCION UNIDAD MEDIDA
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.RUBRO].Value = item.rubro; // RUBRO
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.DESCRIP_RUBRO].Value = item.descriprubro; // DESCRIP RUBRO
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.PRESENTACION].Value = item.presentacion; // PRESENTACION
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.MEDIDA].Value = item.medida; // MEDIDA
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.SUB_RUBRO].Value = item.subrubro; // SUB RUBRO
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.DESCRIP_SUBRUBRO].Value = item.descripsubrubro; // DESCRIP SUB RUBRO

                        // ahora recupero la fila del combo, para saber que fila debo llenar con la marca

                        DataGridViewRow row =  dataGridViewReq.Rows[indice];// this.dataGridViewReq.CurrentRow;
                        DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Detalle.MARCA] as DataGridViewComboBoxCell;

                        CargarMarca(item.art_codgen,comboboxColumnSector );
                    }


                   // this.bindingSourceReq.DataSource = q;

                    _contOriginalGRid = dataGridViewReq.Rows.Count;

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
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = this.textBoxBuscar.Text.Trim();
            List<DataGridViewRow> rows = (from item in dataGridViewReq.Rows.Cast<DataGridViewRow>()
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
                dataGridViewReq.Rows[row.Index].Cells[1].Selected = true;

                break;

            }
        }


        #endregion

        private void dataGridViewProvisorios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewProvisorios.IsCurrentCellDirty)
                dataGridViewProvisorios.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewProvisorios_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewProvisorios.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_Detalle.CANTIDAD)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
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
                         where item.art_descgen.Contains(textBoxBuscar.Text.Trim().ToUpper()) && item.rubro.ToString().Trim() == this.comboBoxRubro2.SelectedValue.ToString().Trim()
                         select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();

                    this.dataGridViewReq.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.H_ARTICULOSDEPOSITO item in q)
                    {
                        indice = dataGridViewReq.Rows.Add();
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.CODIGO].Value = item.art_codgen; //ARTICULO
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.DESCRIPCION].Value = item.art_descgen; // DESCTRIPCION ARTICULO
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.UNIDAD].Value = item.unimed; // UNIDAD MEDIDA
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.CLA_DESC].Value = item.cla_desc; // DESCRIPCION UNIDAD MEDIDA
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.RUBRO].Value = item.rubro; // RUBRO
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.DESCRIP_RUBRO].Value = item.descriprubro; // DESCRIP RUBRO
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.PRESENTACION].Value = item.presentacion; // PRESENTACION
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.MEDIDA].Value = item.medida; // MEDIDA
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.SUB_RUBRO].Value = item.subrubro; // SUB RUBRO
                        dataGridViewReq.Rows[indice].Cells[(int)Col_Detalle.DESCRIP_SUBRUBRO].Value = item.descripsubrubro; // DESCRIP SUB RUBRO

                        // ahora recupero la fila del combo, para saber que fila debo llenar con la marca

                        DataGridViewRow row = dataGridViewReq.Rows[indice]; //this.dataGridViewReq.CurrentRow;
                        DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Detalle.MARCA] as DataGridViewComboBoxCell;

                        CargarMarca(item.art_codgen, comboboxColumnSector);
                    }


                    // this.bindingSourceReq.DataSource = q;

                    _contOriginalGRid = dataGridViewReq.Rows.Count;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewReq_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //solo para que no me muestre el error
        }

        private void comboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SOLO CAMBIO DE EMPRESA SI ESTA AUTORIZADA

            if (comboBoxEmpresa.SelectedIndex > 0)
            {

                string _emp = this.comboBoxEmpresa.SelectedValue.ToString();
                int _index = this.comboBoxEmpresa.SelectedIndex;
                CargarLugaresEntrega(_emp);
                if (Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != _emp.Trim() && Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != "AMBA")
                {
                    MessageBox.Show("Ud. no está autorizado a operar con esta empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.comboBoxEmpresa.SelectedIndex = (_index == 0) ? 1 : 0;
                    return;
                }

            }
        }
    }
}
