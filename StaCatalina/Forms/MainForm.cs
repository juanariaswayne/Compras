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
    public partial class MainForm : Form
    {
        

       
        #region Variables
            private System.Reflection.Assembly Ensamblado;
            private Int32 id_Perfil;
        #endregion

        #region Funciones y Procedimientos

            public MainForm()
            {
                InitializeComponent();
            }
            private void CargarMenus(Int32 id_Perfil)
            {
                MenuSistema.Cls_Menus OpcionesMenu = new MenuSistema.Cls_Menus();
                //Ctrl_Datos._SIS.Cls_Menus OpcionesMenu = new Ctrl_Datos._SIS.Cls_Menus();
                //dtMenus = new DataTable();
                //dtMenus = OpcionesMenu.MenusWindowsDelPerfil(id_Perfil);
                //dtMenus.CaseSensitive = false;
                BLL.Procedures._MENUES_PADRES_E_HIJOS _menuesSistema = new BLL.Procedures._MENUES_PADRES_E_HIJOS();
                BLL.Procedures._MENUES_PADRES_E_HIJOS _hijos = new BLL.Procedures._MENUES_PADRES_E_HIJOS();
                //PRIMERO TRAIGO TODOS LOS MENUES PADRES (ID_MENUPADRE = 0)
                foreach (Entities.Procedures._MENUES_PADRES_E_HIJOS ItemMenu in _menuesSistema.ItemList(0, id_Perfil))
                {
                    ToolStripItem[] Menu = new ToolStripItem[1];
                    Menu[0] = new ToolStripMenuItem();
                    Menu[0].Name = ItemMenu.id_menu.ToString();
                    Menu[0].Text = ItemMenu.descripcionmenu.ToString();
                    if (ItemMenu.urlmenu == null)
                    { Menu[0].Tag = string.Empty; }
                    else { Menu[0].Tag = ItemMenu.urlmenu.ToString(); }
                    //Menu[0].Image = (Image)MenuPadre["IconoMenu"];
                    //Averiguando si tiene Hijos o no
                    if (_hijos.ItemList(ItemMenu.id_menu, id_Perfil).Count == 0)
                    {
                        //Sino tiene hijos lo agrego a la barra de menu principal
                        Menu[0].Click += new EventHandler(MenuItemClicked);
                        MenuPpal.Items.Add(Menu[0]);
                    }
                    else
                    {
                        //Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                        MenuPpal.Items.Add(Menu[0]);
                        AgregarMenuHijo(Menu[0], id_Perfil, _hijos);

                    }

                }

            }
            private void AgregarMenuHijo(ToolStripItem MenuItemPadre, int _perfil, BLL.Procedures._MENUES_PADRES_E_HIJOS _hijos)
            {

                ToolStripMenuItem MenuPadre = (ToolStripMenuItem)MenuItemPadre;

                ////Obtengo el ID del menu Enviado para saber si tiene hijos o no
                int Id = Int32.Parse(MenuPadre.Name);

                BLL.Procedures._MENUES_PADRES_E_HIJOS _tieneHijos = new BLL.Procedures._MENUES_PADRES_E_HIJOS();

                if (_tieneHijos.ItemList(Id, _perfil).Count == 0)
                {
                    //Si No tiene Hijos Solo Agrego el Evento
                    MenuPadre.Click += new EventHandler(MenuItemClicked);
                }
                else
                {
                    //TRAIGO LOS HIJOS DE ESTE PADRE
                    foreach (Entities.Procedures._MENUES_PADRES_E_HIJOS ItemMenu in _hijos.ItemList(Id, _perfil))
                    {
                        ToolStripItem[] NuevoMenu = new ToolStripItem[1];
                        NuevoMenu[0] = new ToolStripMenuItem();
                        NuevoMenu[0].Name = ItemMenu.id_menu.ToString();
                        NuevoMenu[0].Text = ItemMenu.descripcionmenu.ToString();
                        if (ItemMenu.urlmenu == null)
                        { NuevoMenu[0].Tag = string.Empty; }
                        else { NuevoMenu[0].Tag = ItemMenu.urlmenu.ToString(); }
                        //Averiguo se es un separador
                        if (ItemMenu.descripcionmenu.ToString() == "-")
                        {
                            MenuPadre.DropDownItems.Add(NuevoMenu[0].Text);
                        }
                        else
                        {
                            //Averiguando si tiene Hijos o no
                            if (_tieneHijos.ItemList(ItemMenu.id_menu, _perfil).Count == 0)
                            {
                                //Sino tiene hijos lo agrego al Menu Padre
                                NuevoMenu[0].Click += new EventHandler(MenuItemClicked);
                                
                                if (ItemMenu.descripcionmenu.ToString() == "EGES")
                                {
                                    NuevoMenu[0].Text = "EGESAC S.A.";
                                    //VERIFICO EN QUE EMPRESA ESTOY AUTORIZADO A OPERAR
                                    if (Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() == "RSC")
                                    {
                                        //NO HABILITO EGES
                                        NuevoMenu[0].Enabled = false;
                                    }
                                    else
                                    {
                                        NuevoMenu[0].Enabled = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString() == "EGES") ? false : true;
                                    }
                                   
                                }
                                else
                                {
                                    if (ItemMenu.descripcionmenu.ToString() == "RSC")
                                    {
                                        NuevoMenu[0].Text = "RSC S.A.";
                                        //VERIFICO EN QUE EMPRESA ESTOY AUTORIZADO A OPERAR
                                        if(Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() == "EGES")
                                        {
                                            //NO HABILITO RSC
                                            NuevoMenu[0].Enabled = false;
                                        }
                                        else
                                        {
                                            NuevoMenu[0].Enabled = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString() == "RSC") ? false : true;
                                        }
                                       
                                    }
                                }
                                 
                                MenuPadre.DropDownItems.Add(NuevoMenu[0]);
                            }
                            else
                            {
                                //Si tiene hijos llamo a la funcion recursiva y Agrego el Item sin Evento
                                MenuPadre.DropDownItems.Add(NuevoMenu[0]);
                                AgregarMenuHijo(NuevoMenu[0], _perfil, _tieneHijos);
                            }
                        }

                    }

                }

            }

            private Boolean FormularioEstaAbierto(String NombreDelFrm)
            {
                try
                {

                    if (this.MdiChildren.Length > 0)
                    {
                        for (int i = 0; i < this.MdiChildren.Length; i++)
                        {
   
                            if (this.MdiChildren[i].Name == NombreDelFrm.Substring(NombreDelFrm.IndexOf("Frm_"), NombreDelFrm.Length - NombreDelFrm.IndexOf("Frm_")))
                            {
                                MessageBox.Show("El formulario solicitado ya se encuentra abierto");
                                return true;
                            }
                        }
                        return false;
                    }
                    else
                        return false;

                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
                }
            }
        #endregion

        #region menu

            private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Close();
                this.Dispose();
            }



            private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
            {
                LayoutMdi(MdiLayout.Cascade);
            }

            private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
            {
                LayoutMdi(MdiLayout.TileVertical);
            }

            private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
            {
                LayoutMdi(MdiLayout.TileHorizontal);
            }

            private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                LayoutMdi(MdiLayout.ArrangeIcons);
            }

            private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
            }

        #endregion
        #region OptionMenu


            private void MenuItemClicked(object sender, EventArgs e)
            {
                if (sender.GetType() == typeof(ToolStripMenuItem))
                {
                    string NombreFormulario = ((ToolStripItem)sender).Tag.ToString();

                    Object ObjFrm;
                    Type tipo = Ensamblado.GetType(Ensamblado.GetName().Name + "." + NombreFormulario);

                    if (tipo == null)
                    {
                        if (sender.ToString().Trim() == "EGESAC S.A.")
                        {
                            Clases.Usuario.EmpresaLogeada.EmpresaIngresada = "EGES";
                            this.Text = "Clínica Santa Catalina: " + "[EGESAC S.A.]";
                            foreach (ToolStripMenuItem menu in this.MenuPpal.Items)
                            {
                                if (menu.Text.Trim() == "Empresa")
                                {
                                    RecorreMenuHijos(menu.DropDownItems, "EGES");
                                }
                            }
                            return;
                        }
                        else
                        {
                            if (sender.ToString().Trim() == "RSC S.A.")
                            {
                                Clases.Usuario.EmpresaLogeada.EmpresaIngresada = "RSC";
                                this.Text = "Clínica Santa Catalina: " + "[RSC S.A.]";

                                foreach (ToolStripMenuItem menu in this.MenuPpal.Items)
                                {
                                    if (menu.Text.Trim() == "Empresa")
                                    {
                                        RecorreMenuHijos(menu.DropDownItems,"RSC");
                                    }                                      
                                }
                                return;
                            }
                        }
                        MessageBox.Show("No se encontró el formulario", "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!this.FormularioEstaAbierto(NombreFormulario))
                        {
                            ObjFrm = Activator.CreateInstance(tipo);
                            Plantilla Formulario = (Plantilla)ObjFrm;
                                                     
                            Formulario.Id_Perfil = id_Perfil;
                            Formulario.MdiParent = this;
                            Formulario.Tag = ((ToolStripItem)sender).Name.ToString();//le envio el numero de Id de Menu para recuperar con este valor los permisos de este menu
                            Formulario.Top = 5;
                            Formulario.Show();
                        }
                    }
                }
            }

        private void RecorreMenuHijos(ToolStripItemCollection Menu, string _empresaSelect)
        {

            foreach (ToolStripItem submenu in Menu)
            {
                if (_empresaSelect == "RSC" && submenu.Text.Trim() == "EGESAC S.A.")
                {
                    submenu.Enabled = true;
                    Menu[1].Enabled = false;
                }

                if (_empresaSelect == "EGES" && submenu.Text.Trim() == "RSC S.A.")
                {
                    submenu.Enabled = true;
                    Menu[0].Enabled = false;
                    break;
                }


            }
                               
        }
        #endregion



       #region eventos

            private void MainForm_Load(object sender, EventArgs e)
            {
                Frm_Login login = new Frm_Login();
                login.ShowDialog();


                if (login.IngresoCorrecto)
                {
                    Ensamblado = System.Reflection.Assembly.GetExecutingAssembly();
                    this.MenuPpal.Items.Clear();
                    this.CargarMenus(login.PerfilUsuario);
                    id_Perfil = login.PerfilUsuario;

                    string _empresa = Clases.Usuario.EmpresaLogeada.NombreEmpresaIngresada.ToString();
                    this.Text = "Clínica Santa Catalina: " + "[" + _empresa + "]";


                }
                else
                {
                    Application.Exit();
                }
            }

        #endregion

    }
}
