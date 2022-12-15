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
        #region Atributos
        private string titulo;
        private string informacion;
        #endregion

        #region Constructores
        public FrmInformacionEstadistica()
        {
            InitializeComponent();
        }

        public FrmInformacionEstadistica(string titulo,string informacion):this()
        {
            this.titulo = titulo;
            this.informacion = informacion;
        }

        #endregion

        #region Load
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
        #endregion

        #region Boton
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
