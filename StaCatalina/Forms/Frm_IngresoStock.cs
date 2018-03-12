using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Configuration;
namespace StaCatalina.Forms
{
    public interface IAddItemIngStock
    {
        void AddNewItemIngStock(string cod, string descrip, string uniMed,Boolean llevaVto);
    }
    public partial class Frm_IngresoStock : StaCatalina.Plantilla, IAddItemIngStock
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
                UNIDAD,
                CANTIDAD,
                LLEVA_VENCIMIENTO,
                VTOS
        }
            protected int _indexSeleccionado;
            protected List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
            protected List<Entities.Procedures.RUBROARTICULOS> _rubrositem = new List<Entities.Procedures.RUBROARTICULOS>();

            private List<Entities.Tables.STKVENCIMIENTO> _ArtsVtos = new List<Entities.Tables.STKVENCIMIENTO>();

        //VARIABLE PARA PASAR CON ENTER A OTRA COLUMNA
        private DataGridViewCell _celWasEndEdit;
        #endregion

        #region IAddItem Members

        public void AddNewItemIngStock(string cod, string descrip, string uniMed,Boolean llevaVto)
        {
            this.dataGridViewDetalleIngStock.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.CODIGO].Value = cod;
            this.dataGridViewDetalleIngStock.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.DESCRIPCION].Value = descrip;
            this.dataGridViewDetalleIngStock.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.UNIDAD].Value = uniMed;
            this.dataGridViewDetalleIngStock.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.LLEVA_VENCIMIENTO].Value = llevaVto;
            if (Convert.ToBoolean(dataGridViewDetalleIngStock.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.LLEVA_VENCIMIENTO].Value))
            {
                DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)dataGridViewDetalleIngStock.Rows[_indexSeleccionado].Cells[(int)Col_Detalle.VTOS];
                //HABILITRO LA CELDA... LE CAMBIO EL VALOR A TRUE
                buttonCell.Enabled = true;
            }

            this.dataGridViewDetalleIngStock.CurrentCell = this.dataGridViewDetalleIngStock.CurrentRow.Cells[(int)Col_Detalle.CANTIDAD];
        }
        
        #endregion

        #region Funciones
            public Frm_IngresoStock()
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

            private void CargarDepositos()
            {
                try
                {
                string _codEmp = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                BLL.Tables.STKDEPOSITO _dep = new BLL.Tables.STKDEPOSITO();
                _dep.WhereParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, _codEmp);
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
                    _sec.ItemList(_codEmp,_dep);

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
                    if (this.comboBoxDeposito.SelectedIndex == 0)
                    {
                        this.errorProvider1.SetError(this.comboBoxDeposito, "Debe seleccionar un Depósito");
                        this.comboBoxDeposito.Focus();
                        return false;
                    }

                    //if (this.comboBoxSector.SelectedIndex == 0)
                    //{
                    //    this.errorProvider1.SetError(this.comboBoxSector, "Debe seleccionar un Sector");
                    //    this.comboBoxSector.Focus();
                    //    return false;
                    //}


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

        public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
        {
            public DataGridViewDisableButtonColumn()
            {
                this.CellTemplate = new DataGridViewDisableButtonCell();
            }
        }
        public class DataGridViewDisableButtonCell : DataGridViewButtonCell
        {
            private bool enabledValue;
            public bool Enabled
            {
                get
                {
                    return enabledValue;
                }
                set
                {
                    enabledValue = value;
                }
            }
        }
        #endregion

        #region Eventos
        private void Frm_IngresoStock_Load(object sender, EventArgs e)
            {
                try
                {
                    MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                    menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                    this.OperacionesDelUsuario();

                    // cargo en una coleccion los productos por unica vez
                    BLL.Procedures.H_ARTICULOSDEPOSITO _art = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                    _articulosItem = _art.ItemList();//le paso la colección de artículos

                    //también cargo los rubros por única vez
                    BLL.Procedures.RUBROARTICULOS _rubro = new BLL.Procedures.RUBROARTICULOS();
                    _rubrositem = _rubro.ItemList();//le paso la colección de rubros

                    //carga los depósitos
                    CargarDepositos();

                    //CREO LA COLUMNA DE TIPO BUTTON
                    DataGridViewDisableButtonColumn column = new DataGridViewDisableButtonColumn();
                    column.Name = "Fvto";
                    column.HeaderText = "Fecha Vtos.";
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    dataGridViewDetalleIngStock.Columns.Insert((int)Col_Detalle.VTOS, column);

                    //FIN CREAR COLUMNA

            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            private void dataGridViewDetalleIngStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    //var senderGrid = (DataGridView)sender;

                //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                if (e.ColumnIndex == (int)Col_Detalle.BUSCADOR && e.RowIndex >= 0)
                {
                        Frm_ProdIngresoStock _prod = new Frm_ProdIngresoStock();
                        _prod.Articulos = _articulosItem;//le paso la colección de artículos
                        //paso los rubros
                        _prod.Rubros = _rubrositem;
                        _indexSeleccionado = e.RowIndex; //establezco el index
                        _prod.MdiParent = this.MdiParent; // esto porque estoy utiliando MDI
                        _prod.Opener = this; // es para el formulario hijo
                        _prod.Show();
                        _prod.StartPosition = FormStartPosition.CenterScreen;

                }

                if (e.ColumnIndex == (int)Col_Detalle.VTOS && e.RowIndex >= 0)
                {
                    DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)dataGridViewDetalleIngStock.Rows[e.RowIndex].Cells[(int)Col_Detalle.VTOS];

                    if (!buttonCell.Enabled)
                    {
                        MessageBox.Show("Este artículo no tiene el atributo Trabaja con Fecha de Vto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return; //SI EL BUTTON TIENE ENEBLE = FALSE NO PERMITO MOSTRAR EL OTRO FORMULARIO
                    }
                    Frm_Vtos _vto = new Frm_Vtos();
                    string _art = dataGridViewDetalleIngStock.Rows[e.RowIndex].Cells[(int)Col_Detalle.CODIGO].Value.ToString();
                    string _descripArt = dataGridViewDetalleIngStock.Rows[e.RowIndex].Cells[(int)Col_Detalle.DESCRIPCION].Value.ToString();
                    //RECUPERO LA LISTA DE VTOS DE ESTE ARTICULO PARA PASARLO AL FORMULARIO DE VTOS
                    List<Entities.Tables.STKVENCIMIENTO> _listObj = _ArtsVtos.FindAll(item => item.ARTICULO_ID == _art);
                    //ACA BORRAR DE LA LISTA ESTE ARTICULO CON TODOS SUS VTOS. PORQUE CARGO TODO DE NUEVO CADA VEZ QUE SE EDITA... 
                    //ESTO PORQUE PUEDE ESTAR AGREGANDO O ELIMINANDO VTOS.
                    _ArtsVtos.RemoveAll(item => item.ARTICULO_ID == _art);
                    //PASO LA LISTA AL FORMULARIO DE VTOS
                    _vto.ListVto = _listObj;
                    Entities.Tables.STKVENCIMIENTO _newVto;
                    _vto.CodigoArticuloVto = _art;
                    _vto.DescripArticuloVto = _descripArt;
                    decimal _cantIngresada = 0;
                    int _cantidadFechaVto = 0;
                    if (_vto.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var item in _vto.ListVto)
                        {
                            _newVto = new Entities.Tables.STKVENCIMIENTO();
                            _newVto.ARTICULO_ID = item.ARTICULO_ID;
                            _newVto.CANTIDAD = item.CANTIDAD;
                            _newVto.VTO = item.VTO;
                            //VOY SUMANDO LAS CANTIDADES
                            _cantIngresada += item.CANTIDAD;
                            _cantidadFechaVto++; //ME DICE CUANTAS FECHAS DE VTOS DISTINTAS TENGO, ES PARA SABER CUANTAS ETIQUETAS DEBO IMPRIMIR
                            _ArtsVtos.Add(_newVto);
                        }
                        //COLOCO LA CANTIDAD TOTAL RECIBIDA DE ESTE ARTICULO
                        //NO COLOCO LA CANTIDAD RECIBIDA PORQUE NO ME HABILITA EL PROXIMO RENGON.....
                       // dataGridViewDetalleIngStock.Rows[e.RowIndex].Cells[(int)Col_Detalle.CANTIDAD].Value = _cantIngresada.ToString().Replace(",", ".");
                       
                    }


                }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            private void dataGridViewDetalleIngStock_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewDetalleIngStock.IsCurrentCellDirty)
                    dataGridViewDetalleIngStock.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            private void dataGridViewDetalleIngStock_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
            {
                int iColumn = dataGridViewDetalleIngStock.CurrentCell.ColumnIndex;
                if (iColumn == (int)Col_Detalle.CANTIDAD)
                {
                    TextBox txt = e.Control as TextBox;
                    txt.KeyPress += OnlyNumbers_KeyPress;
                }
            }

            private void buttonNew_Click(object sender, EventArgs e)
            {
                dataGridViewDetalleIngStock.Rows.Clear();
              
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

                        CultureInfo culture = new CultureInfo("en-US");
                        


                        for (int i = 0; i < this.dataGridViewDetalleIngStock.Rows.Count - 1; i++)
                        {
                            _itemInventario = new Entities.Tables.STKINVENTARIO();
                            _itemInventario.ARTICULO_ID = dataGridViewDetalleIngStock.Rows[i].Cells[(int)Col_Detalle.CODIGO].Value.ToString();//COD ARTICULO
                            _itemInventario.CANTIDAD = Convert.ToDecimal(dataGridViewDetalleIngStock.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value.ToString(), culture); //cantidad
                            _itemInventario.DEPOSITO_ID = Convert.ToInt32(this.comboBoxDeposito.SelectedValue);//DEPOSITO
                            _itemInventario.SECTOR_ID = 1; //SECTOR
                            _itemInventario.UNIMED = dataGridViewDetalleIngStock.Rows[i].Cells[(int)Col_Detalle.UNIDAD].Value.ToString();//UNIDAD MEDIDA
                            //VOY AGREGANDO A LA COLECCION
                            _itemsInv.Add(_itemInventario);

                            //AHORA CARGO EL OBJETO STKMOVIMIENTOITEM
                            _itemMov = new Entities.Tables.STKMOVIMIENTOITEM();
                            _itemMov.ARTICULO_ID = dataGridViewDetalleIngStock.Rows[i].Cells[(int)Col_Detalle.CODIGO].Value.ToString();//COD ARTICULO
                            _itemMov.CANTIDAD = Convert.ToDecimal(dataGridViewDetalleIngStock.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value.ToString(), culture); //cantidad
                            _itemMov.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(); //CODEMP
                            _itemMov.UNIMED = dataGridViewDetalleIngStock.Rows[i].Cells[(int)Col_Detalle.UNIDAD].Value.ToString();//UNIDAD MEDIDA                            
                            //VOY AGREGANDO A LA COLECCION
                            _itemsMov.Add(_itemMov);



                        }

                        //CARGO LOS OBJETOS DE STKMOVIMIENTOS
                        _itemMovimiento.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(); //CODEMP
                        _itemMovimiento.ANULADO = 0;
                        _itemMovimiento.FECHAMOV = Convert.ToDateTime(this.dateTimeFecha.Value.ToShortDateString());
                        _itemMovimiento.TIPOMOV_ID = 1; //OJO VER ESTO SI SE PUEDE CAMBIAR...... EL 1 ES ENTRADA
                        _itemMovimiento.DEPOSITOORIGEN_ID = Convert.ToInt32(this.comboBoxDeposito.SelectedValue);//DEPOSITO
                        _itemMovimiento.SECTORORIGEN_ID = 1;  // OJO ***** NO SE LLEVA EL STOCK POR SECTOR.. EL ORIGEN SOLO SE UTILZA PARA ENVIAR MERCADERIA //Convert.ToInt32(this.comboBoxSector.SelectedValue); //SECTOR
                    if (checkBoxInicial.Checked)
                    {
                        _itemMovimiento.SUBTIPOMOV_ID = 6; // STOCK INICIAL
                    }
                    else
                    {
                        _itemMovimiento.SUBTIPOMOV_ID = 1; //ojo ver SI SE PUEDE CAMBIAR...... EL 1 ES INGRESO DE STOCK
                    }

                    _itemMovimiento.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();
                    _itemMovimiento.OBS = "";

                        
                        if (_stk.GenerarMovStock(_itemsInv, _itemMovimiento, _itemsMov, _ArtsVtos) == 0)
                        {
                            MessageBox.Show("El ingreso se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridViewDetalleIngStock.Rows.Clear();
                            this.comboBoxDeposito.SelectedIndex = 0;
                            this.comboBoxSector.SelectedIndex = 0;
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

            private void comboBoxDeposito_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (this.comboBoxDeposito.SelectedIndex > 0)
                    CargarSectoresDeposito(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(), Convert.ToInt32(this.comboBoxDeposito.SelectedValue));
            }

            private void dataGridViewDetalleIngStock_KeyDown(object sender, KeyEventArgs e)
            {
                try
                {
                    var senderGrid = (DataGridView)sender;

                    if (e.KeyCode == Keys.Enter && senderGrid.Columns[this.dataGridViewDetalleIngStock.CurrentCell.ColumnIndex].Index == (int)Col_Detalle.BUSCADOR && this.dataGridViewDetalleIngStock.CurrentCell.RowIndex >= 0)
                    {
                        Frm_ProdIngresoStock _prod = new Frm_ProdIngresoStock();
                        _prod.Articulos = _articulosItem;//le paso la colección de artículos
                        //paso los rubros
                        _prod.Rubros = _rubrositem;
                        _indexSeleccionado = this.dataGridViewDetalleIngStock.CurrentCell.RowIndex; //establezco el index
                        _prod.MdiParent = this.MdiParent; // esto porque estoy utiliando MDI
                        _prod.Opener = this; // es para el formulario hijo
                        _prod.Show();
                        _prod.StartPosition = FormStartPosition.CenterScreen;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            private void dataGridViewDetalleIngStock_CellEndEdit(object sender, DataGridViewCellEventArgs e)
            {
                _celWasEndEdit = dataGridViewDetalleIngStock[e.ColumnIndex, e.RowIndex];
            }

            private void dataGridViewDetalleIngStock_SelectionChanged(object sender, EventArgs e)
            {
                //PASO CON ENTER A LA OTRA COLUMNA
                //if (MouseButtons != 0) return;

                //if (_celWasEndEdit != null && dataGridViewDetalleIngStock.CurrentCell != null)
                //{
                //    // if we are currently in the next line of last edit cell
                //    if (dataGridViewDetalleIngStock.CurrentCell.RowIndex == _celWasEndEdit.RowIndex + 1 &&
                //        dataGridViewDetalleIngStock.CurrentCell.ColumnIndex == _celWasEndEdit.ColumnIndex)
                //    {
                //        int iColNew;
                //        int iRowNew = 0;
                //        if (_celWasEndEdit.ColumnIndex >= dataGridViewDetalleIngStock.ColumnCount - 1)
                //        {
                //            iColNew = 0;
                //            iRowNew = dataGridViewDetalleIngStock.CurrentCell.RowIndex;
                //        }
                //        else
                //        {
                //            iColNew = _celWasEndEdit.ColumnIndex + 1;
                //            iRowNew = _celWasEndEdit.RowIndex;
                //        }
                //        dataGridViewDetalleIngStock.CurrentCell = dataGridViewDetalleIngStock[iColNew, iRowNew];
                //    }
                //}
                //_celWasEndEdit = null;
            }


        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
