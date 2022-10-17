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
        private static List<Crucero> cruceros;

        #region Constructor Estatico
        static Harcodeo()
        {
            Harcodeo.usuarios = new List<Usuario>();
            Harcodeo.cruceros = new List<Crucero>();
        }
        #endregion

        #region Harcodeo de Usuarios

        private static Usuario[] Usuarios()
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

            //Cargo los datos
            Harcodeo.AgregarUsuarios(Harcodeo.Usuarios());

            return Harcodeo.usuarios;

        }

        #endregion

        #region Harcodeo Crucero

        private static void Cruceros()
        {
            //Crucero 1
            cruceros.Add(new Crucero("ABC265","Titanic",5,5,2,1000,false,true,EestadoViaje.Disponible));
            //Crucero 2
            cruceros.Add(new Crucero("EWK264", "Corsa", 5, 5, 2, 1000, false, true, EestadoViaje.En_Viaje));
            //Crucero 3
            cruceros.Add(new Crucero("ABC267", "Vento", 5, 5, 2, 1000, false, true, EestadoViaje.En_Viaje));
            //Crucero 4
            cruceros.Add(new Crucero("ABC266", "Sirocco", 5, 5, 2, 1000, false, true, EestadoViaje.Disponible));
            //Crucero 5
            cruceros.Add(new Crucero("ABC268", "Ferrari", 5, 5, 2, 1000, false, true, EestadoViaje.En_Viaje));
            //Crucero 6
            cruceros.Add(new Crucero("ABC269", "Lamborghini", 5, 5, 2, 1000, false, true, EestadoViaje.Disponible));
            //Crucero 7
            cruceros.Add(new Crucero("ABC277", "Ataque77", 5, 5, 2, 1000, false, true, EestadoViaje.En_Viaje));
        }
        
        public static List<Crucero> ListaCruceros()
        {
            Harcodeo.Cruceros();
            return Harcodeo.cruceros;
        }

        #endregion
    }
}
