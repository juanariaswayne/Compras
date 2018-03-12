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
namespace StaCatalina.Stock
{
    public partial class Frm_IngresoDeStock_vs_FacturaBejerman : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        #endregion

        #region Funciones
        public Frm_IngresoDeStock_vs_FacturaBejerman()
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

        private void CargarProveedor(string _codEmp)
        {
            try
            {
                BLL.Procedures._H_PROVEEDORES _prov = new BLL.Procedures._H_PROVEEDORES();
                _prov.ItemList(_codEmp);
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

        #endregion

        #region Eventos
        private void Frm_IngresoDeStock_vs_FacturaBejerman_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            this.dateTimeDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.dateTimeHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
        }

        #endregion

        private void textBoxOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void radioButtonProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonProveedor.Checked)
            {
                comboBoxProveed.Enabled = true;
                textBoxOC.Enabled = false;
            }
        }

        private void radioButtonOC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOC.Checked)
            {
                textBoxOC.Enabled = true;
                comboBoxProveed.Enabled = false;
            }
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new StaCatalina.Forms.Reports();
                ReportDocument objReport = new ReportDocument();

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "Cumplimiento_OC_vs_IngresoStock.rpt";
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
                ParametroField.Name = "@Empresa";
                ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaDesde";
                ParametroValue.Value = this.dateTimeDesde.Value.ToString("yyyy-MM-dd 00:00:00");
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaHasta";
                ParametroValue.Value = this.dateTimeHasta.Value.ToString("yyyy-MM-dd 23:59:59");
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //4to PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Filtro";
                if (this.radioButtonTodos.Checked)
                {
                    ParametroValue.Value = "TODO";
                }
                if (this.radioButtonProveedor.Checked)
                {
                    ParametroValue.Value = "PROV";

                }
                if (this.radioButtonOC.Checked)
                {
                    ParametroValue.Value = "OCOM";

                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //6to PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@proveedor";
                if (this.radioButtonProveedor.Checked)
                {
                    ParametroValue.Value = this.comboBoxProveed.SelectedValue.ToString().Trim();

                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //7to PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@OrdenCompraAnalisis";
                if (this.radioButtonOC.Checked)
                {
                    ParametroValue.Value = textBoxOC.Text;

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

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
