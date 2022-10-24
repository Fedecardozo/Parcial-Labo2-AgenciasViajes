using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Adicional;

namespace InterfazDeUsuario
{
    public static class Estadistica
    {
        /// <summary>
        /// Funcion para ordenar de manera Descendente en sort de List<Viaje>
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Arma un string con la informacion del destino por facturacion ordenados de forma descendente
        /// </summary>
        /// <param name="viajes"></param>
        /// <returns></returns>       
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
    
        /// <summary>
        /// Muestra de forma harcodeada los pasajeros mas frecuentes
        /// </summary>
        /// <returns></returns>
        public static string ListarPasajeroFrecuentes()
        {
            StringBuilder sb = new StringBuilder();
            Viaje viaje = HistorialViajes.HistorialdeViajes[0];
            int min = 5;
            int max = 8;

            sb.AppendLine($"Pasajeros frecuentes: ");
            sb.AppendLine("");

            foreach (Pasajero pasajero in viaje.Pasajeros)
            {
                sb.AppendLine($"Nombre: {pasajero.Pasaporte.Nombre}");
                sb.AppendLine($"Apellido: {pasajero.Pasaporte.Apellido}");
                sb.AppendLine($"DNI: {pasajero.Pasaporte.Dni}");
                sb.AppendLine($"Cantidad de viajes: {Aleatorio.Azar(min,max)}");
                sb.AppendLine("");
                
                min++; max++;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Muestra Ganancias totales y clasificadas por regional y extra regional
        /// </summary>
        /// <returns></returns>
        public static string ListarGananciasTotalesClasificadas()
        {
            StringBuilder sb = new StringBuilder();
            double gananciaTotalRegional = 0;
            double gananciaTotalExtraRegional = 0;


            foreach (Viaje item in HistorialViajes.HistorialdeViajes)
            {
                if(item is ViajeRegional)
                {
                    gananciaTotalRegional += item.TotalFacturado;
                }
                else if(item is ViajeExtraRegional)
                {
                    gananciaTotalExtraRegional += item.TotalFacturado;
                }
            }

            sb.AppendLine($"Ganancias totales: ${(gananciaTotalRegional + gananciaTotalExtraRegional).ToString("N3")}");
            sb.AppendLine("");
            sb.AppendLine($"Ganancia regional: ${gananciaTotalRegional.ToString("N3")}");
            sb.AppendLine("");
            sb.AppendLine($"Ganancia Extra regional: ${gananciaTotalExtraRegional.ToString("N3")}");

            return sb.ToString();
        }

        /// <summary>
        /// Muestra las horas de viaje de cada crucero
        /// </summary>
        /// <returns></returns>
        public static string HorasViajesCruceros()
        {
            StringBuilder sb = new StringBuilder();

            int len = Harcodeo.ListaCruceros().Count;

            sb.AppendLine("Cruceros: ");
            sb.AppendLine("");
            foreach (Crucero item in Harcodeo.ListaCruceros())
            {
                sb.AppendLine($"Nombre: {item.Nombre}");
                sb.AppendLine($"Matricula: {item.Matricula}");
                sb.AppendLine($"Total de horas en viaje: {item.TotalHorasDeViaje}");
                sb.AppendLine("");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Harcodeo el destino mas pedido
        /// </summary>
        /// <returns></returns>
        public static string MostrarDestinosMasPedido()
        {
            return "El destino mas pedido es: Miami";
        }

    }
}
