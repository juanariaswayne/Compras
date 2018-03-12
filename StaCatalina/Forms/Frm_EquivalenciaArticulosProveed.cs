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
    public partial class Frm_EquivalenciaArticulosProveed : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        private string _articulo;
        #endregion
        #region Funciones
        public Frm_EquivalenciaArticulosProveed()
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
        private void CargarSubRubros()
        {
            try
            {
                BLL.Procedures.RUBROARTICULOS _rubroItem = new BLL.Procedures.RUBROARTICULOS();
                Entities.Procedures.RUBROARTICULOS _itemSeleccion = new Entities.Procedures.RUBROARTICULOS();
                _rubroItem.Items(); 
                //Limpia el combo
                this.comboBoxSubRubro.SuspendLayout();
                this.comboBoxSubRubro.DataSource = null;
                this.comboBoxSubRubro.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.da1_desc = "<Seleccione un Rubro>";
                _itemSeleccion.da1_cod= "0";
                _rubroItem.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSubRubro.DisplayMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_DESC;
                this.comboBoxSubRubro.ValueMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_COD;
                this.comboBoxSubRubro.DataSource = _rubroItem.Result.ToArray();
                this.comboBoxSubRubro.SelectedIndex = 0;

                this.comboBoxSubRubro.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void CargarArticulos(string _Rubro)
        {
            try
            {
                BLL.Procedures.H_ARTICULOSDEPOSITO _prod = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                Entities.Procedures.H_ARTICULOSDEPOSITO _itemSeleccion = new Entities.Procedures.H_ARTICULOSDEPOSITO();
                List<Entities.Procedures.H_ARTICULOSDEPOSITO> _ItemsArtDep = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();

                _ItemsArtDep = _prod.ItemList();

                var q = (dynamic)null;

                q = (from item in _ItemsArtDep
                     where item.rubro.Contains(_Rubro.ToString()) //FILTRO POR RUBRO
                     select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();


                //Limpia el combo
                this.comboBoxProductos.SuspendLayout();
                this.comboBoxProductos.DataSource = null;
                this.comboBoxProductos.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione un Artículo>";
                _itemSeleccion.art_codgen = "0";

                //_ItemsArtDep = _prod.ItemList();
                q.Insert(0, _itemSeleccion);
                //Carga el combo
                this.comboBoxProductos.DisplayMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_DESCGEN;
                this.comboBoxProductos.ValueMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_CODGEN;
                this.comboBoxProductos.DataSource = q;

                this.comboBoxProductos.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void CargarProveedor()
        {
            try
            {
                BLL.Procedures._H_PROVEEDORES _prov = new BLL.Procedures._H_PROVEEDORES();
                _prov.ItemList("EGES");
                Entities.Procedures._H_PROVEEDORES _itemSeleccion = new Entities.Procedures._H_PROVEEDORES();

                //Limpia el combo
                this.comboBoxProveed.SuspendLayout();
                this.comboBoxProveed.DataSource = null;
                this.comboBoxProveed.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.pro_razsoc = "<Seleccione un Proveedor>";
                _itemSeleccion.pro_cod = "0";
                _prov.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxProveed.DisplayMember = BLL.Procedures._H_PROVEEDORES.ColumnNames.PRO_RAZSOC;
                this.comboBoxProveed.ValueMember = BLL.Procedures._H_PROVEEDORES.ColumnNames.PRO_COD;
                this.comboBoxProveed.DataSource = _prov.Result.ToArray();

                this.comboBoxProveed.ResumeLayout();
                this.comboBoxProveed.SelectedIndex = 0;



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
                if (this.comboBoxSubRubro.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxSubRubro, "Debe seleccionar un Rubro");
                    this.comboBoxSubRubro.Focus();
                    return false;
                }

                if (this.comboBoxProductos.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxProductos, "Debe seleccionar un Artículo");
                    this.comboBoxProductos.Focus();
                    return false;
                }

                if (this.comboBoxProveed.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxProveed, "Debe seleccionar un Proveedor");
                    this.comboBoxProveed.Focus();
                    return false;
                }

                if(this.textBoxArticuloProveed.Text == string.Empty)
                {
                    this.errorProvider1.SetError(this.textBoxArticuloProveed, "Debe ingresar un código");
                    this.textBoxArticuloProveed.Focus();
                    return false;

                }

                if (this.textBoxDescripcion.Text == string.Empty)
                {
                    this.errorProvider1.SetError(this.textBoxDescripcion, "Debe ingresar una Descripción");
                    this.textBoxDescripcion.Focus();
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
        private void Frm_EquivalenciaArticulosProveed_Load(object sender, EventArgs e)
            {
                //PERMISOS
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
                //FIN PERMISOS
                CargarSubRubros();
                CargarProveedor();
            }


        private void comboBoxSubRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubRubro.SelectedIndex > 0)
            {
                CargarArticulos(comboBoxSubRubro.SelectedValue.ToString());
            }
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProductos.SelectedIndex > 0)
                {
                    this.labelArticuloBejerman.Text = comboBoxProductos.SelectedValue.ToString();
                    this.labelDescripcionBejerman.Text = comboBoxProductos.Text.ToString();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBoxProveed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProveed.SelectedIndex > 0)
                {
                    _articulo = string.Empty;
                    //BUSCO SI ESTE ARTÍCULO YA TIENE CARGADO UNA EQUIVALENCIA
                    BLL.Procedures.EQUIVALENCIAARTICULOPROVEED _equi = new BLL.Procedures.EQUIVALENCIAARTICULOPROVEED();
                    if (_equi.ItemList(this.comboBoxProductos.SelectedValue.ToString(), this.comboBoxProveed.SelectedValue.ToString()).Count > 0)
                    {

                        this.textBoxArticuloProveed.Text = _equi.Resultset[0].articulo_proveed.ToString();
                        this.textBoxDescripcion.Text = _equi.Resultset[0].descripcionproveed.ToString();
                        _articulo = _equi.Resultset[0].articulo_proveed.ToString();
                    }
                    else
                    {
                        this.textBoxArticuloProveed.Text = string.Empty;
                        this.textBoxDescripcion.Text = string.Empty;
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
            this.Close();
        }

        private void textBoxArticuloProveed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxDescripcion.Focus();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaIngreso())
                {
                    BLL.Tables.COMEQUIVALENCIAARTICULOSPROVEED _equivalencia = new BLL.Tables.COMEQUIVALENCIAARTICULOSPROVEED();
                    Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED _item = new Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED();
                    _item.ARTICULO_ID = this.comboBoxProductos.SelectedValue.ToString(); //ARTICULO BEJERMAN
                    _item.ARTICULO_PROVEED = this.textBoxArticuloProveed.Text.ToString(); //ARTICULO DE ESTE PROVEEDOR
                    _item.DESCRIP_ARTICULO_PROVEED = this.textBoxDescripcion.Text.ToString(); //    DESCRIPCION DEL PROVEEDOR
                    _item.PROVEED_ID = this.comboBoxProveed.SelectedValue.ToString(); //CODIGO DE PROVEEDOR

                    if (_articulo != string.Empty)
                    {
                        //ESTE ARTICULO YA EXISTE, SOLO MODIFICO LOS DATOS-----
                        _equivalencia.Update(_item);
                    }
                    else
                    {
                        _equivalencia.Add(_item);

                    }
                    MessageBox.Show("Equivalencia se grabó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.comboBoxSubRubro.SelectedIndex = 0; // 01-06-2016 pedido POR MARIANO... PARA NO BORRAR LOS COMBOS
                    //this.comboBoxProductos.SelectedIndex = 0;
                    //this.comboBoxProveed.SelectedIndex = 0;
                    this.labelArticuloBejerman.Text = string.Empty;
                    this.labelDescripcionBejerman.Text = string.Empty;
                    this.textBoxArticuloProveed.Text = string.Empty;
                    this.textBoxDescripcion.Text = string.Empty;
                    _articulo = string.Empty;

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (_articulo != string.Empty && _articulo != null)
                {
                    DialogResult _result = MessageBox.Show("Está por eliminar esta equivalencia, desea continuar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (_result == System.Windows.Forms.DialogResult.OK)
                    {
                        BLL.Tables.COMEQUIVALENCIAARTICULOSPROVEED _elimina = new BLL.Tables.COMEQUIVALENCIAARTICULOSPROVEED();
                        Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED _item = new Entities.Tables.COMEQUIVALENCIAARTICULOSPROVEED();
                        _item.ARTICULO_ID = this.comboBoxProductos.SelectedValue.ToString(); //ARTICULO BEJERMAN
                        _item.PROVEED_ID = this.comboBoxProveed.SelectedValue.ToString(); //CODIGO DE PROVEEDOR

                        _elimina.Remove(_item);

                        MessageBox.Show("Equivalencia eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.comboBoxSubRubro.SelectedIndex = 0;
                        this.comboBoxProductos.SelectedIndex = 0;
                        this.comboBoxProveed.SelectedIndex = 0;
                        this.labelArticuloBejerman.Text = string.Empty;
                        this.labelDescripcionBejerman.Text = string.Empty;
                        this.textBoxArticuloProveed.Text = string.Empty;
                        this.textBoxDescripcion.Text = string.Empty;
                        _articulo = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("No existe equivalencia para eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxArticuloProveed_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  CONVIERTO A MAYUSCULAS MIENTRAS ESCRIBE
            if (char.IsLower(e.KeyChar))
            {
                textBoxArticuloProveed.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;

            }
        }

        private void textBoxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  CONVIERTO A MAYUSCULAS MIENTRAS ESCRIBE
            if (char.IsLower(e.KeyChar))
            {
                textBoxDescripcion.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;

            }
        }

        #endregion

    }
}
