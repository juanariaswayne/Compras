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
    public partial class Frm_InformeOC : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        #endregion

        #region Funciones
         public Frm_InformeOC()
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

        private void Frm_InformeOC_Load(object sender, EventArgs e)
        {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
                this.radioButtonTodo.Checked = true;
                if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                {
                    this.checkBoxEGES.Checked = true;
                    this.checkBoxRSC.Checked = false;
                this.checkBoxGSC.Checked = false;
                
            }
                if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "RSC")
                {
                    this.checkBoxEGES.Checked = false;
                    this.checkBoxRSC.Checked = true;
                this.checkBoxGSC.Checked = false;
                
            }

            if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "GSC")
            {
                this.checkBoxGSC.Checked = true;
                this.checkBoxEGES.Checked = false;
                this.checkBoxRSC.Checked = false;
            }

            this.dateTimeFechaDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                this.dateTimeFechaHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

        }
         
        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "InformeOrdenesDeCompras.rpt";
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
                ParametroValue.Value = this.dateTimeFechaDesde.Value.ToString("yyyy-MM-dd 00:00:00");
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaHasta";
                ParametroValue.Value = this.dateTimeFechaHasta.Value.ToString("yyyy-MM-dd 23:59:59");
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
                if (this.radioButtonPendAuto.Checked)
                {
                    ParametroValue.Value = "PEN";
                }
                if (this.radioButtonCompleta.Checked)
                {
                    ParametroValue.Value = "COM";
                }
                if (this.radioButtonProveedor.Checked)
                {
                    ParametroValue.Value = "PRO";
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //4to PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@codEmp";
                if (this.checkBoxEGES.Checked && this.checkBoxRSC.Checked)
                {
                    ParametroValue.Value = "TODO";
                }
                if (this.checkBoxEGES.Checked)
                {
                    ParametroValue.Value = "EGES";
                }
                if (this.checkBoxRSC.Checked)
                {
                    ParametroValue.Value = "RSC";
                }
                if (this.checkBoxGSC.Checked)
                {
                    ParametroValue.Value = "GSC";
                }
                if (this.checkBoxEGES.Checked == false && this.checkBoxRSC.Checked == false && this.checkBoxGSC.Checked == false)
                {
                    MessageBox.Show("Debe seleccionar  una Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //5° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Proveed";
                if (radioButtonProveedor.Checked)
                {
                    if (this.comboBoxProveed.SelectedIndex > 0)
                    {
                        ParametroValue.Value = this.comboBoxProveed.SelectedValue.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    ParametroValue.Value = null;
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

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxEGES_Click(object sender, EventArgs e)
        {
            this.checkBoxRSC.Checked = false;
        }

        private void checkBoxRSC_Click(object sender, EventArgs e)
        {
            this.checkBoxEGES.Checked = false;
        }

        private void checkBoxEGES_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxEGES.Checked)
            {
                CargarProveedor("EGES");
            }

        }

        private void checkBoxRSC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRSC.Checked)
            {
                CargarProveedor("RSC");
            }
        }

        private void radioButtonProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonProveedor.Checked)
            {
                labelProveedor.Visible = true;
                comboBoxProveed.Visible = true;
            }
        }

        private void radioButtonTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTodo.Checked)
            {
                labelProveedor.Visible = false;
                comboBoxProveed.Visible = false;
            }
        }

        private void radioButtonAnulados_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAnulados.Checked)
            {
                labelProveedor.Visible = false;
                comboBoxProveed.Visible = false;
            }
        }

        private void radioButtonAutorizados_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAutorizados.Checked)
            {
                labelProveedor.Visible = false;
                comboBoxProveed.Visible = false;
            }
        }

        private void radioButtonRechazados_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRechazados.Checked)
            {
                labelProveedor.Visible = false;
                comboBoxProveed.Visible = false;
            }
        }

        private void radioButtonPendAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPendAuto.Checked)
            {
                labelProveedor.Visible = false;
                comboBoxProveed.Visible = false;
            }
        }

        private void radioButtonCompleta_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCompleta.Checked)
            {
                labelProveedor.Visible = false;
                comboBoxProveed.Visible = false;
            }
        }

        private void checkBoxGSC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGSC.Checked)
            {
                CargarProveedor("GSC");
            }
        }
    }
}
