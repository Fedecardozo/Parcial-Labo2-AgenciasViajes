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

        public bool ObtenerViaje(int id,out Viaje viaje)
        {
            int i = 0;
            bool retorno = false;
            viaje = null;

            foreach (Viaje item in this.viajes)
            {
                if(item == id)
                {
                    retorno = true;
                    viaje = this.viajes[i];
                    break;
                }
                i++;
            }

            return retorno;
        }

        public Viaje ObtenerViaje(int id)
        {
            Viaje viaje;

            this.ObtenerViaje(id,out viaje);

            return viaje;
        }

        private Viaje this[int index] 
        {
            get
            {
                if (index > 0)
                    return this.viajes[index];
                else
                    return null;
            }
        }

        public List<Viaje> Viajes{ get{ return this.viajes; } }

        

    }
}
