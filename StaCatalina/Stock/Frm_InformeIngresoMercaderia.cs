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
    public partial class Frm_InformeIngresoMercaderia : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private enum Col_Depisito
        {
            DEPOSITO_ID,
            INCLUIR,
            CODEMP,
            DESCRIPCION

        }
        #endregion

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

        public Frm_InformeIngresoMercaderia()
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


                //*** auto complit
                //AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
                //sourcename.AddRange(_prov.Result.ToString());
                //comboBoxProveed.AutoCompleteCustomSource = _prov.Result.ToArray();
                //comboBoxProveed.AutoCompleteMode = AutoCompleteMode.Suggest;
                //comboBoxProveed.AutoCompleteSource = AutoCompleteSource.CustomSource;

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

        private bool Valida()
        {
            try
            {
                if(radioButtonOC.Checked && this.textBoxOC.Text == string.Empty)
                {
                    MessageBox.Show("Debe Ingresar un Nro. de Orden de Compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (radioButtonProveed.Checked && comboBoxProveed.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar un Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if(comboBoxDeposito.SelectedIndex ==0)
                {
                    MessageBox.Show("Debe seleccionar un Depósito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }

            catch(Exception ex)
            {

                return false;
            }

        }

        private void CargarDepositos()
        {
            try
            {
                BLL.Tables.STKDEPOSITO _dep = new BLL.Tables.STKDEPOSITO();
                _dep.WhereParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim());
                _dep.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.OR, DAL.Tables.STKDEPOSITO.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, "AMBA");//TAMBIEN TRAIGO LA EMPRESA AMBA
                _dep.OrderByParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.descripcion);
                _dep.ItemList();
                Entities.Tables.STKDEPOSITO _itemSeleccion = new Entities.Tables.STKDEPOSITO();

                //Limpia el combo
                this.comboBoxDeposito.SuspendLayout();
                this.comboBoxDeposito.DataSource = null;
                this.comboBoxDeposito.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione un Depósito>";
                _itemSeleccion.DEPOSITO_ID = 0;
                _dep.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxDeposito.DisplayMember = BLL.Tables.STKDEPOSITO.ColumnNames.DESCRIPCION;
                this.comboBoxDeposito.ValueMember = BLL.Tables.STKDEPOSITO.ColumnNames.DEPOSITO_ID;
                this.comboBoxDeposito.DataSource = _dep.Result.ToArray();

                this.comboBoxDeposito.ResumeLayout();
                comboBoxDeposito.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        #endregion

        #region Eventos
        private void Frm_InformeIngresoMercaderia_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            this.dateTimeFechaDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.dateTimeFechaHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            this.dateTimeFechaIngDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.dateTimeFechaIngHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            this.Text = "Ingreso de Mercadería Por Orden de Compra empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
            this.comboBoxcodEmp.SelectedIndex = 0;
            if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
            {
                this.comboBoxcodEmp.SelectedIndex = 0;
                CargarProveedor("EGES");
            }

            else
            {
                this.comboBoxcodEmp.SelectedIndex = 1;
                CargarProveedor("RSC");
            }
            this.textBoxOC.Enabled = false;
            this.comboBoxProveed.Enabled = false;

            CargarDepositos();
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {

                if (Valida())
                {
                    StaCatalina.Forms.Reports _Reporte = new StaCatalina.Forms.Reports();
                    ReportDocument objReport = new ReportDocument();

                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IngresoMercaderia_por_OC.rpt";
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
                    ParametroField.Name = "@codEmp";
                    ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim();
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@FechaDesde";
                    if (radioButtonPorFechaOC.Checked)
                    {
                        ParametroValue.Value = this.dateTimeFechaDesde.Value.ToString("yyyy-MM-dd 00:00:00"); //FECHA DE O.C.
                    }
                    else
                    {
                        ParametroValue.Value = this.dateTimeFechaIngDesde.Value.ToString("yyyy-MM-dd 00:00:00"); // FECHA INGRESO
                    }
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@FechaHasta";
                    if (radioButtonPorFechaOC.Checked)
                    {
                        ParametroValue.Value = this.dateTimeFechaHasta.Value.ToString("yyyy-MM-dd 23:59:59");//FECHA DE O.C.
                    }
                    else
                    {
                        ParametroValue.Value = this.dateTimeFechaIngHasta.Value.ToString("yyyy-MM-dd 23:59:59");// FECHA INGRESO
                    }
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@ordenCompra";
                    ParametroValue.Value = (radioButtonOC.Checked) ? textBoxOC.Text.ToString() : null;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Proveed";
                    ParametroValue.Value = (radioButtonProveed.Checked) ? comboBoxProveed.SelectedValue : null;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Tipo";
                    if (radioButtonTodo.Checked)
                    { ParametroValue.Value = "TODO"; }
                    if (radioButtonOC.Checked)
                    { ParametroValue.Value = "ORDC"; }
                    if (radioButtonProveed.Checked)
                    { ParametroValue.Value = "PROV"; }
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Criterio";
                    if(radioButtonTodosProveed.Checked)
                    { ParametroValue.Value = "TODO"; }
                    if (radioButtonParcialCumplida.Checked)
                    { ParametroValue.Value = "PARC"; }
                    if (radioButtonIncumplidas.Checked)
                    { ParametroValue.Value = "INCU"; }
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //TIPO DE FECHA DE INFORME
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@TipoFecha";
                    if (radioButtonPorFechaIngreso.Checked)
                    { ParametroValue.Value = "FIN"; } //POR FECHA DE INGRESO
                    if (radioButtonPorFechaOC.Checked)
                    { ParametroValue.Value = "FOC"; } // POR FECHA DE O.C.
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //DEPOSITO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Deposito";
                    ParametroValue.Value = comboBoxDeposito.SelectedValue.ToString();  // DEPOSITO
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

        private void textBoxOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void comboBoxcodEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxcodEmp.SelectedIndex ==0)
            { CargarProveedor("EGES"); }
            if (comboBoxcodEmp.SelectedIndex == 1)
            { CargarProveedor("RSC"); }
        }

        private void radioButtonTodo_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxOC.Text = string.Empty;
            this.textBoxOC.Enabled = false;
            this.comboBoxProveed.SelectedIndex = 0;
            this.comboBoxProveed.Enabled = false;
        }

        private void radioButtonOC_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxOC.Enabled = true;
            this.textBoxOC.Text = string.Empty;
            this.comboBoxProveed.SelectedIndex = 0;
            this.comboBoxProveed.Enabled = false;
            this.textBoxOC.Focus();
        }

        private void radioButtonProveed_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxOC.Text = string.Empty;
            this.textBoxOC.Enabled = false;
            this.comboBoxProveed.Enabled = true;
            this.comboBoxProveed.SelectedIndex = 0;
        }

        #endregion

        private void radioButtonPorFechaOC_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeFechaDesde.Enabled = true;
            dateTimeFechaHasta.Enabled = true;
            dateTimeFechaIngDesde.Enabled = false;
            dateTimeFechaIngHasta.Enabled = false;
        }

        private void radioButtonPorFechaIngreso_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeFechaDesde.Enabled = false;
            dateTimeFechaHasta.Enabled = false;
            dateTimeFechaIngDesde.Enabled = true;
            dateTimeFechaIngHasta.Enabled = true;
        }
    }
}
