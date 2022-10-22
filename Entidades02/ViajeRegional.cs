using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ViajeRegional : Viaje
    {
        private Eregional destino;

        public ViajeRegional(Eregional destino, DateTime fechaInicioViaje, Crucero crucero, DateTime fechaDeLlegada)
            : base(fechaInicioViaje, crucero, fechaDeLlegada)
        {
            this.destino = destino;
        }

        public ViajeRegional(Eregional destino, DateTime fechaInicioViaje, Crucero crucero, DateTime fechaDeLlegada, List<Pasajero> listPasajeros)
            : base(fechaInicioViaje, crucero, fechaDeLlegada, listPasajeros)
        {

        }

        public ViajeRegional(DateTime fechaInicioViaje, Crucero crucero, Eregional destino)
           : base(fechaInicioViaje, crucero, Aleatorio.FechaLlegadaExtraRegional(fechaInicioViaje))
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
