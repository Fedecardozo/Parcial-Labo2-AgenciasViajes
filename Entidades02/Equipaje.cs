using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipaje
    {
        #region Atributos
        private int cantidadValijas;
        private float totalKg;
        private bool bolsoMano;
        #endregion

        #region Constructores
        public Equipaje()
        {
            this.bolsoMano = false;
            this.cantidadValijas = 0;
            this.totalKg = 0;
        }

        public Equipaje(bool bolsoMano) : this()
        {
            this.bolsoMano = bolsoMano;
        }

        public Equipaje(bool bolsoMano, float totalKg, int cantidadValijas) : this(bolsoMano)
        {
            this.cantidadValijas = cantidadValijas;
            this.totalKg = totalKg;
        }
        #endregion

        #region Propiedades
        public int Valijas
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    this.cantidadValijas = value;
                }
            }
            get
            {
                return this.cantidadValijas;
            }
        }

        public float Kilosgramos
        {
            set
            {
                if (this.cantidadValijas == 2 && value >= 0 && value <= 50)
                {
                    this.totalKg = value;
                }
                else if (this.cantidadValijas == 1 && value >= 0 && value <= 25)
                {
                    this.totalKg = value;
                }

            }
            get
            {
                return this.totalKg;
            }
        }

        public string BolsoMano
        {
            get
            {
                if (this.bolsoMano)
                    return "Si";
                else
                    return "No";

            }

        }

        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad valijas: {this.Valijas}");
            sb.AppendLine($"Total Kg: {this.Kilosgramos}");
            sb.AppendLine($"Bolso de mano: {this.BolsoMano}");

            return sb.ToString();
        }
        #endregion
    }
}
