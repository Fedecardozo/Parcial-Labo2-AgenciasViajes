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
    public partial class FrmViajes : FrmPadre
    {
        public FrmViajes()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void CargarDataGrid(List<Viaje> listaViajes)
        {
            foreach (Viaje viaje in listaViajes)
            {
                this.dataGridViewViajes.Rows.Add(viaje.Id, viaje.CiudadPartida, viaje.TipoDestino, viaje.FechaInicioViaje, viaje.FechaLlegada, viaje.Crucero.Nombre,
                    viaje.CantidadTurista, viaje.CantidadPremium, viaje.EstadoViaje.ToString(), viaje.DuracionViaje);
            }
        }

    }
}
