using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using System.IO;

namespace StaCatalina.Forms


{
    public partial class Frm_ImpresionEtiquetas : StaCatalina.Plantilla
    {
        #region variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;
            CultureInfo culture = new CultureInfo("en-US");
            List<Entities.Procedures.H_ARTICULOSDEPOSITO> _ItemsArticulos = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        private enum eTiposCodigo
        {
            Codabar = 0,
            Ean13,
            Ean13Nochecksum,
            Code39,
            Code128,
            PDF417,
            Datamatrix
        }
        #endregion

        #region Funciones
        public Frm_ImpresionEtiquetas()
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

        private void CargarProductosBejerman()
        {
            try
            {
                BLL.Procedures.H_ARTICULOSDEPOSITO _prod = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                Entities.Procedures.H_ARTICULOSDEPOSITO _itemSeleccion = new Entities.Procedures.H_ARTICULOSDEPOSITO();
               

                //Limpia el combo

                this.comboBoxProductos.SuspendLayout();
                this.comboBoxProductos.DataSource = null;
                this.comboBoxProductos.Items.Clear();



                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione un Artículo>";
                _itemSeleccion.art_codgen = "0";

                _ItemsArticulos = _prod.ItemList(); //Carga la lista para llenar el combo;
                _ItemsArticulos.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxProductos.DisplayMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_DESCGEN;
                this.comboBoxProductos.ValueMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_CODGEN;
                this.comboBoxProductos.DataSource = _ItemsArticulos;

                this.comboBoxProductos.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Imprime(int _cantCopias, string _descripcion,String _codigoBarra)
        {
            StaCatalina.Forms.Reports _Reporte = new Reports();
            ReportDocument objReport = new ReportDocument();

            String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "Etiquetas.rpt";
            objReport.Load(reportPath);
            objReport.Refresh();
            objReport.ReportOptions.EnableSaveDataWithReport = false;

            _Reporte.Reporte = objReport;
            objReport.SetParameterValue("DescripProd", _descripcion);
            objReport.SetParameterValue("Vto", this.dateTimeVto.Value);
            if (labelVto.Visible)
            {
                objReport.SetParameterValue("ImprimeVto", true);
            }
            else
            {
                objReport.SetParameterValue("ImprimeVto", false);
            }
            //objReport.SetParameterValue("CodigoBarra", _codigoBarra);

            objReport.PrintToPrinter(_cantCopias, false, 0, 0); // cantidad de copias, si se intercalan, primera página, segunda página

            //pictureBox1.Dispose();

        }
        #endregion

        #region Eventos
        private void Frm_ImpresionEtiquetas_Load(object sender, EventArgs e)
        {
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            CargarProductosBejerman();
        }
               

        private void textBoxCantEtiquetas_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = culture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxUniXBulto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = culture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxCodigo.Text = string.Empty;
            this.textBoxCantEtiquetas.Text = string.Empty;
            this.textBoxUniXBulto.Text = string.Empty;
            this.labelDescripcionArt.Text = string.Empty;

            if (this.comboBoxProductos.SelectedIndex > 0)
            {
                this.textBoxCodigo.Text = this.comboBoxProductos.SelectedValue.ToString();
                this.textBoxCantEtiquetas.Focus();
                this.labelDescripcionArt.Text = this.comboBoxProductos.Text.ToString();
                labelVto.Visible = false;
                dateTimeVto.Visible = false;

                //VERIFICO SI ESTE ARTICULO LLEVA VTO.
                BLL.Tables.STKARTICULOS _vto = new BLL.Tables.STKARTICULOS();
                _vto.WhereParameter.Add(DAL.Tables.STKARTICULOS.ColumnEnum.articulo_id, DAL.SqlEnums.OperandEnum.Equal, textBoxCodigo.Text.ToString().Trim());
                _vto.ItemList();
                if (_vto.Resultset.Count > 0)
                {
                  bool _llevaVto = _vto.Resultset[0].LLEVAVENCIMIENTO;
                  if(_llevaVto)
                    {
                        labelVto.Visible = true;
                        dateTimeVto.Visible = true;
                    }
                  else
                    {
                        labelVto.Visible = false;
                        dateTimeVto.Visible = false;
                    }
                   
                }

                //TRAIGO LA UNIDAD DE MEDIDA DE BEJERMAN
                textBoxUniMedBejerman.Text = _ItemsArticulos.Find(x => x.art_codgen.Contains(this.comboBoxProductos.SelectedValue.ToString())).unimed;
                labelDescripUniMed.Text =  _ItemsArticulos.Find(x => x.art_codgen.Contains(this.comboBoxProductos.SelectedValue.ToString())).cla_desc;
            }
        }

        private void textBoxCantEtiquetas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.textBoxUniXBulto.Focus();
        }

        #endregion

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxCodigo.Text != string.Empty && this.textBoxCantEtiquetas.Text != string.Empty && this.textBoxUniXBulto.Text != string.Empty)
                {
                    Int32 _cantidad;
                    string _codProd;
                    Bitmap bm = null;
                    char pad = '0';
                    string _texto;
                    string _descripProd;
                    string _uniBulto;

                    _codProd = this.textBoxCodigo.Text.ToString().Trim(); //CODIGO PRODUCTO
                    _cantidad = Convert.ToInt32(this.textBoxCantEtiquetas.Text); //CANT DE ETIQUETAS A IMPRIMIR 
                    _descripProd = this.labelDescripcionArt.Text.ToString().Trim(); // this.comboBoxProductos.SelectedText.ToString().Trim();//DESCRIPCION DEL PRODUCTO
                    //UNIDADES POR BULTO, ES LA CANTIDAD QUE SE DARA DE BAJA CUNADO SE LEE ESTA ETIQUETA
                    _uniBulto = this.textBoxUniXBulto.Text.ToString();

                    _texto = _codProd.PadLeft(7, pad) + _uniBulto.PadLeft(7, pad) + dateTimeVto.Value.Year.ToString()+dateTimeVto.Value.Month.ToString().PadLeft(2, pad) + dateTimeVto.Value.Day.ToString().PadLeft(2,pad);
                    
                    if (_descripProd.Length > 0)
                    {

                        bm = BarCode.BarCode.Code128(_texto, (int)BarCode.BarCode.Code128SubTypes.CODE128_UCC, true, 50);
                        if (bm != null)
                        {
                            pictureBox1.Image = bm;

                            pictureBox1.Image.Save("\\\\192.168.5.10\\Bejerman\\compartida\\Reporting\\Santa Catalina\\codbar.Bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                            //YA NO GACE FALTA GUARDAR LA IMAGEN
                            Imprime (_cantidad, _descripProd, _texto);

                    }
                }
                    else
                    {
                        MessageBox.Show("Debe ingresar todos los datos para impirmir las etiquetas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Debe ingresar todos los datos para impirmir las etiquetas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
