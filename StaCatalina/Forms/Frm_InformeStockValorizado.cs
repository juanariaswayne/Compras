﻿using System;
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
    public partial class Frm_InformeStockValorizado : Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        #endregion

        #region Funciones
        public Frm_InformeStockValorizado()
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

        #endregion

        #region Eventos

        private void Frm_InformeStockValorizado_Load(object sender, EventArgs e)
        {

            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StaCatalina.Forms.Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "InformeStockValorizado.rpt";
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


    }
}
