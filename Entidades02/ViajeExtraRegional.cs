using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adicional;

namespace Entidades
{
    public class ViajeExtraRegional : Viaje
    {
        #region Atributos
        private EextraRegional destino;
        #endregion

        #region Constructores
        public ViajeExtraRegional(EextraRegional destino, DateTime fechaInicioViaje, Crucero crucero,List<Pasajero> listPasajeros)
            : this(fechaInicioViaje, crucero, destino)
        {
            base.listPasajeros = listPasajeros;
        }

        public ViajeExtraRegional( DateTime fechaInicioViaje, Crucero crucero, EextraRegional destino) 
            : base(fechaInicioViaje, crucero, Aleatorio.FechaLlegadaExtraRegional(fechaInicioViaje))
        {
            this.destino = destino;
            base.costoTurista = 120;
            base.costoPremium = base.costoTurista + (base.costoTurista * 20) / 100;
        }
        #endregion

        #region Propiedadess
        public override string TipoDestino { get { return this.destino.ToString(); } }
        #endregion

        #region Sobreescritura
        public override string ToString()
        {
            return base.ToString() + "\nDestino: " + this.destino;
        }
        #endregion
    }
}
