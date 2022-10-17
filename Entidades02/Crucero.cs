using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Crucero
    {
        #region Atributos

        private string matricula;
        private string nombre;
        private int cantidadCamarotes;
        private int cantidadSalones;
        private int cantidadCasino;
        private double capacidadBodega;
        private bool piscina;
        private bool gimnasio;
        private EestadoViaje estadoViaje;
        //private Viaje viaje;

        #endregion

        #region Constructores
        public Crucero(string matricula, string nombre, int cantidadCamarotes,
            int cantidadSalones, int cantidadCasino, float capacidadBodega, bool piscina, bool gimnasio)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.cantidadCamarotes = cantidadCamarotes;
            this.cantidadSalones = cantidadSalones;
            this.cantidadCasino = cantidadCasino;
            this.capacidadBodega = capacidadBodega;
            this.piscina = piscina;
            this.gimnasio = gimnasio;
        }

        public Crucero(string matricula, string nombre, int cantidadCamarotes,
            int cantidadSalones, int cantidadCasino, float capacidadBodega, bool piscina, bool gimnasio, EestadoViaje estadoViaje)
            : this(matricula, nombre, cantidadCamarotes,
             cantidadSalones, cantidadCasino, capacidadBodega, piscina, gimnasio)
        {
            //this.viaje = viaje;
            this.estadoViaje = estadoViaje;
        }

        #endregion

        #region Propiedades
        public string Gimnsaio
        {
            get
            {
                string retorno = "no";

                if (this.gimnasio)
                    retorno = "si";

                return retorno;
            }

        }

        public string Piscina
        {
            get
            {
                string retorno = "no";

                if (this.piscina)
                    retorno = "si";

                return retorno;
            }

        }

        public string Nombre { get { return this.nombre; } }

        public string Matricula { get { return this.matricula; } }

        public EestadoViaje EstadoViaje
        {
            get
            {
                return this.estadoViaje;
            }

            set
            {
                this.estadoViaje = value;
            }
        }

        private int CapacidadMaximaPasajeros { get { return this.cantidadCamarotes * 4; } }

        #endregion

        #region Sobrecarga operadores
        public static bool operator ==(Crucero c1, Crucero c2)
        {
            return c1.matricula == c2.matricula;
        }

        public static bool operator !=(Crucero c1, Crucero c2)
        {
            return !(c1 == c2);
        }

        #endregion

        #region Metodos

        #endregion

        #region Sobreescritura
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is not null && obj is Crucero)
            {
                retorno = ((Crucero)obj) == this;
            }

            return retorno;
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre} - Camarotes: {this.cantidadCamarotes} - Casinos: {this.cantidadCasino}" +
                $" - Estado de viaje: {this.estadoViaje}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
