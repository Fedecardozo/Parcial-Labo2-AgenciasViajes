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
            Random random = new Random();

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
                    break;

                }
                #endregion
               

            }

        }
    }
}
