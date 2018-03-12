using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_EliminaReclamoSinFactura : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        //private enum Col_Grid
        //{
        //    ARTICULO = 0,
        //    DESCRIPCION,
        //    UNIDAD,
        //    CANTIDAD,

        //}
        #endregion
        
        #region Funciones
            public Frm_EliminaReclamoSinFactura()
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

            private void CargarReclamos()
            {
                try
                {
                    BLL.Tables.RECLAMOFACTURASINCARGAR _re = new BLL.Tables.RECLAMOFACTURASINCARGAR();
                    _re.OrderByParameter.Add(DAL.Tables.RECLAMOFACTURASINCARGAR.ColumnEnum.fechaReclamo);
                    this.bindingSourceReclamo.DataSource = _re.ItemList();
                   
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        #endregion
        
        #region Eventos
        private void dataGridViewEliminaReclamos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewEliminaReclamos.IsCurrentCellDirty)
                    dataGridViewEliminaReclamos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

      private void Frm_EliminaReclamoSinFactura_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //FIN PERMISOS
            CargarReclamos();

        }


        #endregion

      private void toolStripButtonSave_Click(object sender, EventArgs e)
      {
          try
          {
              Boolean _selecciono = false;
              BLL.Tables.RECLAMOFACTURASINCARGAR _elimina = new BLL.Tables.RECLAMOFACTURASINCARGAR();
              for (int i = 0; i < this.dataGridViewEliminaReclamos.Rows.Count; i++)
              {

                  DataGridViewCheckBoxCell cellSelecion = dataGridViewEliminaReclamos.Rows[i].Cells[1] as DataGridViewCheckBoxCell;
                  if (Convert.ToBoolean(cellSelecion.Value))
                  {
                      _selecciono = true;
                     // _elimina = new BLL.Tables.RECLAMOFACTURASINCARGAR();
                      _elimina.RemoveItem(Convert.ToInt32(dataGridViewEliminaReclamos.Rows[i].Cells[0].Value));
                      _elimina.WhereParameter.Clear();
                  }

              }

              if (_selecciono)
              {
                  MessageBox.Show("Se eliminaron los reclamos seleccionados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  CargarReclamos();
                  //dataGridViewEliminaReclamos.Rows.Clear();

              }
              else
              {
                  MessageBox.Show("Debe seleccionar al menos un Reclamo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}
