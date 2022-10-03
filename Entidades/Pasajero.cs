using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero
    {
        private Equipaje equipaje;
        private Pasaporte pasaporte;
 
        public Pasajero (Pasaporte pasaporte, Equipaje equipaje)
        {
            this.equipaje = equipaje;
            this.pasaporte = pasaporte;
        }

        public Pasaporte Pasaporte{ get { return this.pasaporte; } }
        public Equipaje Equipaje { get { return this.equipaje; } }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.pasaporte.ToString()}");
            sb.AppendLine($"Equipaje: {this.equipaje.Mostrar()}");
            
            return sb.ToString();

        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
