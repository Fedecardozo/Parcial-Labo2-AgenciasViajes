﻿using System;
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
        private static int contadorId;
        List<Pasajero> listPasajeros;
        private string ciudadPartida;
        private DateTime fechaInicioViaje;
        private DateTime fechaDeLlegada;
        private Crucero crucero;
        private int cantidClasePremium;
        private int cantidadClaseTurista;
        private int id;
        #endregion

        #region Constructores

        static Viaje()
        {
            Viaje.contadorId = 1000;
        }

        private Viaje()
        {
            this.listPasajeros = new List<Pasajero>();
            this.ciudadPartida = "Buenos Aires";
            this.id = Viaje.contadorId;
            Viaje.contadorId++;
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
        public virtual string TipoDestino { get { return ""; } }
        public virtual string DuracionViaje { get { return ""; } }
        public int Id { get { return this.id; } }

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
            if(passanger is not null && this.crucero.LugaresDisponibles > 0)
            {
                this.listPasajeros.Add(passanger);
            }

        }

        public static bool operator ==(Viaje v1,Viaje v2)
        {
            return v1.id == v2.id;
        }

        public static bool operator != (Viaje v1, Viaje v2)
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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Clase turista: {this.cantidadClaseTurista} ");
            sb.AppendLine($"Cantidad Premium: {this.cantidClasePremium} ");
            sb.AppendLine($"Nombre Crucero: {this.crucero.Nombre} ");
            sb.AppendLine($"Matricula Crucero: {this.crucero.Matricula} ");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            
            if(obj != null && obj is Viaje)
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
