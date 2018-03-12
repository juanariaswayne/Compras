using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Catalogos
{
    public partial class Frm_Perfiles : Plantilla
    {
        #region Variables
            private bool lectura;
            private Boolean escritura;
            private Boolean elimina;

        #endregion
        #region Funciones y Procedimientos
            public Frm_Perfiles()
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
        #endregion
        #region Eventos
            private void Frm_Perfiles_Load(object sender, EventArgs e)
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
            }

            private void cmdGrabarUsuario_Click(object sender, EventArgs e)
            {
                try
                {
                    if (this.textBoxPerfil.Text.Trim() != string.Empty)
                    {
                        BLL .Tables.TBL_PERFILES _perfil = new BLL.Tables.TBL_PERFILES();
                        Entities.Tables.TBL_PERFILES _newPerfil = new Entities.Tables.TBL_PERFILES();
                        _newPerfil.NOMBREPERFIL = this.textBoxPerfil.Text.ToString().Trim();
                        _newPerfil.DESCRIPCIONPERFIL = this.textBoxDescripcion.Text.ToString().Trim();

                        _perfil.Add(_newPerfil);

                        MessageBox.Show("Perfil dado de alta correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar una descripción de Perfil", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        #endregion
           
          
    }
}
