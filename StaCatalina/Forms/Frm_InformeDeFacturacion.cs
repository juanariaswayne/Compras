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
    public partial class Frm_informeDeFacturacion : Plantilla
    {

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

 #region Funciones
            private void OperacionesDelUsuario()
            {
                try
                {
                    if (!escritura) { this.informeFacturacion.Enabled = false; }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

 #endregion

            public Frm_informeDeFacturacion()
        {
            InitializeComponent();
        }
#region Eventos
        private void informeFacturacion_Click(object sender, EventArgs e)
        {
            StaCatalina.Forms.Reports _Reporte = new Reports();
            ReportDocument objReport = new ReportDocument();

            String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "InformeFacturacion.rpt";
            objReport.Load(reportPath);

            objReport.Refresh();
            objReport.ReportOptions.EnableSaveDataWithReport = false;

            // PARAMETROS DE CONEXION
            TableLogOnInfo logoninfo = new TableLogOnInfo();
            logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source_DATA"];
            if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
            {
                logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogDATA_EGES"];
            }
            else
            {
                logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogDATA_RSC"];
            }

            logoninfo.ConnectionInfo.UserID = ConfigurationManager.AppSettings["User ID"];
            logoninfo.ConnectionInfo.Password = ConfigurationManager.AppSettings["Password_DATA"];
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
            ParametroField.Name = "@FECHA_DESDE";
            ParametroValue.Value = this.DateTimefechaDesde.Value.ToString("yyyy-MM-dd 00:00:00");
            ParametroField.CurrentValues.Add(ParametroValue);
            Parametros.Add(ParametroField);

            //2do PARAMETRO
            ParametroField = new ParameterField();
            ParametroValue = new ParameterDiscreteValue();
            ParametroField.Name = "@FECHA_HASTA";
            ParametroValue.Value = this.DateTimefechaHasta.Value.ToString("yyyy-MM-dd 23:59:59");
            ParametroField.CurrentValues.Add(ParametroValue);
            Parametros.Add(ParametroField);

            //3er PARAMETRO
            ParametroField = new ParameterField();
            ParametroValue = new ParameterDiscreteValue();
            ParametroField.Name = "@OPA";
            
            if (this.check_Venezuela.Checked && !this.check_Mexico.Checked)
            {
                ParametroValue.Value = "V";
            }
            if (!this.check_Venezuela.Checked && this.check_Mexico.Checked)
            {
                ParametroValue.Value = "M";
            }

            if (this.check_Venezuela.Checked && this.check_Mexico.Checked || this.check_Catamarca.Checked)
            {
                ParametroValue.Value = "T";
            }

            ParametroField.CurrentValues.Add(ParametroValue);
            Parametros.Add(ParametroField);

            _Reporte.Parameters = Parametros;
            _Reporte.Reporte = objReport;
            _Reporte.Show();
        }


        private void informeDeFacturacion_Load(object sender, EventArgs e)
        {
          MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();

            this.check_Mexico.Visible=(Clases.Usuario.EmpresaLogeada.EmpresaIngresada == "EGES")?true:false;
            this.check_Venezuela.Visible = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada == "EGES") ? true:false;
            this.check_Catamarca.Visible = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada == "EGES") ? false : true;
        }
    }
}
#endregion
