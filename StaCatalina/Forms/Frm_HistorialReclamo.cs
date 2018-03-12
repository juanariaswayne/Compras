using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_HistorialReclamo : Form
    {
        private Entities.Tables.HISTORIALSEGUIMIENTO _historialReclamo = new Entities.Tables.HISTORIALSEGUIMIENTO();
        #region varibles publicas
        public Entities.Tables.HISTORIALSEGUIMIENTO HistorialReclamo
        {
            get{return _historialReclamo; }
            set { _historialReclamo = value; }

        }

        #endregion
                
        #region Variables locales
        private enum Col_Historial
        {
            Id = 0, //id tabla
            ccoemp_Codigo, //EMPRESA
            ccosuc_Cod, //suc empresa
            cco_ID, //id mov
            fecha, //fecha reclamo
            Obs //observaciones
          
        }
        #endregion
        #region Funciones
            public Frm_HistorialReclamo()
            {
                InitializeComponent();
            }

        private void TraeHistorial (string ccoemp_Codigo,string ccosuc_Cod,int cco_ID)
        {

             try
            {
                this.dataGridViewHistComent.AutoGenerateColumns = false;
                BLL.Tables.HISTORIALSEGUIMIENTO _hist = new BLL.Tables.HISTORIALSEGUIMIENTO();

                this.dataGridViewHistComent.DataSource = _hist.ItemList(0,ccoemp_Codigo, ccosuc_Cod, cco_ID);
                this.dataGridViewHistComent.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion

            private void Frm_HistorialReclamo_Load(object sender, EventArgs e)
            {
                if (HistorialReclamo.CCO_ID > 0)
                    this.textBoxNewComentario.Text = "";
                    TraeHistorial(HistorialReclamo.CCOEMP_CODIGO, HistorialReclamo.CCOSUC_COD, HistorialReclamo.CCO_ID);
            }

            private void toolStripButtonSave_Click(object sender, EventArgs e)
            {
                try
                {
                    if (this.textBoxNewComentario.Text != string.Empty)
                    {
                        BLL.Tables.HISTORIALSEGUIMIENTO _genera = new BLL.Tables.HISTORIALSEGUIMIENTO();
                        Entities.Tables.HISTORIALSEGUIMIENTO _newItem = new Entities.Tables.HISTORIALSEGUIMIENTO();
                        _newItem.CCO_ID = HistorialReclamo.CCO_ID;
                        _newItem.CCOEMP_CODIGO = HistorialReclamo.CCOEMP_CODIGO;
                        _newItem.CCOSUC_COD = HistorialReclamo.CCOSUC_COD;
                        _newItem.OBS = this.textBoxNewComentario.Text.Trim();
                        _newItem.FECHA = Convert.ToDateTime(DateTime.Now.ToShortDateString().ToString());
                        _genera.Add(_newItem);
                        MessageBox.Show("Observaciones grabadas correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //vuelvo a recargar hisotorial
                        TraeHistorial(HistorialReclamo.CCOEMP_CODIGO, HistorialReclamo.CCOSUC_COD, HistorialReclamo.CCO_ID);
                        this.textBoxNewComentario.Text = "";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar una observación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        #region Eventos


        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
