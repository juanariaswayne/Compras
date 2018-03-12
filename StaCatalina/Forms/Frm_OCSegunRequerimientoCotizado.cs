using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
namespace StaCatalina.Forms
{
    public partial class Frm_OCSegunRequerimientoCotizado : StaCatalina.Plantilla
    {
        #region varibles
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;

            private enum Col_Proveedores
            {
                NROCOTIZACION=0,
                EMPRESA,
                PROVEEDOR_ID,
                RAZONSOCIAL
            }

            private enum Col_items
            {
                INCLUIR,
                ARTICULO_ID,
                DESCRIPCION,
                MARCA,
                EMBALAJE,
                UNIMED,
                CANTIDAD,
                PRECIO,
       
            }
        CultureInfo culture = new CultureInfo("en-US");
        #endregion

        #region Funciones
        public Frm_OCSegunRequerimientoCotizado()
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

            private void TraeArticulos(string codEmp,string proveed, int _nroCotizacion)
            {

                try
                {
                    BLL.Procedures.TRAEARTICULOSCOTIZADOSPARAORDENDECOMPRA _items = new BLL.Procedures.TRAEARTICULOSCOTIZADOSPARAORDENDECOMPRA();
                
                    this.dataGridViewDetalleReqCotizados.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.TRAEARTICULOSCOTIZADOSPARAORDENDECOMPRA item in _items.ItemList(codEmp, proveed, _nroCotizacion))
                    {
                        indice = dataGridViewDetalleReqCotizados.Rows.Add();
                        dataGridViewDetalleReqCotizados.Rows[indice].Cells[(int)Col_items.ARTICULO_ID].Value = item.articulo_id; //ARTICULO
                        dataGridViewDetalleReqCotizados.Rows[indice].Cells[(int)Col_items.DESCRIPCION].Value = item.descripcion;
                        dataGridViewDetalleReqCotizados.Rows[indice].Cells[(int)Col_items.MARCA].Value = item.marca;
                        dataGridViewDetalleReqCotizados.Rows[indice].Cells[(int)Col_items.EMBALAJE].Value = item.embalaje;
                        dataGridViewDetalleReqCotizados.Rows[indice].Cells[(int)Col_items.UNIMED].Value = item.unimed;
                        dataGridViewDetalleReqCotizados.Rows[indice].Cells[(int)Col_items.CANTIDAD].Value = item.cantidad.ToString().Replace(",",".");
                        dataGridViewDetalleReqCotizados.Rows[indice].Cells[(int)Col_items.PRECIO].Value = item.precio.ToString().Replace(",","."); 
                    
                    }


            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            private void TraeProveedoresCotizados(string _codEmp)
            {
                try
                {
                    BLL.Procedures.TRAEPROVEEDORESCOTIZADOS _prov = new BLL.Procedures.TRAEPROVEEDORESCOTIZADOS();
                    this.dataGridViewProveedorCotizado.DataSource = _prov.ItemList(_codEmp);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }


        #endregion

     
        #region Eventos

            private void Frm_OCSegunRequerimientoCotizado_Load(object sender, EventArgs e)
            {
                //PERMISOS
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();

                Clases.Empresa.CargarEmpresas(comboBoxEmpresa);
                //FIN PERMISOS
                this.comboBoxEmpresa.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();
                string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();

                TraeProveedoresCotizados(_empresa);

                this.dateTimePickerFechaEntrega.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }

            private void toolStripButtonSave_Click(object sender, EventArgs e)
            {
                try
                {
               

                Entities.Tables.COMORDENCOMPRA _OCCabecera = new Entities.Tables.COMORDENCOMPRA();
                BLL.Tables.COMORDENCOMPRA _OCCab = new BLL.Tables.COMORDENCOMPRA();
                Entities.Tables.COMORDENCOMPRAITEM _OCItem = new Entities.Tables.COMORDENCOMPRAITEM();
                List<Entities.Tables.COMORDENCOMPRAITEM> _ItemsCab = new List<Entities.Tables.COMORDENCOMPRAITEM>();

                Boolean _selecciono = false;

                if (this.dataGridViewDetalleReqCotizados.Rows.Count > 0)
                {

                    //cabecera
                    _OCCabecera.FECHA = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //FECHA
                    _OCCabecera.PROVEED_ID = dataGridViewProveedorCotizado.Rows[dataGridViewProveedorCotizado.CurrentRow.Index].Cells[(int)Col_Proveedores.PROVEEDOR_ID].Value.ToString(); // PROVEEDOR
                    _OCCabecera.ESTADO_ID = 1; //Ojo ver que valor se envia despues  //ESTADO
                    _OCCabecera.TIPOOC_ID = 3; //OJO COLOCAR EL VALOR REAL DE ORDEN DE COMPRA SEGUN REQUERIMIENTO
                    _OCCabecera.MODIFICACOSTO = 0; //MODIFICA COSTO
                    string _codEmp  = this.comboBoxEmpresa.SelectedValue.ToString();
                    _OCCabecera.CODEMP = _codEmp;
                    _OCCabecera.CONDICIONPAGO_ID = "0"; // CONDICIOND DE PAGO
                    _OCCabecera.OBS = this.textBoxObs.Text.Trim(); //OBS
                    _OCCabecera.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                    int _nroCotizacion = Convert.ToInt32(dataGridViewProveedorCotizado.Rows[dataGridViewProveedorCotizado.CurrentRow.Index].Cells[(int)Col_Proveedores.NROCOTIZACION].Value.ToString());

                    for (int i = 0; i < this.dataGridViewDetalleReqCotizados.Rows.Count; i++)
                    {
                        _OCItem = new Entities.Tables.COMORDENCOMPRAITEM();

                        //RECUPERO LOS ITEMS DE ESTA COTIZACION
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewDetalleReqCotizados.Rows[i].Cells[(int)Col_items.INCLUIR] as DataGridViewCheckBoxCell;

                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            //VOY GUARDANSDO LOS ITEMS DE LA ORDEN DE COMPRA
                            _selecciono = true;

                            _OCItem.ARTICULO_ID = dataGridViewDetalleReqCotizados.Rows[i].Cells[(int)Col_items.ARTICULO_ID].Value.ToString();
                            _OCItem.UNIMED = dataGridViewDetalleReqCotizados.Rows[i].Cells[(int)Col_items.UNIMED].Value.ToString();
                            _OCItem.PRECIO = Convert.ToDecimal(dataGridViewDetalleReqCotizados.Rows[i].Cells[(int)Col_items.PRECIO].Value.ToString(), culture);
                            _OCItem.CANTIDAD = Convert.ToDecimal(dataGridViewDetalleReqCotizados.Rows[i].Cells[(int)Col_items.CANTIDAD].Value.ToString(), culture);
                            _OCItem.FECHAENTREGA = Convert.ToDateTime(this.dateTimePickerFechaEntrega.Value.ToShortDateString());
                            _OCItem.NIVELAUT_ID = 1; //ojo ver como se envia despues
                            _OCItem.CODEMPREQUERIMIENTO = _codEmp;
                          

                            //VOY AGREGANDO A LA COLECCION
                            _ItemsCab.Add(_OCItem);
                        }


                    }

                    if (!_selecciono)
                    {
                        MessageBox.Show("Para generar una Orden de Compra, debe seleccionar al menos un artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //LLAMO A LA FUNCION QUE GUARDA CABECERA E ITEMS
                    int _NroOC;
                    _NroOC = _OCCab.GeneraOrdenDeCompraSegunCotizacion(_OCCabecera, _ItemsCab, _nroCotizacion);
                    if (_NroOC > 0)
                    {
                        MessageBox.Show("Se generó la orden de compra Nro:" + " " + _NroOC, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewDetalleReqCotizados.Rows.Clear();
                        this.dateTimePickerFechaEntrega.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
                        TraeProveedoresCotizados(_empresa);
                    }
                    else
                    {
                        MessageBox.Show("Error al grabar Orden de Compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           

            private void dataGridViewProveedorCotizado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewProveedorCotizado.IsCurrentCellDirty)
                    dataGridViewProveedorCotizado.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            private void dataGridViewDetalleReqCotizados_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewDetalleReqCotizados.IsCurrentCellDirty)
                    dataGridViewDetalleReqCotizados.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            private void dataGridViewProveedorCotizado_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    if (this.dataGridViewProveedorCotizado.Rows.Count > 0)
                    {
                        string _codEmp = dataGridViewProveedorCotizado.Rows[e.RowIndex].Cells[(int)Col_Proveedores.EMPRESA].Value.ToString();
                        string _codProveed = dataGridViewProveedorCotizado.Rows[e.RowIndex].Cells[(int)Col_Proveedores.PROVEEDOR_ID].Value.ToString();
                        int _nroCotizacion = Convert.ToInt32(dataGridViewProveedorCotizado.Rows[e.RowIndex].Cells[(int)Col_Proveedores.NROCOTIZACION].Value.ToString());
                        TraeArticulos(_codEmp, _codProveed, _nroCotizacion);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        #endregion

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

                TraeProveedoresCotizados(_empresa);
                this.dataGridViewDetalleReqCotizados.Rows.Clear();
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
