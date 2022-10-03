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
        public static Pasajero[] HarcodeoPasajeros()
        {
            DateTime fecha = new DateTime();

            Pasajero[] passangers = 
            {
                new Pasajero("Fede","Cardozo",40812362,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Lea","Cardozo",54546645,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(false,25f,1)),
                new Pasajero("Marcos","Paez",112311321,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Carina","Jaure",16156161,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456,new Equipaje(true,35f,2)),
                new Pasajero("Carmen","Benvidez",1161566,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Toby","Perrito",161523213,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(false,15f,2)),
                new Pasajero("Evelio","Paez",23133212,fecha.Date,ENacionalidad.Paraguaya,ESexo.Masculino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Clarisa","Alvarez",123131654,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456,new Equipaje(true,15f,2))};

            return passangers;
        }

        public static Pasajero[] HarcodeoPasajeros2()
        {
            DateTime fecha = new DateTime();

            Pasajero[] passangers =
            {
                new Pasajero("Fede2","Cardozo",40812362,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Lea2","Cardozo",54546645,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(false,25f,1)),
                new Pasajero("Marcos2","Paez",112311321,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Carina2","Jaure",16156161,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456,new Equipaje(true,35f,2)),
                new Pasajero("Carmen2","Benvidez",1161566,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Toby2","Perrito",161523213,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(false,15f,2)),
                new Pasajero("Evelio2","Paez",23133212,fecha.Date,ENacionalidad.Paraguaya,ESexo.Masculino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Clarisa2","Alvarez",123131654,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456,new Equipaje(true,15f,2))};

            return passangers;
        }

        public static Pasajero[] HarcodeoPasajeros3()
        {
            DateTime fecha = new DateTime();

            Pasajero[] passangers =
            {
                new Pasajero("Fede3","Cardozo",40812362,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Lea3","Cardozo",54546645,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(false,25f,1)),
                new Pasajero("Marcos3","Paez",112311321,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Carina3","Jaure",16156161,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456,new Equipaje(true,35f,2)),
                new Pasajero("Carmen3","Benvidez",1161566,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Toby3","Perrito",161523213,fecha.Date,ENacionalidad.Argentina,ESexo.Masculino,123456,new Equipaje(false,15f,2)),
                new Pasajero("Evelio3","Paez",23133212,fecha.Date,ENacionalidad.Paraguaya,ESexo.Masculino,123456,new Equipaje(true,15f,1)),
                new Pasajero("Clarisa3","Alvarez",123131654,fecha.Date,ENacionalidad.Argentina,ESexo.Femenino,123456,new Equipaje(true,15f,2))};

            return passangers;
        }

        public static Crucero[] HarcodeoCrucero()
        {
            Crucero[] crucero = { new Crucero("EWK264", "Corsel", 10, 10, 1, 10000, true, true),
            new Crucero("EWK265", "Corsel2", 10, 10, 2, 10000, true, true),
            new Crucero("EWK266", "Corsel3", 10, 10, 1, 10000, true, false),
            new Crucero("EWK267", "Corsel4", 10, 10, 2, 10000, true, true),
            new Crucero("EWK268", "Corsel5", 10, 10, 1, 10000, false, true),
            new Crucero("EWK269", "Corsel6", 10, 10, 3, 10000, true, true),
            new Crucero("EWK270", "Corsel7", 10, 10, 1, 10000, true, false)};

            return crucero;
        }

        public static Viaje[] HarcodeoViaje()
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

            Viaje.HarcodeoPasajeros(viajesito[0],1);
            Viaje.HarcodeoPasajeros(viajesito[1],2);
            Viaje.HarcodeoPasajeros(viajesito[2],3);
            Viaje.HarcodeoPasajeros(Harcodeo.HarcodeoPasajeros(), viajesito[3]);
            Viaje.HarcodeoPasajeros(Harcodeo.HarcodeoPasajeros(), viajesito[4]);
            Viaje.HarcodeoPasajeros(Harcodeo.HarcodeoPasajeros(), viajesito[5]);
            Viaje.HarcodeoPasajeros(Harcodeo.HarcodeoPasajeros(), viajesito[6]);

            return viajesito;
        }

    }
}
