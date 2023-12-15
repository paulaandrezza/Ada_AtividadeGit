using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    internal class ConveraoRealRupia
    {
        private double taxaConversaoParaINR = 16.84;
        public double Converter(double valorEmReal)
        {
            return valorEmReal * taxaConversaoParaINR;
        }
    }
}