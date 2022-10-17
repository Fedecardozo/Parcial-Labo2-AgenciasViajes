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
        private static List<Viaje> viajes;

        #region Constructor Estatico
        static Harcodeo()
        {
            Harcodeo.usuarios = new List<Usuario>();
            Harcodeo.cruceros = new List<Crucero>();
            Harcodeo.viajes = new List<Viaje>();
        }
        #endregion

        #region Harcodeo global

        public static void Global()
        {
            Harcodeo.Cruceros();
            Harcodeo.Viajes();
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
            cruceros.Add(new Crucero("ABC265", "Titanic", 5, 5, 2, 1000, false, true));
            //Crucero 2
            cruceros.Add(new Crucero("EWK264", "Corsa", 5, 5, 2, 1000, false, true));
            //Crucero 3
            cruceros.Add(new Crucero("ABC267", "Vento", 5, 5, 2, 1000, false, true));
            //Crucero 4
            cruceros.Add(new Crucero("ABC266", "Sirocco", 5, 5, 2, 1000, false, true));
            //Crucero 5
            cruceros.Add(new Crucero("ABC268", "Ferrari", 5, 5, 2, 1000, false, true));
            //Crucero 6
            cruceros.Add(new Crucero("ABC269", "Lamborghini", 5, 5, 2, 1000, false, true));
            //Crucero 7
            cruceros.Add(new Crucero("ABC277", "Ataque77", 5, 5, 2, 1000, false, true));
        }

        public static List<Crucero> ListaCruceros()
        {
            return Harcodeo.cruceros;
        }

        #endregion

        #region Harcodeo Viajes

        private static void Viajes()
        {
            DateTime fechaRegional;
            DateTime fechaExtra;
            int indexCrucero, indexCruceroExtra, cantPremiun,cantTurista,destinoRegion,destinoExtra;
            
            for (int i = 0; i < 20; i++)
            {
                fechaRegional = Aleatorio.FechaInicio();
                fechaExtra = Aleatorio.FechaInicio();
                indexCrucero = Aleatorio.Azar(0,6);
                indexCruceroExtra = Aleatorio.Azar(0, 6);
                cantPremiun = Aleatorio.Azar(5,20);
                cantTurista = Aleatorio.Azar(10,25);
                destinoRegion = Aleatorio.Azar(0,9);
                destinoExtra = Aleatorio.Azar(0, 7);

                //Viajes regionales
                Harcodeo.viajes.Add(new ViajeRegional((Eregional)destinoRegion, fechaRegional,Harcodeo.cruceros[indexCrucero],
                    cantPremiun, cantTurista, Aleatorio.FechaLlegadaRegional(fechaRegional)));

                //Viajes extra regionales
                Harcodeo.viajes.Add(new ViajeExtraRegional((EextraRegional)destinoExtra, fechaExtra, Harcodeo.cruceros[indexCruceroExtra],
                    10, 5, Aleatorio.FechaLlegadaRegional(fechaExtra)));
            }

        }

        public static List<Viaje> ListaViajes()
        {
            return Harcodeo.viajes;
        }

        #endregion

    }
}
