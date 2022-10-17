using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Viaje
    {
        #region Atributos estaticos
        private static int costoPremium;
        private static int costoTurista;
        private static int contadorId;
        #endregion

        #region Atributos
        private string ciudadPartida;
        List<Pasajero> listPasajeros;
        private DateTime fechaInicioViaje;
        private DateTime fechaDeLlegada;
        private Crucero crucero;
        private int cantidClasePremium;
        private int cantidadClaseTurista;
        private int id;
        private EestadoViaje estadoViaje;
        #endregion

        #region Constructores

        static Viaje()
        {
            Viaje.contadorId = 1000;
            Viaje.costoTurista = 57;
            Viaje.costoPremium = 120;
        }

        private Viaje()
        {
            this.listPasajeros = new List<Pasajero>();
            this.ciudadPartida = "Buenos Aires";
            this.estadoViaje = EestadoViaje.Disponible;
            this.id = Viaje.contadorId;
            Viaje.contadorId++;
        }

        public Viaje(DateTime fechaInicioViaje, Crucero crucero, int cantidClasePremium,
            int cantidadClaseTurista, DateTime fechaDeLlegada) : this()
        {

            this.fechaInicioViaje = fechaInicioViaje;
            this.fechaDeLlegada = fechaDeLlegada;
            this.crucero = crucero;
            this.cantidClasePremium = cantidClasePremium;
            this.cantidadClaseTurista = cantidadClaseTurista;
            this.estadoViaje = this.EstadoViaje;

        }

        public Viaje(DateTime fechaInicioViaje, Crucero crucero, int cantidClasePremium,
            int cantidadClaseTurista, DateTime fechaDeLlegada,List<Pasajero> listpasajeros) 
            : this(fechaInicioViaje, crucero, cantidClasePremium, cantidadClaseTurista, fechaDeLlegada)
        {
            this.listPasajeros = listpasajeros;
        }

        #endregion

        #region Propiedades

        public int CantidadTurista { get { return this.cantidadClaseTurista; } }
        public int CantidadPremium { get { return this.cantidClasePremium; } }
        public DateTime FechaLlegada { get { return this.fechaDeLlegada.Date; } }
        public DateTime FechaInicioViajeDate { get { return this.fechaInicioViaje.Date; } }
        public string FechaInicioViaje { get { return this.FechaInicioViajeDate.ToString("d"); } }
        public Crucero Crucero { get { return this.crucero; } }
        public string CiudadPartida { get { return this.ciudadPartida; } }
        public List<Pasajero> Pasajeros { get { return this.listPasajeros; } }
        public virtual string TipoDestino { get { return ""; } }
        public string DuracionViaje 
        { 
            get 
            {              
                double duracion = (this.fechaDeLlegada - this.fechaInicioViaje).TotalHours;
                //return $"Inicio:{this.fechaInicioViaje} \nFin:{this.fechaDeLlegada} \nDuracion:{duracion}"; 
                return $"{duracion}";
            } 
        }
        public int Id { get { return this.id; } }

        public EestadoViaje EstadoViaje
        {
            get
            {
                if (this.fechaDeLlegada >= DateTime.Now)
                {
                    this.estadoViaje = EestadoViaje.En_Viaje;
                }

                return this.estadoViaje;
            }

        }

        #endregion

        #region Sobrecarga operadores
        /*public void AgregarPasajero(Pasajero passanger)
        {
            if (passanger is not null && this.crucero.LugaresDisponibles > 0)
            {
                this.listPasajeros.Add(passanger);
            }

        }*/

        public static bool operator ==(Viaje v1, Viaje v2)
        {
            return v1.id == v2.id;
        }

        public static bool operator !=(Viaje v1, Viaje v2)
        {
            return !(v1 == v2);
        }
        public static bool operator ==(Viaje v1, int id)
        {
            return v1.id == id;
        }

        public static bool operator !=(Viaje v1, int id)
        {
            return !(v1 == id);
        }
        #endregion

        #region Sobreescritura 
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Ciudad de partida: {this.ciudadPartida}");
            sb.AppendLine($"Fecha inicio de viaje: {this.fechaInicioViaje}");
            sb.AppendLine($"Fecha llegada de viaje: {this.fechaDeLlegada}");
            sb.AppendLine($"Clase turista: {this.cantidadClaseTurista} ");
            sb.AppendLine($"Cantidad Premium: {this.cantidClasePremium} ");
            sb.AppendLine($"Estado de viaje {this.estadoViaje}");
            sb.AppendLine($"Nombre Crucero: {this.crucero.Nombre} ");
            sb.AppendLine($"Matricula Crucero: {this.crucero.Matricula} ");
            sb.AppendLine($"Duracion viaje: {this.DuracionViaje}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj != null && obj is Viaje)
            {
                retorno = (Viaje)obj == this;
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    }
}
