using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using System.Configuration;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
namespace StaCatalina.Forms
{
    public partial class Frm_comPedidoCotizacionProveedDirecto : StaCatalina.Plantilla
    {
        #region Variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;
            CultureInfo culture = new CultureInfo("en-US");
        
            private string _articuloSeleccionado = string.Empty;
            private List<Entities.Procedures.TRAEREQUERIMIENTOSPARAGENERARCOTIZACION> _itemsReq = new List<Entities.Procedures.TRAEREQUERIMIENTOSPARAGENERARCOTIZACION>();

            private enum Col_GridDetalle
            {
                ARTICULO = 0,
                DESCRIPCION,
                UNIDAD,
                CANTIDAD,
                COTIZACIONES,
                ELIMINAR

            }
        #endregion

        #region Funciones
            public Frm_comPedidoCotizacionProveedDirecto()
            {
                InitializeComponent();
            }


            //PERMISOS
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
            //FIN PERMISOS

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

            private void CargarSubRubros()
            {
                try
                {
                    BLL.Procedures.TRAESUBRUBROSDELUSUARIO _rubroItem = new BLL.Procedures.TRAESUBRUBROSDELUSUARIO();
                    Entities.Procedures.TRAESUBRUBROSDELUSUARIO _itemSeleccion = new Entities.Procedures.TRAESUBRUBROSDELUSUARIO();
                    _rubroItem.Items(Clases.Usuario.UsuarioLogeado.id_usuario_Logeado);
                    //Limpia el combo
                    this.comboBoxSubRubro.SuspendLayout();
                    this.comboBoxSubRubro.DataSource = null;
                    this.comboBoxSubRubro.Items.Clear();


                    // Carga el item de Seleccion
                    _itemSeleccion.da2_desc = "<Seleccione un Sub Rubro>";
                    _itemSeleccion.artda2_cod = "0";
                    _rubroItem.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxSubRubro.DisplayMember = BLL.Procedures.TRAESUBRUBROSDELUSUARIO.ColumnNames.DA2_DESC;
                    this.comboBoxSubRubro.ValueMember = BLL.Procedures.TRAESUBRUBROSDELUSUARIO.ColumnNames.ARTDA2_COD;
                    this.comboBoxSubRubro.DataSource = _rubroItem.Result.ToArray();
                    this.comboBoxSubRubro.SelectedIndex = 0;

                    this.comboBoxSubRubro.ResumeLayout();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            private void TraerRequerimientosDisponibles()
            {
                try
                {
                    //STORED CORREGIDO DISTINGUE EMPRESA
                    BLL.Procedures.TRAEREQUERIMIENTOSPARAGENERARCOTIZACION _Req = new BLL.Procedures.TRAEREQUERIMIENTOSPARAGENERARCOTIZACION();
                    //traigo todos los requerimientos autorizados, no importa la empresa, solo lo que NO estan finalizados, de este Sub rubro
                    string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
                    this._itemsReq.Clear();
                    this._itemsReq = _Req.ItemList((this.comboBoxSubRubro.SelectedValue.ToString()), _empresa); 

                    //MUESTRO EL LA GRILLA LOS REQUERIMIENTOS AGRUPADOS POR EMPRESA Y CÓDIGO DE PRODUCTO Y SUMO LAS CANTIDADES
                    var groupsForIterate = _itemsReq.GroupBy(x =>
                        new {x.articulo_id, x.art_descgen, x.unimed });

                    int indice;
                    this.dataGridRequerimientosParaCotizar.Rows.Clear();
                    foreach (var categ in groupsForIterate)
                    {
                        indice = dataGridRequerimientosParaCotizar.Rows.Add();
                        dataGridRequerimientosParaCotizar.Rows[indice].Cells[(int)Col_GridDetalle.ARTICULO].Value = categ.Key.articulo_id;
                        dataGridRequerimientosParaCotizar.Rows[indice].Cells[(int)Col_GridDetalle.DESCRIPCION].Value = categ.Key.art_descgen;
                        dataGridRequerimientosParaCotizar.Rows[indice].Cells[(int)Col_GridDetalle.UNIDAD].Value = categ.Key.unimed;
                        //ES LA FORMA DE SUMAR LAS CANTIDADES DE UN MISMO PRODUCTO
                        dataGridRequerimientosParaCotizar.Rows[indice].Cells[(int)Col_GridDetalle.CANTIDAD].Value = categ.Sum(x => x.cantidad).ToString().Replace(",",".");
                    }

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
                if (this.comboBoxProveed.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxProveed, "Debe seleccionar un Proveedor");
                    this.comboBoxProveed.Focus();
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

        private void GenerarPDFProveedor(string codEmp, int _nroCotizacion)
        {
            try
            {
                //string SPath  = this.saveFileDialog1.FileName = "Cotizacion_Nro_" + this.saveFileDialog1.FileName; // Default file name
                this.saveFileDialog1.DefaultExt = ".PDF"; // Default file extension
                this.saveFileDialog1.Filter = "Text documents (.pdf)|*.pdf"; // Filter files by extension

                if (this.saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    string SPath = this.saveFileDialog1.FileName; // = "Cotizacion_Nro_" + _nroCotizacion; // Default file name

                    ReportDocument objReport = new ReportDocument();
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "PedidoCotizacion.rpt";

                    objReport.Load(reportPath);


                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;

                    // PARAMETROS DE CONEXION
                    CrystalDecisions.Shared.TableLogOnInfo logoninfo = new CrystalDecisions.Shared.TableLogOnInfo();
                    logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogSTACATALINA"];
                    logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source"];
                    logoninfo.ConnectionInfo.UserID = ConfigurationManager.AppSettings["User ID"];
                    logoninfo.ConnectionInfo.Password = ConfigurationManager.AppSettings["Password"];

                    logoninfo.ConnectionInfo.IntegratedSecurity = false; //cambiado a false por la linea de arriba
                    Tables tables = objReport.Database.Tables;
                    foreach (Table table in tables)
                    {
                        table.ApplyLogOnInfo(logoninfo);
                    }

                    //PRIMER PARAMTRO

                    objReport.SetParameterValue(0, codEmp.Trim());
                    objReport.SetParameterValue(1, _nroCotizacion);

                    //GUARDO EN FORMATO PDF
                    objReport.ExportToDisk(ExportFormatType.PortableDocFormat, SPath.ToString());
                    MessageBox.Show("Se generó el pedido de Cotización Nro: " + _nroCotizacion, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void Frm_comPedidoCotizacionProveedDirecto_Load(object sender, EventArgs e)
            {
                //PERMISOS
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
            //FIN PERMISOS
            Clases.Empresa.CargarEmpresas(comboBoxEmpresa);
                CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString()); //OJO VER SI ESTO ESTÁ BIEN!!!!!!!!!!
                CargarSubRubros();

                this.comboBoxEmpresa.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() ;
        }


        #endregion

            private void comboBoxSubRubro_SelectedIndexChanged(object sender, EventArgs e)
            {
                try
                {
                    if (this.comboBoxSubRubro.SelectedIndex > 0)
                    {
                        TraerRequerimientosDisponibles();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //calculo el proximo Nro de Cotizacion
                BLL.Procedures.MAXNROCOTIZACION _proxNro = new BLL.Procedures.MAXNROCOTIZACION();
                _proxNro.ItemList();
                Int32 _nroCotizacion = (_proxNro.Resultset[0].nrocotizacion + 1);
                
                if (this.dataGridRequerimientosParaCotizar.Rows.Count > 0 && VerificaIngreso())
                {

                    for (int i = 0; i < this.dataGridRequerimientosParaCotizar.Rows.Count; i++)
                    {
                        //STORED CORREGIDO.. DISTINGUE EMPRESA
                        BLL.Procedures.INGRESAPEDIDOCOTIZACIONARTICULOEMPRESA _cotizaArt = new BLL.Procedures.INGRESAPEDIDOCOTIZACIONARTICULOEMPRESA();
                        string _codEmp = this.comboBoxEmpresa.SelectedValue.ToString();
                        string _articulo_id = dataGridRequerimientosParaCotizar.Rows[i].Cells[(int)Col_GridDetalle.ARTICULO].Value.ToString();
                        string _uniMed = dataGridRequerimientosParaCotizar.Rows[i].Cells[(int)Col_GridDetalle.UNIDAD].Value.ToString();
                        decimal _cantidad = Convert.ToDecimal(dataGridRequerimientosParaCotizar.Rows[i].Cells[(int)Col_GridDetalle.CANTIDAD].Value.ToString(), culture);
                        decimal _precio =0; //NO LO NECESITO
                        string _Proveed = this.comboBoxProveed.SelectedValue.ToString();
                        DateTime _fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        string _usuario = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                        string _obs = (this.textBoxObs.Text == string.Empty) ? "" : this.textBoxObs.Text.Trim();
                        string _descripArticulo = dataGridRequerimientosParaCotizar.Rows[i].Cells[(int)Col_GridDetalle.DESCRIPCION].Value.ToString();

                        //VERIFICO SI ESTE ARTICULO QUE ESTA PIDIENDO TIENE PENDIENTE DE ENTREGA-....
                        BLL.Procedures.PEDIENTEENTREGAARTICULO _pendiente = new BLL.Procedures.PEDIENTEENTREGAARTICULO();
                        _pendiente.Items(_codEmp, _articulo_id);
                        if (_pendiente.Resultset[0].diferencia > 0)
                        {
                            DialogResult _result = MessageBox.Show("El artículo: " + _descripArticulo + " tiene pendiente de entrega, desea pedir cotización de todos modos?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (_result == DialogResult.OK)
                            {
                                _cotizaArt.ItemList(_codEmp, _nroCotizacion, _articulo_id, _uniMed, _cantidad, _precio, _Proveed, _fecha, _usuario, _obs);
                            }
                        } //FIN VERIFICA PENDIENTE DE ENTREGA
                        else
                        {
                            _cotizaArt.ItemList(_codEmp, _nroCotizacion, _articulo_id, _uniMed, _cantidad, _precio, _Proveed, _fecha, _usuario, _obs);
                        }

                    }
                    string _codEmpresa = this.comboBoxEmpresa.SelectedValue.ToString();
                    GenerarPDFProveedor(_codEmpresa, _nroCotizacion);

                    
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridRequerimientosParaCotizar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == (int)Col_GridDetalle.ELIMINAR && e.RowIndex >= 0 )
                {
                    dataGridRequerimientosParaCotizar.Rows.RemoveAt(e.RowIndex);
                }


                if (e.ColumnIndex == (int)Col_GridDetalle.COTIZACIONES && e.RowIndex >= 0)
                {

                    //antes de MOSTRAR EL FORMULARIO, VERIFICO SI TIENE ALGUNA COTIZACION
                    string _codEmp = this.comboBoxEmpresa.SelectedValue.ToString();
                    BLL.Procedures.REQUERIMIENTOS_COTIZADOS_PROVEEDOR _reqCotizados = new BLL.Procedures.REQUERIMIENTOS_COTIZADOS_PROVEEDOR();
                    if(_reqCotizados.ItemList(dataGridRequerimientosParaCotizar.Rows[e.RowIndex].Cells[(int)Col_GridDetalle.ARTICULO].Value.ToString(), _codEmp).Count > 0)
                    {
                        Frm_CotizacionesPedidas _verCotiz = new Frm_CotizacionesPedidas();
                        _verCotiz.Articulo_cotizado = dataGridRequerimientosParaCotizar.Rows[e.RowIndex].Cells[(int)Col_GridDetalle.ARTICULO].Value.ToString();
                        _verCotiz.DescripArt_cotizado = dataGridRequerimientosParaCotizar.Rows[e.RowIndex].Cells[(int)Col_GridDetalle.DESCRIPCION].Value.ToString();
                        _verCotiz.CodEmp = _codEmp;
                        _verCotiz.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Este Artículo no tiene pedido de cotización", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

        
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void comboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
            int _index = this.comboBoxEmpresa.SelectedIndex;
            if (Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != _empresa.Trim() && Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != "AMBA")
            {
                MessageBox.Show("Ud. no está autorizado a operar con esta empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBoxEmpresa.SelectedIndex = (_index == 0) ? 1 : 0;
                return;
            }
            else
            {
                CargarProveedor(_empresa);
                this.comboBoxSubRubro.SelectedIndex = 0;
                this.dataGridRequerimientosParaCotizar.Rows.Clear();
                this.textBoxObs.Text = string.Empty;
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
