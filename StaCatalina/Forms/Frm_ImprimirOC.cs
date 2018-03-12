using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using System.Globalization;

namespace StaCatalina.Forms
{
    public partial class Frm_ImprimirOC : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        #endregion

        #region Funciones

        public Frm_ImprimirOC()
        {
            
            InitializeComponent();
        }

        private void OperacionesDelUsuario()
        {
            try
            {
                if (!escritura) { this.toolStripButtonPrint.Enabled = false; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Impresion()
        {

            try
            {
                //PRIMERO VERIFICO QUE TIPO DE OC ES: SIN STOCK O CON STOCK
         


                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "OrdenDeCompra.rpt";
                objReport.Load(reportPath);
                objReport.Refresh();
                objReport.ReportOptions.EnableSaveDataWithReport = false;

                // PARAMETROS DE CONEXION
                TableLogOnInfo logoninfo = new TableLogOnInfo();
                logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source"];
                logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogSTACATALINA"];
                logoninfo.ConnectionInfo.UserID = ConfigurationManager.AppSettings["User ID"];
                logoninfo.ConnectionInfo.Password = ConfigurationManager.AppSettings["Password"];
                logoninfo.ConnectionInfo.IntegratedSecurity = false;
                Tables tables = objReport.Database.Tables;
                foreach (Table table in tables)
                {
                    table.ApplyLogOnInfo(logoninfo);
                }
                // FIN PARAMETROS DE CONEXION

                ParameterFields Parametros = new ParameterFields();
                ParameterField ParametroField = new ParameterField();
                ParameterDiscreteValue ParametroValue = new ParameterDiscreteValue();
                Parametros.Clear();

                //1er PARAMETRO

                ParametroField.Name = "@codEmp";
                ParametroValue.Value = this.comboBoxEmpresa.SelectedValue.ToString();
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);


                //2do PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@TIPOINF";
                if (this.radioButtonPorOC.Checked)
                {
                    ParametroValue.Value = "OC";
                }
                if (this.radioButtonPorFecha.Checked)
                {
                    ParametroValue.Value = "FC";
                }
                if (this.radioButtonProveedor.Checked)
                {
                    ParametroValue.Value = "PR"; // POR PROVEEDOR
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3er PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@OC_id_Desde";
                if (this.radioButtonPorOC.Checked)
                {
                    ParametroValue.Value = this.textBoxOCDesde.Text;
                }
                else
                {
                    ParametroValue.Value = null;
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //4to PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@OC_id_Hasta";
                if (this.radioButtonPorOC.Checked)
                {
                    ParametroValue.Value = this.textBoxOCHasta.Text;
                }
                else
                {
                    ParametroValue.Value = null;
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //5to PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FECHADESDE";
                if (radioButtonPorFecha.Checked)
                {

                    ParametroValue.Value = this.dateTimePickerFechaDesde.Value.ToString("yyyy-MM-dd 00:00:00");
                }
                else
                {
                    ParametroValue.Value = null;
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //6to PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FECHAHASTA";
                if (radioButtonPorFecha.Checked)
                {

                    ParametroValue.Value = this.dateTimePickerFechaHasta.Value.ToString("yyyy-MM-dd 23:59:59");
                }
                else
                {
                    ParametroValue.Value = null;
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //7mo PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@ESTADO";
                ParametroValue.Value = 1; //estado Normal de la OC
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //8vo PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@PROVEED";
                if (this.comboBoxProveed.SelectedIndex > 0)
                {
                    ParametroValue.Value = (this.radioButtonProveedor.Checked) ? this.comboBoxProveed.SelectedValue.ToString() : null;
                }
                else
                {
                    if (radioButtonProveedor.Checked)
                    {
                        MessageBox.Show("Debe seleccionar un Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                               
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //9no PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FECHADESDE_PROVEED";
                if (this.radioButtonProveedor.Checked)
                {

                    ParametroValue.Value = this.dateTimeProveedDesde.Value.ToString("yyyy-MM-dd 00:00:00");
                }
                else
                {
                    ParametroValue.Value = null;
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //10mo PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FECHAHASTA_PROVEED";
                if (this.radioButtonProveedor.Checked)
                {

                    ParametroValue.Value = this.dateTimeProveedHasta.Value.ToString("yyyy-MM-dd 23:59:59");
                }
                else
                {
                    ParametroValue.Value = null;
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);


                _Reporte.Parameters = Parametros;
                _Reporte.Reporte = objReport;
                _Reporte.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CargarProveedor(string _codEmp)
        {
            try
            {
                BLL.Procedures._H_PROVEEDORES _prov = new BLL.Procedures._H_PROVEEDORES();
                _prov.ItemList(_codEmp);
                Entities.Procedures._H_PROVEEDORES _itemSeleccion = new Entities.Procedures._H_PROVEEDORES();

                //Limpia el combo
                this.comboBoxProveed.SuspendLayout();
                this.comboBoxProveed.DataSource = null;
                this.comboBoxProveed.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.pro_razsoc = "<Seleccione un Proveedor>";
                _itemSeleccion.pro_cod = "0";
                _prov.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxProveed.DisplayMember = BLL.Procedures._H_PROVEEDORES.ColumnNames.PRO_RAZSOC;
                this.comboBoxProveed.ValueMember = BLL.Procedures._H_PROVEEDORES.ColumnNames.PRO_COD;
                this.comboBoxProveed.DataSource = _prov.Result.ToArray();

                this.comboBoxProveed.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #endregion

        #region Eventos


        private void Frm_ImprimirOC_Load_1(object sender, EventArgs e)
        {
            try
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
                Clases.Empresa.CargarEmpresas(comboBoxEmpresa);

                if (this.radioButtonPorOC.Checked)
                {
                    this.dateTimePickerFechaDesde.Enabled = false;
                    this.dateTimePickerFechaHasta.Enabled = false;
                    
                }

                this.comboBoxEmpresa.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();

                CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
                     

         

               private void toolStripButtonPrint_Click_1(object sender, EventArgs e)
               {
                    try
                    {
                        if(radioButtonPorOC.Checked)
                        {
                            if(textBoxOCDesde.Text == string.Empty && this.textBoxOCHasta.Text == string.Empty)
                            {
                                 MessageBox.Show("Debe ingresar Nro. de Orden de compra Desde, Hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                Impresion();

                            }
                        
                        }
                        else
                        {
                            Impresion();
                        }




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                 }

               private void radioButtonPorOC_CheckedChanged(object sender, EventArgs e)
               {
                 

                    this.dateTimePickerFechaDesde.Enabled = false;
                    this.dateTimePickerFechaHasta.Enabled = false;
                    this.textBoxOCDesde.Enabled = true;
                    this.textBoxOCHasta.Enabled = true;
                    this.dateTimeProveedDesde.Enabled = false;
                    this.dateTimeProveedHasta.Enabled = false;

                }

               private void radioButtonPorFecha_CheckedChanged(object sender, EventArgs e)
               {
                   this.dateTimePickerFechaDesde.Enabled = true;
                   this.dateTimePickerFechaHasta.Enabled = true;
                   this.textBoxOCDesde.Enabled = false;
                   this.textBoxOCHasta.Enabled = false;
                   this.dateTimeProveedDesde.Enabled = false;
                   this.dateTimeProveedHasta.Enabled = false;

        }
               
        private void textBoxOCDesde_KeyPress(object sender, KeyPressEventArgs e)
           {
               if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                   e.Handled = false;
               else
                   e.Handled = true;

           }


            

        private void textBoxOCHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

           

        private void textBoxOCDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxOCHasta.Focus();
            }
        }

        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
          
               CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
          
        }

        private void radioButtonProveedor_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePickerFechaDesde.Enabled = false;
            this.dateTimePickerFechaHasta.Enabled = false;
            this.textBoxOCDesde.Enabled = false;
            this.textBoxOCHasta.Enabled = false;
            this.dateTimeProveedDesde.Enabled = true;
            this.dateTimeProveedHasta.Enabled = true;
        }
    }
}
