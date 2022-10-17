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
        private EtipoClase clase;
        #endregion

        #region Constructor
        public Pasajero(Pasaporte pasaporte, Equipaje equipaje, EtipoClase clase)
        {
            this.equipaje = equipaje;
            this.pasaporte = pasaporte;
            this.clase = clase;
        }
        #endregion

        #region Propiedades

        public Pasaporte Pasaporte { get { return this.pasaporte; } }
        public Equipaje Equipaje { get { return this.equipaje; } }
        public EtipoClase TipoClase { get { return this.clase; } }

        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.pasaporte.ToString()}");
            sb.AppendLine($"Equipaje: {this.equipaje.ToString()}");
            sb.AppendLine($"Tipo de clase: {this.clase}");

            return sb.ToString();
        }
        #endregion
    }
}
