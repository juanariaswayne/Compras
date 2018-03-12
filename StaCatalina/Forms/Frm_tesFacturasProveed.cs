using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Forms
{
    public partial class Frm_tesFacturasProveed : Plantilla
    {
        #region Variables

        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        private string _codProveed;

        #endregion

        #region Funciones

        public Frm_tesFacturasProveed()
        {
            InitializeComponent();
        }
        //PERMISOS
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
        //FIN PERMISOS

        #endregion

        #region Eventos
        private void Frm_tesFacturasProveed_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();

            this.labelRsocProveed.Visible = false;
        }

        private void textBoxCUIT_Proveed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string _codEmp;
                BLL.Procedures.RECUPERAPROVEEDOREMPRESA _Proveds = new BLL.Procedures.RECUPERAPROVEEDOREMPRESA();

                string _cuit;
                _cuit = this.textBoxCUIT_Proveed.Text.ToString().Trim().Substring(1, 11);


                _codEmp = (comboBoxEmpresa.SelectedIndex == 0)? "EGES":"RSC";
                _Proveds.Items(_codEmp, _cuit);

                if (_Proveds.Resultset.Count > 0)
                {
                    this.labelRsocProveed.Visible = true;
                    this.labelRsocProveed.Text = _Proveds.Resultset[0].pro_razsoc;
                    this._codProveed = _Proveds.Resultset[0].pro_cod;
                }

                else
                {
                    MessageBox.Show( "No se encontro ningun proveedor con este CUIT","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void toolStripButtonSave_Click(object sender, EventArgs e)
                {
                    Entities.Tables.TESFACTURAPROVEED _Fact = new Entities.Tables.TESFACTURAPROVEED();
                    BLL.Tables.TESFACTURAPROVEED _Facts = new BLL.Tables.TESFACTURAPROVEED();

                    if (comboBoxEmpresa.SelectedIndex == 0)
                    {
                        _Fact.CODEMP = "EGES";
                    }
                    else
                    {
                        _Fact.CODEMP = "RSC";
                    }

                    _Fact.PRO_COD = _codProveed;
                    _Fact.SUCFACTURA = this.textBoxSucursal.Text;
                    _Fact.COMPROBANTE = Convert.ToInt32(this.textBoxNComprobante.Text);
                    _Fact.IMPORTE = Convert.ToInt32(this.textBoxImporte.Text);
                    _Fact.FECHAFACT = dateTimePickerFechaComp.Value;
                    _Fact.FECHALECTURA = DateTime.Today;            
                    _Fact.CODIGOBARRA = "0000000000000000000000000000"; //Codigo Temporal
                    _Fact.TIPO = 000;
                    _Fact.USUARIO = Clases.Usuario.UsuarioLogeado.usuario_Logeado;

                    _Facts.Add(_Fact);

                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                   


                }
        #endregion

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
