using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Estadistica
    {
        private static int OrdenarPorFacturacion(Viaje v1, Viaje v2)
        {
            int retorno = 0;

            if(v1.TotalFacturado < v2.TotalFacturado)
            {
                retorno = 1;
            }
            else if(v1.TotalFacturado > v2.TotalFacturado)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static string ListarDestinosPorFacturacion(List<Viaje> viajes)
        {
            //List<string> destinos = new List<string>();
            StringBuilder destinos = new StringBuilder();

            List<Viaje> viajesAux = viajes;
            viajesAux.Sort(OrdenarPorFacturacion);

            foreach (Viaje item in viajesAux)
            {
                destinos.AppendLine($"Destino: {item.TipoDestino}");
                destinos.AppendLine($"Total Facturado: {item.TotalFacturado}");
                destinos.AppendLine("");
            }

            return destinos.ToString();
        }
    }
}
