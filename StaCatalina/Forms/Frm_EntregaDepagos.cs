using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
namespace StaCatalina.Forms
{
    public partial class Frm_EntregaDepagos : StaCatalina.Plantilla
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

            private enum Col_FacturaOP
            {
                codigoEmpresa = 0,
                sucursalEmpresa,
                ID,
                codproveed,
                razonSocial,
                OrdenPago,
                FechaOP,
                Importe,
                Retirado,
                FechaRetiro
            }
        #endregion
        #region Funciones

            public Frm_EntregaDepagos()
            {
                InitializeComponent();
                //calendar
                //this.dataGridViewRetiro.Dock = DockStyle.Fill;
                //this.Controls.Add(this.dataGridViewRetiro);
                //this.Load += new EventHandler(FrmEntregaDepagos_Load);
                //this.Text = "Fecha Retiro";
                //fin calendar
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
            private void CargarFacturas()
            {
                try
                {
                    BLL.Procedures.PAGOSARETIRARPROVEEDORES _pago = new BLL.Procedures.PAGOSARETIRARPROVEEDORES();
                    this.bindingSourcePagos.DataSource = _pago.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() );
                    this.dataGridViewRetiro.ClearSelection();
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
            private void FrmEntregaDepagos_Load(object sender, EventArgs e)
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
               

                //calendar
                CalendarColumn col = new CalendarColumn();
               
                this.dataGridViewRetiro.Columns.Add(col);
                this.dataGridViewRetiro.Columns[(int)Col_FacturaOP.FechaRetiro].HeaderText = "Fecha Entrega";
                                   
                //calendar

                //this.dataGridViewRetiro.AutoGenerateColumns = false;
                 CargarFacturas();
            }

            private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewRetiro.IsCurrentCellDirty)
                    dataGridViewRetiro.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            private void toolStripButtonSave_Click(object sender, EventArgs e)
            {
                try
                {
                    Entities.Tables.ENTREGAORDENPAGO _newItem = new Entities.Tables.ENTREGAORDENPAGO();
                    BLL.Tables.ENTREGAORDENPAGO _entre = new BLL.Tables.ENTREGAORDENPAGO();
                    Boolean _selecciono = false;
                    DateTime? _fechaRetiro;

                    //PRIMERO CONTROLO LOS QUE ESTAN SELECCIONADOS, QUE LA FECHA DE RETIRO NO SEA MENOR QUE LA FECHA DE LA OP

                    for (int I = 0; I < this.dataGridViewRetiro.RowCount; I++)
                    {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewRetiro.Rows[I].Cells[(int)Col_FacturaOP.Retirado] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            if (Convert.ToString(Convert.ToDateTime(dataGridViewRetiro.Rows[I].Cells[(int)Col_FacturaOP.FechaRetiro].Value)) != DateTime.MinValue.ToString())
                            {
                                _fechaRetiro = Convert.ToDateTime(Convert.ToDateTime(dataGridViewRetiro.Rows[I].Cells[(int)Col_FacturaOP.FechaRetiro].Value));
                                if (_fechaRetiro < Convert.ToDateTime(dataGridViewRetiro.Rows[I].Cells[(int)Col_FacturaOP.FechaOP].Value.ToString()))
                                {
                                    MessageBox.Show("La fecha de Retiro no puede ser menor que la fecha de la OP", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                            }

                        }

                    }
                    //FIN VERIFICA FECHA DE ENTREGA
                    for (int i = 0; i < this.dataGridViewRetiro.RowCount; i++)
                    {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewRetiro.Rows[i].Cells[(int)Col_FacturaOP.Retirado] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            _newItem = new Entities.Tables.ENTREGAORDENPAGO();
                            _selecciono = true;
                            _newItem.CCOEMP_CODIGO = dataGridViewRetiro.Rows[i].Cells[(int)Col_FacturaOP.codigoEmpresa].Value.ToString();
                            _newItem.CCOSUC_COD = dataGridViewRetiro.Rows[i].Cells[(int)Col_FacturaOP.sucursalEmpresa].Value.ToString();
                            _newItem.CCO_ID = Convert.ToInt32(dataGridViewRetiro.Rows[i].Cells[(int)Col_FacturaOP.ID].Value.ToString());
                            _newItem.CCO_NRO = dataGridViewRetiro.Rows[i].Cells[(int)Col_FacturaOP.OrdenPago].Value.ToString();
                            if (Convert.ToString(Convert.ToDateTime(dataGridViewRetiro.Rows[i].Cells[(int)Col_FacturaOP.FechaRetiro].Value)) != DateTime.MinValue.ToString())
                            {
                                _newItem.FECHARETIRO = Convert.ToDateTime(dataGridViewRetiro.Rows[i].Cells[(int)Col_FacturaOP.FechaRetiro].Value.ToString());
                            }
                            else
                            {
                                _newItem.FECHARETIRO = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //POR DEFAUL INGRESO LA FECHA ACTUAL
                            }
                            _newItem.CCO_CODPRO = dataGridViewRetiro.Rows[i].Cells[(int)Col_FacturaOP.codproveed].Value.ToString();
                            _newItem.CCO_FEMISION = Convert.ToDateTime(dataGridViewRetiro.Rows[i].Cells[(int)Col_FacturaOP.FechaOP].Value.ToString());
                            _newItem.CCO_IMPMONLOC = Convert.ToDouble(dataGridViewRetiro.Rows[i].Cells[(int)Col_FacturaOP.Importe].Value.ToString());
                            _newItem.CCOPRO_RAZSOC = dataGridViewRetiro.Rows[i].Cells[(int)Col_FacturaOP.razonSocial].Value.ToString();
                            _newItem.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();

                            _entre.Add(_newItem);

                        }

                    }
                    if (_selecciono)
                    {
                        MessageBox.Show("La operación se grabó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarFacturas();
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna Orden de Pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        #endregion

            private void toolStripButtonPrint_Click(object sender, EventArgs e)
            {
                try
                {
                    StaCatalina.Forms.Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();

                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "PagosARetirarProveedores.rpt";
                    objReport.Load(reportPath);
                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;

                    // PARAMETROS DE CONEXION
                    TableLogOnInfo logoninfo = new TableLogOnInfo();
                    logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source"];
                    logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogSTACATALINA"];
                    logoninfo.ConnectionInfo.UserID = ConfigurationManager.AppSettings["User ID"];
                    logoninfo.ConnectionInfo.Password = ConfigurationManager.AppSettings["Password"];
                    logoninfo.ConnectionInfo.IntegratedSecurity = false;
                    Tables tables = objReport.Database.Tables;
                    foreach (Table table in tables)
                    {
                        table.ApplyLogOnInfo(logoninfo);
                    }
                    // FIN PARAMETROS DE CONEXION

                    ParameterFields Parametros = new ParameterFields();
                    ParameterField ParametroField = new ParameterField();
                    ParameterDiscreteValue ParametroValue = new ParameterDiscreteValue();
                    Parametros.Clear();
                    //1er PARAMETRO
                    ParametroField.Name = "@codEmp";
                    ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    _Reporte.Parameters = Parametros;
                    _Reporte.Reporte = objReport;
                    _Reporte.Show();


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
    }
}
