using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Viaje
    {
        private const int costoPremium = 120;
        private const int costoTurista = 57;
        List<Pasajero> listPasajeros;
        private Ciudad ciudadPartida;
        private Ciudad ciudadDestino;
        private DateTime fechaInicioViaje;
        private Crucero crucero;
        private int cantidClasePremium;
        private int cantidadClaseTurista;
        private Random duracionViaje;

        

        public string mostrarCiudad()
        {
            return $"{this.ciudadPartida} - {this.ciudadDestino}";
        }

    }
}
