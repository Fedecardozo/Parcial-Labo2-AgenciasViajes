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

namespace Parcial_Labo2_AgenciasViajes
{
    public partial class FrmSecundario : Form
    {
        public FrmSecundario()
        {
            InitializeComponent();
            //this.CenterToParent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial();

            frmHistorial.ShowDialog();

        }
    }
}
