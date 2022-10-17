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
            
            if(Validacion.ValidarUsuario(new Usuario("admin", "admin")))
            {
                Console.WriteLine("Viajes disponibles");

                #region Viajes Disponibles
                /*foreach (Crucero crucero in Harcodeo.ListaCruceros())
                {
                    if(true)
                    {
                        Console.WriteLine(crucero.ToString());
                    }
                }*/
                #endregion

                for (int i = 0; i < 5; i++)
                {
                    DateTime fechaInicio = Aleatorio.FechaInicio();
                    Console.WriteLine("Regional");
                    Console.WriteLine($"Fecha inicio: {fechaInicio}");
                    Console.WriteLine($"Fecha llegada: {Aleatorio.FechaLlegadaRegional(fechaInicio)}");
                    Console.WriteLine($"Fecha nacimiento: {Aleatorio.FechaNacimiento()}");
                    Console.WriteLine("");
                    DateTime fechaInicio2 = Aleatorio.FechaInicio();
                    Console.WriteLine("Extra Regional");
                    Console.WriteLine($"Fecha inicio: {fechaInicio2}");
                    Console.WriteLine($"Fecha llegada: {Aleatorio.FechaLlegadaExtraRegional(fechaInicio2)}");
                    Console.WriteLine($"Fecha nacimiento: {Aleatorio.FechaNacimiento()}");
                    Console.WriteLine("");
                }

            }

        }
    }
}
