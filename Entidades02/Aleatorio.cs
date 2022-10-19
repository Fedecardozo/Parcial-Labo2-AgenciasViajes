using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aleatorio
    {

        #region Constructor

        #endregion

        #region Generador Fecha Aleatorios

        public static DateTime Fecha(DateTime start, DateTime fin)
        {
            Random random = new Random();

            int range = (fin - start).Days;

            return start.AddDays(random.Next(range));

        }

        public static DateTime FechaNacimiento()
        {
            DateTime start = new DateTime(1950, 1, 1);
            DateTime fin = new DateTime(2003, 1, 1);

            return Aleatorio.Fecha(start, fin);

        }

        public static DateTime FechaInicio()
        {
            return Aleatorio.Fecha(new DateTime(2022, 7, 1), DateTime.Now.AddDays(20));
        }
        public static DateTime FechaLlegadaRegional(DateTime fechaInicio)
        {
            //Viajes regionales: entre 72 hs.y 360 hs.
            //Minimo: 3 dias y maximo: 15 dias 
            return fechaInicio.AddDays(Aleatorio.Azar(3,16));
        }
        public static DateTime FechaLlegadaExtraRegional(DateTime fechaInicio)
        {
            //Viajes extra regionales: entre 480 hs.y 720 hs.
            //Minimo: 20 dias Y maximo: 30 dias
            return fechaInicio.AddDays(Aleatorio.Azar(20,31));
        }

        public static int Azar(int min, int max)
        {
            Random random = new Random();
            return random.Next(min,max);

        }

        #endregion
    }
}
