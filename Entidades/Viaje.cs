using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Viaje
    {
        private const int costoPremium = 120;
        private const int costoTurista = 57;
        private const Eregional ciudadPartida = Eregional.Buenos_Aires;
        
        List<Pasajero> listPasajeros;
        private Ciudad ciudadDestino;
        private DateTime fechaInicioViaje;
        private Crucero crucero;
        private int cantidClasePremium;
        private int cantidadClaseTurista;
        private int duracionViaje;

        private Viaje()
        {
            this.listPasajeros = new List<Pasajero>();
        }

        public Viaje(DateTime fechaInicioViaje, Crucero crucero, int cantidClasePremium, 
            int cantidadClaseTurista) : this()
        {

            Random numeroRandom = new Random();

            this.fechaInicioViaje = fechaInicioViaje;
            this.crucero = crucero;
            this.cantidClasePremium = cantidClasePremium;
            this.cantidadClaseTurista = cantidadClaseTurista;
            //Cuando solucione lo de ciudad deberia calcular mejor la duracion de viaje
            this.duracionViaje = numeroRandom.Next(100,300);
            
        }

       // public string CiudadPartida { get { return this.ciudadPartida.ToString(); } }
       // public string CiudadDestino { get { return this.ciudadDestino.ToString(); } }
        public int CantidadTurista { get { return this.cantidadClaseTurista; } }
        public int CantidadPremium { get { return this.cantidClasePremium; } }
        public int DuracionViaje { get { return this.duracionViaje; } }
        public DateTime FechaInicioViaje { get { return this.fechaInicioViaje.Date; } }
        public Crucero Crucero { get { return this.crucero; } }

        public List<Pasajero> Pasajeros { get { return this.listPasajeros; } }
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

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Clase turista: {this.cantidadClaseTurista} ");
            sb.AppendLine($"Cantidad Premium: {this.cantidClasePremium} ");
            sb.AppendLine($"Duracion Viaje: {this.duracionViaje} ");
            sb.AppendLine($"Nombre Crucero: {this.crucero.Nombre} ");
            sb.AppendLine($"Matricula Crucero: {this.crucero.Matricula} ");

            return sb.ToString();
                 
        }
    
        

    }
}
