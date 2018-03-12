using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaCatalina
{
    public partial class Plantilla : Form
    {
        public Plantilla()
        {
            InitializeComponent();
        }

        private Int32 _id_Perfil;
        private Int32 _id_sector;
        
        public Int32 Id_Perfil
        {
            get { return _id_Perfil; }
            set { _id_Perfil = value; }
        }

        public Int32 Id_Sector
        {
            get { return _id_sector; }
            set { _id_sector = value; }
        }

    }
}
