using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    internal class CharlesClasse
    {
        public static void ConverteRealParaDolarCanadense()
        {
            double taxaConversao = 3.69;

            while(true)
            {
                Console.WriteLine("Digite o valor em reais: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double valorReal))
                {
                    double valorDolarCanadense = valorReal / taxaConversao;
                    Console.WriteLine($"Valor em dólares canadenses: C$ {valorDolarCanadense:F2}");
                    return;
                }
                Console.WriteLine("Entrada inválida. Digite novamente.");
            }
            
        }
    }
}
