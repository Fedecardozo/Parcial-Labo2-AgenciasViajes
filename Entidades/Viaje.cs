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
        List<Pasajero> listPasajeros;
        private Ciudad ciudadPartida;
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

        public Viaje(Ciudad ciudadPartida, Ciudad ciudadDestino)
        {
            this.ciudadPartida = ciudadPartida;
            this.ciudadDestino = ciudadDestino;
        }

        public string mostrarCiudad()
        {
            return $"{this.ciudadPartida} - {this.ciudadDestino}";
        }

        public string Mostrar()
        {
            return $"Clase turista: {this.cantidadClaseTurista} " +
                $"\nCantidad Premium: {this.cantidClasePremium} " +
                $"\nDuracion Viaje: {this.duracionViaje}" +
                $"\nNombre Crucero: {this.crucero.Nombre}" +
                $"\nMatricula Crucero: {this.crucero.Matricula}";
        }
    
        public static void HarcodeoPasajeros(Pasajero[] pasajeros, Viaje viaje)
        {

            for (int i = 0; i < pasajeros.Length; i++)
            {
                viaje.AgregarPasajero(pasajeros[i]);
            }

        }


    }
}
