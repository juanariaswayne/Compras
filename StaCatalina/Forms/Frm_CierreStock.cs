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
    public partial class Frm_CierreStock : StaCatalina.Plantilla
    {
        #region Variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;
            
        #endregion

        #region funciones
            public Frm_CierreStock()
            {
                InitializeComponent();
            }

            private void OperacionesDelUsuario()
            {
                try
                {
                    if (!escritura) { this.toolStripButtonSave.Enabled = false; }

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
                    if (this.textBoxAnio.Text == string.Empty )
                    {
                        this.errorProvider1.SetError(this.textBoxAnio, "Debe ingresar año");
                        this.textBoxAnio.Focus();
                        return false;
                    }

                    if (Convert.ToInt32(this.textBoxAnio.Text) < 2015)
                    {
                        this.errorProvider1.SetError(this.textBoxAnio, "Debe ingresar año");
                        this.textBoxAnio.Focus();
                        return false;
                    }
                    
                    if (Convert.ToInt32(this.textBoxMes.Text) > 12)
                    {
                        this.errorProvider1.SetError(this.textBoxMes, "el mes no puede ser mayor que 12");
                        this.textBoxMes.Focus();
                        return false;
                    }


                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


            }
        #endregion

        #region Eventos
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

            private void textBoxMes_KeyDown(object sender, KeyEventArgs e)
            {
                //if(e.KeyCode== Keys.Enter)
                //    this.toolStripButtonSave.f
            }

            private void Frm_CierreStock_Load(object sender, EventArgs e)
            {
                try
                {
                    MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                    menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                    this.OperacionesDelUsuario();

                    this.textBoxAnio.Text = DateTime.Now.Year.ToString();
                    this.textBoxMes.Text = DateTime.Now.Month.ToString();
                    this.textBoxAnio.Focus();
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            private void toolStripButtonSave_Click(object sender, EventArgs e)
            {
                try
                {
                    if (VerificaIngreso())
                    {
                        BLL.Procedures.CIERRESTOCKMENSUAL _cierre = new BLL.Procedures.CIERRESTOCKMENSUAL();
                        BLL.Tables.STKCIERRESTOCK _existe = new BLL.Tables.STKCIERRESTOCK();

                        if(_existe.ItemList(Convert.ToInt32(this.textBoxAnio.Text), Convert.ToInt32(this.textBoxMes.Text)).Count > 0)
                        {
                            DialogResult _result = MessageBox.Show("Este Año y Mes ya están cerrados, desea modificar el cierre anterior?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (_result == System.Windows.Forms.DialogResult.OK)
                            {
                                _existe.RemoveItem(Convert.ToInt32(this.textBoxAnio.Text), Convert.ToInt32(this.textBoxMes.Text));

                            }
                                                  
                        }

                        _cierre.ItemList(Convert.ToInt32(this.textBoxAnio.Text), Convert.ToInt32(this.textBoxMes.Text));
                         MessageBox.Show("El ingreso se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        #endregion

            private void toolStripButtonPrint_Click(object sender, EventArgs e)
            {
                try
                {
                    //if(VerificarDatos() )
                    //{
                    StaCatalina.Forms.Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();

                    CultureInfo culture = new CultureInfo("en-US");

                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "ControlInventario.rpt";
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
                    ParametroField.Name = "@Anio";
                    ParametroValue.Value = this.textBoxAnio.Text;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Mes";
                    ParametroValue.Value = this.textBoxMes.Text;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    _Reporte.Parameters = Parametros;
                    _Reporte.Reporte = objReport;
                    _Reporte.Show();

                    //}
                    //else
                    //{
                    //    MessageBox.Show("El valor de porcentaje debe ser menor o igual a 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    this.textBoxPorcentaje.Focus();
                    //}

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
