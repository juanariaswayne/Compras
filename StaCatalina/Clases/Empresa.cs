using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Clases
{
    static class Empresa
    {

        public static void CargarEmpresas( ComboBox _combo )
        {
            try
            {
                StaCatalinaEntities _mod = new StaCatalinaEntities();

                var _listObj = (_mod.varEmpresa).ToList();

                varEmpresa _itemSeleccion = new varEmpresa();

                //Limpia el combo
                _combo.SuspendLayout();
                _combo.DataSource = null;
                _combo.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.Descripcion = "<Seleccione una Empresa>";
                _itemSeleccion.codEmp = "0";
                _listObj.Insert(0, _itemSeleccion);
                //Carga el combo
                _combo.DisplayMember = "Descripcion";
                _combo.ValueMember = "codEmp";
                _combo.DataSource = _listObj;
                _combo.ResumeLayout();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



    }
}
