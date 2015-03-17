using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTecnica
{
    public class TiqueteAvion : Tiquete
    {
        private string numAsiento = "";
        private string numVuelo = "";
        private string puertaAbordaje = "";

        public TiqueteAvion(string salida, string llegada, string puertaAbordaje, string vuelo, string asiento)
            : base(salida, llegada)
        {
            numAsiento = asiento;
            numVuelo = vuelo;
            this.puertaAbordaje = puertaAbordaje;
        }

        public void SetNumAsiento(string asiento)
        {
            numAsiento = asiento;
        }

        public string GetNumAsiento()
        {
            return numAsiento;
        }

        public void SetNumVuelo(string vuelo)
        {
            numVuelo = vuelo;
        }

        public string GetNumVuelo()
        {
            return numVuelo;
        }

        public void SetPuertaAbordaje(string puertaAbordaje)
        {
            this.puertaAbordaje = puertaAbordaje;
        }

        public string GetPuertaAbordaje()
        {
            return puertaAbordaje;
        }
    }
}
