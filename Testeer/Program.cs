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
                foreach (Viaje viaje in Harcodeo.ListaViajes())
                {
                  
                     Console.WriteLine(viaje.ToString());
                    
                }
                #endregion


            }

        }
    }
}
