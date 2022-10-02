using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harcodeo
    {
        private static List<Usuario> usuarios;

        private static Usuario[] HarcodeoUsuarios()
        {
            Usuario[] usuarios = {new Usuario("admin","admin"), new Usuario("admin2", "admin2"),
                new Usuario("admin3", "admin3"),new Usuario("admin4","admin4") };

            return usuarios;
        }

        private static void AgregarUsuarios(Usuario[] usuarios)
        {

            for (int i = 0; i < usuarios.Length; i++)
            {
                Harcodeo.usuarios.Add(usuarios[i]);
            }

        }

        public static List<Usuario> ListaUsuarios()
        {
            //Inicio la misma clase
            Harcodeo.usuarios = new List<Usuario>();

            //Cargo los datos
            Harcodeo.AgregarUsuarios(Harcodeo.HarcodeoUsuarios());

            return Harcodeo.usuarios;

        }
    }
}
