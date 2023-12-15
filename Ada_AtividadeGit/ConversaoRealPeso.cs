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
        private bool valido = true;
        public void ConversaoPesoArgentino()
        {
            while (valido)
            {
                double valorEmReal;
                Console.Write("Insira o valor em real que deseja converter para Peso Argentino: R$ ");

                if (double.TryParse(Console.ReadLine(), out valorEmReal))
                {
                    double valorEmARS = valorEmReal * taxaConversaoParaARS;
                    Console.WriteLine($"Valor em Peso Argentino: $ {valorEmARS}");
                    valido = false;
                }
                else
                {
                    Console.WriteLine("Por favor, insira um valor válido.");
                }
            }
        }
    }
}
