using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    public class YuriClasse
    {
        private double taxaConversaoParaEUR = 5.41;
        public void ConversaoEuro()
        {
            double valorEmReal;
            Console.Write("Insira o valor em real que deseja converter para Euro: R$ ");

            if (double.TryParse(Console.ReadLine(), out valorEmReal))
            {
                double valorEmEUR = valorEmReal * taxaConversaoParaEUR;
                Console.WriteLine($"Valor em Euro: € {valorEmEUR}");
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor válido.");
            }
        }
    }
}
