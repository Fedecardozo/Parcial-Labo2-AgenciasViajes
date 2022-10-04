using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Viaje
    {
        #region Constantes
        private const int costoPremium = 120;
        private const int costoTurista = 57;
        #endregion

        #region Atributos
        List<Pasajero> listPasajeros;
        private string ciudadPartida;
        private DateTime fechaInicioViaje;
        private DateTime fechaDeLlegada;
        private Crucero crucero;
        private int cantidClasePremium;
        private int cantidadClaseTurista;
        private Eciudad tipoDestino;
        #endregion

        #region Constructores

        private Viaje()
        {
            this.listPasajeros = new List<Pasajero>();
            this.ciudadPartida = "Buenos Aires";
        }

        public Viaje(DateTime fechaInicioViaje, Crucero crucero, int cantidClasePremium, 
            int cantidadClaseTurista, DateTime fechaDeLlegada) : this()
        {

            this.fechaInicioViaje = fechaInicioViaje;
            this.crucero = crucero;
            this.cantidClasePremium = cantidClasePremium;
            this.cantidadClaseTurista = cantidadClaseTurista;
            this.fechaDeLlegada = fechaDeLlegada;

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
        public virtual string TipoDestino { get { return this.tipoDestino.ToString(); } }

        public Eestado Estado 
        {
            get
            {
                Eestado retorno = Eestado.Disponible;

                if(this.fechaDeLlegada >= DateTime.Now)
                {
                    retorno = Eestado.En_Viaje;
                }

                return retorno;
            }
        
        }

        #endregion

        #region Metodos
        public void AgregarPasajero(Pasajero passanger)
        {
            if(passanger is not null)
            {
                this.listPasajeros.Add(passanger);
            }

        }

        public List<Pasajero> GetListPasajeros()
        {
            return this.listPasajeros;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Clase turista: {this.cantidadClaseTurista} ");
            sb.AppendLine($"Cantidad Premium: {this.cantidClasePremium} ");
            sb.AppendLine($"Nombre Crucero: {this.crucero.Nombre} ");
            sb.AppendLine($"Matricula Crucero: {this.crucero.Matricula} ");

            return sb.ToString();
        }

        #endregion

    }
}
