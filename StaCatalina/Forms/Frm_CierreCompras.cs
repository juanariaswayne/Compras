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
using System.IO;
using System.Net.Mail;
using System.Net;
namespace StaCatalina.Forms
{
    public partial class Frm_CierreCompras : Plantilla
    {
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        #region Functions
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
            public Frm_CierreCompras()
            {
                InitializeComponent();
            }

            private void Sintetico(DateTime _fechaDesde,DateTime _fechaHasta, double _porcent)
            {
                try 
	            {
                    StaCatalina.Forms.Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();

                    if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                    {
                        String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IngresoCompras_Sintetico.rpt";
                        objReport.Load(reportPath);
                    }

                    if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "RSC")
                    {
                        String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IngresoCompras_Sintetico_RSC.rpt";
                        objReport.Load(reportPath);
                    }

                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;

                    // PARAMETROS DE CONEXION
                    TableLogOnInfo logoninfo = new TableLogOnInfo();
                    logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source"];
                    if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                    {
                        logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["Catalog"];
                    }
                    else
                    {
                        logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogSBDARSC"];
                    }
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
                    ParametroField.Name = "@FechaContDesde";
                    ParametroValue.Value = _fechaDesde.ToString("yyyy-MM-dd 00:00:00");
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@FechaContHasta";
                    ParametroValue.Value = _fechaHasta.ToString("yyyy-MM-dd 23:59:59");
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);
                    
                    //3° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@PorcDistrVen";
                    ParametroValue.Value = _porcent;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //4° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Empresa";
                    ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();
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
            private void DetalleUnidad(DateTime _fechaDesde, DateTime _fechaHasta, double _porcent, string _unidad)
            {
                try
                {
                    StaCatalina.Forms.Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();

                    if (radioButtonPorRubro.Checked)
                    {
                    // **************** NO SE USA
                        String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IngresoCompras_Detallado_Unidades.rpt";
                        objReport.Load(reportPath);
                    }

                    if (this.radioButtonPorCuenta.Checked)
                    {
                        //SOLO SE USA ESTE
                        String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IngresoCompras_Detallado_Unidades_CuentaContable.rpt";
                        objReport.Load(reportPath);
                    }

                    if (this.radioButtonPorMedicamentos.Checked)
                    {
                    // **************** NO SE USA
                        String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IngresoCompras_Detallado_Unidades_Detalle_Producto.rpt";
                        objReport.Load(reportPath);
                    }
                     
                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;

                    // PARAMETROS DE CONEXION
                    TableLogOnInfo logoninfo = new TableLogOnInfo();
                    logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source"];
                    if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                    {
                        logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["Catalog"];
                    }
                    else
                    {
                        logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogSBDARSC"];
                    }
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
                    ParametroField.Name = "@FechaContDesde";
                    ParametroValue.Value = _fechaDesde.ToString("yyyy-MM-dd 00:00:00");
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@FechaContHasta";
                    ParametroValue.Value = _fechaHasta.ToString("yyyy-MM-dd 23:59:59");
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //3° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@PorcDistrVen";
                    ParametroValue.Value = _porcent;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //4° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Unidad";
                    ParametroValue.Value = _unidad;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //4° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Empresa";
                    ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();
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

        private bool EnvioInformeUsuarios(DateTime _fechaDesde, DateTime _fechaHasta, string _unidad, string _empresa, int id_usuario,string Email)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();
                if (_empresa == "EGES")
                {
                    //SOLO SE USA ESTE
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "Informe_Gastos.rpt";
                    objReport.Load(reportPath);
                }

                if (_empresa == "RSC") //SIGO UTILIZANDO EL MISMO REPORTE.. PARA ESTA EMPRESA NO CAMBIA NADA.. YA ES CONSOLIDADO
                {
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "Informe_Gastos_RSC.rpt";
                    objReport.Load(reportPath);
                }
                objReport.Refresh();
                objReport.ReportOptions.EnableSaveDataWithReport = false;

                // PARAMETROS DE CONEXION
                TableLogOnInfo logoninfo = new TableLogOnInfo();
                logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source"];
                if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                {
                    logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["Catalog"];
                }
                else
                {
                    logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogSBDARSC"];
                }
                logoninfo.ConnectionInfo.UserID = ConfigurationManager.AppSettings["User ID"];
                logoninfo.ConnectionInfo.Password = ConfigurationManager.AppSettings["Password"];
                logoninfo.ConnectionInfo.IntegratedSecurity = false;
                Tables tables = objReport.Database.Tables;
                foreach (Table table in tables)
                {
                    table.ApplyLogOnInfo(logoninfo);
                }
                // FIN PARAMETROS DE CONEXION

                //PAOS LOS PARAMTROS EN ORDEN

                objReport.SetParameterValue("@FechaContDesde", _fechaDesde.ToString("yyyy-MM-dd 00:00:00"));
                objReport.SetParameterValue("@FechaContHasta", _fechaHasta.ToString("yyyy-MM-dd 23:59:59"));
                objReport.SetParameterValue("@PorcDistrVen", 0); //NO SE USA EN EL INFORME
                if (_empresa == "RSC")
                {
                    objReport.SetParameterValue("@Unidad", _unidad);
                }
                objReport.SetParameterValue("@Empresa", Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim());
                objReport.SetParameterValue("@Usuario", id_usuario);

                
                string _path =ConfigurationManager.AppSettings["PDF"] + "\\PDF\\" + "Informe_Gastos.PDF";
                    
                objReport.ExportToDisk(ExportFormatType.PortableDocFormat, _path.ToString());
                             
                if( EnviarMail( _path, Email))
                {
                    //BORRO EL REPORTE... QUE GENERE EN PDF
                    objReport.Dispose();
                    File.Delete(_path);
                    return true;
                }
                else
                {
                    //BORRO EL REPORTE... QUE GENERE EN PDF
                    objReport.Dispose();
                    File.Delete(_path);
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private void DetalleConsolidado(DateTime _fechaDesde, DateTime _fechaHasta,string _unidad ,string _empresa)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();
                if (_empresa == "EGES")
                {
                    //SOLO SE USA ESTE
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IngresoCompras_Detallado_Unidades_CuentaContable_Consolidado.rpt";
                    objReport.Load(reportPath);
                }

                if(_empresa == "RSC") //SIGO UTILIZANDO EL MISMO REPORTE.. PARA ESTA EMPRESA NO CAMBIA NADA.. YA ES CONSOLIDADO
                {
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IngresoCompras_Detallado_Unidades_CuentaContable.rpt";
                    objReport.Load(reportPath);
                }
                objReport.Refresh();
                objReport.ReportOptions.EnableSaveDataWithReport = false;

                // PARAMETROS DE CONEXION
                TableLogOnInfo logoninfo = new TableLogOnInfo();
                logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source"];
                if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                {
                    logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["Catalog"];
                }
                else
                {
                    logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogSBDARSC"];
                }
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
                ParametroField.Name = "@FechaContDesde";
                ParametroValue.Value = _fechaDesde.ToString("yyyy-MM-dd 00:00:00");
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaContHasta";
                ParametroValue.Value = _fechaHasta.ToString("yyyy-MM-dd 23:59:59");
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@PorcDistrVen";
                ParametroValue.Value = 0; //NO SE USA EN ESTE INFORME
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                if(_empresa == "RSC")
                {
                    //4° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Unidad";
                    ParametroValue.Value = _unidad;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);
                }
                
                //4° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Empresa";
                ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();
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

        private void DetalleADistribuir(DateTime _fechaDesde,DateTime _fechaHasta)
            {
                try 
	            {
                    StaCatalina.Forms.Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();

                    //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Detallado_A_Distribuir.rpt";
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IngresoCompras_Detallado_A_Distribuir.rpt";
                    objReport.Load(reportPath);
                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;

                    // PARAMETROS DE CONEXION
                    TableLogOnInfo logoninfo = new TableLogOnInfo();
                    logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source"];
                    if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                    {
                        logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["Catalog"];
                    }
                    else
                    {
                        logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogSBDARSC"];
                    }
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
                    ParametroField.Name = "@FechaContDesde";
                    ParametroValue.Value = _fechaDesde.ToString("yyyy-MM-dd 00:00:00");
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@FechaContHasta";
                    ParametroValue.Value = _fechaHasta.ToString("yyyy-MM-dd 23:59:59");
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //4° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Empresa";
                    ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();
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

        private bool  EnviarMail(string _path,string Email)
        {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(Email.ToString()));
            //email.CC.Add(new MailAddress(EmailCC));
            email.From = new MailAddress("sistemas@csantacatalina.com.ar");
            email.Subject = "Informe de Gastos";
            email.Body = "Informe de Gastos para Controlar";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            email.Attachments.Add(new Attachment(_path));

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("sistemas@csantacatalina.com.ar", "sys/TSH.360");

            string output = null;

            try
            {
                smtp.Send(email);
                email.Dispose();
                //BORRO EL REPORTE... QUE GENERE EN PDF
                //File.Delete(_path);
                smtp.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                //BORRO EL REPORTE... QUE GENERE EN PDF
                //File.Delete(_path);
                email.Dispose();
                smtp.Dispose();
                output = "Error enviando correo electrónico: " + ex.Message;
                return false;
            }

            //Console.WriteLine(output);
        }

        #endregion

        #region Events
        private void textBoxPorcentDistrib_KeyPress(object sender, KeyPressEventArgs e)
            {
                //if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 )
                //{
                //    e.Handled = true;
                //}
                CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
                if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }

            private void dateTimeDesde_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                    this.dateTimeHasta.Focus();
            }

            private void dateTimeHasta_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                    this.textBoxPorcentDistrib.Focus();
            }


            private void toolStripButtonPrint_Click(object sender, EventArgs e)
            {

                //ANTES DE EJECUTAR EL INFORME, VERIRFICO QUE SE HAYA PRORRATEADO ESTE MES......
                //if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim() == "EGES")
                //{
                //    SBDAEGESEntities _Mod = new SBDAEGESEntities();


                //    var _query = (_Mod.USR_ControlProrrateoEmpresaEGES.Where(c => c.Anio == dateTimeDesde.Value.Year && c.Mes == dateTimeDesde.Value.Month).OrderByDescending(c => c.FechaProrrateoEmpresa).FirstOrDefault());
                //    if (_query == null)
                //    {
                //        MessageBox.Show("Antes de Emitir este informe, debe generar el proceso de Prorrateo de Facturas entre Empresas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        return;
                //    }



                //}

                //if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim() == "RSC")
                //{
                //    SBDARSCEntities _Mod = new SBDARSCEntities();

                //    var _query = (from M in _Mod.USR_ControlProrrateoEmpresa where M.Anio == dateTimeDesde.Value.Year && M.Mes == dateTimeDesde.Value.Month select M.FechaProrrateoEmpresa).Max();
                //    if (_query == null)
                //    {
                //        MessageBox.Show("Antes de Emitir este informe, debe generar el proceso de Prorrateo de Facturas entre Empresas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        return;
                //    }

                //}


            //deshabilito boton
            toolStripButtonPrint.Enabled = false;
                try
                {
                    if (this.textBoxPorcentDistrib.Text != string.Empty &&  radioButtonCondistribución.Checked)
                    {
                        if (this.radioButtonSintetico.Checked)
                        {
                            this.Sintetico(Convert.ToDateTime(this.dateTimeDesde.Value.ToShortDateString()), Convert.ToDateTime(this.dateTimeHasta.Value.ToShortDateString()), Convert.ToDouble(this.textBoxPorcentDistrib.Text.ToString()));
                        }
                        else //informe detallado, saco 3 informes
                        {

                        if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim() == "EGES")
                        {
                                this.DetalleUnidad(Convert.ToDateTime(this.dateTimeDesde.Value.ToShortDateString()), Convert.ToDateTime(this.dateTimeHasta.Value.ToShortDateString()), Convert.ToDouble(this.textBoxPorcentDistrib.Text.ToString()), "Venezuela");
                                this.DetalleUnidad(Convert.ToDateTime(this.dateTimeDesde.Value.ToShortDateString()), Convert.ToDateTime(this.dateTimeHasta.Value.ToShortDateString()), Convert.ToDouble(this.textBoxPorcentDistrib.Text.ToString()), "México");
                                this.DetalleADistribuir(Convert.ToDateTime(this.dateTimeDesde.Value.ToShortDateString()), Convert.ToDateTime(this.dateTimeHasta.Value.ToShortDateString()));
                        }
                        else
                        {
                               this.DetalleUnidad(Convert.ToDateTime(this.dateTimeDesde.Value.ToShortDateString()), Convert.ToDateTime(this.dateTimeHasta.Value.ToShortDateString()), Convert.ToDouble(this.textBoxPorcentDistrib.Text.ToString()), "Catamarca");
                        }

                           
                        }
                        
                    }
                    else // ***** INFORME SIN DISTRIBUCION **************
                    {
                        if (radioButtonSindistribucion.Checked)
                        {
                            //INFORME DETALLADO SIN DISTRIBUCION
                            if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim() == "EGES")
                            {
                                if (!this.checkBoxEnviaInforme.Checked)
                                {
                                    this.DetalleConsolidado(Convert.ToDateTime(this.dateTimeDesde.Value.ToShortDateString()), Convert.ToDateTime(this.dateTimeHasta.Value.ToShortDateString()), "", Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
                                }
                                //VERIFICO SI TIENE EL TILDE DE ENVIO DE INFORME A LOS USUARIOS
                                if (this.checkBoxEnviaInforme.Checked)
                                {
                                    BLL.Procedures.USUARIO_CON_CUENTAS _cuentaUsu = new BLL.Procedures.USUARIO_CON_CUENTAS();
                                    bool enviado=false;
                                    foreach (Entities.Procedures.USUARIO_CON_CUENTAS item in _cuentaUsu.ItemList())
                                    {
                                        //POR CADA USUARIO LLAMO AL INFORME Y SE LO ENVIO POR MAIL
                                        if (this.EnvioInformeUsuarios(Convert.ToDateTime(this.dateTimeDesde.Value.ToShortDateString()), Convert.ToDateTime(this.dateTimeHasta.Value.ToShortDateString()),"",Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(), item.id_usuario, item.email))
                                        {
                                            enviado = true;
                                            
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al enviar el mail, compruebe la dirección de mail del usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            return;
                                        }
                                    }
                                    if(enviado)
                                        MessageBox.Show("Mail enviado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }//FIN ENVIA INFORME POR MAIL EMPRESA EGES
                            }
                            else // RSC
                            {
                                if (!this.checkBoxEnviaInforme.Checked)
                                {
                                    this.DetalleConsolidado(Convert.ToDateTime(this.dateTimeDesde.Value.ToShortDateString()), Convert.ToDateTime(this.dateTimeHasta.Value.ToShortDateString()), "Catamarca", Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
                                }
                                //VERIFICO SI TIENE EL TILDE DE ENVIO DE INFORME A LOS USUARIOS
                                if (this.checkBoxEnviaInforme.Checked)
                                {
                                    BLL.Procedures.USUARIO_CON_CUENTAS _cuentaUsu = new BLL.Procedures.USUARIO_CON_CUENTAS();
                                    bool enviado = false;
                                    foreach (Entities.Procedures.USUARIO_CON_CUENTAS item in _cuentaUsu.ItemList())
                                    {
                                        //POR CADA USUARIO LLAMO AL INFORME Y SE LO ENVIO POR MAIL SOLO CATAMARCA
                                        if (this.EnvioInformeUsuarios(Convert.ToDateTime(this.dateTimeDesde.Value.ToShortDateString()), Convert.ToDateTime(this.dateTimeHasta.Value.ToShortDateString()), "Catamarca", Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(), item.id_usuario, item.email))
                                        {
                                            enviado = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al enviar el mail, compruebe la dirección de mail del usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            return;
                                        }

                                    }
                                    if (enviado)
                                        MessageBox.Show("Mail enviado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            }//FIN INFORME

                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar un porcentaje de distribución para Venezuela", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    //habilito boton             
                    toolStripButtonPrint.Enabled = true;
                }
                catch (Exception ex)
                {
                    toolStripButtonPrint.Enabled = true;
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
               
            }

            private void CierreCompras_Load(object sender, EventArgs e)
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();

                this.dateTimeDesde.Value = Convert.ToDateTime( DateTime.Now.ToShortDateString());
                this.dateTimeHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                this.labelDistribucion.Text = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? "% Distribución Venezuela:" : "% Distribución Catamarca:";
                this.textBoxPorcentDistrib.Text = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? string.Empty : "100";
                this.textBoxPorcentDistrib.Enabled = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? true : false;

            }
        #endregion

            private void radioButtonDetallado_CheckedChanged(object sender, EventArgs e)
            {
                if (this.radioButtonDetallado.Checked && radioButtonSindistribucion.Checked)
                {
                    // this.groupBoxTipo.Visible = true;
                    this.checkBoxEnviaInforme.Visible = true;
                }
            }

        private void radioButtonSintetico_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonSintetico.Checked)
            {
                this.groupBoxTipo.Visible = false;
                this.checkBoxEnviaInforme.Visible = false;
                this.checkBoxEnviaInforme.Checked = false;
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonSindistribucion_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPorcentDistrib.Enabled = false;
            if (this.radioButtonDetallado.Checked && radioButtonSindistribucion.Checked)
            {
                // this.groupBoxTipo.Visible = true;
                this.checkBoxEnviaInforme.Visible = true;
            }
        }

        private void radioButtonCondistribución_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPorcentDistrib.Enabled = true;
            this.checkBoxEnviaInforme.Visible = false;
            this.checkBoxEnviaInforme.Checked = false;
        }
    }
}
