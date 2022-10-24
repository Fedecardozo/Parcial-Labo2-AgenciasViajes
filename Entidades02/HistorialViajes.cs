using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

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

        /// <summary>
        /// Devuelve solo los viajes que estan disponibles
        /// </summary>
        /// <param name="viajes1"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Devuelve lista de pasajeros de un Viaje en especifico por su Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Pasajero> Pasajeros(int id)
        {
            List<Pasajero> pasajeros = new List<Pasajero>();

            pasajeros = (HistorialViajes.BuscadorViaje(id)).Pasajeros;

            return pasajeros;
        }

        /// <summary>
        /// Busca un por su Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Devuelve lista de viajes realizados por un crucero en especifico
        /// </summary>
        /// <param name="crucero"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Agregar un viaje al historial
        /// </summary>
        /// <param name="viaje"></param>
        public static void AgregarViaje(Viaje viaje)
        {
            HistorialViajes.viajes.Add(viaje);
        }
    }
}
