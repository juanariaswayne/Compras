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
using System.Net.Mail;
using System.Net;

namespace StaCatalina.Forms
{
    public partial class Frm_ReclamoMercaderia : Plantilla
    {

        #region Variables

        private List<Entities.Procedures.H_ARTICULOSDEPOSITO> _articulosItem = new List<Entities.Procedures.H_ARTICULOSDEPOSITO>();
        public List<Entities.Procedures.H_ARTICULOSDEPOSITO> Articulos
        {
            get { return _articulosItem; }
            set { _articulosItem = value; }

        }

        private enum Col_Articulos
        {
            ARTICULOID = 0,
            DESCRIPCION,
            CANTIDADFALTANTE,
            CANTIDADDEMAS,
            RECIBIDOPORERROR,
            ANOTACION

        }

        private int _MAXIMO;
        #endregion

        #region Funciones
        public Frm_ReclamoMercaderia()
        {
            InitializeComponent();
        }
        private void CargarDepositos()
        {
            try
            {
                BLL.Tables.STKDEPOSITO _dep = new BLL.Tables.STKDEPOSITO();
                _dep.OrderByParameter.Add(DAL.Tables.STKDEPOSITO.ColumnEnum.descripcion);
                _dep.ItemList();
                Entities.Tables.STKDEPOSITO _itemSeleccion = new Entities.Tables.STKDEPOSITO();

                //Limpia el combo
                this.comboBoxDeposito.SuspendLayout();
                this.comboBoxDeposito.DataSource = null;
                this.comboBoxDeposito.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Todos los Depósito>";
                _itemSeleccion.DEPOSITO_ID = 0;
                _dep.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxDeposito.DisplayMember = BLL.Tables.STKDEPOSITO.ColumnNames.DESCRIPCION;
                this.comboBoxDeposito.ValueMember = BLL.Tables.STKDEPOSITO.ColumnNames.DEPOSITO_ID;
                this.comboBoxDeposito.DataSource = _dep.Result.ToArray();

                this.comboBoxDeposito.ResumeLayout();
                this.comboBoxDeposito.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void GenerarPDF(int PlantillaID)
        {
            try
            {
                //string SPath  = this.saveFileDialog1.FileName = "Cotizacion_Nro_" + this.saveFileDialog1.FileName; // Default file name
                //this.saveFileDialog1.DefaultExt = ".PDF"; // Default file extension
                //this.saveFileDialog1.Filter = "Text documents (.pdf)|*.pdf"; // Filter files by extension

                //if (this.saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                //{
                    string SPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "\\PDF\\" + "Reclamo.pdf"; // = "Cotizacion_Nro_" + _nroCotizacion; // Default file name

                    ReportDocument objReport = new ReportDocument();
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "InformeReclamoMercaderia.rpt";

                    objReport.Load(reportPath);

                    this.progressBar1.Step = 30;
                    
                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;

                    // PARAMETROS DE CONEXION
                    CrystalDecisions.Shared.TableLogOnInfo logoninfo = new CrystalDecisions.Shared.TableLogOnInfo();
                    logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogSTACATALINA"];
                    logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source"];
                    logoninfo.ConnectionInfo.UserID = ConfigurationManager.AppSettings["User ID"];
                    logoninfo.ConnectionInfo.Password = ConfigurationManager.AppSettings["Password"];

                    logoninfo.ConnectionInfo.IntegratedSecurity = false; //cambiado a false por la linea de arriba
                    Tables tables = objReport.Database.Tables;
                    foreach (Table table in tables)
                    {
                        table.ApplyLogOnInfo(logoninfo);
                    }

                    //PRIMER PARAMTRO

                    objReport.SetParameterValue(0, PlantillaID);
                    this.progressBar1.Value = 40; 

                    //GUARDO EN FORMATO PDF
                    objReport.ExportToDisk(ExportFormatType.PortableDocFormat, SPath.ToString());
                    this.progressBar1.Value = 60;
                    EnviarMail(SPath);
                    
                    //MessageBox.Show("Se generó el archivo PDF: ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarSectoresDeposito(string _codEmp, int _dep)
        {
            try
            {
                BLL.Tables.STKSECTOR _sec = new BLL.Tables.STKSECTOR();
                _sec.OrderByParameter.Add(DAL.Tables.STKSECTOR.ColumnEnum.descripcion);
                _sec.ItemList(_codEmp, _dep);

                Entities.Tables.STKSECTOR _itemSeleccion = new Entities.Tables.STKSECTOR();

                //Limpia el combo
                this.comboBoxSector.SuspendLayout();
                this.comboBoxSector.DataSource = null;
                this.comboBoxSector.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Todos los Sectores>";
                _itemSeleccion.SECTOR_ID = 0;
                _sec.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSector.DisplayMember = BLL.Tables.STKSECTOR.ColumnNames.DESCRIPCION;
                this.comboBoxSector.ValueMember = BLL.Tables.STKSECTOR.ColumnNames.SECTOR_ID;
                this.comboBoxSector.DataSource = _sec.Result.ToArray();

                this.comboBoxSector.ResumeLayout();
                this.comboBoxSector.SelectedIndex = 0;



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
                BLL.Procedures.TRAESUBRUBROSEMPRESA _rubroItem = new BLL.Procedures.TRAESUBRUBROSEMPRESA();
                Entities.Procedures.TRAESUBRUBROSEMPRESA _itemSeleccion = new Entities.Procedures.TRAESUBRUBROSEMPRESA();
                _rubroItem.Items(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
                //Limpia el combo
                this.comboBoxSubRubro.SuspendLayout();
                this.comboBoxSubRubro.DataSource = null;
                this.comboBoxSubRubro.Items.Clear();


                // Carga el item de Seleccion
                _itemSeleccion.da2_desc = "<Seleccione un Sub Rubro>";
                _itemSeleccion.da2_cod = "0";
                _rubroItem.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxSubRubro.DisplayMember = BLL.Procedures.TRAESUBRUBROSEMPRESA.ColumnNames.DA2_DESC;
                this.comboBoxSubRubro.ValueMember = BLL.Procedures.TRAESUBRUBROSEMPRESA.ColumnNames.DA2_COD;
                this.comboBoxSubRubro.DataSource = _rubroItem.Result.ToArray();
                this.comboBoxSubRubro.SelectedIndex = 0;

                this.comboBoxSubRubro.ResumeLayout();



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
                BLL.Procedures.H_ARTICULOSDEPOSITO _art = new BLL.Procedures.H_ARTICULOSDEPOSITO();
                _articulosItem = _art.Items();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void EnviarMail(string SPath)
        {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress("florencia.lingua@csantacatalina.com.ar"));
            //email.CC.Add(new MailAddress("comprasnilda@csantacatalina.com.ar", "comprasnoelia@csantacatalina.com.ar"));
            email.From = new MailAddress("sistemas@csantacatalina.com.ar");
            email.Subject = "Nuevo Reclamo de Mercaderia";
            email.Body = "Se genero un nuevo reclamo de mercaderia por sistema";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            email.Attachments.Add(new Attachment(SPath));

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;          
            smtp.Credentials = new NetworkCredential("sistemas@csantacatalina.com.ar", "Omg.2018");

            string output = null;
            this.progressBar1.Value = 80;
            try
            {
                smtp.Send(email);
                this.progressBar1.Value = 90;
                email.Dispose();
                output = "Corre electrónico fue enviado satisfactoriamente.";
            }
            catch (Exception ex)
            {
                output = "Error enviando correo electrónico: " + ex.Message;
            }

            Console.WriteLine(output);
        }

       


        #endregion

        #region Eventos
        private void Frm_ReclamoMercaderia_Load(object sender, EventArgs e)
        {
            int _Max;
            _Max = 0;
            CargarDepositos();
            CargarSectoresDeposito(Clases.Usuario.EmpresaLogeada.EmpresaIngresada,Convert.ToInt32(this.comboBoxDeposito.SelectedValue));
            CargarSubRubros();
            CargarArticulos();
           
            Entities.Procedures.STKMAXIMOIDPLANTILLA _MAXS = new Entities.Procedures.STKMAXIMOIDPLANTILLA();
            BLL.Procedures.STKMAXIMOIDPLANTILLA _MAXIMOS = new BLL.Procedures.STKMAXIMOIDPLANTILLA();

            foreach (Entities.Procedures.STKMAXIMOIDPLANTILLA item in _MAXIMOS.ItemList())
            {
                _Max = item.max + 1 ;
            }

            this.NumPlantilla.Text = _Max.ToString();

            
            
            
             
        }

        private void comboBoxDeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSectoresDeposito(Clases.Usuario.EmpresaLogeada.EmpresaIngresada, Convert.ToInt32(this.comboBoxDeposito.SelectedValue));
        }

        private void comboBoxSubRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxSubRubro.SelectedIndex > 0)
            {
                var q = (dynamic)null;

                q = (from item in _articulosItem
                     where item.subrubro.Contains(this.comboBoxSubRubro.SelectedValue.ToString())
                     select item).ToList<Entities.Procedures.H_ARTICULOSDEPOSITO>();

                //Limpia el combo
                this.comboBoxArticulo.SuspendLayout();
                this.comboBoxArticulo.DataSource = null;
                this.comboBoxArticulo.Items.Clear();

                //Carga el combo
                this.comboBoxArticulo.DisplayMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_DESCGEN;
                this.comboBoxArticulo.ValueMember = BLL.Procedures.H_ARTICULOSDEPOSITO.ColumnNames.ART_CODGEN;
                this.comboBoxArticulo.DataSource = q;
                this.comboBoxArticulo.ResumeLayout();
            }

        }


        private void comboBoxArticulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBoxArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            int rowEscribir = dataGridViewArticulos.Rows.Count;
            this.dataGridViewArticulos.Rows.Add(1);
            this.dataGridViewArticulos.Rows[rowEscribir].Cells[0].Value = this.comboBoxArticulo.SelectedValue;
            this.dataGridViewArticulos.Rows[rowEscribir].Cells[1].Value = this.comboBoxArticulo.Text.ToString();

        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
        
            int _NumPlantilla = Convert.ToInt32(this.NumPlantilla.Text);

            try
            {
                if (this.textBoxFactura.Text != string.Empty)
                {
                    Entities.Tables.STK_RECLAMODEMERCADERIA _Art = new Entities.Tables.STK_RECLAMODEMERCADERIA();
                    BLL.Tables.STK_RECLAMODEMERCADERIA _Articulos = new BLL.Tables.STK_RECLAMODEMERCADERIA();

                    this.progressBar1.Step = 5;

                    if (this.dataGridViewArticulos.Rows.Count > 0)
                    {
                        for (int i = 0; i < this.dataGridViewArticulos.Rows.Count; i++)
                        {
                            _Art = new Entities.Tables.STK_RECLAMODEMERCADERIA();


                            _Art.ARTICULO_ID = dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.ARTICULOID].Value.ToString();
                            _Art.DEPOSITO_ID = Convert.ToInt32(this.comboBoxDeposito.SelectedValue);
                            _Art.SECTOR_ID = Convert.ToInt32(this.comboBoxSector.SelectedValue);
                            _Art.NUMFACTURA = Convert.ToInt32(this.textBoxFactura.Text);
                            _Art.NUMREMITO = (this.textBoxRemito.Text == string.Empty) ? 0 : Convert.ToInt32(this.textBoxRemito.Text);
                            _Art.ANOTACION = (dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.ANOTACION].Value == null) ? "" : dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.ANOTACION].Value.ToString();
                            _Art.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                            _Art.CANTIDADFALTANTE = (dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.CANTIDADFALTANTE].Value == null) ? 0 : Convert.ToInt32(dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.CANTIDADFALTANTE].Value);
                            _Art.CANTIDADRECIBIDADEMAS = (dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.CANTIDADDEMAS].Value == null) ? 0 : Convert.ToInt32(dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.CANTIDADDEMAS].Value);
                            _Art.CANTIDADRECIBIDAPORERROR = (dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.RECIBIDOPORERROR].Value == null) ? 0 : Convert.ToInt32(dataGridViewArticulos.Rows[i].Cells[(int)Col_Articulos.RECIBIDOPORERROR].Value);
                            _Art.FECHA = DateTime.Now;
                            _Art.PLANTILLAID = Convert.ToInt32(this.NumPlantilla.Text);
                            _Articulos.Add(_Art);
                        }
                    
                   

                        this.progressBar1.Step = 20;

                        GenerarPDF(_NumPlantilla);

                        this.comboBoxSector.SelectedIndex = 0;
                        this.comboBoxDeposito.SelectedIndex = 0;
                        this.comboBoxSubRubro.SelectedIndex = 0;
                        this.comboBoxArticulo.SelectedIndex = 0;
                        this.dataGridViewArticulos.Rows.Clear();
                        this.NumPlantilla.Text = Convert.ToString(_NumPlantilla + 1);
                        this.progressBar1.Value = 100;
                        MessageBox.Show("Se Envio Correctamente el Correo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.progressBar1.Value = 0;
                    }

                    else
                    {
                        MessageBox.Show("Debe ingresar al menos un articulo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                else
                {
                    MessageBox.Show("Debe ingresar una Factura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
