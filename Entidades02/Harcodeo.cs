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
        private static List<Pasaporte> pasaportes;
        private static List<Equipaje> equipajes;
        private static List<Pasajero> pasajeros1;
        private static List<Pasajero> pasajeros2;
        private static List<Pasajero> pasajeros3;

        #region Constructor Estatico
        static Harcodeo()
        {
            Harcodeo.usuarios = new List<Usuario>();
            Harcodeo.cruceros = new List<Crucero>();
            Harcodeo.viajes = new List<Viaje>();
            Harcodeo.pasaportes = new List<Pasaporte>();
            Harcodeo.equipajes = new List<Equipaje>();
            Harcodeo.pasajeros1 = new List<Pasajero>();
            Harcodeo.pasajeros2 = new List<Pasajero>();
            Harcodeo.pasajeros3 = new List<Pasajero>();
            Harcodeo.Global();
        }
        #endregion

        #region Harcodeo global

        public static void Global()
        {
            Harcodeo.Cruceros();
            Harcodeo.Viajes();
            Harcodeo.Pasaportes();
            Harcodeo.Equipaje();
            Harcodeo.Pasajeros();
        }

        #endregion

        #region Harcodeo de Usuarios

        private static Usuario[] Usuarios()
        {
            Usuario[] usuarios = {new Usuario("admin","admin","Federico","Cardozo"), new Usuario("admin2", "admin2","Gaston","Bizarrap"),
                new Usuario("admin3","admin3","Nicolas", "Bertolo"),new Usuario("admin4","admin4","Lionel","Messi") };

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
            cruceros.Add(new Crucero("ABC265FF", "Titanic", 20, 5, 1, 1050, false, false));
            //Crucero 2
            cruceros.Add(new Crucero("EWK264AA", "Corsa", 30, 5, 0, 1300, false, true));
            //Crucero 3
            cruceros.Add(new Crucero("ABC267HH", "Vento", 40, 5, 2, 1500, true, false));
            //Crucero 4
            cruceros.Add(new Crucero("ABC266JJ", "Sirocco", 25, 5, 0, 1100, false, true));
            //Crucero 5
            cruceros.Add(new Crucero("ABC268SD", "Ferrari", 35, 5, 1, 1350, true, false));
            //Crucero 6
            cruceros.Add(new Crucero("ABC269AF", "Lamborghini", 45, 3, 2, 1700, true, true));
            //Crucero 7
            cruceros.Add(new Crucero("ABC277SW", "Ataque77", 50, 5, 4, 2000, true, true));
        }

        public static List<Crucero> ListaCruceros()
        {
            return Harcodeo.cruceros;
        }

        #endregion

        #region Harcodeo Pasajeros

        private static void Pasaportes()
        {

            Harcodeo.pasaportes.Add(new Pasaporte("Fede", "Cardozo", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Lea", "Cardozo", 54546645, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123458));
            Harcodeo.pasaportes.Add(new Pasaporte("Marcos", "Paez", 112311321, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123496));
            Harcodeo.pasaportes.Add(new Pasaporte("Carina", "Jaure", 16156161, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Femenino, 123455));
            Harcodeo.pasaportes.Add(new Pasaporte("Carmen", "Benvidez", 1161566, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Femenino, 123956));
            Harcodeo.pasaportes.Add(new Pasaporte("Toby", "Perrito", 161523213, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123756));
            Harcodeo.pasaportes.Add(new Pasaporte("Evelio", "Paez", 23133212, Aleatorio.FechaNacimiento(), "PARAGUAY", ESexo.Masculino, 123450));
            Harcodeo.pasaportes.Add(new Pasaporte("Clarisa", "Alvarez", 123131654, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Femenino, 183456));

            Harcodeo.pasaportes.Add(new Pasaporte("Carlos", "Ferreiro", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Miguel ", "Gironeiro", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Pedro", "Alcantara", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Ramiro", "Maroto", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Luis", "Alcaide", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Arturo", "Pavon", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Jose", "Marrero", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));

            Harcodeo.pasaportes.Add(new Pasaporte("Maximino", "Milione", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Gaspar", "Servio", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Debora", "Robledo", 1161566, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Femenino, 123956));
            Harcodeo.pasaportes.Add(new Pasaporte("Regina ", "Valdivia", 1161566, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Femenino, 123956));
            Harcodeo.pasaportes.Add(new Pasaporte("Natalia", "Llamas", 1161566, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Femenino, 123956));
            Harcodeo.pasaportes.Add(new Pasaporte("Tomas", "Suller", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Ferran", "Soria", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Francisco", "Lopez", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));

            Harcodeo.pasaportes.Add(new Pasaporte("Rafaela", "Guevara", 1161566, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Femenino, 123956));
            Harcodeo.pasaportes.Add(new Pasaporte("Karim", "Benzema", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("James", "Rodriguez", 12135465, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Masculino, 123456));
            Harcodeo.pasaportes.Add(new Pasaporte("Maria", "Quero", 1161566, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Femenino, 123956));
            Harcodeo.pasaportes.Add(new Pasaporte("Juana", "Salvador", 1161566, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Femenino, 123956));
            Harcodeo.pasaportes.Add(new Pasaporte("Teresa", "Guevara", 1161566, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Femenino, 123956));
            Harcodeo.pasaportes.Add(new Pasaporte("Antonia", "Gilabert", 1161566, Aleatorio.FechaNacimiento(), "ARGENTINA", ESexo.Femenino, 123956));
        }

        private static void Equipaje()
        {
            Harcodeo.equipajes.Add(new Equipaje(true,40.2f,2));
            Harcodeo.equipajes.Add(new Equipaje(false, 35.5f, 2));
            Harcodeo.equipajes.Add(new Equipaje(true, 18.7f, 1));
            Harcodeo.equipajes.Add(new Equipaje(false, 20.4f, 1));
        }

        private static void Pasajeros()
        {
            int indexAzar;
            int claseAzar;
            int catidadPasaportes = Harcodeo.pasaportes.Count();
            int divisionPasajeros = catidadPasaportes / 3;

            for (int  i = 0;  i < catidadPasaportes;  i++)
            {
                indexAzar = Aleatorio.Azar(0, Harcodeo.equipajes.Count());
                claseAzar = Aleatorio.Azar(0,2);

                if (i < divisionPasajeros)
                {
                    Harcodeo.pasajeros1.Add(new Pasajero(Harcodeo.pasaportes[i],Harcodeo.equipajes[indexAzar],(EtipoClase)claseAzar));
                }
                else if(i >= divisionPasajeros && i < divisionPasajeros*2)
                {
                    Harcodeo.pasajeros2.Add(new Pasajero(Harcodeo.pasaportes[i], Harcodeo.equipajes[indexAzar],(EtipoClase)claseAzar));
                }
                else
                {
                    Harcodeo.pasajeros3.Add(new Pasajero(Harcodeo.pasaportes[i], Harcodeo.equipajes[indexAzar],(EtipoClase)claseAzar));
                }
            }
        }

        #endregion

        #region Harcodeo Viajes

        private static void Viajes()
        {
            DateTime fechaRegional;
            DateTime fechaExtra;
            int indexCrucero, indexCruceroExtra,destinoRegion,destinoExtra,numeroAzar;
            List<Pasajero> azarPasajeros;

            for (int i = 0; i < 20; i++)
            {
                fechaRegional = Aleatorio.FechaInicio();
                fechaExtra = Aleatorio.FechaInicio();
                indexCrucero = Aleatorio.Azar(0,7);
                indexCruceroExtra = Aleatorio.Azar(0, 6);
                destinoRegion = Aleatorio.Azar(0,9);
                destinoExtra = Aleatorio.Azar(0, 7);
                numeroAzar = Aleatorio.Azar(0,3);

                switch(numeroAzar)
                {
                    case 1: azarPasajeros = Harcodeo.pasajeros1; break;
                    case 2: azarPasajeros = Harcodeo.pasajeros2; break;
                    default: azarPasajeros = Harcodeo.pasajeros3; break;
                }

                //Viajes regionales
                Harcodeo.viajes.Add(new ViajeRegional((Eregional)destinoRegion, fechaRegional,Harcodeo.cruceros[indexCrucero], azarPasajeros));

                //Viajes extra regionales
                Harcodeo.viajes.Add(new ViajeExtraRegional((EextraRegional)destinoExtra, fechaExtra, Harcodeo.cruceros[indexCruceroExtra], azarPasajeros));
            }

        }

        public static List<Viaje> ListaViajes()
        {
            return Harcodeo.viajes;
        }

        #endregion

    }
}
