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
    public partial class Frm_Art_ModificarCuentas : Plantilla
    {
        #region Variables
        List<Entities.Procedures.TRAECUENTASPORARTICULO> _ListaArticulos = new List<Entities.Procedures.TRAECUENTASPORARTICULO>();
        Entities.Procedures.TRAECUENTASPORARTICULO E = new Entities.Procedures.TRAECUENTASPORARTICULO();
        BLL.Procedures.TRAECUENTASPORARTICULO art = new BLL.Procedures.TRAECUENTASPORARTICULO();
        #endregion

        #region Funciones
        public Frm_Art_ModificarCuentas()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void Art_ModificarCuentas_Load(object sender, EventArgs e)
        {
            try
            {                               
                _ListaArticulos = art.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void txtArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    
                    var item = _ListaArticulos.Where(a => a.art_codgen.ToString().Contains(txtArticulo.Text)).SingleOrDefault();
                    if (item != null)
                    { 
                    txtCosto.Text = item.aappla_cuentacostos;
                    txtCompras.Text = item.aappla_cuentacpra;
                    txtVentas.Text = item.aappla_cuentavta;
                    txtInventario.Text = item.aappla_cuentainv;
                    lblDescArticulo.Text = item.art_descgen;
                     }
                    else
                    {
                        MessageBox.Show("No se encontro el articulo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtArticulo.Text != String.Empty && lblDescArticulo.Text != String.Empty)
                {


                    BLL.Procedures.UPDATECUENTASPORARTICULO _update = new BLL.Procedures.UPDATECUENTASPORARTICULO();

                    _update.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada, txtArticulo.Text, txtCosto.Text, txtCompras.Text, txtVentas.Text, txtInventario.Text);

                    MessageBox.Show("Se actualizo correctamente el articulo");
                    lblDescArticulo.Text = "";
                    txtArticulo.Text = "";
                    txtCompras.Text = "";
                    txtCosto.Text = "";
                    txtInventario.Text = "";
                    txtVentas.Text = "";

                    List<Entities.Procedures.TRAECUENTASPORARTICULO> _ListaArticulos = new List<Entities.Procedures.TRAECUENTASPORARTICULO>();
                    Entities.Procedures.TRAECUENTASPORARTICULO E = new Entities.Procedures.TRAECUENTASPORARTICULO();
                    _ListaArticulos = art.ItemList(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);
                }
                else
                {
                    MessageBox.Show("Debe ingresar un articulo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {
                      
        }
    }
}
