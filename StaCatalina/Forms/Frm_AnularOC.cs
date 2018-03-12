using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace StaCatalina.Forms
{
    public partial class Frm_AnularOC : Plantilla
    {
        #region #Variables

        private enum Col_OC
        {
            USUARIO_AUTORIZA = 0,
            CODEMP,
            ANULAR,
            NRO_ORDEN_COMPRA,
            FECHA,
            CODPRO,
            PROVEEDOR,
            MOTIVO,
            CONDPAGO,
            MODIFICACOSTO,
            USUARIO,
            TIPOOC

        }

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;


        #endregion

        #region Funciones

        public Frm_AnularOC()
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

        private void TraeOCPendientes()
        {

            try
            {
                BLL.Procedures.ORDENCOMPRA_PARA_ANULAR _detalle = new BLL.Procedures.ORDENCOMPRA_PARA_ANULAR();
                
                this.dataGridViewOC.Rows.Clear();
                var q = (dynamic)null;

                q = (from item in _detalle.ItemList()
                     where item.codemp == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString()
                     select item);

                int indice;
                foreach (Entities.Procedures.ORDENCOMPRA_PARA_ANULAR item in q)
                {
                    indice = dataGridViewOC.Rows.Add();
                    dataGridViewOC.Rows[indice].Cells[(int)Col_OC.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewOC.Rows[indice].Cells[(int)Col_OC.NRO_ORDEN_COMPRA].Value = item.ordencompra_id; //TRAE ID DE REQUERIMIENTO
                    dataGridViewOC.Rows[indice].Cells[(int)Col_OC.FECHA].Value = item.fecha.ToShortDateString(); //TRAE FECHA DE PEDIDO
                    dataGridViewOC.Rows[indice].Cells[(int)Col_OC.CODPRO].Value = item.proveed_id;//TRAE ID DEL SECTOR
                    dataGridViewOC.Rows[indice].Cells[(int)Col_OC.PROVEEDOR].Value = item.razonsocial;//TRAE DESCRIPCION DEL SECTOR
                    //dataGridViewOC.Rows[indice].Cells[(int)Col_OC.OBSERVACIONES].Value = item.obs;//TRAE OBSERVACION
                    dataGridViewOC.Rows[indice].Cells[(int)Col_OC.CONDPAGO].Value = item.condicionpago_id;
                    dataGridViewOC.Rows[indice].Cells[(int)Col_OC.MODIFICACOSTO].Value = item.modificacosto;
                    dataGridViewOC.Rows[indice].Cells[(int)Col_OC.USUARIO].Value = item.usuario;
                    dataGridViewOC.Rows[indice].Cells[(int)Col_OC.TIPOOC].Value = item.tipooc_id;
                    dataGridViewOC.Rows[indice].Cells[(int)Col_OC.USUARIO_AUTORIZA].Value = item.usuarioautoriza;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion


        #region Eventos

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Procedures.ANULA_OC _OrdenCompra = new BLL.Procedures.ANULA_OC();
                //** objetos de OC para volver a generar el nuevo requerimiento
                Entities.Tables.COMORDENCOMPRA _ocAnulada = new Entities.Tables.COMORDENCOMPRA();
                List<Entities.Tables.COMORDENCOMPRA> _listOcAnulada = new List<Entities.Tables.COMORDENCOMPRA>();

                // ***


                string _codEmp;
                Int32 _nroOC;
                string _motivo;

                Boolean _selecciono = false;
                for (int i = 0; i < this.dataGridViewOC.Rows.Count; i++)
                {
                    
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewOC.Rows[i].Cells[(int)Col_OC.ANULAR] as DataGridViewCheckBoxCell;


                    _nroOC = Convert.ToInt32(dataGridViewOC.Rows[i].Cells[(int)Col_OC.NRO_ORDEN_COMPRA].Value);
                    _codEmp = dataGridViewOC.Rows[i].Cells[(int)Col_OC.CODEMP].Value.ToString();
                 

                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _selecciono = true;
                        if (dataGridViewOC.Rows[i].Cells[(int)Col_OC.MOTIVO].Value == null || dataGridViewOC.Rows[i].Cells[(int)Col_OC.MOTIVO].Value == string.Empty)
                        {
                            MessageBox.Show("Debe ingresar un Motivo de Anulación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        _motivo = dataGridViewOC.Rows[i].Cells[(int)Col_OC.MOTIVO].Value.ToString();

                        _OrdenCompra.AnulaOrdenDeCompra(_codEmp, _nroOC, Convert.ToDateTime(DateTime.Now.ToShortTimeString()),_motivo);


                        //creo los objetos por si el usuario quiere generar nuevos requerimientos, SOLO LAS O.C. QUE SEAN POR REQUERIMIENTO O BIONEXO
                        if (dataGridViewOC.Rows[i].Cells[(int)Col_OC.TIPOOC].Value.ToString() == "2" || dataGridViewOC.Rows[i].Cells[(int)Col_OC.TIPOOC].Value.ToString() == "3")
                        {
                            _ocAnulada = new Entities.Tables.COMORDENCOMPRA();
                            _ocAnulada.CODEMP = _codEmp;
                            _ocAnulada.ORDENCOMPRA_ID = _nroOC;
                            _listOcAnulada.Add(_ocAnulada);
                            //fin crea objetos OC anuladas
                        }
                    }
             
                    

                }
                
                if (_selecciono)
                {
                    MessageBox.Show("La orden de compra se anuló correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewOC.Rows.Clear();
                    
                    // ****** PREGUNTO SI QUIERE VOLVER A GENERAR NUEVOS REQ
                    List<Entities.Tables.COMORDENCOMPRA> _ItemsnewOC = new List<Entities.Tables.COMORDENCOMPRA>();
                    Entities.Tables.COMORDENCOMPRA _newOC = new Entities.Tables.COMORDENCOMPRA();
                    BLL.Tables.COMREQUERIMIENTO _genera = new BLL.Tables.COMREQUERIMIENTO();
                    foreach (Entities.Tables.COMORDENCOMPRA item in _listOcAnulada)
                    {
                        DialogResult _result = MessageBox.Show("Desea generar un nuevo requerimiento para la orden de compra: " + item.ORDENCOMPRA_ID + " ?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (_result == System.Windows.Forms.DialogResult.OK)
                        {
                            _newOC = new Entities.Tables.COMORDENCOMPRA();
                            //VOY GUARDANDO LAS OC PARA GENERAR LOS REQ
                            _newOC.CODEMP = item.CODEMP;
                            _newOC.ORDENCOMPRA_ID = item.ORDENCOMPRA_ID;
                            _ItemsnewOC.Add(_newOC);
                        }
                    }
                    if (_ItemsnewOC.Count > 0)
                    {
                       if( _genera.GeneraNuevosRequerimientos(_ItemsnewOC,"ANU"))//Fuerzo el ANU porque es una anulacion de la O.C genero todos los Items como nuevo Req.
                            MessageBox.Show("Requerimiento generado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // ***** FIN GENERA NUEVOS REQ

                    TraeOCPendientes();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos una OC", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Frm_AnularOC_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //FIN PERMISOS
            this.Text = "Anular Orden de Compra Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
            TraeOCPendientes();

        }

        private void dataGridViewOC_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewOC.IsCurrentCellDirty)
                dataGridViewOC.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }




        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewOC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string _usuarioQueAutorizo;

                if (e.ColumnIndex == (int)Col_OC.ANULAR)
                {

                    DataGridViewCheckBoxCell cellSelecion = dataGridViewOC.Rows[e.RowIndex].Cells[(int)Col_OC.ANULAR] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        //VERIFICO SI ESTA OC ESTA AUTORIZADA
                        //VERIFICO SI ESTA OC ESTA AUTORIZADA, DE SER ASÍ SOLO EL USUARIO QUE LO AUTORIZO LO PUEDE MODIFICAR
                        if (dataGridViewOC.Rows[e.RowIndex].Cells[(int)Col_OC.USUARIO_AUTORIZA].Value != null)
                        {
                            _usuarioQueAutorizo = dataGridViewOC.Rows[e.RowIndex].Cells[(int)Col_OC.USUARIO_AUTORIZA].Value.ToString(); //SALVO EL USUARIO QUE AUTORIZO
                        }
                        else
                        {
                            _usuarioQueAutorizo = string.Empty; //SALVO EL USUARIO QUE AUTORIZO
                        }


                        if (_usuarioQueAutorizo.Trim() != string.Empty)
                        {
                            if (_usuarioQueAutorizo.Trim().ToUpper() != Clases.Usuario.UsuarioLogeado.usuario_Logeado.Trim().ToUpper())
                            {
                                //EL USUARIO NO PUEDE ANULAR ESTA OC PORQUE NO ES EL QUE LO AUTORIZÓ
                                cellSelecion.Value = false;
                                dataGridViewOC.RefreshEdit(); // HACE QUE LE SAQUE EL TILDE DE LA SELDA
                                MessageBox.Show("Usted no puede Anular esta Orden de Compra, porque la misma está autorizada, solo puede Anularla el usuario: " + _usuarioQueAutorizo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }

                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxOC_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxOC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string busqueda = this.textBoxOC.Text.Trim();
                List<DataGridViewRow> rows = (from item in dataGridViewOC.Rows.Cast<DataGridViewRow>()
                                              let descripcion = Convert.ToString(item.Cells[(int)Col_OC.NRO_ORDEN_COMPRA].Value ?? string.Empty).ToLower()
                                              where descripcion.Contains(busqueda.ToLower())
                                              select item).ToList<DataGridViewRow>();

                foreach (DataGridViewRow row in rows)
                {
                    List<DataGridViewCell> cells = (from item in row.Cells.Cast<DataGridViewCell>()
                                                    let cell = Convert.ToString(item.Value).ToLower()
                                                    where cell.Contains(busqueda.ToLower())
                                                    select item).ToList<DataGridViewCell>();


                    row.Selected = true;
                    dataGridViewOC.Rows[row.Index].Cells[(int)Col_OC.NRO_ORDEN_COMPRA].Selected = true;

                    break;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
