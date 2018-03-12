using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Bejerman
{
    public partial class Frm_HistorialSaldoProveedores : StaCatalina.Plantilla
    {
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        public Frm_HistorialSaldoProveedores()
        {
            InitializeComponent();
        }

        private bool VerificaIngreso()
        {

            try
            {
                if (this.textBoxAnio.Text == string.Empty)
                {
                    this.errorProvider1.SetError(this.textBoxAnio, "Debe ingresar año");
                    this.textBoxAnio.Focus();
                    return false;
                }

              
                if (Convert.ToInt32(this.textBoxMes.Text) > 12)
                {
                    this.errorProvider1.SetError(this.textBoxMes, "El mes no puede ser mayor que 12");
                    this.textBoxMes.Focus();
                    return false;
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
                if (!escritura) { this.toolStripButtonSave.Enabled = false; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Frm_HistorialSaldoProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.Text = "Genera historial de Saldo proveedores, empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                this.OperacionesDelUsuario();

                this.textBoxAnio.Text = DateTime.Now.Year.ToString();
                this.textBoxMes.Text = DateTime.Now.Month.ToString();
                this.textBoxMes.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaIngreso())
                {
                    BLL.Procedures.GENERAHISTORIALSALDOPROVEEDOR _cierre = new BLL.Procedures.GENERAHISTORIALSALDOPROVEEDOR();
                                     

                    _cierre.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString(),Convert.ToInt32(this.textBoxAnio.Text), Convert.ToInt32(this.textBoxMes.Text));
                    MessageBox.Show("El ingreso se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
