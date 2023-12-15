using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    internal class LauraClasse
    {
        double taxaConversaoARS = 162.04;
        public double conversaoPesoArgentino(double real)
        {
            double valorEmARS = real * taxaConversaoARS;
            return valorEmARS;
        }
    }
}
