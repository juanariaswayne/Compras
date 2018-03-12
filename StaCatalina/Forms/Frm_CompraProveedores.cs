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
    public partial class Frm_CompraProveedores : Plantilla
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
                if (!escritura) { this.toolStripButtonPrint.Enabled = false; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
        
        public Frm_CompraProveedores()
            {
                InitializeComponent();
            }

            private void CargarProveedor()
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
                    _itemSeleccion.pro_razsoc = "<Seleccione un Proveedor>";
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

            private void MostrarCompras( string _proveed)
            {
                try
                {
                    StaCatalina.Forms.Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();

                   
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "UltimasComprasProveedor.rpt";
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
                    ParametroField.Name = "@codProv";
                    ParametroValue.Value = _proveed;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2er PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@codEmp";
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
        #endregion

        #region Eventos
            private void FrmCompraProveedores_Load(object sender, EventArgs e)
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();

                CargarProveedor();

            }

        #endregion

            private void toolStripButtonPrint_Click(object sender, EventArgs e)
            {
                if (this.comboBoxProveed.SelectedIndex != 0)
                {
                    MostrarCompras(this.comboBoxProveed.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
