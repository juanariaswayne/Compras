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
    public partial class Frm_ProrrateoComprasEmpresa : StaCatalina.Plantilla
    {
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        public Frm_ProrrateoComprasEmpresa()
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

        private void GeneraProrrateo(DateTime _fechaDesde, DateTime _fechaHasta, double PorcentVenezuela)
        {
            try
            {
                if(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                {
                    BLL.Procedures.GENERAPRORRATEOEMPRESA _proEgesac = new BLL.Procedures.GENERAPRORRATEOEMPRESA();
                    _proEgesac.ItemList(_fechaDesde, _fechaHasta, PorcentVenezuela);

                    //TAMBIEN GRABO LA FECHA QUE SE PRORRATEO..
                    SBDAEGESEntities _ModEges = new SBDAEGESEntities();
                    USR_ControlProrrateoEmpresaEGES _control = new USR_ControlProrrateoEmpresaEGES
                    {
                        FechaProrrateoEmpresa = _fechaDesde,
                        Anio = _fechaDesde.Year,
                        Mes = _fechaDesde.Month
                        
                    };
                    _ModEges.USR_ControlProrrateoEmpresaEGES.Add(_control);
                    _ModEges.SaveChanges();
                    //FIN GRABA FECHA DE PRORRATEO

                    MessageBox.Show("El prorrateo de facturas para la Empresa EGESAC se generó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.toolStripButtonSave.Enabled = true;
                }

                if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "RSC")
                {
                    BLL.Procedures.GENERAPRORRATEOEMPRESA_RSC _proEgesac = new BLL.Procedures.GENERAPRORRATEOEMPRESA_RSC();
                    _proEgesac.ItemList(_fechaDesde, _fechaHasta);

                    //TAMBIEN GRABO LA FECHA QUE SE PRORRATEO..
                    SBDARSCEntities _ModRsc = new SBDARSCEntities();
                    USR_ControlProrrateoEmpresa _control = new USR_ControlProrrateoEmpresa
                    {
                        FechaProrrateoEmpresa = _fechaDesde,
                        Anio = _fechaDesde.Year,
                        Mes = _fechaDesde.Month
                    };
                    _ModRsc.USR_ControlProrrateoEmpresa.Add(_control);
                    _ModRsc.SaveChanges();
                    //FIN GRABA FECHA DE PRORRATEO

                    MessageBox.Show("El prorrateo de facturas para la Empresa RSC se generó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.toolStripButtonSave.Enabled = true;
                }


             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Frm_ProrrateoComprasEmpresa_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            this.dateTimeDesde.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.dateTimeHasta.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            this.labelDistribucion.Text = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? "% Distribución Venezuela:" : "% Distribución Catamarca:";
            this.textBoxPorcentDistrib.Text = (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES") ? "70" : "100";
            this.Text = "Prorrateo de Facturas de compras entre Empresas (Empresa Ingresada :" + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() + ")";
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {


            try
            {
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
                this.toolStripButtonSave.Enabled = false;
                this.GeneraProrrateo(Convert.ToDateTime(this.dateTimeDesde.Value.ToString("yyyy-MM-dd 00:00:00")),Convert.ToDateTime(this.dateTimeHasta.Value.ToString("yyyy-MM-dd 23:59:59")), Convert.ToDouble(this.textBoxPorcentDistrib.Text));

               


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void textBoxPorcentDistrib_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
