﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ViajeRegional : Viaje
    {
        private Eregional destino;

        public ViajeRegional(Eregional destino, DateTime fechaInicioViaje, Crucero crucero, int cantidClasePremium,
            int cantidadClaseTurista, DateTime fechaDeLlegada)
            : base(fechaInicioViaje, crucero, cantidClasePremium, cantidadClaseTurista, fechaDeLlegada)
        {
            this.destino = destino;
        }

        public override string TipoDestino { get { return this.destino.ToString(); } }

        public override string ToString()
        {
            return base.ToString() + "\nDestino: " + this.destino;
        }

    }
}
