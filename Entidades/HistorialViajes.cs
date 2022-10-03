using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HistorialViajes
    {
        private List<Viaje> viajes;

        public HistorialViajes()
        {
            this.viajes = new List<Viaje>();
        }

        public void AgregarViaje(Viaje viaje)
        {
            this.viajes.Add(viaje);
        }

        public List<Viaje> Viajes{ get{ return this.viajes; } }

        

    }
}
