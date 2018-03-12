using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
namespace StaCatalina.Forms
{
    public partial class Frm_EvolucionHistImputacionCompras : Plantilla
    {
        #region Funciones
            public Frm_EvolucionHistImputacionCompras()
            {
                InitializeComponent();
            }

            private void GeneraHistorial(DateTime _fechaDesde, DateTime _fechaHasta, double PorcentVenezuela,string Empresa)
            {
                try
                {
                    BLL.Procedures.H_GENERAHISTORIALIMPUTACIONCOMPRAS _generaHist = new BLL.Procedures.H_GENERAHISTORIALIMPUTACIONCOMPRAS();
                    _generaHist.GenerarHistorial(_fechaDesde, _fechaHasta, PorcentVenezuela, Empresa);

                    MessageBox.Show("El historial de Imputaciones de compras se generó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        #endregion

        #region Eventos
            private void FrmEvolucionHistImputacionCompras_Load(object sender, EventArgs e)
            {
                this.dateTimeDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                this.dateTimeHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                this.labelDistribucion.Text = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? "% Distribución Venezuela:" : "% Distribución Catamarca:";
                this.textBoxPorcentDistrib.Text = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? string.Empty : "100";
            }

            private void dateTimeDesde_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                    this.dateTimeHasta.Focus();
            }

            private void dateTimeHasta_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                    this.textBoxPorcentDistrib.Focus();
            }

          private void toolStripButtonSave_Click(object sender, EventArgs e)
            {

                try
                {

                Cursor = System.Windows.Forms.Cursors.WaitCursor;

                //verifico que las fechas sean del mismo mes
                    if (this.dateTimeDesde.Value.Month == this.dateTimeHasta.Value.Month)
                    {
                        if (this.dateTimeDesde.Value.Year != this.dateTimeHasta.Value.Year)
                        {
                            MessageBox.Show("El Año de ambas fechas, deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.dateTimeDesde.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El mes de ambas fechas, deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.dateTimeDesde.Focus();
                        return;
                    }
                    //verifico que se haya ingresado algo en porcentaje
                    if (this.textBoxPorcentDistrib.Text == string.Empty)
                    {
                        MessageBox.Show("Debe ingresar un Porcentaje a distribuir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBoxPorcentDistrib.Focus();
                        return;
                    }

                    //primero verifico si este mes y año ya están guardados, de ser así pregunto si quiere actualizar
                    BLL.Procedures._EXISTEHISTORIAL _verificaFecha = new BLL.Procedures._EXISTEHISTORIAL();
                    _verificaFecha.Items(Convert.ToDateTime(this.dateTimeDesde.Value.ToShortDateString()),Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
                    if (_verificaFecha.Resultset.Count > 0)
                    {
                        //ya esta cargado este mes y año
                        //DialogResult _result = MessageBox.Show("Este Año y Mes ya están cargados, desea modificar los datos?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        //if (_result == System.Windows.Forms.DialogResult.OK)
                        //{
                            // primero borro el historial de este mes para cargarlo de nuevo
                            BLL.Procedures.H_ACTUALIZAHISTORIALCOMPRAS _actualiza = new BLL.Procedures.H_ACTUALIZAHISTORIALCOMPRAS();
                            _actualiza.ActualizaHistorial(this.dateTimeDesde.Value.Year,this.dateTimeDesde.Value.Month, Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
                            //luego cargo todo de nuevo
                            GeneraHistorial(this.dateTimeDesde.Value, this.dateTimeHasta.Value,Convert.ToDouble (this.textBoxPorcentDistrib.Text),Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim());

                        //}
                    }
                    else
                    {
                        toolStripButtonSave.Enabled = false;
                        GeneraHistorial(this.dateTimeDesde.Value, this.dateTimeHasta.Value, Convert.ToDouble(this.textBoxPorcentDistrib.Text),Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim());

                        toolStripButtonSave.Enabled = true;
                    }

                Cursor = System.Windows.Forms.Cursors.Default;
                }
                catch (Exception ex)
                {
                Cursor = System.Windows.Forms.Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          private void textBoxPorcentDistrib_KeyPress(object sender, KeyPressEventArgs e)
          {
              CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
              if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                  e.Handled = false;
              else
                  e.Handled = true;
          }


        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
