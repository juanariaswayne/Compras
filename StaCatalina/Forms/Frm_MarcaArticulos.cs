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
    public partial class Frm_MarcaArticulos : StaCatalina.Plantilla

    {
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private enum Col_GridDetalle
        {
            ARTICULO = 0,
            DESCRIPCION,
            MARCA1,
            MARCA2,
            MARCA3,
            MARCA4,
            MARCA5

        }

        private List<Entities.Procedures.H_ARTICULOSMARCA> _itemsMarca = new List<Entities.Procedures.H_ARTICULOSMARCA>();

        #region Funciones
        public Frm_MarcaArticulos()
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

        private void TraerArticulos()
        {

            string _codEmp = "EGES"; //    LAS MARCAS SIEMPRE SE CARGAN CON EGES..... (this.comboBoxEmpresa.SelectedIndex == 0) ? "EGES" : "RSC";
            BLL.Procedures.H_ARICULOSMARCA _marca = new BLL.Procedures.H_ARICULOSMARCA();
            _itemsMarca = _marca.ItemList(_codEmp);
            this.bindingSourceMarca.DataSource = _itemsMarca;// _marca.ItemList(_codEmp);

        }

        #endregion

        #region Eventos

        private void Frm_MarcaArticulos_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //FIN PERMISOS
            TraerArticulos();
            // NO SE USA.. SIEMPRE TOMO EGES ***** this.comboBoxEmpresa.SelectedIndex = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? 0 : 1;
        }

        private void comboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            TraerArticulos();
        }
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            //primero borro todos los datos de la tabla y guardo todo de nuevo...
            BLL.Tables.STKARTICULOMARCA _artMarca = new BLL.Tables.STKARTICULOMARCA();
            string _codEmp = "EGES"; // SIEMPRE TOMO EGES .... (this.comboBoxEmpresa.SelectedIndex == 0) ? "EGES" : "RSC";

            //_artMarca.RemoveItem(_codEmp, "0"); //EN EL ARTICULO LE ENVÍO CERO.. EL STORED BORRA TODO DE ESA EMPRESA.. NO IMPORTA EL ARTICULO

            Entities.Tables.STKARTICULOMARCA _itemMarca = new Entities.Tables.STKARTICULOMARCA();
            bool ingreso = false;
            for (int i = 0; i < this.dataGridViewMarcas.Rows.Count; i++)
            {
                if (dataGridViewMarcas.Rows[i].Cells[(int)Col_GridDetalle.MARCA1].Value.ToString().Trim() != string.Empty || dataGridViewMarcas.Rows[i].Cells[(int)Col_GridDetalle.MARCA2].Value.ToString().Trim() != string.Empty || dataGridViewMarcas.Rows[i].Cells[(int)Col_GridDetalle.MARCA3].Value.ToString().Trim() != string.Empty || (dataGridViewMarcas.Rows[i].Cells[(int)Col_GridDetalle.MARCA4].Value.ToString().Trim() != string.Empty) || dataGridViewMarcas.Rows[i].Cells[(int)Col_GridDetalle.MARCA5].Value.ToString().Trim() != string.Empty)
                {
                    _itemMarca = new Entities.Tables.STKARTICULOMARCA();

                    _itemMarca.CODEMP = _codEmp;
                    _itemMarca.ARTICULO_ID = dataGridViewMarcas.Rows[i].Cells[(int)Col_GridDetalle.ARTICULO].Value.ToString().Trim();
                    _itemMarca.MARCA1 = dataGridViewMarcas.Rows[i].Cells[(int)Col_GridDetalle.MARCA1].Value.ToString().Trim();
                    _itemMarca.MARCA2 = dataGridViewMarcas.Rows[i].Cells[(int)Col_GridDetalle.MARCA2].Value.ToString().Trim();
                    _itemMarca.MARCA3 = dataGridViewMarcas.Rows[i].Cells[(int)Col_GridDetalle.MARCA3].Value.ToString().Trim();
                    _itemMarca.MARCA4 = dataGridViewMarcas.Rows[i].Cells[(int)Col_GridDetalle.MARCA4].Value.ToString().Trim();
                    _itemMarca.MARCA5 = dataGridViewMarcas.Rows[i].Cells[(int)Col_GridDetalle.MARCA5].Value.ToString().Trim();

                    _artMarca.Add(_itemMarca); //VOY AGREGANDO A LA BASE
                    ingreso = true;
                }

            }
            if (ingreso)
            {
                MessageBox.Show("La operación se generó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Debe ingresar al menos una marca para alguno de los artículos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void buttonBuscarDesc_Click(object sender, EventArgs e)
        {
            var q = (dynamic)null;

            q = (from item in _itemsMarca
                 where item.Art_DescGen.ToUpper().Contains(textBoxBuscarDescrip.Text.Trim().ToUpper())
                 select item).ToList<Entities.Procedures.H_ARTICULOSMARCA>();
                 this.bindingSourceMarca.DataSource = q;
        }

        private void textBoxBuscarDescrip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonBuscarDesc.PerformClick();
            }
        }

        private void buttonBuscarMarca_Click(object sender, EventArgs e)
        {
            var q = (dynamic)null;

            q = (from item in _itemsMarca
                 where  item.Marca1.ToUpper().Contains(this.textBoxBuscarMarca.Text.Trim().ToUpper()) || item.Marca2.ToUpper().Contains(this.textBoxBuscarMarca.Text.Trim().ToUpper()) || item.Marca3.ToUpper().Contains(this.textBoxBuscarMarca.Text.Trim().ToUpper()) || item.Marca4.ToUpper().Contains(this.textBoxBuscarMarca.Text.Trim().ToUpper()) || item.Marca5.ToUpper().Contains(this.textBoxBuscarMarca.Text.Trim().ToUpper())
                 select item).ToList<Entities.Procedures.H_ARTICULOSMARCA>();
            this.bindingSourceMarca.DataSource = q;
        }

        private void textBoxBuscarMarca_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.buttonBuscarMarca.PerformClick();
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void dataGridViewMarcas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //if (dataGridViewMarcas.IsCurrentCellDirty)
            //    dataGridViewMarcas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            
        }
    }
}

