using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace StaCatalina.Forms
{
    public partial class Frm_ExcluirArticulosReq : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private enum Col_ReqCab
        {
            USUARIO_AUTORIZO = 0,
            CODEMP,
            NRO_REQ,
            FECHA,
            OBSERVACIONES

        }

        private enum Col_ReqItem
        {
            EXCLUIDO,
            NROITEM,
            ARTICULO,
            DESCRIPCION,
            UNIMED,
            MOTIVO

        }
        string _usuarioQueAutorizo;
        int REQ_ID = 0;
        string _codEmp = string.Empty;
        #endregion
        #region Funciones
        public Frm_ExcluirArticulosReq()
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

        private void TraeRequerimientos()
        {

            try
            {
                BLL.Procedures.REQUERIMIENTOS_PARA_EXCLUIR_ARTICULOS _detalle = new BLL.Procedures.REQUERIMIENTOS_PARA_EXCLUIR_ARTICULOS();
               
                this.dataGridViewOCCab.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.REQUERIMIENTOS_PARA_EXCLUIR_ARTICULOS item in _detalle.Items(Clases.Usuario.UsuarioLogeado.Id_Sector, Clases.Usuario.UsuarioLogeado.id_usuario_Logeado, Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString()) )
                {
                    indice = dataGridViewOCCab.Rows.Add();
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_ReqCab.CODEMP].Value = item.codemp; //EMPRESA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_ReqCab.FECHA].Value = item.fecha.ToShortDateString();//FECHA
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_ReqCab.NRO_REQ].Value = item.requerimiento_id; //NRO req
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_ReqCab.FECHA].Value = item.fecha.ToShortDateString();
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_ReqCab.OBSERVACIONES].Value = item.obs;//PROVEEDOR
                    dataGridViewOCCab.Rows[indice].Cells[(int)Col_ReqCab.USUARIO_AUTORIZO].Value = item.usuarioautoriza;//USUARIO QUE AUTORIZO
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarItemsReq(int _index, int _nivelAutorizacion)
        {
            try
            {
                BLL.Procedures.TRAEREQUERIMIENTOITEMPARAEXCLUIR _item = new BLL.Procedures.TRAEREQUERIMIENTOITEMPARAEXCLUIR();

                this.dataGridViewOCItem.Rows.Clear();
                int indice;
                //TRAIGO LOS ITEMS QUE NO TIENEN ORDEN DE COMPRA
                foreach (Entities.Procedures.TRAEREQUERIMIENTOITEMPARAEXCLUIR item in _item.ItemList(dataGridViewOCCab.Rows[_index].Cells[(int)Col_ReqCab.CODEMP].Value.ToString(), Convert.ToInt32(dataGridViewOCCab.Rows[_index].Cells[(int)Col_ReqCab.NRO_REQ].Value)))
                {
                    indice = dataGridViewOCItem.Rows.Add();
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_ReqItem.ARTICULO].Value = item.articulo_id;//ARTICULO
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_ReqItem.NROITEM].Value = item.nroitem; //ITEM OC
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_ReqItem.DESCRIPCION].Value = item.art_descgen.ToString();//DESCRIP ARTICULO
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_ReqItem.UNIMED].Value = item.unimed.ToString();//DESCRIP ARTICULO
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_ReqItem.EXCLUIDO].Value = item.excluido;//excluido
                    dataGridViewOCItem.Rows[indice].Cells[(int)Col_ReqItem.MOTIVO].Value = item.motivoexclusion;//excluido

                }
                REQ_ID = Convert.ToInt32(dataGridViewOCCab.Rows[_index].Cells[(int)Col_ReqCab.NRO_REQ].Value); // Salvo Nro. req
                _codEmp = dataGridViewOCCab.Rows[_index].Cells[(int)Col_ReqCab.CODEMP].Value.ToString(); // Salvo el CODEMP

        
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region Eventos
        private void Frm_ExcluirArticulosReq_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            //FIN PERMISOS
            //this.dateTimeDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //this.dateTimeHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            this.Text = "Excluir Artículos de un Requerimiento, Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
            TraeRequerimientos();
        }
        
        private void dataGridViewOCCab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    //VERIFICO SI ESTA OC ESTA AUTORIZADA, DE SER ASÍ SOLO EL USUARIO QUE LA AUTORIZO LA PUEDE MODIFICAR
                    if (dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_ReqCab.USUARIO_AUTORIZO].Value != null)
                    {
                        _usuarioQueAutorizo = dataGridViewOCCab.Rows[e.RowIndex].Cells[(int)Col_ReqCab.USUARIO_AUTORIZO].Value.ToString(); //SALVO EL USUARIO QUE AUTORIZO
                    }
                    else
                    {
                        _usuarioQueAutorizo = string.Empty; //SALVO EL USUARIO QUE AUTORIZO
                    }

                    int _nivelAutorizacion;

                    if (_usuarioQueAutorizo.Trim() == string.Empty)
                    {
                        _nivelAutorizacion = 1; //NO ESTA AUTORIZADO
                        CargarItemsReq(e.RowIndex, _nivelAutorizacion); //ESTA OC NO ESTA AUTORIZADA. LA PUEDE MODIFICAR EL USUARIO CON PERMISOS
                        return;
                    }

                    if (_usuarioQueAutorizo.Trim() != string.Empty)
                    {
                        if (_usuarioQueAutorizo.Trim().ToUpper() == Clases.Usuario.UsuarioLogeado.usuario_Logeado.Trim().ToUpper())
                        {
                            _nivelAutorizacion = 2; //ESTA AUTORIZADO
                            CargarItemsReq(e.RowIndex, _nivelAutorizacion); //ESTA OC NO ESTA AUTORIZADA. LA PUEDE MODIFICAR PORQUE EL USARIO LOGRADO ES EL MISMO QUE AUTORIZÓ
                            return;
                        }
                        else
                        {
                            this.dataGridViewOCItem.Rows.Clear();
                            MessageBox.Show("Usted no puede Excluir items de este Requerimiento, porque el mismo está autorizada, solo puede hacerlo el usuario: " + _usuarioQueAutorizo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewOCItem_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewOCItem.IsCurrentCellDirty)
                this.dataGridViewOCItem.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewOCCab_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewOCCab.IsCurrentCellDirty)
                this.dataGridViewOCCab.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        
       private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                int _cantidaditems = this.dataGridViewOCItem.Rows.Count - 1;
                int _cantExcluidos = 0;
                Entities.Tables.COMREQUERIMIENTOITEM _item = new Entities.Tables.COMREQUERIMIENTOITEM();
                List<Entities.Tables.COMREQUERIMIENTOITEM> _Items = new List<Entities.Tables.COMREQUERIMIENTOITEM>();
                BLL.Procedures.EXCLUYEITEMSREQ _excluye = new BLL.Procedures.EXCLUYEITEMSREQ();

                for (int i = 0; i < this.dataGridViewOCItem.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewOCItem.Rows[i].Cells[(int)Col_ReqItem.EXCLUIDO] as DataGridViewCheckBoxCell;

                  
                    _item = new Entities.Tables.COMREQUERIMIENTOITEM();
                    _item.CODEMP = _codEmp;
                    _item.REQUERIMIENTO_ID = REQ_ID;
                    _item.NROITEM = Convert.ToInt32(dataGridViewOCItem.Rows[i].Cells[(int)Col_ReqItem.NROITEM].Value);
                    if (dataGridViewOCItem.Rows[i].Cells[(int)Col_ReqItem.MOTIVO].Value == null)
                    {
                        _item.MOTIVOEXCLUSION = "";
                    }
                    else
                    {
                        _item.MOTIVOEXCLUSION = dataGridViewOCItem.Rows[i].Cells[(int)Col_ReqItem.MOTIVO].Value.ToString().ToUpper();
                    }
                    _item.USUARIOEXCLUYE = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();
                   
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _item.EXCLUIDO = 1;
                        _cantExcluidos++;
                        _Items.Add(_item);
                        
                    }
                    else  //ESTO PORQUE PUEDE VOLVER A TRAS UN ARTICULO EXLUIDO... ES DECIR LO PUEDO INCLUR DE NUEVO
                    {
                        _item.EXCLUIDO = 0;
                        _item.MOTIVOEXCLUSION = "";
                        _item.USUARIOEXCLUYE = "";
                        _Items.Add(_item);
                    }

                }
                _excluye.ExcluyeItem(_Items);

                if (_Items.Count > 0)
                {
                    if (_cantExcluidos == _cantidaditems)
                    {
                        MessageBox.Show("No se puede excluir la totalidad de Items de la O.C.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        MessageBox.Show("Items excluidos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        REQ_ID = 0;
                        _codEmp = string.Empty;
                        dataGridViewOCItem.Rows.Clear();
                    }


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


    }
}
