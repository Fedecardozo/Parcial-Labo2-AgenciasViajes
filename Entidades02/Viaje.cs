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
        protected List<Pasajero> listPasajeros;
        private DateTime fechaInicioViaje;
        private DateTime fechaDeLlegada;
        private Crucero crucero;
        private EestadoViaje estadoViaje;
        private int id;
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

        public Viaje(DateTime fechaInicioViaje, Crucero crucero, DateTime fechaDeLlegada) : this()
        {

            this.fechaInicioViaje = fechaInicioViaje;
            this.fechaDeLlegada = fechaDeLlegada;
            this.crucero = crucero;
            this.estadoViaje = this.EstadoViaje;

        }

        #endregion

        #region Propiedades

        public int CantidadTurista { get { return this.ContarClaseTurista(); } }
        public int CantidadPremium { get { return this.ContarClasePremium(); } }
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
                //15/09/2022 - 19-10-2022
                if (this.fechaInicioViaje <= DateTime.Now && this.fechaDeLlegada <= DateTime.Now)
                {
                    this.estadoViaje = EestadoViaje.Terminado;
                }
                else if(this.fechaInicioViaje <= DateTime.Now && this.fechaDeLlegada >= DateTime.Now)
                {
                    this.estadoViaje = EestadoViaje.En_Viaje;
                }
                else
                {
                    this.estadoViaje = EestadoViaje.Disponible;
                }

                return this.estadoViaje;
            }

        }

        #endregion

        #region Metodos
        private int ContarClasePremium()
        {
            int cantidadClasePremium = 0;

            foreach (Pasajero passanger in this.listPasajeros)
            {
                if (passanger.TipoClase == EtipoClase.Premium)
                {
                    cantidadClasePremium++;
                }
            }

            return cantidadClasePremium;
        }
        private int ContarClaseTurista()
        {
            int cantidadClaseTurista = 0;

            foreach (Pasajero passanger in this.listPasajeros)
            {
                if (passanger.TipoClase == EtipoClase.Turistica)
                {
                    cantidadClaseTurista++;
                }
            }

            return cantidadClaseTurista;

        }

        public void AgregarPasajero(Pasajero passanger)
        {
            
            if (passanger is not null )//&& this.crucero.LugaresDisponibles > 0)
            {
                this.listPasajeros.Add(passanger);
            }

        }
        
        #endregion

        #region Sobrecarga operadores
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
            sb.AppendLine($"Clase turista: {this.CantidadTurista} ");
            sb.AppendLine($"Cantidad Premium: {this.CantidadPremium}");
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
