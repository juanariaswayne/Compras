using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Catalogos
{
    public partial class Frm_PerfilesPermisos : Plantilla
    {
        
        #region Variables
            private bool lectura;
            private Boolean escritura;
            private Boolean elimina;

            private enum col_Menues
            {
                MENU_ID = 0,
                DESCRIPCION,
                LECTURA,
                ESCRITURA,
                ELIMINACION

            }
        #endregion

        #region Funciones y Procedimientos
            public Frm_PerfilesPermisos()
            {
                InitializeComponent();
            }

            private void OperacionesDelUsuario()
            {
                try
                {
                    if (!escritura) { this.cmdGrabarUsuario.Enabled = false; }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            private void CargarPerfiles()
            {
                try
                {
                    BLL.Tables.TBL_PERFILES _perfiles = new BLL.Tables.TBL_PERFILES();
                    _perfiles.OrderByParameter.Add(DAL.Tables.TBL_PERFILES.ColumnEnum.DescripcionPerfil, DAL.SqlEnums.DirEnum.ASC);
                    _perfiles.ItemList();
                    Entities.Tables.TBL_PERFILES _itemSeleccion = new Entities.Tables.TBL_PERFILES();
                    //Limpia el combo
                    this.comboPerfiles.SuspendLayout();
                    this.comboPerfiles.DataSource = null;
                    this.comboPerfiles.Items.Clear();

                    //Carga el item de Seleccion.-
                    _itemSeleccion.NOMBREPERFIL = "<Seleccione un Perfil>";
                    _itemSeleccion.ID_PERFIL = 0;
                    _perfiles.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboPerfiles.ValueMember = "Id_Perfil";
                    this.comboPerfiles.DisplayMember = "NombrePerfil";
                    this.comboPerfiles.DataSource = _perfiles.Result;
                    this.comboPerfiles.ResumeLayout();
                    this.comboPerfiles.SelectedIndex = 0;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            private void CargarModulos()
            {
                try
                {
                    BLL.Tables.TBL_MENUS _menu = new BLL.Tables.TBL_MENUS();
                    _menu.WhereParameter.Add(DAL.Tables.TBL_MENUS.ColumnEnum.Id_MenuPadre, DAL.SqlEnums.OperandEnum.Equal, 0);
                    _menu.OrderByParameter.Add(DAL.Tables.TBL_MENUS.ColumnEnum.DescripcionMenu, DAL.SqlEnums.DirEnum.ASC);
                    _menu.ItemList();
                    Entities.Tables.TBL_MENUS _itemSeleccion = new Entities.Tables.TBL_MENUS();
                    //Limpia el combo
                    this.comboModulos.SuspendLayout();
                    this.comboModulos.DataSource = null;
                    this.comboModulos.Items.Clear();

                    //Carga el item de Seleccion.-
                    _itemSeleccion.DESCRIPCIONMENU = "<Seleccione un Módulo>";
                    _itemSeleccion.ID_MENU = 0;
                    _menu.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboModulos.ValueMember = "Id_Menu";
                    this.comboModulos.DisplayMember = "DescripcionMenu";
                    this.comboModulos.DataSource = _menu.Result;
                    this.comboModulos.ResumeLayout();
                    this.comboModulos.SelectedIndex = 0;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        #endregion
        private void Frm_PerfilesPermisos_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.CargarPerfiles();
            this.CargarModulos();
            this.OperacionesDelUsuario();
        }

        private void comboModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.comboModulos.SelectedIndex != 0 && this.comboPerfiles.SelectedIndex != 0)
                {
                    //MUESTRO LOS MENUES DE ESTE MODULO, O SEA LOS HIJOS CON SUS PERMISOS, MAS LOS MENUES QUE NO TIENE ASIGNADO DE ESTE MODULO
                    BLL.Procedures._OBTENERPERMISOS_PORMODULO _menu = new BLL.Procedures._OBTENERPERMISOS_PORMODULO();
                    this.dataGridMenues.Rows.Clear();
                    int indice;
                    foreach (Entities.Procedures._OBTENERPERMISOS_PORMODULO _menuhijo in _menu.ItemList(Convert.ToInt16(this.comboPerfiles.SelectedValue.ToString()), Convert.ToInt16(this.comboModulos.SelectedValue.ToString())))
                    {
                        indice = dataGridMenues.Rows.Add();
                        dataGridMenues.Rows[indice].Cells[(int)col_Menues.MENU_ID].Value = _menuhijo.id_menu.ToString();
                        dataGridMenues.Rows[indice].Cells[(int)col_Menues.DESCRIPCION].Value=_menuhijo.descripcionmenu.ToString();



                        dataGridMenues.Rows[indice].Cells[(int)col_Menues.LECTURA].Value = Convert.ToInt16(_menuhijo.lectura.ToString());
                        dataGridMenues.Rows[indice].Cells[(int)col_Menues.ESCRITURA].Value = Convert.ToInt16(_menuhijo.escritura.ToString());
                        dataGridMenues.Rows[indice].Cells[(int)col_Menues.ELIMINACION].Value = Convert.ToInt16(_menuhijo.eliminacion.ToString());
         
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdSalirUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmdGrabarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboPerfiles.SelectedIndex != 0 && this.comboModulos.SelectedIndex != 0)
                {
                    //RECORRO TODOS LO MENUES
                    BLL.Tables.TBL_PERFILESPERMISOS _permisos = new BLL.Tables.TBL_PERFILESPERMISOS();
                    Entities.Tables.TBL_PERFILESPERMISOS _itemPermisos = new Entities.Tables.TBL_PERFILESPERMISOS();

                    for (int i = 0; i < this.dataGridMenues.RowCount; i++)
                    {
                        _itemPermisos = new Entities.Tables.TBL_PERFILESPERMISOS();
                        _itemPermisos.ID_PERFIL = Convert.ToInt32(this.comboPerfiles.SelectedValue.ToString());
                        _itemPermisos.ID_MENU = Convert.ToInt32(dataGridMenues.Rows[i].Cells[(int)col_Menues.MENU_ID].Value);
                        _itemPermisos.LECTURA = Convert.ToBoolean (dataGridMenues.Rows[i].Cells[(int)col_Menues.LECTURA].Value);
                        _itemPermisos.ESCRITURA = Convert.ToBoolean(dataGridMenues.Rows[i].Cells[(int)col_Menues.ESCRITURA].Value);
                        _itemPermisos.ELIMINACION = Convert.ToBoolean(dataGridMenues.Rows[i].Cells[(int)col_Menues.ELIMINACION].Value);

                        _permisos.Add(_itemPermisos);
                    }
                    MessageBox.Show("Permisos Asignados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridMenues_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridMenues.IsCurrentCellDirty)
                dataGridMenues.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

  
    }
}
