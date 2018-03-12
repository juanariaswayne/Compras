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
    public partial class Frm_FacturasCargadasProveedor : StaCatalina.Plantilla
    {

        #region Variables
        private enum Col_GridDetalle
        {
            DETALLE = 0,
            CCOEMP_CODIGO,
            CCOSUC_COD,
            CCO_ID,
            CCO_NROCUOTA,
            SUCURSAL,
            LETRA,
            TIPO,
            NUMERO,
            IMPORTE,
            SALDO,
            FEMISION,
            FVTO,
            CCO_CODPRO


        }

        #endregion


        #region Funciones

        public Frm_FacturasCargadasProveedor()
        {
            InitializeComponent();
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
                this.comboBoxProveed.SelectedIndex = 0;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private  void cargarFactruas()
        {
            try
            {

                this.bindingSourceFacturas.DataSource = null;
               
                BLL.Procedures.FACTURASCARGADASPROVEEDOR _fact = new BLL.Procedures.FACTURASCARGADASPROVEEDOR();
                string _codEmp = (this.comboBoxEmpresa.SelectedIndex == 0) ? "EGES" : "RSC";
                DateTime _fechaDesde = Convert.ToDateTime(this.dateTimePickerDesde.Value.ToString("yyyy-MM-dd 00:00:00"));
                DateTime _fechaHasta = Convert.ToDateTime(this.dateTimePickerHasta.Value.ToString("yyyy-MM-dd 23:59:59"));
                dataGridViewFacturas.AutoGenerateColumns = false;

                List<Entities.Procedures.FACTURASCARGADASPROVEEDOR> _facturas = new List<Entities.Procedures.FACTURASCARGADASPROVEEDOR>();
                _facturas = _fact.ItemList(_codEmp, this.comboBoxProveed.SelectedValue.ToString(), _fechaDesde, _fechaHasta);

                this.bindingSourceFacturas.DataSource = _facturas;

                int _anioAnt = 0;
                int _mesAnt = 0;
                labelMes1.Text = string.Empty;
                labelImporte1.Text = string.Empty;
                labelMes2.Text = string.Empty;
                labelImporte2.Text = string.Empty;
                labelMes3.Text = string.Empty;
                labelImporte3.Text = string.Empty;

                CultureInfo culture = new CultureInfo("en-US");
                if (_fact.Resultset.Count > 0)
                {
                    _anioAnt = _fact.Resultset[0].cco_fcontab.Year;
                    _mesAnt = _fact.Resultset[0].cco_fcontab.Month;
                    double _subTotal = 0;
                    int i = 1;
                    //double _total = 0;
                    //VOY RECORRIENDO LOS DATOS Y SUMANDO EL IMPORTE, CORTE DE CONTROL POR AÑO Y MES
                    foreach (Entities.Procedures.FACTURASCARGADASPROVEEDOR item in _facturas)
                    {
                        if (item.cco_fcontab.Year == _anioAnt && item.cco_fcontab.Month == _mesAnt)
                        {
                            _subTotal += item.cco_impmonloc;

                        }
                        else //CAMBIO EL MES Y AÑO
                        {
                            if (i == 1)
                            {
                                labelMes1.Text = "Total Mes: " + _mesAnt;
                                labelImporte1.Text = _subTotal.ToString("C", culture);

                            }
                            if (i == 2)
                            {
                                labelMes2.Text = "Total Mes: " + _mesAnt;
                                labelImporte2.Text = _subTotal.ToString("C", culture);

                            }

                            if (i == 3)
                            {
                                labelMes3.Text = "Total Mes: " + _mesAnt;
                                labelImporte3.Text = _subTotal.ToString("C", culture);
                            }

                            _subTotal = 0;
                            _subTotal += item.cco_impmonloc;

                            _anioAnt = item.cco_fcontab.Year;
                            _mesAnt = item.cco_fcontab.Month;
                            i = i + 1;

                        }


                    }
                    if (i == 1)
                    {
                        labelMes1.Text = "Total Mes: " + _mesAnt;
                        labelImporte1.Text = _subTotal.ToString("C", culture);
                    }
                    if (i == 2)
                    {
                        labelMes2.Text = "Total Mes: " + _mesAnt;
                        labelImporte2.Text = _subTotal.ToString("C", culture);
                    }

                    if (i == 3)
                    {
                        labelMes3.Text = "Total Mes: " + _mesAnt;
                        labelImporte3.Text = _subTotal.ToString("C", culture);
                    }


                }


           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

}
        #endregion

        #region Eventos
        private void Frm_FacturasCargadasProveedor_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                    
            //FIN PERMISOS
            this.dateTimePickerDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.dateTimePickerHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            this.comboBoxEmpresa.SelectedIndex = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? 0 : 1;
            string _codEmp = (this.comboBoxEmpresa.SelectedIndex ==0) ? "EGES" : "RSC";
            CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
        }



        #endregion

        private void comboBoxProveed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxProveed.SelectedIndex > 0)
                {

                    cargarFactruas();
                }


            }

             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dataGridViewFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (int)Col_GridDetalle.DETALLE && e.RowIndex >= 0 && dataGridViewFacturas.Rows[e.RowIndex].Cells[(int)Col_GridDetalle.SUCURSAL].Value != null )
            {
                //MUESTRO EL DETALLE DE LA FACTURA EN UN CRYSTAL
                try
                {
                    StaCatalina.Forms.Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();

                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "FacturaProveedorBejerman.rpt";
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
                    ParametroField.Name = "@ccoemp_Codigo";
                    ParametroValue.Value = dataGridViewFacturas.Rows[dataGridViewFacturas.CurrentRow.Index].Cells[(int)Col_GridDetalle.CCOEMP_CODIGO].Value.ToString();
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@ccosuc_Cod";
                    ParametroValue.Value = dataGridViewFacturas.Rows[dataGridViewFacturas.CurrentRow.Index].Cells[(int)Col_GridDetalle.CCOSUC_COD].Value.ToString();
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);


                    //3° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@cco_ID";
                    ParametroValue.Value = dataGridViewFacturas.Rows[dataGridViewFacturas.CurrentRow.Index].Cells[(int)Col_GridDetalle.CCO_ID].Value.ToString();
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //4° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@cco_NroCuota";
                    ParametroValue.Value = dataGridViewFacturas.Rows[dataGridViewFacturas.CurrentRow.Index].Cells[(int)Col_GridDetalle.CCO_NROCUOTA].Value.ToString();
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //5° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@ImporteTotal";
                    ParametroValue.Value = dataGridViewFacturas.Rows[dataGridViewFacturas.CurrentRow.Index].Cells[(int)Col_GridDetalle.IMPORTE].Value.ToString();
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //6° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Tipo";
                    ParametroValue.Value = dataGridViewFacturas.Rows[dataGridViewFacturas.CurrentRow.Index].Cells[(int)Col_GridDetalle.TIPO].Value.ToString();
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //7° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Letra";
                    ParametroValue.Value = dataGridViewFacturas.Rows[dataGridViewFacturas.CurrentRow.Index].Cells[(int)Col_GridDetalle.LETRA].Value.ToString();
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //8° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Numero";
                    ParametroValue.Value = dataGridViewFacturas.Rows[dataGridViewFacturas.CurrentRow.Index].Cells[(int)Col_GridDetalle.NUMERO].Value.ToString();
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //9° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@fechaFactura";
                    ParametroValue.Value = dataGridViewFacturas.Rows[dataGridViewFacturas.CurrentRow.Index].Cells[(int)Col_GridDetalle.FEMISION].Value.ToString();
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
        }

        private void dateTimePickerHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && comboBoxProveed.SelectedIndex > 0 )
            {

                cargarFactruas();

            }
        }

        private void dateTimePickerDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBoxProveed.SelectedIndex > 0)
            {
                dateTimePickerHasta.Focus();
                cargarFactruas();

            }

            if (e.KeyCode == Keys.Enter && comboBoxProveed.SelectedIndex == 0)
            {
                dateTimePickerHasta.Focus();
            
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            cargarFactruas();
        }
    }
}
