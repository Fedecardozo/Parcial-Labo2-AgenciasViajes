﻿using System;
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
        private float capacidadBodega;
        private bool piscina;
        private bool gimnasio;

        public string Gymnsaio 
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
    }
}
