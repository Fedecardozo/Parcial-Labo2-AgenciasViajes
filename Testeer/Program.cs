using System;
using Entidades;
using System.Collections.Generic;

namespace Testeer
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Harcodeo.Global();

             if (Validacion.ValidarUsuario(new Usuario("admin", "admin")))
             {
                 Console.WriteLine("Viajes disponibles");

                 #region Viajes Disponibles
                 foreach (Viaje viaje in Harcodeo.ListaViajes())
                 {
                     foreach (Pasajero item in viaje.Pasajeros)
                     {
                         Console.WriteLine(item.ToString());
                     }

                     Console.WriteLine("Premium: " + viaje.CantidadPremium);
                     Console.WriteLine("Turista: " + viaje.CantidadTurista);

                     break;

                 }
                 #endregion*/

            string name = "federico cardozo";

            string aux = name.Substring(0,1).ToUpper() + name.Substring(1).ToLower();

            Console.WriteLine(aux);


        }

    }
}
