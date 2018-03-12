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
    public partial class Frm_AnularRequerimiento : StaCatalina.Plantilla
    {
#region #Variables

        private enum Col_Requerimiento
        {
            USUARIO_AUTORIZA=0,
            CODEMP,
            ANULAR,
            NRO_REQUERIMIENTO,
            FECHA_DE_PEDIDO,
            SECTOR_REQUERIMIENTO_ID,    
            SECTOR_REQUERIMIENTO,
            MOTIVO,
            OBSERVACIONES

        }

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        string _usuarioQueAutorizo;

#endregion

        #region Funciones

        public Frm_AnularRequerimiento()
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

        private void TraeRequerimientosPendientes()
        {

            try
            {
                BLL.Procedures.REQUERIMIENTOS_PARA_MODIFICAR _detalle = new BLL.Procedures.REQUERIMIENTOS_PARA_MODIFICAR();
                
                this.dataGridViewReq.Rows.Clear();
                int indice;

                var q = (dynamic)null;

                q = (from item in _detalle.ItemList(Clases.Usuario.UsuarioLogeado.Id_Sector,Clases.Usuario.UsuarioLogeado.id_usuario_Logeado)
                     where item.codemp == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString()
                     select item);

                foreach (Entities.Procedures.REQUERIMIENTOS_PARA_MODIFICAR item in q)
                {
                    indice = dataGridViewReq.Rows.Add();
                    dataGridViewReq.Rows[indice].Cells[(int)Col_Requerimiento.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewReq.Rows[indice].Cells[(int)Col_Requerimiento.NRO_REQUERIMIENTO].Value = item.requerimiento_id; //TRAE ID DE REQUERIMIENTO
                    dataGridViewReq.Rows[indice].Cells[(int)Col_Requerimiento.FECHA_DE_PEDIDO].Value = item.fecha.ToShortDateString(); //TRAE FECHA DE PEDIDO
                    dataGridViewReq.Rows[indice].Cells[(int)Col_Requerimiento.SECTOR_REQUERIMIENTO_ID].Value = item.sectorrequerimiento_id;//TRAE ID DEL SECTOR
                    dataGridViewReq.Rows[indice].Cells[(int)Col_Requerimiento.SECTOR_REQUERIMIENTO].Value = item.descripcion;//TRAE DESCRIPCION DEL SECTOR
                    dataGridViewReq.Rows[indice].Cells[(int)Col_Requerimiento.OBSERVACIONES].Value = item.obs;//TRAE OBSERVACION
                    dataGridViewReq.Rows[indice].Cells[(int)Col_Requerimiento.USUARIO_AUTORIZA].Value = item.usuarioautoriza;//USUARIO AUTORIZA


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


#endregion

#region Eventos

        private void Frm_AnularRequerimiento_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //FIN PERMISOS
            this.Text = "Anular Requerimientos Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
            TraeRequerimientosPendientes();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Entities.Tables.COMREQUERIMIENTO _Req = new Entities.Tables.COMREQUERIMIENTO();
               BLL.Procedures.ANULA_REQUERIMIENTO _Requerimiento = new BLL.Procedures.ANULA_REQUERIMIENTO();
                int _nroRequerimiento;
                string _codEmp;
                string _motivo;
                Boolean _selecciono = false;
                for (int i = 0; i < this.dataGridViewReq.Rows.Count; i++)
                {
                    
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewReq.Rows[i].Cells[(int)Col_Requerimiento.ANULAR] as DataGridViewCheckBoxCell;

                    _codEmp = dataGridViewReq.Rows[i].Cells[(int)Col_Requerimiento.CODEMP].Value.ToString();
                    _nroRequerimiento = Convert.ToInt32(dataGridViewReq.Rows[i].Cells[(int)Col_Requerimiento.NRO_REQUERIMIENTO].Value);
              
                   
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _selecciono = true;
                        
                        if (dataGridViewReq.Rows[i].Cells[(int)Col_Requerimiento.MOTIVO].Value == null || dataGridViewReq.Rows[i].Cells[(int)Col_Requerimiento.MOTIVO].Value == string.Empty)
                        {
                            MessageBox.Show("Debe ingresar un Motivo de Anulación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        _motivo = dataGridViewReq.Rows[i].Cells[(int)Col_Requerimiento.MOTIVO].Value.ToString();
                       
                        _Requerimiento.AnulaRequerimiento(_codEmp,_nroRequerimiento,_motivo);
                    }
                   
                }
                if (_selecciono)
                {
                    MessageBox.Show("El requerimiento se anuló correctamente, si el mismo tenía pedidos de cotización, éstos se eliminaron", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewReq.Rows.Clear();
                    TraeRequerimientosPendientes();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un Requerimiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        //HACE QUE FUNCIONE EL CHECK DE LA GRILLA 
        private void dataGridViewReq_CurrentCellDirtyStateChanged(object sender, EventArgs e)
       {
            if (dataGridViewReq.IsCurrentCellDirty)
                dataGridViewReq.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }


        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == (int)Col_Requerimiento.ANULAR)
                {

                    DataGridViewCheckBoxCell cellSelecion = dataGridViewReq.Rows[e.RowIndex].Cells[(int)Col_Requerimiento.ANULAR] as DataGridViewCheckBoxCell;
                   
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        //VERIFICO SI ESTE REQUERIMIENTO ESTA AUTORIZADO
                        //VERIFICO SI ESTE REQ ESTA AUTORIZADO, DE SER ASÍ SOLO EL USUARIO QUE LO AUTORIZO LO PUEDE MODIFICAR
                        if (dataGridViewReq.Rows[e.RowIndex].Cells[(int)Col_Requerimiento.USUARIO_AUTORIZA].Value != null)
                        {
                            _usuarioQueAutorizo = dataGridViewReq.Rows[e.RowIndex].Cells[(int)Col_Requerimiento.USUARIO_AUTORIZA].Value.ToString(); //SALVO EL USUARIO QUE AUTORIZO
                        }
                        else
                        {
                            _usuarioQueAutorizo = string.Empty; //SALVO EL USUARIO QUE AUTORIZO
                        }

                                          
                        if (_usuarioQueAutorizo.Trim() != string.Empty)
                        {
                            if (_usuarioQueAutorizo.Trim().ToUpper() != Clases.Usuario.UsuarioLogeado.usuario_Logeado.Trim().ToUpper())
                            {
                                //EL USUARIO NO PUEDE ANULAR ESTE REQ PORQUE NO ES EL QUE LO AUTORIZÓ
                                cellSelecion.Value = false;
                                dataGridViewReq.RefreshEdit(); // HACE QUE LE SAQUE EL TILDE DE LA SELDA
                                MessageBox.Show("Usted no puede Anular este Requerimiento, porque el mismo está autorizado, solo puede Anularlo el usuario: " + _usuarioQueAutorizo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
