using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    public class ConversaoRealPeso
    {
        private double taxaConversaoParaARS = 162.04;
        public double Converter(double valorEmReal)
        {
            return valorEmReal * taxaConversaoParaARS;
        }
    }
}
