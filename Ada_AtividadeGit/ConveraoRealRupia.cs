using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    internal class ConveraoRealRupia
    {
        private decimal taxaConversaoParaINR = 0.059m;
        public void conversaoEuro()
        {
            decimal valorEmReal;
            Console.Write("Insira o valor em real que deseja converter para Rupias: R$ ");

            if (decimal.TryParse(Console.ReadLine(), out valorEmReal))
            {
                decimal valorEmINR = valorEmReal * taxaConversaoParaINR;
                Console.WriteLine($"Valor em Rupias: ₹ {valorEmINR}");
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor válido.");
            }
        }
    }
}