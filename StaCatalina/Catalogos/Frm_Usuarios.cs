using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace StaCatalina.Catalogos
{
    public partial class Frm_Usuarios : Plantilla
    {

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        private enum Col_Usuarios
        {
            EMAIL=0,
            INACTIVO,
            ID_PERFIL,
            ID_USUARIO,
            USUARIO,
            NOMBRE,
            PERFIL,
            SECTOR_ID,
            SECTOR,
            EMPRESA
        }

        public Frm_Usuarios()
        {
            InitializeComponent();
        }
      
        #region "Funciones y procedimientos"
            private void CargarPerfiles()
            {
            try
            {
                BLL.Tables.TBL_PERFILES _perfiles = new BLL.Tables.TBL_PERFILES();
                _perfiles.ItemList();
                Entities.Tables.TBL_PERFILES _itemSeleccion = new Entities.Tables.TBL_PERFILES();
                //Limpia el combo
                this.comboPerfil.SuspendLayout();
                this.comboPerfil.DataSource = null;
                this.comboPerfil.Items.Clear();

                //Carga el item de Seleccion.-
                _itemSeleccion.NOMBREPERFIL = "<Seleccione un Perfil>";
                _itemSeleccion.ID_PERFIL = 0;
                _perfiles.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboPerfil.ValueMember = "Id_Perfil";
                this.comboPerfil.DisplayMember = "NombrePerfil";
                this.comboPerfil.DataSource = _perfiles.Result;
                this.comboPerfil.SelectedValue = 0;
                this.comboPerfil.ResumeLayout();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            private void CargarUsuarios()
        {
            try
            {
            

                BLL.Joins.TBL_USUARIOS _usuarios = new BLL.Joins.TBL_USUARIOS();
                _usuarios.OrderByParameter.Add(DAL.Joins.TBL_USUARIOS.ColumnEnum.NombreUsuario, DAL.SqlEnums.DirEnum.ASC);
                this.dataGridViewUsuarios.Rows.Clear();
                int indice;
               
                foreach (Entities.Joins.TBL_USUARIOS _usuario in _usuarios.ItemList())
                {
                    indice = dataGridViewUsuarios.Rows.Add();
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuarios.INACTIVO].Value = _usuario.INACTIVO.ToString();
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuarios.ID_PERFIL].Value = _usuario.ID_PERFIL.ID_PERFIL.ToString();
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuarios.ID_USUARIO].Value = _usuario.ID_USUARIO.ToString();
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuarios.USUARIO].Value = _usuario.IDENTIFICADORUSUARIO.ToString();
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuarios.NOMBRE].Value = _usuario.NOMBREUSUARIO.ToString();
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuarios.PERFIL].Value = _usuario.ID_PERFIL.NOMBREPERFIL.ToString();
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuarios.SECTOR_ID].Value = _usuario.SECTOR_ID.SECTORREQUERIMIENTO_ID;
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuarios.SECTOR].Value = _usuario.SECTOR_ID.DESCRIPCION.ToString();
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuarios.EMAIL].Value = (_usuario.EMAIL == null) ? string.Empty : _usuario.EMAIL.ToString(); //EMAIL

                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuarios.EMPRESA].Value =(_usuario.EMPRESA.ToString().Trim() == "AMBA") ? "AMBAS": _usuario.EMPRESA.ToString();
                }
          

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private Boolean VerificaDatos()
        {
            try
            {
                if (this.comboPerfil.SelectedValue.ToString() == "0")
                {
                    errProvider.SetError(this.comboPerfil, "Debe asignar un Perfil de Usuario");
                    this.comboPerfil.Focus();
                    return false;
                }
                else
                { errProvider.SetError(this.comboPerfil, ""); }

                if (this.comboBoxSector.SelectedValue.ToString() == "0")
                {
                    errProvider.SetError(this.comboBoxSector, "Debe seleccionar un sector");
                    this.comboBoxSector.Focus();
                    return false;
                }
                else
                { errProvider.SetError(this.comboBoxSector, ""); }

                if (this.textUsuario.Text == string.Empty)
                {
                    errProvider.SetError(this.textUsuario, "Debe ingresar un Usuario");
                    this.textUsuario.Focus();
                    return false;
                }
                else
                { errProvider.SetError(this.textUsuario, ""); }

                if (this.textNombre.Text == string.Empty)
                {
                    errProvider.SetError(this.textNombre, "Debe ingresar un Nombre de Usuario");
                    this.textNombre.Focus();
                    return false;
                }
                else
                { errProvider.SetError(this.textNombre, ""); }

                if (id_usuario == 0)
                {
                    if (this.TextClave.Text == string.Empty)
                    {
                        errProvider.SetError(this.TextClave, "Debe ingresar Clave de Usuario");
                        //MessageBox.Show("Debe ingresar Clave de Usuario");
                        this.TextClave.Focus();
                        return false;
                    }
                    else
                    { errProvider.SetError(this.TextClave, ""); }

                }
                if(this.textBoxMail.Text != string.Empty )
                {
                    if(! email_bien_escrito (this.textBoxMail.Text.Trim().ToString()))
                    {
                        errProvider.SetError(this.textBoxMail, "Formato de Email no válido");
                        textBoxMail.Focus();
                        return false;
                    }
                    else
                    {
                        errProvider.SetError(this.textBoxMail, "");

                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

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


        private void CargarSectorRequerimiento()
        {
            try
            {
                BLL.Tables.COMSECTORREQUERIMIENTO _sector = new BLL.Tables.COMSECTORREQUERIMIENTO();
                _sector.ItemList();
                Entities.Tables.COMSECTORREQUERIMIENTO _itemSeleccion = new Entities.Tables.COMSECTORREQUERIMIENTO();
                //Limpia el combo
                this.comboBoxSector.SuspendLayout();
                this.comboBoxSector.DataSource = null;
                this.comboBoxSector.Items.Clear();

                //Carga el item de Seleccion.-
                _itemSeleccion.DESCRIPCION = "<Seleccione un Sector>";
                _itemSeleccion.SECTORREQUERIMIENTO_ID = 0;
                _sector.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSector.ValueMember = "SECTORREQUERIMIENTO_ID";
                this.comboBoxSector.DisplayMember = "DESCRIPCION";
                this.comboBoxSector.DataSource = _sector.Result;
                this.comboBoxSector.SelectedValue = 0;
                this.comboBoxSector.ResumeLayout();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region "Eventos"

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);

            this.CargarPerfiles();
            this.CargarUsuarios();
            this.CargarSectorRequerimiento();
            this.OperacionesDelUsuario();
            this.comboBoxEmpresa.SelectedIndex = 0;
        }
            
            private void cmdNuevoIngreso_Click(object sender, EventArgs e)
    {
        try
        {
            id_usuario = 0;
            this.textUsuario.Text = string.Empty;
            this.textNombre.Text = string.Empty;
            this.TextClave.Text = string.Empty;
            this.checkInactivo.Checked = false;
            this.comboPerfil.SelectedValue = 0;
            this.textUsuario.Focus();
            this.textBoxMail.Text =string.Empty;
            this.comboBoxSector.SelectedIndex = 0;
            this.comboBoxEmpresa.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

            private void cmdGrabarUsuario_Click(object sender, EventArgs e)
    {

        try
        {
            if (VerificaDatos())
            {
                Entities.Tables.TBL_USUARIOS item_user = new Entities.Tables.TBL_USUARIOS();
                if (this.TextClave.Text == string.Empty)
                {
                    //ACTUALIZO DATOS, NO INCLUIDO LA CLAVE
                    BLL.Procedures._TBL_USUARIOS_UPDATE_SIN_CLAVE update_user = new BLL.Procedures._TBL_USUARIOS_UPDATE_SIN_CLAVE();
                    item_user.ID_USUARIO = id_usuario;
                    item_user.ID_PERFIL = (int)this.comboPerfil.SelectedValue;
                    item_user.IDENTIFICADORUSUARIO = this.textUsuario.Text;
                    item_user.NOMBREUSUARIO = this.textNombre.Text;
                    item_user.INACTIVO = this.checkInactivo.Checked;
                    item_user.SECTOR_ID = (int)this.comboBoxSector.SelectedValue;
                    item_user.EMAIL = (this.textBoxMail.Text == string.Empty) ? null : this.textBoxMail.Text.ToString();
                    if(this.comboBoxEmpresa.SelectedIndex == 0)
                    {
                            item_user.EMPRESA = "AMBA";
                    }
                    if (this.comboBoxEmpresa.SelectedIndex == 1)
                    {
                        item_user.EMPRESA = "EGES";
                    }
                    if (this.comboBoxEmpresa.SelectedIndex == 2)
                    {
                        item_user.EMPRESA = "RSC";
                    }

                    if (this.comboBoxEmpresa.SelectedIndex == 3)
                    {
                        item_user.EMPRESA = "GSC";
                    }


                        update_user.UpdateUsuario(item_user.ID_USUARIO, item_user.ID_PERFIL, item_user.IDENTIFICADORUSUARIO, item_user.NOMBREUSUARIO, item_user.INACTIVO, item_user.SECTOR_ID, item_user.EMAIL, item_user.EMPRESA);
                    MessageBox.Show("Usuario Actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else // ACTUALIZA DATOS DEL USUARIO INCLUYENDO SU CLAVE
                {
                    BLL.Tables.TBL_USUARIOS user = new BLL.Tables.TBL_USUARIOS();

                    Seguridad.Encriptacion encripta = new Seguridad.Encriptacion();
                    item_user.ID_USUARIO = id_usuario;
                    item_user.ID_PERFIL = (int)this.comboPerfil.SelectedValue;
                    item_user.CONTRASENIAUSUARIO = encripta.ENCRIPTAR(this.TextClave.Text).ToString();
                    item_user.IDENTIFICADORUSUARIO = this.textUsuario.Text;
                    item_user.NOMBREUSUARIO = this.textNombre.Text;
                    item_user.INACTIVO = this.checkInactivo.Checked;
                    item_user.SECTOR_ID = (int)this.comboBoxSector.SelectedValue;
                    item_user.EMAIL = (this.textBoxMail.Text == string.Empty) ? null : this.textBoxMail.Text.ToString();
                    if (this.comboBoxEmpresa.SelectedIndex == 0)
                    {
                        item_user.EMPRESA = "AMBA";//AMBAS EMPRESAS
                    }
                    if (this.comboBoxEmpresa.SelectedIndex == 1)
                    {
                        item_user.EMPRESA = "EGES";
                    }
                    if (this.comboBoxEmpresa.SelectedIndex == 2)
                    {
                        item_user.EMPRESA = "RSC";
                    }
                    if (this.comboBoxEmpresa.SelectedIndex == 3)
                    {
                        item_user.EMPRESA = "GSC";
                    }
                    if (id_usuario == 0)
                    {

                        item_user = user.Add(item_user);
                        MessageBox.Show("Se creó un nuevo usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        user.Update(item_user);
                        MessageBox.Show("Usuario Actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                this.comboBoxEmpresa.SelectedIndex = 0;
                CargarUsuarios();
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

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsuarios.Rows.Count > 0)
            {

                this.textUsuario.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[(int)Col_Usuarios.USUARIO].Value.ToString();
                this.textNombre.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[(int)Col_Usuarios.NOMBRE].Value.ToString();
                id_usuario = Convert.ToInt32(dataGridViewUsuarios.Rows[e.RowIndex].Cells[(int)Col_Usuarios.ID_USUARIO].Value.ToString());
                this.checkInactivo.Checked = Convert.ToBoolean(dataGridViewUsuarios.Rows[e.RowIndex].Cells[(int)Col_Usuarios.INACTIVO].Value.ToString());
                this.comboPerfil.SelectedValue = Convert.ToInt32(dataGridViewUsuarios.Rows[e.RowIndex].Cells[(int)Col_Usuarios.ID_PERFIL].Value.ToString());
                this.comboBoxSector.SelectedValue = Convert.ToInt32(dataGridViewUsuarios.Rows[e.RowIndex].Cells[(int)Col_Usuarios.SECTOR_ID].Value.ToString());
                this.textBoxMail.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[(int)Col_Usuarios.EMAIL].Value.ToString();

                if (dataGridViewUsuarios.Rows[e.RowIndex].Cells[(int)Col_Usuarios.EMPRESA].Value.ToString().Trim() == "AMBA")
                {
                    this.comboBoxEmpresa.SelectedIndex = 0;
                }

                if (dataGridViewUsuarios.Rows[e.RowIndex].Cells[(int)Col_Usuarios.EMPRESA].Value.ToString().Trim() == "EGES")
                {
                    this.comboBoxEmpresa.SelectedIndex = 1;
                }

                if (dataGridViewUsuarios.Rows[e.RowIndex].Cells[(int)Col_Usuarios.EMPRESA].Value.ToString().Trim() == "RSC")
                {
                    this.comboBoxEmpresa.SelectedIndex = 2;
                }

                if (dataGridViewUsuarios.Rows[e.RowIndex].Cells[(int)Col_Usuarios.EMPRESA].Value.ToString().Trim() == "GSC")
                {
                    this.comboBoxEmpresa.SelectedIndex = 3;
                }
            }

        }
        #endregion

    }
}
