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
    public partial class FrmCentrado : Form
    {
        public FrmCentrado()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FmrCentrado_Load(object sender, EventArgs e)
        {
            //this.Centrado();
        }

        protected void Centrado(Panel panel1,Form form)
        {
            int altura_forma = form.Height;
            int anchura_forma = form.Width;
            int alturaPanel = panel1.Height;
            int anchuraPanel = panel1.Width;

            int nuevaAltura = (altura_forma - alturaPanel-45) / 2;
            int nuevaAnchura = (anchura_forma - anchuraPanel-20) / 2;

            panel1.Location = new Point(nuevaAnchura,nuevaAltura);
            //return new Point(nuevaAnchura, nuevaAltura);
        }

        protected void Centrado(GroupBox groupBox,Form form)
        {
            int altura_forma = form.Height;
            int anchura_forma = form.Width;
            int alturaPanel = groupBox.Height;
            int anchuraPanel = groupBox.Width;

            int nuevaAltura = (altura_forma - alturaPanel - 45) / 2;
            int nuevaAnchura = (anchura_forma - anchuraPanel - 20) / 2;

            groupBox.Location = new Point(nuevaAnchura,nuevaAltura);
            //return new Point(nuevaAnchura, nuevaAltura);
        }

        protected void Centrado(DataGridView data, Form form)
        {
            int altura_forma = form.Height;
            int anchura_forma = form.Width;
            int alturaPanel = data.Height;
            int anchuraPanel = data.Width;

            int nuevaAltura = (altura_forma - alturaPanel - 45) / 2;
            int nuevaAnchura = (anchura_forma - anchuraPanel - 20) / 2;

            data.Location = new Point(nuevaAnchura, nuevaAltura);
            //return new Point(nuevaAnchura, nuevaAltura);
        }

        private void FmrCentrado_SizeChanged(object sender, EventArgs e)
        {
            //this.Centrado();
        }
    }
}
