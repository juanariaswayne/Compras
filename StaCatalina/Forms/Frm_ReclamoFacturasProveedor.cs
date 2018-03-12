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
namespace StaCatalina.Forms
{
    public partial class Frm_ReclamoFacturasProveedor : StaCatalina.Plantilla
    {
        #region Variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
        #endregion
        #region Funciones
            public Frm_ReclamoFacturasProveedor()
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
            private void CargarProveedores()
            {
                try
                {
                    BLL.Procedures._H_PROVEEDORES _prov = new BLL.Procedures._H_PROVEEDORES();
                    _prov.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim());
                    Entities.Procedures._H_PROVEEDORES _itemSeleccion = new Entities.Procedures._H_PROVEEDORES();

                    //Limpia el combo
                    this.comboBoxProveed.SuspendLayout();
                    this.comboBoxProveed.DataSource = null;
                    this.comboBoxProveed.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.pro_razsoc = "<Todos los Proveedores>";
                    _itemSeleccion.pro_cod = "0";
                    _prov.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxProveed.DisplayMember = BLL.Procedures._H_PROVEEDORES.ColumnNames.PRO_RAZSOC;
                    this.comboBoxProveed.ValueMember = BLL.Procedures._H_PROVEEDORES.ColumnNames.PRO_COD;
                    this.comboBoxProveed.DataSource = _prov.Result.ToArray();

                    this.comboBoxProveed.ResumeLayout();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        private void MostrarReclamos (string _empresa,string _proveed)
        {
             try
                {
                    StaCatalina.Forms.Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();


                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "ReclamoFacturasProveedor.rpt";
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
                    ParametroValue.Value = _empresa;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@codProv";
                    ParametroValue.Value = _proveed;
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
            private void FrmReclamoFacturasProveedor_Load(object sender, EventArgs e)
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
                CargarProveedores();
            }

            private void toolStripButtonPrint_Click(object sender, EventArgs e)
            {
                try
                {
                    string _proveed = (this.comboBoxProveed.SelectedValue.ToString() == "0")? null:this.comboBoxProveed.SelectedValue.ToString();
                    MostrarReclamos(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim(), _proveed);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
