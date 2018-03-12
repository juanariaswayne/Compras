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
    public partial class Frm_PrecioCompra : Plantilla
    {
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        #region Funciones
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

            public Frm_PrecioCompra()
            {
                InitializeComponent();
            }

            private void CargarRubros()
            {
                 try
                {
                    BLL.Procedures.TRAESUBRUBROSEMPRESA _prov = new BLL.Procedures.TRAESUBRUBROSEMPRESA();
                    _prov.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim());
                    Entities.Procedures.TRAESUBRUBROSEMPRESA _itemSeleccion = new Entities.Procedures.TRAESUBRUBROSEMPRESA();

                    //Limpia el combo
                    this.comboBoxRubro.SuspendLayout();
                    this.comboBoxRubro.DataSource = null;
                    this.comboBoxRubro.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.da2_desc = "<Seleccione un Rubro>";
                    _itemSeleccion.da2_cod = "0";
                    _prov.Result.Insert(0, _itemSeleccion);

                    //Carga el combo
                    this.comboBoxRubro.DisplayMember = BLL.Procedures.TRAESUBRUBROSEMPRESA.ColumnNames.DA2_DESC;
                    this.comboBoxRubro.ValueMember = BLL.Procedures.TRAESUBRUBROSEMPRESA.ColumnNames.DA2_COD;
                    this.comboBoxRubro.DataSource = _prov.Result.ToArray();

                    this.comboBoxRubro.ResumeLayout();



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

            private void PrecioDeCompra(int _tipoInforme,int _filtro, string _rubro, string _codigo , string _codLike, int _orden)
            {
                try
                {
                    StaCatalina.Forms.Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();
                    
                    if (_tipoInforme == 1) //REPORTE ULTIMA COMPRA
                    {
                        String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "PrecioUltimaCompra.rpt";
                        objReport.Load(reportPath);
                    }
                    else // REPORTE TRES ULTIMAS COMPRAS
                    {
                        String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "PrecioTresUltimasCompras.rpt";
                        objReport.Load(reportPath);
                    }
                       
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
                    ParametroField.Name = "@Filtro";
                    ParametroValue.Value = _filtro;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@Rubro";
                    ParametroValue.Value = _rubro;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //3° PARAMETRO
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
                    ParametroValue.Value = _codLike;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);

                    //4° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@orden";
                    ParametroValue.Value = _orden;
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
        #region Eventos
            private void FrmPrecioCompra_Load(object sender, EventArgs e)
            {
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();

                CargarRubros(); //EN REALIDAD TRAE LOS SUB RUBROS
                CargarArticulos();
            }

            private void toolStripButtonPrint_Click(object sender, EventArgs e)
            {
             
                // INFORME GENERAL
                if (this.radioButtonGeneral.Checked) 
                {
                    //ORDENADO POR ARTICULO
                    if (this.radioButtonOrdenArticulo.Checked)
                    {
                        if (this.radioButtonUltima.Checked) 
                        {
                            PrecioDeCompra(1, 1, null, null, null, 1); //REPORTE ULTIMA COMPRA
                        }
                        else 
                        {
                            PrecioDeCompra(2, 1, null, null, null, 1); //REPORTE TRES ULTIMAS COMPRAS
                        }
                    }
                    
                    //ORDENADO POR RUBRO
                    if (this.radioButtonOrdenRubro.Checked)
                    {
                        if (this.radioButtonUltima.Checked)
                        {
                            PrecioDeCompra(1, 1, null, null, null, 2);//REPORTE ULTIMA COMPRA
                        }
                        else
                        {
                            PrecioDeCompra(2, 1, null, null, null, 2);//REPORTE TRES ULTIMAS COMPRAS
                        }
                    }

                    //ORDENADO POR PROVEEDOR
                    if (this.radioButtonOrdenProveed.Checked)
                    {
                        if (this.radioButtonUltima.Checked)
                        {
                            PrecioDeCompra(1, 1, null, null, null, 3);//REPORTE ULTIMA COMPRA
                        }
                        else
                        {
                            PrecioDeCompra(2, 1, null, null, null, 3);//REPORTE TRES ULTIMAS COMPRAS
                        }
                    }
                }
                    
                // INFORME POR UN RUBRO
                if (this.radioButtonRubro.Checked) 
                {
                    if (this.comboBoxRubro.SelectedIndex != 0)
                    {
                        //ORDENADO POR ARTICULO
                        if (this.radioButtonOrdenArticulo.Checked)
                        {
                            if (this.radioButtonUltima.Checked)
                            {
                                PrecioDeCompra(1, 2, this.comboBoxRubro.SelectedValue.ToString(), null, null, 1); //REPORTE ULTIMA COMPRA
                            }
                            else
                            {
                                PrecioDeCompra(2, 2, this.comboBoxRubro.SelectedValue.ToString(), null, null, 1); //REPORTE TRES ULTIMAS COMPRAS
                            }
                        }

                        //ORDENADO POR RUBRO
                        if (this.radioButtonOrdenRubro.Checked)
                        {
                            if (this.radioButtonUltima.Checked)
                            {
                                PrecioDeCompra(1, 2, this.comboBoxRubro.SelectedValue.ToString(), null, null, 2);//REPORTE ULTIMA COMPRA
                            }
                            else
                            {
                                PrecioDeCompra(2, 2, this.comboBoxRubro.SelectedValue.ToString(), null, null, 2);//REPORTE TRES ULTIMAS COMPRAS
                            }
                        }

                        //ORDENADO POR PROVEEDOR
                        if (this.radioButtonOrdenProveed.Checked)
                        {
                            if (this.radioButtonUltima.Checked)
                            {
                                PrecioDeCompra(1, 2, this.comboBoxRubro.SelectedValue.ToString(), null, null, 3);//REPORTE ULTIMA COMPRA
                            }
                            else
                            {
                                PrecioDeCompra(2, 2, this.comboBoxRubro.SelectedValue.ToString(), null, null, 3);//REPORTE TRES ULTIMAS COMPRAS
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un Rubro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                // INFORME POR UN ARTICULO
                if (this.radioButtonArticulo.Checked)
                {
                    if (this.comboBoxArticulo.SelectedIndex != 0)
                    {
                        //ORDENADO POR ARTICULO
                        if (this.radioButtonOrdenArticulo.Checked)
                        {
                            if (this.radioButtonUltima.Checked)
                            {
                                PrecioDeCompra(1, 3, null, this.comboBoxArticulo.SelectedValue.ToString(), null, 1);//REPORTE ULTIMA COMPRA
                            }
                            else
                            {
                                PrecioDeCompra(2, 3, null, this.comboBoxArticulo.SelectedValue.ToString(), null, 1);//REPORTE TRES ULTIMAS COMPRAS
                            }
                        }

                        //ORDENADO POR RUBRO
                        if (this.radioButtonOrdenRubro.Checked)
                        {
                            if (this.radioButtonUltima.Checked)
                            {
                                PrecioDeCompra(1, 3, null, this.comboBoxArticulo.SelectedValue.ToString(), null, 2);//REPORTE ULTIMA COMPRA
                            }
                            else
                            {
                                PrecioDeCompra(2, 3, null, this.comboBoxArticulo.SelectedValue.ToString(), null, 2);//REPORTE TRES ULTIMAS COMPRAS
                            }

                        }

                        //ORDENADO POR PROVEEDOR
                        if (this.radioButtonOrdenProveed.Checked)
                        {
                            if (this.radioButtonUltima.Checked)
                            {
                                PrecioDeCompra(1, 3, null, this.comboBoxArticulo.SelectedValue.ToString(), null, 3);//REPORTE ULTIMA COMPRA
                            }
                            else
                            {
                                PrecioDeCompra(2, 3, null, this.comboBoxArticulo.SelectedValue.ToString(), null, 3);//REPORTE TRES ULTIMAS COMPRAS
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un Artículo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                // INFORME ARTICULO QUE COMIENZAN CON ....
                if (this.radioButtonLike.Checked)
                {
                    if (this.textBoxLike.Text != string.Empty)
                    {
                        string _palabra;
                        _palabra = this.textBoxLike.Text.ToString().Trim()+'%';

                        //ORDENADO POR ARTICULO
                        if (this.radioButtonOrdenArticulo.Checked)
                        {
                            if (this.radioButtonUltima.Checked)
                            {
                                PrecioDeCompra(1, 4, null, null, _palabra, 1);//REPORTE ULTIMA COMPRA
                            }
                            else
                            {
                                PrecioDeCompra(2, 4, null, null, _palabra, 1);//REPORTE TRES ULTIMAS COMPRAS
                            }
                        }

                        //ORDENADO POR RUBRO
                        if (this.radioButtonOrdenRubro.Checked)
                        {
                            if (this.radioButtonUltima.Checked)
                            {
                                PrecioDeCompra(1, 4, null, null, _palabra, 2);//REPORTE ULTIMA COMPRA
                            }
                            else
                            {
                                PrecioDeCompra(2, 4, null, null, _palabra, 2);//REPORTE TRES ULTIMAS COMPRAS
                            }
                        }

                        //ORDENADO POR PROVEEDOR
                        if (this.radioButtonOrdenProveed.Checked)
                        {
                            if (this.radioButtonUltima.Checked)//ORDEN POR PROVEEDOR SOLO APLICA AL REPORTE ULTIMA COMPRA
                            {
                                PrecioDeCompra(1, 4, null, null, _palabra, 3);//REPORTE ULTIMA COMPRA
                            }
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar una palabra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
           

            }

            private void radioButtonUltima_CheckedChanged(object sender, EventArgs e)
            {
                radioButtonOrdenProveed.Enabled = true;
            }

            private void radioButtonTresUltimas_CheckedChanged(object sender, EventArgs e)
            {
                radioButtonOrdenProveed.Enabled = false;
            }

            private void radioButtonGeneral_CheckedChanged(object sender, EventArgs e)
            {
                this.comboBoxRubro.SelectedIndex = 0;
                this.comboBoxArticulo.SelectedIndex = 0;
                this.textBoxLike.Text = string.Empty;
            }

            private void radioButtonLike_CheckedChanged(object sender, EventArgs e)
            {
                this.comboBoxRubro.SelectedIndex = 0;
                this.comboBoxArticulo.SelectedIndex = 0;
                this.textBoxLike.Text = string.Empty;
            }

            private void radioButtonRubro_CheckedChanged(object sender, EventArgs e)
            {
                this.comboBoxArticulo.SelectedIndex = 0;
                this.textBoxLike.Text = string.Empty;
            }

            private void radioButtonArticulo_CheckedChanged(object sender, EventArgs e)
            {
                this.comboBoxRubro.SelectedIndex = 0;
                this.textBoxLike.Text = string.Empty;
            }


        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
