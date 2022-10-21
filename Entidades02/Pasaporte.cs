using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaporte : Persona
    {
        #region Atributos
        private string nacionalidad;
        private ESexo sexo;
        private int numeroPasaporte;
        #endregion

        #region Constructor
        public Pasaporte(string nombre, string apellido, long dni, DateTime fechaNacimiento, string nacion,
            ESexo sexo, int numeroPasaporte) : base(nombre, apellido, dni, fechaNacimiento)
        {
            this.nacionalidad = nacion;
            this.numeroPasaporte = numeroPasaporte;
            this.sexo = sexo;
        }
        #endregion

        #region Propiedades
        public string Nacionalidad { get { return this.nacionalidad; } }
        public string Sexo { get { return this.sexo.ToString(); } }
        public int NumeroPasaporte { get { return this.numeroPasaporte; } }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Sexo: {this.sexo}");
            sb.AppendLine($"Nacionalidad: {this.nacionalidad}");
            sb.AppendLine($"Numero Pasaporte: {this.numeroPasaporte}");

            return sb.ToString();
        }
        #endregion
    }
}
