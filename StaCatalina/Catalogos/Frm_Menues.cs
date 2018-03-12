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
    public partial class Frm_Menues : Plantilla
    {
        #region Variables
            private bool lectura;
            private Boolean escritura;
            private Boolean elimina;
        #endregion

        #region Funciones y procedimientos
            public Frm_Menues()
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

            private void CargarMenuesPadre()
            {
                try
                {
                    BLL.Tables.TBL_MENUS _menu = new BLL.Tables.TBL_MENUS();
                    _menu.WhereParameter.Add(DAL.Tables.TBL_MENUS.ColumnEnum.Id_MenuPadre, DAL.SqlEnums.OperandEnum.Equal, 0);
                    _menu.OrderByParameter.Add(DAL.Tables.TBL_MENUS.ColumnEnum.DescripcionMenu, DAL.SqlEnums.DirEnum.ASC);
                    _menu.ItemList();
                    Entities.Tables.TBL_MENUS _itemSeleccion = new Entities.Tables.TBL_MENUS();
                    //Limpia el combo
                    this.comboMenuPadre.SuspendLayout();
                    this.comboMenuPadre.DataSource = null;
                    this.comboMenuPadre.Items.Clear();

                    //Carga el item de Seleccion.-
                    _itemSeleccion.DESCRIPCIONMENU = "<Seleccione un Menú Padre>";
                    _itemSeleccion.ID_MENU = 0;
                    _menu.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboMenuPadre.ValueMember = "Id_Menu";
                    this.comboMenuPadre.DisplayMember = "DescripcionMenu";
                    this.comboMenuPadre.DataSource = _menu.Result;
                    this.comboMenuPadre.ResumeLayout();
                    this.comboMenuPadre.SelectedIndex = 0;
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
                    //Limpia el combo
                    this.comboModulos.SuspendLayout();
                    this.comboModulos.DataSource = null;
                    this.comboModulos.Items.Clear();

                    this.comboModulos.Items.Add("<Seleccione un un Módulo>");
                    this.comboModulos.Items.Add("Catalogos");
                    this.comboModulos.Items.Add("Forms");
                                                   
                    this.comboModulos.SelectedIndex = 0;

                    this.comboModulos.ResumeLayout();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            private Boolean VerificaIngreso()
            {
                try
                {
           
                    if(this.comboModulos.SelectedIndex  == 0)
                    {
                        this.errorProvider.SetError(this.comboModulos, "Mensaje");
                        MessageBox.Show("Debe seleccionar un Módulo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.comboModulos.Focus();
                        return false;
                    }
                    else
                    {
                        this.errorProvider.SetError(this.comboModulos, "");
                    }

                    if (this.comboMenuPadre.SelectedIndex == 0)
                    {
                        this.errorProvider.SetError(this.comboMenuPadre, "Mensaje");
                        MessageBox.Show("Debe seleccionar un Menú Padre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.comboMenuPadre.Focus();
                        return false;
                    }
                    else
                    {
                        this.errorProvider.SetError(this.comboMenuPadre, "");
                    }

                    if(this.textDescrip.Text == string .Empty )
                    {
                        this.errorProvider.SetError(this.textDescrip, "Mensaje");
                        MessageBox.Show("Debe ingresar una descripción de menú", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.textDescrip.Focus();
                        return false;

                    }
                    else
                    {
                        this.errorProvider.SetError(this.textDescrip, "");
                    }

                    if (this.textNombre.Text == string.Empty)
                    {
                        this.errorProvider.SetError(this.textNombre, "Mensaje");
                        MessageBox.Show("Debe ingresar nombre de Formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.textNombre.Focus();
                        return false;

                    }
                    else
                    {
                        this.errorProvider.SetError(this.textNombre, "");
                    }

                    return true;

                }
                catch (Exception ex)
                {
                    
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
                }

            }

            private void NuevoIngreso()
            {
                this.comboModulos.SelectedIndex = 0;
                this.comboMenuPadre.SelectedIndex = 0;
                this.textDescrip.Text = string.Empty;
                this.textNombre.Text = string.Empty;
                this.comboModulos.Focus(); 
            }
        #endregion

        #region Eventos
            private void Frm_Menues_Load(object sender, EventArgs e)
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus(); 
                //Ctrl_Datos._SIS.Cls_Menus menu = new Ctrl_Datos._SIS.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                CargarMenuesPadre();
                CargarModulos();
                this.OperacionesDelUsuario();
            }

            private void cmdSalirUsuario_Click(object sender, EventArgs e)
            {
                this.Close();
                this.Dispose();
            }

            private void comboModulos_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.comboMenuPadre.Focus();
                }

            }

            private void comboMenuPadre_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.textDescrip.Focus();
                }
            }

            private void textDescrip_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.textNombre.Focus();
                }

            }

            private void cmdNuevoIngreso_Click(object sender, EventArgs e)
            {
                this.NuevoIngreso(); 
            }

            private void cmdGrabarUsuario_Click(object sender, EventArgs e)
            {
                if(VerificaIngreso())
                {
                    try
                    {
                        BLL.Tables.TBL_MENUS _menu = new BLL.Tables.TBL_MENUS();
                        Entities.Tables.TBL_MENUS _itemMenu = new Entities.Tables.TBL_MENUS();
                        BLL.Procedures.ULTIMA_POSICION_MENU _ultimaPoc = new BLL.Procedures.ULTIMA_POSICION_MENU();  
                        int _pos = 0;
                        //TRAIGO LA ULTIMA POSICION DEL MENU. PARA SABER EN QUE LUGAR CREO ESTE NUEVO MENU
                        _ultimaPoc.Items((int)this.comboMenuPadre.SelectedValue);
                        _pos = _ultimaPoc.Result[0].ultimomenu + 1; // ES LA PROXIMA POSICIÓN

                        //AGGREGO EL NUEVO MENU
                        _itemMenu.DESCRIPCIONMENU = this.textDescrip.Text.ToString();
                        _itemMenu.FORMULARIOASOCIADO = true;
                        _itemMenu.HABILITADOMENU = true;
                        _itemMenu.ID_MENUPADRE = (int)this.comboMenuPadre.SelectedValue;
                        _itemMenu.POSICIONMENU = _pos;
                        _itemMenu.URLMENU = this.comboModulos.Text.ToString()+"."+this.textNombre.Text.ToString(); // LA URLMENU ES LA CONCATENACION DEL MODULO CON EL NOMBRE DEL FORMULARIO

                        _menu.AddItem(_itemMenu);
                        MessageBox.Show("Menú agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        this.NuevoIngreso();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                                       


                }

            }

        #endregion
    
       
    }
}
