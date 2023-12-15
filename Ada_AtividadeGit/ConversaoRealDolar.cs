using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    internal class ConversaoRealDolar
    {
        /// <summary>
        /// Converte um valor dado em reais para seu valor correspondente em dólares canadenses
        /// </summary>
        /// <param name="valorReal"></param>
        /// <returns></returns>
        public double Converter(double valorReal)
        {
            double taxaConversao = 3.69;
            double valorDolarCanadense = valorReal * taxaConversao;
            return valorDolarCanadense;            
        }
    }
}
