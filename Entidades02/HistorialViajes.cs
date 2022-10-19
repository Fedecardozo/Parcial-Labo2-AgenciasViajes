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

        public static bool ViajesDiponibles(out List<Viaje> viajes1)
        {
            bool retorno = false;
            viajes1 = new List<Viaje>();

            foreach (Viaje item in viajes)
            {
                if(item.EstadoViaje == EestadoViaje.Disponible)
                {
                    viajes1.Add(item);

                    retorno = true;
                    
                }
            }


            return retorno;
        }

        public static List<Viaje> HistorialdeViajes { get { return HistorialViajes.viajes; } }

    }
}
