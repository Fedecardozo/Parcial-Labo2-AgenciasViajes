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
    public partial class FrmInformacionEstadistica : FrmPadre
    {
        private string titulo;
        private string informacion;

        public FrmInformacionEstadistica()
        {
            InitializeComponent();
        }

        public FrmInformacionEstadistica(string titulo,string informacion):this()
        {
            this.titulo = titulo;
            this.informacion = informacion;
        }

        private void FrmInformacionEstadistica_Load(object sender, EventArgs e)
        {
            FrmPadre.Centrar(this.panelContenedor,this);

            if(titulo is not null)
            {
                this.Text = this.titulo;
            }

            if(informacion is not null)
            {
                this.textBoxInformacion.Text = this.informacion; 
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
