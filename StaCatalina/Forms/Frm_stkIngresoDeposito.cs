using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_stkIngresoDeposito : Plantilla
    {
        #region Variables
        private enum Col_Remito
        {
            CODEMP = 0,
            REMITO,
            FECHA,
            SUCURSAL,
            COMPROBANTE,
            LETRA,
            CODEMPSTK,
            COMPROBANTESTK
        }

        private enum Col_Detalle

        {           
            COMPROBANTE = 0,
            NROITEM,
            COD,
            ARTICULO,
            UNIMED,
            CANT_PEDIDA,
            CANTENVIADA,
            CANTRECIBIDA
        }
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        public int _Comprobante;
           
        #endregion

        #region Funciones
        public Frm_stkIngresoDeposito()
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

        private void TraeRemitos(DateTime _FechaDesde, DateTime _FechaHasta, int _Sector, int _Deposito)
        {
            try
            {
                BLL.Procedures.TRAEREMITOSPENDIENTES _detalle = new  BLL.Procedures.TRAEREMITOSPENDIENTES();

                this.dataGridViewRemitos.Rows.Clear();            

                int indice;
                foreach (Entities.Procedures.TRAEREMITOSPENDIENTES item in _detalle.ItemList(_FechaDesde, _FechaHasta, _Sector, _Deposito))
                {
                    indice = dataGridViewRemitos.Rows.Add();
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.REMITO].Value = item.letra + item.sucursal +"-"+ item.comprobante;
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.FECHA].Value = item.fecha.ToShortDateString();
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.COMPROBANTE].Value = item.comprobante;
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.LETRA].Value = item.letra;
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.SUCURSAL].Value = item.sucursal;
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.CODEMPSTK].Value = item.codempstk;
                    dataGridViewRemitos.Rows[indice].Cells[(int)Col_Remito.COMPROBANTESTK].Value = item.comprobantestk;
                }             

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

        private void TraeDetalleRemito(string _CodEmp, int _Comprobante)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.TRAEDETALLEREMITOSPENDIENTES _detalle = new BLL.Procedures.TRAEDETALLEREMITOSPENDIENTES();

                this.dataGridViewDetalle.Rows.Clear();

                int indice;
                foreach (Entities.Procedures.TRAEDETALLEREMITOSPENDIENTES item in _detalle.ItemList(_CodEmp,_Comprobante))
                {
                    indice = dataGridViewDetalle.Rows.Add();
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.COD].Value = item.articulo_id;//CODIGO DE EMPRESA
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.ARTICULO].Value = item.art_descgen;
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.UNIMED].Value = item.unimed;
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.CANTENVIADA].Value = item.cantoriginal.ToString().Replace(",",".");
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.CANTRECIBIDA].Value =item.cantrecibida.ToString().Replace(",", ".");
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.CANT_PEDIDA].Value = item.cantpedida.ToString().Replace(",", ".");
                    dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.NROITEM].Value = item.nroitem;
                    if(item.cantpedida > item.cantoriginal)
                    {
                        dataGridViewDetalle.Rows[indice].Cells[(int)Col_Detalle.CANTENVIADA].Style.ForeColor = Color.Red;
                    }
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EnviaMailDiferencias()
        {
            try
            {
                BLL.Procedures.ENVIAMAILARTICULOSCONDIFERENCIASSTK _Diferencias = new BLL.Procedures.ENVIAMAILARTICULOSCONDIFERENCIASSTK();
                _Diferencias.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada,_Comprobante);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Guardar()
        {
            try
            {
                //OBJETOS STKINVENTARIO
                //Entities.Tables.STKINVENTARIO _itemInventario = new Entities.Tables.STKINVENTARIO();
                //List<Entities.Tables.STKINVENTARIO> _itemsInv = new List<Entities.Tables.STKINVENTARIO>();

                //OBJETOS STKMOVIMIENTOSITEM
                Entities.Tables.STKMOVIMIENTOITEM _itemMov = new Entities.Tables.STKMOVIMIENTOITEM();
                List<Entities.Tables.STKMOVIMIENTOITEM> _itemsMov = new List<Entities.Tables.STKMOVIMIENTOITEM>();

                //VARIABLES STKMOVIMIENTOS
                Entities.Tables.STKMOVIMIENTO _itemMovimiento = new Entities.Tables.STKMOVIMIENTO();
                BLL.Tables.STKMOVIMIENTO _stk = new BLL.Tables.STKMOVIMIENTO();

                //VARIABLES STKENTRANSITO   
                Entities.Tables.STKENTRANSITO _itemTransito = new Entities.Tables.STKENTRANSITO();
                List<Entities.Tables.STKENTRANSITO> _itemsTransito = new List<Entities.Tables.STKENTRANSITO>();

                CultureInfo culture = new CultureInfo("en-US");

                bool _Diferencias;
                _Diferencias = false;
                for (int i = 0; i < this.dataGridViewDetalle.Rows.Count; i++)
                {
                    //_itemInventario = new Entities.Tables.STKINVENTARIO();
                    //_itemInventario.ARTICULO_ID = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.COD].Value.ToString().Trim().ToUpper();//COD ARTICULO
                    //_itemInventario.CANTIDAD = Convert.ToDecimal(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CANTRECIBIDA].Value.ToString(), culture); //cantidad
                    //_itemInventario.DEPOSITO_ID = Convert.ToInt32(this.comboBoxDeposito.SelectedValue);//DEPOSITO DE DONDE SALE LA MERCADERIA
                    //_itemInventario.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(); //CODEMP
                    //_itemInventario.SECTOR_ID = Convert.ToInt32(this.comboBoxSector.SelectedValue); //SECTOR DE DONDE SALE LA MERCADERIA
                    //_itemInventario.UNIMED = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.UNIMED].Value.ToString();//UNIDAD MEDIDA
                    //                                                                                                     //VOY AGREGANDO A LA COLECCION
                    //_itemsInv.Add(_itemInventario);

                    //AHORA CARGO EL OBJETO STKMOVIMIENTOITEM
                    _itemMov = new Entities.Tables.STKMOVIMIENTOITEM();
                    _itemMov.ARTICULO_ID = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.COD].Value.ToString();//COD ARTICULO
                    _itemMov.CANTIDAD = Convert.ToDecimal(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CANTRECIBIDA].Value,culture); //cantidad
                    _itemMov.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(); //CODEMP
                    _itemMov.UNIMED = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.UNIMED].Value.ToString();//UNIDAD MEDIDA
                    

                    //VOY AGREGANDO A LA COLECCION
                    _itemsMov.Add(_itemMov);

                    //AHORA CARGO EL OBJETO STKENTRANSITO
                    _itemTransito = new Entities.Tables.STKENTRANSITO();
                    _itemTransito.COMPROBANTE = _Comprobante;
                    _itemTransito.CANTORIGINAL = Convert.ToDecimal(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CANTENVIADA].Value,culture); //cantidad
                    _itemTransito.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(); //CODEMP
                    _itemTransito.CANTRECIBIDA = Convert.ToDecimal(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CANTRECIBIDA].Value,culture); //cantidad
                    _itemTransito.NROITEM = Convert.ToInt32(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.NROITEM].Value.ToString());  //EMPRESA DEL DEPOSITO DESTINO
                    _itemTransito.USUARIORECIBE = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                    _itemTransito.UNIMED = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.UNIMED].Value.ToString();
                    _itemTransito.FECHARECEPCION = DateTime.Now;
                    _itemTransito.ESTADO_ID = 0;

                    if(_itemTransito.CANTORIGINAL != _itemTransito.CANTRECIBIDA)
                    {
                        _Diferencias = true;
                    }

                    //VOY AGREGANDO A LA COLECCION
                    _itemsTransito.Add(_itemTransito);

                }

                //CARGO LOS OBJETOS DE STKMOVIMIENTOS
                _itemMovimiento.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(); //CODEMP
                _itemMovimiento.ANULADO = 0;
                _itemMovimiento.TIPOMOV_ID = 1; //OJO VER ESTO SI SE PUEDE CAMBIAR...... EL 1 ES ENTRADA ************************************
                _itemMovimiento.SUBTIPOMOV_ID = 2; //ojo ver SI SE PUEDE CAMBIAR...... EL 2 es CAMBIO DE DEPÓSITOP **************************
                _itemMovimiento.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();
                _itemMovimiento.OBS = "";               
                _itemMovimiento.FECHAMOV = DateTime.Now;
                _itemMovimiento.DEPOSITOORIGEN_ID = Convert.ToInt32(this.comboBoxDeposito.SelectedValue); //ES EL DEPOSITO DONDE INGRESA LA MERCADERIA
                _itemMovimiento.SECTORORIGEN_ID = Convert.ToInt32(this.comboBoxSector.SelectedValue); // SECTOR DONDE INGRESA LA MERCADERIA
                _itemMovimiento.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();
                
                if (_stk.RecepcionArticulos(_itemsTransito, _itemMovimiento, _itemsMov))
                {
                    if(_Diferencias)
                    { EnviaMailDiferencias(); }                    
                    MessageBox.Show("El ingreso se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewDetalle.Rows.Clear();                    
                }
                else
                {
                    MessageBox.Show("Hubo un error al realizar el proceso por favor contacte al administrador del sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
        #endregion

        #region Eventos
        private void Frm_stkIngresoDeposito_Load(object sender, EventArgs e)
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
                CargarSectoresDeposito( Convert.ToInt32(this.comboBoxDeposito.SelectedValue));
          
        }

        private void dataGridViewDetalle_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewDetalle.IsCurrentCellDirty)
                dataGridViewDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewRemitos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewRemitos.IsCurrentCellDirty)
                dataGridViewRemitos.CommitEdit(DataGridViewDataErrorContexts.Commit);
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

        private void checkBoxRecibido_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDetalle.Rows.Count > 0)
                {

                    if (this.checkBoxRecibido.Checked)
                    {
                        foreach (DataGridViewRow item in dataGridViewDetalle.Rows)
                        {
                            item.Cells[(int)Col_Detalle.CANTRECIBIDA].Value = item.Cells[(int)Col_Detalle.CANTENVIADA].Value;
                        }
                    }

                    else
                    {

                        foreach (DataGridViewRow item in dataGridViewDetalle.Rows)
                        {
                            item.Cells[(int)Col_Detalle.CANTRECIBIDA].Value = 0;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dataGridViewRemitos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                _Comprobante = Convert.ToInt32(dataGridViewRemitos.CurrentRow.Cells[(int)Col_Remito.COMPROBANTESTK].Value);               
                TraeDetalleRemito(Clases.Usuario.EmpresaLogeada.EmpresaIngresada,_Comprobante);
                this.Cursor = Cursors.Arrow;
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
                Guardar();
                this.checkBoxRecibido.Checked = false;

                int _sector = Convert.ToInt32(comboBoxSector.SelectedValue);
                int _deposito = Convert.ToInt32(comboBoxDeposito.SelectedValue);

                TraeRemitos(dateTimeFechaDesde.Value, dateTimeFechaHasta.Value, _sector, _deposito);

                if (dataGridViewRemitos.Rows.Count > 0)
                {
                    _Comprobante = Convert.ToInt32(dataGridViewRemitos.CurrentRow.Cells[(int)Col_Remito.COMPROBANTESTK].Value);

                    TraeDetalleRemito(Clases.Usuario.EmpresaLogeada.EmpresaIngresada, _Comprobante);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       private void dataGridViewDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //SOLO DEJO INGRESAR NUMEROS
            int iColumn = dataGridViewDetalle.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_Detalle.CANTRECIBIDA)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }
        }


        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewDetalle_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewDetalle.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_Detalle.CANTRECIBIDA)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }
        }
    }
}
