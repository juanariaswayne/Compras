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
    public partial class Frm_CotizacionesPedidas : Form
    {
        public Frm_CotizacionesPedidas()
        {
            InitializeComponent();
        }

        private string _articulo_cotizado;
        private string _descripArt_cotizado;
        private string _codEmp;
        public string Articulo_cotizado
        {
            get {return _articulo_cotizado; }

            set{_articulo_cotizado = value; }
        }

        public string DescripArt_cotizado
        {
            get{return _descripArt_cotizado;}

            set{ _descripArt_cotizado = value;}
        }

        public string CodEmp
        {
            get
            {
                return _codEmp;
            }

            set
            {
                _codEmp = value;
            }
        }

        private void Frm_CotizacionesPedidas_Load(object sender, EventArgs e)
        {
            try
            {
                this.Top = 50;
                BLL.Procedures.REQUERIMIENTOS_COTIZADOS_PROVEEDOR _reqCotizados = new BLL.Procedures.REQUERIMIENTOS_COTIZADOS_PROVEEDOR();
                this.dataGridViewArticulosCotizadosProveed.DataSource = _reqCotizados.ItemList(_articulo_cotizado, _codEmp).ToArray();
                this.labelArticulo.Text = _articulo_cotizado.ToString();
                this.labelDescripArticulo.Text = _descripArt_cotizado.ToString();
            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
