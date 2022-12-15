using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adicional;

namespace Entidades
{
    public class ViajeRegional : Viaje
    {
        #region Atributos

        private Eregional destino;

        #endregion

        #region Constructores
        public ViajeRegional(Eregional destino, DateTime fechaInicioViaje, Crucero crucero, List<Pasajero> listPasajeros)
            : this(fechaInicioViaje, crucero, destino)
        {
            base.listPasajeros = listPasajeros;
        }

        public ViajeRegional(DateTime fechaInicioViaje, Crucero crucero, Eregional destino)
           : base(fechaInicioViaje, crucero, Aleatorio.FechaLlegadaRegional(fechaInicioViaje))
        {
            this.destino = destino;
            base.costoTurista = 57;
            base.costoPremium = base.costoTurista + (base.costoTurista * 20) / 100;
        }
        #endregion

        #region Propiedades
        public override string TipoDestino { get { return this.destino.ToString(); } }
        #endregion

        #region Sobreecritura
        public override string ToString()
        {
            return base.ToString() + "\nDestino: " + this.destino;
        }
        #endregion

    }
}
