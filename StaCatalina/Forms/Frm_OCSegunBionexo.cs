using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace StaCatalina.Forms
{
    public partial class Frm_OCSegunBionexo : StaCatalina.Plantilla
    {
        #region Variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;
            // ******* FORMATO ARCHIVO TXT BIONEXO ********
            //1 - Nº de PDC: NUMERICO(18)
            //2 - FECHA DE CONFIRMACION: FECHA(DD/MM/YYYY)
            //3 - COD. PROVEEDOR (TABLA DE EQUIVALENCIAS):ALFANUMERICO(10)
            //4 - RAZÓN SOCIAL DE PROVEEDOR: ALFANUMERICO(20)
            //5 - CODIGO DE PRODUCTO: ALFANUMERICO(20)
            //6 - DESCRIPCION PRODUCTO: VARCHAR(40)
            //7 - ID_CATEGORIA1:NUMBER(3)
            //8 - CANTIDAD TOTAL: NUMBER(10)
            //9 - PRECIO UNITARIO SIN IVA: NUMBER(12,4)
            //10 - PRECIO TOTAL SIN IVA: NUMBER(12,4)
            //11 - DESCRIPCION FORMA DE PAGO: VARCHAR(30)
            //12 - MARCA: VARCHAR2(20)
            //13 - EMBALAJE: VARCHAR(20)
            //14 - Nº DE NECESIDAD: ALFANUMERICO(20)
            //15 - PROGRAMACIÓN DE ENTREGA FECHA_1: DATE(DD/MM/YYYY)
            //16 - CANTIDAD_1: NUMBER(10)
            //17 - PROGRAMACIÓN DE ENTREGA FECHA_2: DATE(DD/MM/YYYY)
            //18 - CANTIDAD_2: NUMBER(10)
            //19 - PROGRAMACIÓN DE ENTREGA FECHA_3: DATE(DD/MM/YYYY)
            //20 - CANTIDAD_3: NUMBER(10)
            //21 - PROGRAMACIÓN DE ENTREGA FECHA_4: DATE(DD/MM/YYYY)
            //22 - CANTIDAD_4: NUMBER(10)
            //23 - PROGRAMACIÓN DE ENTREGA FECHA_5:DATE(DD/MM/YYYY)
            //24 - CANTIDAD_5: NUMBER(10)
            //25 - PROGRAMACIÓN DE ENTREGA FECHA_6: DATE(DD/MM/YYYY)
            //26 - CANTIDAD_6 NUMBER(10)
            //HASTA 24 FECHAS DE ENTREGA

            //*********************************************
        #endregion

        #region Funciones
            public Frm_OCSegunBionexo()
            {
                InitializeComponent();
            }

         
            private void OperacionesDelUsuario()
            {
                try
                {
                    if (!escritura) { this.buttonImporta.Enabled = false; }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        #endregion

        #region Eventos
            private void Frm_OCSegunBionexo_Load(object sender, EventArgs e)
            {
                //PERMISOS
                MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
                menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
                this.OperacionesDelUsuario();
                Clases.Empresa.CargarEmpresas(comboBoxEmpresa);
                this.comboBoxEmpresa.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim();


            }

            private void buttonImporta_Click(object sender, EventArgs e)
            {
                try
                {
                    
                    openFileDialog1.FileName = String.Empty;
                    openFileDialog1.Filter = "archivos TXT Bionexo|*.txt";
                    //openFileDialog1.ShowDialog();
                    String sContent = string.Empty;
                    BLL.Procedures.IMPORTA_TXT_BIONEXO _importa = new BLL.Procedures.IMPORTA_TXT_BIONEXO();
                     
                   
                    if (this.openFileDialog1.ShowDialog() != DialogResult.Cancel)
                    {
                        string SPath = this.openFileDialog1.FileName;
                        if (File.Exists(SPath))
                        {
                            sContent = File.ReadAllText(SPath);
                            string _empresa;
                            string _ocDesde;
                            string _ocHasta;
                            _empresa = this.comboBoxEmpresa.SelectedValue.ToString();
                            //LLAMO AL STORED QUE IMPORTA EL TXT
                            _importa.Items(sContent, "", -1, -1, _empresa, Clases.Usuario.UsuarioLogeado.usuario_Logeado.Trim());

                            _ocDesde = _importa.Resultset[0].oc_desde.ToString();
                            _ocHasta = _importa.Resultset[0].oc_hasta.ToString();
                            if (_ocDesde != "0")
                            {
                                MessageBox.Show("Se generaron las Ordenes de Compra desde la: " + _ocDesde + " hasta la: " + _ocHasta, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error al generar las ordenes de compra, comuníquese con Sistemas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("No se encuentra el archivo de Bionexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            Close();
        }
    }
}
