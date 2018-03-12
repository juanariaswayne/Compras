using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina.Catalogos
{
    public partial class Frm_Eventos : Form
    {
        public Frm_Eventos()
        {
            InitializeComponent();
        }
        public List<Entities.Procedures.EVENTOSUSUARIO> _listEvento = new List<Entities.Procedures.EVENTOSUSUARIO>();

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Eventos_Load(object sender, EventArgs e)
        {
            if(_listEvento.Count > 0)
            {
                foreach (Entities.Procedures.EVENTOSUSUARIO item in _listEvento)
                {
                    this.listBoxEvento.Items.Add(item.descripcion);
                }

            }
        }
    }
}
