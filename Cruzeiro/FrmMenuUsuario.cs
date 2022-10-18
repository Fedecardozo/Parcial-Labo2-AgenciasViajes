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
    public partial class FrmMenuUsuario : FrmPadre
    {
        public FrmMenuUsuario()
        {
            InitializeComponent();
        }

        private void FrmMenuUsuario_Load(object sender, EventArgs e)
        {
            FrmPadre.Centrar(this.panelContenedor,this);
        }
    }
}
