using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTecnica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tiquete> paquete = new List<Tiquete>();
            paquete.Add(new TiqueteTren("Cartago", "San José", "32A"));
            paquete.Add(new TiqueteBus("San José", "Aeropuerto JSM"));
            paquete.Add(new TiqueteAvion("Aeropuerto NY", "Madrid", "30C", "MD124", "24B"));
            paquete.Add(new TiqueteAvion("Aeropuerto JSM", "Aeropuerto NY", "15B", "NY-15", "10A"));
            
            List<Tiquete> paqueteOrdenado = PaqueteTiquetes.OrdenarPaqueteTiquetes(paquete);

            foreach (Tiquete tiquete in paqueteOrdenado)
            {
                if (tiquete is TiqueteTren)
                {
                    Console.WriteLine("Medio: Tren, " + " {0}, {1}, {2}",
                        "Salida: " + tiquete.GetSalida() + ", ",
                        "Llegada: " + tiquete.GetLlegada() + ", ",
                        "Asiento: " + ((TiqueteTren)tiquete).GetNumAsiento());
                }
                else if (tiquete is TiqueteAvion)
                {
                    Console.WriteLine("Medio: Avión, " + " {0}, {1}, {2}, {3}, {4}",
                        "Salida: " + tiquete.GetSalida() + ", ",
                        "Llegada: " + tiquete.GetLlegada() + ", ",
                        "Puerta de abordaje: " + ((TiqueteAvion)tiquete).GetPuertaAbordaje() + ", ",
                        "Vuelo: " + ((TiqueteAvion)tiquete).GetNumVuelo() + ", ",
                        "Asiento: " + ((TiqueteAvion)tiquete).GetNumAsiento());
                }
                else
                {
                    Console.WriteLine("Medio: Bus, " + " {0}, {1}",
                        "Salida: " + tiquete.GetSalida() + ", ",
                        "Llegada: " + tiquete.GetLlegada() + ", ");
                }
            }
            Console.Read();
        }
    }
}
