using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
namespace StaCatalina.Forms
{
    public partial class Frm_HistoricoPrecios : StaCatalina.Plantilla
    {
        #region Variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            protected List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        #endregion

        #region Funciones
            public Frm_HistoricoPrecios()
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

            private void CargarRubros()
            {
                try
                {
                    BLL.Procedures.RUBROARTICULOS _rubro = new BLL.Procedures.RUBROARTICULOS();
                    _rubro.ItemList();//le paso la colección de rubros
                    Entities.Procedures.RUBROARTICULOS _itemSeleccion = new Entities.Procedures.RUBROARTICULOS();

                    //Limpia el combo
                    this.comboBoxrubro.SuspendLayout();
                    this.comboBoxrubro.DataSource = null;
                    this.comboBoxrubro.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.da1_desc = "<Seleccione un Rubro>";
                    _itemSeleccion.da1_cod = "0";
                    _rubro.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxrubro.DisplayMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_DESC;
                    this.comboBoxrubro.ValueMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_COD;
                    this.comboBoxrubro.DataSource = _rubro.Result.ToArray();
                    this.comboBoxrubro.SelectedIndex = 0;

                    this.comboBoxrubro.ResumeLayout();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        private void HistoricoPrecios()
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "HistoricoDePrecios.rpt";
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
                ParametroField.Name = "@codProducto";
                ParametroValue.Value = this.comboBoxProductoxRubro.SelectedValue;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2° PARAMETRO
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
            private void Frm_HistoricoPrecios_Load(object sender, EventArgs e)
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();

                // cargo en una coleccion los productos por unica vez
                BLL.Procedures.H_ARTICULOSDEPOSITO _art = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                _articulosItem = _art.ItemList();//le paso la colección de artículos

                //cargo los rubros
                CargarRubros();
            }


        #endregion

            private void comboBoxrubro_SelectedIndexChanged(object sender, EventArgs e)
            {
                //MUESTRA LOS ARTICULOS DE ESE RUBRO
                try
                {
                    var q = (dynamic)null;

                    q = (from item in _articulosItem
                         where item.rubro.Contains(this.comboBoxrubro.SelectedValue.ToString())
                         select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();
                    //cargo el combo con los articulos filtrados por este rubro
                    Entities.Procedures.H_ARTICULOSDEPOSITO _itemSeleccion = new Entities.Procedures.H_ARTICULOSDEPOSITO();

                    //Limpia el combo
                    this.comboBoxProductoxRubro.SuspendLayout();
                    this.comboBoxProductoxRubro.DataSource = null;
                    this.comboBoxProductoxRubro.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.art_descgen = "<Seleccione un Artículo>";
                    _itemSeleccion.art_codgen = "0";
                    q.Insert(0, _itemSeleccion);
                    
                    //Carga el combo
                    this.comboBoxProductoxRubro.DisplayMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_DESCGEN;
                    this.comboBoxProductoxRubro.ValueMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_CODGEN;
                    this.comboBoxProductoxRubro.DataSource = q;
                    this.comboBoxProductoxRubro.SelectedIndex = 0;

                    this.comboBoxProductoxRubro.ResumeLayout();

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            private void toolStripButtonSave_Click(object sender, EventArgs e)
            {
                if (this.comboBoxrubro.SelectedIndex > 0 && this.comboBoxProductoxRubro.SelectedIndex > 0)
                {
                    HistoricoPrecios();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Rubro y un Artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
