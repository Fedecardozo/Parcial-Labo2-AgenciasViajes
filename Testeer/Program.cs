using System;
using Entidades;

namespace Testeer
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime fecha = new DateTime();

            Crucero crucero = new Crucero("EWK264","Corsel",10,10,1,10000,true,true);

            Viaje viajesito = new Viaje(fecha.Date,crucero,10,10);

            Viaje.HarcodeoPasajeros(Harcodeo.HarcodeoPasajeros(),viajesito);

            foreach (Pasajero item in viajesito.GetListPasajeros())
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}
