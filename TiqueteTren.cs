using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTecnica
{
    public class TiqueteTren : Tiquete
    {
        private string numAsiento = "";

        public TiqueteTren(string salida, string llegada, string asiento)
            : base(salida, llegada)
        {
            numAsiento = asiento;
        }

        public void SetNumAsiento(string asiento)
        {
            numAsiento = asiento;
        }

        public string GetNumAsiento()
        {
            return numAsiento;
        }
    }
}
