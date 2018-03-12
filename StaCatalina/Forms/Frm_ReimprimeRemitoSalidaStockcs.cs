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
namespace StaCatalina.Forms
{
    public partial class Frm_ReimprimeRemitoSalidaStockcs : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private enum Col_Remito
        {
            CODEMP = 0,
            FECHA,
            LETRA,
            SUCURSAL,
            COMPROBANTE,
            CODEMPSTK,
            COMPROBANTESTK

        }

        #endregion

        #region Funciones
        public Frm_ReimprimeRemitoSalidaStockcs()
        {
            InitializeComponent();
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

                ////SETEO EL DEPOSITO SEGUN LA EMPRESA ////
                //if (Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToUpper().ToString().Trim() == "DEPOSITO")
                //{
                //    this.comboBoxDeposito.SelectedValue = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? 1 : 5;

                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void CargarSectoresDeposito(int _dep)
        {
            try
            {
                BLL.Tables.STKSECTOR _sec = new BLL.Tables.STKSECTOR();
                _sec.OrderByParameter.Add(DAL.Tables.STKSECTOR.ColumnEnum.descripcion);
                _sec.ItemList(_dep);

                Entities.Tables.STKSECTOR _itemSeleccion = new Entities.Tables.STKSECTOR();

                //Limpia el combo
                this.comboBoxSector.SuspendLayout();
                this.comboBoxSector.DataSource = null;
                this.comboBoxSector.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione un Sector>";
                _itemSeleccion.SECTOR_ID = 0;
                _sec.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSector.DisplayMember = BLL.Tables.STKSECTOR.ColumnNames.DESCRIPCION;
                this.comboBoxSector.ValueMember = BLL.Tables.STKSECTOR.ColumnNames.SECTOR_ID;
                this.comboBoxSector.DataSource = _sec.Result.ToArray();

                this.comboBoxSector.ResumeLayout();

                //SETEO EL DEPOSITO SEGUN LA EMPRESA ////
                //if (Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToUpper().ToString().Trim() == "DEPOSITO")
                //{
                //    this.comboBoxSector.SelectedValue = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? 1 : 2;

                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void TraeRemitos(DateTime _FechaDesde, DateTime _FechaHasta,int _sector, int _Deposito)
        {
            try
            {
                BLL.Procedures.TRAE_REMITOS_PARA_IMPRESION _detalle = new BLL.Procedures.TRAE_REMITOS_PARA_IMPRESION();

                this.dataGridViewRemitos.Rows.Clear();

                int indice;
                foreach (Entities.Procedures.TRAE_REMITOS_PARA_IMPRESION item in _detalle.ItemList(_FechaDesde, _FechaHasta, _sector, _Deposito))
                {
                    indice = dataGridViewRemitos.Rows.Add();
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.LETRA].Value = item.letra;
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.SUCURSAL].Value = item.sucursal;
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.COMPROBANTE].Value = item.comprobante;
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.FECHA].Value = item.fecha.ToShortDateString();
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.CODEMPSTK].Value = item.codempstk;
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.COMPROBANTESTK].Value = item.comprobantestk;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ReimprimeRemitoSalidaStockcs_Load(object sender, EventArgs e)
        {
            try
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();

                this.dateTimeFechaDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                this.dateTimeFechaHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                CargarDepositos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBoxDeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxDeposito.SelectedIndex > 0)
                CargarSectoresDeposito(Convert.ToInt32(this.comboBoxDeposito.SelectedValue));
        }

        private void comboBoxSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int _sector = Convert.ToInt32(comboBoxSector.SelectedValue);
                int _deposito = Convert.ToInt32(comboBoxDeposito.SelectedValue);
                TraeRemitos(dateTimeFechaDesde.Value, dateTimeFechaHasta.Value, _sector, _deposito);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dateTimeFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int _sector = Convert.ToInt32(comboBoxSector.SelectedValue);
                int _deposito = Convert.ToInt32(comboBoxDeposito.SelectedValue);
                TraeRemitos(dateTimeFechaDesde.Value, dateTimeFechaHasta.Value, _sector, _deposito);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dateTimeFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int _sector = Convert.ToInt32(comboBoxSector.SelectedValue);
                int _deposito = Convert.ToInt32(comboBoxDeposito.SelectedValue);
                TraeRemitos(dateTimeFechaDesde.Value, dateTimeFechaHasta.Value, _sector, _deposito);
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
                int _nroRemito = Convert.ToInt32(dataGridViewRemitos.Rows[dataGridViewRemitos.CurrentRow.Index].Cells[(int)Col_Remito.COMPROBANTE].Value);
                string _letra = dataGridViewRemitos.Rows[dataGridViewRemitos.CurrentRow.Index].Cells[(int)Col_Remito.LETRA].Value.ToString();
                string _sucursal = dataGridViewRemitos.Rows[dataGridViewRemitos.CurrentRow.Index].Cells[(int)Col_Remito.SUCURSAL].Value.ToString();

                StaCatalina.Forms.Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();


                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "RemitoCambioDeposito.rpt";
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
                    ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Letra";
                    ParametroValue.Value = _letra;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Sucursal";
                    ParametroValue.Value = _sucursal;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@comprobante";
                    ParametroValue.Value = _nroRemito;
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
}
