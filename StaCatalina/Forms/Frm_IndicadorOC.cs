using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace StaCatalina.Forms
{
    public partial class Frm_IndicadorOC : StaCatalina.Plantilla
    {
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        public Frm_IndicadorOC()
        {
            InitializeComponent();
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

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_IndicadorOC_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            textBoxAnio.Text = DateTime.Now.Year.ToString();
            textBoxMes.Text = DateTime.Now.Month.ToString();
        }

        private void textBoxAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxAnio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxMes.Focus();
            }
        }

        private void textBoxMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxMes_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAnio.Text != string.Empty && textBoxMes.Text != string.Empty)
                {
                    if (Convert.ToInt16(textBoxMes.Text) <= 12)
                    {
                        Cursor = System.Windows.Forms.Cursors.WaitCursor;

                        StaCatalinaEntities _mod = new StaCatalinaEntities();
                        _mod.Database.CommandTimeout = 3800;
                        _mod.OrdenCompra_Indicador_Mensual(Clases.Usuario.EmpresaLogeada.EmpresaIngresada, Convert.ToInt32(textBoxAnio.Text), Convert.ToInt16(textBoxMes.Text), 90);

                        MessageBox.Show("Indicador generado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El número de mes no puede ser mayor a 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBoxMes.Focus();
                    }

                }

                else
                {
                    MessageBox.Show("Debe ingresar Año y Mes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxAnio.Focus();
                }


                Cursor = System.Windows.Forms.Cursors.Default;
            }

            catch(Exception ex)
            {
                Cursor = System.Windows.Forms.Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
