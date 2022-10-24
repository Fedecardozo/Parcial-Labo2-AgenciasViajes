using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Cruzeiro
{
    public partial class FrmHistorialViajes : FrmViajes
    {
        private FrmHistorialViajes()
        {
            InitializeComponent();
        }
        public FrmHistorialViajes(Usuario usuario) : this()
        {
            base.usuario = usuario;
        }
        private void FrmHistorialViajes_Load(object sender, EventArgs e)
        {
            base.CargarDataGrid(HistorialViajes.HistorialdeViajes);
            
        }

    }
}
