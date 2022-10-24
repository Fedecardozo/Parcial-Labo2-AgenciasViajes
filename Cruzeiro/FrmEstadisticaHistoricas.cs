﻿using System;
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
    public partial class FrmEstadisticaHistoricas : FrmHistorialViajes
    {
        public FrmEstadisticaHistoricas()
        {
            InitializeComponent();
        }

        private void btnDestinoMasPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            FrmInformacionEstadistica frmInfo = new FrmInformacionEstadistica("Destinos ordenador por facturación de forma descendente",
                Estadistica.ListarDestinosPorFacturacion(HistorialViajes.HistorialdeViajes));

            frmInfo.ShowDialog();
        }

        private void btnGananciasTotales_Click(object sender, EventArgs e)
        {

        }

        private void btnHorasCrucero_Click(object sender, EventArgs e)
        {

        }

        private void btnPasajeroFrecuentes_Click(object sender, EventArgs e)
        {
            FrmInformacionEstadistica frmInfo = new FrmInformacionEstadistica("Pasajeros más frecuentes ordenados por cantidad de viajes",
                Estadistica.ListarPasajeroFrecuentes());

            frmInfo.ShowDialog();
        }
    }
}
