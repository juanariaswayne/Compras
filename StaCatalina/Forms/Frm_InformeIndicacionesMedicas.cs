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

namespace StaCatalina.Forms
{
    public partial class Frm_InformeIndicacionesMedicas : Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        #endregion

        #region Funciones
        public Frm_InformeIndicacionesMedicas()
        {
            InitializeComponent();
        }

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

        private void InformeXDia()
        {
            try
            {

                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "InformeCantidadMedicamentos.rpt";
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
                ParametroField.Name = "@Fecha";               
                ParametroValue.Value = this.dateTimePickerDesde.Value.ToString("yyyyMMdd");
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);
                //2do PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Sede";
                if (this.comboBoxSede.SelectedIndex == 0)
                {
                    ParametroValue.Value = "VEN";
                }
                if (this.comboBoxSede.SelectedIndex == 1)
                {
                    ParametroValue.Value = "MEX";
                }
                if (this.comboBoxSede.SelectedIndex == 2)
                {
                    ParametroValue.Value = "CAT";
                }
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

        private void InformeXPaciente()
        {
            try
            {

                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "InformeCantidadMedPaciente.rpt";
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
                ParametroField.Name = "@Fecha";
                ParametroValue.Value = this.dateTimePickerDesde.Value.ToString("yyyyMMdd");
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);
                //2do PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Sede";
                if (this.comboBoxSede.SelectedIndex == 0)
                {
                    ParametroValue.Value = "VEN";
                }
                if (this.comboBoxSede.SelectedIndex == 1)
                {
                    ParametroValue.Value = "MEX";
                }
                if (this.comboBoxSede.SelectedIndex == 2)
                {
                    ParametroValue.Value = "CAT";
                }
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

        private void InformeXProyeccion()
        {
            try
            {

                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "InformeProyeccionMensualIM.rpt";
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
                ParametroField.Name = "@FechaDesde";
                ParametroValue.Value = Convert.ToInt32(this.dateTimePickerDesde.Value.ToString("yyyyMMdd"));
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);
                //2do PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaHasta";
                ParametroValue.Value = Convert.ToInt32(this.dateTimePickerHasta.Value.ToString("yyyyMMdd"));
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);
                //3er PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Sede";
                if (this.comboBoxSede.SelectedIndex == 0)
                {
                    ParametroValue.Value = "VEN";
                }
                if (this.comboBoxSede.SelectedIndex == 1)
                {
                    ParametroValue.Value = "MEX";
                }
                if (this.comboBoxSede.SelectedIndex == 2)
                {
                    ParametroValue.Value = "CAT";
                }
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


        #endregion


        #region Eventos
        private void Frm_InformeIndicacionesMedicas_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            this.comboBoxTipoInf.SelectedIndex = 0;
            this.comboBoxSede.SelectedIndex = 2;
            
        }

        private void comboBoxTipoInf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxTipoInf.SelectedIndex == 0)
            {
                this.dateTimePickerDesde.Show();
                this.dateTimePickerHasta.Show();
            }
            if (this.comboBoxTipoInf.SelectedIndex == 1)
            {
                this.dateTimePickerDesde.Show();
                this.dateTimePickerHasta.Hide();
            }
            if (this.comboBoxTipoInf.SelectedIndex == 2)
            {
                this.dateTimePickerDesde.Show();
                this.dateTimePickerHasta.Hide();
            }

        }

        #endregion

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxTipoInf.SelectedIndex == 1)
                {
                    InformeXDia();                
                }
                if (this.comboBoxTipoInf.SelectedIndex == 2)
                {
                    InformeXPaciente();
                }
                if (this.comboBoxTipoInf.SelectedIndex == 0)
                {
                    InformeXProyeccion();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        
    }
}
