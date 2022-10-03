using System;
using Entidades;

namespace Testeer
{
    class Program
    {
        static void Main(string[] args)
        {

            HistorialViajes historial = new HistorialViajes();
            HistorialViajes.HarcodeoViajes(historial, Harcodeo.HarcodeoViaje());

            foreach (Viaje viaje in historial.Viajes)
            {
                Console.WriteLine(viaje.Mostrar());

            }

        }
    }
}
