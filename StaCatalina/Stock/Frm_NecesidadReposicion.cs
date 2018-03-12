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
    public partial class Frm_NecesidadReposicion : StaCatalina.Plantilla
    {
        #region Variables
        private enum Col_Depisito
        {
            DEPOSITO_ID,
            INCLUIR,
            CODEMP,
            DESCRIPCION

        }

        #endregion

        #region Funciones
        public Frm_NecesidadReposicion()
            {
                InitializeComponent();

            }
        

            private void CargarDepositos(string _codEmp)
            {
                try
                {
                    BLL.Tables.STKDEPOSITO _dep = new BLL.Tables.STKDEPOSITO();
                    if (_codEmp != "TODOS")
                    {
                        //LOS DEPOSITOS DE ESTA EMPRESA
                        _dep.WhereParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, _codEmp);
                    }

                    _dep.OrderByParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.codEmp);


                    this.dataGridViewDeposito.Rows.Clear();
                    int indice;
                    foreach (Entities.Tables.STKDEPOSITO item in _dep.ItemList())
                    {
                        indice = dataGridViewDeposito.Rows.Add();
                        dataGridViewDeposito.Rows[indice].Cells[(int)Col_Depisito.DEPOSITO_ID].Value = item.DEPOSITO_ID;
                        dataGridViewDeposito.Rows[indice].Cells[(int)Col_Depisito.CODEMP].Value = item.CODEMP;
                        dataGridViewDeposito.Rows[indice].Cells[(int)Col_Depisito.DESCRIPCION].Value = item.DESCRIPCION;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

            private void CargarArticulos()
            {
                try
                {

                    BLL.Procedures._H_ARTICULOS _art = new BLL.Procedures._H_ARTICULOS();
                    List<Entities.Procedures._H_ARTICULOS> _rubroItem = new List<Entities.Procedures._H_ARTICULOS>();
                    Entities.Procedures._H_ARTICULOS _itemSeleccion = new Entities.Procedures._H_ARTICULOS();

                    _rubroItem = _art.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());//le paso la colección de rubros

                    //Limpia el combo
                    this.comboBoxArticulo.SuspendLayout();
                    this.comboBoxArticulo.DataSource = null;
                    this.comboBoxArticulo.Items.Clear();


                    // Carga el item de Seleccion
                    _itemSeleccion.descripcion = "<todos los Artículo>";
                    _itemSeleccion.art_codgen = "0";
                    _rubroItem.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxArticulo.DisplayMember = BLL.Procedures._H_ARTICULOS.ColumnNames.DESCRIPCION;
                    this.comboBoxArticulo.ValueMember = BLL.Procedures._H_ARTICULOS.ColumnNames.ART_CODGEN;
                    this.comboBoxArticulo.DataSource = _rubroItem;
                    this.comboBoxArticulo.SelectedIndex = 0;

                    this.comboBoxArticulo.ResumeLayout();



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
                    Entities.Procedures.RUBROARTICULOS _itemSeleccion = new Entities.Procedures.RUBROARTICULOS();
                    BLL.Procedures.RUBROARTICULOS _rubroItem = new BLL.Procedures.RUBROARTICULOS();
                    _rubroItem.Items();
                    //Limpia el combo
                    this.comboBoxRubro.SuspendLayout();
                    this.comboBoxRubro.DataSource = null;
                    this.comboBoxRubro.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.da1_desc = "<Todos los Rubros>";
                    _itemSeleccion.da1_cod = "0";
                    _rubroItem.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxRubro.DisplayMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_DESC;
                    this.comboBoxRubro.ValueMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_COD;
                    this.comboBoxRubro.DataSource = _rubroItem.Result.ToArray();
                    this.comboBoxRubro.ResumeLayout();
                    this.comboBoxRubro.SelectedIndex = 0;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            private void CargarSubRubros()
            {
                try
                {

                    BLL.Procedures.TRAESUBRUBROSEMPRESA _rubro = new BLL.Procedures.TRAESUBRUBROSEMPRESA();
                    List<Entities.Procedures.TRAESUBRUBROSEMPRESA> _rubroItem = new List<Entities.Procedures.TRAESUBRUBROSEMPRESA>();
                    Entities.Procedures.TRAESUBRUBROSEMPRESA _itemSeleccion = new Entities.Procedures.TRAESUBRUBROSEMPRESA();

                    _rubroItem = _rubro.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());//le paso la colección de rubros

                    //Limpia el combo
                    this.comboBoxSubRubro.SuspendLayout();
                    this.comboBoxSubRubro.DataSource = null;
                    this.comboBoxSubRubro.Items.Clear();


                    // Carga el item de Seleccion
                    _itemSeleccion.da2_desc = "<Todos los Sub Rubro>";
                    _itemSeleccion.da2_cod = "0";
                    _rubroItem.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxSubRubro.DisplayMember = BLL.Procedures.TRAESUBRUBROSEMPRESA.ColumnNames.DA2_DESC;
                    this.comboBoxSubRubro.ValueMember = BLL.Procedures.TRAESUBRUBROSEMPRESA.ColumnNames.DA2_COD;
                    this.comboBoxSubRubro.DataSource = _rubroItem;
                    this.comboBoxSubRubro.SelectedIndex = 0;

                    this.comboBoxSubRubro.ResumeLayout();



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
                if (radioButtonRubro.Checked && this.comboBoxRubro.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un Rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (radioButtonSubRubro.Checked && this.comboBoxSubRubro.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un SubRubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (radioButtonArticulo.Checked && comboBoxArticulo.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un Artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                int mesDesde = 0;
                int mesHasta = 0;
                mesDesde = Convert.ToInt16(dateTimeFDesde.Value.Month);
                mesHasta = Convert.ToInt16(dateTimeFHasta.Value.Month);
                if (mesDesde != mesHasta)
                {
                    MessageBox.Show("La fecha debe ser mes completo, verifique el mes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }

            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion



        private void comboBoxcodEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxcodEmp.SelectedIndex == 0)
            {
                CargarDepositos("TODOS");
            }

            if (comboBoxcodEmp.SelectedIndex == 1)
            {
                CargarDepositos("EGES");
            }

            if (comboBoxcodEmp.SelectedIndex == 2)
            {
                CargarDepositos("RSC");
            }
        }

        private void Frm_NecesidadReposicion_Load(object sender, EventArgs e)
        {
            try
            {
                CargarRubros();
                CargarSubRubros();
                CargarArticulos();
                this.comboBoxcodEmp.SelectedIndex = 0;
                CargarDepositos("TODOS");
                dateTimeFDesde.Value = Convert.ToDateTime("01/" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Year); //Convert.ToDateTime(DateTime.Now.ToShortDateString());
                dateTimeFHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valida())
                {
                    StaCatalina.Forms.Reports _Reporte = new StaCatalina.Forms.Reports();
                    ReportDocument objReport = new ReportDocument();

                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "Necesidad_Reposicion.rpt";
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

                    //4to PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Filtro";
                    if (radioButtonRubro.Checked)
                    { ParametroValue.Value = "RUBR"; }
                    if (radioButtonSubRubro.Checked)
                    { ParametroValue.Value = "SRUB"; }
                    if (radioButtonArticulo.Checked)
                    { ParametroValue.Value = "ARTI"; }
                    if (radioButtonTodos.Checked)
                    { ParametroValue.Value = "TODO"; }
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);


                    //5to PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Rubro";
                    ParametroValue.Value = this.comboBoxRubro.SelectedValue;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //5to PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@SubRubro";
                    ParametroValue.Value = comboBoxSubRubro.SelectedValue;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);


                    //5to PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Articulo";
                    ParametroValue.Value = comboBoxArticulo.SelectedValue;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@FechaDesde";
                    ParametroValue.Value = dateTimeFDesde.Value.ToString("yyyy-MM-dd 00:00:00");
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@FechaHasta";
                    ParametroValue.Value = dateTimeFHasta.Value.ToString("yyyy-MM-dd 23:59:59");
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@ConNecesidad";
                    ParametroValue.Value = (radioButtonTodos.Checked) ? 0 : 1;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@PorcentajeProrrateo";
                    ParametroValue.Value = this.textBoxProrrateo.Text;
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
            Close();
        }

        private void dataGridViewDeposito_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewDeposito.IsCurrentCellDirty)
                dataGridViewDeposito.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void radioButtonRubro_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxArticulo.SelectedIndex = 0;
            comboBoxRubro.SelectedIndex = 0;
            comboBoxSubRubro.SelectedIndex = 0;
            comboBoxRubro.Enabled = true;
            comboBoxArticulo.Enabled = false;
            comboBoxSubRubro.Enabled = false;
        }

        private void radioButtonArticulo_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxArticulo.SelectedIndex = 0;
            comboBoxRubro.SelectedIndex = 0;
            comboBoxSubRubro.SelectedIndex = 0;
            comboBoxRubro.Enabled = false;
            comboBoxArticulo.Enabled = true;
            comboBoxSubRubro.Enabled = false;

        }

        private void radioButtonSubRubro_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxArticulo.SelectedIndex = 0;
            comboBoxRubro.SelectedIndex = 0;
            comboBoxSubRubro.SelectedIndex = 0;

            comboBoxRubro.Enabled = false;
            comboBoxArticulo.Enabled = false;
            comboBoxSubRubro.Enabled = true;
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxArticulo.SelectedIndex = 0;
            comboBoxRubro.SelectedIndex = 0;
            comboBoxSubRubro.SelectedIndex = 0;

            comboBoxRubro.Enabled = false;
            comboBoxArticulo.Enabled = false;
            comboBoxSubRubro.Enabled = false;
        }
    }
}
