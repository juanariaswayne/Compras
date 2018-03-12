using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_IncidenciasProveedor : Plantilla
    {
        #region Variables
            private enum Col_FacturaSinOP
            {
                codigoEmpresa = 0, //COD EMPRESA
                sucursalEmpresa, //SUC EMPRESA
                ID, //ID MOV
                Tipo, //TIPO COMPROB
                Letra, //LETRA
                Sucursal, //SUCURSAL
                Comprobante, //COMPROBANTE
                Importe,
                Saldo,
                Fecha,
                FechaVto,
                TipoReclamo,
                Reclamar,
                UltimaFechaReclamo,
                NroReclamo,
                AdeudaNC,
                Obs
            }
            private enum Col_Historia
            {
                _ccoemp_codigo=0,
                _ccosuc_cod,
                _cco_id,
                _ccotco_cod,
                _cco_letra, 
                _cco_codpvt, 
                _cco_nro, 
                _cco_impmonloc, 
                _cco_femision, 
                _cco_fvto, 
                _fechaop, 
                _fecharetiro 

            }
            private bool lectura;
            private bool escritura;
            private bool elimina;
           // private int id_usuario;
        #endregion

        #region Funciones
        public Frm_IncidenciasProveedor()
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

        private void CargarProveedores()
        {
            try
            {
                BLL.Procedures._H_PROVEEDORES _prov = new BLL.Procedures._H_PROVEEDORES();
                _prov.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim());
               
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



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void TraerFacturasSinOp(string _codEmp, string _proveed)
        {
            try
            {
                this.dataGridViewPendientes.Rows.Clear();
                DataGridViewComboBoxColumn comboboxColumnReclamo = dataGridViewPendientes.Columns[(int)Col_FacturaSinOP.TipoReclamo] as DataGridViewComboBoxColumn;

                BLL.Tables.TIPORECLAMOPROVEEDOR _tip = new BLL.Tables.TIPORECLAMOPROVEEDOR();
                _tip.ItemList();
                Entities.Tables.TIPORECLAMOPROVEEDOR _itemSeleccion2 = new Entities.Tables.TIPORECLAMOPROVEEDOR();

                //Limpia el combo
                //this.comboBoxProveed.SuspendLayout();
                comboboxColumnReclamo.DataSource = null;
                comboboxColumnReclamo.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion2.DESCRIPCION = "<Seleccione un Tipo>";
                _itemSeleccion2.TIPORECLAMO = 0;
                _tip.Result.Insert(0, _itemSeleccion2);

                //Carga el combo
                comboboxColumnReclamo.DataSource = _tip.Result.ToArray();
                comboboxColumnReclamo.DisplayMember = BLL.Tables.TIPORECLAMOPROVEEDOR.ColumnNames.DESCRIPCION;
                comboboxColumnReclamo.ValueMember = BLL.Tables.TIPORECLAMOPROVEEDOR.ColumnNames.TIPORECLAMO;
                
                //FIN CARGO COMBO TIPO RECLAMO

                //AHORA CARGO LA GRILLA CON LAS FACTURAS
                dataGridViewPendientes.AutoGenerateColumns = false;

                BLL.Procedures.TRAECOMPROBANTESPENDIENTESPROVEEDOR _factDisp = new BLL.Procedures.TRAECOMPROBANTESPENDIENTESPROVEEDOR();
                //this.bindingSourceFacSinOP.DataSource = _factDisp.ItemList(_codEmp, _proveed);

               
                int indice;
                foreach (Entities.Procedures.TRAECOMPROBANTESPENDIENTESPROVEEDOR item in _factDisp.ItemList(_codEmp, _proveed))
                {
                    indice = dataGridViewPendientes.Rows.Add();
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.codigoEmpresa].Value = item.ccoemp_codigo;//cod empresa
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.sucursalEmpresa].Value = item.ccosuc_cod; //suc empresa
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.ID].Value = item.cco_id; //id mov
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.Tipo].Value = item.ccotco_cod;//tipo comprobante
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.Letra].Value = item.cco_letra;//letra
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.Sucursal].Value = item.cco_codpvt;//suucural compro
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.Comprobante].Value = item.cco_nro;// comprobante
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.Importe].Value = item.cco_impmonloc; //importe
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.Saldo].Value = item.cco_saldomonloc; //saldo
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.Fecha].Value = Convert.ToDateTime(item.cco_femision).ToShortDateString();//fecha
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.FechaVto].Value = Convert.ToDateTime(item.cco_fvto).ToShortDateString();//vto
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.UltimaFechaReclamo].Value = (Convert.ToDateTime(item.fechaultimoreclamo.ToString()) > Convert.ToDateTime("01/01/1900") && Convert.ToDateTime(item.fechaultimoreclamo.ToString()) < Convert.ToDateTime(DateTime.MaxValue.ToString())) ? Convert.ToDateTime(item.fechaultimoreclamo).ToShortDateString() : "";//ultima fecha
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.NroReclamo].Value = item.estado_id;
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.TipoReclamo].Value = item.tiporeclamo;//tipo reclamo
                    dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.AdeudaNC].Value = item.adeudanc;//adeuda nc
                    //COLOR AMARILLO AQUELLAS FACTURAS QUE TENGAN OBS
                    if (item.tieneObs > 0)
                        dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.Obs].Style.BackColor = System.Drawing.Color.Yellow;    

                    if (item.estado_id == 6)
                    {
                        dataGridViewPendientes.Rows[indice].Cells[(int)Col_FacturaSinOP.Reclamar].ReadOnly = true;
                    }

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TraeFacturasConOPSinRetirar(string _codEmp, string _proveed)
        {
            try
            {
                this.dataGridViewPreparados.Rows.Clear();
                this.dataGridViewPreparados.AutoGenerateColumns = false;
                BLL.Procedures.FACTURASCONOPSINRETIRAR _facOP = new BLL.Procedures.FACTURASCONOPSINRETIRAR();
                //this.bindingSourceFactConOP.DataSource = _facOP.ItemList(_codEmp, _proveed);
                int indice;
                foreach (Entities.Procedures.FACTURASCONOPSINRETIRAR item in _facOP.ItemList(_codEmp, _proveed))
                {
                    indice = dataGridViewPreparados.Rows.Add();
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._ccoemp_codigo].Value = item.ccoemp_codigo;//cod empresa
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._ccosuc_cod].Value = item.ccosuc_cod;//suc empresa
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._cco_id].Value = item.cco_id;// id
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._ccotco_cod].Value = item.ccotco_cod;
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._cco_letra].Value = item.cco_letra;//punto de venta
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._cco_codpvt].Value = item.cco_codpvt;//punto de venta
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._cco_nro].Value = item.cco_nro;
                    //dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._cco_codpro].Value = item.cco_codpro;
                    //dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._ccopro_razsoc].Value = item.ccopro_razsoc;
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._cco_impmonloc].Value = item.cco_impmonloc;
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._cco_femision].Value = Convert.ToDateTime(item.cco_femision).ToShortDateString();
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._cco_fvto].Value = Convert.ToDateTime(item.cco_fvto).ToShortDateString();
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._fechaop].Value = Convert.ToDateTime(item.fechaop).ToShortDateString() ;
                    dataGridViewPreparados.Rows[indice].Cells[(int)Col_Historia._fecharetiro].Value = (Convert.ToDateTime(item.fecharetiro.ToString()) > Convert.ToDateTime("01/01/1900") && Convert.ToDateTime(item.fecharetiro.ToString()) < Convert.ToDateTime(DateTime.MaxValue.ToString())) ? Convert.ToDateTime(item.fecharetiro).ToShortDateString() : "";//fecharetiro;
                     
             

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion

        #region Eventos
            private void FrmIncidenciasProveedor_Load(object sender, EventArgs e)
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();

                CargarProveedores();
            }


            private void comboBoxProveed_SelectedIndexChanged(object sender, EventArgs e)
            {
                //TRAE LAS FACTURAS PENDIENTES DE PAGO
                if (this.comboBoxProveed.SelectedIndex != 0)
                {
                    TraerFacturasSinOp(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim(), this.comboBoxProveed.SelectedValue.ToString());
                    this.dataGridViewPendientes.ClearSelection();

                    TraeFacturasConOPSinRetirar(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim(), this.comboBoxProveed.SelectedValue.ToString());
                    this.dataGridViewPreparados.ClearSelection();
                   
                }
            }



            private void dataGridViewPendientes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewPendientes.IsCurrentCellDirty)
                    dataGridViewPendientes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            private void toolStripButtonSave_Click(object sender, EventArgs e)
            {
                try
                {
                    //VERIFICO QUE FILA TIENE EL ESTADO Y EL TIPO <> 0
                    Entities.Tables.PROVSEGUIMIENTO _newItem = new Entities.Tables.PROVSEGUIMIENTO();
                    BLL.Tables.PROVSEGUIMIENTO _seg = new BLL.Tables.PROVSEGUIMIENTO();
                    BLL.Tables.PROVSEGUIMIENTO _existe = new BLL.Tables.PROVSEGUIMIENTO();
                    bool _almenos = false;
                    int nroReclamo = 0;
                    for (int i = 0; i < this.dataGridViewPendientes.RowCount; i++)
                    {
                        _newItem = new Entities.Tables.PROVSEGUIMIENTO();

                        DataGridViewCheckBoxCell cellSelecion = dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.Reclamar] as DataGridViewCheckBoxCell;
                        DataGridViewComboBoxCell comboboxColumnTipo = dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.TipoReclamo] as DataGridViewComboBoxCell;
                        //SOLO TOMO AQUELLOS DONDE SE SELECCIONO EL TIPO DE RECLAMO Y SE HAYA TILDADO EN RECLAMAR
                        if (comboboxColumnTipo.Value.ToString() != "0" && Convert.ToBoolean(cellSelecion.Value))
                        {
                            _almenos = true;
                            _newItem.CCOEMP_CODIGO = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.TrimEnd(); //CODIGO EMPRESA
                            _newItem.CCOSUC_COD = ""; //CODIGO SUCURSAL EMPRESA
                            _newItem.CCO_ID = Convert.ToInt32(dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.ID].Value.ToString());//ID REGISTRO
                            _newItem.CCOTCO_COD = dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.Tipo].Value.ToString();//TIPO DE COMPROBANTE
                            _newItem.CCO_LETRA = dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.Letra].Value.ToString();//LETRA COMPROBANTE
                            _newItem.CCO_CODPVT = dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.Sucursal].Value.ToString();//SUC COMPROBANTE
                            _newItem.CCO_NRO = dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.Comprobante].Value.ToString();//NRO DE FACTURA
                            _newItem.CCO_FEMISION = Convert.ToDateTime(dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.Fecha].Value.ToString());//FECHA DE FACTURA
                            _newItem.CCO_FVTO = Convert.ToDateTime(dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.FechaVto].Value.ToString());//FECHA DE VTO
                            _newItem.CCO_IMPMONLOC = Convert.ToDouble(dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.Importe].Value.ToString());//IMPORTE FACTURA
                            _newItem.CCO_SALDOMONLOC = Convert.ToDouble(dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.Saldo].Value.ToString());//SALDO FACTURA
                            _newItem.CCO_CODPRO = this.comboBoxProveed.SelectedValue.ToString(); //COD PROVEEDOR
                            _newItem.CCOPRO_RAZSOC = this.comboBoxProveed.Text.ToString().Trim();//NOMBRE PROVEEDOR
                            _newItem.TIPORECLAMO = Convert.ToInt32(comboboxColumnTipo.Value.ToString());//TIPO DE RECLAMO
                            _newItem.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();
                            _newItem.ADEUDANC = Convert.ToBoolean(dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.AdeudaNC].Value.ToString());//adeuda nc
                            _newItem.FECHAULTIMORECLAMO = Convert.ToDateTime(DateTime.Now.ToShortDateString().ToString()); //FECHA DE VTO
                           
                            _existe.WhereParameter.Clear();
                            if (_existe.ItemList(_newItem.CCOEMP_CODIGO,_newItem.CCOSUC_COD,_newItem.CCO_ID).Count > 0)
                            {
                                //TIENE AL MENOS UN RECLAMO
                                
                                nroReclamo = Convert.ToInt16(dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.NroReclamo].Value.ToString());
                                if (nroReclamo == 6)
                                {
                                    MessageBox.Show("Esta factura ya tiene 6 Reclamos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                
                                _newItem.ESTADO_ID = nroReclamo + 1; //AL RECLAMO QUE TENÍA LE SUMO UNO
                                 //if (dataGridViewPendientes.Rows[i].Cells[(int)Col_FacturaSinOP.Reclamo2].Value.ToString() == DateTime.MinValue.ToString())
                                                             
                                _seg.Update(_newItem);
                                //MessageBox.Show("El reclamo se generó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                //ES EL PRIMER RECLAMO
                                _newItem.ESTADO_ID = 1; //es el primer reclamo
                                _seg.Add(_newItem);
                               
                            }

                        }

                    }

                    if (!_almenos)
                    {
                        MessageBox.Show("No ha seleccionado ninguna factura para hacer el Reclamo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("El reclamo se generó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //recargo de nuevo la grilla actualizando los datos
                    TraerFacturasSinOp(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim(), this.comboBoxProveed.SelectedValue.ToString());
                    this.dataGridViewPendientes.ClearSelection();
                    TraeFacturasConOPSinRetirar(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim(), this.comboBoxProveed.SelectedValue.ToString());
                    this.dataGridViewPreparados.ClearSelection();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        #endregion

            private void dataGridViewPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    Frm_HistorialReclamo _historial = new Frm_HistorialReclamo();
                    _historial.HistorialReclamo.CCOEMP_CODIGO = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim(); //CODIGO EMPRESA
                    _historial.HistorialReclamo.CCOSUC_COD  = ""; //CODIGO SUCURSAL EMPRESA
                    _historial.HistorialReclamo.CCO_ID  = Convert.ToInt32(dataGridViewPendientes.Rows[e.RowIndex].Cells[(int)Col_FacturaSinOP.ID].Value.ToString());//ID REGISTRO

                    //_historial.MdiParent = this.MdiParent;
                    _historial.ShowDialog();
                   
                }

                if (e.ColumnIndex == (int)Col_FacturaSinOP.Reclamar)
                {
                    //verifico la cantidad de reclamos.. 
                    int nroReclamo = 0;
                    nroReclamo = Convert.ToInt16(dataGridViewPendientes.Rows[e.RowIndex].Cells[(int)Col_FacturaSinOP.NroReclamo].Value.ToString());
                    if (nroReclamo == 6)
                    {
                        MessageBox.Show("Esta factura ya tiene 6 Reclamos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

            }

            private void buttonSinFactura_Click(object sender, EventArgs e)
            {
                if (this.comboBoxProveed.SelectedIndex != 0)
                {
                   try
                   {
                        Frm_ReclamoSinFactura _reclamo = new Frm_ReclamoSinFactura();
                       // _reclamo.HistorialReclamo.CCOEMP_CODIGO = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim(); //CODIGO EMPRESA
                       // _reclamo.HistorialReclamo.CCOSUC_COD = ""; //CODIGO SUCURSAL EMPRESA
                        _reclamo.ReclamoFact.CCO_CODPRO = this.comboBoxProveed.SelectedValue.ToString();
                        _reclamo.ReclamoFact.CCOPRO_RAZSOC = this.comboBoxProveed.Text.ToString();
                    
                        //_reclamo.MdiParent = this.MdiParent;
                        _reclamo.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
