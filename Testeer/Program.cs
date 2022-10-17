using System;
using Entidades;
using System.Collections.Generic;

namespace Testeer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if(Validacion.ValidarUsuario(new Usuario("admin", "admin")))
            {
                Console.WriteLine("Viajes disponibles");

                #region Viajes Disponibles
                foreach (Crucero crucero in Harcodeo.ListaCruceros())
                {
                    if(crucero.EstadoViaje == EestadoViaje.Disponible)
                    {
                        Console.WriteLine(crucero.ToString());
                    }
                }
                #endregion

            }

        }
    }
}
