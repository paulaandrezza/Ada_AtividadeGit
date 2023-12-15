using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    public class ConversaoRealEuro
    {
        private double taxaConversaoParaEUR = 5.41;
        public double Converter(double valorEmReal)
        {     
            return valorEmReal * taxaConversaoParaEUR;
        }
    }
}
