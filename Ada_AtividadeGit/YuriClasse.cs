using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    internal class YuriClasse
    {
        double taxaConversaoEUR = 5.41;
        public double conversaoEuro(double real)
        {
            double valorEmEUR = real * taxaConversaoEUR;
            return valorEmEUR;
        }
    }
}
