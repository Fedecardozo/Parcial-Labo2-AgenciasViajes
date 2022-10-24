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
        protected static Usuario usuario;
        public FrmViajes()
        {
            InitializeComponent();
        }

        public static Usuario Usuario { set { FrmViajes.usuario = value; } }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void CargarDataGrid(List<Viaje> listaViajes)
        {
            Crucero crucero;
            foreach (Viaje viaje in listaViajes)
            {
                crucero = viaje.Crucero;

                this.dataGridViewViajes.Rows.Add(viaje.Id, viaje.CiudadPartida, viaje.TipoDestino, viaje.FechaInicioViaje, viaje.FechaLlegada, viaje.DuracionViaje.ToString(),
                   viaje.CostoPremium.ToString("N2"),viaje.CostoTurista.ToString("N2"),crucero.Nombre,crucero.Gimnsaio,crucero.Piscina,viaje.CapacidadDisponibleBodega.ToString("N3"),crucero.CantidadCasinos,
                    viaje.CamaroteDisponiblePremium, viaje.CamaroteDisponibleTurista, viaje.EstadoViaje.ToString());
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

        private void FrmViajes_Load(object sender, EventArgs e)
        {
            this.labelNameOperador.Text = FrmViajes.usuario.Nombre + " " + FrmViajes.usuario.Apellido;
            this.labelFechaActual.Text = DateTime.Now.ToString("D");
        }
    }
}
