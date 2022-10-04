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
                this.dataGridViajes.Rows.Add(i++,viaje.CiudadPartida,viaje.TipoDestino,viaje.FechaInicioViaje,viaje.FechaLlegada,viaje.Crucero.Nombre,viaje.Crucero.Matricula,
                    viaje.CantidadTurista,viaje.CantidadPremium,viaje.Estado,viaje.DuracionViaje);
            }
        }

        private void btnVisualizarPasajero_Click(object sender, EventArgs e)
        {

            if(this.dataGridViajes.Rows.Count > 0)
            {
                FrmListaPasajeros frmPasajeros = new FrmListaPasajeros();

                int obtenerIndex = this.dataGridViajes.CurrentRow.Index;
                int obtenerId = int.Parse(this.dataGridViajes.Rows[obtenerIndex].Cells[0].Value.ToString());
                //MessageBox.Show($"{obtenerId}");
                
                FrmListaPasajeros.cargaPasajero(frmPasajeros,historial.Viajes[obtenerId-1].Pasajeros);
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

        private void btnVenta_Click(object sender, EventArgs e)
        {
            int obtenerIndex = this.dataGridViajes.CurrentRow.Index;
            //string obtenerEstado = this.dataGridViajes.Rows[obtenerIndex].Cells[9].Value.ToString();
            Eestado obtenerEstado = (Eestado)this.dataGridViajes.Rows[obtenerIndex].Cells[9].Value;

            if(obtenerEstado == Eestado.Disponible)
            {
                FrmCargaPasajero frmCargaPasajero = new FrmCargaPasajero();

                frmCargaPasajero.ShowDialog();
            }
            
        }
    }
}
