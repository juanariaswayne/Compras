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
    public partial class Frm_ModicaOC_SinStock : StaCatalina.Plantilla
    {
        #region variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        CultureInfo culture = new CultureInfo("en-US");

        private enum Col_OCDetalle
        {
            DETALLE = 0,
            CANTIDAD,
            PRECIO

        }

        Int32 _OrdenCompraModifica = 0;
        private DataGridViewCell _celWasEndEdit;
        #endregion

        #region Funciones
        public Frm_ModicaOC_SinStock()
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

                if (this.comboBoxLugarEntrega.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxLugarEntrega, "Debe seleccionar una dirección de entrega");
                    this.comboBoxLugarEntrega.Focus();
                    return false;
                }

                //if(textBoxDetalle.Text == string.Empty)
                //{
                //    this.errorProvider1.SetError(this.textBoxDetalle, "Debe ingresar un Detalle");
                //    this.textBoxDetalle.Focus();
                //    return false;
                //}
                if (textBoxImporte.Text == string.Empty)
                {
                    this.errorProvider1.SetError(this.textBoxImporte, "Debe ingresar un Importe");
                    this.textBoxImporte.Focus();
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

        private void CalculaImporte()
        {
            try
            {
                //CALUCLO PRECIO x CANTIDAD
                textBoxImporte.Text = ("0").ToString(culture);
                decimal _importeTotal = 0;
                for (int i = 0; i < this.dataGridViewDetalleOC.Rows.Count; i++)
                {

                    //VERIFICO QUE PRECIO Y CANTIDAD SEAN VALORES VALIDOS
                    if (dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.PRECIO].Value != null && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.CANTIDAD].Value != null && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.PRECIO].Value != string.Empty && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.CANTIDAD].Value != string.Empty)
                    {
                        decimal _precio = Convert.ToDecimal(dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.PRECIO].Value.ToString(), culture);
                        decimal _cantidad = Convert.ToDecimal(dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.CANTIDAD].Value.ToString(), culture);

                        _importeTotal = Convert.ToDecimal(_importeTotal + (_precio * _cantidad), culture);

                    }


                }
                textBoxImporte.Text = "$ " + _importeTotal.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46

            int iColumn = dataGridViewDetalleOC.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_OCDetalle.CANTIDAD || iColumn == (int)Col_OCDetalle.PRECIO)
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46) // Si no es numerico y si no es espacio EL 46 ES EL PUNTO
                {
                    // Invalidar la accion
                    e.Handled = true;
                    // Enviar el sonido de beep de windows
                    System.Media.SystemSounds.Beep.Play();
                }

            }
        }
        #endregion
        private void textBoxNroOC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (comboBoxcodEmp.SelectedIndex > 0)
                {
                    StaCatalinaEntities _Mod = new StaCatalinaEntities();
                    dataGridViewDetalleOC.Rows.Clear();

                    var _ocDetalle = (from L in _Mod.ordenCompraSinStock_ParaModificar(comboBoxcodEmp.SelectedValue.ToString(), Convert.ToInt32(textBoxNroOC.Text))
                                      select L).ToList();

                    int indice = 0;
                    Int16 _tipoProrrateo = 1;

                    foreach (var item in _ocDetalle)
                    {
                        if(item.usuarioAutoriza != string.Empty)
                        {
                            if (item.usuarioAutoriza.Trim() != Clases.Usuario.UsuarioLogeado.usuario_Logeado.Trim())
                            {
                                MessageBox.Show("Ud. no puede modificar esta orden de Compra porque la misma está autorizada. Solo puede modificarla el usuario: " + item.usuarioAutoriza, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                        indice = dataGridViewDetalleOC.Rows.Add();
                        comboBoxProveed.SelectedValue = item.proveed_id;
                        comboBoxLugarEntrega.SelectedValue = item.sectorEntrega_id;
                      
                        dataGridViewDetalleOC.Rows[indice].Cells[(int)Col_OCDetalle.DETALLE].Value = item.detalle;
                        dataGridViewDetalleOC.Rows[indice].Cells[(int)Col_OCDetalle.CANTIDAD].Value = item.cantidad.ToString().Replace(",", ".");
                        dataGridViewDetalleOC.Rows[indice].Cells[(int)Col_OCDetalle.PRECIO].Value = item.importe.ToString().Replace(",", ".");
                        _tipoProrrateo = Convert.ToInt16(item.tipoProrrateo);
                        textBoxObs.Text = item.Obs;

                        indice++;
                    }
                    //tipo prorrateo
                    if(_tipoProrrateo == 1)
                    {
                        checkBoxCuotas.Checked = false;
                        checkBoxEmpresa.Checked = false;
                    }
                    if (_tipoProrrateo == 2)
                    {
                        checkBoxEmpresa.Checked = true;
                        checkBoxCuotas.Checked = false;
                    }

                    if (_tipoProrrateo == 3)
                    {
                        checkBoxEmpresa.Checked = false;
                        checkBoxCuotas.Checked = true;
                    }
                    if (_tipoProrrateo == 4)
                    {
                        checkBoxEmpresa.Checked = true;
                        checkBoxCuotas.Checked = true;
                    }

                    if (_ocDetalle != null)
                    {
                        CalculaImporte();
                        _OrdenCompraModifica = Convert.ToInt32(textBoxNroOC.Text);
                    }
                    else

                    {
                        _OrdenCompraModifica = 0;
                        MessageBox.Show("No existe este Número de orden de compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                else
                {

                    MessageBox.Show("Debe seleccionar una Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Frm_ModicaOC_SinStock_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //FIN PERMISOS
            Clases.Empresa.CargarEmpresas(comboBoxcodEmp);

            CargarLugaresEntrega(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);

            CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());


            comboBoxcodEmp.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;

            textBoxNroOC.Focus();
          
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (VerificaIngreso())
            {
                Entities.Tables.COMORDENCOMPRA _OCCabecera = new Entities.Tables.COMORDENCOMPRA();
                BLL.Tables.COMORDENCOMPRA _OCCab = new BLL.Tables.COMORDENCOMPRA();
                //Entities.Tables.COMORDENCOMPRADETALLE _OCDetalle = new Entities.Tables.COMORDENCOMPRADETALLE();
                List<Entities.Tables.COMORDENCOMPRADETALLE> _listDetalle = new List<Entities.Tables.COMORDENCOMPRADETALLE>();

                CultureInfo culture = new CultureInfo("en-US");
                _OCCabecera.ORDENCOMPRA_ID = _OrdenCompraModifica;
                _OCCabecera.FECHA = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //FECHA
                _OCCabecera.PROVEED_ID = this.comboBoxProveed.SelectedValue.ToString(); // PROVEEDOR
                _OCCabecera.ESTADO_ID = 1; //Ojo ver que valor se envia despues  //ESTADO
                _OCCabecera.TIPOOC_ID = 4; //ORDEN DE COMPRA DE SERVICIO, SIN STOCK
                _OCCabecera.MODIFICACOSTO = 0; //MODIFICA COSTO
                _OCCabecera.CODEMP = this.comboBoxcodEmp.SelectedValue.ToString(); //EMPRESA PARA LA CUAL SE HACE LA OC
                _OCCabecera.CONDICIONPAGO_ID = ""; // CONDICIOND DE PAGO NO ENVIO NADA
                //ya la dejo autorizada
                //_OCCabecera.FECHAAUTORIZACION = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //FECHA
                //_OCCabecera.USUARIOAUTORIZA = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                _OCCabecera.OBS = this.textBoxObs.Text.Trim();

                _OCCabecera.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                _OCCabecera.PEDIDODIARIO = false;
                //PRORRATEO EMPRESA- CUOTAS
                if (!checkBoxCuotas.Checked && !checkBoxEmpresa.Checked)
                {
                    _OCCabecera.TIPOPRORRATEO = 1; //SIN PRORRATEO
                }
                if (checkBoxEmpresa.Checked && !checkBoxCuotas.Checked)
                {
                    _OCCabecera.TIPOPRORRATEO = 2; //SOLO EMPRESA
                }
                if (checkBoxCuotas.Checked && !checkBoxEmpresa.Checked)
                {
                    _OCCabecera.TIPOPRORRATEO = 3; //SOLO CUOTAS
                }

                if (checkBoxCuotas.Checked && checkBoxEmpresa.Checked)
                {
                    _OCCabecera.TIPOPRORRATEO = 4; //AMBOS
                }

                //FIN PRORRATEO
                if (this.comboBoxLugarEntrega.SelectedIndex > 0)
                {
                    _OCCabecera.SECTORENTREGA_ID = Convert.ToInt32(this.comboBoxLugarEntrega.SelectedValue);//SECTOR DE ENTREGA
                }

                bool _hayItems = false;
                //AHORA LOS OBJETOS DE LA TABLA COMORDENCOMPRADETALLE
                for (int i = 0; i < this.dataGridViewDetalleOC.Rows.Count - 1; i++)
                {
                    if (dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.CANTIDAD].Value != string.Empty && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.CANTIDAD].Value != null && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.PRECIO].Value != string.Empty && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.PRECIO].Value != null && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.DETALLE].Value != null && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.DETALLE].Value != string.Empty)
                    {
                        Entities.Tables.COMORDENCOMPRADETALLE _OCDetalle = new Entities.Tables.COMORDENCOMPRADETALLE();
                        _OCDetalle.CODEMP = this.comboBoxcodEmp.SelectedValue.ToString(); //EMPRESA PARA LA CUAL SE HACE LA OC
                        _OCDetalle.ORDENCOMPRA_ID = _OrdenCompraModifica;
                        _OCDetalle.DETALLE = dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.DETALLE].Value.ToString(); //this.textBoxDetalle.Text.Trim();
                        _OCDetalle.NIVELAUTO_ID = 1; //LA AUTORIZA SERGIO !!!!
                        _OCDetalle.IMPORTE = Convert.ToDouble(dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.PRECIO].Value.ToString(), culture);//Convert.ToDouble(this.textBoxImporte.Text.ToString(), culture);
                        _OCDetalle.CANTIDAD = Convert.ToDecimal(dataGridViewDetalleOC.Rows[i].Cells[(int)Col_OCDetalle.CANTIDAD].Value.ToString(), culture);
                        _OCDetalle.NROITEM = i + 1;

                        _listDetalle.Add(_OCDetalle);

                        _hayItems = true;
                    }
                }

                if (_hayItems)
                {

                    if (_OCCab.ModificaOCSinStock(_OCCabecera, _listDetalle))
                    {
                        MessageBox.Show("La orden de compra se modificó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.textBoxObs.Text = "";

                        this.textBoxImporte.Text = string.Empty;
                        this.comboBoxProveed.SelectedIndex = 0;
                        this.comboBoxLugarEntrega.SelectedIndex = 0;
                        dataGridViewDetalleOC.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la Orden de Compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {

                    MessageBox.Show("No se puede modificar la orden de compra porque no tiene detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridViewDetalleOC_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _celWasEndEdit = dataGridViewDetalleOC[e.ColumnIndex, e.RowIndex];
            if (e.RowIndex >= 0)
            {
                //SIEMPRE Y CUANDO SE INGRESE VALORES EN PRECIO Y CANTIDAD
                if (e.ColumnIndex == Convert.ToInt32(Col_OCDetalle.CANTIDAD) || e.ColumnIndex == Convert.ToInt32(Col_OCDetalle.PRECIO))
                {
                    CalculaImporte();
                }
            }
        }

        private void dataGridViewDetalleOC_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewDetalleOC.IsCurrentCellDirty)
                dataGridViewDetalleOC.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewDetalleOC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridViewDetalleOC_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewDetalleOC.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_OCDetalle.CANTIDAD || iColumn == (int)Col_OCDetalle.PRECIO)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }
        }
    }
}
