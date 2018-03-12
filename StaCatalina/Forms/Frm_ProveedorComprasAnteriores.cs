using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;
using System.Configuration;
namespace StaCatalina.Forms
{
    public partial class Frm_ProveedorComprasAnteriores : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        #endregion
        public Frm_ProveedorComprasAnteriores()
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

        private bool VerificaIngreso()
        {

            try
            {
                if (this.textBoxAnio.Text == string.Empty)
                {
                    this.errorProvider1.SetError(this.textBoxAnio, "Debe ingresar año");
                    this.textBoxAnio.Focus();
                    return false;
                }
                else
                {
                    this.errorProvider1.SetError(this.textBoxAnio, "");
                }

                if (this.textBoxMes.Text == string.Empty)
                {
                    this.errorProvider1.SetError(this.textBoxMes, "Debe ingresar mes");
                    this.textBoxMes.Focus();
                    return false;
                }
                else
                {

                    this.errorProvider1.SetError(this.textBoxMes, "");
                }

                if (Convert.ToInt32(this.textBoxMes.Text) > 12)
                {
                    this.errorProvider1.SetError(this.textBoxMes, "el mes no puede ser mayor que 12");
                    this.textBoxMes.Focus();
                    return false;
                }
                else
                {
                   this.errorProvider1.SetError(this.textBoxMes, "");
                 
                }

              

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }
        private void Frm_ProveedorComprasAnteriores_Load(object sender, EventArgs e)
        {
            try

            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();

                this.comboBoxEmpresa.SelectedIndex = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString() == "EGES")? 0: 1;

                this.textBoxAnio.Text = DateTime.Now.Year.ToString();
                this.textBoxMes.Text = DateTime.Now.Month.ToString();
                this.textBoxAnio.Focus();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void textBoxAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxAnio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxMes.Focus();
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if(VerificaIngreso() )
                {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //CultureInfo culture = new CultureInfo("en-US");

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "ProveedoresSinMovimientos.rpt";
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
                ParametroValue.Value = (comboBoxEmpresa.SelectedIndex == 0) ? "EGES": "RSC";
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

               //2° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@MesIncluir";
                ParametroValue.Value =  (textBoxMes.Text.Length == 1) ? this.textBoxMes.Text.ToString().PadLeft(2,'0'): textBoxMes.Text.ToString();
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@AnioIncluir";
                ParametroValue.Value = this.textBoxAnio.Text;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //4 PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Tipo";
                if(this.radioButtonMismaEmpresa.Checked)
                {
                    ParametroValue.Value = "EEMP"; // que operaron en los ultimos 3 meses, pero no en el mes actual de la misma empresa
                }
                else
                {
                    ParametroValue.Value = "OEMP"; // las que no compraron en este mes, pero comprron en la otra empresa

                }
               
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                    _Reporte.Parameters = Parametros;
                _Reporte.Reporte = objReport;
                _Reporte.Show();

                }
        

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
