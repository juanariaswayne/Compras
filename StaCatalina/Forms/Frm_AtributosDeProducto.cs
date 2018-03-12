using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
namespace StaCatalina.Forms
{
    public partial class Frm_AtributosDeProducto : StaCatalina.Plantilla
    {
        #region Variables

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private Int32 _updateProducto;
        List <Entities.Procedures._H_ARTICULOS> _ItemsArticulos = new List<Entities.Procedures._H_ARTICULOS>();
        List<Entities.Procedures.H_ARTICULOSDEPOSITO> _ItemsArtDep = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        #endregion

        #region Funciones
        public Frm_AtributosDeProducto()
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

        private void CargarProductos(string _subRubro)
        {
            try
            {
                BLL.Procedures.H_ARTICULOSDEPOSITO _prod = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                
                Entities.Procedures.H_ARTICULOSDEPOSITO _itemSeleccion = new Entities.Procedures.H_ARTICULOSDEPOSITO();

                _ItemsArtDep = _prod.ItemList();

                var q = (dynamic)null;

                q = (from item in _ItemsArtDep
                     where item.subrubro.Contains(_subRubro.ToString() )
                     orderby item.art_descgen
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
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarTodosProductos()
        {
            try
            {
                BLL.Procedures.H_ARTICULOSDEPOSITO _prod = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                Entities.Procedures.H_ARTICULOSDEPOSITO _itemSeleccion = new Entities.Procedures.H_ARTICULOSDEPOSITO();

                _ItemsArtDep = _prod.ItemList();

                var q = (dynamic)null;

                q = (from item in _ItemsArtDep orderby item.art_descgen
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

        private void CargarCodigos()
        {
            try
            {
                BLL.Procedures.H_ARTICULOSDEPOSITO _prod = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                Entities.Procedures.H_ARTICULOSDEPOSITO _itemSeleccion = new Entities.Procedures.H_ARTICULOSDEPOSITO();

                _ItemsArtDep = _prod.ItemList();

                var q = (dynamic)null;

                q = (from item in _ItemsArtDep
                     select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();


                //Limpia el combo
                this.comboBoxCodigosProd.SuspendLayout();
                this.comboBoxCodigosProd.DataSource = null;
                this.comboBoxCodigosProd.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "";
                _itemSeleccion.art_codgen = "0";

                //_ItemsArtDep = _prod.ItemList();
                q.Insert(0, _itemSeleccion);
                //Carga el combo
                this.comboBoxCodigosProd.DisplayMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_CODGEN;
                this.comboBoxCodigosProd.ValueMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_CODGEN;
                this.comboBoxCodigosProd.DataSource = q;

                this.comboBoxProductos.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarSubRubros()
        {
            try
            {
                BLL.Procedures.SUBRUBROARTICULOS _rubroItem = new BLL.Procedures.SUBRUBROARTICULOS();
                Entities.Procedures.SUBRUBROARTICULOS _itemSeleccion = new Entities.Procedures.SUBRUBROARTICULOS();
                _rubroItem.Items("EGES");  //SIEMPRE TRAIGO ARTICULOS DE LA EMPRESA EGES
                //Limpia el combo
                this.comboBoxSubrubro.SuspendLayout();
                this.comboBoxSubrubro.DataSource = null;
                this.comboBoxSubrubro.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.da2_desc = "<Seleccione SubRubro>";
                _itemSeleccion.da2_cod = "0";
                _rubroItem.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSubrubro.DisplayMember = BLL.Procedures.SUBRUBROARTICULOS.ColumnNames.DA2_DESC;
                this.comboBoxSubrubro.ValueMember = BLL.Procedures.SUBRUBROARTICULOS.ColumnNames.DA2_COD;
                this.comboBoxSubrubro.DataSource = _rubroItem.Result.ToArray();
                this.comboBoxSubrubro.SelectedIndex = 0;

                this.comboBoxSubrubro.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarProductosBejerman()
        {
            try
            {
                BLL.Procedures._H_ARTICULOS _prod = new BLL.Procedures._H_ARTICULOS();
                Entities.Procedures._H_ARTICULOS _itemSeleccion = new Entities.Procedures._H_ARTICULOS();


                //Limpia el combo

                this.comboBoxProductosBejerman.SuspendLayout();
                this.comboBoxProductosBejerman.DataSource = null;
                this.comboBoxProductosBejerman.Items.Clear();



                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione un Artículo>";
                _itemSeleccion.art_codgen = "0";

                _ItemsArticulos = _prod.ItemList("EGES"); //Carga la lista para llenar el combo;
                _ItemsArticulos.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxProductosBejerman.DisplayMember = BLL.Procedures._H_ARTICULOS.ColumnNames.DESCRIPCION;
                this.comboBoxProductosBejerman.ValueMember = BLL.Procedures._H_ARTICULOS.ColumnNames.ART_CODGEN;
                this.comboBoxProductosBejerman.DataSource = _ItemsArticulos;

                this.comboBoxProductosBejerman.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarUniMed()
        {
            try
            {
                BLL.Procedures.UNIDADESDEMEDIDAS _unidad = new BLL.Procedures.UNIDADESDEMEDIDAS();
                Entities.Procedures.UNIDADESDEMEDIDAS _itemSeleccion = new Entities.Procedures.UNIDADESDEMEDIDAS();
                _unidad.ItemList(); //Carga la lista para llenar el combo

                //Limpia el combo
                this.comboBoxUniMedPrimaria.SuspendLayout();
                this.comboBoxUniMedPrimaria.DataSource = null;
                this.comboBoxUniMedPrimaria.Items.Clear();
                this.comboBoxUniMedSecundaria.SuspendLayout();
                this.comboBoxUniMedSecundaria.DataSource = null;
                this.comboBoxUniMedSecundaria.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "Seleccione una Unidad";
                _itemSeleccion.unimed = "0";
                _unidad.Result.Insert(0, _itemSeleccion);

                //Carga el combo Unimed Primaria
                this.comboBoxUniMedPrimaria.DisplayMember = BLL.Procedures.UNIDADESDEMEDIDAS.ColumnNames.DESCRIPCION;
                this.comboBoxUniMedPrimaria.ValueMember = BLL.Procedures.UNIDADESDEMEDIDAS.ColumnNames.UNIMED;
                this.comboBoxUniMedPrimaria.DataSource = _unidad.Result.ToArray();

                this.comboBoxUniMedPrimaria.ResumeLayout();

                //Carga el combo Unimed Secundaria
                this.comboBoxUniMedSecundaria.DisplayMember = BLL.Procedures.UNIDADESDEMEDIDAS.ColumnNames.DESCRIPCION;
                this.comboBoxUniMedSecundaria.ValueMember = BLL.Procedures.UNIDADESDEMEDIDAS.ColumnNames.UNIMED;
                this.comboBoxUniMedSecundaria.DataSource = _unidad.Result.ToArray();

                this.comboBoxUniMedSecundaria.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarSubCuenta()
        {
            try
            {
                BLL.Tables.USR_ARTICULOSUBCUENTA _cuenta = new BLL.Tables.USR_ARTICULOSUBCUENTA();
                Entities.Tables.USR_ARTICULOSUBCUENTA _itemSeleccion = new Entities.Tables.USR_ARTICULOSUBCUENTA();
                _cuenta.ItemList(); //Carga la lista para llenar el combo

                //Limpia el combo
                this.comboBoxSubCuenta.SuspendLayout();
                this.comboBoxSubCuenta.DataSource = null;
                    
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "Sin Subcuenta";
                _itemSeleccion.SUBCUENTA = 0;
                _cuenta.Result.Insert(0, _itemSeleccion);

                //Carga el combo Unimed Primaria
                this.comboBoxSubCuenta.DisplayMember = BLL.Tables.USR_ARTICULOSUBCUENTA.ColumnNames.DESCRIPCION;
                this.comboBoxSubCuenta.ValueMember = BLL.Tables.USR_ARTICULOSUBCUENTA.ColumnNames.SUBCUENTA;
                this.comboBoxSubCuenta.DataSource = _cuenta.Result.ToArray();

                this.comboBoxUniMedPrimaria.ResumeLayout();
                comboBoxSubCuenta.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxTolerancia_KeyPress(object sender, KeyPressEventArgs e)
                 {
                     CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
                     if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                         e.Handled = false;
                     else
                         e.Handled = true;
                 }
       
        private void textBoxStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
         {
             CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
             if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                 e.Handled = false;
             else
                 e.Handled = true;
         }
        
        private void textBoxStockMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void textBoxFactorConversion_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;

        }

        private Boolean VerificarDatos() 
        {
            try
            {
                if (this.comboBoxProductos.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxProductos, "Debe Seleccionar un Producto");
                    this.comboBoxProductos.Focus();
                    return false;
                }
                else
                {
                    this.errorProvider1.Clear();
                }
              
                //if (this.textBoxStockMinimo.Text.Trim() == string.Empty)
                //{
                //    this.errorProvider1.SetError(this.textBoxStockMinimo, "Este campo no puede estar vacio");
                //    this.textBoxStockMinimo.Focus();
                //    return false;
                //}
                //else
                //{
                //    this.errorProvider1.Clear();
                //}
                //if (this.textBoxStockMaximo.Text.Trim() == string.Empty)
                //{
                //    this.errorProvider1.SetError(this.textBoxStockMaximo, "Este campo no puede estar vacio");
                //    this.textBoxStockMaximo.Focus();
                //    return false;
                //}
                if (this.comboBoxUniMedPrimaria.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxUniMedPrimaria, "Debe seleccionar una unidad de medida");
                    this.comboBoxUniMedPrimaria.Focus();
                    return false;
                }
                else
                {
                    this.errorProvider1.Clear();
                }
                if (this.textBoxFactorConversion.Text.Trim() != string.Empty)
                {
                    if(this.comboBoxUniMedSecundaria.SelectedIndex == 0 && this.comboBoxUniMedPrimaria.SelectedIndex == 0)
                        {
                            this.errorProvider1.SetError(this.comboBoxUniMedSecundaria, "Debe seleccionar una unidad de medida");
                            this.comboBoxUniMedSecundaria.Focus();
                            return false;
                        }                
                    
                }
                else
                {
                    this.errorProvider1.Clear();
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

        private void Frm_AtributosDeProducto_Load(object sender, EventArgs e)
                {

                    //PERMISOS
                    MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                    menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                    this.OperacionesDelUsuario();
                    //FIN PERMISOS

                    CargarSubRubros();
                    CargarUniMed();
                    CargarTodosProductos();
                    CargarCodigos();

                    this.comboBoxProductosBejerman.Hide();

                    CargarSubCuenta();

                }

        
         private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            
               try 
               {
                   if (VerificarDatos())
                     {
                           {
                                Entities.Tables.STKARTICULOS _item = new Entities.Tables.STKARTICULOS();
                                BLL.Tables.STKARTICULOS _articulo = new BLL.Tables.STKARTICULOS();

                                CultureInfo culture = new CultureInfo("en-US");

                                _item.CODEMP = "EGES";//  SIEMPRE VA CON UNA SOLA EMPRESA ****OJO NO CAMBIAR *******************    Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
                                _item.ARTICULO_ID = this.comboBoxProductos.SelectedValue.ToString();
                                _item.TOLERANCIAINGSTOCK = (this.textBoxTolerancia.Text == string.Empty) ? 0: Convert.ToDecimal(this.textBoxTolerancia.Text,culture);
                                _item.STOCKMINIMO = (this.textBoxStockMinimo.Text == string.Empty) ? 0: Convert.ToDecimal(this.textBoxStockMinimo.Text, culture);
                                _item.STOCKMAXIMO = (this.textBoxStockMaximo.Text == string.Empty) ? 0: Convert.ToDecimal(this.textBoxStockMaximo.Text, culture);
                                _item.UNIMEDPPAL = this.comboBoxUniMedPrimaria.SelectedValue.ToString();
                                _item.UNIMEDSEC = this.comboBoxUniMedSecundaria.SelectedValue.ToString();
                                _item.CODIGOSUBCUENTA = Convert.ToInt32(comboBoxSubCuenta.SelectedValue);
                                _item.MOSTRARENREQUERIMIENTO = (this.checkBoxNoRequerimiento.Checked) ? false : true;
                                if (this.checkBoxVa_a_Stock.Checked)
                                {
                                    _item.VAASTOCK = 1;
                                }
                                else
                                {
                                    _item.VAASTOCK = 0;
                                }

                                if (this.textBoxFactorConversion.Text.Trim() == string.Empty)
                                {
                                    _item.FACTORCONVERSION = 0;
                                }
                                else
                                {
                                    _item.FACTORCONVERSION = Convert.ToDecimal(this.textBoxFactorConversion.Text);
                                }

                                if (this.comboBoxUniMedSecundaria.SelectedIndex == 0)
                                {
                                    _item.UNIMEDSEC = "0";
                                }
                                else
                                {
                                    _item.UNIMEDSEC = this.comboBoxUniMedSecundaria.SelectedValue.ToString();
                                }

                                if (this.checkBoxTrazable.Checked)
                                {
                                    _item.TRAZABLE = true;
                                }
                                else
                                {
                                    _item.TRAZABLE = false;
                                }
                                if(checkBoxReceta.Checked)
                                {
                                    _item.LLEVARECETA = true;
                                }
                                else
                                {
                                     _item.LLEVARECETA = false;
                                }
                               //LLEVA VENCIMIENTO
                               if(checkBoxVencimiento.Checked)
                                {
                                    _item.LLEVAVENCIMIENTO = true;
                                }
                               else
                                {
                                    _item.LLEVAVENCIMIENTO = false;
                                }

                                //Actualizo los datos Ingresados Si la variable UpadteProducto es 1
                                if (_updateProducto == 1)
                                {
                                    _articulo.Update(_item);
                                    this.textBoxTolerancia.Text = string.Empty;
                                    this.textBoxStockMaximo.Text = string.Empty;
                                    this.textBoxStockMinimo.Text = string.Empty;
                                    this.textBoxFactorConversion.Text = string.Empty;
                                    checkBoxReceta.Checked = false;
                                    this.comboBoxProductos.SelectedIndex = 0;
                                    this.comboBoxCodigosProd.SelectedIndex = 0;                                   
                                    this.checkBoxVa_a_Stock.Checked = false;
                                    this.comboBoxUniMedPrimaria.SelectedIndex = 0;
                                    this.comboBoxUniMedSecundaria.SelectedIndex = 0;
                                    comboBoxSubCuenta.SelectedIndex = 0;
                                    this.checkBoxNoRequerimiento.Checked = false;
                                    this.checkBoxTrazable.Checked = false;
                                    this.checkBoxVencimiento.Checked = false;      
                                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    _updateProducto = 0;
                                }
                                else
                                {
                                    _articulo.Add(_item);
                                    this.textBoxTolerancia.Text = string.Empty;
                                    this.textBoxStockMaximo.Text = string.Empty;
                                    this.textBoxStockMinimo.Text = string.Empty;
                                    this.textBoxFactorConversion.Text = string.Empty;
                                    checkBoxReceta.Checked = false;
                                    this.comboBoxProductos.SelectedIndex = 0;
                                    this.comboBoxCodigosProd.SelectedIndex = 0;
                                    this.checkBoxVa_a_Stock.Checked = false;
                                    this.comboBoxUniMedPrimaria.SelectedIndex = 0;
                                    this.comboBoxUniMedSecundaria.SelectedIndex = 0;
                                    comboBoxSubCuenta.SelectedIndex = 0;
                                    this.checkBoxNoRequerimiento.Checked = false;
                                    this.checkBoxTrazable.Checked = false;
                                    this.checkBoxVencimiento.Checked = false;
                                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    _updateProducto = 0;
                                }
                            }                          
                            
                      }
                }
                  

             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
               }

          private void toolStripButtonNew_Click(object sender, EventArgs e)
            {
                this.textBoxTolerancia.Text = string.Empty;
                this.textBoxStockMinimo.Text = string.Empty;
                this.textBoxStockMaximo.Text = string.Empty;
                this.textBoxFactorConversion.Text = string.Empty;
                this.checkBoxVa_a_Stock.Checked = false;
                this.comboBoxUniMedPrimaria.SelectedIndex = 0;
                this.comboBoxUniMedSecundaria.SelectedIndex = 0;
                comboBoxSubCuenta.SelectedIndex = 0;
                this.checkBoxNoRequerimiento.Checked = false;
                this.checkBoxTrazable.Checked = false;
                checkBoxReceta.Checked = false;
                checkBoxVencimiento.Checked = false;

        }
            
        private void checkBoxIncorporarArt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.checkBoxIncorporarArt.Checked)
                {
                    this.comboBoxProductosBejerman.Show();
                    CargarProductosBejerman();
                }
                else
                {
                    this.comboBoxProductosBejerman.Hide();
                }
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


    private void textBoxFactoraCorreccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }





        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTolerancia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxStockMinimo.Focus();
        }

        private void textBoxStockMinimo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxStockMaximo.Focus();
        }

        private void textBoxStockMaximo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxUniMedPrimaria.Focus();
        }

        private void comboBoxUniMedPrimaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUniMedPrimaria.SelectedIndex > 0)
                this.comboBoxUniMedSecundaria.Focus();
        }

        private void comboBoxUniMedSecundaria_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxUniMedSecundaria.SelectedIndex > 0)
                this.textBoxFactorConversion.Focus();
        }

        private void textBoxFactorConversion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxSubCuenta.Focus();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSubrubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubrubro.SelectedIndex > 0)
            {
                CargarProductos(comboBoxSubrubro.SelectedValue.ToString());


            }

        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (comboBoxProductos.SelectedIndex != 0)
                {
                    BLL.Tables.STKARTICULOS _DescArt = new BLL.Tables.STKARTICULOS();
                    _DescArt.ItemList("EGES", this.comboBoxProductos.SelectedValue.ToString());

                    if (_DescArt.Result.Count > 0) //Verifico si tiene Algo cargado el producto
                    {
                        _updateProducto = 1;
                        this.textBoxTolerancia.Text = _DescArt.Resultset[0].TOLERANCIAINGSTOCK.ToString().Replace(",", ".");
                        this.textBoxStockMinimo.Text = _DescArt.Resultset[0].STOCKMINIMO.ToString().Replace(",", ".");
                        this.textBoxStockMaximo.Text = _DescArt.Resultset[0].STOCKMAXIMO.ToString().Replace(",", ".");
                        comboBoxSubCuenta.SelectedValue = _DescArt.Resultset[0].CODIGOSUBCUENTA;
                        this.comboBoxUniMedPrimaria.SelectedValue = _DescArt.Resultset[0].UNIMEDPPAL;
                        this.checkBoxNoRequerimiento.Checked = (_DescArt.Resultset[0].MOSTRARENREQUERIMIENTO) ? false : true;
                        if (_DescArt.Resultset[0].UNIMEDSEC != null)
                        {
                            this.comboBoxUniMedSecundaria.SelectedValue = _DescArt.Resultset[0].UNIMEDSEC;
                            this.textBoxFactorConversion.Text = _DescArt.Resultset[0].FACTORCONVERSION.ToString();
                        }


                        if (_DescArt.Resultset[0].VAASTOCK == 1)
                        {
                            this.checkBoxVa_a_Stock.Checked = true;

                        }

                        else
                        {
                            this.checkBoxVa_a_Stock.Checked = false;
                        }

                        if (_DescArt.Resultset[0].TRAZABLE)
                        {
                            this.checkBoxTrazable.Checked = true;
                        }
                        else
                        {
                            this.checkBoxTrazable.Checked = false;
                        }
                        checkBoxReceta.Checked = (_DescArt.Resultset[0].LLEVARECETA) ? true : false;
                        checkBoxVencimiento.Checked = (_DescArt.Resultset[0].LLEVAVENCIMIENTO) ? true : false;
                       
                    }


                    else // Vacio los campos en caso de no tener Valores
                    {
                        _updateProducto = 0;
                        this.textBoxTolerancia.Text = string.Empty;
                        this.textBoxStockMinimo.Text = string.Empty;
                        this.textBoxStockMaximo.Text = string.Empty;
                        this.textBoxFactorConversion.Text = string.Empty;
                        checkBoxReceta.Checked = false;
                        this.checkBoxVa_a_Stock.Checked = false;
                        this.comboBoxUniMedPrimaria.SelectedIndex = 0;
                        this.comboBoxUniMedSecundaria.SelectedIndex = 0;
                        comboBoxSubCuenta.SelectedIndex = 0;
                        this.checkBoxNoRequerimiento.Checked = false;
                        this.checkBoxTrazable.Checked = false;
                        textBoxTolerancia.Focus();
                        checkBoxVencimiento.Checked = false;
                        checkBoxReceta.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBoxCodigosProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxProductos.SelectedValue = comboBoxCodigosProd.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
