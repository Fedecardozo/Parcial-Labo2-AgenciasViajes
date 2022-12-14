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
    public partial class FrmPadre : Form
    {
        public FrmPadre()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Centra un panel dentro del marco del formulario a medida que se agranda
        /// </summary>
        /// <param name="panel1"></param>
        /// <param name="form1"></param>
        protected static void Centrar(Panel panel1, Form form1)
        {
            int altura_forma = form1.Height;
            int anchura_forma = form1.Width;
            int alturaPanel = panel1.Height;
            int anchuraPanel = panel1.Width;

            int nuevaAltura = (altura_forma - alturaPanel - 45) / 2;
            int nuevaAnchura = (anchura_forma - anchuraPanel - 20) / 2;

            panel1.Location = new Point(nuevaAnchura, nuevaAltura);
            //return new Point(nuevaAnchura, nuevaAltura);
        }

        protected void MostrarFormularioModal(Form form)
        {
            this.Hide();

            form.ShowDialog();

            this.Show();
            
        }


    }

   
}
