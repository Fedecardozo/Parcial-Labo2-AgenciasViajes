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
using InterfazDeUsuario;

namespace Cruzeiro
{
    public partial class FrmEstadisticaHistoricas : FrmHistorialViajes
    {
        #region Constructor
        public FrmEstadisticaHistoricas()
        {
            InitializeComponent();
        }
        #endregion

        #region Botones

        private void btnDestinoMasPedido_Click(object sender, EventArgs e)
        {
            this.InstanciarFormInfoEstadistica("Destino más pedido",Estadistica.MostrarDestinosMasPedido());
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            this.InstanciarFormInfoEstadistica("Destinos ordenador por facturación de forma descendente",
                Estadistica.ListarDestinosPorFacturacion(HistorialViajes.HistorialdeViajes));
        }

        private void btnGananciasTotales_Click(object sender, EventArgs e)
        {
            this.InstanciarFormInfoEstadistica("Ganancias totales clasificadas por servicio (region / extra regional)",
                Estadistica.ListarGananciasTotalesClasificadas());
        }

        private void btnHorasCrucero_Click(object sender, EventArgs e)
        {
            this.InstanciarFormInfoEstadistica("Horas de viaje de cada crucero",
                Estadistica.HorasViajesCruceros());
        }

        private void btnPasajeroFrecuentes_Click(object sender, EventArgs e)
        {
            this.InstanciarFormInfoEstadistica("Pasajeros más frecuentes ordenados por cantidad de viajes",
                Estadistica.ListarPasajeroFrecuentes());
        }

        #endregion

        #region Metodos
        private void InstanciarFormInfoEstadistica(string titulo, string info)
        {
            FrmInformacionEstadistica frmInfo = new FrmInformacionEstadistica(titulo,info);

            frmInfo.ShowDialog();
        }
        #endregion
    }
}
