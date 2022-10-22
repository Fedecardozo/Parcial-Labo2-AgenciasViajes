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

        protected int idViaje;
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

            this.idViaje = int.Parse(this.dataGridViewViajes.Rows[0].Cells[0].Value.ToString());
        }

        private void btnListaPasajeros_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewViajes.Rows.Count >= 0)
            {
                base.MostrarFormularioModal(new FrmListaPasajeros(HistorialViajes.Pasajeros(this.idViaje)));           
            }
            else
            {
                MessageBox.Show("No hay pasajeros cargados","Error!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void dataGridViewViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int obtenerIndex = this.dataGridViewViajes.CurrentRow.Index;

            this.idViaje = int.Parse(this.dataGridViewViajes.Rows[obtenerIndex].Cells[0].Value.ToString());
            
            //dataGridViewViajes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(209, 227, 254);
        }

        protected void ActualizarDataGrid(List<Viaje> listaViajes)
        {
            this.dataGridViewViajes.Rows.Clear();
            this.CargarDataGrid(listaViajes);
        }

    }
}
