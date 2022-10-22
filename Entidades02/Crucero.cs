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
       // private List<Viaje> viajesRealizados;
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

        /*public Crucero(string matricula, string nombre, int cantidadCamarotes,
            int cantidadSalones, int cantidadCasino, float capacidadBodega, bool piscina, bool gimnasio)
            : this(matricula, nombre, cantidadCamarotes,
             cantidadSalones, cantidadCasino, capacidadBodega, piscina, gimnasio)
        {
            //this.viaje = viaje;
            //this.estadoViaje = estadoViaje;
        }*/

        #endregion

        #region Propiedades

        public double CapacidadBodega { get { return this.capacidadBodega; } }

        public int CantidadCasinos { get { return this.cantidadCasino; } }

        public int CantidadCamarotes { get { return this.cantidadCamarotes; } }

        public int CantidadSalones { get { return this.cantidadSalones; } }

        public DateTime FechaDisponible { get { return this.CalcularFechaDisponible(); } }
        
        public List<Viaje> ViajesRealizados { get { return HistorialViajes.ViajesRealizadosPorDeterminadoCrucero(this); } }
        
        public string Gimnsaio
        {
            get
            {
                string retorno = "No";

                if (this.gimnasio)
                    retorno = "Si";

                return retorno;
            }

        }

        public string Piscina
        {
            get
            {
                string retorno = "No";

                if (this.piscina)
                    retorno = "Si";

                return retorno;
            }

        }

        public string Nombre { get { return this.nombre; } }

        public string Matricula { get { return this.matricula; } }

        /*public EestadoViaje EstadoViaje
        {
            get
            {
                return this.estadoViaje;
            }

            set
            {
                this.estadoViaje = value;
            }
        }*/

        private int CapacidadMaximaPasajeros { get { return this.cantidadCamarotes * 4; } }

        #endregion

        #region Sobrecarga operadores
        public static bool operator ==(Crucero c1, Crucero c2)
        {
            return c1 == c2.matricula;
        }

        public static bool operator !=(Crucero c1, Crucero c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Crucero c1, string matricula)
        {
            return c1.matricula == matricula;
        }

        public static bool operator !=(Crucero c1, string matricula)
        {
            return !(c1 == matricula);
        }
        #endregion

        #region Metodos
        private DateTime CalcularFechaDisponible()
        {
            DateTime fechaLlegadaMayor = DateTime.Now.AddDays(1);
            DateTime fechaLlegada;
            int contador = 0;

            foreach (Viaje item in this.ViajesRealizados)
            {
                if (item.EstadoViaje == EestadoViaje.Disponible)
                {
                    fechaLlegada = item.FechaLlegada;

                    if (contador == 0)
                    {
                        fechaLlegadaMayor = fechaLlegada;
                    }
                    else if (contador > 0 && fechaLlegada > fechaLlegadaMayor)
                    {
                        fechaLlegadaMayor = fechaLlegada;
                    }
                    contador++;
                }
            }
            return fechaLlegadaMayor;
        }
       
        public static Crucero ObtenerCrucero(string matricula)
        {
            Crucero crucero = null;
            foreach (Crucero item in Harcodeo.ListaCruceros())
            {
                if(item == matricula)
                {
                    crucero = item;
                    break;
                }
            }
            return crucero;
        }

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
            return $"Nombre: {this.nombre} - Camarotes: {this.cantidadCamarotes} - Casinos: {this.cantidadCasino}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
