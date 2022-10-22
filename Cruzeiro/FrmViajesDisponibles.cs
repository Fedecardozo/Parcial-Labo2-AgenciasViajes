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

        private void btnCargaPasajero_Click(object sender, EventArgs e)
        {

            Viaje viaje = HistorialViajes.BuscadorViaje(base.idViaje);

            if (viaje is not null)
            {
                base.MostrarFormularioModal(new FrmCargaPasajero(viaje));
            }
            else
            {
                MessageBox.Show("No se puede cargar pasajeros a este viaje","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            List<Viaje> viajeDisponibles;

            base.MostrarFormularioModal(new FrmCrearViaje());

            if(HistorialViajes.ViajesDiponibles(out viajeDisponibles))
            {
                base.ActualizarDataGrid(viajeDisponibles);
            }
        }

        #region Metodos
        private void MostrarViajesDisponibles()
        {
            List<Viaje> viajeDisponibles;

            if (!HistorialViajes.ViajesDiponibles(out viajeDisponibles))
            {
                if(MessageBox.Show("¿Desea continuar?", "Sin viajes disponibles", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                base.CargarDataGrid(viajeDisponibles);
            }
        }
        
        #endregion

        
    }
}
