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
    public partial class FrmImprimeReqInterno : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        #endregion

        #region Funciones
        public FrmImprimeReqInterno()
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

        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmImprimeReqInterno_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            this.radioButtonTodo.Checked = true;
            this.dateTimePickerFechaDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.dateTimePickerFechaHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.Text = "Informe Estado de Requerimientos Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "InformeRequerimientos.rpt";
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
                ParametroValue.Value = this.dateTimePickerFechaDesde.Value.ToString("yyyy-MM-dd 00:00:00");
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaHasta";
                ParametroValue.Value = this.dateTimePickerFechaHasta.Value.ToString("yyyy-MM-dd 23:59:59");
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3er PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Tipo";
                if (this.radioButtonTodo.Checked)
                {
                    ParametroValue.Value = "TOD";
                }
                if (this.radioButtonAnulados.Checked)
                {
                    ParametroValue.Value = "ANU";
                }
                if (this.radioButtonRechazados.Checked)
                {
                    ParametroValue.Value = "REC";
                }
                if (this.radioButtonAutorizados.Checked)
                {
                    ParametroValue.Value = "AUT";
                }
                if (this.radioButtonPendientes.Checked)
                {
                    ParametroValue.Value = "PEN";
                }
                if (this.radioButtonSectorUnico.Checked)
                {
                    ParametroValue.Value = "SEC";
                }

                if (this.radioButtonPorNro.Checked)
                {
                    ParametroValue.Value = "NRO";
                }

                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);


                //4° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@codEmp";
                ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //5° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Sector";
                if (this.radioButtonSectorUnico.Checked)
                {
                    ParametroValue.Value = Clases.Usuario.UsuarioLogeado.Id_Sector;
                }
                else
                {
                    ParametroValue.Value = null;
                }

                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //6° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@usuario_id";
                ParametroValue.Value = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //7° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@NroReq";
                ParametroValue.Value = Convert.ToInt32(textBoxNroReq.Text == "" ? "0" : textBoxNroReq.Text);
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

        private void radioButtonPorNro_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNroReq.Focus();
        }
    }
}
