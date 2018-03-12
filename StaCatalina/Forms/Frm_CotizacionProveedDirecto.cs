using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;
namespace StaCatalina.Forms
{
    public partial class Frm_CotizacionProveedDirecto : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        
       // private List<Entities.Procedures.ARTICULOSENVIADOSACOTIZAR> _itemsReq = new List<Entities.Procedures.ARTICULOSENVIADOSACOTIZAR>();
        private  int  _numCotizacionSeleccionado= 0;
        CultureInfo culture = new CultureInfo("en-US");
        private enum Col_GridDetalle
        {
            COTIZACION=0,
            CODEMP,
            PROVEED_ID,
            RAZONSOCIAL,
            FECHA
        
        }

        private enum Col_GridCotizado
        {
            ARTICULO_ID=0,
            DESCRIPCION,
            OBS,
            NROCOTIZACION,
            EMPRESA,
            PROVEED_ID,
            RAZONSOCIAL,
            EMBALAJE,
            MARCA,
            FECHA,
            UNIMED,
            CANTIDAD,
            PRECIO
       
        

        }

        #endregion

        #region Funciones
        public Frm_CotizacionProveedDirecto()
            {
                InitializeComponent();
            }

            //PERMISOS
            private void OperacionesDelUsuario()
            {
                try
                {
                   // if (!escritura) { this.toolStripButtonSave.Enabled = false; }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //FIN PERMISOS

            private void TraerArticulosEnviadosACotizar(string _empresa)
            {
                try
                {
                
                BLL.Procedures.COTIZACIONESPENDIENTESDEINGRESAR _Req = new BLL.Procedures.COTIZACIONESPENDIENTESDEINGRESAR();
                this.dataGridRequerimientosACotizar.DataSource = _Req.ItemList(_empresa);
                   
                    //this._itemsReq.Clear();
                    //this._itemsReq = _Req.ItemList(_empresa); //TRAIGO LOS ARTICULO QUE ENVIE A COTIZAR.. PARA INGRESAR LOS PRECIOS, solo lo que NO estan finalizados

                    ////MUESTRO EL LA GRILLA LOS REQUERIMIENTOS AGRUPADOS POR CÓDIGO DE PRODUCTO Y SUMO LAS CANTIDADES
                    //var groupsForIterate = _itemsReq.GroupBy(x =>
                    //    new { x.articulo_id, x.art_descgen, x.unimed });


                    //this.dataGridRequerimientosACotizar.Rows.Clear();
                    //int indice;
                    ////RECORRO LA LISTA AGRUPADA
                    //foreach (var categ in groupsForIterate)
                    //{
                    //    indice = dataGridRequerimientosACotizar.Rows.Add();
                    //    dataGridRequerimientosACotizar.Rows[indice].Cells[(int)Col_GridDetalle.ARTICULO].Value = categ.Key.articulo_id;
                    //    dataGridRequerimientosACotizar.Rows[indice].Cells[(int)Col_GridDetalle.DESCRIPCION].Value = categ.Key.art_descgen;
                    //    dataGridRequerimientosACotizar.Rows[indice].Cells[(int)Col_GridDetalle.UNIDAD].Value = categ.Key.unimed;
                    //    //ES LA FORMA DE SUMAR LAS CANTIDADES DE UN MISMO PRODUCTO
                    //    dataGridRequerimientosACotizar.Rows[indice].Cells[(int)Col_GridDetalle.CANTIDAD].Value = categ.Sum(x => x.cantidad);
                    //}

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            private void TraeCotizaciones(int _numCotizacion ,string _codEmp)
            {
                //AHORA RECUPERO LAS COTIZACIONES ///
                BLL.Procedures.ARTICULOSSEGUNCOTIZACION _cotizado = new BLL.Procedures.ARTICULOSSEGUNCOTIZACION();
            this.dataGridViewCotizado.Rows.Clear();
            int indice;
            foreach (Entities.Procedures.ARTICULOSSEGUNCOTIZACION item in _cotizado.ItemList(_numCotizacion, _codEmp))
            {
                indice = dataGridViewCotizado.Rows.Add();
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.ARTICULO_ID].Value = item.articulo_id; //ARTICULO
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.DESCRIPCION].Value = item.art_descgen; //DESCRIPCION
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.OBS].Value = item.obs; //obs
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.NROCOTIZACION].Value = item.nrocotizacion; //cotizacion
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.EMPRESA].Value = item.embalaje; //EMPRESA
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.PROVEED_ID].Value = item.proveed_id; //PROVEEDOR
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.RAZONSOCIAL].Value = item.razonsocial; //RAZON SOCIAL
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.EMBALAJE].Value = item.embalaje; //EMBALAJE
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.MARCA].Value = item.marca; //MARCA
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.FECHA].Value = item.fechacotizacion; //FECHA COTIZ
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.UNIMED].Value = item.unimed; //UNI MED
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.CANTIDAD].Value =item.cantidad.ToString().Replace(",","."); //CANTIDAD
                dataGridViewCotizado.Rows[indice].Cells[(int)Col_GridCotizado.PRECIO].Value = item.precio.ToString().Replace(",", "."); //PRECIO
            }
                               

        }

            private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
            {
                //!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46) // Si no es numerico y si no es espacio EL 46 ES EL PUNTO
                {
                    // Invalidar la accion
                    e.Handled = true;
                    // Enviar el sonido de beep de windows
                    System.Media.SystemSounds.Beep.Play();
                }
            }
        #endregion

        #region Eventos
        private void Frm_CotizacionProveedDirecto_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //FIN PERMISOS
            Clases.Empresa.CargarEmpresas(comboBoxEmpresa);
            this.comboBoxEmpresa.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();
            string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
            TraerArticulosEnviadosACotizar(_empresa);

            }

            private void dataGridRequerimientosACotizar_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                // recupero el detalle del artículo cotrizado
                try
                {
                    _numCotizacionSeleccionado =Convert.ToInt32( dataGridRequerimientosACotizar.Rows[e.RowIndex].Cells[(int)Col_GridDetalle.COTIZACION].Value.ToString());
                    string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
                    TraeCotizaciones(_numCotizacionSeleccionado,_empresa);
                                       
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            
            }

        private void comboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
           string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
            int _index = this.comboBoxEmpresa.SelectedIndex;
            if (Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != _empresa.Trim() && Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != "AMBA")
            {
                MessageBox.Show("Ud. no está autorizado a operar con esta empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBoxEmpresa.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                return;
            }
            else
            {
                TraerArticulosEnviadosACotizar(_empresa);
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewCotizado.Rows.Count > 0)
                {
                    BLL.Procedures.INGRESACOTIZACIONARTICULOEMPRESA _cotizaArt = new BLL.Procedures.INGRESACOTIZACIONARTICULOEMPRESA();

                    for (int i = 0; i < this.dataGridViewCotizado.Rows.Count; i++)
                    {

                        string _codEmp = this.comboBoxEmpresa.SelectedValue.ToString();
                        int _nroCotizacion = Convert.ToInt32(this.dataGridViewCotizado.Rows[i].Cells[(int)Col_GridCotizado.NROCOTIZACION].Value);
                        string _Proveed = this.dataGridViewCotizado.Rows[i].Cells[(int)Col_GridCotizado.PROVEED_ID].Value.ToString();
                        string _articulo_id = this.dataGridViewCotizado.Rows[i].Cells[(int)Col_GridCotizado.ARTICULO_ID].Value.ToString();
                        string _uniMed = this.dataGridViewCotizado.Rows[i].Cells[(int)Col_GridCotizado.UNIMED].Value.ToString();
                        decimal _cantidad = Convert.ToDecimal(this.dataGridViewCotizado.Rows[i].Cells[(int)Col_GridCotizado.CANTIDAD].Value.ToString(),culture);
                        decimal _precio = Convert.ToDecimal(this.dataGridViewCotizado.Rows[i].Cells[(int)Col_GridCotizado.PRECIO].Value.ToString(),culture);
                        DateTime _fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        string _usuario = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                        string _embalaje = this.dataGridViewCotizado.Rows[i].Cells[(int)Col_GridCotizado.EMBALAJE].Value.ToString();
                        string _marca = this.dataGridViewCotizado.Rows[i].Cells[(int)Col_GridCotizado.MARCA].Value.ToString();

                        _cotizaArt.Items(_codEmp, _nroCotizacion, _Proveed, _articulo_id, _uniMed, _cantidad, _precio, _fecha, _usuario, _embalaje, _marca);
                    }

                    MessageBox.Show("Cotización ingresada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
                    TraerArticulosEnviadosACotizar(_empresa);

                }
                else
                {
                    MessageBox.Show("Debe ingresar la menos una cotización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCotizado_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iColumn = dataGridViewCotizado.CurrentCell.ColumnIndex;
            if (iColumn == (int)Col_GridCotizado.CANTIDAD || iColumn == (int)Col_GridCotizado.PRECIO)
            {
                TextBox txt = e.Control as TextBox;
                txt.KeyPress += OnlyNumbers_KeyPress;
            }
        }

        private void dataGridViewCotizado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewCotizado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewCotizado.IsCurrentCellDirty)
                dataGridViewCotizado.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewCotizado_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridViewCotizado.Columns[(int)Col_GridCotizado.PRECIO].DefaultCellStyle.Format = "N2";
        }

        #endregion



    }
}
