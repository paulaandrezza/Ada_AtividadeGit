using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    internal class ConversaoRealIene
    {
        private double taxaCambioRealParaIene = 20.5;
        public double Converter(double valorEmReal)
        {
            return valorEmReal * taxaCambioRealParaIene;
        }
    }
}
