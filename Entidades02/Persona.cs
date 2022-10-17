using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
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
            this.nombre = nombre;
            this.apellido = apellido;
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

        public override string ToString()
        {
            return $"\nNombre: {this.nombre} \nApellido: {this.apellido} \nDNI: {this.dni}" +
                $" \nFecha Nacimiento: {this.fechaNacimiento.Date.ToString("d")}";
        }

        #region Propiedades

        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public long Dni { get { return this.dni; } }
        public DateTime FechaNacimientoDate { get { return this.fechaNacimiento.Date; } }
        public string FechaNacimiento { get { return this.FechaNacimientoDate.ToString("d"); } }

        #endregion
    }
}
