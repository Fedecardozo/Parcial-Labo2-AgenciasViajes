using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aleatorio
    {

        #region Generador Fecha Aleatorios

        public static DateTime Fecha(DateTime start, DateTime fin)
        {

            Random gen = new Random();

            int range = (fin - start).Days;

            return start.AddDays(gen.Next(range));

        }

        public static DateTime FechaNacimiento()
        {
            DateTime start = new DateTime(1950, 1, 1);
            DateTime fin = new DateTime(2003, 1, 1);

            return Aleatorio.Fecha(start, fin);

        }

        public static DateTime FechaInicio()
        {
            return Aleatorio.Fecha(new DateTime(2020, 1, 1), DateTime.Now);
        }
        public static DateTime FechaLlegadaRegional(DateTime fechaInicio)
        {
            //Viajes regionales: entre 72 hs.y 360 hs.
            //Minimo: 3 dias y maximo: 15 dias 
            Random random = new Random();
            int dias = random.Next(3,15);
            return Aleatorio.Fecha(fechaInicio, fechaInicio.AddDays(dias));
        }
        public static DateTime FechaLlegadaExtraRegional(DateTime fechaInicio)
        {
            //Viajes extra regionales: entre 480 hs.y 720 hs.
            //Minimo: 20 dias Y maximo: 30 dias
            Random random = new Random();
            int dias = random.Next(20, 30);
            return Aleatorio.Fecha(fechaInicio, fechaInicio.AddDays(dias));
        }
        #endregion
    }
}
