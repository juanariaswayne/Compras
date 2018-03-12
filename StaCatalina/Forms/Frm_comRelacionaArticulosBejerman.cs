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
    public partial class Frm_comRelacionaArticulosBejerman : StaCatalina.Plantilla
    {
        #region variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;
        private enum Col_Articulos
        {
            SELECCIONA=0,
            ID,
            CODPROVISORIO,
            CODEMP,
            REQUERIMIENTO_ID,
            NROITEM,
            PENDIENTEBEJERMAN,
            DESCRIPCION,
            PRESENTACION,
            UNIMED,
            MARCA,
            EMBALAJE,
            CANTIDAD,
            COD_BEJERMAN,
            NO_ASOC,
            USUARIO_ID,
            EMAIL
        }

        List<Entities.Procedures._H_ARTICULOS> _articulosBejerman = new List<Entities.Procedures._H_ARTICULOS>();

        #endregion

        #region Funciones
        public Frm_comRelacionaArticulosBejerman()
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

        private void TraerArticulosProvisorios(string _codEmp)
        {
            try
            {
                BLL.Tables.COMARTICULOSPROVISORIOS _provisorio = new BLL.Tables.COMARTICULOSPROVISORIOS();
                _provisorio.WhereParameter.Add(DAL.Tables.COMARTICULOSPROVISORIOS.ColumnEnum.codEmp, DAL.SqlEnums.OperandEnum.Equal, _codEmp);
                _provisorio.WhereParameter.Add(DAL.SqlEnums.ConjunctionEnum.AND, DAL.Tables.COMARTICULOSPROVISORIOS.ColumnEnum.pendienteEnBejerman, DAL.SqlEnums.OperandEnum.Equal, 1);
                _provisorio.OrderByParameter.Add(DAL.Tables.COMARTICULOSPROVISORIOS.ColumnEnum.requerimiento_id);
              
                this.bindingSourceArt.DataSource = _provisorio.Items();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarArticulosBejerman(string codEmp)
        {
            try
            {
                BLL.Procedures._H_ARTICULOS _art = new BLL.Procedures._H_ARTICULOS();
                _articulosBejerman = _art.ItemList(codEmp);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #endregion

        private void comboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string _codEmp = this.comboBoxEmpresa.SelectedValue.ToString();
                TraerArticulosProvisorios(_codEmp);

                _articulosBejerman.Clear();
                CargarArticulosBejerman(_codEmp);


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Frm_comRelacionaArticulosBejerman_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            Clases.Empresa.CargarEmpresas(comboBoxEmpresa);

            this.comboBoxEmpresa.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();

            CargarArticulosBejerman(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
            //FIN PERMISOS
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool _selecciono = false;
                BLL.Procedures.ACTULIZAARTICULOSPROVISORIOS _actualiza = new BLL.Procedures.ACTULIZAARTICULOSPROVISORIOS();
                string _codEmp;
                int _requerimiento_id;
                int _nroItem;
                string _articulo;

                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridView1.Rows[i].Cells[(int)Col_Articulos.SELECCIONA] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value) && dataGridView1.Rows[i].Cells[(int)Col_Articulos.COD_BEJERMAN].Value != null)
                    {
                        //ANTES DE ENVIAR A GRABAR -- VERTIFICO QUE ESTE ARTICULO EXISTA EN BEJERMAN ---
                        var q = (dynamic)null;
                        q = (from item in _articulosBejerman
                            where item.art_codgen.ToString().Trim().ToUpper() == dataGridView1.Rows[i].Cells[(int)Col_Articulos.COD_BEJERMAN].Value.ToString().Trim().ToUpper()
                            select item).ToList<Entities.Procedures._H_ARTICULOS>();
                        if (q.Count > 0)
                        {
                            _selecciono = true;
                            _codEmp = dataGridView1.Rows[i].Cells[(int)Col_Articulos.CODEMP].Value.ToString();
                            _requerimiento_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[(int)Col_Articulos.REQUERIMIENTO_ID].Value.ToString());
                            _nroItem = Convert.ToInt32(dataGridView1.Rows[i].Cells[(int)Col_Articulos.NROITEM].Value.ToString());
                            _articulo = dataGridView1.Rows[i].Cells[(int)Col_Articulos.COD_BEJERMAN].Value.ToString().Trim().ToUpper();

                            _actualiza.Items(_codEmp, _requerimiento_id, _nroItem, _articulo);
                        }
                        else
                        {
                            MessageBox.Show("El artículo: " + dataGridView1.Rows[i].Cells[(int)Col_Articulos.COD_BEJERMAN].Value.ToString().Trim().ToUpper() + " No existe en Bejerman", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                    }


                }

                if (_selecciono)
                {
                    MessageBox.Show("Requerimiento actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string _codEmpresa = this.comboBoxEmpresa.SelectedValue.ToString();
                    TraerArticulosProvisorios(_codEmpresa);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un Articulo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    //Enviar Mail
                    Entities.Tables.COMARTICULOSPROVISORIOS _item = new Entities.Tables.COMARTICULOSPROVISORIOS();
                    BLL.Tables.COMARTICULOSPROVISORIOS _Actu = new BLL.Tables.COMARTICULOSPROVISORIOS();

                    _item.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.ID].Value);
                    _item.CODPROVISORIO = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.CODPROVISORIO].Value);
                    _item.CODEMP = dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.CODEMP].Value.ToString();
                    _item.REQUERIMIENTO_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.REQUERIMIENTO_ID].Value);
                    _item.NROITEM = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.NROITEM].Value);
                    _item.PENDIENTEENBEJERMAN = 0;
                    _item.DESCRIPCION = dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.DESCRIPCION].Value.ToString();
                    _item.PRESENTACION = dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.PRESENTACION].Value.ToString();
                    _item.UNIMED = dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.UNIMED].Value.ToString();
                    _item.MARCA = dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.MARCA].Value.ToString();
                    _item.EMBALAJE = dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.EMBALAJE].Value.ToString();
                    _item.CANTIDAD = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.CANTIDAD].Value);
                    _item.USUARIO_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.USUARIO_ID].Value);
                    if (_item.USUARIO_MAIL == null)
                    {
                        _item.USUARIO_MAIL = "";
                    }
                    else
                    {
                        _item.USUARIO_MAIL = dataGridView1.Rows[e.RowIndex].Cells[(int)Col_Articulos.EMAIL].Value.ToString();
                    }
                    

                    _Actu.UpdateItem(_item);

                    string _codEmp = this.comboBoxEmpresa.SelectedValue.ToString();
                    TraerArticulosProvisorios(_codEmp);

                    _articulosBejerman.Clear();
                    CargarArticulosBejerman(_codEmp);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }   
}
