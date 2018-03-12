using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Linq;
namespace StaCatalina.Forms
{
    public partial class Frm_AutorizacionOrdenCompra : StaCatalina.Plantilla
    {
        #region Variables
        private enum Col_OCCab
        {
            CODEMP = 0,
            EMPRESA,
            NRO_OC,
            FECHA,
            PROVEEDOR,
            OBSERVACIONES,
            EMAIL,
            TIPO_OC,
            USUARIO

        }

        private enum Col_OCItem
        {
            CODEMP = 0,
            ARTICULO_ID,
            NRO_OC,
            NRO_ITEM,
            AUTORIZA,
            NO_AUTORIZA,
            ARTICULO,
            UNIDAD_DE_MEDIDA,
            PRECIO,
            CANTIDAD,
            MARCA,
            FECHA_DE_ENTREGA
        }

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        CultureInfo culture = new CultureInfo("en-US");
       
        #endregion

        #region Calendar2
        private DataGridView dataGridView1 = new DataGridView();

        #endregion

        #region Funciones
            public Frm_AutorizacionOrdenCompra()
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
                    BLL.Procedures.ORDENCOMPRA_DISPONIBLES _detalle = new BLL.Procedures.ORDENCOMPRA_DISPONIBLES();
                    this.dataGridViewOCCab.Rows.Clear();
                    //FILTRO LOS DE LA EMPRESA LOGEADA
                    var q = (dynamic)null;

                    q = (from _item in _detalle.ItemList()
                         where _item.codemp.Trim() == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim()
                         select _item);

                int indice;
                    foreach (Entities.Procedures.ORDENCOMPRA_DISPONIBLES item in q)
                    {
                        indice = dataGridViewOCCab.Rows.Add();
                        dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                        dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.EMPRESA].Value = item.codemp; //EMPRESA
                        dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.NRO_OC].Value = item.ordencompra_id; //NRO OC
                        dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.FECHA].Value = item.fecha.ToShortDateString();//FECHA
                        dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.PROVEEDOR].Value = item.razonsocial;//PROVEEDOR
                        dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.OBSERVACIONES].Value = item.obs;//PROVEEDOR
                        dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.EMAIL].Value = item.email;//EMAIL
                        dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.TIPO_OC].Value = item.obs;//TIPO OC
                        dataGridViewOCCab.Rows[indice].Cells[(int)Col_OCCab.USUARIO].Value = item.usuario;//USUARIO
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

        static void ExportToMSMail(string _codEmp, int _NroOrdenCompra)
        {
            StaCatalina.Forms.Reports _Reporte = new Reports();
            ReportDocument objReport = new ReportDocument();


            String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "OrdenDeCompra.rpt";
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

            //PAOS LOS PARAMTROS EN ORDEN

            objReport.SetParameterValue(0, _codEmp);
            objReport.SetParameterValue(1, "OC");
            objReport.SetParameterValue(2, _NroOrdenCompra);
            objReport.SetParameterValue(3, _NroOrdenCompra);
            objReport.SetParameterValue(4, null);
            objReport.SetParameterValue(5, null);
            objReport.SetParameterValue(6, 1);


            //PdfRtfWordFormatOptions pdfOpts = ExportOptions.CreatePdfRtfWordFormatOptions();
            PdfFormatOptions pdfOpts = new PdfFormatOptions();
            MicrosoftMailDestinationOptions mailOpts = ExportOptions.CreateMicrosoftMailDestinationOptions();
            ExportOptions exportOpts = new ExportOptions();
            

            pdfOpts.UsePageRange=false;
            exportOpts.ExportFormatOptions = pdfOpts;

            mailOpts.MailCCList = "sistemas@csantacatalina.com.ar";
            mailOpts.MailMessage = "PRUEBA DE CORREO OC HECTOR";
            mailOpts.MailSubject = "PRUEBA";
            mailOpts.MailToList = "sistemas@csantacatalina.com.ar";
            mailOpts.Password = "sys/TSH.360";
            mailOpts.UserName = "sistemas@csantacatalina.com.ar";
            exportOpts.ExportDestinationOptions =mailOpts;

            exportOpts.ExportDestinationType = ExportDestinationType.MicrosoftMail;
            exportOpts.ExportFormatType = ExportFormatType.PortableDocFormat;
           

            objReport.Export(exportOpts);
        }

        private bool  GenerarPDFOC(string _codEmp, int _NroOrdenCompra,string Email)
        {
            

            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

               
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "OrdenDeCompra.rpt";
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

                //PAOS LOS PARAMTROS EN ORDEN

                objReport.SetParameterValue(0, _codEmp);
                objReport.SetParameterValue(1, "OC");
                objReport.SetParameterValue(2, _NroOrdenCompra);
                objReport.SetParameterValue(3, _NroOrdenCompra);
                objReport.SetParameterValue(4, null);
                objReport.SetParameterValue(5, null);
                objReport.SetParameterValue(6, 1);
                objReport.SetParameterValue(7, "");
                objReport.SetParameterValue(8, null);
                objReport.SetParameterValue(9,null);


                //GUARDO EN FORMATO PDF
                string _path = ConfigurationManager.AppSettings["PDF"] + "\\PDF\\" + "OrdenDeCompra.PDF";


                objReport.ExportToDisk(ExportFormatType.PortableDocFormat, _path);
                            

                //_codEmp = (_codEmp == "EGES") ? "EGESAC S.A." : "RSC S.A.";

               if( EnviarMail(_codEmp, _path,Email))
                {
                    return true;

                }
               else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        private bool EnviarMail(string _empresa,string _path,string Email)
        {
            MailMessage email = new MailMessage();
            //email.To.Add(new MailAddress(Email)); //  ************* MAILS CARGADOS EN BEJERMAN, EN DATOS ADICIONALES DEL PROVEEDOR
            
            email.To.Add(Email.ToString().Replace(";",","));
            //ENVIO UNA COPIA A LA PERSONA QUE ESTA AUTORIZANDO, AL USUARIO QUE REALIZÓ LA OC Y AL GRUPO
            StaCatalinaEntities _Mod = new StaCatalinaEntities();
            String _usuOC = dataGridViewOCCab.Rows[dataGridViewOCCab.CurrentRow.Index].Cells[(int)Col_OCCab.USUARIO].Value.ToString().Trim();

            var _mailUsu = (from U in _Mod.comUsuarioEnviaMail 
                            join tbl in _Mod.TBL_Usuarios
                            on U.Id_Usuario equals tbl.Id_Usuario
                            join tbl2 in _Mod.TBL_Usuarios
                            on U.Id_Usuario_EnviaMail equals tbl2.Id_Usuario
                            where tbl.IdentificadorUsuario == _usuOC
                            select new
                            {
                              MAIL = tbl.Email, //MAIL DEL USUARIO DE LA OC
                              mail_GRUPO = tbl2.Email //MAIL DEL GRUPO
                            }).ToList();

            String _CCMail = string.Empty;
            bool _primero = true;
            foreach (var item in _mailUsu)
            {
                //CONCATENO TODOS LOS MAIL A LOS QUE TENGO QUE ENVIAR
                if (_primero)
                {
                    _CCMail = item.MAIL +","+item.mail_GRUPO;
                    _primero = false;
                }
                else
                {
                    _CCMail = _CCMail + "," + item.mail_GRUPO;
                }
                

            }


            if (Clases.Usuario.UsuarioLogeado.Email != string.Empty)
            {
                if (_CCMail != string.Empty)
                {
                    //_CCMail = _CCMail + "," + Clases.Usuario.UsuarioLogeado.Email.ToString();
                    //email.CC.Add(new MailAddress(_CCMail.ToString()));
                    email.CC.Add(_CCMail.ToString());
                }
                else // solo envio mail al que esta autorizando
                {
                    email.CC.Add(new MailAddress(Clases.Usuario.UsuarioLogeado.Email.ToString()));
                }
            }
            email.From = new MailAddress("compras@csantacatalina.com.ar"); // VER SI SE PUEDE UTILIZAR UN GENERICO
            email.Subject = "Orden de Compra para la Empresa: " + _empresa ;
            email.Body = "******** ORDEN DE COMPRA CLÍNICA SANTA CATALINA ************* ";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            email.Attachments.Add(new Attachment(_path));
            email.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
            
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("compras@csantacatalina.com.ar", "compras2013");

            string output = null;
           
            try
            {
                smtp.Send(email);
               
                email.Dispose();

                //BORRO EL REPORTE... QUE GENERE EN PDF
                File.Delete(_path);

                return true;
            }
            catch (Exception ex)
            {
                File.Delete(_path);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }

            Console.WriteLine(output);
        }

        private void CalculaImporte()
        {
            try
            {
                //CALUCLO PRECIO x CANTIDAD
                labelImporteOC.Text = ("0").ToString(culture);
                decimal _importeTotal = 0;
                for (int i = 0; i < this.dataGridViewOCItem.Rows.Count; i++)
                {
                    //SOLO TOMO LAS FILAS SELECCIONADAS
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.AUTORIZA] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        //VERIFICO QUE PRECIO Y CANTIDAD SEAN VALORES VALIDOS
                        if (dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.PRECIO].Value != null && dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.CANTIDAD].Value != null && dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.PRECIO].Value != string.Empty && dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.CANTIDAD].Value != string.Empty)
                        {
                            decimal _precio = Convert.ToDecimal(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.PRECIO].Value.ToString(), culture);
                            decimal _cantidad = Convert.ToDecimal(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.CANTIDAD].Value.ToString(), culture);

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
                        ctl.Value = Convert.ToDateTime(this.Value.ToString());
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
            private void Frm_AutorizacionOrdenCompra_Load(object sender, EventArgs e)
            {
                //PERMISOS
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();

                //calendar
                CalendarColumn col = new CalendarColumn();

                this.dataGridViewOCItem.Columns.Add(col);
                this.dataGridViewOCItem.Columns[(int)Col_OCItem.FECHA_DE_ENTREGA].HeaderText = "Fecha Entrega";
                this.dataGridViewOCItem.Columns[(int)Col_OCItem.FECHA_DE_ENTREGA].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //FIN PERMISOS
                this.Text = "Autorización Orden de Compra Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                TraeOCPendientes();

               
            }

            private void dataGridViewOCCab_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    if (e.RowIndex > -1)
                    {
               
                            //this.textBoxDetalleOC.Visible = false;
                            //this.dataGridViewOCItem.Visible = true;

                            BLL.Procedures.TRAEORDENCOMPRAITEM _item = new BLL.Procedures.TRAEORDENCOMPRAITEM();

                            this.dataGridViewOCItem.Rows.Clear();
                            int indice;
                            decimal _totalOC = 0;
                            foreach (Entities.Procedures.TRAEORDENCOMPRAITEM item in _item.ItemList(dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_OCCab.NRO_OC].Value), 1))
                            {
                                indice = dataGridViewOCItem.Rows.Add();
                                dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CODEMP].Value = item.codemp;//CODIGO EMPRESA
                                dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.ARTICULO_ID].Value = item.articulo_id;//ARTICULO
                                dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.NRO_OC].Value = item.ordencompra_id; //OC
                                dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.NRO_ITEM].Value = item.nroitem; //NRO ITEM
                                dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.ARTICULO].Value = item.art_descgen.ToString();//DESCRIP ARTICULO
                                dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.UNIDAD_DE_MEDIDA].Value = item.unimed;//TRAE UNIMED
                                dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.PRECIO].Value = item.precio.ToString().Replace(",", ".");//PRECIO 
                                dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CANTIDAD].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD  
                                dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.MARCA].Value = item.marca;//TRAE MARCA   
                                dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.FECHA_DE_ENTREGA].Value = item.fechaentrega.ToShortDateString();//FECHA ENTREGA      

                                decimal _precio = Convert.ToDecimal(item.precio.ToString().Replace(",", ".").ToString(), culture);
                                decimal _cantidad = Convert.ToDecimal(item.cantidad.ToString().Replace(",", ".").ToString(), culture);

                                _totalOC = Convert.ToDecimal(_totalOC + (_precio * _cantidad), culture);
                            }
                            labelImporteOC.Text = "$ " + _totalOC.ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            private void dataGridViewOCItem_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewOCItem.IsCurrentCellDirty)
                    dataGridViewOCItem.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            private void dataGridViewOCItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    //NO PERMITE QUE TILDE LOS DOS A LA MISMA VEZ
                    if (e.ColumnIndex == (int)Col_OCItem.AUTORIZA || e.ColumnIndex == (int)Col_OCItem.NO_AUTORIZA)
                    {

                        DataGridViewCheckBoxCell cellSelecion = dataGridViewOCItem.Rows[e.RowIndex].Cells[(int)Col_OCItem.AUTORIZA] as DataGridViewCheckBoxCell;
                        DataGridViewCheckBoxCell cellSelecionNoAut = dataGridViewOCItem.Rows[e.RowIndex].Cells[(int)Col_OCItem.NO_AUTORIZA] as DataGridViewCheckBoxCell;

                        if (Convert.ToBoolean(cellSelecion.Value))
                        {

                            if (Convert.ToBoolean(cellSelecionNoAut.Value))
                            {
                                cellSelecionNoAut.Value = false;
                                cellSelecion.Value = false;

                            }

                        }


                        if (Convert.ToBoolean(cellSelecionNoAut.Value))
                        {

                            if (Convert.ToBoolean(cellSelecion.Value))
                            {
                                cellSelecionNoAut.Value = false;
                                cellSelecion.Value = false;
                            }

                        }

                        CalculaImporte();
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
                    
                    Entities.Tables.COMORDENCOMPRAITEM _itemOC = new Entities.Tables.COMORDENCOMPRAITEM();
                    List<Entities.Tables.COMORDENCOMPRAITEM> _items = new List<Entities.Tables.COMORDENCOMPRAITEM>();
                    Entities.Tables.COMORDENCOMPRA _itemCab = new Entities.Tables.COMORDENCOMPRA();
                    BLL.Tables.COMORDENCOMPRA _auto = new BLL.Tables.COMORDENCOMPRA();
                    bool _selecciono = false;
                   
                  
                    for (int i = 0; i < this.dataGridViewOCItem.Rows.Count ; i++)
                    {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.AUTORIZA] as DataGridViewCheckBoxCell;
                        DataGridViewCheckBoxCell cellSelecionNoAuto = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.NO_AUTORIZA] as DataGridViewCheckBoxCell;
                      

                        _itemOC = new Entities.Tables.COMORDENCOMPRAITEM();
                        _itemOC.CODEMP = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.CODEMP].Value.ToString();
                        _itemOC.ARTICULO_ID = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.ARTICULO_ID].Value.ToString();
                        _itemOC.ORDENCOMPRA_ID = Convert.ToInt32(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.NRO_OC].Value);
                        _itemOC.NROITEM = Convert.ToInt32(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.NRO_ITEM].Value);
                        _itemOC.UNIMED = dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.UNIDAD_DE_MEDIDA].Value.ToString();
                        _itemOC.PRECIO = Convert.ToDecimal(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.PRECIO].Value.ToString(),culture);
                        _itemOC.CANTIDAD = Convert.ToDecimal(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.CANTIDAD].Value.ToString(),culture);
                        _itemOC.MARCA = (dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.MARCA].Value == null) ? string.Empty : dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.MARCA].Value.ToString();
                        _itemOC.FECHAENTREGA = Convert.ToDateTime(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.FECHA_DE_ENTREGA].Value);
                    
                        //VERIFICA SI ESTA AUTORIZADO
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            _selecciono = true;
                            _itemOC.NIVELAUT_ID = 2;
                            _items.Add(_itemOC); //VOY AGREGANDO A LA COLECCION
                        }
                        //VERIFICA SI LO ESTA RECHAZANDO
                        if (Convert.ToBoolean(cellSelecionNoAuto.Value))
                        {
                            _selecciono = true;
                            _itemOC.NIVELAUT_ID = 3;
                            _items.Add(_itemOC); //VOY AGREGANDO A LA COLECCION
                        }
                        
                        
                      
                        
                    }
                    //DATOS PARA LA CABECERA
                    _itemCab.CODEMP = dataGridViewOCCab.Rows[dataGridViewOCCab.CurrentRow.Index].Cells[(int)Col_OCCab.CODEMP].Value.ToString();
                    _itemCab.ORDENCOMPRA_ID = Convert.ToInt32(dataGridViewOCCab.Rows[dataGridViewOCCab.CurrentRow.Index].Cells[(int)Col_OCCab.NRO_OC].Value);
                    //PASO EL USUARIO LOGEADO
                    _itemCab.USUARIOAUTORIZA = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();
                    
                    //ACTUALIZO CABECERA E ITEMS
                    _auto.AutorizaOrdenCompra(_items, _itemCab);

                    if (_selecciono)
                    {
                        MessageBox.Show("La autorización se guardó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult _result = MessageBox.Show("Desea enviar al Proveedor la Orden de Compra por mail?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (_result == System.Windows.Forms.DialogResult.OK)
                        {
                           
                            //ENVIO POR MAIL, SOLO LOS QUE SELECCIONO Y SI ESTE PROVEEDOR TIENE UN MAIL VÁLIDO
                            if (_selecciono)
                            {
                               //VERIFICO QUE ESTE PROVEEDOR TENGA CARGADO AL MENOS UN MAIL
                               if(dataGridViewOCCab.Rows[dataGridViewOCCab.CurrentRow.Index].Cells[(int)Col_OCCab.EMAIL].Value == null || dataGridViewOCCab.Rows[dataGridViewOCCab.CurrentRow.Index].Cells[(int)Col_OCCab.EMAIL].Value == string.Empty)
                               {
                                    MessageBox.Show("Este proveedor no tiene cargado ninguna dirección de mail", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                               }
                                

                                if( GenerarPDFOC(_itemCab.CODEMP, _itemCab.ORDENCOMPRA_ID, dataGridViewOCCab.Rows[dataGridViewOCCab.CurrentRow.Index].Cells[(int)Col_OCCab.EMAIL].Value.ToString()))
                                {
                                    MessageBox.Show("Mail enviado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo enviar el mail al proveedor, verifique si tiene cargado correctamente una dirección de mail", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }

                           

                        }
                    

                        TraeOCPendientes();
                        dataGridViewOCItem.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar al menos un Articulo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

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

     private void checkBoxSeleccionar_CheckedChanged(object sender, EventArgs e)
    {
        if (dataGridViewOCItem.Rows.Count > 0)
        {
                if (this.checkBoxSeleccionar.Checked)
                {


                    foreach (DataGridViewRow item in dataGridViewOCItem.Rows)
                    {
                        item.Cells[(int)Col_OCItem.AUTORIZA].Value = 1;
                    }
                }
                else
                {

                    foreach (DataGridViewRow item in dataGridViewOCItem.Rows)
                    {
                        item.Cells[(int)Col_OCItem.AUTORIZA].Value = 0;
                    }

                }

                CalculaImporte();
        }
    }



        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewOCCab_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewOCCab.IsCurrentCellDirty)
                dataGridViewOCCab.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewOCItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int iColumn = dataGridViewOCItem.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_OCItem.CANTIDAD || iColumn == (int)Col_OCItem.PRECIO)
            {
                CalculaImporte();
            }          
        }
    }
}
