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
using System.Globalization;
using System.Linq;
namespace StaCatalina.Forms
{
    public partial class Frm_InformePlanillaArqueo : Plantilla
    {
        #region Variables
        private List<Entities.Procedures.RUBROARTICULOS> _rubroItem = new List<Entities.Procedures.RUBROARTICULOS>();

        public List<Entities.Procedures.RUBROARTICULOS> Rubros
        {
            get { return _rubroItem; }
            set { _rubroItem = value; }

        }
        public IAddItem Opener { get; set; }
        #endregion

        #region Funciones

        public Frm_InformePlanillaArqueo()
        {
            InitializeComponent();
        }

        private void CargarRubros()
        {
            try
            {
                Entities.Procedures.RUBROARTICULOS _itemSeleccion = new Entities.Procedures.RUBROARTICULOS();
                BLL.Procedures.RUBROARTICULOS _rubroItem = new BLL.Procedures.RUBROARTICULOS();
                _rubroItem.Items();
                //Limpia el combo
                this.comboBoxRubro.SuspendLayout();
                this.comboBoxRubro.DataSource = null;
                this.comboBoxRubro.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.da1_desc = "<Todos los Rubros>";
                _itemSeleccion.da1_cod = "0";
                _rubroItem.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxRubro.DisplayMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_DESC;
                this.comboBoxRubro.ValueMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_COD;
                this.comboBoxRubro.DataSource = _rubroItem.Result.ToArray();
                this.comboBoxRubro.ResumeLayout();
                this.comboBoxRubro.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #endregion

        #region Eventos

        private void Frm_InformePlanillaArqueo_Load(object sender, EventArgs e)
        {
            CargarRubros();
        }

        #endregion

        private void comboBoxrubro_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "InformeArqueo.rpt";
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
                ParametroField.Name = "@Rubro";
                ParametroValue.Value = this.comboBoxRubro.SelectedValue;
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
