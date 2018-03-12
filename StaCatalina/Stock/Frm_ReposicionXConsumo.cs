using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
namespace StaCatalina.Stock
{
    public partial class Frm_ReposicionXConsumo : StaCatalina.Plantilla
    {
        #region  Variables
        private enum Col_Consumo
        {
            ARTICULO,
            DESCRIPCION,
            UNIMED,
            CONSUMO,
            PENDIENTE_REQ,
            PENDIENTE_OC,
            REPONER,
            GENERAR,
            MARCA
        }
        private enum Col_Deposito
        {
            DEPOSITO_ID,
            INCLUIR,
            CODEMP,
            DESCRIPCION
            
        }
        CultureInfo culture = new CultureInfo("en-US");
        List<Entities.Procedures.TRAEMARCAARTICULOS> _itemsMarca = new List<Entities.Procedures.TRAEMARCAARTICULOS>();
        #endregion

        #region Funciones
        public Frm_ReposicionXConsumo()
        {
            InitializeComponent();
        }
        private void CargarRubros()
        {
            try
            {
                //también cargo los RUBROS por única vez
                BLL.Procedures.RUBROARTICULOS _rubro = new BLL.Procedures.RUBROARTICULOS();
                List<Entities.Procedures.RUBROARTICULOS> _rubroItem = new List<Entities.Procedures.RUBROARTICULOS>();
                Entities.Procedures.RUBROARTICULOS _itemSeleccion = new Entities.Procedures.RUBROARTICULOS();

                _rubroItem = _rubro.ItemList();//le paso la colección de rubros

                //Limpia el combo
                this.comboBoxRubro.SuspendLayout();
                this.comboBoxRubro.DataSource = null;
                this.comboBoxRubro.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.da1_desc = "<Seleccione un Rubro>";
                _itemSeleccion.da1_cod = "0";
                _rubroItem.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxRubro.DisplayMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_DESC;
                this.comboBoxRubro.ValueMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_COD;
                this.comboBoxRubro.DataSource = _rubroItem;
                this.comboBoxRubro.SelectedIndex = 0;

                this.comboBoxRubro.ResumeLayout();



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
                //también cargo los SUB RUBROS por única vez, SOLO TRAIGO LOS QUE EL USUARIO PUEDE VER
                BLL.Procedures.TRAESUBRUBROSDELUSUARIO _rubro = new BLL.Procedures.TRAESUBRUBROSDELUSUARIO();
                List<Entities.Procedures.TRAESUBRUBROSDELUSUARIO> _rubroItem = new List<Entities.Procedures.TRAESUBRUBROSDELUSUARIO>();
                Entities.Procedures.TRAESUBRUBROSDELUSUARIO _itemSeleccion = new Entities.Procedures.TRAESUBRUBROSDELUSUARIO();

                _rubroItem = _rubro.ItemList(Clases.Usuario.UsuarioLogeado.id_usuario_Logeado);//le paso la colección de rubros

                //Limpia el combo
                this.comboBoxSubRubro.SuspendLayout();
                this.comboBoxSubRubro.DataSource = null;
                this.comboBoxSubRubro.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.da2_desc = "<Seleccione un Sub Rubro>";
                _itemSeleccion.artda2_cod = "0";
                _rubroItem.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSubRubro.DisplayMember = BLL.Procedures.TRAESUBRUBROSDELUSUARIO.ColumnNames.DA2_DESC;
                this.comboBoxSubRubro.ValueMember = BLL.Procedures.TRAESUBRUBROSDELUSUARIO.ColumnNames.ARTDA2_COD;
                this.comboBoxSubRubro.DataSource = _rubroItem;
                this.comboBoxSubRubro.SelectedIndex = 0;

                this.comboBoxSubRubro.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private string Depositos()
        {
            try
            {
                string _depositos = string.Empty;
                bool _selecciono = false;

                for (int i = 0; i < this.dataGridViewDeposito.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewDeposito.Rows[i].Cells[(int)Col_Deposito.INCLUIR] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _selecciono = true;
                        _depositos = (_depositos.Length == 0) ? dataGridViewDeposito.Rows[i].Cells[(int)Col_Deposito.DEPOSITO_ID].Value.ToString() : _depositos.ToString() + "," + dataGridViewDeposito.Rows[i].Cells[(int)Col_Deposito.DEPOSITO_ID].Value.ToString();

                    }
                }

                if (_selecciono)
                {

                    return _depositos.ToString();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un depósito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            }

            catch (Exception ex)
            {

                return null;
            }
        }

        private void CargarDepositos(string _codEmp)
        {
            try
            {
                BLL.Tables.STKDEPOSITO _dep = new BLL.Tables.STKDEPOSITO();
                _dep.WhereParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, _codEmp);
               _dep.OrderByParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.codEmp);

                this.dataGridViewDeposito.Rows.Clear();
                int indice;
                foreach (Entities.Tables.STKDEPOSITO item in _dep.ItemList())
                {
                    indice = dataGridViewDeposito.Rows.Add();
                    dataGridViewDeposito.Rows[indice].Cells[(int)Col_Deposito.DEPOSITO_ID].Value = item.DEPOSITO_ID;
                    dataGridViewDeposito.Rows[indice].Cells[(int)Col_Deposito.CODEMP].Value = item.CODEMP;
                    dataGridViewDeposito.Rows[indice].Cells[(int)Col_Deposito.DESCRIPCION].Value = item.DESCRIPCION;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void CargarLugaresEntrega(string _CodEmp)
        {
            try
            {
                //también cargo los RUBROS por única vez
                BLL.Procedures.TRAELUGARESENTREGA _rubro = new BLL.Procedures.TRAELUGARESENTREGA();
                List<Entities.Procedures.TRAELUGARESENTREGA> _rubroItem = new List<Entities.Procedures.TRAELUGARESENTREGA>();
                Entities.Procedures.TRAELUGARESENTREGA _itemSeleccion = new Entities.Procedures.TRAELUGARESENTREGA();

                _rubroItem = _rubro.ItemList(_CodEmp);//le paso la colección de Lugares

                //Limpia el combo
                this.comboBoxLugarEntrega.SuspendLayout();
                this.comboBoxLugarEntrega.DataSource = null;
                this.comboBoxLugarEntrega.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione un lugar>";
                _itemSeleccion.lugar_id = 0;
                _rubroItem.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxLugarEntrega.DisplayMember = BLL.Tables.COMLUGARENTREGA.ColumnNames.DESCRIPCION;
                this.comboBoxLugarEntrega.ValueMember = BLL.Tables.COMLUGARENTREGA.ColumnNames.LUGAR_ID;
                this.comboBoxLugarEntrega.DataSource = _rubroItem;
                this.comboBoxLugarEntrega.SelectedIndex = 0;

                this.comboBoxLugarEntrega.ResumeLayout();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void TraerMarcasArticulos()
        {
            try
            {
                BLL.Procedures.TRAEMARCAARTICULOS _marca = new BLL.Procedures.TRAEMARCAARTICULOS();
                _itemsMarca = _marca.ItemList("EGES"); //LAS MARCAS SE CARGAN CON LA EMPRESA EGESAC.. LOS ARTICULOS SON LOS MISMOS

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarMarca(string _articulo, DataGridViewComboBoxCell comboboxColumnSector)
        {
            try
            {


                Entities.Procedures.TRAEMARCAARTICULOS _itemSeleccion = new Entities.Procedures.TRAEMARCAARTICULOS();
                List<Entities.Procedures.TRAEMARCAARTICULOS> _miMarca = new List<Entities.Procedures.TRAEMARCAARTICULOS>();

                var q = (dynamic)null;

                _miMarca = (from m in _itemsMarca
                            where m.articulo_id.ToString().Trim() == _articulo.ToString().Trim()
                            select m).ToList<Entities.Procedures.TRAEMARCAARTICULOS>();


                comboboxColumnSector.DataSource = null;
                comboboxColumnSector.Items.Clear();

                //Carga el item de Seleccion
                _itemSeleccion.marca = "<Sin Definir>";// (_miMarca.Count > 0) ? "<Seleccione una Marca>" : "<Sin Definir>";
                _itemSeleccion.articulo_id = "0";
                _miMarca.Insert(0, _itemSeleccion);

                //Carga el combo
                comboboxColumnSector.DataSource = _miMarca.ToArray();
                comboboxColumnSector.DisplayMember = BLL.Procedures.TRAEMARCAARTICULOS.ColumnNames.MARCA;
                comboboxColumnSector.ValueMember = BLL.Procedures.TRAEMARCAARTICULOS.ColumnNames.ARTICULO_ID;
                comboboxColumnSector.Value = "<Sin Definir>";//(_miMarca.Count > 0) ? "<Seleccione una Marca>" : "<Sin Definir>"; ;

                //FIN CARGO COMBO TIPO RECLAMO

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
               
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }

        }

        private void RequerimientosPendientesOC (String codEmp, string _articulo)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new StaCatalina.Forms.Reports();
                ReportDocument objReport = new ReportDocument();

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "RequerimientosSinOCxArticulo.rpt";
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
                ParametroValue.Value = codEmp;  
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2do PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@articulo";
                ParametroValue.Value = _articulo;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                _Reporte.Parameters = Parametros;
                _Reporte.Reporte = objReport;
                _Reporte.Show();

            }

            catch (Exception ex)
            {


            }

        }

        private void OCPendienteEntrega(String codEmp, string _articulo)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new StaCatalina.Forms.Reports();
                ReportDocument objReport = new ReportDocument();

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "OrdenesDeCompraPendientesDeEntregaxArticulo.rpt";
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
                ParametroValue.Value = codEmp;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2do PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@articulo";
                ParametroValue.Value = _articulo;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                _Reporte.Parameters = Parametros;
                _Reporte.Reporte = objReport;
                _Reporte.Show();

            }

            catch (Exception ex)
            {


            }

        }

        #endregion

        #region Eventos
        private void Frm_ReposicionXConsumo_Load(object sender, EventArgs e)
        {
            this.Text = "Generación de Requerimientos por Reposición de consumos, empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
            dateTimeFDesde.Value =Convert.ToDateTime(DateTime.Now.ToShortDateString());
            dateTimeFHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            CargarRubros();
            CargarSubRubros();
            CargarDepositos(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
            CargarLugaresEntrega(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);
            TraerMarcasArticulos();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxLugarEntrega.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar un lugar de Entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                bool _selecciono = false;
                int nroReqGenerado = 0;

                // ***cabecera
                Entities.Tables.COMREQUERIMIENTO _ReqCabecera = new Entities.Tables.COMREQUERIMIENTO();
                BLL.Tables.COMREQUERIMIENTO _ReqCab = new BLL.Tables.COMREQUERIMIENTO();
                Entities.Tables.COMREQUERIMIENTOITEM _ReqItem = new Entities.Tables.COMREQUERIMIENTOITEM();
                // BLL.Tables.COMREQUERIMIENTOITEM _ReqIte = new BLL.Tables.COMREQUERIMIENTOITEM();
                List<Entities.Tables.COMREQUERIMIENTOITEM> _ItemsReq = new List<Entities.Tables.COMREQUERIMIENTOITEM>();

                string _empresa = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();

                _ReqCabecera.FECHA = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                _ReqCabecera.ESTADO_ID = 1; //Ojo ver que valor se envia despues 
                _ReqCabecera.OBS = this.textBoxObs.Text.Trim();
                _ReqCabecera.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                _ReqCabecera.SECTORREQUERIMIENTO_ID = Clases.Usuario.UsuarioLogeado.Id_Sector; // Ojo ver como se envia Despues
                _ReqCabecera.SECTORENTREGA_ID = Convert.ToInt32(comboBoxLugarEntrega.SelectedValue);

                // ** fin cabecera
                for (int i = 0; i < dataGridViewConsumos.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewConsumos.Rows[i].Cells[(int)Col_Consumo.GENERAR] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _selecciono = true;
                        _ReqItem = new Entities.Tables.COMREQUERIMIENTOITEM();
                        _ReqItem.ARTICULO_ID = dataGridViewConsumos.Rows[i].Cells[(int)Col_Consumo.ARTICULO].Value.ToString();
                        _ReqItem.UNIMED = dataGridViewConsumos.Rows[i].Cells[(int)Col_Consumo.UNIMED].Value.ToString();
                        _ReqItem.CANTIDAD = Convert.ToDecimal(dataGridViewConsumos.Rows[i].Cells[(int)Col_Consumo.REPONER].Value.ToString(), culture);
                        _ReqItem.FECHAENTREGA = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        _ReqItem.MARCA = dataGridViewConsumos.Rows[i].Cells[(int)Col_Consumo.MARCA].EditedFormattedValue.ToString();
                        _ReqItem.NIVELAUT_ID = 1; //ojo ver como se envia despues
                                                  //SI LA CANTIDAD ES CERO.. NO LO GRABO.
                        if (_ReqItem.CANTIDAD > 0)
                            _ItemsReq.Add(_ReqItem); //Meto en la coleccion todos los elementos de la grilla

                    }
                }
                if (_selecciono)
                {
                    //LO DE ABAJO NO LO USO, PERO LO NECESITA LA FUNCION QUE CREA EL REQ
                    List<Entities.Tables.COMARTICULOSPROVISORIOS> _ItemsProvisorios = new List<Entities.Tables.COMARTICULOSPROVISORIOS>();
                    if (_ReqCab.AddItem(_ReqCabecera, _ItemsReq, _empresa, _ItemsProvisorios,ref nroReqGenerado))
                    {
                        MessageBox.Show("Se generó el Requerimiento Nro: " + nroReqGenerado, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewConsumos.Rows.Clear();
                        this.textBoxObs.Text = "";
                        comboBoxLugarEntrega.SelectedIndex = 0;
                        comboBoxRubro.SelectedIndex = 0;
                        comboBoxSubRubro.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Error al grabar Requerimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void radioButtonRubro_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRubro.Checked)
            {
                comboBoxSubRubro.SelectedIndex = 0;
                comboBoxSubRubro.Enabled = false;

                comboBoxRubro.SelectedIndex = 0;
                comboBoxRubro.Enabled = true;
            }
        }

        private void radioButtonSubRubro_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSubRubro.Checked)
            {
                comboBoxRubro.SelectedIndex = 0;
                comboBoxRubro.Enabled = false;

                comboBoxSubRubro.SelectedIndex = 0;
                comboBoxSubRubro.Enabled = true;
            }

        }

        private void dataGridViewDeposito_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewDeposito.IsCurrentCellDirty)
                dataGridViewDeposito.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewConsumos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewConsumos.IsCurrentCellDirty)
                dataGridViewConsumos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void toolStripButtonMostrar_Click(object sender, EventArgs e)
        {
            //string _depositos = Depositos();
            if (Valida())
            {
                //if (_depositos.Length > 0 || _depositos != null)
                //{
                    BLL.Procedures.REPOSICIONPORCONSUMO _consumo = new BLL.Procedures.REPOSICIONPORCONSUMO();
                    DateTime _fechaDesde = Convert.ToDateTime(dateTimeFDesde.Value.ToString("yyyy-MM-dd 00:00:00"));
                    DateTime _fechaHasta = Convert.ToDateTime(dateTimeFHasta.Value.ToString("yyyy-MM-dd 23:59:59"));
                    string _codRubro = comboBoxRubro.SelectedValue.ToString();
                    string _codSubRubro = comboBoxSubRubro.SelectedValue.ToString();
                    string _filtro = (comboBoxRubro.SelectedIndex == 0) ? "SRUB" : "RUBR";

                    this.dataGridViewConsumos.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.REPOSICIONPORCONSUMO item in _consumo.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(),  _filtro, _codRubro, _codSubRubro, _fechaDesde, _fechaHasta))
                    {

                        indice = dataGridViewConsumos.Rows.Add();
                        dataGridViewConsumos.Rows[indice].Cells[(int)Col_Consumo.ARTICULO].Value = item.articulo_id;
                        dataGridViewConsumos.Rows[indice].Cells[(int)Col_Consumo.DESCRIPCION].Value = item.art_descgen;
                        dataGridViewConsumos.Rows[indice].Cells[(int)Col_Consumo.UNIMED].Value = item.unimed;
                        dataGridViewConsumos.Rows[indice].Cells[(int)Col_Consumo.CONSUMO].Value = item.consumo.ToString().Replace(",", ".");
                        dataGridViewConsumos.Rows[indice].Cells[(int)Col_Consumo.PENDIENTE_REQ].Value = item.cantpendientereq.ToString().Replace(",", ".");
                        dataGridViewConsumos.Rows[indice].Cells[(int)Col_Consumo.PENDIENTE_OC].Value = item.cantpendienteoc.ToString().Replace(",", ".");
                        dataGridViewConsumos.Rows[indice].Cells[(int)Col_Consumo.REPONER].Value = item.reponer.ToString().Replace(",", ".");
                        // ahora recupero la fila del combo, para saber que fila debo llenar con la marca

                        DataGridViewRow row = dataGridViewConsumos.Rows[indice];// this.dataGridViewReq.CurrentRow;
                        DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Consumo.MARCA] as DataGridViewComboBoxCell;

                        CargarMarca(item.articulo_id, comboboxColumnSector);
                    }
                //}
            }

        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewConsumos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //solo para que no me muestre el error
        }

        private void checkBoxSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewConsumos.Rows.Count > 0)
            {
                if (this.checkBoxSeleccionar.Checked)
                {

                    foreach (DataGridViewRow item in dataGridViewConsumos.Rows)
                    {
                        item.Cells[(int)Col_Consumo.GENERAR].Value = 1;
                    }
                }
                else
                {

                    foreach (DataGridViewRow item in dataGridViewConsumos.Rows)
                    {
                        item.Cells[(int)Col_Consumo.GENERAR].Value = 0;
                    }

                }


            }
        }

        #endregion

        private void dataGridViewConsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == (int)Col_Consumo.PENDIENTE_REQ)
                {
                    //LLAMO AL REPORTE QUE MUESTRA EL DETALLE DE LOS PENDIENTES DE OC
                    RequerimientosPendientesOC(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(), dataGridViewConsumos.Rows[e.RowIndex].Cells[(int)Col_Consumo.ARTICULO].Value.ToString());

                }

                if (e.ColumnIndex == (int)Col_Consumo.PENDIENTE_OC)
                {
                    //LLAMO AL REPORTE QUE MUESTRA EL DETALLE DE LOS PENDIENTES DE OC
                    OCPendienteEntrega(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(), dataGridViewConsumos.Rows[e.RowIndex].Cells[(int)Col_Consumo.ARTICULO].Value.ToString());

                }

            }

            catch(Exception ex)
            {


            }

        }
    }
}
