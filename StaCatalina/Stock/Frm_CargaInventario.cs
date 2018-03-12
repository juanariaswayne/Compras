using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Stock
{
    public partial class Frm_CargaInventario : StaCatalina.Plantilla
    {
        public Frm_CargaInventario()
        {
            InitializeComponent();
        }

        private void dataGridViewArtInventario_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewArtInventario.IsCurrentCellDirty)
                dataGridViewArtInventario.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
