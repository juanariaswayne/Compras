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
    public partial class Frm_comOrdenCompraDirectaSinStock : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        protected string _condPagoProveed = null;
        CultureInfo culture = new CultureInfo("en-US");
        private enum Col_Detalle
        {
            DETALLE = 0,
            CANTIDAD,
            PRECIO
            
        }

        //VARIABLE PARA PASAR CON ENTER A OTRA COLUMNA
        private DataGridViewCell _celWasEndEdit;
        bool blnAjustarCeldas = true;
        StaCatalinaEntities _Mod = new StaCatalinaEntities();
        #endregion

        #region Funciones
        public Frm_comOrdenCompraDirectaSinStock()
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

                if (this.comboBoxCtaContable.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxCtaContable, "Debe seleccionar una condición de pago");
                    this.comboBoxCtaContable.Focus();
                    return false;
                }

                if (textBoxCondPago.Text == string.Empty)
                {
                    this.errorProvider1.SetError(this.textBoxCondPago, "Debe ingresar una Condicioón de pago");
                    this.textBoxCondPago.Focus();
                    return false;
                }
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

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46

            int iColumn = dataGridViewDetalleOC.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_Detalle.CANTIDAD || iColumn == (int)Col_Detalle.PRECIO)
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
                    if (dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value != null && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != null && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value != string.Empty && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != string.Empty)
                    {
                        decimal _precio = Convert.ToDecimal(dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value.ToString(), culture);
                        decimal _cantidad = Convert.ToDecimal(dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value.ToString(), culture);

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

        private void CargarCtaContables()
        {
            try
            {

                var _listObj = (from cta in _Mod.CtaContable() select cta).ToList();

                CtaContable_Result _itemSeleccion = new CtaContable_Result();

                //Limpia el combo
                this.comboBoxCtaContable.SuspendLayout();
                this.comboBoxCtaContable.DataSource = null;
                this.comboBoxCtaContable.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.cta_descrip = "<Seleccione una Cuenta Contable>";
                _itemSeleccion.cta_nrocta = 0;
                _listObj.Insert(0, _itemSeleccion);
                //Carga el combo
                this.comboBoxCtaContable.DisplayMember = "cta_descrip";
                this.comboBoxCtaContable.ValueMember = "cta_nrocta";
                this.comboBoxCtaContable.DataSource = _listObj;
                this.comboBoxCtaContable.ResumeLayout();

                comboBoxCtaContable.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos
        private void Frm_comOrdenCompraDirectaSinStock_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            Clases.Empresa.CargarEmpresas(comboBoxcodEmp);

            CargarLugaresEntrega(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);
            
            CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
          
            //cargo proveedores

            dataGridViewDetalleOC.RowTemplate.Height = 40;

            CargarCtaContables();

        }



        #endregion

        private void comboBoxcodEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxcodEmp.SelectedIndex > 0)
            {
                //SOLO CAMBIO DE EMPRESA SI ESTA AUTORIZADA
                string _emp = this.comboBoxcodEmp.SelectedValue.ToString();
                int _index = this.comboBoxcodEmp.SelectedIndex;
                if (Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != _emp.Trim() && Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != "AMBA")
                {
                    MessageBox.Show("Ud. no está autorizado a operar con esta empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.comboBoxcodEmp.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                    return;
                }
                else
                {

                    CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
                    CargarLugaresEntrega(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());


                }
            }
        }

        private void textBoxImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46) // Si no es numerico y si no es espacio EL 46 ES EL PUNTO
            //{
            //    // Invalidar la accion
            //    e.Handled = true;
            //    // Enviar el sonido de beep de windows
            //    System.Media.SystemSounds.Beep.Play();
            //}
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

                _OCCabecera.FECHA = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //FECHA
                _OCCabecera.PROVEED_ID = this.comboBoxProveed.SelectedValue.ToString(); // PROVEEDOR
                _OCCabecera.ESTADO_ID = 1; //Ojo ver que valor se envia despues  //ESTADO
                _OCCabecera.TIPOOC_ID = 4; //ORDEN DE COMPRA DE SERVICIO, SIN STOCK
                _OCCabecera.MODIFICACOSTO = 0; //MODIFICA COSTO
                _OCCabecera.CODEMP = this.comboBoxcodEmp.SelectedValue.ToString(); //EMPRESA PARA LA CUAL SE HACE LA OC
                _OCCabecera.CONDICIONPAGO_ID = _condPagoProveed; // CONDICIOND DE PAGO
                //ya la dejo autorizada
                //_OCCabecera.FECHAAUTORIZACION = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //FECHA
                //_OCCabecera.USUARIOAUTORIZA = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                _OCCabecera.OBS = this.textBoxObs.Text.Trim();

                _OCCabecera.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                _OCCabecera.PEDIDODIARIO = false;
                if (this.comboBoxLugarEntrega.SelectedIndex > 0)
                {
                    _OCCabecera.SECTORENTREGA_ID = Convert.ToInt32(this.comboBoxLugarEntrega.SelectedValue);//SECTOR DE ENTREGA
                }
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

                //AHORA LOS OBJETOS DE LA TABLA COMORDENCOMPRADETALLE
                for (int i = 0; i < this.dataGridViewDetalleOC.Rows.Count -1; i++)
                {
                    if (dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != string.Empty && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != null && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value != string.Empty && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value != null && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.DETALLE].Value != null && dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.DETALLE].Value != string.Empty)
                    {
                        Entities.Tables.COMORDENCOMPRADETALLE _OCDetalle = new Entities.Tables.COMORDENCOMPRADETALLE();
                        _OCDetalle.CODEMP = this.comboBoxcodEmp.SelectedValue.ToString(); //EMPRESA PARA LA CUAL SE HACE LA OC
                        _OCDetalle.DETALLE = dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.DETALLE].Value.ToString(); //this.textBoxDetalle.Text.Trim();
                        _OCDetalle.NIVELAUTO_ID = 1; //LA AUTORIZA SERGIO !!!!
                        _OCDetalle.IMPORTE = Convert.ToDouble(dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.PRECIO].Value.ToString(), culture);//Convert.ToDouble(this.textBoxImporte.Text.ToString(), culture);
                        _OCDetalle.CANTIDAD = Convert.ToDecimal(dataGridViewDetalleOC.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value.ToString(), culture);
                        _OCDetalle.NROITEM = i + 1;

                        _listDetalle.Add(_OCDetalle);
                    }
                }

                int _NroOC;
                _NroOC = _OCCab.AddItem(_OCCabecera, _listDetalle);
                if (_NroOC > 0)
                {
                    MessageBox.Show("Se generó la orden de compra Nro:" + " " + _NroOC, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    this.textBoxObs.Text = "";
                    this.textBoxDetalle.Text = string.Empty;
                    this.textBoxImporte.Text = string.Empty;
                    this.comboBoxProveed.SelectedIndex = 0;
                    this.comboBoxLugarEntrega.SelectedIndex = 0;
                    dataGridViewDetalleOC.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Error al grabar Orden de Compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxProveed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBoxProveed.SelectedIndex > 0 )
                {
                    if (comboBoxcodEmp.SelectedIndex > 0)
                    {
                        //recupera condicion de pago
                        BLL.Procedures.H_CONDPAGOPROVEED _condPago = new BLL.Procedures.H_CONDPAGOPROVEED();
                        string _codEmp;

                        _codEmp = this.comboBoxcodEmp.SelectedValue.ToString();

                        _condPago.ItemList(_codEmp, this.comboBoxProveed.SelectedValue.ToString());
                        if (_condPago.Resultset.Count > 0)
                        {
                            _condPagoProveed = _condPago.Resultset[0].condpago.ToString();
                            textBoxCondPago.Text = _condPagoProveed.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error al recuperar Condición de pago del proveedor, verifique si ha seleccionado una empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Primero debe seleccionar una Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            this.textBoxObs.Text = "";
            this.textBoxDetalle.Text = string.Empty;
            this.textBoxImporte.Text = string.Empty;
            this.comboBoxProveed.SelectedIndex = 0;
            this.comboBoxLugarEntrega.SelectedIndex = 0;
            
        }

        private void dataGridViewDetalleOC_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewDetalleOC.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_Detalle.CANTIDAD || iColumn == (int)Col_Detalle.PRECIO )
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }
        }

        private void dataGridViewDetalleOC_SelectionChanged(object sender, EventArgs e)
        {
            //PASO CON ENTER A LA OTRA COLUMNA
            if (MouseButtons != 0) return;

            if (_celWasEndEdit != null && dataGridViewDetalleOC.CurrentCell != null)
            {
                // if we are currently in the next line of last edit cell
                if (dataGridViewDetalleOC.CurrentCell.RowIndex == _celWasEndEdit.RowIndex + 1 &&
                    dataGridViewDetalleOC.CurrentCell.ColumnIndex == _celWasEndEdit.ColumnIndex)
                {
                    int iColNew;
                    int iRowNew = 0;
                    if (_celWasEndEdit.ColumnIndex >= dataGridViewDetalleOC.ColumnCount - 1)
                    {
                        iColNew = 0;
                        iRowNew = dataGridViewDetalleOC.CurrentCell.RowIndex;
                    }
                    else
                    {
                        iColNew = _celWasEndEdit.ColumnIndex + 1;
                        iRowNew = _celWasEndEdit.RowIndex;
                    }
                    dataGridViewDetalleOC.CurrentCell = dataGridViewDetalleOC[iColNew, iRowNew];
                }
            }
            _celWasEndEdit = null;
        }

        private void dataGridViewDetalleOC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // ES NECESARIO PARA QUE NO DE ERROR
        }

        private void dataGridViewDetalleOC_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _celWasEndEdit = dataGridViewDetalleOC[e.ColumnIndex, e.RowIndex];
            if (e.RowIndex >= 0)
            {
                //SIEMPRE Y CUANDO SE INGRESE VALORES EN PRECIO Y CANTIDAD
                if (e.ColumnIndex == Convert.ToInt32(Col_Detalle.CANTIDAD) || e.ColumnIndex == Convert.ToInt32(Col_Detalle.PRECIO))
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

        private void dataGridViewDetalleOC_Paint(object sender, PaintEventArgs e)
        {
            if (blnAjustarCeldas)

            {

                blnAjustarCeldas = false;

                this.dataGridViewDetalleOC.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);

            }
        }

        private void dataGridViewDetalleOC_Scroll(object sender, ScrollEventArgs e)
        {
            this.dataGridViewDetalleOC.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
        }

        private void dataGridViewDetalleOC_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CalculaImporte();
        }
    }
}
