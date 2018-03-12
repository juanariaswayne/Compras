using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using System.Globalization;

namespace StaCatalina.Forms
{
    public partial class Frm_ConsumoArticulos : Plantilla
    {
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        #region Funciones
            public Frm_ConsumoArticulos()
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

            private void CargarArticulos()
            {
                try
                {
                    BLL.Procedures._H_ARTICULOS _prov = new BLL.Procedures._H_ARTICULOS();
                    _prov.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim());
                    Entities.Procedures._H_ARTICULOS _itemSeleccion = new Entities.Procedures._H_ARTICULOS();

                    //Limpia el combo
                    this.comboBoxArticulo.SuspendLayout();
                    this.comboBoxArticulo.DataSource = null;
                    this.comboBoxArticulo.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.descripcion = "<Seleccione un Artículo>";
                    _itemSeleccion.art_codgen = "0";
                    _prov.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxArticulo.DisplayMember = BLL.Procedures._H_ARTICULOS.ColumnNames.DESCRIPCION;
                    this.comboBoxArticulo.ValueMember = BLL.Procedures._H_ARTICULOS.ColumnNames.ART_CODGEN;
                    this.comboBoxArticulo.DataSource = _prov.Result.ToArray();

                    this.comboBoxArticulo.ResumeLayout();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            private void Consumo(int _tipo,int _AnioActual, int _MesActual, int _Anio_1, int _Mes_1, int _Mes_2,string _codigo,string _like)
            {
                try
                {
                    StaCatalina.Forms.Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();
                   
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "ConsumoArticulos.rpt";
                    objReport.Load(reportPath);
                  
                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;

                    // PARAMETROS DE CONEXION
                    TableLogOnInfo logoninfo = new TableLogOnInfo();
                    logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source"];
                    if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                    {
                        logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["Catalog"];
                    }
                    else
                    {
                        logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogSBDARSC"];
                    }
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
                    ParametroField.Name = "@Tipo";
                    ParametroValue.Value = _tipo;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@AnioAct";
                    ParametroValue.Value = _AnioActual;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@MesAct";
                    ParametroValue.Value = _MesActual;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //3° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Anio_1";
                    ParametroValue.Value = _Anio_1;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //4° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Mes_1";
                    ParametroValue.Value = _Mes_1;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //4° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Mes_2";
                    ParametroValue.Value = _Mes_2;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //4° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Codigo";
                    ParametroValue.Value = _codigo;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //4° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@CodLike";
                    ParametroValue.Value = _like;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //5° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@codEmp";
                    ParametroValue.Value = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();
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
        #endregion
        #region eventos
            private void FrmConsumoArticulos_Load(object sender, EventArgs e)
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
                this.textBoxAnio.Text = DateTime.Now.Year.ToString();
                this.textBoxMes.Text = DateTime.Now.Month.ToString();
                
                CargarArticulos();
            }

            private void textBoxAnio_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                    this.textBoxMes.Focus();
            }

            private void textBoxAnio_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }

            private void textBoxMes_Leave(object sender, EventArgs e)
            {
                if (Convert.ToInt16(textBoxMes.Text) < 1 || Convert.ToInt16(textBoxMes.Text) > 12)
                {
                    MessageBox.Show("El mes debe ser un número entre 1 y 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBoxMes.Focus();
                }
            }

            private void textBoxMes_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        #endregion

            private void toolStripButtonPrint_Click(object sender, EventArgs e)
            {
                if (this.textBoxAnio.Text == string.Empty || this.textBoxMes.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar un Año y mes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBoxAnio.Focus();
                }
                else
                {
                    int _anioActual;
                    int _mesActual;
                    int _anio_1;
                    int _mes_1;
                    int _mes_2;
                    int _tipo=0;
                    string _codigo=null;
                    string _like=null;

                    _anioActual = Convert.ToInt32(this.textBoxAnio.Text.ToString()); //AÑO ACTUAL
                    _mesActual = Convert.ToInt32(this.textBoxMes.Text.ToString()); // MES ACTUAL
                    if (this.textBoxMes.Text == "1")
                    {
                        //ESTOY EN ENERO, POR LO TANTO DEBO TRAER EL AÑO MENOS 1
                        _anio_1 = _anioActual - 1;
                        _mes_1 = 12;
                        _mes_2 = 11;
                    }
                    else
                    {
                        //ESTOY ENTRE EL MES DE FEBRERO Y DICIEMBRE
                        _anio_1 = _anioActual;
                        _mes_1 = _mesActual-1;
                        _mes_2 = _mesActual-2;
                    }

                    if (this.radioButtonGeneral.Checked)
                    {
                        _tipo = 1;
                        _codigo = null;
                        _like = null;
                    }

                    if (this.radioButtonArticulo.Checked)
                    {
                        _tipo = 2;
                        _codigo =this.comboBoxArticulo.SelectedValue.ToString();
                        _like = null;
                    }

                    if (this.radioButtonLike.Checked)
                    {
                        _tipo = 3;
                        _codigo = null;
                        _like = this.textBoxLike.Text.ToString().Trim() + '%';
                    }

                    Consumo(_tipo, _anioActual, _mesActual, _anio_1, _mes_1, _mes_2, _codigo, _like);

                }
            }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
