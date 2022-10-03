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
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            HistorialViajes historial = new HistorialViajes();
            HistorialViajes.HarcodeoViajes(historial, Harcodeo.HarcodeoViaje());

            foreach (Viaje viaje in historial.Viajes)
            {
                this.dataGridViajes.Rows.Add("Buenos Aires",EextraRegional.Nueva_York,viaje.FechaInicioViaje,viaje.NombreCrucero,viaje.MatriculaCrucero,viaje.CantidadTurista,viaje.CantidadPremium,viaje.DuracionViaje);
            }
        }

        private void btnVisualizarPasajero_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }
    }
}
