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
    public partial class Frm_OPSinImputar : StaCatalina.Plantilla
    {
        public Frm_OPSinImputar()
        {
            InitializeComponent();
        }

        private void buttonGenera_Click(object sender, EventArgs e)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();


                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "OPSinImputar.rpt";
                objReport.Load(reportPath);


                objReport.Refresh();
                objReport.ReportOptions.EnableSaveDataWithReport = false;

                //crystalReportViewer.ShowGroupTreeButton = true;
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
                ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                ////2° PARAMETRO
                //ParametroField = new ParameterField();
                //ParametroValue = new ParameterDiscreteValue();
                //ParametroField.Name = "@codProv";
                //ParametroValue.Value = _proveed;
                //ParametroField.CurrentValues.Add(ParametroValue);
                //Parametros.Add(ParametroField);

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
