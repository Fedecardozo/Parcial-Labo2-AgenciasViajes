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

            Console.WriteLine(Estadistica.ListarDestinosPorFacturacion(HistorialViajes.HistorialdeViajes));


        }

    }
}
