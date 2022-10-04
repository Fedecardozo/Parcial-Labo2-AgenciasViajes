using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Crucero
    {
        private string matricula;
        private string nombre;
        private int cantidadCamarotes;
        private int cantidadSalones;
        private int cantidadCasino;
        private double capacidadBodega;
        private bool piscina;
        private bool gimnasio;
        private Eestado estadoViaje;
        private Viaje viaje;

        public Crucero(string matricula, string nombre, int cantidadCamarotes,
            int cantidadSalones,int cantidadCasino, float capacidadBodega, bool piscina, bool gimnasio)
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

        public string Gimnsaio 
        { 
            get
            {
                string retorno = "no";

                if (this.gimnasio)
                    retorno = "si";

                return retorno;
            }
        
        }

        public string Piscina
        {
            get
            {
                string retorno = "no";

                if (this.piscina)
                    retorno = "si";

                return retorno;
            }

        }

        public string Nombre { get { return this.nombre; } }

        public string Matricula { get { return this.matricula; } }

    }
}
