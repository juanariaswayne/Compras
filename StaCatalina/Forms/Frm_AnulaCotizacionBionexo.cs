using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_AnulaCotizacionBionexo : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;

        private enum Col_GridDetalle
        {
           ELIMINAR = 0,
           EMPRESA,
           NROREQUERIMIENTO,
           NROSOLICITUD,
           FECHA

        }
        #endregion

        #region Funciones
        public Frm_AnulaCotizacionBionexo()
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

        private void TraerSolicitudes(string _codEmp, DateTime _fechaDesde, DateTime _fechaHasta)
        {

            try
            {
                BLL.Procedures.TRAESOLICITUDES _bionexo = new BLL.Procedures.TRAESOLICITUDES();
               
                this.dataGridViewSolicitud.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.TRAESOLICITUDES item in _bionexo.Items(_codEmp, _fechaDesde, _fechaHasta))
                {
                    indice = dataGridViewSolicitud.Rows.Add();
                    dataGridViewSolicitud.Rows[indice].Cells[(int)Col_GridDetalle.EMPRESA].Value = item.codemp; //empresa
                    dataGridViewSolicitud.Rows[indice].Cells[(int)Col_GridDetalle.NROREQUERIMIENTO].Value = item.requerimiento_id; //requerimiento
                    dataGridViewSolicitud.Rows[indice].Cells[(int)Col_GridDetalle.NROSOLICITUD].Value = item.nrosolicitud; //solicitud
                    dataGridViewSolicitud.Rows[indice].Cells[(int)Col_GridDetalle.FECHA].Value = item.fecha.ToShortDateString(); //fecha
                }



                }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        #endregion

        #region Eventos

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void dataGridViewSolicitud_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewSolicitud.IsCurrentCellDirty)
                dataGridViewSolicitud.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void FrmAnulaCotizacionBionexo_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            this.dateTimeFechaDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.dateTimeFechaHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }
        
        private void dateTimeFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TraerSolicitudes(Clases.Usuario.EmpresaLogeada.EmpresaIngresada, dateTimeFechaDesde.Value, dateTimeFechaHasta.Value);
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
                TraerSolicitudes(Clases.Usuario.EmpresaLogeada.EmpresaIngresada, dateTimeFechaDesde.Value, dateTimeFechaHasta.Value);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.Tables.COMREQUERIMIENTOBIONEXO _reqBionexo;
                BLL.Tables.COMREQUERIMIENTOBIONEXO _anula = new BLL.Tables.COMREQUERIMIENTOBIONEXO();
                Boolean _selecciono = false;
                for (int i = 0; i < this.dataGridViewSolicitud.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewSolicitud.Rows[i].Cells[(int)Col_GridDetalle.ELIMINAR] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _selecciono = true;
                        _reqBionexo = new Entities.Tables.COMREQUERIMIENTOBIONEXO();
                        _reqBionexo.CODEMP = dataGridViewSolicitud.Rows[i].Cells[(int)Col_GridDetalle.EMPRESA].Value.ToString();
                        _reqBionexo.NROSOLICITUD = Convert.ToInt32(dataGridViewSolicitud.Rows[i].Cells[(int)Col_GridDetalle.NROSOLICITUD].Value);
                        _reqBionexo.REQUERIMIENTO_ID = Convert.ToInt32(dataGridViewSolicitud.Rows[i].Cells[(int)Col_GridDetalle.NROREQUERIMIENTO].Value);

                        _anula.Remove(_reqBionexo);

                    }
                }
                if (_selecciono)
                {
                    TraerSolicitudes(Clases.Usuario.EmpresaLogeada.EmpresaIngresada, dateTimeFechaDesde.Value, dateTimeFechaHasta.Value);
                    MessageBox.Show("Solicitud eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos una Solicitud", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
