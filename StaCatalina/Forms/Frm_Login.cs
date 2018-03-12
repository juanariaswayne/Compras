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
    public partial class Frm_Login : Form
    {
        public bool IngresoCorrecto = false;

        private Int32 _perfilUsuario = 0;
        private Int32 _idUsuario = 0;
        private Int32 _idSector = 0;

        public Int32 PerfilUsuario
        {
            get { return _perfilUsuario; }
            set { _perfilUsuario = value; }
        }

        //public Int32 SectorUsuario
        //{
        //    get { return _idSector; }
        //    set { _idSector = value; }
        //}
        
        public Frm_Login()
        {
            InitializeComponent();
        }

        private bool ValidarIngreso()
        {
            if (String.IsNullOrEmpty(this.Txt_Usuario.Text.Trim()))
            {
                this.errorProvider1.SetError(this.Txt_Usuario, "Escriba el nombre del usuario");
                this.Txt_Usuario.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(this.Txt_Contrasenia.Text.Trim()))
            {
                this.errorProvider1.SetError(this.Txt_Contrasenia, "Escriba la contraseña");
                this.Txt_Contrasenia.Focus();
                return false;
            }
            else if (this.comboBoxEmpresa.SelectedIndex == 0)
            {
                this.errorProvider1.SetError(this.comboBoxEmpresa, "Debe seleccionar una Empresa");
                this.comboBoxEmpresa.Focus();
                return false;
            }
            else
                return true;
        }
        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarIngreso())
                {

                    MenuSistema.Cls_Menus Menus = new MenuSistema.Cls_Menus();
                    Seguridad.Encriptacion encripta = new Seguridad.Encriptacion();
                    string ClaveUsu;
                    ClaveUsu = encripta.ENCRIPTAR(Txt_Contrasenia.Text.ToString());


                    foreach (Entities.Procedures._VALIDACREDENCIAL Creden in Menus.ValidarCredenciales(Txt_Usuario.Text, ClaveUsu))
                    {
                        _idUsuario = Creden.idusuario;
                        PerfilUsuario = Creden.perfil;
                        _idSector = Creden.sector_id;
                        Clases.Usuario.UsuarioLogeado.id_usuario_Logeado = Creden.idusuario;
                        Clases.Usuario.UsuarioLogeado.Email = Creden.email.ToString();
                        Clases.Usuario.UsuarioLogeado.EmpresaAutorizada = Creden.empresa.ToString();
                    }

                    if (_idUsuario != 0) //SI ES CERO, NO EXISTE O LA CLAVE ES INCORRECTA, SINO TRAE EL ID DE USUARIO Y EL PERFIL AL QUE PERTENECE
                    {
                        //VERIFICO SI ESTÁ HABILITADO A LA EMPRESA QUE SELECCIONO
                        Clases.Usuario.EmpresaLogeada.EmpresaIngresada = comboBoxEmpresa.SelectedValue.ToString();
                        Clases.Usuario.EmpresaLogeada.NombreEmpresaIngresada = comboBoxEmpresa.Text.Trim();

                        if (Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != "AMBA")//QUIERE DECIR QUE SOLO ESTA AUTORIZADA A UNA EMPRESA
                        {
                            if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString().Trim() != Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim())
                            {
                                MessageBox.Show("Ud. no está autorizado a ingresar a la empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada, "Error de credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 //   Application.Exit();
                                return;
                            }

                        }
                        IngresoCorrecto = true;
                        //GUARDO EL USUARIO QUE ESTÁ LOGEADO
                        Clases.Usuario.UsuarioLogeado.usuario_Logeado = Txt_Usuario.Text.ToString();
                        Clases.Usuario.UsuarioLogeado.Id_Sector = _idSector;

                        // ********************* MUESTRO EVENTOS PARA ESTE USUARIO //
                        Catalogos.Frm_Eventos _evento = new Catalogos.Frm_Eventos();
                        BLL.Procedures.EVENTOSUSUARIO _usuEvento = new BLL.Procedures.EVENTOSUSUARIO();
                        List<Entities.Procedures.EVENTOSUSUARIO> _listEvento = new List<Entities.Procedures.EVENTOSUSUARIO>();
                        if (_usuEvento.ItemList(_idUsuario).Count > 0)
                        {
                            //SOLO MUESTRO EVENTOS SI TIENE PENDIENTE DE VER
                            _evento._listEvento = _usuEvento.ItemList(_idUsuario); //paso la coleccion alformulario
                            _listEvento = _usuEvento.ItemList(_idUsuario);
                            //GRABO ESTOS EVENTOS.. ASI NO LOS MUESTRA  MAS ....
                            BLL.Tables.EVENTOUSUARIO _newEvento = new BLL.Tables.EVENTOUSUARIO();
                            Entities.Tables.EVENTOUSUARIO _itemEv = new Entities.Tables.EVENTOUSUARIO();
                            foreach (Entities.Procedures.EVENTOSUSUARIO item in _listEvento)
                            {
                                _itemEv = new Entities.Tables.EVENTOUSUARIO();
                                _itemEv.EVENTO_ID = item.id;
                                _itemEv.FECHA = Convert.ToDateTime(DateTime.Now.ToString()); //GUARDA CON LA HORA
                                _itemEv.ID_USUARIO = _idUsuario;
                                _newEvento.Add(_itemEv);// grabo
                            }

                            _evento.ShowDialog();
                        }
                        // FIN MUESTRA Y GRABA EVENTOS ****************************************************

                        this.Close();
                    }
                    else
                    {
                        if (MessageBox.Show("El usuario o la contraseña no son válidos ó este usuario está inactivo", "Error de credenciales", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                            Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            this.Txt_Contrasenia.Focus();
        }

        private void Txt_Contrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.comboBoxEmpresa.Focus();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            Clases.Empresa.CargarEmpresas(comboBoxEmpresa);

            this.comboBoxEmpresa.SelectedIndex = 1;
        }

        private void comboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Btn_Aceptar.Focus();
        }

        private void comboBoxEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
                this.Btn_Aceptar.Focus();
        }


    }
}
