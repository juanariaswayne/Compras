using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_InformeControlLibreria : Form
    {
        #region Variables
        #endregion

        #region Funciones
        public Frm_InformeControlLibreria()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void Frm_InformeControlLibreria_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "InformeControlLibreria.rpt";
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
                ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Periodo";
                ParametroValue.Value = this.comboBoxPeriodo.Text;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Anio";
                ParametroValue.Value = this.comboBoxAnio.Text;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Tipo";
                if(this.radioButtonTotal.Checked)
                { ParametroValue.Value = "TOT"; }
                if (this.radioButtonFaltante.Checked)
                { ParametroValue.Value = "FAL"; }
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
    }
}
