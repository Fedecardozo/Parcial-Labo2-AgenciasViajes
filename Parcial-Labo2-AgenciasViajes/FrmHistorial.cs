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
        private HistorialViajes historial = new HistorialViajes();
         

        public FrmHistorial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            Harcodeo.HarcodeoProgram(historial);

            int i = 1;
            
            foreach (Viaje viaje in historial.Viajes)
            {
                this.dataGridViajes.Rows.Add(i++,"Buenos Aires",EextraRegional.Nueva_York,viaje.FechaInicioViaje,viaje.Crucero.Nombre,viaje.Crucero.Matricula,
                    viaje.CantidadTurista,viaje.CantidadPremium,viaje.DuracionViaje);
            }
        }

        private void btnVisualizarPasajero_Click(object sender, EventArgs e)
        {

            if(this.dataGridViajes.Rows.Count > 0)
            {
                FrmListaPasajeros frmPasajeros = new FrmListaPasajeros();

                int obtenerIndex = this.dataGridViajes.CurrentRow.Index;
                int obtenerIdIndex = int.Parse(this.dataGridViajes.Rows[obtenerIndex].Cells[0].Value.ToString());
                //MessageBox.Show($"{obtenerId}");
                
                FrmListaPasajeros.cargaPasajero(frmPasajeros,historial.Viajes[obtenerIdIndex-1].Pasajeros);
                frmPasajeros.ShowDialog();
                //MessageBox.Show(this.dataGridViajes.CurrentRow.Index.ToString());
            }
            else 
            {
                MessageBox.Show("NO tenes cargado nada Pa!");
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
