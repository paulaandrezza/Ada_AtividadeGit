using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    public class LauraClasse
    {
        private double taxaConversaoParaARS = 162.04;
        public void ConversaoPesoArgentino()
        {
            double valorEmReal;
            Console.Write("Insira o valor em real que deseja converter para Peso Argentino: R$ ");

            if (double.TryParse(Console.ReadLine(), out valorEmReal))
            {
                double valorEmARS = valorEmReal * taxaConversaoParaARS;
                Console.WriteLine($"Valor em Peso Argentino: $ {valorEmARS}");
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor válido.");
            }
        }
    }
}
