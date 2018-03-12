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
    public partial class Frm_comAutorizaCotizaciones : StaCatalina.Plantilla
    {
        #region Variables

            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;
            private List<Entities.Procedures.TRAEREQUERIMIENTOITEMSCOTIZADOS> _itemsReq = new List<Entities.Procedures.TRAEREQUERIMIENTOITEMSCOTIZADOS>();
            private string _articuloSeleccionado = string.Empty;
           
            private enum Col_GridDetalle
            {
                ARTICULO = 0,
                DESCRIPCION,
                UNIDAD,
                CANTIDAD,

            }

            private enum Col_GridCotizado
            {
            AUTORIZA = 0,
            NROCOTIZACION,
            EMPRESA,
            ARTICULO,
            DESCRIPCION,
            UNIMED,
            CANTIDAD,
            PRECIO,
            EMBALAJE,
            MARCA,
            PROVEED_ID,
            RAZONSOCIAL,
            FECHA,
            OBS
    
            }

        CultureInfo culture = new CultureInfo("en-US");
        #endregion

        #region Funciones
        public Frm_comAutorizaCotizaciones()
            {
                InitializeComponent();
            }
        //PERMISOS
        private void OperacionesDelUsuario()
        {
            try
            {
                 if (!escritura) { this.toolStripButtonAutoriza.Enabled = false; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //FIN PERMISOS
        private void TraerRequerimientosDisponibles(string _codEmp, string _subrubro)
            {
                try
                {
                    BLL.Procedures.TRAEREQUERIMIENTOITEMSCOTIZADOS _Req = new BLL.Procedures.TRAEREQUERIMIENTOITEMSCOTIZADOS();
                    this._itemsReq.Clear();
                    this._itemsReq = _Req.ItemList(_codEmp, _subrubro); //traigo todos los requerimientos que estan cotizados y NO finalizados

                    ////MUESTRO EL LA GRILLA LOS REQUERIMIENTOS AGRUPADOS POR CÓDIGO DE PRODUCTO Y SUMO LAS CANTIDADES
                    //var groupsForIterate = _itemsReq.GroupBy(x =>
                    //    new { x.articulo_id, x.art_descgen, x.unimed });


                    this.dataGridRequerimientosCotizados.Rows.Clear();
                    int indice;
                    //RECORRO LA LISTA AGRUPADA
                    foreach (var categ in _itemsReq)
                    {
                        indice = dataGridRequerimientosCotizados.Rows.Add();
                        dataGridRequerimientosCotizados.Rows[indice].Cells[(int)Col_GridDetalle.ARTICULO].Value = categ.articulo_id;
                        dataGridRequerimientosCotizados.Rows[indice].Cells[(int)Col_GridDetalle.DESCRIPCION].Value = categ.art_descgen;
                   
                    }

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void TraeCotizaciones()
            {
                try
                {
                    //AHORA RECUPERO LAS COTIZACIONES ///
                    BLL.Procedures.ARTICULOCOTIZADO _cotizado = new BLL.Procedures.ARTICULOCOTIZADO();
                  
                    string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
                    this.dataGridViewCotizaciones.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures.ARTICULOCOTIZADO item in _cotizado.ItemList(_articuloSeleccionado, _empresa))
                    {
                        indice = dataGridViewCotizaciones.Rows.Add();
                        dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.NROCOTIZACION].Value = item.nrocotizacion;
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.EMPRESA].Value = item.codemp;
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.ARTICULO].Value = item.articulo_id;
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.DESCRIPCION].Value = item.art_descgen;
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.UNIMED].Value = item.unimed;
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.CANTIDAD].Value = item.cantidad.ToString().Replace(",",".");
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.PRECIO].Value = item.precio.ToString().Replace(",",".");
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.EMBALAJE].Value = item.embalaje;
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.MARCA].Value = item.marca;
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.PROVEED_ID].Value = item.proveed_id;
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.RAZONSOCIAL].Value = item.razonsocial;
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.FECHA].Value = item.fechacotizacion;
                    dataGridViewCotizaciones.Rows[indice].Cells[(int)Col_GridCotizado.OBS].Value = item.obs;
                }

                    //this.bindingSourceCotiz.DataSource = _cotizado.ItemList(_articuloSeleccionado, _empresa);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void CargarSubRubros(string _codEmp)
        {
            try
            {
                //también cargo los SUB RUBROS por única vez, SOLO TRAIGO LOS QUE EL USUARIO PUEDE VER
                BLL.Procedures.SUBRUBROARTICULOS _subrubro = new BLL.Procedures.SUBRUBROARTICULOS();
                List<Entities.Procedures.SUBRUBROARTICULOS> _rubroItem = new List<Entities.Procedures.SUBRUBROARTICULOS>();
                Entities.Procedures.SUBRUBROARTICULOS _itemSeleccion = new Entities.Procedures.SUBRUBROARTICULOS();
                _rubroItem = _subrubro.ItemList(_codEmp);

                //Limpia el combo
                this.comboBoxSubRubro.SuspendLayout();
                this.comboBoxSubRubro.DataSource = null;
                this.comboBoxSubRubro.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.da2_desc = "<Seleccione un Sub SubRubro>";
                _itemSeleccion.da2_cod = "0";
                _rubroItem.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSubRubro.DisplayMember = BLL.Procedures.SUBRUBROARTICULOS.ColumnNames.DA2_DESC;
                this.comboBoxSubRubro.ValueMember = BLL.Procedures.SUBRUBROARTICULOS.ColumnNames.DA2_COD;
                this.comboBoxSubRubro.DataSource = _rubroItem;
                this.comboBoxSubRubro.SelectedIndex = 0;

                this.comboBoxSubRubro.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion

        #region Eventos
        private void dataGridViewCotizaciones_CurrentCellDirtyStateChanged(object sender, EventArgs e)
            {
                if (dataGridViewCotizaciones.IsCurrentCellDirty)
                    dataGridViewCotizaciones.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }


        #endregion

            private void Frm_comAutorizaCotizaciones_Load(object sender, EventArgs e)
            {
                //PERMISOS
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
                //FIN PERMISOS
                this.comboBoxEmpresa.SelectedValue =  Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();
                string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
                CargarSubRubros(_empresa); //CARGO LOS SUBRUBROS

            }

            private void dataGridRequerimientosCotizados_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                // recupero el detalle del requerimiento
                try
                {
                    //guardo el articulo... lo necesito para guardar la cotizacion
                    _articuloSeleccionado = dataGridRequerimientosCotizados.Rows[e.RowIndex].Cells[(int)Col_GridDetalle.ARTICULO].Value.ToString();
                     TraeCotizaciones();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


            private void dataGridViewCotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                // dataGridViewCotizaciones.Rows[e.RowIndex].Cells[(int)Col_GridCotizado.AUTORIZA].Value != dataGridViewCotizaciones.Rows[e.RowIndex].Cells[(int)Col_GridCotizado.AUTORIZA].Value;
                //CON ESTE FOR, SOLO ME PERMITE SELECCIONAR UN SOLO CHECK PARA EL MISMO ARTICULO Y EMPRESA
                //RECUPERO LA EMPRESA Y PRODUCTO
                string _codEmp;
                string _codProd;
                string _codEmp2;
                string _codProd2;
                _codEmp = dataGridViewCotizaciones.Rows[this.dataGridViewCotizaciones.CurrentCell.RowIndex].Cells[(int)Col_GridCotizado.EMPRESA].Value.ToString();
                _codProd = dataGridViewCotizaciones.Rows[this.dataGridViewCotizaciones.CurrentCell.RowIndex].Cells[(int)Col_GridCotizado.ARTICULO].Value.ToString();

                foreach (DataGridViewRow fila in this.dataGridViewCotizaciones.Rows)
                {
                    _codEmp2 = fila.Cells[(int)Col_GridCotizado.EMPRESA].Value.ToString();
                    _codProd2 = fila.Cells[(int)Col_GridCotizado.ARTICULO].Value.ToString();

                    if (fila != this.dataGridViewCotizaciones.Rows[this.dataGridViewCotizaciones.CurrentCell.RowIndex] && _codEmp == _codEmp2 && _codProd == _codProd2)
                    {
                        fila.Cells[(int)Col_GridCotizado.AUTORIZA].Value = 0;
                    }
                }
            }

        private void comboBoxSubRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxSubRubro.SelectedIndex > 0)
            {
                string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
                this.dataGridViewCotizaciones.Rows.Clear();
                TraerRequerimientosDisponibles(_empresa, this.comboBoxSubRubro.SelectedValue.ToString());
            }
        }

        private void comboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
            this.dataGridRequerimientosCotizados.Rows.Clear();
            this.dataGridViewCotizaciones.Rows.Clear();
            CargarSubRubros(_empresa); //CARGO LOS SUBRUBROS
        }

        private void toolStripButtonAutoriza_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Procedures.AUTORIZACOTIZACION _autoriza = new BLL.Procedures.AUTORIZACOTIZACION();
                string codEmp;
                int NroCotiz;
                string proveed;
                string articulo;
                string uniMed;
                decimal cantidad;
                decimal precio;
                DateTime fecha;
                string usuario;
                string embalaje;
                string marca;
                int autorizado;
                int finalizado;

                for (int i = 0; i < this.dataGridViewCotizaciones.Rows.Count; i++)
                {
                    codEmp = dataGridViewCotizaciones.Rows[i].Cells[(int)Col_GridCotizado.EMPRESA].Value.ToString();
                    NroCotiz = Convert.ToInt32(dataGridViewCotizaciones.Rows[i].Cells[(int)Col_GridCotizado.NROCOTIZACION].Value.ToString());
                    proveed = dataGridViewCotizaciones.Rows[i].Cells[(int)Col_GridCotizado.PROVEED_ID].Value.ToString();
                    articulo = dataGridViewCotizaciones.Rows[i].Cells[(int)Col_GridCotizado.ARTICULO].Value.ToString();
                    uniMed = dataGridViewCotizaciones.Rows[i].Cells[(int)Col_GridCotizado.UNIMED].Value.ToString();
                    cantidad = Convert.ToDecimal(dataGridViewCotizaciones.Rows[i].Cells[(int)Col_GridCotizado.CANTIDAD].Value.ToString(),culture);
                    precio = Convert.ToDecimal(dataGridViewCotizaciones.Rows[i].Cells[(int)Col_GridCotizado.PRECIO].Value.ToString(),culture);
                    fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString().ToString());
                    usuario = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                    embalaje = dataGridViewCotizaciones.Rows[i].Cells[(int)Col_GridCotizado.EMBALAJE].Value.ToString();
                    marca = dataGridViewCotizaciones.Rows[i].Cells[(int)Col_GridCotizado.MARCA].Value.ToString();

                    DataGridViewCheckBoxCell cellSelecion = dataGridViewCotizaciones.Rows[i].Cells[(int)Col_GridCotizado.AUTORIZA] as DataGridViewCheckBoxCell;
                    autorizado = (Convert.ToBoolean(cellSelecion.Value)) ? 1 : 0;
                    //FINALIZO TODO.. ES DECIR NO DEJO PENDIENTE ESTE ITEM.... PARA QUE NO ME LO TRAIGA LA PROXIMA VEZ
                    //ES DECIR.. AUTORIZO LOS QUE ESTAN MARCADOS Y FINALIZO TODO EL RESTO DE LAS COTIZACIONES DE ESTE ARTICULO
                    finalizado = 1;

                    _autoriza.ItemList(codEmp, NroCotiz, proveed, articulo, uniMed, cantidad, precio, fecha, usuario, embalaje, marca, autorizado, finalizado);
                }
                MessageBox.Show("La cotización se autorizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
                TraerRequerimientosDisponibles(_empresa, this.comboBoxSubRubro.SelectedValue.ToString());
                this.dataGridViewCotizaciones.Rows.Clear();
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
