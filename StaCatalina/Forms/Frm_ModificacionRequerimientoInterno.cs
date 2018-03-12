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


     public partial class Frm_ModificacionRequerimientoInterno : Plantilla, IAddItemModReq
    {
        #region Variables

        private enum Col_ReqCab
        {
            CODEMP = 0,
            USUARIO_AUTORIZA,
            REQ_ID,
            FECHA,
            SECTOR_ID,
            OBSERVACIONES,
            DEPOSITO_ORIGEN,
            SECTOR_DEPOSITO_ORIGEN,
            DEPOSITO_DESTINO,
            SECTOR_DEPÒSITO_DESTINO
            
        }

        private enum Col_ReqItem
        {
            BUSCADOR = 0,
            CODEMP,
            NROREQ,
            NROITEM,
            CODIGO,
            DESCRIPCION,
            UNIDAD,            
            CANTIDAD
            
        }


        protected int _indexSeleccionado;
        protected List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        protected string _condPagoProveed = null;

        //VARIABLE PARA PASAR CON ENTER A OTRA COLUMNA
        private DataGridViewCell _celWasEndEdit;

        protected int REQ_ID;
        protected string _codemp;
        protected int NroProvisorio;

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        public int _Grabo { get; set; }

        CultureInfo culture = new CultureInfo("en-US");
        string _usuarioQueAutorizo;
        #endregion

        #region IAddItemModReq Members

        public void AddNewItemModReq(string cod, string descrip, string uniMed)
        {
            this.dataGridViewReqItemsInterno.Rows[_indexSeleccionado].Cells[(int)Col_ReqItem.CODIGO].Value = cod;
            this.dataGridViewReqItemsInterno.Rows[_indexSeleccionado].Cells[(int)Col_ReqItem.DESCRIPCION].Value = descrip;
            this.dataGridViewReqItemsInterno.Rows[_indexSeleccionado].Cells[(int)Col_ReqItem.UNIDAD].Value = uniMed;
            
        }

        #endregion


        #region Funciones

        public Frm_ModificacionRequerimientoInterno()
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
                this.comboBoxDepositoDestino.DataSource = _dep.Result.Where(x => x.DEPOSITO_ID != 3 && x.DEPOSITO_ID != 5).ToArray(); //FILTRO LOS DEPOSITO DE PUERTO MADERO Y DE MEXICO.. NO LOS TRAIGO.. PEDIDO POR MARIANO

                this.comboBoxDepositoDestino.ResumeLayout();
                this.comboBoxDepositoDestino.SelectedIndex = 0;

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

        private void CargarDepositosOrigen()
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
                this.comboBoxDepositoOrigen.SuspendLayout();
                this.comboBoxDepositoOrigen.DataSource = null;
                this.comboBoxDepositoOrigen.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione un Depósito Destino>";
                _itemSeleccion.DEPOSITO_ID = 0;
                _dep.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxDepositoOrigen.DisplayMember = BLL.Tables.STKDEPOSITO.ColumnNames.DESCRIPCION;
                this.comboBoxDepositoOrigen.ValueMember = BLL.Tables.STKDEPOSITO.ColumnNames.DEPOSITO_ID;
                this.comboBoxDepositoOrigen.DataSource = _dep.Result.ToArray();

                this.comboBoxDepositoOrigen.ResumeLayout();
                this.comboBoxDepositoOrigen.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void CargarSectoresOrigen(int _dep)
        {
            try
            {
                BLL.Tables.STKSECTOR _sec = new BLL.Tables.STKSECTOR();
                _sec.OrderByParameter.Add(DAL.Tables.STKSECTOR.ColumnEnum.descripcion);
                _sec.ItemList(_dep);

                Entities.Tables.STKSECTOR _itemSeleccion = new Entities.Tables.STKSECTOR();

                //Limpia el combo
                this.comboBoxSectorOrigen.SuspendLayout();
                this.comboBoxSectorOrigen.DataSource = null;
                this.comboBoxSectorOrigen.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione un Sector Destino>";
                _itemSeleccion.SECTOR_ID = 0;
                _sec.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSectorOrigen.DisplayMember = BLL.Tables.STKSECTOR.ColumnNames.DESCRIPCION;
                this.comboBoxSectorOrigen.ValueMember = BLL.Tables.STKSECTOR.ColumnNames.SECTOR_ID;
                this.comboBoxSectorOrigen.DataSource = _sec.Result.ToArray();

                this.comboBoxSectorOrigen.ResumeLayout();

                this.comboBoxSectorOrigen.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        private void TraeItemsPendientes()
        {

            try
            {
                // stored REQUERIMIENTOS_INTERNO_PARA_MODIFICAR
                StaCatalinaEntities _mod = new StaCatalinaEntities();

                var _listObj = (_mod.REQUERIMIENTOS_INTERNO_PARA_MODIFICAR(Clases.Usuario.UsuarioLogeado.Id_Sector, Clases.Usuario.UsuarioLogeado.id_usuario_Logeado)).ToList();


                this.dataGridViewReqInternoCab.Rows.Clear();
                int indice;
               
              
                foreach (REQUERIMIENTOS_INTERNO_PARA_MODIFICAR_Result item in _listObj)
                {
                    indice = dataGridViewReqInternoCab.Rows.Add();
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_ReqCab.CODEMP].Value = item.codEmp;//CODIGO DE EMPRESA
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_ReqCab.REQ_ID].Value = item.requerimiento_id; //NRO req
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_ReqCab.FECHA].Value = item.fecha.ToShortDateString();//FECHA
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_ReqCab.SECTOR_ID].Value = item.sectorRequerimiento_id;// sector al cual pertenece el usuarioque hizo el requerimiento
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_ReqCab.DEPOSITO_ORIGEN].Value = item.depositoOrigen_id;// DEPOSITO DEL CUAL HICE EL PEDIDO. ES EL LUGAR DE ENTREGA
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_ReqCab.SECTOR_DEPOSITO_ORIGEN].Value = item.sectorDepositoOrigen_id; //SECTOR DEL DEPOSITO DEL CUAL HICE EL PEDIDO
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_ReqCab.DEPOSITO_DESTINO].Value = item.depositoDestino_id;// DEPOSITO DEL CUAL HICE EL PEDIDO. ES EL LUGAR DE ENTREGA
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_ReqCab.SECTOR_DEPÒSITO_DESTINO].Value = item.sectorDepositoDestino_id; //SECTOR DEL DEPOSITO DEL CUAL HICE EL PEDIDO

                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_ReqCab.OBSERVACIONES].Value = (item.OBS == string.Empty) ? "": item.OBS;// obs
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_ReqCab.USUARIO_AUTORIZA].Value = item.usuarioAutoriza; //USUARIO AUTORIZA
                    
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CargarItemsRequerimiento(int _index, int _nivelAutorizazion)
        {
            try
            {
                
               //TraeRequerimientoInternoItem_Result _item = new TraeRequerimientoInternoItem_Result();
                StaCatalinaEntities _mod = new StaCatalinaEntities();

                this.dataGridViewReqItemsInterno.Rows.Clear();
                int indice;
                foreach (TraeRequerimientoInternoItem_Result item in _mod.TraeRequerimientoInternoItem(dataGridViewReqInternoCab.Rows[_index].Cells[(int)Col_ReqCab.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewReqInternoCab.Rows[_index].Cells[(int)Col_ReqCab.REQ_ID].Value), _nivelAutorizazion))
                {
                    indice = dataGridViewReqItemsInterno.Rows.Add();
                    dataGridViewReqItemsInterno.Rows[indice].Cells[(int)Col_ReqItem.CODEMP].Value = item.codEmp;//CODIGO EMPRESA
                    dataGridViewReqItemsInterno.Rows[indice].Cells[(int)Col_ReqItem.CODIGO].Value = item.articulo_id;//ARTICULO
                    dataGridViewReqItemsInterno.Rows[indice].Cells[(int)Col_ReqItem.NROREQ].Value = item.requerimiento_id; //OC
                    dataGridViewReqItemsInterno.Rows[indice].Cells[(int)Col_ReqItem.NROITEM].Value = item.nroItem; //NRO ITEM
                    dataGridViewReqItemsInterno.Rows[indice].Cells[(int)Col_ReqItem.DESCRIPCION].Value = item.art_DescGen.ToString();//DESCRIP ARTICULO
                    dataGridViewReqItemsInterno.Rows[indice].Cells[(int)Col_ReqItem.UNIDAD].Value = item.uniMed;//TRAE UNIMED                   
                    dataGridViewReqItemsInterno.Rows[indice].Cells[(int)Col_ReqItem.CANTIDAD].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD   
                    

                }
                REQ_ID = Convert.ToInt32(dataGridViewReqInternoCab.Rows[_index].Cells[(int)Col_ReqCab.REQ_ID].Value); // Salvo el NRO REQ
                _codemp = dataGridViewReqInternoCab.Rows[_index].Cells[(int)Col_ReqCab.CODEMP].Value.ToString(); // Salvo el CODEMP
                

                //TRAIGO LAS OBSERVACIOENS EN EL TEXT.. POR SI LA QUIERE MODIFICAR
                this.textBoxObs.Text = dataGridViewReqInternoCab.Rows[_index].Cells[(int)Col_ReqCab.OBSERVACIONES].Value.ToString();

                //SETEO LOS DEPOSITOS Y SECTORES
                comboBoxDepositoOrigen.SelectedValue = dataGridViewReqInternoCab.Rows[_index].Cells[(int)Col_ReqCab.DEPOSITO_ORIGEN].Value;
                comboBoxSectorOrigen.SelectedValue = dataGridViewReqInternoCab.Rows[_index].Cells[(int)Col_ReqCab.SECTOR_DEPOSITO_ORIGEN].Value;

                comboBoxDepositoDestino.SelectedValue = dataGridViewReqInternoCab.Rows[_index].Cells[(int)Col_ReqCab.DEPOSITO_DESTINO].Value;
                comboBoxSectorDestino.SelectedValue = dataGridViewReqInternoCab.Rows[_index].Cells[(int)Col_ReqCab.SECTOR_DEPÒSITO_DESTINO].Value;
                // fin seteo 
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

        //private int TraeCondPagoProveed
        //{


        //}

         private bool ValidarDatos()
         {
             try
             {
                for (int i = 0; i < this.dataGridViewReqItemsInterno.Rows.Count - 1; i++)
                 {
                     if (dataGridViewReqItemsInterno.Rows[i].Cells[(int)Col_ReqItem.CANTIDAD].Value == null || dataGridViewReqItemsInterno.Rows[i].Cells[(int)Col_ReqItem.CANTIDAD].Value == string.Empty)
                     {
                         MessageBox.Show("Debe Ingresar un valor en Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         return false;

                     }

                     if (Convert.ToDecimal(dataGridViewReqItemsInterno.Rows[i].Cells[(int)Col_ReqItem.CANTIDAD].Value) == 0)
                     {
                         MessageBox.Show("Debe Ingresar una Cantidad mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         return false;
                     }                    


                     
                 }


                 return true;


             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;

             }
         }
      

        #endregion

        #region Eventos

        private void Frm_ModificacionRequerimientoInterno_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            this.Text = "Modificación de Requerimientos Internos de la empresa: ";
            //FIN PERMISOS
                       

            // cargo en una coleccion los productos por unica vez
            BLL.Procedures.H_ARTICULOSDEPOSITO _art = new BLL.Procedures.H_ARTICULOSDEPOSITO();
            _articulosItem = _art.ItemList();//le paso la colección de artículos

            CargarDepositosDestino();
            CargarDepositosOrigen();

            TraeItemsPendientes();

        }

        private void dataGridViewOCCab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    
                    //VERIFICO SI ESTE REQ ESTA AUTORIZADO, DE SER ASÍ SOLO EL USUARIO QUE LO AUTORIZO LO PUEDE MODIFICAR
                    if (dataGridViewReqInternoCab.Rows[e.RowIndex].Cells[(int)Col_ReqCab.USUARIO_AUTORIZA].Value != null)
                    {
                        _usuarioQueAutorizo = dataGridViewReqInternoCab.Rows[e.RowIndex].Cells[(int)Col_ReqCab.USUARIO_AUTORIZA].Value.ToString(); //SALVO EL USUARIO QUE AUTORIZO
                    }
                    else
                    {
                        _usuarioQueAutorizo = string.Empty; //SALVO EL USUARIO QUE AUTORIZO
                    }

                    int _nivelAutorizacion;

                    if (_usuarioQueAutorizo.Trim() == string.Empty)
                    {
                        _nivelAutorizacion = 1; //NO ESTA AUTORIZADO
                        this.CargarItemsRequerimiento(e.RowIndex, _nivelAutorizacion); //ESTE REQ. NO ESTA AUTORIZADO. LA PUEDE MODIFICAR EL USUARIO CON PERMISOS
                        return;
                    }

                    if (_usuarioQueAutorizo.Trim() != string.Empty)
                    {
                        if (_usuarioQueAutorizo.Trim().ToUpper() == Clases.Usuario.UsuarioLogeado.usuario_Logeado.Trim().ToUpper())
                        {
                            _nivelAutorizacion = 2; //ESTA AUTORIZADO
                            this.CargarItemsRequerimiento(e.RowIndex, _nivelAutorizacion); //ESTE REQ NO ESTA AUTORIZADO. LO PUEDE MODIFICAR PORQUE EL USARIO LOGEADO ES EL MISMO QUE AUTORIZÓ
                            return;
                        }
                        else
                        {
                            this.dataGridViewReqItemsInterno.Rows.Clear();
                           
                            MessageBox.Show("Usted no puede modificar este Requerimiento, porque el mismo está autorizado, solo puede modifcarlo el usuario: " + _usuarioQueAutorizo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }

                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dataGridViewOCItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    Frm_ProdModReq _prod = new Frm_ProdModReq();
                    _prod.Articulos = _articulosItem;//le paso la colección de artículos
                    _indexSeleccionado = e.RowIndex; //establezco el index
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

        private void dataGridViewOCItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewReqItemsInterno.IsCurrentCellDirty)
                this.dataGridViewReqItemsInterno.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewOCItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewReqItemsInterno.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_ReqItem.CANTIDAD)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }


        }

            

        private void dataGridViewOCItems_KeyDown(object sender, KeyEventArgs e)
        {
            //MUESTRO PRODUCTOS CUANDO LE DOY UN ENTER EN EL BOTON DE LA PRIMER COLUMNA
            var senderGrid = (DataGridView)sender;
            if (e.KeyCode == Keys.Enter && senderGrid.Columns[this.dataGridViewReqItemsInterno.CurrentCell.ColumnIndex].Index == (int)Col_ReqItem.BUSCADOR && this.dataGridViewReqItemsInterno.CurrentCell.RowIndex >= 0)
            {
                Frm_ProdModReq _prod = new Frm_ProdModReq();
                _prod.Articulos = _articulosItem;//le paso la colección de artículos
                _indexSeleccionado = this.dataGridViewReqItemsInterno.CurrentCell.RowIndex; //establezco el index
                _prod.MdiParent = this.MdiParent; // esto porque estoy utiliando MDI
                _prod.Opener = this; // es para el formulario hijo
                _prod.Show();
                _prod.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void dataGridViewOCItems_SelectionChanged(object sender, EventArgs e)
        {
            //PASO CON ENTER A LA OTRA COLUMNA
            if (MouseButtons != 0) return;

            if (_celWasEndEdit != null && dataGridViewReqItemsInterno.CurrentCell != null)
            {
                // if we are currently in the next line of last edit cell
                if (dataGridViewReqItemsInterno.CurrentCell.RowIndex == _celWasEndEdit.RowIndex + 1 &&
                    dataGridViewReqItemsInterno.CurrentCell.ColumnIndex == _celWasEndEdit.ColumnIndex)
                {
                    int iColNew;
                    int iRowNew = 0;
                    if (_celWasEndEdit.ColumnIndex >= dataGridViewReqItemsInterno.ColumnCount - 1)
                    {
                        iColNew = 0;
                        iRowNew = dataGridViewReqItemsInterno.CurrentCell.RowIndex;
                    }
                    else
                    {
                        iColNew = _celWasEndEdit.ColumnIndex + 1;
                        iRowNew = _celWasEndEdit.RowIndex;
                    }
                    dataGridViewReqItemsInterno.CurrentCell = dataGridViewReqItemsInterno[iColNew, iRowNew];
                }
            }
            _celWasEndEdit = null;
        }

        private void dataGridViewOCItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _celWasEndEdit = dataGridViewReqItemsInterno[e.ColumnIndex, e.RowIndex];
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (ValidarDatos())
                {
                   

                    BLL.Tables.COMREQUERIMIENTOINTERNOITEM _ReqItems = new BLL.Tables.COMREQUERIMIENTOINTERNOITEM();
                    Entities.Tables.COMREQUERIMIENTOINTERNOITEM _ReqItem = new Entities.Tables.COMREQUERIMIENTOINTERNOITEM();
                    List<Entities.Tables.COMREQUERIMIENTOINTERNOITEM> _reqItemsListAdd = new List<Entities.Tables.COMREQUERIMIENTOINTERNOITEM>();

                    _Grabo = 0;

                    int _nroItem = 1;
                 
                    for (int i = 0; i < this.dataGridViewReqItemsInterno.Rows.Count - 1; i++)
                    {
                        _ReqItem = new Entities.Tables.COMREQUERIMIENTOINTERNOITEM();
                        _ReqItem.CODEMP = _codemp;
                        _ReqItem.REQUERIMIENTO_ID = REQ_ID;
                        _ReqItem.NROITEM = _nroItem;
                        _ReqItem.ARTICULO_ID = dataGridViewReqItemsInterno.Rows[i].Cells[(int)Col_ReqItem.CODIGO].Value.ToString();
                        _ReqItem.UNIMED = dataGridViewReqItemsInterno.Rows[i].Cells[(int)Col_ReqItem.UNIDAD].Value.ToString();
                        _ReqItem.CANTIDAD = Convert.ToDecimal(dataGridViewReqItemsInterno.Rows[i].Cells[(int)Col_ReqItem.CANTIDAD].Value.ToString(),culture);
                        _ReqItem.NIVELAUT_ID = 1;
                        _ReqItem.FECHAENTREGA = Convert.ToDateTime(DateTime.Now);
                        _reqItemsListAdd.Add(_ReqItem);
                        _nroItem++;
                        _Grabo = 1;
                    }

                    string _obs = this.textBoxObs.Text;

              

                    _ReqItems.RemoveItem(_codemp, REQ_ID, _reqItemsListAdd,  _obs,Convert.ToInt32(comboBoxDepositoOrigen.SelectedValue), Convert.ToInt32(comboBoxSectorOrigen.SelectedValue), Convert.ToInt32(comboBoxDepositoDestino.SelectedValue), Convert.ToInt32(comboBoxSectorDestino.SelectedValue));
                     MessageBox.Show("Los cambios se realizaron correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     dataGridViewReqItemsInterno.Rows.Clear();
                    this.textBoxObs.Text = string.Empty;
              
                     TraeItemsPendientes();
                    comboBoxDepositoOrigen.SelectedIndex = 0;
                    comboBoxDepositoDestino.SelectedIndex = 0;

                    comboBoxSectorOrigen.SelectedIndex = 0;
                    comboBoxSectorDestino.SelectedIndex = 0;


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxDepositoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CARGO LOS SECTORES DE ESTE DEPOSITO
            if (comboBoxDepositoDestino.SelectedIndex > 0)
                CargarSectoresDestino(Convert.ToInt32(this.comboBoxDepositoDestino.SelectedValue));
        }

        private void comboBoxDepositoOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDepositoOrigen.SelectedIndex > 0)
            {
                CargarSectoresOrigen(Convert.ToInt32(this.comboBoxDepositoOrigen.SelectedValue));
            }
        }
    }
}
