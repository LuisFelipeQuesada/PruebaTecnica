using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTecnica
{
    public class PaqueteTiquetes
    {
        public static List<Tiquete> OrdenarPaqueteTiquetes(List<Tiquete> paqueteDesordenado)
        {
            List<Tiquete> paqueteOrdenado = new List<Tiquete>();
            
            // El primer tiquete de "paqueteTiquetes" se ingresa a "resultadoOrdenado". Este primer tiquete será utilizado como pivot
            paqueteOrdenado.Add(paqueteDesordenado.First());

            // Después de ingresar el primer tiquete al paquete ordenado, se elimina del paquete desordenado
            paqueteDesordenado.RemoveAt(0);

            for (int i = 0; i < paqueteDesordenado.Count(); i++)
            {
                Tiquete tiquete = paqueteDesordenado.ElementAt(i);

                // En este ciclo se puede comparar el tiquete con los del paquete ordenado
                for (int j = 0; j < paqueteOrdenado.Count(); j++)
                {
                    Tiquete pivot = paqueteOrdenado.ElementAt(j);
                    if (tiquete.GetSalida() == pivot.GetLlegada())
                    {
                        paqueteOrdenado.Insert(j + 1, tiquete);
                        paqueteDesordenado.RemoveAt(i);
                        i = -1;
                        break;
                    }
                    else if (pivot.GetSalida() == tiquete.GetLlegada())
                    {
                        paqueteOrdenado.Insert(j, tiquete);
                        paqueteDesordenado.RemoveAt(i);
                        i = -1;
                        break;
                    }
                }
            }
            return paqueteOrdenado;
        }
    }
}
