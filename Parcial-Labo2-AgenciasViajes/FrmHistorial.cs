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
    public partial class FrmHistorial : FrmCentrado
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
            //No se puede agregar mas filas
            this.dataGridViajes.AllowUserToAddRows = false;

            //No se puede seleccionar mas de una fila
            this.dataGridViajes.MultiSelect = false;

            //Se selecciona toda la fila
            this.dataGridViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Elimina la primera columna que viene por defecto
            this.dataGridViajes.RowHeadersVisible = false;

            //Saco la visibilidad de la primera columna
            this.dataGridViajes.Columns[0].Visible = false;

            //Centro el header
            this.dataGridViajes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            

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
            
            int obtenerIndex = this.dataGridViajes.CurrentRow.Index;
            int obtenerId = int.Parse(this.dataGridViajes.Rows[obtenerIndex].Cells[0].Value.ToString());
            this.historial.ObtenerViaje(obtenerId,out this.obtenerViaje);
            
            //MessageBox.Show(obtenerId.ToString());
        }

        private void FrmHistorial_SizeChanged(object sender, EventArgs e)
        {
            this.Centrado(this.panelListado,this);
        }

        private void dataGridViajes_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            //Las columnas toman todo el espacio
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
    }
}
