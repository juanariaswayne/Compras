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
    public partial class Frm_AutorizacionReqInterno : StaCatalina.Plantilla
    {
        #region Variables
        private enum Col_RequerimientoCab

        {
            CODEMP = 0,
            NRO_REQUERIMIENTO,
            FECHA_DE_PEDIDO,
            SECTOR_REQUERIMIENTO,
            USUARIO,
            OBSERVACIONES

        }

        private enum Col_RequerimientoItem
        {
            CODEMPRESA = 0,
            ARTICULO_ID,
            NRO_REQUERIMIENTO,
            NRO_ITEM,
            AUTORIZA,
            NO_AUTORIZA,
            ARTICULO,
            UNIDAD_DE_MEDIDA,
            CANTIDAD,
            MARCA,
            FECHA_DE_ENTREGA
        }

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private List<Entities.Procedures.REQUERIMIENTOS_INERNO_DISPONIBLES> _itemDisponibles = new List<Entities.Procedures.REQUERIMIENTOS_INERNO_DISPONIBLES>();
        //LISTA DE SECTORES QUE PUEDE AUTORIZAR UN USUARIO
        private List<Entities.Tables.COMUSUARIOAUTORIZAREQUERIMIENTOS> _sectoresAutoriza = new List<Entities.Tables.COMUSUARIOAUTORIZAREQUERIMIENTOS>();

        CultureInfo culture = new CultureInfo("en-US");
        #endregion

#region Funciones

        public Frm_AutorizacionReqInterno()
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

        private void SectoresAutoriza(int _usuario)
        {
            try
            {
                BLL.Tables.COMUSUARIOAUTORIZAREQUERIMIENTOS _sector = new BLL.Tables.COMUSUARIOAUTORIZAREQUERIMIENTOS();
                _sector.WhereParameter.Add(DAL.Tables.COMUSUARIOAUTORIZAREQUERIMIENTOS.ColumnEnum.Id_Usuario, DAL.SqlEnums.OperandEnum.Equal, _usuario);
                Entities.Tables.COMUSUARIOAUTORIZAREQUERIMIENTOS _itemSector;
                foreach (Entities.Tables.COMUSUARIOAUTORIZAREQUERIMIENTOS item in _sector.ItemList())
                {
                    _itemSector = new Entities.Tables.COMUSUARIOAUTORIZAREQUERIMIENTOS();
                    _itemSector.ID_USUARIO = item.ID_USUARIO;
                    _itemSector.SECTORREQUERIMIENTO = item.SECTORREQUERIMIENTO;
                    _sectoresAutoriza.Add(_itemSector);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TraeRequerimientosPendientes()

        {

            try
            {
                BLL.Procedures.REQUERIMIENTOS_INERNO_DISPONIBLES _detalle = new BLL.Procedures.REQUERIMIENTOS_INERNO_DISPONIBLES();
                //traigo todos los requerimientos de todos los sectores y despues fitro el sector de este usuario
                _itemDisponibles = _detalle.ItemList(1);
                //var q = (dynamic)null;
                //q = (from item in _itemDisponibles
                //          where item.sectorrequerimiento_id == Clases.Usuario.UsuarioLogeado.Id_Sector
                //         select item).ToList<Entities.Procedures.REQUERIMIENTOS_DISPONIBLES>();

                // ***** SOLO MUESTRA LOS REQUERIMIENTOS DE LOS SECTORES QUE PUEDE AUTORIZAR ESTE USUARIO Y REQ DE LA EMPRESA LOGEADA ************
                var q = from requeDisponibles in _itemDisponibles
                        join _sector in _sectoresAutoriza on requeDisponibles.sectorrequerimiento_id equals _sector.SECTORREQUERIMIENTO
                        where requeDisponibles.codemp == Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString()
                        select requeDisponibles;

                //fin Filtro por sector

                this.dataGridViewReqInternoCab.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.REQUERIMIENTOS_INERNO_DISPONIBLES item in q)
                {
                    indice = dataGridViewReqInternoCab.Rows.Add();
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_RequerimientoCab.CODEMP].Value = item.codemp;//CODIGO DE EMPRESA
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_RequerimientoCab.NRO_REQUERIMIENTO].Value = item.requerimiento_id; //TTRAE ID DE REQUERIMIENTO
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_RequerimientoCab.FECHA_DE_PEDIDO].Value = item.fecha.ToShortDateString(); //TRAE FECHA DE PEDIDO
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_RequerimientoCab.SECTOR_REQUERIMIENTO].Value = item.descripcion;//TRAE DESCRIPCION DEL SECTOR
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_RequerimientoCab.USUARIO].Value = item.usuario;//USUARIO
                    dataGridViewReqInternoCab.Rows[indice].Cells[(int)Col_RequerimientoCab.OBSERVACIONES].Value = item.obs;//TRAE OBSERVACION

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion

        private void Frm_AutorizacionReqInterno_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            //TRAIGO TODOS LOS SECTORES QUE PUEDE AUTORIZAR ESTE USUARIO
            SectoresAutoriza(Clases.Usuario.UsuarioLogeado.id_usuario_Logeado);

            //FIN PERMISOS
            this.Text = "Autorización de Requerimientos Internos Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();

            TraeRequerimientosPendientes();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {

            try
            {


                Entities.Tables.COMREQUERIMIENTOINTERNOITEM _itemRequerimiento = new Entities.Tables.COMREQUERIMIENTOINTERNOITEM();
                List<Entities.Tables.COMREQUERIMIENTOINTERNOITEM> _items = new List<Entities.Tables.COMREQUERIMIENTOINTERNOITEM>();
                Entities.Tables.COMREQUERIMIENTOINTERNO _itemCab = new Entities.Tables.COMREQUERIMIENTOINTERNO();
                BLL.Tables.COMREQUERIMIENTOINTERNO _auto = new BLL.Tables.COMREQUERIMIENTOINTERNO();

                Boolean _selecciono = false;
                for (int i = 0; i < this.dataGridViewReqInternoItem.Rows.Count; i++)
                {
                    _itemRequerimiento = new Entities.Tables.COMREQUERIMIENTOINTERNOITEM();

                    DataGridViewCheckBoxCell cellSelecion = dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.AUTORIZA] as DataGridViewCheckBoxCell;
                    DataGridViewCheckBoxCell cellSelecionNoAuto = dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.NO_AUTORIZA] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value) || Convert.ToBoolean(cellSelecionNoAuto.Value))
                    {
                        _itemRequerimiento.CODEMP = dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.CODEMPRESA].Value.ToString();  //Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
                        _itemRequerimiento.REQUERIMIENTO_ID = Convert.ToInt32(dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.NRO_REQUERIMIENTO].Value);
                        _itemRequerimiento.NROITEM = Convert.ToInt32(dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.NRO_ITEM].Value);
                        _itemRequerimiento.ARTICULO_ID = dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.ARTICULO_ID].Value.ToString();
                        _itemRequerimiento.UNIMED = dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.UNIDAD_DE_MEDIDA].Value.ToString();
                        _itemRequerimiento.CANTIDAD = Convert.ToDecimal(dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.CANTIDAD].Value.ToString(), culture);
                        _itemRequerimiento.FECHAENTREGA = Convert.ToDateTime(dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.FECHA_DE_ENTREGA].Value.ToString());
                        _itemRequerimiento.MARCA = (dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.MARCA].Value == null) ? string.Empty : dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.MARCA].Value.ToString();
                        //DATOS PARA LA CABECERA
                        _itemCab.REQUERIMIENTO_ID = Convert.ToInt32(dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.NRO_REQUERIMIENTO].Value);
                        _itemCab.CODEMP = dataGridViewReqInternoItem.Rows[i].Cells[(int)Col_RequerimientoItem.CODEMPRESA].Value.ToString();
                      

                        //VERIFICA SI ESTA AUTORIZADO
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            _selecciono = true;
                            _itemRequerimiento.NIVELAUT_ID = 2;

                        }
                        //VERIFICA SI LO ESTA RECHAZANDO
                        if (Convert.ToBoolean(cellSelecionNoAuto.Value))
                        {
                            _selecciono = true;
                            _itemRequerimiento.NIVELAUT_ID = 3;

                        }

                        _items.Add(_itemRequerimiento);

                    }
                }
                //PASO EL USAURIO LOGEADO
                _itemCab.USUARIOAUTORIZA = Clases.Usuario.UsuarioLogeado.usuario_Logeado.ToString();
                if (_selecciono)
                {
                    _auto.AutorizaRequerimiento(_items, _itemCab);

                    MessageBox.Show("Se Guardó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TraeRequerimientosPendientes();
                    dataGridViewReqInternoItem.Rows.Clear();
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

        private void dataGridViewReqInternoCab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BLL.Procedures.TRAEREQUERIMIENTOINTERNOITEM _item = new BLL.Procedures.TRAEREQUERIMIENTOINTERNOITEM();

                this.dataGridViewReqInternoItem.Rows.Clear();
                int indice;
                int _requerimiento_id = Convert.ToInt32(dataGridViewReqInternoCab.Rows[e.RowIndex].Cells[(int)Col_RequerimientoCab.NRO_REQUERIMIENTO].Value);
                string _codEmpresa = dataGridViewReqInternoCab.Rows[e.RowIndex].Cells[(int)Col_RequerimientoCab.CODEMP].Value.ToString();
               
                foreach (Entities.Procedures.TRAEREQUERIMIENTOINTERNOITEM item in _item.ItemList(_codEmpresa, _requerimiento_id, 1))
                {
                    indice = dataGridViewReqInternoItem.Rows.Add();
                    dataGridViewReqInternoItem.Rows[indice].Cells[(int)Col_RequerimientoItem.CODEMPRESA].Value = item.codemp.ToString();//DESCRIPCION DEL ARTICULO
                    dataGridViewReqInternoItem.Rows[indice].Cells[(int)Col_RequerimientoItem.ARTICULO].Value = item.art_descgen;//DESCRIPCION DEL ARTICULO
                    dataGridViewReqInternoItem.Rows[indice].Cells[(int)Col_RequerimientoItem.NRO_REQUERIMIENTO].Value = item.requerimiento_id;//DESCRIPCION DEL ARTICULO
                    dataGridViewReqInternoItem.Rows[indice].Cells[(int)Col_RequerimientoItem.ARTICULO_ID].Value = item.articulo_id; //ID DEL ARTICULO
                    dataGridViewReqInternoItem.Rows[indice].Cells[(int)Col_RequerimientoItem.CANTIDAD].Value = item.cantidad.ToString().Replace(",", "."); //TRAE CANTIDAD
                    dataGridViewReqInternoItem.Rows[indice].Cells[(int)Col_RequerimientoItem.FECHA_DE_ENTREGA].Value = item.fechaentrega.ToShortDateString();//FECHA DE ENTREGA
                    dataGridViewReqInternoItem.Rows[indice].Cells[(int)Col_RequerimientoItem.UNIDAD_DE_MEDIDA].Value = item.unimed;//TRAE UNIMED
                    dataGridViewReqInternoItem.Rows[indice].Cells[(int)Col_RequerimientoItem.MARCA].Value = item.Marca;//MARCA
                    dataGridViewReqInternoItem.Rows[indice].Cells[(int)Col_RequerimientoItem.NRO_ITEM].Value = item.nroitem;//TRAE NRO ITEM                

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewReqInternoCab_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewReqInternoCab.IsCurrentCellDirty)
                dataGridViewReqInternoCab.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewReqInternoItem_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewReqInternoItem.IsCurrentCellDirty)
                dataGridViewReqInternoItem.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void checkBoxSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewReqInternoItem.Rows.Count > 0)
            {

                if (this.checkBoxSeleccionar.Checked)
                {
                    foreach (DataGridViewRow item in dataGridViewReqInternoItem.Rows)
                    {
                        item.Cells[(int)Col_RequerimientoItem.AUTORIZA].Value = 1;
                    }
                }

                else
                {

                    foreach (DataGridViewRow item in dataGridViewReqInternoItem.Rows)
                    {
                        item.Cells[(int)Col_RequerimientoItem.AUTORIZA].Value = 0;
                    }
                }

            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
