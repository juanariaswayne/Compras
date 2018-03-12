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
    public interface IAddItem
    {
        void AddNewItem(string cod, string descrip,string uniMed);
    }
    public partial class Frm_EgresoArticulos : Plantilla,IAddItem
    {
        #region Variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;

            private enum Col_Detalle
            {
                BUSCADOR = 0,
                CODIGO,
                DESCRIPCION,
                EXISTENCIA,
                UNIDAD,
                CANTIDAD
                        
            }

          protected  int _indexSeleccionado;
          protected List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
          protected List<Entities.Procedures.RUBROARTICULOS> _rubrositem = new List<Entities.Procedures.RUBROARTICULOS>();
        //VARIABLE PARA PASAR CON ENTER A OTRA COLUMNA
          private DataGridViewCell _celWasEndEdit;
        //VARIABLE PARA CARGAR LOS SECTORES
          DataGridViewComboBoxEditingControl dgvCombo;
        //VARIABLE PARA SABER SI ESTOY UTILIZANDO EL LECTOR
        bool _lector = false;
        int _nroRemitoGenerado;
        decimal _existenciaArticulo = 0;
        CultureInfo culture = new CultureInfo("en-US");
        #endregion

        #region IAddItem Members

        public void AddNewItem(string cod, string descrip,string uniMed)
            {
                this.dataGridViewDetalle.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.CODIGO].Value = cod;
                this.dataGridViewDetalle.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.DESCRIPCION].Value = descrip;
                this.dataGridViewDetalle.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.UNIDAD].Value = uniMed;
                this.dataGridViewDetalle.CurrentCell = this.dataGridViewDetalle.CurrentRow.Cells[(int)Col_Detalle.CANTIDAD];

            //TRAIGO EL STOCK DE ESTE ARTICULO....
            _existenciaArticulo = 0;
            _existenciaArticulo = ExistenciaArticulo(comboBoxDepositoSalida.SelectedValue.ToString(), cod);
            //bool _tieneVto = LlevaVtoArt(cod);

            this.dataGridViewDetalle.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.EXISTENCIA].Value = _existenciaArticulo.ToString().Replace(",", ".");
            this.dataGridViewDetalle.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.EXISTENCIA].Style.ForeColor = (_existenciaArticulo <= 0) ? Color.Red : Color.Black;
                     
            //this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.LLEVA_VTO].Value = _tieneVto;
        }

        #endregion

        #region Funciones
            public Frm_EgresoArticulos()
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
                    this.comboBoxDepositoSalida.SuspendLayout();
                    this.comboBoxDepositoSalida.DataSource = null;
                    this.comboBoxDepositoSalida.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.DESCRIPCION = "<Seleccione un Depósito>";
                    _itemSeleccion.DEPOSITO_ID = 0;
                    _dep.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxDepositoSalida.DisplayMember = BLL.Tables.STKDEPOSITO.ColumnNames.DESCRIPCION;
                    this.comboBoxDepositoSalida.ValueMember = BLL.Tables.STKDEPOSITO.ColumnNames.DEPOSITO_ID;
                    this.comboBoxDepositoSalida.DataSource = _dep.Result.ToArray();

                    this.comboBoxDepositoSalida.ResumeLayout();
                    //SETEO EL DEPOSITO SEGUN LA EMPRESA ////
                    if (Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToUpper().ToString().Trim() == "DEPOSITO")
                    {
                        this.comboBoxDepositoSalida.SelectedValue = 1;

                    }


            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

            private void CargarSectoresDeposito(string _codEmp, int _dep)
            {
                try
                {
                    BLL.Tables.STKSECTOR _sec = new BLL.Tables.STKSECTOR();
                    _sec.OrderByParameter.Add(DAL.Tables.STKSECTOR.ColumnEnum.descripcion);
                    _sec.ItemList(_codEmp, _dep);

                    Entities.Tables.STKSECTOR _itemSeleccion = new Entities.Tables.STKSECTOR();

                    //Limpia el combo
                    this.comboBoxSectorSalida.SuspendLayout();
                    this.comboBoxSectorSalida.DataSource = null;
                    this.comboBoxSectorSalida.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.DESCRIPCION = "<Seleccione un Sector>";
                    _itemSeleccion.SECTOR_ID = 0;
                    _sec.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxSectorSalida.DisplayMember = BLL.Tables.STKSECTOR.ColumnNames.DESCRIPCION;
                    this.comboBoxSectorSalida.ValueMember = BLL.Tables.STKSECTOR.ColumnNames.SECTOR_ID;
                    this.comboBoxSectorSalida.DataSource = _sec.Result.ToArray();

                    this.comboBoxSectorSalida.ResumeLayout();

                    this.comboBoxSectorSalida.SelectedIndex = 0;
                    //SETEO EL DEPOSITO SEGUN LA EMPRESA ////
                    if (Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToUpper().ToString().Trim() == "DEPOSITO")
                    {
                        this.comboBoxSectorSalida.SelectedValue = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? 1 : 2;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

        private void CargarDepositosDestino_Predefinido()
        {
            try
            {
                //CARGO SOLO LOS DEPOSITO DE LA EMPRESA LOGEADA
                BLL.Tables.STKDEPOSITO _dep = new BLL.Tables.STKDEPOSITO();
                _dep.WhereParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim());
                _dep.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.OR, DAL.Tables.STKDEPOSITO.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, "AMBA");//TAMBIEN TRAIGO LA EMPRESA AMBA
                _dep.OrderByParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.descripcion);
                _dep.ItemList();
                Entities.Tables.STKDEPOSITO _itemSeleccion = new Entities.Tables.STKDEPOSITO();

                //Limpia el combo
                this.comboBoxDepositoDestino.SuspendLayout();
                this.comboBoxDepositoDestino.DataSource = null;
                this.comboBoxDepositoDestino.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione un Depósito Destino>";
                _itemSeleccion.DEPOSITO_ID = 0;
                _dep.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxDepositoDestino.DisplayMember = BLL.Tables.STKDEPOSITO.ColumnNames.DESCRIPCION;
                this.comboBoxDepositoDestino.ValueMember = BLL.Tables.STKDEPOSITO.ColumnNames.DEPOSITO_ID;
                this.comboBoxDepositoDestino.DataSource = _dep.Result.ToArray();

                this.comboBoxDepositoDestino.ResumeLayout();
                this.comboBoxDepositoDestino.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void CargarSectoresDestino_Predefinido( int _dep)
        {
            try
            {
                BLL.Tables.STKSECTOR _sec = new BLL.Tables.STKSECTOR();
                _sec.OrderByParameter.Add(DAL.Tables.STKSECTOR.ColumnEnum.descripcion);
                _sec.ItemList(_dep);

                Entities.Tables.STKSECTOR _itemSeleccion = new Entities.Tables.STKSECTOR();

                //Limpia el combo
                this.comboBoxSectorDestino.SuspendLayout();
                this.comboBoxSectorDestino.DataSource = null;
                this.comboBoxSectorDestino.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione un Sector Destino>";
                _itemSeleccion.SECTOR_ID = 0;
                _sec.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSectorDestino.DisplayMember = BLL.Tables.STKSECTOR.ColumnNames.DESCRIPCION;
                this.comboBoxSectorDestino.ValueMember = BLL.Tables.STKSECTOR.ColumnNames.SECTOR_ID;
                this.comboBoxSectorDestino.DataSource = _sec.Result.ToArray();

                this.comboBoxSectorDestino.ResumeLayout();

                this.comboBoxSectorDestino.SelectedIndex = 0;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        //private void CargarMercaderia()
        //{
        //    try
        //    {
        //        string _IDAnt;
        //        string _descripAnt;
        //        string _unimedAnt;
        //        string _codEmpAnt;
        //        CultureInfo culture = new CultureInfo("en-US");
        //        //Entities.Procedures.MERCADERIA_CARGADA _item = new Entities.Procedures.MERCADERIA_CARGADA();
        //        BLL.Procedures.MERCADERIA_CARGADA _merc = new BLL.Procedures.MERCADERIA_CARGADA();
        //        _merc.Items(this.dateTimeFecha.Value);

        //        if (_merc.Resultset.Count > 0)
        //        {
        //            this.dataGridViewDetalle.Rows.Clear();
        //            int indice;
        //            int i = 0;

        //            //_item = new Entities.Procedures.MERCADERIA_CARGADA();

        //            indice = dataGridViewDetalle.Rows.Add();
        //            _IDAnt = _merc.Result[i].id_articulo;
        //            _descripAnt = _merc.Result[i].art_descgen;
        //            _unimedAnt = _merc.Result[i].unimed;
        //            _codEmpAnt = _merc.Result[i].codemp;
        //            this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.CODIGO].Value = _merc.Result[i].id_articulo;
        //            this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.DESCRIPCION].Value = _merc.Result[i].art_descgen;
        //            this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.UNIDAD].Value = _merc.Result[i].unimed;


        //            while (i < _merc.Resultset.Count)
        //            {
        //                if (_IDAnt.Trim() == _merc.Result[i].id_articulo.Trim())
        //                {
        //                    if (_merc.Result[i].codemp == "EGES")
        //                    {
        //                        this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.EGESAC].Value = Convert.ToDecimal(_merc.Result[i].cantidad,culture);
        //                    }

        //                    if (_merc.Result[i].codemp == "RSC")
        //                    {
        //                        this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.RSC].Value = Convert.ToDecimal(_merc.Result[i].cantidad,culture);
        //                    }
        //                }
        //                else
        //                {
        //                    indice = dataGridViewDetalle.Rows.Add();
        //                    _IDAnt = _merc.Result[i].id_articulo;
        //                    _descripAnt = _merc.Result[i].art_descgen;
        //                    _unimedAnt = _merc.Result[i].unimed;
        //                    this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.CODIGO].Value = _merc.Result[i].id_articulo;
        //                    this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.DESCRIPCION].Value = _merc.Result[i].art_descgen;
        //                    this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.UNIDAD].Value = _merc.Result[i].unimed;
        //                    if (_merc.Result[i].codemp == "EGES")
        //                    {
        //                        this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.EGESAC].Value = Convert.ToDecimal(_merc.Result[i].cantidad,culture);
        //                    }

        //                    if (_merc.Result[i].codemp == "RSC")
        //                    {
        //                        this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.RSC].Value = Convert.ToDecimal(_merc.Result[i].cantidad,culture);
        //                    }
        //                }

        //                i++;

        //            }

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        //}

        //private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
            
        //{
            
        //    //!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46
        //    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46) // Si no es numerico y si no es espacio EL 46 ES EL PUNTO
        //    {
        //        // Invalidar la accion
        //        e.Handled = true;
        //        // Enviar el sonido de beep de windows
        //        System.Media.SystemSounds.Beep.Play();
        //    }
            
        //}

        private bool VerificaIngreso()
        {
            try
            {
                if (this.comboBoxDepositoSalida.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxDepositoSalida, "Debe seleccionar un Depósito");
                    this.comboBoxDepositoSalida.Focus();
                    return false;
                }

                if (this.comboBoxDepositoDestino.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxDepositoDestino, "Debe seleccionar un Depóstio Destino");
                    this.comboBoxDepositoDestino.Focus();
                    return false;
                }

                if (this.comboBoxSectorDestino.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxSectorDestino, "Debe seleccionar un Sector Destino");
                    this.comboBoxSectorDestino.Focus();
                    return false;
                }

                //if (String.IsNullOrEmpty(this.textBoxObs.Text.Trim()))
                //{
                //    this.errorProvider1.SetError(this.textBoxObs, "Debe ingresar una Observación");
                //    this.textBoxObs.Focus();
                //    return false;
                //}

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        private void CargarDepositosDestino()
        {
            //try
            //{
                //CARGO LOS DEPOSITOS EN LA COLUMNA COMBO DEL GRID

            //   DataGridViewComboBoxColumn comboboxColumnDeposito = dataGridViewDetalle.Columns[(int)Col_Detalle.DEPOSITO] as DataGridViewComboBoxColumn;

            //    BLL.Tables.STKDEPOSITO _tip = new BLL.Tables.STKDEPOSITO();
            //    _tip.ItemList();
            //    Entities.Tables.STKDEPOSITO _itemSeleccion2 = new Entities.Tables.STKDEPOSITO();

            //    //Limpia el combo
            //    //this.comboBoxProveed.SuspendLayout();
            //    comboboxColumnDeposito.DataSource = null;
            //    comboboxColumnDeposito.Items.Clear();


            //    //Carga el item de Seleccion
            //    _itemSeleccion2.DESCRIPCION = "<Seleccione un Deposito>";
            //    _itemSeleccion2.DEPOSITO_ID = 0;
            //    _tip.Result.Insert(0, _itemSeleccion2);

            //    //Carga el combo
            //    comboboxColumnDeposito.DataSource = _tip.Result.ToArray();
            //    comboboxColumnDeposito.DisplayMember = BLL.Tables.STKDEPOSITO.ColumnNames.DESCRIPCION;
            //    comboboxColumnDeposito.ValueMember = BLL.Tables.STKDEPOSITO.ColumnNames.DEPOSITO_ID;
    
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            //}

        }

        private void CargarSectoresDestino(int _dep, DataGridViewComboBoxCell comboboxColumnSector)
        {
            //try
            //{


            //   BLL.Tables.STKSECTOR _tip = new BLL.Tables.STKSECTOR();
            //    //_tip.WhereParameter.Clear();
            //    _tip.ItemList(_dep); //TRAE LOS SECTORES DE ESTE DEPOSITO
            //    Entities.Tables.STKSECTOR _itemSeleccion2 = new Entities.Tables.STKSECTOR();

            //    //Limpia el combo
            //    //this.comboBoxProveed.SuspendLayout();
            //    comboboxColumnSector.DataSource = null;
            //    comboboxColumnSector.Items.Clear();


            //    //Carga el item de Seleccion
            //    _itemSeleccion2.DESCRIPCION = "<Seleccione un Sector>";
            //    _itemSeleccion2.SECTOR_ID = 0;
            //    _tip.Result.Insert(0, _itemSeleccion2);

            //    //Carga el combo
            //    comboboxColumnSector.DataSource = _tip.Result.ToArray();
            //    comboboxColumnSector.DisplayMember = BLL.Tables.STKSECTOR.ColumnNames.DESCRIPCION;
            //    comboboxColumnSector.ValueMember = BLL.Tables.STKSECTOR.ColumnNames.SECTOR_ID;
            //    comboboxColumnSector.Value = 0;
            //    //FIN CARGO COMBO TIPO RECLAMO

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}

        }

        private void dvgCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //es el combo del deposito
           // ComboBox combo = sender as ComboBox;
            
           // // ahora recupero la fila del combo sector, para saber que fila debo llenar con el sector
                     
           //DataGridViewRow row = this.dataGridViewDetalle.CurrentRow;
           //DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Detalle.SECTOR] as DataGridViewComboBoxCell;
         
           //CargarSectoresDestino(Convert.ToInt32(combo.SelectedValue), comboboxColumnSector);

            
        }

        private void ImprimirRemito()
        {
            try
            {
                if (_nroRemitoGenerado > 0)
                {

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
                    ParametroValue.Value = "R";
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Sucursal";
                    ParametroValue.Value = "0001";
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@comprobante";
                    ParametroValue.Value = _nroRemitoGenerado;
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

        private decimal ExistenciaArticulo(string _deposito,string _articulo)
        {
            try
            {
                decimal _stock;
                _stock = 0;
                BLL.Procedures.STOCK_A_FECHA_POREMPRESA _existencia = new BLL.Procedures.STOCK_A_FECHA_POREMPRESA();
                if (_existencia.ItemList(_deposito, "ARTI", null, null, _articulo).Count > 0)
                {
                    _stock =  _existencia.Resultset[0].cantidad;
                }

                return _stock;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private bool LlevaVtoArt(string _articulo)
        {
            try
            {
                bool _vto = false;

                BLL.Tables.STKARTICULOS _artStk = new BLL.Tables.STKARTICULOS();
                _artStk.WhereParameter.Add(DAL.Tables.STKARTICULOS.ColumnEnum.articulo_id, DAL.SqlEnums.OperandEnum.Equal, _articulo);
                if (_artStk.ItemList().Count > 0)
                {
                    _vto = _artStk.Resultset[0].LLEVAVENCIMIENTO;
                }

                return _vto;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool FechaVtoCorrecta (string _articulo, string _fechaEtiqueta)
        {
            try
            {
                bool _correcta = true;
                //VERIFICO QUE NO ESTE SACANDO UNA FECHA MAS NUEVA.. ES DECIR QUE TIENE QUE SACAR UN ARTICULO CON FECHA MAS PROXIMA A VENCER
                BLL.Tables.STKVENCIMIENTO _existeVto = new BLL.Tables.STKVENCIMIENTO();
                _existeVto.WhereParameter.Add(DAL.Tables.STKVENCIMIENTO.ColumnEnum.articulo_id, DAL.SqlEnums.OperandEnum.Equal, _articulo);
                _existeVto.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, DAL.Tables.STKVENCIMIENTO.ColumnEnum.vto, DAL.SqlEnums.OperandEnum.LessThan, _fechaEtiqueta);
                _existeVto.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, DAL.Tables.STKVENCIMIENTO.ColumnEnum.enStock, DAL.SqlEnums.OperandEnum.GreaterThan, 0);

                if (_existeVto.ItemList().Count > 0)
                {
                    _correcta = false; //EXISTEN ARTICULOS CON FECHA MAS PROXIMA A VENCER QUE ESTA ETIQUETA
                }
               

                return _correcta;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Eventos

        private void Frm_EnvioMercaderia_Load(object sender, EventArgs e)
        {
            try
            {
            
        
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
                this.dateTimeFecha.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                this.Text = "Salida de Mercadería desde la Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();

                // cargo en una coleccion los productos por unica vez
                BLL.Procedures.H_ARTICULOSDEPOSITO _art = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                _articulosItem = _art.ItemList();//le paso la colección de artículos

                //también cargo los rubros por única vez
                BLL.Procedures.RUBROARTICULOS _rubro = new BLL.Procedures.RUBROARTICULOS();
                _rubrositem = _rubro.ItemList();//le paso la colección de rubros
          
                CargarDepositos();
                //CARGO LOS DEPOSITOS EN LA COLUMNA COMBO DEL GRID
                //CargarDepositosDestino(); NO LO VOY A UTILIZAR ... TOMO EL DEPOSITO Y SECTOR PREDEFINIDO EN EL ENCABEZADO

                CargarDepositosDestino_Predefinido();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

          
        }
        

        private void buttonNew_Click(object sender, EventArgs e)
        {
            dataGridViewDetalle.Rows.Clear();
        }

        private void comboBoxDepositoSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxDepositoSalida.SelectedIndex > 0)
                CargarSectoresDeposito(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(), Convert.ToInt32(this.comboBoxDepositoSalida.SelectedValue));
        }

        private void dataGridViewDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    Frm_Productos _prod = new Frm_Productos();
                    _prod.Articulos = _articulosItem;//le paso la colección de artículos
                    //paso los rubros
                    _prod.Rubros = _rubrositem;
                    _indexSeleccionado = e.RowIndex; //establezco el index
                    _prod.MdiParent = this.MdiParent; // esto porque estoy utiliando MDI
                    _prod.Opener = this; // es para el formulario hijo
                    _prod.Show();

                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewDetalle_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewDetalle.IsCurrentCellDirty)
                dataGridViewDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

       
        private void dataGridViewDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //SOLO PERMITE NUMEROS EN LA COLUMNA CANTIDAD
            if (dataGridViewDetalle.CurrentCell.ColumnIndex == (int)Col_Detalle.CANTIDAD)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dataGridViewDetalle_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dataGridViewDetalle_KeyPress);
                }
            }

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaIngreso())
                {
                    //OBJETOS STKINVENTARIO
                    Entities.Tables.STKINVENTARIO _itemInventario = new Entities.Tables.STKINVENTARIO();
                    List<Entities.Tables.STKINVENTARIO> _itemsInv = new List<Entities.Tables.STKINVENTARIO>();

                    //OBJETOS STKMOVIMIENTOSITEM
                    Entities.Tables.STKMOVIMIENTOITEM _itemMov = new Entities.Tables.STKMOVIMIENTOITEM();
                    List<Entities.Tables.STKMOVIMIENTOITEM> _itemsMov = new List<Entities.Tables.STKMOVIMIENTOITEM>();

                    //VARIABLES STKMOVIMIENTOS
                    Entities.Tables.STKMOVIMIENTO _itemMovimiento = new Entities.Tables.STKMOVIMIENTO();
                    BLL.Tables.STKMOVIMIENTO _stk = new BLL.Tables.STKMOVIMIENTO();

                   
                    for (int i = 0; i < this.dataGridViewDetalle.Rows.Count - 1; i++)
                    {
                        _itemInventario = new Entities.Tables.STKINVENTARIO();
                        _itemInventario.ARTICULO_ID = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CODIGO].Value.ToString().Trim().ToUpper();//COD ARTICULO
                        _itemInventario.CANTIDAD = Convert.ToDecimal(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value.ToString(), culture); //cantidad
                        _itemInventario.DEPOSITO_ID = Convert.ToInt32(this.comboBoxDepositoSalida.SelectedValue);//DEPOSITO DE DONDE SALE LA MERCADERIA
                        _itemInventario.SECTOR_ID = 1; //  *** NO SE USA ... NO SE LLEVA EL STOCK POR SECTOR Convert.ToInt32(this.comboBoxSectorSalida.SelectedValue); //SECTOR DE DONDE SALE LA MERCADERIA
                        _itemInventario.UNIMED = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.UNIDAD].Value.ToString();//UNIDAD MEDIDA
                        //VOY AGREGANDO A LA COLECCION
                        _itemsInv.Add(_itemInventario);

                        //AHORA CARGO EL OBJETO STKMOVIMIENTOITEM
                        _itemMov = new Entities.Tables.STKMOVIMIENTOITEM();
                        _itemMov.ARTICULO_ID = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CODIGO].Value.ToString();//COD ARTICULO
                        _itemMov.CANTIDAD = Convert.ToDecimal(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value.ToString(), culture); //cantidad
                        _itemMov.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(); //CODEMP
                        _itemMov.UNIMED = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.UNIDAD].Value.ToString();//UNIDAD MEDIDA
                    
                        //VOY AGREGANDO A LA COLECCION
                        _itemsMov.Add(_itemMov);



                    }

                    //CARGO LOS OBJETOS DE STKMOVIMIENTOS
                    _itemMovimiento.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(); //CODEMP
                    _itemMovimiento.ANULADO = 0;
                    _itemMovimiento.TIPOMOV_ID = 2; //OJO VER ESTO SI SE PUEDE CAMBIAR...... EL 2 ES SALIDA *************************************
                    _itemMovimiento.SUBTIPOMOV_ID = 2; //ojo ver SI SE PUEDE CAMBIAR...... EL 2 es CAMBIO DE DEPÓSITOP **************************
                    _itemMovimiento.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();
                    _itemMovimiento.OBS = "";
                    _itemMovimiento.FECHAMOV = Convert.ToDateTime(this.dateTimeFecha.Value.ToShortDateString());
                    _itemMovimiento.DEPOSITOORIGEN_ID = Convert.ToInt32(this.comboBoxDepositoSalida.SelectedValue);//DEPOSITO DE DONDE SALE LA MERCADERIA
                    _itemMovimiento.SECTORORIGEN_ID = 1; //  OJO NO SE LLEVA EL STOCK POR SECTOR Convert.ToInt32(this.comboBoxSectorSalida.SelectedValue); //SECTOR DE DONDE SALE LA MERCADERIA
                    _itemMovimiento.DEPOSITODESTINO_ID = Convert.ToInt32(this.comboBoxDepositoDestino.SelectedValue.ToString()); // SACADO 29-08-2016 NO USO EL DEPOSITO DE LA GRILLA Convert.ToInt32(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.DEPOSITO].Value.ToString());//DEPOSITO DESTINO
                    _itemMovimiento.SECTORDESTINO_ID = Convert.ToInt32(this.comboBoxSectorDestino.SelectedValue.ToString()); // SACADO 29-08-2016 NO USO EL SECTOR DE LA GRILLA Convert.ToInt32(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.SECTOR].Value.ToString());//SECTOR DESTINO

                    _nroRemitoGenerado = _stk.GenerarMovStock(_itemsInv, _itemMovimiento, _itemsMov);
                    if (_nroRemitoGenerado > 0)
                    {
                        MessageBox.Show("El ingreso se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ImprimirRemito();

                        dataGridViewDetalle.Rows.Clear();
                        this.comboBoxDepositoSalida.SelectedIndex = 0;
                        //this.comboBoxSectorSalida.SelectedIndex = 0;
                        this.comboBoxDepositoDestino.SelectedIndex = 0;
                        this.comboBoxSectorDestino.SelectedIndex = 0;
                    }

                    else
                    {
                        MessageBox.Show("Error al ingresar Stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void dataGridViewDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // LO DE ABAJO SACADO 29-08-2016
            //if (dgvCombo != null && (e.ColumnIndex == (int)Col_Detalle.DEPOSITO))
            //{ dgvCombo.SelectedIndexChanged -= new EventHandler(dvgCombo_SelectedIndexChanged); }

            _celWasEndEdit = dataGridViewDetalle[e.ColumnIndex, e.RowIndex];
           
            try
            {
                // ********************** TRAIGO DESCRIPCIÓN DEL PRODUCTO.. Y SI ESTOY UTILIZANDO LECTOR.. TAMBIEN TRAIGO LA CANTIDAD QUE DICE LA ETIQUETA
                if (e.ColumnIndex == (int)Col_Detalle.CODIGO)
                {
                    Entities.Procedures.H_ARTICULOSDEPOSITO _resultado = new Entities.Procedures.H_ARTICULOSDEPOSITO();


                    if (this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.CODIGO].Value.ToString().ToUpper().Trim().Length == 22)
                    {
                        //ESTOY UTILIZNADO LECTOR DE CÓDIGOS, EXTRAIGO EL CÓDIGO DEL ARTÍCULO
                        _lector = true;
                        decimal _cantidadLeida;
                        DateTime _fechaVto;
                        string _cadenaIngresada;

                        _cadenaIngresada = this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.CODIGO].Value.ToString().ToUpper().Trim();
                        string _articulo = _cadenaIngresada.Substring(0, 7);//this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.CODIGO].Value.ToString().ToUpper().Trim().Substring(1, 6);//TRIMSTART me saca los ceros de la izquierda..
                        
                        _articulo = _articulo.TrimStart('0');
                        //MessageBox.Show(_articulo);

                        _cantidadLeida = Convert.ToDecimal(_cadenaIngresada.Substring(7, 7)); // Convert.ToDecimal(this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.CODIGO].Value.ToString().ToUpper().Trim().Substring(7, 7));
                        _resultado = _articulosItem.Where(x => x.art_codgen.ToUpper().ToString().Trim() == _articulo.ToString()).First();

                        this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.CODIGO].Value = _resultado.art_codgen.Trim();
                        this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.CANTIDAD].Value = _cantidadLeida.ToString().Replace(",", ".");//CANTIDAD  ;

                        //TRAIGO EL STOCK DE ESTE ARTICULO.... 
                        _existenciaArticulo = 0;
                        _existenciaArticulo = ExistenciaArticulo(comboBoxDepositoSalida.SelectedValue.ToString(), _articulo);

                        this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.EXISTENCIA].Value = _existenciaArticulo.ToString().Replace(",", ".");
                        this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.EXISTENCIA].Style.ForeColor = (_existenciaArticulo <= 0) ? Color.Red : Color.Black;
                        //VERIFICO SI ESTE ARTICULO LLEVA VTO. DE SER ASÍ, CONTROLO QUE LA ETIQUETA QUE ESTA LEYENDO TENGA LA FECHA CORRECTA, ES
                        bool _tieneVto = LlevaVtoArt(_resultado.art_codgen);
                        if(_tieneVto)
                        {
                           
                            //_fechaVto = DateTime.ParseExact(_cadenaIngresada.Substring(14, 8),"yyyyMMdd",culture);
                            if (!FechaVtoCorrecta(_resultado.art_codgen.Trim(), _cadenaIngresada.Substring(14, 8)))
                            {
                                //LA FECHA DE VTO NO ES CORRECTA
                                DialogResult _result = MessageBox.Show("Este artículo tiene en stock, cantidades con fecha mas próxima a vencer que la que intenta sacar, desea continuar de todos modos?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                                if (_result == System.Windows.Forms.DialogResult.Cancel)
                                {
                                    dataGridViewDetalle.Rows.Remove(dataGridViewDetalle.CurrentRow);
                                    return;
                                }
                            
                               
                            }
                        }
                    }
                    else
                    {
                        _lector = false;
                        //ESTOY ESCRIBIENDO EL ARTÍCULO A MANO
                        _resultado = _articulosItem.Where(x => x.art_codgen.ToUpper().ToString().Trim() == this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.CODIGO].Value.ToString().ToUpper().Trim()).First();
                        this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.CODIGO].Value = _resultado.art_codgen.ToUpper().Trim();
                    }

                    this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.DESCRIPCION].Value = _resultado.art_descgen;
                    this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.UNIDAD].Value = _resultado.unimed;

                    //TRAIGO EL STOCK DE ESTE ARTICULO.... 
                    _existenciaArticulo = 0;
                     _existenciaArticulo = ExistenciaArticulo(comboBoxDepositoSalida.SelectedValue.ToString(), _resultado.art_codgen);
                    this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.EXISTENCIA].Value = _existenciaArticulo.ToString().Replace(",", ".");
                    this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.EXISTENCIA].Style.ForeColor = (_existenciaArticulo <= 0) ? Color.Red : Color.Black;
                    

                }


            }




            catch (Exception ex)
            {
                MessageBox.Show("Artículo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            // ********************

        }

        private void dataGridViewDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //solo para que no me muestre el error
        }

        private void dataGridViewDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                //MUESTRO PRODUCTOS CUANDO LE DOY UN ENTER EN EL BOTON DE LA PRIMER COLUMNA
                var senderGrid = (DataGridView)sender;
                if (e.KeyCode == Keys.Enter && senderGrid.Columns[this.dataGridViewDetalle.CurrentCell.ColumnIndex].Index == (int)Col_Detalle.BUSCADOR && this.dataGridViewDetalle.CurrentCell.RowIndex >= 0)
                {
                    Frm_Productos _prod = new Frm_Productos();
                    _prod.Articulos = _articulosItem;//le paso la colección de artículos
                                                     //paso los rubros
                    _prod.Rubros = _rubrositem;
                    _indexSeleccionado = this.dataGridViewDetalle.CurrentCell.RowIndex; //establezco el index
                    _prod.MdiParent = this.MdiParent; // esto porque estoy utiliando MDI
                    _prod.Opener = this; // es para el formulario hijo
                    _prod.Show();
                    _prod.StartPosition = FormStartPosition.CenterScreen;
                }

                //            Dim li_index As Integer

                //If e.KeyCode = Keys.Delete Then

                // e.Handled = True

                // li_index = CType(sender, DataGridView).CurrentRow.Index
                // DataGridView.Row.RemoveAt(li_index)

                //End If
                int li_index;
                if (e.KeyCode == Keys.Delete)
                {
                    e.Handled = true;
                    li_index = senderGrid.CurrentCell.RowIndex;
                    if (li_index >= 0)
                        senderGrid.Rows.RemoveAt(li_index);

                }

            }

            catch(Exception ex)
            {


            }

         }
        
        private void dataGridViewDetalle_SelectionChanged(object sender, EventArgs e)
        {
            //PASO CON ENTER A LA OTRA COLUMNA
            if (MouseButtons != 0) return;

            if (_celWasEndEdit != null && dataGridViewDetalle.CurrentCell != null)
            {
                // if we are currently in the next line of last edit cell
                if (dataGridViewDetalle.CurrentCell.RowIndex == _celWasEndEdit.RowIndex + 1 &&
                    dataGridViewDetalle.CurrentCell.ColumnIndex == _celWasEndEdit.ColumnIndex)
                {
                    int iColNew;
                    int iRowNew = 0;
                    if (_celWasEndEdit.ColumnIndex >= dataGridViewDetalle.ColumnCount - 1)
                    {
                        //SI ESTOY UTILIZANDO LECTOR O INGRESO EL CÓDIGO... FUERZO EL FOCO
                        //if (dataGridViewDetalle.CurrentCell.ColumnIndex == (int)Col_Detalle.CODIGO)
                        //{
                        //    iColNew = (int)Col_Detalle.DEPOSITO;
                        //    iRowNew = _celWasEndEdit.RowIndex;
                        //}
                        //else
                        //{

                        //    iColNew = 0;
                        //    iRowNew = dataGridViewDetalle.CurrentCell.RowIndex;
                        //}
                        iColNew = 0;
                        iRowNew = dataGridViewDetalle.CurrentCell.RowIndex;
                    }
                    else
                    {
                        //SI ESTOY UTILIZANDO LECTOR O INGRESO EL CÓDIGO... FUERZO EL FOCO
                        //if (dataGridViewDetalle.CurrentCell.ColumnIndex == (int)Col_Detalle.CODIGO)
                        //{
                        //    //iColNew = (int)Col_Detalle.DEPOSITO;
                        //    //iRowNew = _celWasEndEdit.RowIndex;
                        //}
                        //else
                        //{
                        //    iColNew = _celWasEndEdit.ColumnIndex + 1;
                        //    iRowNew = _celWasEndEdit.RowIndex;
                        //}
                        if (_lector)
                        {
                            iColNew = 1;//_celWasEndEdit.ColumnIndex + 1;
                            iRowNew = _celWasEndEdit.RowIndex + 1;
                        }
                        else
                        {
                            iColNew = (int)Col_Detalle.CANTIDAD;
                            iRowNew = _celWasEndEdit.RowIndex;
                        }
                    }
                    
                    dataGridViewDetalle.CurrentCell = dataGridViewDetalle[iColNew, iRowNew];
                }
                
            }

 
            _celWasEndEdit = null;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxDepositoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CARGO LOS SECTORES DE ESTE DEPOSITO
            CargarSectoresDestino_Predefinido(Convert.ToInt32(this.comboBoxDepositoDestino.SelectedValue));
        }

        private void comboBoxSectorDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                //if(this.comboBoxDepositoDestino.SelectedIndex > 0 && this.comboBoxDepositoDestino.SelectedIndex > 0 )
                //{
                //    //SACADO 29-08-2016 CARGO TODA LA COLUMNA CON LOS SECTORES

                //    //DataGridViewRow row = this.dataGridViewDetalle.CurrentRow;
                //    //DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Detalle.SECTOR] as DataGridViewComboBoxCell;

                //    //CargarSectoresDestino( Convert.ToInt32(this.comboBoxDepositoDestino.SelectedValue), comboboxColumnSector);
                //}


            }


              catch (Exception ex)
            {
                MessageBox.Show("Artículo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            ImprimirRemito();
        }


        #endregion

        private void dataGridViewDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // SI ESTOY EN LA COLUMNA CANTIDAD VALIDO QUE SOLO SE INGRESEN NUMEROS
            if (dataGridViewDetalle.CurrentCell.ColumnIndex == (int)Col_Detalle.CANTIDAD)
            {
                if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
               
            }

            //if(dataGridViewDetalle.CurrentCell.ColumnIndex == (int)Col_Detalle.CODIGO)
            //{
            //    string texto = this.dataGridViewDetalle.Rows[this.dataGridViewDetalle.CurrentCell.RowIndex].Cells[(int)Col_Detalle.CODIGO].Value.ToString();
            //    if(texto.Length == 22)
            //    {
            //        dataGridViewDetalle_CellEndEdit(null,null);
            //    }
            //}
        }
    }

}
