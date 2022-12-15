using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  abstract class Persona
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        protected long dni;
        protected DateTime fechaNacimiento;
        #endregion

        #region Constructores
        protected Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        protected Persona(string nombre, string apellido, long dni) : this(nombre, apellido)
        {
            this.dni = dni;
        }

        protected Persona(string nombre, string apellido, long dni, DateTime fechaNacimiento) : this(nombre, apellido, dni)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        #endregion

        #region Propiedades

        public string Nombre { get { return this.nombre; } set { this.nombre = Persona.ConvertirMayusculaMinuscula(value); } }
        public string Apellido { get { return this.apellido; } set { this.apellido = Persona.ConvertirMayusculaMinuscula(value);  } }
        public long Dni { get { return this.dni; } }
        public DateTime FechaNacimientoDate { get { return this.fechaNacimiento.Date; } }
        public string FechaNacimiento { get { return this.FechaNacimientoDate.ToString("d"); } }
        public int Edad { get { return DateTime.Today.AddTicks(-this.fechaNacimiento.Ticks).Year - 1; ; } }

        #endregion

        #region Metodos

        /// <summary>
        /// Convierte la pimera letra en Mayuscula y el ressto en Minuscula
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static string ConvertirMayusculaMinuscula(string cadena)
        {
            return cadena.Substring(0, 1).ToUpper() + cadena.Substring(1).ToLower();
        }

        #endregion

        #region Sobreescritura
        public override string ToString()
        {
            return $"\nNombre: {this.nombre} \nApellido: {this.apellido} \nDNI: {this.dni}" +
                $" \nFecha Nacimiento: {this.fechaNacimiento.Date.ToString("d")}";
        }

        #endregion
    }
}
