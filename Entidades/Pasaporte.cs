using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaporte : Persona
    {
        protected ENacionalidad nacionalidad;
        protected ESexo sexo;
        protected int numeroPasaporte;

        public Pasaporte(string nombre, string apellido, long dni, DateTime fechaNacimiento, ENacionalidad nacion,
            ESexo sexo, int numeroPasaporte) :
            base(nombre, apellido, dni, fechaNacimiento)
        {
            this.nacionalidad = nacion;
            this.numeroPasaporte = numeroPasaporte;
            this.sexo = sexo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Sexo: {this.sexo}");
            sb.AppendLine($"Nacionalidad: {this.nacionalidad}");
            sb.AppendLine($"Numero Pasaporte: {this.numeroPasaporte}");

            return sb.ToString();

        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
