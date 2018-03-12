using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using StaCatalina.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina
{
    public partial class Frm_ControlLibreria : Plantilla
    {
        #region Variables
        private enum Col_Articulos
            {
              Codigo = 0,
              Articulo,
              CantRecibida,
              CantEnviada
            }
        #endregion

        #region Funciones
        public Frm_ControlLibreria()
        {
            InitializeComponent();
        }

        private void TraeReq(DateTime _FechaDesde, DateTime _FechaHasta)

        {
            try
            {
                this.dataGridViewArticulos.Rows.Clear();
                int indice;

                BLL.Procedures.TRAEREQUERIMIENTOSLIBRERIA _detalle = new BLL.Procedures.TRAEREQUERIMIENTOSLIBRERIA();
                Entities.Procedures.TRAEREQUERIMIENTOSLIBRERIA _items = new Entities.Procedures.TRAEREQUERIMIENTOSLIBRERIA();

                this.dataGridViewArticulos.Rows.Clear();
                //FILTRO LAS OC DE LA EMPRESA LOGEADA Y ME DEVUELVE LAS ORDENES QUE ESTE USUARIO AUTORIZO               

                foreach (Entities.Procedures.TRAEREQUERIMIENTOSLIBRERIA item in _detalle.ItemList(_FechaDesde, _FechaHasta))
                {
                    indice = dataGridViewArticulos.Rows.Add();
                    dataGridViewArticulos.Rows[indice].Cells[(int)Col_Articulos.Codigo].Value = item.articulo_id;//CODIGO DE EMPRESA
                    dataGridViewArticulos.Rows[indice].Cells[(int)Col_Articulos.Articulo].Value = item.art_descgen;                   
                    dataGridViewArticulos.Rows[indice].Cells[(int)Col_Articulos.CantEnviada].Value = item.cantidad;//FECHA                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion

        #region Eventos
        private void buttonCerrarPeriodo_Click(object sender, EventArgs e)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                Entities.Tables.STK_CONTROLLIBRERIA _LibItem = new Entities.Tables.STK_CONTROLLIBRERIA();
                BLL.Tables.STK_CONTROLLIBRERIA _Items = new BLL.Tables.STK_CONTROLLIBRERIA();


                for (int i = 0; i < this.dataGridViewArticulos.Rows.Count - 1; i++)
                {
                    _LibItem = new Entities.Tables.STK_CONTROLLIBRERIA();
                    _LibItem.CODEMP = Clases.Usuario.EmpresaLogeada.EmpresaIngresada;
                    _LibItem.ANIO = DateTime.Today.Year;
                    _LibItem.PERIDODO = comboBoxPeriodo.Text;
                    _LibItem.ARTICULO_ID = dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.Codigo].Value.ToString();
                    _LibItem.CANT_RECIBIDA = Convert.ToDecimal(dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.CantRecibida].Value, culture);
                    _LibItem.CANT_SOLICITADA = Convert.ToDecimal(dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.CantEnviada].Value, culture);

                    _Items.AddItem(_LibItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Frm_ControlLibreria_Load(object sender, EventArgs e)
        {
            try
            {
                string _anio = DateTime.Now.Year.ToString();
                this.groupBoxPeriodo.Text = "Periodo a cerrar: Año " + _anio;

                TraeReq(this.dateTimePickerDesde.Value,this.dateTimePickerHasta.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void dateTimePickerDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TraeReq(this.dateTimePickerDesde.Value, this.dateTimePickerHasta.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TraeReq(this.dateTimePickerDesde.Value, this.dateTimePickerHasta.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "PlanillaControlLibreria.rpt";
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
                ParametroField.Name = "@FechaDesde";
                ParametroValue.Value = this.dateTimePickerDesde.Value;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaHasta";
                ParametroValue.Value = this.dateTimePickerHasta.Value;
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
    }
}
