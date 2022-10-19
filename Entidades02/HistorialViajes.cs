using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class HistorialViajes
    {

        public static bool ViajesDiponibles(out List<Viaje> viajes)
        {
            bool retorno = false;
            viajes = new List<Viaje>();


            foreach (Viaje item in Harcodeo.ListaViajes())
            {
                if(item.EstadoViaje == EestadoViaje.Disponible)
                {
                    viajes.Add(item);

                    retorno = true;
                    
                }
            }


            return retorno;
        }

    }
}
