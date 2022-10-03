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
        public HistorialViajes historial = new HistorialViajes();
         

        public FrmHistorial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            HistorialViajes.HarcodeoViajes(historial, Harcodeo.HarcodeoViaje());
            foreach (Viaje viaje in historial.Viajes)
            {
                this.dataGridViajes.Rows.Add("Buenos Aires",EextraRegional.Nueva_York,viaje.FechaInicioViaje,viaje.Crucero.Nombre,viaje.Crucero.Matricula,viaje.CantidadTurista,viaje.CantidadPremium,viaje.DuracionViaje);
            }
        }

        private void btnVisualizarPasajero_Click(object sender, EventArgs e)
        {
            FrmListaPasajeros frmPasajeros = new FrmListaPasajeros();

            if(this.dataGridViajes.Rows.Count > 0)
            {
                int obtenerIndex = this.dataGridViajes.CurrentRow.Index;
                FrmListaPasajeros.cargaPasajero(frmPasajeros,historial.Viajes[obtenerIndex].Pasajeros);
                frmPasajeros.ShowDialog();
                //MessageBox.Show(this.dataGridViajes.CurrentRow.Index.ToString());
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
