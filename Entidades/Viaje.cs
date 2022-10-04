﻿using System;
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
        private Eregional ciudadDestinoRegional;
        private EextraRegional ciudadDestinoExtraRegional;
        private DateTime fechaInicioViaje;
        private DateTime fechaDeLlegada;
        private Crucero crucero;
        private int cantidClasePremium;
        private int cantidadClaseTurista;


        #region Constructores

        private Viaje()
        {
            this.listPasajeros = new List<Pasajero>();
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

        public Viaje(DateTime fechaInicioViaje, Crucero crucero, int cantidClasePremium,
            int cantidadClaseTurista, Eregional ciudadDestinoRegional, DateTime fechaDeLlegada)
            : this(fechaInicioViaje, crucero, cantidClasePremium, cantidadClaseTurista, fechaDeLlegada)
        {
            
            this.ciudadDestinoRegional = ciudadDestinoRegional;
        }

        public Viaje(DateTime fechaInicioViaje, Crucero crucero, int cantidClasePremium,
            int cantidadClaseTurista, DateTime fechaDeLlegada, EextraRegional ciudadDestinoExtraRegional)
            : this(fechaInicioViaje, crucero, cantidClasePremium, cantidadClaseTurista, fechaDeLlegada)
        {
    
            this.ciudadDestinoExtraRegional = ciudadDestinoExtraRegional;
        }

        #endregion

        #region Propiedades

        public int CantidadTurista { get { return this.cantidadClaseTurista; } }
        public int CantidadPremium { get { return this.cantidClasePremium; } }
        public DateTime FechaLlegada { get { return this.fechaDeLlegada.Date; } }
        public DateTime FechaInicioViajeDate { get { return this.fechaInicioViaje.Date; } }
        public string FechaInicioViaje { get { return this.FechaInicioViajeDate.ToString("d"); } }
        public Crucero Crucero { get { return this.crucero; } }
        public Eregional DestinoRegional { get { return this.DestinoRegional; } }
        public EextraRegional DestinoExtraRegional { get { return this.DestinoExtraRegional; } }

        public List<Pasajero> Pasajeros { get { return this.listPasajeros; } }

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
            sb.AppendLine($"Nombre Crucero: {this.crucero.Nombre} ");
            sb.AppendLine($"Matricula Crucero: {this.crucero.Matricula} ");

            return sb.ToString();
                 
        }
    
        

    }
}
