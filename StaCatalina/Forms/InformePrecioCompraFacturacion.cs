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
    public partial class InformePrecioCompraFacturacion : Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private Int32 _updateProducto;
       
        List<Entities.Procedures.H_ARTICULOSDEPOSITO> _ItemsArtDep = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        #endregion

        #region Funciones

        public InformePrecioCompraFacturacion()
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

        private void CargarProductos()
        {
            try
            {
                BLL.Procedures.H_ARTICULOSDEPOSITO _prod = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                Entities.Procedures.H_ARTICULOSDEPOSITO _itemSeleccion = new Entities.Procedures.H_ARTICULOSDEPOSITO();

                _ItemsArtDep = _prod.ItemList();

                var q = (dynamic)null;

                q = (from item in _ItemsArtDep
                     where item.subrubro.Contains("DE") || item.subrubro.Contains("DM")
                     || item.subrubro.Contains("DMP") || item.subrubro.Contains("DRH")
                     || item.subrubro.Contains("MEDI") 
                     select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();


                //Limpia el combo
                this.comboBoxProductos.SuspendLayout();
                this.comboBoxProductos.DataSource = null;
                this.comboBoxProductos.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione un Artículo>";
                _itemSeleccion.art_codgen = "0";

                //_ItemsArtDep = _prod.ItemList();
                q.Insert(0, _itemSeleccion);
                //Carga el combo
                this.comboBoxProductos.DisplayMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_DESCGEN;
                this.comboBoxProductos.ValueMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_CODGEN;
                this.comboBoxProductos.DataSource = q;

                this.comboBoxProductos.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarObrasSociales()
        {
        
          try
                {
                    BLL.Procedures.TRAEOBRASSOCIALESDATATECH _OS = new BLL.Procedures.TRAEOBRASSOCIALESDATATECH();
                    
                    _OS.ItemList();
                    Entities.Procedures.TRAEOBRASSOCIALESDATATECH _itemSeleccion = new Entities.Procedures.TRAEOBRASSOCIALESDATATECH();

                    //Limpia el combo
                    this.comboBoxObraSocial.SuspendLayout();
                    this.comboBoxObraSocial.DataSource = null;
                    this.comboBoxObraSocial.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.des = "<Todos las Obras Sociales>";
                    _itemSeleccion.ins = "0";
                    _OS.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxObraSocial.DisplayMember = BLL.Procedures.TRAEOBRASSOCIALESDATATECH.ColumnNames.DES;
                    this.comboBoxObraSocial.ValueMember = BLL.Procedures.TRAEOBRASSOCIALESDATATECH.ColumnNames.INS;
                    this.comboBoxObraSocial.DataSource = _OS.Result.ToArray();

                    this.comboBoxObraSocial.ResumeLayout();
                    this.comboBoxObraSocial.SelectedIndex = 0;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

        private void InformeListaPreciosXOS()
        {
            try
            {

                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "PrecioUltimaCompraFacturaObrasSociales.rpt";
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
        private void InformePrecioCompraFacturacion_Load(object sender, EventArgs e)
        {

            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            this.textBoxAnio.Text = DateTime.Now.Year.ToString();
            this.textBoxMes.Text = DateTime.Now.Month.ToString();

           
            this.comboBoxEmpresa.SelectedIndex = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString() == "EGES") ? 0 : 1;
            this.comboBoxObraSocial.Hide();
            this.comboBoxProductos.Hide();
            this.comboBoxTipoInf.SelectedIndex = 0;

        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "PrecioUltimaCompraFactura.rpt";
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


                //3° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@codEmp";
                ParametroValue.Value = (this.comboBoxEmpresa.SelectedIndex == 0) ? "EGES":"RSC";
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //4° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@TipoINF";
                if (this.comboBoxTipoInf.SelectedIndex == 0)
                {
                    ParametroValue.Value = "LPR";
                }
                if (this.comboBoxTipoInf.SelectedIndex == 2)
                {
                    ParametroValue.Value = "OSO";
                }
                if (this.comboBoxTipoInf.SelectedIndex == 1)
                {
                    ParametroValue.Value = "ART";
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);


                //5° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Articulo";
                if (this.comboBoxTipoInf.SelectedIndex == 0)
                {
                    ParametroValue.Value = "NULL";
                }
                if (this.comboBoxTipoInf.SelectedIndex == 1)
                {
                    ParametroValue.Value = this.comboBoxProductos.SelectedValue;
                }
                if (this.comboBoxTipoInf.SelectedIndex == 2)
                {
                    ParametroValue.Value = "NULL";
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //6° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@ObraSocial";
                if (this.comboBoxTipoInf.SelectedIndex == 0)
                {
                    ParametroValue.Value = "NULL";
                }
                if (this.comboBoxTipoInf.SelectedIndex == 1)
                {
                    ParametroValue.Value = "NULL";
                }
                if (this.comboBoxTipoInf.SelectedIndex == 2)
                {
                    ParametroValue.Value = this.comboBoxObraSocial.SelectedValue;
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                _Reporte.Parameters = Parametros;
                _Reporte.Reporte = objReport;
                _Reporte.Show();

                if (checkBoxListaPreciosOS.Checked)
                {
                    InformeListaPreciosXOS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }






        #endregion

        private void textBoxAnio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxMes.Focus();
        }

        private void textBoxAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTipoInf_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.comboBoxTipoInf.SelectedIndex == 0)
            {
                this.comboBoxProductos.Hide();
                this.comboBoxObraSocial.Hide();
            }

            if (this.comboBoxTipoInf.SelectedIndex == 1)
            {
                CargarProductos();
                this.comboBoxProductos.Show();
                this.comboBoxObraSocial.Hide();
            }

            if (this.comboBoxTipoInf.SelectedIndex == 2)
            {
                CargarObrasSociales();
                this.comboBoxObraSocial.Show();
                this.comboBoxProductos.Hide();
            }

        }
    }
}
