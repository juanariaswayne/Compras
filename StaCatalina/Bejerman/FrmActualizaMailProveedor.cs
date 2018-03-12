using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;
namespace StaCatalina.Bejerman
{
    public partial class FrmActualizaMailProveedor : StaCatalina.Plantilla
    {
        #region Variables
            private bool lectura;
            private bool escritura;
            private bool elimina;
            private int id_usuario;

        private enum Col_Mail
        {
            INACTIVO = 0,
            MAIL
           
        }

        #endregion

        #region Funciones

        public FrmActualizaMailProveedor()
        {
            InitializeComponent();
        }
        
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
        
        private void CargarProveedor(string _codEmp)
        {
            try
            {
                BLL.Procedures._H_PROVEEDORES _prov = new BLL.Procedures._H_PROVEEDORES();
                _prov.ItemList(_codEmp);
                Entities.Procedures._H_PROVEEDORES _itemSeleccion = new Entities.Procedures._H_PROVEEDORES();

                //Limpia el combo
                this.comboBoxProveed.SuspendLayout();
                this.comboBoxProveed.DataSource = null;
                this.comboBoxProveed.Items.Clear();


                //Carga el item de Seleccion
                _itemSeleccion.pro_razsoc = "<Seleccione un Proveedor>";
                _itemSeleccion.pro_cod = "0";
                _prov.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.comboBoxProveed.DisplayMember = BLL.Procedures._H_PROVEEDORES.ColumnNames.PRO_RAZSOC;
                this.comboBoxProveed.ValueMember = BLL.Procedures._H_PROVEEDORES.ColumnNames.PRO_COD;
                this.comboBoxProveed.DataSource = _prov.Result.ToArray();

                this.comboBoxProveed.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private static bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sEmailAComprobar, sFormato))
            {
                if (Regex.Replace(sEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        private void FrmActualizaMailProveedor_Load(object sender, EventArgs e)
        {

            MenuSistema.Cls_Menus menu = new MenuSistema.Cls_Menus();
            menu.ObtenerPermisos(Id_Perfil, Convert.ToInt32(Tag.ToString()), ref lectura, ref escritura, ref elimina);
            this.OperacionesDelUsuario();
            Clases.Empresa.CargarEmpresas(comboBoxcodEmp);

            comboBoxcodEmp.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();

            CargarProveedor(Clases.Usuario.EmpresaLogeada.EmpresaIngresada);
        }

        private void comboBoxcodEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxcodEmp.SelectedIndex > 0)
            {
                //SOLO CAMBIO DE EMPRESA SI ESTA AUTORIZADA
                string _emp = this.comboBoxcodEmp.SelectedValue.ToString();
                int _index = this.comboBoxcodEmp.SelectedIndex;
                if (Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != _emp.Trim() && Clases.Usuario.UsuarioLogeado.EmpresaAutorizada.ToString().Trim() != "AMBA")
                {
                    MessageBox.Show("Ud. no está autorizado a operar con esta empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.comboBoxcodEmp.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                    return;
                }
                else
                {
                    CargarProveedor(comboBoxcodEmp.SelectedValue.ToString());
                   

                }
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewMails_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewMails.IsCurrentCellDirty)
                dataGridViewMails.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void comboBoxProveed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProveed.SelectedIndex > 0 )
                {
                    StaCatalinaEntities _Mod = new StaCatalinaEntities();
                    var _list = (from M in _Mod.TraeProveedorEmpresa(comboBoxcodEmp.SelectedValue.ToString(), comboBoxProveed.SelectedValue.ToString())

                                 select new
                                 {
                                     M.Email,

                                 }).SingleOrDefault();
                    dataGridViewMails.Rows.Clear();
                    int indice = 0;

                 
                    if (_list.Email != string.Empty && _list.Email != null)
                    {
                        // UN PROVEEDOR PUEDE TENER MAS DE UNA DIRECCION DE MAIL SEPARADO POR ; (punto y coma), APLICO SPLIT
                        Char _delimiter= ';';
                        String[] substrings = _list.Email.Split(_delimiter);
                        for (int i = 0; i < substrings.Length; i++)
                        {
                            indice = dataGridViewMails.Rows.Add();
                            dataGridViewMails.Rows[indice].Cells[(int)Col_Mail.MAIL].Value = substrings[i].ToString(); // MAIL

                            indice++;
                        }
                    }
                   
                }

            

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                StaCatalinaEntities _Mod = new StaCatalinaEntities();
               
                if (comboBoxcodEmp.SelectedIndex > 0 && comboBoxProveed.SelectedIndex > 0)
                {

                    if (dataGridViewMails.Rows.Count > 0)
                    {
                        string _email = string.Empty;
                        Boolean _existe = false;
                        for (int i = 0; i < dataGridViewMails.Rows.Count - 1; i++)
                        {
                            //CONCATENO TODOS LOS MAILS CON ;
                            DataGridViewCheckBoxCell cellSelecion = dataGridViewMails.Rows[i].Cells[(int)Col_Mail.INACTIVO] as DataGridViewCheckBoxCell;
                            if (!Convert.ToBoolean(cellSelecion.Value))
                            {
                                if (dataGridViewMails.Rows[i].Cells[(int)Col_Mail.MAIL].Value != string.Empty && dataGridViewMails.Rows[i].Cells[(int)Col_Mail.MAIL].Value != null)
                                {
                                    //ANTES VALIDO EL FORMATO DE MAIL
                                    if (ComprobarFormatoEmail(dataGridViewMails.Rows[i].Cells[(int)Col_Mail.MAIL].Value.ToString()))
                                    {

                                        if (i == 0)
                                        {
                                            _email = dataGridViewMails.Rows[i].Cells[(int)Col_Mail.MAIL].Value.ToString();
                                            _existe = true;
                                        }
                                        else
                                        {
                                            _email = _email + ";" + dataGridViewMails.Rows[i].Cells[(int)Col_Mail.MAIL].Value.ToString();
                                            _existe = true;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El Formato de mail no es válido, verifique la dirección ingresada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                    }
                                }

                            }
                        }

                        if (!_existe)
                        {
                            _email = string.Empty; // ES PORQUE ESTA ELIMINANDO TODOS LOS MAIL DE ESTE PROVEEDOR


                        }
                                            
                        _Mod.ActualizaMailProveedor(comboBoxcodEmp.SelectedValue.ToString(), comboBoxProveed.SelectedValue.ToString(), _email);
                        MessageBox.Show("Emails actualizados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        comboBoxcodEmp.SelectedValue = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                        comboBoxProveed.SelectedIndex = 0;
                        dataGridViewMails.Rows.Clear();
                    }

                    else
                    {
                        MessageBox.Show("No existen mails para grabar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }

                else
                {
                    MessageBox.Show("Debe seleccionar una Sede y un Sector", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            comboBoxcodEmp.SelectedValue  = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
            comboBoxProveed.SelectedIndex = 0;
            dataGridViewMails.Rows.Clear();
        }
    }
}
