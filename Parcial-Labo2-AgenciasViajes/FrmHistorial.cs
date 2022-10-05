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
        private HistorialViajes historial;
        private Viaje obtenerViaje; 

        public FrmHistorial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.historial = new HistorialViajes();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            Harcodeo.HarcodeoProgram(historial);
            
            foreach (Viaje viaje in historial.Viajes)
            {
                this.dataGridViajes.Rows.Add(viaje.Id,viaje.CiudadPartida,viaje.TipoDestino,viaje.FechaInicioViaje,viaje.FechaLlegada,viaje.Crucero.Nombre,viaje.Crucero.LugaresDisponibles,
                    viaje.CantidadTurista,viaje.CantidadPremium,viaje.Estado,viaje.DuracionViaje);
            }
        }

        private void btnVisualizarPasajero_Click(object sender, EventArgs e)
        {

            if(this.dataGridViajes.Rows.Count > 0)
            {
                FrmListaPasajeros frmPasajeros = new FrmListaPasajeros();

                //MessageBox.Show($"{obtenerId}");
                
                FrmListaPasajeros.cargaPasajero(frmPasajeros,this.obtenerViaje.Pasajeros);
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
            //int obtenerIndex = this.dataGridViajes.CurrentRow.Index;
            //string obtenerEstado = this.dataGridViajes.Rows[obtenerIndex].Cells[9].Value.ToString();
            //Eestado obtenerEstado = (Eestado)this.dataGridViajes.Rows[obtenerIndex].Cells[9].Value;

            if (this.obtenerViaje.Estado == Eestado.Disponible && this.obtenerViaje.Crucero.EstadoCrucero == Eestado.Disponible)
            {
                FrmCargaPasajero frmCargaPasajero = new FrmCargaPasajero();

                frmCargaPasajero.ShowDialog();
            }
            else if(this.obtenerViaje.Crucero.EstadoCrucero == Eestado.Completo)
            {
                MessageBox.Show("Crucero Completo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Viaje no diponible","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void dataGridViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            int obtenerIndex = this.dataGridViajes.CurrentRow.Index;
            int obtenerId = int.Parse(this.dataGridViajes.Rows[obtenerIndex].Cells[0].Value.ToString());
            this.historial.ObtenerViaje(obtenerId,out this.obtenerViaje);
            
            //MessageBox.Show(obtenerId.ToString());
        }
    }
}
