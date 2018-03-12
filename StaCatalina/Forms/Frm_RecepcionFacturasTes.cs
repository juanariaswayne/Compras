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
    public partial class Frm_RecepcionFacturasTes : StaCatalina.Plantilla
    {
        #region Variables
        private enum Col_Facturas
        {
            RECIBIDO = 0,
            COMPROBANTE,
            PVENTA,
            TIPO,
            PROVEED,
            RAZONSOCIAL,
            IMPORTE,
            FCONTABLE,            

        }

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        #endregion

        #region Funciones

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

        public Frm_RecepcionFacturasTes()
        {
            InitializeComponent();
        }

        private void TraeFacturas()
        {

            try
            {
                BLL.Procedures.TRAEFACTURASRECIBIDAS _detalle = new BLL.Procedures.TRAEFACTURASRECIBIDAS();


                this.dataGridViewFacturas.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.TRAEFACTURASRECIBIDAS item in _detalle.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada,this.dateTimefechaDesde.Value,this.dateTimefechaHasta.Value))
                {
                    indice = dataGridViewFacturas.Rows.Add();
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Facturas.COMPROBANTE].Value = item.numerocomp;//
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Facturas.PVENTA].Value = item.puntodeventa; //
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Facturas.TIPO].Value = item.letracomprobante; //
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Facturas.PROVEED].Value = item.codigoprooved;//
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Facturas.RAZONSOCIAL].Value = item.razonsocial;//
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Facturas.IMPORTE].Value = item.importe;//
                    dataGridViewFacturas.Rows[indice].Cells[(int)Col_Facturas.FCONTABLE].Value = item.fechacontable;//

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #endregion

        #region Eventos
        private void Frm_RecepcionFacturasTes_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //FIN PERMISOS
        }

        private void buttonTraeFacturas_Click(object sender, EventArgs e)
        {
            TraeFacturas();
        }
       
        private void dataGridViewFacturas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewFacturas.IsCurrentCellDirty)
                dataGridViewFacturas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void checkBoxSeleccion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxSeleccion.Checked == true)
            {
                for (int i = 0; i < this.dataGridViewFacturas.Rows.Count; i++)
                {
                    dataGridViewFacturas.Rows[i].Cells[(int)Col_Facturas.RECIBIDO].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < this.dataGridViewFacturas.Rows.Count; i++)
                {
                    dataGridViewFacturas.Rows[i].Cells[(int)Col_Facturas.RECIBIDO].Value = false;
                }
            }

        }

        #endregion

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {

            try
            {
                Entities.Tables.TESFACTURASRECIBIDAS _fact = new Entities.Tables.TESFACTURASRECIBIDAS();
                BLL.Tables.TESFACTURASRECIBIDAS _Facturas = new BLL.Tables.TESFACTURASRECIBIDAS();

                Boolean _selecciono = false;
                for (int i = 0; i < this.dataGridViewFacturas.Rows.Count; i++)
                {
                    _fact = new Entities.Tables.TESFACTURASRECIBIDAS();

                    DataGridViewCheckBoxCell cellSelecion = dataGridViewFacturas.Rows[i].Cells[(int)Col_Facturas.RECIBIDO] as DataGridViewCheckBoxCell;

                    _fact.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
                    _fact.CODIGOPROVEED = Convert.ToString(dataGridViewFacturas.Rows[i].Cells[(int)Col_Facturas.PROVEED].Value);
                    _fact.RAZONSOCIAL = Convert.ToString(dataGridViewFacturas.Rows[i].Cells[(int)Col_Facturas.RAZONSOCIAL].Value);
                    _fact.NUMEROCOMPROBANTE = Convert.ToString(dataGridViewFacturas.Rows[i].Cells[(int)Col_Facturas.COMPROBANTE].Value);
                    _fact.PUNTODEVENTA = Convert.ToString(dataGridViewFacturas.Rows[i].Cells[(int)Col_Facturas.PVENTA].Value);
                    _fact.LETRA = Convert.ToString(dataGridViewFacturas.Rows[i].Cells[(int)Col_Facturas.TIPO].Value);
                    _fact.IMPORTE = Convert.ToDouble(dataGridViewFacturas.Rows[i].Cells[(int)Col_Facturas.IMPORTE].Value);
                    _fact.FECHACONTABLE = Convert.ToDateTime(dataGridViewFacturas.Rows[i].Cells[(int)Col_Facturas.FCONTABLE].Value);
                    _fact.FECHARECEPCION = DateTime.Now;
                    _fact.USUARIORECIBE = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado; 

                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                       _Facturas.AddItem(_fact);
                       _selecciono = true;
                    }                   



                }
                if (_selecciono)
                {
                    MessageBox.Show("Se Guardo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewFacturas.Rows.Clear();
                    TraeFacturas();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos una Factura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
