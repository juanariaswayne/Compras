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
    public partial class Frm_FinalizaRequerimiento : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private enum Col_ReqCab
        {
            CODEMP = 0,
            USUARIO_AUTORIZA,
            EMPRESA,
            REQ_ID,
            FECHA,
            SECTOR_ID,
            SECTOR,
            OBSERVACIONES,
            ENTREGA_ID,
            LUGARENTREGA

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
            CANTIDAD,
            FENTREGA


        }

        #endregion

        #region Funciones
        public Frm_FinalizaRequerimiento()
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

        private void TraeItemsPendientes()
        {

            try
            {
                BLL.Procedures.REQUERIMIENTOS_PARA_FINALIZAR _detalle = new BLL.Procedures.REQUERIMIENTOS_PARA_FINALIZAR();


                this.dataGridViewReqCab.Rows.Clear();
                int indice;

                var q = (dynamic)null;

                q = (from item in _detalle.ItemList(Clases.Usuario.UsuarioLogeado.Id_Sector, Clases.Usuario.UsuarioLogeado.id_usuario_Logeado)
                     where item.codemp == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString()
                     select item);

                foreach (Entities.Procedures.REQUERIMIENTOS_PARA_FINALIZAR item in q)
                {
                    indice = dataGridViewReqCab.Rows.Add();
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.EMPRESA].Value = item.codemp; //EMPRESA
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.REQ_ID].Value = item.requerimiento_id; //NRO OC
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.FECHA].Value = item.fecha.ToShortDateString();//FECHA
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.SECTOR_ID].Value = item.sectorrequerimiento_id;//PROVEEDOR
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.SECTOR].Value = item.descripcion;//PROVEEDOR
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.OBSERVACIONES].Value = (item.obs == string.Empty) ? "" : item.obs;//PROVEEDOR
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.USUARIO_AUTORIZA].Value = item.usuarioautoriza; //USUARIO AUTORIZA
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.LUGARENTREGA].Value = item.Lugarentrega; //LUGAR DE ENTRERGA
                    dataGridViewReqCab.Rows[indice].Cells[(int)Col_ReqCab.ENTREGA_ID].Value = item.Entrega_id; //ENTREGA ID
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion

        #region
        private void Frm_FinalizaRequerimiento_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            this.Text = "Finalización de Requerimientos no cumplidos, empresa: ";
            //FIN PERMISOS

            TraeItemsPendientes();


        }


        #endregion

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
