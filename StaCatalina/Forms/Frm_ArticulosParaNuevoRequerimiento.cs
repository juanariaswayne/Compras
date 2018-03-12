using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace StaCatalina.Forms
{
    public partial class Frm_ArticulosParaNuevoRequerimiento : Form
    {
        #region Variables
            public Entities.Tables.COMORDENCOMPRA _OrdenCompra;
            List<Entities.Procedures.TRAEMARCAARTICULOS> _itemsMarca = new List<Entities.Procedures.TRAEMARCAARTICULOS>();
            public List<nuevosArticulos> _itemReq = new List<nuevosArticulos>();
            CultureInfo culture = new CultureInfo("en-US");
        public class nuevosArticulos
            {
            private string _codEmp;
            private string _articulo;
            private string _descripcion;
            private string _uniMed;
            private decimal _cantidad;
            private string _marca;
            public string CodEmp
            {
                get
                {
                    return _codEmp;
                }

                set
                {
                    _codEmp = value;
                }
            }

            public string Articulo
            {
                get
                {
                    return _articulo;
                }

                set
                {
                    _articulo = value;
                }
            }

            public string Descripcion
            {
                get
                {
                    return _descripcion;
                }

                set
                {
                    _descripcion = value;
                }
            }

            public string UniMed
            {
                get
                {
                    return _uniMed;
                }

                set
                {
                    _uniMed = value;
                }
            }

            public decimal Cantidad
            {
                get
                {
                    return _cantidad;
                }

                set
                {
                    _cantidad = value;
                }
            }

            public string Marca
            {
                get
                {
                    return _marca;
                }

                set
                {
                    _marca = value;
                }
            }
        }


            private enum Col_Detalle
            {
                CODEMP,
                INCLUIR,
                ARTICULO,
                DESCRIPCION,
                UNIMED,
                CANTIDAD,
                MARCA

            }
        #endregion

        #region Funciones
        public Frm_ArticulosParaNuevoRequerimiento()
        {
            InitializeComponent();
        }

        private void CargarMarca(string _articulo, DataGridViewComboBoxCell comboboxColumnSector)
        {
            try
            {


                Entities.Procedures.TRAEMARCAARTICULOS _itemSeleccion = new Entities.Procedures.TRAEMARCAARTICULOS();
                List<Entities.Procedures.TRAEMARCAARTICULOS> _miMarca = new List<Entities.Procedures.TRAEMARCAARTICULOS>();

                var q = (dynamic)null;

                _miMarca = (from m in _itemsMarca
                            where m.articulo_id.ToString().Trim() == _articulo.ToString().Trim()
                            select m).ToList<Entities.Procedures.TRAEMARCAARTICULOS>();


                comboboxColumnSector.DataSource = null;
                comboboxColumnSector.Items.Clear();

                //Carga el item de Seleccion
                _itemSeleccion.marca = "<Sin Definir>";// (_miMarca.Count > 0) ? "<Seleccione una Marca>" : "<Sin Definir>";
                _itemSeleccion.articulo_id = "0";
                _miMarca.Insert(0, _itemSeleccion);

                //Carga el combo
                comboboxColumnSector.DataSource = _miMarca.ToArray();
                comboboxColumnSector.DisplayMember = BLL.Procedures.TRAEMARCAARTICULOS.ColumnNames.MARCA;
                comboboxColumnSector.ValueMember = BLL.Procedures.TRAEMARCAARTICULOS.ColumnNames.ARTICULO_ID;
                comboboxColumnSector.Value = "<Sin Definir>";//(_miMarca.Count > 0) ? "<Seleccione una Marca>" : "<Sin Definir>"; ;

                //FIN CARGO COMBO TIPO RECLAMO

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void TraerMarcasArticulos()
        {
            try
            {
                BLL.Procedures.TRAEMARCAARTICULOS _marca = new BLL.Procedures.TRAEMARCAARTICULOS();
                _itemsMarca = _marca.ItemList("EGES"); //LAS MARCAS SE CARGAN CON LA EMPRESA EGESAC.. LOS ARTICULOS SON LOS MISMOS

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarArticulos()
        {
            try
            {
                this.dataGridViewDetalleReqDisponibles.Rows.Clear();
                int indice;
                foreach ( nuevosArticulos item in _itemReq)
                {
                    indice = dataGridViewDetalleReqDisponibles.Rows.Add();
                    dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_Detalle.CODEMP].Value = item.CodEmp; //CODEMP
                    dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_Detalle.ARTICULO].Value = item.Articulo; // ARTICULO
                    dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_Detalle.DESCRIPCION].Value = item.Descripcion; // DESCRIPCION
                    dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_Detalle.UNIMED].Value = item.UniMed; //  UNIDAD MEDIDA
                    dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_Detalle.CANTIDAD].Value = item.Cantidad.ToString().Replace(",", "."); // CANTIDAD
                    dataGridViewDetalleReqDisponibles.Rows[indice].Cells[(int)Col_Detalle.MARCA].Value = item.Marca; // MARCA

                    ////CARGO LA MARCA DE ESTE ARTICULO
                    //DataGridViewRow row = dataGridViewDetalleReqDisponibles.Rows[indice];
                    //DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Detalle.MARCA] as DataGridViewComboBoxCell;

                    //CargarMarca(item.Articulo, comboboxColumnSector);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarLugaresEntrega(string _CodEmp)
        {
            try
            {
                //también cargo los RUBROS por única vez
                BLL.Procedures.TRAELUGARESENTREGA _rubro = new BLL.Procedures.TRAELUGARESENTREGA();
                List<Entities.Procedures.TRAELUGARESENTREGA> _rubroItem = new List<Entities.Procedures.TRAELUGARESENTREGA>();
                Entities.Procedures.TRAELUGARESENTREGA _itemSeleccion = new Entities.Procedures.TRAELUGARESENTREGA();

                _rubroItem = _rubro.ItemList(_CodEmp);//le paso la colección de Lugares

                //Limpia el combo
                this.comboBoxLugarEntrega.SuspendLayout();
                this.comboBoxLugarEntrega.DataSource = null;
                this.comboBoxLugarEntrega.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione un lugar>";
                _itemSeleccion.lugar_id = 0;
                _rubroItem.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxLugarEntrega.DisplayMember = BLL.Tables.COMLUGARENTREGA.ColumnNames.DESCRIPCION;
                this.comboBoxLugarEntrega.ValueMember = BLL.Tables.COMLUGARENTREGA.ColumnNames.LUGAR_ID;
                this.comboBoxLugarEntrega.DataSource = _rubroItem;
                this.comboBoxLugarEntrega.SelectedIndex = 0;

                this.comboBoxLugarEntrega.ResumeLayout();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        #endregion

        #region Eventos
        private void Frm_ArticulosParaNuevoRequerimiento_Load(object sender, EventArgs e)
        {
            TraerMarcasArticulos();
            CargarLugaresEntrega(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);
            CargarArticulos();

            comboBoxLugarEntrega.SelectedValue = _OrdenCompra.SECTORENTREGA_ID;

        }

        #endregion

        private void dataGridViewDetalleReqDisponibles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewDetalleReqDisponibles.IsCurrentCellDirty)
                dataGridViewDetalleReqDisponibles.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (comboBoxLugarEntrega.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar un Lugar de Entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //
                List<Entities.Tables.COMARTICULOSPROVISORIOS> _ItemsProvisorios = new List<Entities.Tables.COMARTICULOSPROVISORIOS>(); //LO DEFINO... PERO NO LO USO, VA EN NULL
                Entities.Tables.COMREQUERIMIENTO _ReqCabecera = new Entities.Tables.COMREQUERIMIENTO();
                BLL.Tables.COMREQUERIMIENTO _ReqCab = new BLL.Tables.COMREQUERIMIENTO();
                Entities.Tables.COMREQUERIMIENTOITEM _ReqItem = new Entities.Tables.COMREQUERIMIENTOITEM();
                // BLL.Tables.COMREQUERIMIENTOITEM _ReqIte = new BLL.Tables.COMREQUERIMIENTOITEM();
                List<Entities.Tables.COMREQUERIMIENTOITEM> _ItemsReq = new List<Entities.Tables.COMREQUERIMIENTOITEM>();
                //CultureInfo culture = new CultureInfo("en-US");
                string _empresa =Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
               

                _ReqCabecera.FECHA = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                _ReqCabecera.ESTADO_ID = 1; //Ojo ver que valor se envia despues 
                _ReqCabecera.OBS = this.textBoxObs.Text.Trim();
                _ReqCabecera.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                _ReqCabecera.SECTORREQUERIMIENTO_ID = Clases.Usuario.UsuarioLogeado.Id_Sector; // Ojo ver como se envia Despues
                _ReqCabecera.SECTORENTREGA_ID = Convert.ToInt32(comboBoxLugarEntrega.SelectedValue);

                for (int i = 0; i < this.dataGridViewDetalleReqDisponibles.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_Detalle.INCLUIR] as DataGridViewCheckBoxCell;//incluir
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        if (dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != string.Empty && dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value != null)
                        {
                            _ReqItem = new Entities.Tables.COMREQUERIMIENTOITEM();
                            
                            //_ReqItem.COMEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;                                                
                            _ReqItem.ARTICULO_ID = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_Detalle.ARTICULO].Value.ToString();
                            _ReqItem.UNIMED = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_Detalle.UNIMED].Value.ToString();
                            _ReqItem.CANTIDAD = Convert.ToDecimal(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_Detalle.CANTIDAD].Value.ToString(), culture);
                            //if (dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_Detalle.FENTREGA].Value == null)
                            //{
                            _ReqItem.FECHAENTREGA = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            //}
                            //else
                            //{
                            //    _ReqItem.FECHAENTREGA = Convert.ToDateTime(Convert.ToDateTime(dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_Detalle.FENTREGA].Value));
                            //}
                            //VERIFICO SI SELECCIONO UNA MARCA
                            if (dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_Detalle.MARCA].Value != null && dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_Detalle.MARCA].Value != "")
                            {
                                _ReqItem.MARCA = dataGridViewDetalleReqDisponibles.Rows[i].Cells[(int)Col_Detalle.MARCA].EditedFormattedValue.ToString();
                            }

                            _ReqItem.NIVELAUT_ID = 1; //ojo ver como se envia despues
                            //SI LA CANTIDAD ES CERO.. NO LO GRABO.
                            if (_ReqItem.CANTIDAD > 0)
                                _ItemsReq.Add(_ReqItem); //Meto en la coleccion todos los elementos de la grilla

                        }
                    }
                }

                //PUEDE SER QUE SOLO SE CARGUE ARTICULOS PROVISORIOS.... SE ENVIA LA CABECERA DEL REQUERIMIENTO Y LOS ITEMS DE PROVISORIOS
                if (_ItemsReq.Count > 0 )
                {
                    int _nroReqGenerado = 0;
                    //LLAMO A LA FUNCION QUE GUARDA CABECERA E ITEMS
                    if (_ReqCab.AddItem(_ReqCabecera, _ItemsReq, _empresa, _ItemsProvisorios,ref _nroReqGenerado))
                    {

                        MessageBox.Show("Se generó el Requerimiento Nro.: " + _nroReqGenerado, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewDetalleReqDisponibles.Rows.Clear();
                        this.textBoxObs.Text = "";
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Error al grabar Requerimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewDetalleReqDisponibles.Rows.Count > 0)
            {
                if (this.checkBoxSeleccionar.Checked)
                {


                    foreach (DataGridViewRow item in dataGridViewDetalleReqDisponibles.Rows)
                    {
                        item.Cells[(int)Col_Detalle.INCLUIR].Value = 1;
                    }
                }
                else
                {

                    foreach (DataGridViewRow item in dataGridViewDetalleReqDisponibles.Rows)
                    {
                        item.Cells[(int)Col_Detalle.INCLUIR].Value = 0;
                    }

                }


            }
        }
    }
}
