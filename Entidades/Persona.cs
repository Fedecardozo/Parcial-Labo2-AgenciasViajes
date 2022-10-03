﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected long dni;
        protected DateTime fechaNacimiento;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, long dni) : this(nombre, apellido)
        {
            this.dni = dni;
        }

        public Persona(string nombre, string apellido, long dni, DateTime fechaNacimiento) : this(nombre, apellido, dni)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        protected virtual string Mostrar()
        {
            return $"\nNombre: {this.nombre} \nApellido: {this.apellido} \nDNI: {this.dni}" +
                $" \nFecha Nacimiento: {this.fechaNacimiento.Date}";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public string Nombre{ get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public long Dni { get { return this.dni; } }
        public DateTime FechaNacimiento { get { return this.fechaNacimiento.Date; } }

    }
}
