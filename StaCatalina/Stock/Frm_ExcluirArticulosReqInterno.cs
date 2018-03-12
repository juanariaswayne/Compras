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
    public partial class Frm_ExcluirArticulosReqInterno: StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private enum Col_Cabe
        {
            
            DEPOSITO_ORIGEN =0,
            SECTOR_DEPOSITO_ORIGEN,
            FINALIZAR,
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
            EXCLUIR=0,
            CODEMP ,
            REQUERIMIENTO_ID,
            CODIGO,
            NROITEM,
            DESCRIPCION,
            UNIDAD,
            CANT_PEDIDA,
            CANT_ADEUDADA,
            MOTIVO

        }

        
       
        CultureInfo culture = new CultureInfo("en-US");
        string _codEmpresa = string.Empty;
        Int32 _nroRequerimientoInterno = 0;
        int _depositoEnvioMercaderia = 0;
        int _sectorDepositoEnvioMercaderia = 0;
        bool _finaliza = false;
        #endregion

#region Funciones

        public Frm_ExcluirArticulosReqInterno()
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

    
        #endregion

        #region Eventos
        private void Frm_ExcluirArticulosReqInterno_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //this.dateTimeFecha.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            this.Text = "Excluir Artículos o Finalizar Requerimiento Interno, Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
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



   
        private void dataGridViewDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {

                int _cantidaditems = this.dataGridViewDetalle.Rows.Count;
                int _cantExcluidos = 0;
                string _codEmp = string.Empty;
                Int32 _idReq = 0;
                Int32 _nroItem = 0;
                string _motivo = string.Empty;
                bool _excluido = false;
                string _usuarioExcluye = string.Empty;

                StaCatalinaEntities _Mod = new StaCatalinaEntities();

                //VERIFICO SI ESTA ANULANDO ESTE REQUERIMIENTO INTERO
                if(_finaliza)
                {
                    string _codEmpresa = dataGridViewReqCabe.Rows[dataGridViewReqCabe.CurrentRow.Index].Cells[(int)Col_Cabe.CODEMP].Value.ToString();
                    Int32 _reqInt = Convert.ToInt32(dataGridViewReqCabe.Rows[dataGridViewReqCabe.CurrentRow.Index].Cells[(int)Col_Cabe.REQUERIMIENTO_ID].Value);

                    var _usuarioAutorizo = _Mod.comRequerimientoInterno
                     .Where(b => b.codEmp == _codEmpresa && b.requerimiento_id == _reqInt)
                     .FirstOrDefault();

                    if (_usuarioAutorizo.usuarioAutoriza.Trim() != Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString().Trim())
                    {
                        MessageBox.Show("Usted no puede finalizar este Requerimiento interno, lo debe hacer el usuario: "+ _usuarioAutorizo.usuarioAutoriza , "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        if (textBoxMotivoFinaliz.Text == string.Empty)
                        {
                            MessageBox.Show("Debe ingresar un motivo de Anulación", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            textBoxMotivoFinaliz.Focus();
                            return;
                        }


                        //finalizo este requerimiento interno
                  
                        string _motivoAnulacion = textBoxMotivoFinaliz.Text;
                        string _usuarioFinaliza = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();
                        DateTime _fechaFinalizacion = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                        _Mod.FinalizaRequerimientoInterno(_codEmpresa, _reqInt, _motivoAnulacion, _fechaFinalizacion, _usuarioFinaliza);

                        //_Mod.Entry(_reqInterno).State = _reqInterno.codEmp == _codEmpresa && _reqInterno.requerimiento_id == _reqInt ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;

                       // _Mod.Entry(_reqInterno).State = System.Data.Entity.EntityState.Modified;

                        //_Mod.Entry(_reqInterno).Property(m => m.estado_id).IsModified = true;
                        //_Mod.Entry(_reqInterno).Property(m => m.motivoAnulacion).IsModified = true;
                        //_Mod.Entry(_reqInterno).Property(m => m.usuarioFinaliza).IsModified = true;

                        //_Mod.SaveChanges();
                        MessageBox.Show("Requerimiento Interno finalizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _finaliza = false;
                        labelMotivo.Visible = false;
                        textBoxMotivoFinaliz.Text = string.Empty;
                        textBoxMotivoFinaliz.Visible = false;
                    }


                    return;
                }
                //fin finaliza


                //primero controlo que no esté excluyendo la totalidad de los items
                for (int i = 0; i < this.dataGridViewDetalle.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.EXCLUIR] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _cantExcluidos++;
                    }

                }

                if (_cantExcluidos == _cantidaditems)
                {
                    MessageBox.Show("No se puede excluir la totalidad de Items de la O.C.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //FIN CONTROLA CANTIDAD DE ITEMS


                for (int i = 0; i < this.dataGridViewDetalle.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.EXCLUIR] as DataGridViewCheckBoxCell;

                                        
                    _codEmp = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.CODEMP].Value.ToString();
                    _idReq = Convert.ToInt32(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.REQUERIMIENTO_ID].Value);
                    _nroItem = Convert.ToInt32(dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.NROITEM].Value);

                    if (dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.MOTIVO].Value == null)
                    {
                        _motivo = "";
                    }
                    else
                    {
                        _motivo = dataGridViewDetalle.Rows[i].Cells[(int)Col_Detalle.MOTIVO].Value.ToString().ToUpper();
                    }
                    _usuarioExcluye = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();

                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _excluido = true;
                        _cantExcluidos++;
                        _Mod.ExcluyeItemsReqInterno(_codEmp, _idReq, _nroItem, _motivo, _usuarioExcluye, _excluido);

                    }
                    else  //ESTO PORQUE PUEDE VOLVER A TRAS UN ARTICULO EXLUIDO... ES DECIR LO PUEDO INCLUR DE NUEVO
                    {
                        _excluido = false;
                        _motivo = "";
                        _usuarioExcluye = "";
                        _Mod.ExcluyeItemsReqInterno(_codEmp, _idReq, _nroItem, _motivo, _usuarioExcluye, _excluido);
                    }

                }
                

                if (_cantExcluidos > 0)
                {
                        MessageBox.Show("Items excluidos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _codEmp = string.Empty;
                        _idReq = 0;
                        _nroItem = 0;
                        _motivo = string.Empty;
                        _excluido = false;
                        _usuarioExcluye = string.Empty;
                        this.dataGridViewDetalle.Rows.Clear();
                }

                //vuelvo a traer los requerimientos pendientes
                TraerRequerimientos(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(), Convert.ToInt32(comboBoxDepositoDelPedido.SelectedValue), Convert.ToInt32(comboBoxSectorDelPedido.SelectedValue));

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

        private void dataGridViewReqCabe_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewReqCabe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    
                    //_indexRow = e.RowIndex; //GUARDO LA FILA SELECCIONADA
                    TraerDetalleReq(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.REQUERIMIENTO_ID].Value.ToString()), 2, Convert.ToInt32(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.DEPOSITO_ORIGEN].Value.ToString()), Convert.ToInt32(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.SECTOR_DEPOSITO_ORIGEN].Value.ToString()));
                    
                    if(e.ColumnIndex == (int) Col_Cabe.FINALIZAR)
                    {
                        //verifico si esta finalizando
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.FINALIZAR] as DataGridViewCheckBoxCell;

                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            _finaliza = true;
                            labelMotivo.Visible = true;
                            textBoxMotivoFinaliz.Visible = true;
                            textBoxMotivoFinaliz.Focus();
                        }
                        else
                        {
                            _finaliza = false;
                            labelMotivo.Visible = false;
                            textBoxMotivoFinaliz.Text = string.Empty;
                            textBoxMotivoFinaliz.Visible = false;
                        }
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewReqCabe_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridViewReqCabe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    //_indexRow = e.RowIndex; //GUARDO LA FILA SELECCIONADA
                    TraerDetalleReq(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.REQUERIMIENTO_ID].Value.ToString()), 2, Convert.ToInt32(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.DEPOSITO_ORIGEN].Value.ToString()), Convert.ToInt32(dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.SECTOR_DEPOSITO_ORIGEN].Value.ToString()));

                    //if (e.ColumnIndex == (int)Col_Cabe.FINALIZAR)
                    //{
                    //    //verifico si esta finalizando
                    //    DataGridViewCheckBoxCell cellSelecion = dataGridViewReqCabe.Rows[e.RowIndex].Cells[(int)Col_Cabe.FINALIZAR] as DataGridViewCheckBoxCell;

                    //    if (Convert.ToBoolean(cellSelecion.Value))
                    //    {
                    //        _finaliza = true;
                    //        labelMotivo.Visible = true;
                    //        textBoxMotivoFinaliz.Visible = true;
                    //        textBoxMotivoFinaliz.Focus();
                    //    }
                    //    else
                    //    {
                    //        _finaliza = false;
                    //        labelMotivo.Visible = false;
                    //        textBoxMotivoFinaliz.Text = string.Empty;
                    //        textBoxMotivoFinaliz.Visible = false;
                    //    }
                    //}


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
