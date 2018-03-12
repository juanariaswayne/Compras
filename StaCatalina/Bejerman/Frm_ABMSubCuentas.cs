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
    public partial class Frm_ABMSubCuentas : StaCatalina.Plantilla
    {
        private bool lectura;
        private bool escritura;
        private bool elimina;
        private int id_usuario;

        enum Col_Costo
        {
            COL_CODIGO = 0,
            COL_DESCRIPCION

        }
        int _cuentaId =0;

        public Frm_ABMSubCuentas()
        {
            InitializeComponent();
        }

        private void TraeSubCuentas()
        {
            try
            {
                SBDAEGESEntities _Mod = new SBDAEGESEntities();
                var _list = (from M in _Mod.USR_ArticuloSubCuenta

                             select new
                             {
                                 M.subCuenta,
                                 M.Descripcion
                                
                             });
                dataGridViewSubCuentas.Rows.Clear();
                int indice = 0;
                foreach (var item in _list)
                {
                    indice = dataGridViewSubCuentas.Rows.Add();
                    dataGridViewSubCuentas.Rows[indice].Cells[(int)Col_Costo.COL_CODIGO].Value = item.subCuenta; //CODIGO
                    dataGridViewSubCuentas.Rows[indice].Cells[(int)Col_Costo.COL_DESCRIPCION].Value = item.Descripcion; //DESCRIPCION

                    indice++;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_ABMSubCuentas_Load(object sender, EventArgs e)
        {
            TraeSubCuentas();
        }

        private void dataGridViewSubCuentas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewSubCuentas.IsCurrentCellDirty)
                dataGridViewSubCuentas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewSubCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try

            //{
            //    if (e.RowIndex >= 0)
            //    {
            //        _cuentaId = Convert.ToInt32(dataGridViewSubCuentas.Rows[e.RowIndex].Cells[(int)Col_Costo.COL_CODIGO].Value);
            //        //TextBoxCodigo.Text = dataGridViewCentros.Rows[e.RowIndex].Cells[(int)Col_Costo.COL_CODIGO].Value.ToString();
            //        textBoxDescripSub.Text = dataGridViewSubCuentas.Rows[e.RowIndex].Cells[(int)Col_Costo.COL_DESCRIPCION].Value.ToString();
                   
            //    }

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDescripSub.Text != string.Empty)
                {

                    SBDAEGESEntities _Mod = new SBDAEGESEntities();

                    SBDARSCEntities _ModRsc = new SBDARSCEntities();



                    USR_ArticuloSubCuenta _sub = new USR_ArticuloSubCuenta
                    {
                        Descripcion = textBoxDescripSub.Text,
                        //esDeProducto = true
                        
                    }; //TABLA EGES

                   
                    if (_cuentaId == 0)
                    {
                        _Mod.USR_ArticuloSubCuenta.Add(_sub);

                        _Mod.SaveChanges();

                        //ahora grabo en tabla de RSCÇ
                        _ModRsc.USR_ArticuloSubCuenta.Add(_sub);

                        _ModRsc.SaveChanges();


                        textBoxDescripSub.Text = string.Empty;
                        _cuentaId = 0;
                        TraeSubCuentas();
                        MessageBox.Show("Sub Cuenta creada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       

                    }

                    else
                    {
                        _sub.subCuenta = _cuentaId;
                        _Mod.Entry(_sub).State = System.Data.Entity.EntityState.Modified;

                        _Mod.SaveChanges();

                        //ACTUALIZO EN TABLA RSCÇ
                        _sub.subCuenta = _cuentaId;
                        _ModRsc.Entry(_sub).State = System.Data.Entity.EntityState.Modified;

                        _ModRsc.SaveChanges();

                        textBoxDescripSub.Text = string.Empty;
                        _cuentaId = 0;
                        TraeSubCuentas();
                        MessageBox.Show("Sub Cuenta actualizada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        


                    }


                }
                else
                {

                    MessageBox.Show("Debe ingresar una descripción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            textBoxDescripSub.Text = string.Empty;
            _cuentaId = 0;
        }

        private void dataGridViewSubCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                if (e.RowIndex >= 0)
                {
                    _cuentaId = Convert.ToInt32(dataGridViewSubCuentas.Rows[e.RowIndex].Cells[(int)Col_Costo.COL_CODIGO].Value);
                    //TextBoxCodigo.Text = dataGridViewCentros.Rows[e.RowIndex].Cells[(int)Col_Costo.COL_CODIGO].Value.ToString();
                    textBoxDescripSub.Text = dataGridViewSubCuentas.Rows[e.RowIndex].Cells[(int)Col_Costo.COL_DESCRIPCION].Value.ToString();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
