using System;
using Entidades;
using System.Collections.Generic;

namespace Testeer
{
    class Program
    {
        static void Main(string[] args)
        {

            Harcodeo.Global();

            Viaje viaje = HistorialViajes.HistorialdeViajes[0];

            Console.WriteLine(viaje.ToString());

            Console.WriteLine("");

            Console.WriteLine("Cantidad turista: " + viaje.CantidadTurista);
            Console.WriteLine("Costo turista: " + viaje.CostoTurista);
            Console.WriteLine("");
            Console.WriteLine("Cantidad premium: " + viaje.CantidadPremium);
            Console.WriteLine("Costo premium: " + viaje.CostoPremium);
            Console.WriteLine("");
            Console.WriteLine("Total facturado: " + viaje.TotalFacturado);


        }

    }
}
