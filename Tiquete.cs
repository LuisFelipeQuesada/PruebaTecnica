using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTecnica
{
    public class Tiquete
    {
        private string salida   = "";
        private string llegada  = "";

        public Tiquete(string salida, string llegada)
        {
            this.salida = salida;
            this.llegada = llegada;
        }

        public void SetSalida(string salida)
        {
            this.salida = salida;
        }

        public string GetSalida()
        {
            return salida;
        }

        public void SetLlegada(string llegada)
        {
            this.salida = llegada;
        }

        public string GetLlegada()
        {
            return llegada;
        }
    }
}
