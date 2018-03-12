using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace StaCatalina.Bejerman
{
    public partial class Frm_CreaSubCuenta_Concepto : StaCatalina.Plantilla
    {
        #region Variables
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;
        int _idSubCuenta = 0;
        string _codigoConc = string.Empty;

        List<Entities.Procedures.TRAECONCEPTOCTACONTABLE> _conceptos = new List<Entities.Procedures.TRAECONCEPTOCTACONTABLE>();

        List<TraeConceptoCtaContable_Result> _conceptosR = new List<TraeConceptoCtaContable_Result>();
        #endregion
        public Frm_CreaSubCuenta_Concepto()
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

        private void Nuevo()
        {
            comboBoxSubCuenta.SelectedIndex = 0;
            labelCuentaContable.Text = "";
            labelDescripCtaContable.Text = "";
            //comboBoxCodigoConc.SelectedIndex = 0;
            //comboBoxConcepto.SelectedIndex = 0;


        }
        //FIN PERMISOS

        private void CargarConceptos()
        {
            try
            {
                if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                {
                    BLL.Procedures.TRAECONCEPTOCTACONTABLE _conc = new BLL.Procedures.TRAECONCEPTOCTACONTABLE();

                    Entities.Procedures.TRAECONCEPTOCTACONTABLE _itemSeleccion = new Entities.Procedures.TRAECONCEPTOCTACONTABLE();

                    _conceptos = _conc.ItemList(); //GUARDO EN ESTA LISTA

                    var q = (dynamic)null;

                    q = (from item in _conceptos
                         select item).ToList<Entities.Procedures.TRAECONCEPTOCTACONTABLE>();


                    //Limpia el combo
                    this.comboBoxConcepto.SuspendLayout();
                    this.comboBoxConcepto.DataSource = null;
                    this.comboBoxConcepto.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.con_desc = "<Seleccione un Concepto>";
                    _itemSeleccion.con_cod = "0";

                    //_ItemsArtDep = _prod.ItemList();
                    q.Insert(0, _itemSeleccion);
                    //Carga el combo
                    this.comboBoxConcepto.DisplayMember = BLL.Procedures.TRAECONCEPTOCTACONTABLE.ColumnNames.CON_DESC;
                    this.comboBoxConcepto.ValueMember = BLL.Procedures.TRAECONCEPTOCTACONTABLE.ColumnNames.CON_COD;
                    this.comboBoxConcepto.DataSource = q;

                    this.comboBoxConcepto.ResumeLayout();
                }
                else
                {
                    SBDARSCEntities _Mod = new SBDARSCEntities();


                    var _listObj = (from T in _Mod.TraeConceptoCtaContable()
                                    orderby T.con_Cod
                                    select T).ToList();
                    TraeConceptoCtaContable_Result _itemSeleccion = new TraeConceptoCtaContable_Result();

                  
                    _conceptosR = _listObj; //GUARDO EN ESTA LISTA

                    var q = (dynamic)null;

                    q = (from item in _conceptosR
                         select item).ToList<TraeConceptoCtaContable_Result>();


                    //Limpia el combo
                    this.comboBoxConcepto.SuspendLayout();
                    this.comboBoxConcepto.DataSource = null;
                    this.comboBoxConcepto.Items.Clear();


                    //Carga el item de Seleccion
                    _itemSeleccion.con_Desc = "<Seleccione un Concepto>";
                    _itemSeleccion.con_Cod = "0";

                    //_ItemsArtDep = _prod.ItemList();
                    q.Insert(0, _itemSeleccion);
                    //Carga el combo
                    this.comboBoxConcepto.DisplayMember = "con_Desc";
                    this.comboBoxConcepto.ValueMember = "con_Cod";
                    this.comboBoxConcepto.DataSource = q;

                    this.comboBoxConcepto.ResumeLayout();

                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private Boolean VerificarDatos()
        {
            try
            {
                if (this.comboBoxConcepto.SelectedIndex == 0)
                {
                    this.errorProvider1.SetError(this.comboBoxConcepto, "Debe Seleccionar un Concepto");
                    this.comboBoxConcepto.Focus();
                    return false;
                }
                else
                {
                    this.errorProvider1.Clear();
                }

                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void CargarSubCuentas()
        {
            try
            {
                SBDAEGESEntities _Mod = new SBDAEGESEntities();
                               
           
                    var _listObj = (from T in _Mod.USR_ArticuloSubCuenta
                                    orderby T.Descripcion
                                    select T).ToList();
                    USR_ArticuloSubCuenta _itemSeleccion = new USR_ArticuloSubCuenta();

                    //Limpia el combo
                    comboBoxSubCuenta.SuspendLayout();
                    comboBoxSubCuenta.DataSource = null;
                    comboBoxSubCuenta.Items.Clear();

                    // Carga el item de Seleccion
                    _itemSeleccion.Descripcion = "<Seleccione una Sub Cuenta>";
                    _itemSeleccion.subCuenta = 0;
                    _listObj.Insert(0, _itemSeleccion);

                    //Carga el combo
                    comboBoxSubCuenta.DisplayMember = "Descripcion";
                    comboBoxSubCuenta.ValueMember = "subCuenta";
                    comboBoxSubCuenta.DataSource = _listObj.ToArray();
                    comboBoxSubCuenta.SelectedIndex = 0;

                    comboBoxSubCuenta.ResumeLayout();
              
               

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Frm_CreaSubCuenta_Concepto_Load(object sender, EventArgs e)
        {
            //PERMISOS
            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            this.Text = "Asociar Sub Cuenta x Concepto Empresa: " + Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
            //FIN PERMISOS

            CargarConceptos();
            CargarSubCuentas();
        }

        private void comboBoxConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxConcepto.SelectedIndex > 0)
                {
                    Nuevo();
                    _codigoConc = comboBoxConcepto.SelectedValue.ToString();

                    //textBoxSubCuenta.Text = _conceptos.Find(x => x.con_cod.Contains(_codigoConc)).descripsubcuenta; // DESCRIPCION SUB CUENTA
                    //comboBoxSubCuenta.SelectedValue  = _conceptos.Find(x => x.con_cod.Contains(_codigoConc)).subcuenta.ToString(); // NRO. SUB CUENTA

                    if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                    {
                        labelCuentaContable.Text = _conceptos.Find(x => x.con_cod.Contains(_codigoConc)).cappla_cuentacpra.ToString(); // CUENTA CONTABLE
                        labelDescripCtaContable.Text = _conceptos.Find(x => x.con_cod.Contains(_codigoConc)).cta_descrip.ToString(); // DESCRIPCION CUENTA CONTABLE
                        labelCodigoConcepto.Text = _codigoConc;

                        //RECUPERO SI ESTE CONCEPTO TIENE UNA SUB CUENTA ASOCIADA
                        SBDAEGESEntities _Mod = new SBDAEGESEntities();
                        var _listObj = (from T in _Mod.USR_ConceptoSubCuenta
                                        where T.concepto == _codigoConc
                                        select T).SingleOrDefault();

                        if (_listObj == null)
                        {
                            comboBoxSubCuenta.SelectedIndex = 0;
                            _idSubCuenta = 0;
                        }
                        else
                        {
                            comboBoxSubCuenta.SelectedValue = _listObj.subCuenta;
                            _idSubCuenta = _listObj.Id;
                        }
                    }
                    else
                    {
                        labelCuentaContable.Text = _conceptosR.Find(x => x.con_Cod.Contains(_codigoConc)).cappla_CuentaCpra.ToString(); // CUENTA CONTABLE
                        labelDescripCtaContable.Text = _conceptosR.Find(x => x.con_Cod.Contains(_codigoConc)).cta_descrip.ToString(); // DESCRIPCION CUENTA CONTABLE
                        labelCodigoConcepto.Text = _codigoConc;

                        //RECUPERO SI ESTE CONCEPTO TIENE UNA SUB CUENTA ASOCIADA
                        SBDARSCEntities _Mod = new SBDARSCEntities();
                        var _listObj = (from T in _Mod.USR_ConceptoSubCuenta
                                        where T.concepto == _codigoConc
                                        select T).SingleOrDefault();

                        if (_listObj == null)
                        {
                            comboBoxSubCuenta.SelectedIndex = 0;
                            _idSubCuenta = 0;
                        }
                        else
                        {
                            comboBoxSubCuenta.SelectedValue = _listObj.subCuenta;
                            _idSubCuenta = _listObj.Id;
                        }
                    }
                  
                }
               

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
           
          
            labelCuentaContable.Text = "";
            labelDescripCtaContable.Text = "";
            //comboBoxCodigoConc.SelectedIndex = 0;
            comboBoxConcepto.SelectedIndex = 0;
            labelCodigoConcepto.Text = "";
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(VerificarDatos())
                {
                    SBDAEGESEntities _Mod = new SBDAEGESEntities();//eges
                    SBDARSCEntities _ModR = new SBDARSCEntities(); //rsc

                    USR_ConceptoSubCuenta _con = new USR_ConceptoSubCuenta();

                    _con.concepto = _codigoConc;
                    _con.subCuenta = Convert.ToInt32(comboBoxSubCuenta.SelectedValue);
        
                    if (comboBoxSubCuenta.SelectedIndex == 0)
                    {
                        DialogResult _result = MessageBox.Show("No seleccionó ninguna sub cuenta a este concepto, desea continuar de todos modos ?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (_result == System.Windows.Forms.DialogResult.OK)
                        {
                           
                            _con.subCuenta = 0;
                            
                        }
                        else
                        {
                            return;
                        }
                    }

                    if(_idSubCuenta == 0) //ESTOY ASOCIANDO UN NUEVO CONCEPTO A UNA SUBCUENTA
                    {
                        if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                        {
                            _Mod.USR_ConceptoSubCuenta.Add(_con);

                            _Mod.SaveChanges();
                        }
                        else
                        {
                            _ModR.USR_ConceptoSubCuenta.Add(_con);

                            _ModR.SaveChanges();
                        }
                          


                    }
                    else //ESTOY ACTUALIZANBDO UN CONCEPTO CON UNA NUEVA CUENTA.. 
                    {
                        _con.Id = _idSubCuenta;

                        if (Clases.Usuario.EmpresaLogeada.EmpresaIngresada.Trim() == "EGES")
                        {
                            _Mod.Entry(_con).State = System.Data.Entity.EntityState.Modified;

                            _Mod.SaveChanges();
                        }
                        else
                        {
                            _ModR.Entry(_con).State = System.Data.Entity.EntityState.Modified;

                            _ModR.SaveChanges();
                        }
                    }
                                        
                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarConceptos();
                    _idSubCuenta = 0;
                    _codigoConc = string.Empty;
                }


            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
