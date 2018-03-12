using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_InformeTrazabilidadOcReq : Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        #endregion

        #region Funciones
        public Frm_InformeTrazabilidadOcReq()
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

        private void IniciarControles()
        {
            try
            {
                this.radioButtonFechas.Checked = true;
                this.radioButtonPorOC.Checked = false;
                this.radioButtonPorReq.Checked = false;
                this.textBoxOC.Enabled = false;
                this.textBoxReq.Enabled = false;

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
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "InformeTrazabilidadOcReq.rpt";
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
                ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);


                //2do PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@TipoInf";
                if (this.radioButtonFechas.Checked)
                {
                    ParametroValue.Value = "FEC";
                }
                if (this.radioButtonPorOC.Checked)
                {
                    ParametroValue.Value = "OC";
                }
                if (this.radioButtonPorReq.Checked)
                {
                    ParametroValue.Value = "REQ"; // POR REQ
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);
               
                //3er PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaDesde";
                if (radioButtonFechas.Checked)
                {

                    ParametroValue.Value = this.dateTimePickerDesde.Value.ToString("yyyy-MM-dd 00:00:00");
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
                ParametroField.Name = "@FechaHasta";
                if (radioButtonFechas.Checked)
                {

                    ParametroValue.Value = this.dateTimePickerHasta.Value.ToString("yyyy-MM-dd 23:59:59");
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
                ParametroField.Name = "@OC";
                if (radioButtonPorOC.Checked)
                {
                    ParametroValue.Value = this.textBoxOC.Text;
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
                ParametroField.Name = "@Req";
                if (radioButtonPorReq.Checked)
                {
                    ParametroValue.Value = textBoxReq.Text;
                }
                else
                {
                    ParametroValue.Value = null;
                }

                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);
                
                //PARAMETRO DE TIPO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Tipo";
                if (radioButtonPorRubro.Checked)
                {
                    ParametroValue.Value = "RUB";
                }
                else
                {
                    ParametroValue.Value = "SUB";
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //PARAMETRO DE RUBRO O SUB RUBRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@Rubro_sub";
                if (radioButtonPorRubro.Checked)
                {
                    ParametroValue.Value = comboBoxRubro.SelectedValue.ToString(); ;
                }
                else
                {
                    ParametroValue.Value =comboBoxSubRubro.SelectedValue.ToString();
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

        private void CargarRubros()
        {
            try
            {
                Entities.Procedures.RUBROARTICULOS _itemSeleccion = new Entities.Procedures.RUBROARTICULOS();
                BLL.Procedures.RUBROARTICULOS _rubroItem = new BLL.Procedures.RUBROARTICULOS();
                _rubroItem.Items();
                //Limpia el combo
                this.comboBoxRubro.SuspendLayout();
                this.comboBoxRubro.DataSource = null;
                this.comboBoxRubro.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.da1_desc = "<Todos los Rubros>";
                _itemSeleccion.da1_cod = "0";
                _rubroItem.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxRubro.DisplayMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_DESC;
                this.comboBoxRubro.ValueMember = BLL.Procedures.RUBROARTICULOS.ColumnNames.DA1_COD;
                this.comboBoxRubro.DataSource = _rubroItem.Result.ToArray();
                this.comboBoxRubro.ResumeLayout();
                this.comboBoxRubro.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarSubRubros()
        {
            try
            {

                BLL.Procedures.TRAESUBRUBROSEMPRESA _rubro = new BLL.Procedures.TRAESUBRUBROSEMPRESA();
                List<Entities.Procedures.TRAESUBRUBROSEMPRESA> _rubroItem = new List<Entities.Procedures.TRAESUBRUBROSEMPRESA>();
                Entities.Procedures.TRAESUBRUBROSEMPRESA _itemSeleccion = new Entities.Procedures.TRAESUBRUBROSEMPRESA();

                _rubroItem = _rubro.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());//le paso la colección de rubros

                //Limpia el combo
                this.comboBoxSubRubro.SuspendLayout();
                this.comboBoxSubRubro.DataSource = null;
                this.comboBoxSubRubro.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.da2_desc = "<Todos los Sub Rubro>";
                _itemSeleccion.da2_cod = "0";
                _rubroItem.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSubRubro.DisplayMember = BLL.Procedures.TRAESUBRUBROSEMPRESA.ColumnNames.DA2_DESC;
                this.comboBoxSubRubro.ValueMember = BLL.Procedures.TRAESUBRUBROSEMPRESA.ColumnNames.DA2_COD;
                this.comboBoxSubRubro.DataSource = _rubroItem;
                this.comboBoxSubRubro.SelectedIndex = 0;

                this.comboBoxSubRubro.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #endregion

        #region Eventos
        private void Frm_InformeTrazabilidadOcReq_Load(object sender, EventArgs e)
        {
            try
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
                CargarRubros();
                CargarSubRubros();


                IniciarControles();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void radioButtonFechas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.radioButtonFechas.Checked)
                {
                    this.dateTimePickerDesde.Enabled = true;
                    this.dateTimePickerHasta.Enabled = true;
                }
                else
                {
                    this.dateTimePickerDesde.Enabled = false;
                    this.dateTimePickerHasta.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void radioButtonPorOC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.radioButtonPorOC.Checked)
                {
                    this.textBoxOC.Enabled = true;
                    
                }
                else
                {
                    this.textBoxOC.Enabled = false;
                }
                comboBoxRubro.SelectedIndex = 0;
                comboBoxSubRubro.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void radioButtonPorReq_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.radioButtonPorReq.Checked)
                {
                    this.textBoxReq.Enabled = true;

                }
                else
                {
                    this.textBoxReq.Enabled = false;
                }
                comboBoxRubro.SelectedIndex = 0;
                comboBoxSubRubro.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {           
                Impresion();
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comboBoxSubRubro.Items.Count > 0)
            //    comboBoxSubRubro.SelectedIndex = 0;
        }

        private void comboBoxSubRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comboBoxRubro.Items.Count > 0)
            //    comboBoxRubro.SelectedIndex = 0;
        }

        private void radioButtonPorSubRubro_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxRubro.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSubRubro.SelectedIndex = 0;
        }
    }
}
