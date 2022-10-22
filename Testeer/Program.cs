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

            Crucero crucero = new Crucero("ABC265", "Titanic", 5, 5, 2, 1000, false, true);
            DateTime fechaLlegadaMayor = DateTime.Now;
            DateTime fechaLlegada;
            int contador = 0;

            foreach (Viaje item in crucero.ViajesRealizados)
            {
                if (item.EstadoViaje == EestadoViaje.Disponible)
                {

                    fechaLlegada = item.FechaLlegada;

                    Console.WriteLine(item);

                    if(contador == 0)
                    {
                        fechaLlegadaMayor = fechaLlegada;
                    }
                    else if(contador > 0 && fechaLlegada > fechaLlegadaMayor)
                    {
                        fechaLlegadaMayor = fechaLlegada;
                    }

                    Console.WriteLine("Fecha Llegada: " + fechaLlegada.ToString("d"));
                    Console.WriteLine("");
                    //Console.WriteLine(fechaLlegada.AddDays(1).ToString("d"));

                    contador++;
                }
            }

            Console.WriteLine(fechaLlegadaMayor.ToString("d"));


        }

    }
}
