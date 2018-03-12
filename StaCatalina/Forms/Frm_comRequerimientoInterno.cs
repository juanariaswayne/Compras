using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net;

namespace StaCatalina.Forms
{

    public partial class Frm_comRequerimientoInterno : StaCatalina.Plantilla
    {

   
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private enum Col_Detalle
        {
            CODIGO,
            DESCRIPCION,
            UNIDAD,
            CLA_DESC,
            RUBRO,
            DESCRIP_RUBRO,
            PRESENTACION,
            MEDIDA,
            SUB_RUBRO,
            DESCRIP_SUBRUBRO,
            CANTIDAD,
     
        }


        protected int _indexSeleccionado;
        List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
      
        //VARIABLE PARA PASAR CON ENTER A OTRA COLUMNA
        private DataGridViewCell _celWasEndEdit;
        int _contOriginalGRid;
        CultureInfo culture = new CultureInfo("en-US");

        #endregion

        #region Funciones
        public Frm_comRequerimientoInterno()
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

        private void CargarRubros()
        {
            try
            {
                //también cargo los RUBROS por única vez
                BLL.Procedures.RUBROARTICULOS _rubro = new BLL.Procedures.RUBROARTICULOS();
                List<Entities.Procedures.RUBROARTICULOS> _rubroItem = new List<Entities.Procedures.RUBROARTICULOS>();
                Entities.Procedures.RUBROARTICULOS _itemSeleccion = new Entities.Procedures.RUBROARTICULOS();

                _rubroItem = _rubro.ItemList();//le paso la colección de rubros

                //Limpia el combo
                this.comboBoxRubro2.SuspendLayout();
                this.comboBoxRubro2.DataSource = null;
                this.comboBoxRubro2.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.da1_desc = "<Seleccione un Rubro>";
                _itemSeleccion.da1_cod = "0";
                _rubroItem.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxRubro2.DisplayMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_DESC;
                this.comboBoxRubro2.ValueMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_COD;
                this.comboBoxRubro2.DataSource = _rubroItem;
                this.comboBoxRubro2.SelectedIndex = 0;

                this.comboBoxRubro2.ResumeLayout();



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
                //también cargo los SUB RUBROS por única vez, SOLO TRAIGO LOS QUE EL USUARIO PUEDE VER
                BLL.Procedures.TRAESUBRUBROSDELUSUARIO _rubro = new BLL.Procedures.TRAESUBRUBROSDELUSUARIO();
                List<Entities.Procedures.TRAESUBRUBROSDELUSUARIO> _rubroItem = new List<Entities.Procedures.TRAESUBRUBROSDELUSUARIO>();
                Entities.Procedures.TRAESUBRUBROSDELUSUARIO _itemSeleccion = new Entities.Procedures.TRAESUBRUBROSDELUSUARIO();

                _rubroItem = _rubro.ItemList(Clases.Usuario.UsuarioLogeado.id_usuario_Logeado);//le paso la colección de rubros

                //Limpia el combo
                this.comboBoxrubro.SuspendLayout();
                this.comboBoxrubro.DataSource = null;
                this.comboBoxrubro.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.da2_desc = "<Seleccione un Sub Rubro>";
                _itemSeleccion.artda2_cod = "0";
                _rubroItem.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxrubro.DisplayMember = BLL.Procedures.TRAESUBRUBROSDELUSUARIO.ColumnNames.DA2_DESC;
                this.comboBoxrubro.ValueMember = BLL.Procedures.TRAESUBRUBROSDELUSUARIO.ColumnNames.ARTDA2_COD;
                this.comboBoxrubro.DataSource = _rubroItem;
                this.comboBoxrubro.SelectedIndex = 0;

                this.comboBoxrubro.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void HabilitarFunciones()
        {
            try
            {
                //if (Clases.Usuario.UsuarioLogeado.Id_Sector == 21 || Clases.Usuario.UsuarioLogeado.Id_Sector == 8)
                //{
                //    this.comboBoxLugarEntrega.Show();
                //    this.labelEntrega.Show();
                //}
                //else
                //{
                //    this.comboBoxLugarEntrega.Show();
                //    this.labelEntrega.Show();
                //}
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
                this.comboBoxDepositoDestino.DataSource = _dep.Result.Where (x=> x.DEPOSITO_ID != 3 && x.DEPOSITO_ID != 5).ToArray(); //FILTRO LOS DEPOSITO DE PUERTO MADERO Y DE MEXICO.. NO LOS TRAIGO.. PEDIDO POR MARIANO

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

        private bool VerificaIngreso()
        {
            try
            {
               

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

                if (this.comboBoxDepositoOrigen.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxDepositoOrigen, "Debe seleccionar un Sector Destino");
                    this.comboBoxDepositoOrigen.Focus();
                    return false;
                }

                if (this.comboBoxSectorOrigen.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxSectorOrigen, "Debe seleccionar un Sector Destino");
                    this.comboBoxSectorOrigen.Focus();
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

        private void NuevoIngreso()
        {
            dataGridViewReqInerno.Rows.Clear();

            this.comboBoxrubro.SelectedIndex = 0;
            this.textBoxObs.Text = "";
            comboBoxDepositoDestino.SelectedIndex = 0;
            comboBoxSectorDestino.SelectedIndex = 0;
            comboBoxDepositoOrigen.SelectedIndex = 0;
            comboBoxSectorOrigen.SelectedIndex = 0;
            textBoxBuscar.Text = string.Empty;

        }
        #endregion


        #region Eventos

        private void Frm_comRequerimientoInterno_Load(object sender, EventArgs e)
            {
                try
                {
                    MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                    menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                    this.OperacionesDelUsuario();
                   

                                  
                    // cargo en una coleccion los productos por unica vez
                    BLL.Procedures.H_ARTICULOSDEPOSITO _art = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                    _articulosItem = _art.ItemList();//le paso la colección de artículos

                    CargarRubros();
                    CargarSubRubros();

                
                CargarDepositosDestino();
                CargarDepositosOrigen();

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

            private void dataGridViewReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                //EDITO LA CELDA PARA QUE INGRESE ARTICULOS QUE NO ESTEN EN BEJERMAN
               
                    this.dataGridViewReqInerno.CurrentRow.ReadOnly = false;


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
                if (VerificaIngreso())
                {

                    if (comboBoxrubro.SelectedIndex == 0 && comboBoxRubro2.SelectedIndex == 0)
                    {
                        MessageBox.Show("Debe seleccionar un Rubro o un Subrubro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                   

                    Entities.Tables.COMREQUERIMIENTOINTERNO _ReqCabecera = new Entities.Tables.COMREQUERIMIENTOINTERNO();
                    BLL.Tables.COMREQUERIMIENTOINTERNO _ReqCab = new BLL.Tables.COMREQUERIMIENTOINTERNO();
                    Entities.Tables.COMREQUERIMIENTOINTERNOITEM _ReqItem = new Entities.Tables.COMREQUERIMIENTOINTERNOITEM();
                    List<Entities.Tables.COMREQUERIMIENTOINTERNOITEM> _ItemsReq = new List<Entities.Tables.COMREQUERIMIENTOINTERNOITEM>();
                    //CultureInfo culture = new CultureInfo("en-US");
                    string _empresa = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();

                    _ReqCabecera.FECHA = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    _ReqCabecera.ESTADO_ID = 1; //Ojo ver que valor se envia despues 
                    _ReqCabecera.OBS = this.textBoxObs.Text.Trim();
                    _ReqCabecera.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                    _ReqCabecera.SECTORREQUERIMIENTO_ID = Clases.Usuario.UsuarioLogeado.Id_Sector; // Ojo ver como se envia Despues
                    _ReqCabecera.DEPOSITODESTINO_ID = Convert.ToInt32(comboBoxDepositoDestino.SelectedValue); // A QUE DEPOSITO LE HAGO ELPEDIDO
                    _ReqCabecera.SECTORDEPOSITODESTINO_ID = Convert.ToInt32(comboBoxSectorDestino.SelectedValue); // A QUE SECTOR DEL DEPPOSITO LE HAGO EL PEDIDO
                    _ReqCabecera.DEPOSITOORIGEN_ID = Convert.ToInt32(comboBoxDepositoOrigen.SelectedValue); // EN QUE DEPOSITO DEBE ENTREGAR EL PEDIDO
                    _ReqCabecera.SECTORDEPOSITOORIGEN_ID = Convert.ToInt32(comboBoxSectorOrigen.SelectedValue); // EN QUE SECTOR DEL DEPOSITO DEBE ENTREGAR LA MERCADERIA

                    for (int i = 0; i < this.dataGridViewReqInerno.Rows.Count; i++)
                    {

                        if (dataGridViewReqInerno.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != string.Empty && dataGridViewReqInerno.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != null)
                        {
                            _ReqItem = new Entities.Tables.COMREQUERIMIENTOINTERNOITEM();

                            //_ReqItem.COMEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;                                                
                            _ReqItem.ARTICULO_ID = dataGridViewReqInerno.Rows[i].Cells[(int)Col_Detalle.CODIGO].Value.ToString();
                            _ReqItem.UNIMED = dataGridViewReqInerno.Rows[i].Cells[(int)Col_Detalle.UNIDAD].Value.ToString();
                            _ReqItem.CANTIDAD = Convert.ToDecimal(dataGridViewReqInerno.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value.ToString(), culture);
                            _ReqItem.FECHAENTREGA = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //  por defaul... porque lo requiere la table                    
                            _ReqItem.NIVELAUT_ID = 1; // 
                            //SI LA CANTIDAD ES CERO.. NO LO GRABO.
                            if (_ReqItem.CANTIDAD > 0)
                                _ItemsReq.Add(_ReqItem); //Meto en la coleccion todos los elementos de la grilla

                        }
                    }


                    //PUEDE SER QUE SOLO SE CARGUE ARTICULOS PROVISORIOS.... SE ENVIA LA CABECERA DEL REQUERIMIENTO Y LOS ITEMS DE PROVISORIOS
                    if (_ItemsReq.Count > 0)
                    {
                        int _nroReqGenerado = 0;
                        //LLAMO A LA FUNCION QUE GUARDA CABECERA E ITEMS
                        if (_ReqCab.AddItem(_ReqCabecera, _ItemsReq, _empresa, ref _nroReqGenerado))
                        {


                            MessageBox.Show("Se generó el Requerimiento Nro.: " + _nroReqGenerado, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NuevoIngreso();


                        }
                        else
                        {
                            MessageBox.Show("Error al grabar Requerimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar al menos una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            NuevoIngreso();
        }




        private void comboBoxrubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MUESTRA LOS ARTICULOS DE ESE RUBRO
            try
            {
                if (this.comboBoxrubro.SelectedIndex > 0)
                {
                    comboBoxRubro2.SelectedIndex = 0; //DESHABILITO EL COMBO DE RUBROS.. ASÍ SOLO TRAE PRODUCTOS DEL SUB RUBRO 

                    var q = (dynamic)null;

                    q = (from item in _articulosItem
                         where item.art_descgen.Contains(textBoxBuscar.Text.Trim().ToUpper()) && item.subrubro.ToString().Trim() == this.comboBoxrubro.SelectedValue.ToString().Trim()
                         select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();
                   
                    this.dataGridViewReqInerno.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.H_ARTICULOSDEPOSITO item in q)
                    {
                        indice = dataGridViewReqInerno.Rows.Add();
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.CODIGO].Value = item.art_codgen; //ARTICULO
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.DESCRIPCION].Value = item.art_descgen; // DESCTRIPCION ARTICULO
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.UNIDAD].Value = item.unimed; // UNIDAD MEDIDA
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.CLA_DESC].Value = item.cla_desc; // DESCRIPCION UNIDAD MEDIDA
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.RUBRO].Value = item.rubro; // RUBRO
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.DESCRIP_RUBRO].Value = item.descriprubro; // DESCRIP RUBRO
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.PRESENTACION].Value = item.presentacion; // PRESENTACION
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.MEDIDA].Value = item.medida; // MEDIDA
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.SUB_RUBRO].Value = item.subrubro; // SUB RUBRO
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.DESCRIP_SUBRUBRO].Value = item.descripsubrubro; // DESCRIP SUB RUBRO

                    }


                   // this.bindingSourceReq.DataSource = q;

                    _contOriginalGRid = dataGridViewReqInerno.Rows.Count;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = this.textBoxBuscar.Text.Trim();
            List<DataGridViewRow> rows = (from item in dataGridViewReqInerno.Rows.Cast<DataGridViewRow>()
                                          let descripcion = Convert.ToString(item.Cells[(int)Col_Detalle.DESCRIPCION].Value ?? string.Empty).ToLower()
                                          where descripcion.Contains(busqueda.ToLower())
                                          select item).ToList<DataGridViewRow>();

            foreach (DataGridViewRow row in rows)
            {
                List<DataGridViewCell> cells = (from item in row.Cells.Cast<DataGridViewCell>()
                                                let cell = Convert.ToString(item.Value).ToLower()
                                                where cell.Contains(busqueda.ToLower())
                                                select item).ToList<DataGridViewCell>();


                row.Selected = true;
                dataGridViewReqInerno.Rows[row.Index].Cells[1].Selected = true;

                break;

            }
        }


        #endregion



        private void comboBoxRubro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MUESTRA LOS ARTICULOS DE ESE RUBRO
            try
            {
                if (this.comboBoxRubro2.SelectedIndex > 0)
                {
                    comboBoxrubro.SelectedIndex = 0; //DESHABILITO EL COMBO DE SUBRUBROS.. ASÍ SOLO TRAE PRODUCTOS DEL RUBRO 

                    var q = (dynamic)null;

                    q = (from item in _articulosItem
                         where item.art_descgen.Contains(textBoxBuscar.Text.Trim().ToUpper()) && item.rubro.ToString().Trim() == this.comboBoxRubro2.SelectedValue.ToString().Trim()
                         select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();

                    this.dataGridViewReqInerno.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.H_ARTICULOSDEPOSITO item in q)
                    {
                        indice = dataGridViewReqInerno.Rows.Add();
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.CODIGO].Value = item.art_codgen; //ARTICULO
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.DESCRIPCION].Value = item.art_descgen; // DESCTRIPCION ARTICULO
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.UNIDAD].Value = item.unimed; // UNIDAD MEDIDA
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.CLA_DESC].Value = item.cla_desc; // DESCRIPCION UNIDAD MEDIDA
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.RUBRO].Value = item.rubro; // RUBRO
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.DESCRIP_RUBRO].Value = item.descriprubro; // DESCRIP RUBRO
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.PRESENTACION].Value = item.presentacion; // PRESENTACION
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.MEDIDA].Value = item.medida; // MEDIDA
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.SUB_RUBRO].Value = item.subrubro; // SUB RUBRO
                        dataGridViewReqInerno.Rows[indice].Cells[(int)Col_Detalle.DESCRIP_SUBRUBRO].Value = item.descripsubrubro; // DESCRIP SUB RUBRO

                     
                    }


                    // this.bindingSourceReq.DataSource = q;

                    _contOriginalGRid = dataGridViewReqInerno.Rows.Count;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewReq_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //solo para que no me muestre el error
        }

        private void comboBoxDepositoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CARGO LOS SECTORES DE ESTE DEPOSITO
            if(comboBoxDepositoDestino.SelectedIndex > 0)
                CargarSectoresDestino(Convert.ToInt32(this.comboBoxDepositoDestino.SelectedValue));
        }

        private void comboBoxDepositoOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxDepositoOrigen.SelectedIndex > 0)
            {
                CargarSectoresOrigen(Convert.ToInt32(this.comboBoxDepositoOrigen.SelectedValue));
            }
        }

        private void dataGridViewReqInerno_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewReqInerno.IsCurrentCellDirty)
                dataGridViewReqInerno.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewReqInerno_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _celWasEndEdit = dataGridViewReqInerno[e.ColumnIndex, e.RowIndex];
        }

        private void dataGridViewReqInerno_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewReqInerno.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_Detalle.CANTIDAD)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }
        }

        private void dataGridViewReqInerno_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
    }

