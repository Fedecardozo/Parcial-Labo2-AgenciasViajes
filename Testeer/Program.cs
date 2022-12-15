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

           /* Usuario user = new Usuario("admin","fede","cardozo");
            Usuario user2 = new Usuario("admin2", "fede", "cardozo2");
            Dictionary<string, Usuario> usuario = new Dictionary<string, Usuario>();
            Usuario aux;

            usuario.Add("admin",user);
            usuario.Add("admin2", user2);

            Console.WriteLine("Ingrese contraseña: ");

            Console.WriteLine(usuario.TryGetValue(Console.ReadLine(),out aux));

            Console.WriteLine("Usuario: ");
            string cd = Console.ReadLine();

            Console.WriteLine($"Entro: { cd == aux.User}");
           // Console.WriteLine(aux.ToString());
           */

        }

    }
}
