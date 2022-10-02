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
    }
}
