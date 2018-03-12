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
    public partial class Frm_EgresoDepositoPorRequerimientoInterno : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private enum Col_Cabe
        {
            DEPOSITO_ORIGEN=0,
            SECTOR_DEPOSITO_ORIGEN,
            CODEMP ,
            REQUERIMIENTO_ID,
            FECHA,
            PEDIDOPOR,
            ENTREGA_ID,
            LUGARENTREGA,
            OBS

        }

        private enum Col_Detalle
        {
            CODEMP = 0,
            REQUERIMIENTO_ID,
            CODIGO,
            NROITEM,
            DESCRIPCION,
            UNIDAD,
            CANT_PEDIDA,
            CANT_ADEUDADA,
            EXISTENCIA,
            CANT_A_ENVIAR

        }

        int _nroRemitoGenerado;
        decimal _existenciaArticulo = 0;
        CultureInfo culture = new CultureInfo("en-US");
        string _codEmpresa = string.Empty;
        Int32 _nroRequerimientoInterno = 0;
        int _depositoEnvioMercaderia = 0;
        int _sectorDepositoEnvioMercaderia = 0;
        #endregion

#region Funciones

        public Frm_EgresoDepositoPorRequerimientoInterno()
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

        private void TraerRequerimientos(string _codEmp, int _deposito, int _sector)
        {
            try
            {
                BLL.Procedures.REQUERIMIENTO_INTERNO_PENDIENTE_ENTREGAR _detalle = new BLL.Procedures.REQUERIMIENTO_INTERNO_PENDIENTE_ENTREGAR();
                this.dataGridViewReqCabe.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.REQUERIMIENTO_INTERNO_PENDIENTE_ENTREGAR item in _detalle.ItemList(_codEmp,_deposito,_sector))
                {
                    indice = dataGridViewReqCabe.Rows.Add();
                    dataGridViewReqCabe.Rows[indice].Cells[(int)Col_Cabe.CODEMP].Value = item.codemp;//COD EMP
                    dataGridViewReqCabe.Rows[indice].Cells[(int)Col_Cabe.REQUERIMIENTO_ID ].Value = item.requerimiento_id; // NRO REQUERIMIENTO
                    dataGridViewReqCabe.Rows[indice].Cells[(int)Col_Cabe.FECHA].Value = Convert.ToDateTime(item.fecha).ToShortDateString(); //FECHA
                    dataGridViewReqCabe.Rows[indice].Cells[(int)Col_Cabe.PEDIDOPOR].Value = item.usuario;//USUARIO
                    //dataGridViewReqCabe.Rows[indice].Cells[(int)Col_Cabe.ENTREGA_ID].Value = item.sectorentrega_id;// SECTOR ENTREGA_ID
                    dataGridViewReqCabe.Rows[indice].Cells[(int)Col_Cabe.LUGARENTREGA].Value = item.lugarentrega;//LUGAR DE ENTREGA
                    dataGridViewReqCabe.Rows[indice].Cells[(int)Col_Cabe.OBS].Value = item.obs;//OBS
                    dataGridViewReqCabe.Rows[indice].Cells[(int)Col_Cabe.DEPOSITO_ORIGEN].Value = item.depositoorigen_id;//  ES EL DEPOSITO AL CUAL HAY QUE ENVIAR LA MERCADERIA
                    dataGridViewReqCabe.Rows[indice].Cells[(int)Col_Cabe.SECTOR_DEPOSITO_ORIGEN].Value = item.sectordepositoorigen_id;//  ES EL SECTOR DEL DEPOSITO AL CUAL HAY QUE ENVIAR LA MERCADERIA

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private decimal ExistenciaArticulo(string _deposito, string _articulo)
        {
            try
            {
                decimal _stock;
                _stock = 0;
                BLL.Procedures.STOCK_A_FECHA_POREMPRESA _existencia = new BLL.Procedures.STOCK_A_FECHA_POREMPRESA();
                if (_existencia.ItemList(_deposito, "ARTI", null, null, _articulo).Count > 0)
                {
                    _stock = _existencia.Resultset[0].cantidad;
                }

                return _stock;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }


        private void TraerDetalleReq(string _codEmp, int _requerimiento_id, int _nivel_aut, int _deposito, int _sector)
        {
            try
            {
                BLL.Procedures.TRAEREQUERIMIENTOITEM_PENDIENTE_DE_ENVIO _detalle = new BLL.Procedures.TRAEREQUERIMIENTOITEM_PENDIENTE_DE_ENVIO();
                this.dataGridViewDetalle.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.TRAEREQUERIMIENTOITEM_PENDIENTE_DE_ENVIO item in _detalle.ItemList(_codEmp, _requerimiento_id, _nivel_aut))
                {
                    indice = dataGridViewDetalle.Rows.Add();
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.CODEMP].Value = _codEmp;//COd EMP
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.REQUERIMIENTO_ID].Value = _requerimiento_id;//REQUERIMIENTO_ID
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.CODIGO].Value = item.articulo_id;//CODIGO PRODUCTO
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.NROITEM].Value = item.nroitem; //NRO ITEM
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.DESCRIPCION].Value = item.art_descgen; //DESCRIPCION PRODUCTO
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.UNIDAD].Value = item.unimed;//UNIDAD DE MEDIDA
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.CANT_PEDIDA].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD PEDIDA
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.CANT_ADEUDADA].Value = item.cantidadadeudada.ToString().Replace(",", ".");//CANTIDAD ADEUDADA
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.CANT_A_ENVIAR].Value = item.cantidadadeudada.ToString().Replace(",", ".");//CANTIDAD A ENVIAR REPITO LA CANTIDAD ADEUDADA PARA EVITAR QUE SE VUELVA A DIGITAR LA CANT.

                    //TRAIGO EL STOCK DE ESTE ARTICULO....
                    _existenciaArticulo = 0;
                    _existenciaArticulo = ExistenciaArticulo(comboBoxDepositoDelPedido.SelectedValue.ToString(), item.articulo_id);
                    //bool _tieneVto = LlevaVtoArt(cod);

                    this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.EXISTENCIA].Value = _existenciaArticulo.ToString().Replace(",", ".");
                    this.dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.EXISTENCIA].Style.ForeColor = (_existenciaArticulo <= 0) ? Color.Red : Color.Black;

                }
                //SALVO ESTOS VALORES, LOS USO PARA GUARDAR
                 _codEmpresa = _codEmp;
                _nroRequerimientoInterno = _requerimiento_id;
                 _depositoEnvioMercaderia = _deposito;
                 _sectorDepositoEnvioMercaderia = _sector;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46) // Si no es numerico y si no es espacio EL 46 ES EL PUNTO
            {
                // Invalidar la accion
                e.Handled = true;
                // Enviar el sonido de beep de windows
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void CargarDepositosDestino()
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
                this.comboBoxDepositoDelPedido.SuspendLayout();
                this.comboBoxDepositoDelPedido.DataSource = null;
                this.comboBoxDepositoDelPedido.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione un Depósito del Pedido>";
                _itemSeleccion.DEPOSITO_ID = 0;
                _dep.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxDepositoDelPedido.DisplayMember = BLL.Tables.STKDEPOSITO.ColumnNames.DESCRIPCION;
                this.comboBoxDepositoDelPedido.ValueMember = BLL.Tables.STKDEPOSITO.ColumnNames.DEPOSITO_ID;
                this.comboBoxDepositoDelPedido.DataSource = _dep.Result.ToArray();  //_dep.Result.Where(x => x.DEPOSITO_ID != 3 && x.DEPOSITO_ID != 5).ToArray(); //FILTRO LOS DEPOSITO DE PUERTO MADERO Y DE MEXICO.. NO LOS TRAIGO.. PEDIDO POR MARIANO

                this.comboBoxDepositoDelPedido.ResumeLayout();
                this.comboBoxDepositoDelPedido.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void CargarSectoresDestino(int _dep)
        {
            try
            {
                BLL.Tables.STKSECTOR _sec = new BLL.Tables.STKSECTOR();
                _sec.OrderByParameter.Add(DAL.Tables.STKSECTOR.ColumnEnum.descripcion);
                _sec.ItemList(_dep);

                Entities.Tables.STKSECTOR _itemSeleccion = new Entities.Tables.STKSECTOR();

                //Limpia el combo
                this.comboBoxSectorDelPedido.SuspendLayout();
                this.comboBoxSectorDelPedido.DataSource = null;
                this.comboBoxSectorDelPedido.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione un Sector del Pedido";
                _itemSeleccion.SECTOR_ID = 0;
                _sec.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSectorDelPedido.DisplayMember = BLL.Tables.STKSECTOR.ColumnNames.DESCRIPCION;
                this.comboBoxSectorDelPedido.ValueMember = BLL.Tables.STKSECTOR.ColumnNames.SECTOR_ID;
                this.comboBoxSectorDelPedido.DataSource = _sec.Result.ToArray();

                this.comboBoxSectorDelPedido.ResumeLayout();

                this.comboBoxSectorDelPedido.SelectedIndex = 0;


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
                if (this.comboBoxDepositoDelPedido.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxDepositoDelPedido, "Debe seleccionar un Depósito");
                    this.comboBoxDepositoDelPedido.Focus();
                    return false;
                }

          

                if (this.comboBoxSectorDelPedido.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxSectorDelPedido, "Debe seleccionar un Sector");
                    this.comboBoxSectorDelPedido.Focus();
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

        private void ImprimirRemito()
        {
            try
            {
                if (_nroRemitoGenerado > 0)
                {

                    StaCatalina.Forms.Reports _Reporte = new StaCatalina.Forms.Reports();
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
        #endregion

        #region Eventos
        private void Frm_EgresoDepositoPorRequerimientoInterno_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //this.dateTimeFecha.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            this.Text = "Salida de Mercadería Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
            CargarDepositosDestino();

            
        }


        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewReqCabe_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewReqCabe.IsCurrentCellDirty)
                dataGridViewReqCabe.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewDetalle_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewDetalle.IsCurrentCellDirty)
                dataGridViewDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewReqCabe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //_indexRow = e.RowIndex; //GUARDO LA FILA SELECCIONADA
                    TraerDetalleReq(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.REQUERIMIENTO_ID].Value.ToString()), 2, Convert.ToInt32(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.DEPOSITO_ORIGEN].Value.ToString()), Convert.ToInt32(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.SECTOR_DEPOSITO_ORIGEN].Value.ToString()));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewDetalle.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_Detalle.CANT_A_ENVIAR)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }
        }

        private void dataGridViewDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

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


                    for (int i = 0; i < this.dataGridViewDetalle.Rows.Count ; i++)
                    {
                        _itemInventario = new Entities.Tables.STKINVENTARIO();
                        _itemInventario.ARTICULO_ID = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CODIGO].Value.ToString().Trim().ToUpper();//COD ARTICULO
                        _itemInventario.CANTIDAD = Convert.ToDecimal(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CANT_A_ENVIAR].Value.ToString(), culture); //cantidad
                        _itemInventario.DEPOSITO_ID = Convert.ToInt32(this.comboBoxDepositoDelPedido.SelectedValue);//DEPOSITO DE DONDE SALE LA MERCADERIA QUE ES EL MISMO AL CUAL SE LE HIZO EL PEDIDO *********************////
                        _itemInventario.SECTOR_ID = 1; //  *** NO SE USA ... NO SE LLEVA EL STOCK POR SECTOR Convert.ToInt32(this.comboBoxSectorSalida.SelectedValue); //SECTOR DE DONDE SALE LA MERCADERIA
                        _itemInventario.UNIMED = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.UNIDAD].Value.ToString();//UNIDAD MEDIDA
                        //VOY AGREGANDO A LA COLECCION
                        _itemsInv.Add(_itemInventario);

                        //AHORA CARGO EL OBJETO STKMOVIMIENTOITEM
                        _itemMov = new Entities.Tables.STKMOVIMIENTOITEM();
                        _itemMov.ARTICULO_ID = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CODIGO].Value.ToString();//COD ARTICULO
                        _itemMov.CANTIDAD = Convert.ToDecimal(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CANT_A_ENVIAR].Value.ToString(), culture); //cantidad
                        _itemMov.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(); //CODEMP
                        _itemMov.UNIMED = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.UNIDAD].Value.ToString();//UNIDAD MEDIDA
                        _itemMov.NROITEM = Convert.ToInt32(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.NROITEM].Value);// NRO ITEM DEL REQUERIMIENTO INTERNO, LO NECESITO PARA LA TABLA STKMOVIREQINTERNO

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
                    _itemMovimiento.FECHAMOV = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    _itemMovimiento.DEPOSITOORIGEN_ID = Convert.ToInt32(this.comboBoxDepositoDelPedido.SelectedValue);//DEPOSITO DE DONDE SALE LA MERCADERIA  QUE ES LA MISMA DEL PEDIDO
                    _itemMovimiento.SECTORORIGEN_ID = 1; //  OJO NO SE LLEVA EL STOCK POR SECTOR Convert.ToInt32(this.comboBoxSectorSalida.SelectedValue); //SECTOR DE DONDE SALE LA MERCADERIA

                    _itemMovimiento.DEPOSITODESTINO_ID = _depositoEnvioMercaderia; //DEPOSITO AL CUAL VA LA MERCADERIA
                    _itemMovimiento.SECTORDESTINO_ID =_sectorDepositoEnvioMercaderia; // SECTOR DEL DEPOSITO DONDE VA LA MERCADERIA

                    _nroRemitoGenerado = _stk.SalidaMercaderiaPorRequerimientoInterno(_itemsInv, _itemMovimiento, _itemsMov, _codEmpresa,_nroRequerimientoInterno);
                    if (_nroRemitoGenerado > 0)
                    {
                        MessageBox.Show("El egreso se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ImprimirRemito();

                        dataGridViewDetalle.Rows.Clear();
                        this.comboBoxDepositoDelPedido.SelectedIndex = 0;
                        this.comboBoxSectorDelPedido.SelectedIndex = 0;
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

        private void comboBoxSectorDelPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSectorDelPedido.SelectedIndex > 0)
                    TraerRequerimientos(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(), Convert.ToInt32(comboBoxDepositoDelPedido.SelectedValue), Convert.ToInt32(comboBoxSectorDelPedido.SelectedValue));
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxDepositoDelPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CARGO LOS SECTORES DE ESTE DEPOSITO
            CargarSectoresDestino(Convert.ToInt32(this.comboBoxDepositoDelPedido.SelectedValue));
        }

        private void dataGridViewDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int iColumn = dataGridViewDetalle.CurrentCell.ColumnIndex;
           
            if (iColumn == (int)Col_Detalle.CANT_A_ENVIAR)
            {
                if (Convert.ToDecimal(dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_Detalle.CANT_A_ENVIAR].Value.ToString(), culture) > Convert.ToDecimal(dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_Detalle.CANT_ADEUDADA].Value.ToString(), culture))
                {
                    MessageBox.Show("No puede enviar una cantidad mayor a la adeudada. Genere un nuevo requerimiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_Detalle.CANT_A_ENVIAR].Value = dataGridViewDetalle.Rows[e.RowIndex].Cells[(int)Col_Detalle.CANT_ADEUDADA].Value;
                }
               
            }
        }
    }
}
