using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero : Pasaporte
    {
        private Equipaje equipaje;
 
        public Pasajero(string nombre, string apellido, long dni, DateTime fechaNacimiento, ENacionalidad nacion,
            ESexo sexo, int numeroPasaporte,Equipaje equipaje) :
            base(nombre, apellido, dni, fechaNacimiento,nacion,sexo,numeroPasaporte)
        {
            this.equipaje = equipaje;
        }

        public string Nacionalidad { get { return base.nacionalidad.ToString(); } }
        public string Sexo { get { return base.sexo.ToString(); } }
        public string Pasaporte { get { return base.numeroPasaporte.ToString(); } }
        public Equipaje Equipaje { get { return this.equipaje; } }


        private new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{base.ToString()}");
            sb.AppendLine($"Equipaje: {this.equipaje.Mostrar()}");
            
            return sb.ToString();

        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
