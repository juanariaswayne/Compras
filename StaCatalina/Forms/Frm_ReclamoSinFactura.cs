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
    public partial class Frm_ReclamoSinFactura : Form
    {
        #region Variables
        private Entities.Tables.RECLAMOFACTURASINCARGAR _reclamoFact = new Entities.Tables.RECLAMOFACTURASINCARGAR();
            public Entities.Tables.RECLAMOFACTURASINCARGAR ReclamoFact
            {
                get { return _reclamoFact; }
                set { _reclamoFact = value; }

            }
        #endregion

        #region Funciones
               
            public Frm_ReclamoSinFactura()
            {
                InitializeComponent();
            }

            private bool VerificaIngreso()
            {
                try
                {
                    if (String.IsNullOrEmpty(this.textBoxNro.Text.Trim()))
                    {
                        this.errorProvider1.SetError(this.textBoxNro, "Debe ingresar un Nro. de Factura");
                        this.textBoxNro.Focus();
                        return false;
                    }

                    if (String.IsNullOrEmpty(this.textBoxImporte.Text.Trim()))
                    {
                        this.errorProvider1.SetError(this.textBoxImporte, "Debe ingresar Importe de Factura");
                        this.textBoxImporte.Focus();
                        return false;
                    }

                    if (String.IsNullOrEmpty(this.textBoxObs.Text.Trim()))
                    {
                        this.errorProvider1.SetError(this.textBoxObs, "Debe ingresar una Observación");
                        this.textBoxObs.Focus();
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

            private void TraeHistorial(string _proveed)
            {
                try
                {
                    this.dataGridViewHistorial.AutoGenerateColumns = false;
                    BLL.Tables.RECLAMOFACTURASINCARGAR _hist = new BLL.Tables.RECLAMOFACTURASINCARGAR();
                    _hist.WhereParameter.Add(DAL.Tables.RECLAMOFACTURASINCARGAR.ColumnEnum.cco_CodPro, DAL.SqlEnums.OperandEnum.Equal, _proveed);

                    this.dataGridViewHistorial.DataSource = _hist.ItemList();
                    this.dataGridViewHistorial.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        #endregion

        #region Eventos
            private void textBoxNro_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }

            private void textBoxImporte_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 &&  e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }


            private void Frm_ReclamoSinFactura_Load(object sender, EventArgs e)
            {
                try
                {
                    if(ReclamoFact.CCO_CODPRO != string.Empty)
                        this.labelRazonSocial.Text = ReclamoFact.CCOPRO_RAZSOC.ToString();
                    this.dateTimeFechaFactrua.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    TraeHistorial(ReclamoFact.CCO_CODPRO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            private void textBoxNro_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                    this.textBoxImporte.Focus();

            }

            private void textBoxImporte_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                    this.dateTimeFechaFactrua.Focus();
            }

            private void dateTimeFechaFactrua_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                    this.textBoxObs.Focus();
            }
        #endregion

            private void toolStripButtonSave_Click(object sender, EventArgs e)
            {
                if(VerificaIngreso())
                {
                    try
                    {
                        CultureInfo culture = new CultureInfo("en-US");
                        Entities.Tables.RECLAMOFACTURASINCARGAR _itemReclamo = new Entities.Tables.RECLAMOFACTURASINCARGAR();
                        BLL.Tables.RECLAMOFACTURASINCARGAR _reclamo = new BLL.Tables.RECLAMOFACTURASINCARGAR();
                        _itemReclamo.CCOEMP_CODIGO = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();
                        _itemReclamo.CCO_CODPRO = ReclamoFact.CCO_CODPRO;
                        _itemReclamo.CCO_FEMISION = this.dateTimeFechaFactrua.Value;
                        _itemReclamo.CCO_IMPMONLOC = Convert.ToDouble(this.textBoxImporte.Text, culture);
                        _itemReclamo.CCO_NRO = this.textBoxNro.Text;
                        _itemReclamo.CCOPRO_RAZSOC = ReclamoFact.CCOPRO_RAZSOC;
                        _itemReclamo.ENBEJERMAN = 0;
                        _itemReclamo.FECHARECLAMO = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        _itemReclamo.OBS = this.textBoxObs.Text.Trim();
                        _itemReclamo.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado;

                        _reclamo.Add(_itemReclamo);
                        MessageBox.Show("El reclamo se generó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.labelRazonSocial.Text = string.Empty;
                        this.Dispose();
                        this.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
