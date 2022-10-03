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

        /*(string nombre, string apellido, long dni, DateTime fechaNacimiento, ENacionalidad nacion,
            ESexo sexo, int numeroPasaporte,Equipaje equipaje) */
        private static Pasaporte[] HarcodeoPasaportes()
        {
            DateTime fecha = new DateTime();

            Pasaporte[] pasaportes = 
            {            
                new Pasaporte("Fede","Cardozo",40812362,fecha,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Lea","Cardozo",54546645,fecha,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Marcos","Paez",112311321,fecha,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Carina","Jaure",16156161,fecha,ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Carmen","Benvidez",1161566,fecha,ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Toby","Perrito",161523213,fecha,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Evelio","Paez",23133212,fecha,ENacionalidad.Paraguaya,ESexo.Masculino,123456),
                new Pasaporte("Clarisa","Alvarez",123131654,fecha,ENacionalidad.Argentina,ESexo.Femenino,123456)
            };

            return pasaportes;
        }

        private static Pasaporte[] HarcodeoPasaportes2()
        {
            DateTime fecha = new DateTime();

            Pasaporte[] pasaportes =
            {

                new Pasaporte("Fede2","Cardozo",40812362,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Lea2","Cardozo",54546645,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Marcos2","Paez",112311321,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Carina2","Jaure",16156161,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Carmen2","Benvidez",1161566,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Toby2","Perrito",161523213,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Evelio2","Paez",23133212,fecha.Date,ENacionalidad.Paraguaya,ESexo.Masculino,123456),
                new Pasaporte("Clarisa2","Alvarez",123131654,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456)};

            return pasaportes;
        }

        private static Pasaporte[] HarcodeoPasaportes3()
        {
            DateTime fecha = new DateTime();

            Pasaporte[] pasaportes =
            {

                new Pasaporte("Fede3","Cardozo",40812362,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Lea3","Cardozo",54546645,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Marcos3","Paez",112311321,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Carina3","Jaure",16156161,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Carmen3","Benvidez",1161566,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Toby3","Perrito",161523213,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Evelio3","Paez",23133212,fecha.Date,ENacionalidad.Paraguaya,ESexo.Masculino,123456),
                new Pasaporte("Clarisa3","Alvarez",123131654,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456)};

            return pasaportes;
        }

        private static Pasajero[] HarcodeoPasajeros(Pasaporte[] pasaportes)
        {
            Random random = new Random();
            int numeroRandom;
            float kg;
            bool[] flag = {true,false};
            Pasajero[] pasajeros = new Pasajero[pasaportes.Length];

            for (int i = 0; i < pasaportes.Length; i++)
            {
                numeroRandom = random.Next(1,2);
                kg = random.Next(2,25);

                if(numeroRandom == 2)
                {
                    kg = random.Next(20,50);
                }

                pasajeros[i] = new Pasajero(pasaportes[i],new Equipaje(flag[numeroRandom],kg,numeroRandom));
            }

            return pasajeros;

        }

        private static void HarcodeoPasajeros(Pasajero[] pasajeros, Viaje viaje)
        {

            for (int i = 0; i < pasajeros.Length; i++)
            {
                viaje.AgregarPasajero(pasajeros[i]);
            }

        }

        private static void HarcodeoPasajeros(Viaje viaje, int tipoHarcodeo)
        {

            switch (tipoHarcodeo)
            {
                case 1: HarcodeoPasajeros(Harcodeo.HarcodeoPasajeros(Harcodeo.HarcodeoPasaportes()), viaje); break;
                case 2: HarcodeoPasajeros(Harcodeo.HarcodeoPasajeros(Harcodeo.HarcodeoPasaportes2()), viaje); break;
                default: HarcodeoPasajeros(Harcodeo.HarcodeoPasajeros(Harcodeo.HarcodeoPasaportes3()), viaje); break;

            }

        }

        private static Crucero[] HarcodeoCrucero()
        {
            Crucero[] crucero = { new Crucero("EWK264", "Titanic", 15, 10, 1, 10000, true, true),
            new Crucero("EWK265", "Corsa", 10, 5, 2, 10000, true, true),
            new Crucero("EWK266", "Vento", 12, 3, 1, 10000, true, false),
            new Crucero("EWK267", "Sirroco", 4, 4, 2, 10000, true, true),
            new Crucero("EWK268", "Amarok", 10, 10, 1, 10000, false, true),
            new Crucero("EWK269", "Lamborghini", 11, 7, 3, 10000, true, true),
            new Crucero("EWK270", "Ferrari", 10, 5, 1, 10000, true, false)};

            return crucero;
        }

        private static Viaje[] HarcodeoViaje()
        {
            DateTime fecha = new DateTime();     

            Viaje[] viajesito = { new Viaje(fecha.Date, (Harcodeo.HarcodeoCrucero())[6], 10, 10),
                new Viaje(fecha.Date, (Harcodeo.HarcodeoCrucero())[0], 10, 10),
                new Viaje(fecha.Date, (Harcodeo.HarcodeoCrucero())[1], 10, 10),
                new Viaje(fecha.Date, (Harcodeo.HarcodeoCrucero())[2], 10, 10),
                new Viaje(fecha.Date, (Harcodeo.HarcodeoCrucero())[3], 10, 10),
                new Viaje(fecha.Date, (Harcodeo.HarcodeoCrucero())[4], 10, 10),
                new Viaje(fecha.Date, (Harcodeo.HarcodeoCrucero())[5], 10, 10),
            };

            Harcodeo.HarcodeoPasajeros(viajesito[0],1);
            Harcodeo.HarcodeoPasajeros(viajesito[1],2);
            Harcodeo.HarcodeoPasajeros(viajesito[2],3);
            Harcodeo.HarcodeoPasajeros(viajesito[3],1);
            Harcodeo.HarcodeoPasajeros(viajesito[4],3);
            Harcodeo.HarcodeoPasajeros(viajesito[5],3);
            Harcodeo.HarcodeoPasajeros(viajesito[6],2);

            return viajesito;
        }

        private static void HarcodeoViajesHistorial(HistorialViajes historialViaje, Viaje[] viajes)
        {
            for (int i = 0; i < viajes.Length; i++)
            {
                historialViaje.AgregarViaje(viajes[i]);
            }
        }

        public static void HarcodeoProgram(HistorialViajes historialViaje)
        {
            Viaje[] viajes = Harcodeo.HarcodeoViaje();

            Harcodeo.HarcodeoViajesHistorial(historialViaje, viajes);
            
        }
    }
}
