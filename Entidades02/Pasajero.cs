using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero
    {
        #region Atributos
        private Equipaje equipaje;
        private Pasaporte pasaporte;
        #endregion

        #region Constructor
        public Pasajero(Pasaporte pasaporte, Equipaje equipaje)
        {
            this.equipaje = equipaje;
            this.pasaporte = pasaporte;
        }
        #endregion

        #region Propiedades

        public Pasaporte Pasaporte { get { return this.pasaporte; } }
        public Equipaje Equipaje { get { return this.equipaje; } }

        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.pasaporte.ToString()}");
            sb.AppendLine($"Equipaje: {this.equipaje.ToString()}");

            return sb.ToString();
        }
        #endregion
    }
}
