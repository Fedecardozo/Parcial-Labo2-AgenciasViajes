using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruzeiro
{
    public partial class FrmCargaPasajero : FrmPadre
    {
        public FrmCargaPasajero()
        {
            InitializeComponent();
        }

        private void FrmCargaPasajero_Load(object sender, EventArgs e)
        {
            FrmPadre.Centrar(this.panelContenedor,this);
        }
    }
}
