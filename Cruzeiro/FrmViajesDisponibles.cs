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
    public partial class FrmViajesDisponibles : FrmViajes
    {

        public FrmViajesDisponibles()
        {
            InitializeComponent();
        }

        private void FrmViajesDisponibles_Load(object sender, EventArgs e)
        {

            //Harcodeo.Global();

            this.MostrarViajesDisponibles();
            

        }

        #region Metodos
        private void MostrarViajesDisponibles()
        {
            List<Viaje> viajeDispobibles;

            if (!HistorialViajes.ViajesDiponibles(out viajeDispobibles))
            {
                if(MessageBox.Show("¿Desea continuar?", "Sin viajes disponibles", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                foreach (Viaje viaje in viajeDispobibles)
                {
                    this.dataGridViewViajes.Rows.Add(viaje.Id, viaje.CiudadPartida, viaje.TipoDestino, viaje.FechaInicioViaje, viaje.FechaLlegada, viaje.Crucero.Nombre,
                        viaje.CantidadTurista, viaje.CantidadPremium, viaje.EstadoViaje.ToString(), viaje.DuracionViaje);
                }

            }
        }

        #endregion

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
