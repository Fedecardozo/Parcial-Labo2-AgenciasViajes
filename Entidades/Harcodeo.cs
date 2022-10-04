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

        private static DateTime GeneradorFecha()
        {
            DateTime start = new DateTime(1950, 1, 1,0,0,0);
            DateTime fin = new DateTime(2003, 1, 1,0,0,0);

            Random gen = new Random(); 

            int range = (fin - start).Days; 
           
            return start.AddDays(gen.Next(range));
                    
        }

        private static DateTime GeneradorFecha(DateTime start, DateTime fin)
        {

            Random gen = new Random();

            int range = (fin - start).Days;

            return start.AddDays(gen.Next(range));

        }

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

        private static Pasaporte[] HarcodeoPasaportes()
        {

            Pasaporte[] pasaportes = 
            {            
                new Pasaporte("Fede","Cardozo",40812362,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Lea","Cardozo",54546645,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Marcos","Paez",112311321,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Carina","Jaure",16156161,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Carmen","Benvidez",1161566,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Toby","Perrito",161523213,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Evelio","Paez",23133212,Harcodeo.GeneradorFecha(),ENacionalidad.Paraguaya,ESexo.Masculino,123456),
                new Pasaporte("Clarisa","Alvarez",123131654,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Femenino,123456)
            };

            return pasaportes;
        }

        private static Pasaporte[] HarcodeoPasaportes2()
        {

            Pasaporte[] pasaportes =
            {

                new Pasaporte("Fede2","Cardozo",40812362,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Lea2","Cardozo",54546645,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Marcos2","Paez",112311321,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Carina2","Jaure",16156161,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Carmen2","Benvidez",1161566,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Toby2","Perrito",161523213,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Evelio2","Paez",23133212,Harcodeo.GeneradorFecha(),ENacionalidad.Paraguaya,ESexo.Masculino,123456),
                new Pasaporte("Clarisa2","Alvarez",123131654,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Femenino,123456)};

            return pasaportes;
        }

        private static Pasaporte[] HarcodeoPasaportes3()
        {

            Pasaporte[] pasaportes =
            {

                new Pasaporte("Fede3","Cardozo",40812362,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Lea3","Cardozo",54546645,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Marcos3","Paez",112311321,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Carina3","Jaure",16156161,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Carmen3","Benvidez",1161566,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Femenino,123456),
                new Pasaporte("Toby3","Perrito",161523213,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Masculino,123456),
                new Pasaporte("Evelio3","Paez",23133212,Harcodeo.GeneradorFecha(),ENacionalidad.Paraguaya,ESexo.Masculino,123456),
                new Pasaporte("Clarisa3","Alvarez",123131654,Harcodeo.GeneradorFecha(),ENacionalidad.Argentina,ESexo.Femenino,123456)};

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
            Crucero[] crucero = { new Crucero("AAE264WK", "Titanic", 15, 10, 1, 10000, true, true),
            new Crucero("BBE265WK", "Corsa", 10, 5, 2, 10000, true, true),
            new Crucero("CCE266WK", "Vento", 12, 3, 1, 10000, true, false),
            new Crucero("DDE267WK", "Sirroco", 4, 4, 2, 10000, true, true),
            new Crucero("EEE268WK", "Amarok", 10, 10, 1, 10000, false, true),
            new Crucero("FFE269WK", "Lamborghini", 11, 7, 3, 10000, true, true),
            new Crucero("GGE270WK", "Ferrari", 10, 5, 1, 10000, true, false)};

            return crucero;
        }

        private static ViajeExtraRegional[] ViajeExtraRegional()
        {
            ViajeExtraRegional[] viajesito =
            {
                new ViajeExtraRegional(EextraRegional.Atenas,Harcodeo.GeneradorFecha(new DateTime(2022, 1, 1), DateTime.Today), (Harcodeo.HarcodeoCrucero())[6], 10, 10, Harcodeo.GeneradorFecha(DateTime.Today, new DateTime(2022, 10, 10))),
                new ViajeExtraRegional(EextraRegional.Bangkok,Harcodeo.GeneradorFecha(new DateTime(2022, 1, 1), DateTime.Today), (Harcodeo.HarcodeoCrucero())[4], 10, 10, Harcodeo.GeneradorFecha(new DateTime(2022, 1, 2), DateTime.Today)),
                new ViajeExtraRegional(EextraRegional.Miami,Harcodeo.GeneradorFecha(new DateTime(2022, 1, 1), DateTime.Today), (Harcodeo.HarcodeoCrucero())[5], 10, 10, Harcodeo.GeneradorFecha(DateTime.Today, new DateTime(2022, 10, 10))),
            };

            Harcodeo.HarcodeoPasajeros(viajesito[0], 3);
            Harcodeo.HarcodeoPasajeros(viajesito[1], 3);
            Harcodeo.HarcodeoPasajeros(viajesito[2], 2);

            return viajesito;

        }

        private static ViajeRegional[] HarcodeoViaje()
        {
            
            ViajeRegional[] viajesito = 
            { 
                new ViajeRegional(Eregional.Rio_de_Janeiro,Harcodeo.GeneradorFecha(new DateTime(2022,1,1),DateTime.Today), (Harcodeo.HarcodeoCrucero())[0], 10, 10,Harcodeo.GeneradorFecha(DateTime.Today,new DateTime(2022,10,10))),
                new ViajeRegional(Eregional.Puerto_Madryn,Harcodeo.GeneradorFecha(new DateTime(2022,1,1),DateTime.Today), (Harcodeo.HarcodeoCrucero())[1], 10, 10,Harcodeo.GeneradorFecha(new DateTime(2022,1,2),DateTime.Today)),
                new ViajeRegional(Eregional.Lima,Harcodeo.GeneradorFecha(new DateTime(2022,1,1),DateTime.Today), (Harcodeo.HarcodeoCrucero())[2], 10, 10,Harcodeo.GeneradorFecha(new DateTime(2022,1,2),DateTime.Today)),
                new ViajeRegional(Eregional.Cartagena,Harcodeo.GeneradorFecha(new DateTime(2022,1,1),DateTime.Today), (Harcodeo.HarcodeoCrucero())[3], 10, 10,Harcodeo.GeneradorFecha(DateTime.Today,new DateTime(2022,10,10))),
                
            };

            Harcodeo.HarcodeoPasajeros(viajesito[0],1);
            Harcodeo.HarcodeoPasajeros(viajesito[1],2);
            Harcodeo.HarcodeoPasajeros(viajesito[2],3);
            Harcodeo.HarcodeoPasajeros(viajesito[3],1);
            

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
            Viaje[] viajesEx = Harcodeo.ViajeExtraRegional();

            Harcodeo.HarcodeoViajesHistorial(historialViaje, viajes);
            Harcodeo.HarcodeoViajesHistorial(historialViaje, viajesEx);

        }
    }
}
