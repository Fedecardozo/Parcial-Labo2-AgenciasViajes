using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class HistorialViajes
    {

        private static List<Viaje> viajes;

        static HistorialViajes()
        {
            HistorialViajes.viajes = Harcodeo.ListaViajes();
        }
        public static List<Viaje> HistorialdeViajes { get { return HistorialViajes.viajes; } }

        public static bool ViajesDiponibles(out List<Viaje> viajes1)
        {
            bool retorno = false;
            viajes1 = new List<Viaje>();

            foreach (Viaje item in viajes)
            {
                if (item.EstadoViaje == EestadoViaje.Disponible)
                {
                    viajes1.Add(item);

                    retorno = true;

                }
            }


            return retorno;
        }

        public static List<Pasajero> Pasajeros(int id)
        {
            List<Pasajero> pasajeros = new List<Pasajero>();

            pasajeros = (HistorialViajes.BuscadorViaje(id)).Pasajeros;

            return pasajeros;
        }

        public static Viaje BuscadorViaje(int id)
        {
            Viaje viaje = null;
            foreach (Viaje item in HistorialViajes.viajes)
            {
                if (item == id)
                {
                    viaje = item;
                    break;
                }
            }

            return viaje;
        }

        public static List<Viaje> ViajesRealizadosPorDeterminadoCrucero(Crucero crucero)
        {
            List<Viaje> historial = new List<Viaje>();

            foreach (Viaje item in HistorialViajes.viajes)
            {
                if (item.Crucero == crucero)
                {
                    historial.Add(item);
                }
            }


            return historial;
        }

        public static void AgregarViaje(Viaje viaje)
        {
            HistorialViajes.viajes.Add(viaje);
        }
    }
}
