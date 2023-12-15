using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    internal class InterfaceUsuario
    {
        public static void MenuUsuario()
        {
            Console.WriteLine("Bem vindo ao conversor de moedas!");
            Console.WriteLine("Selecione abaixo a opcao desejada: ");
            Console.WriteLine("1 - Real para Iene");
            Console.WriteLine("2 - Real para Euro");
            Console.WriteLine("3 - Real para Peso Argentino");
            int opcao = int.Parse(Console.ReadLine());
            var realParaIene = new ConversaoRealIene();
            var realParaEuro = new ConversaoRealEuro();
            var realParaPesoArgentino = new ConversaoRealPeso();
            var realParaDolar = new ConversaoRealDolar();
            double valorReal;
            Console.WriteLine("Informe o valor que deseja converter: ");
            valorReal = double.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    realParaIene.Converter(valorReal);
                    break;
                case 2:
                    realParaEuro.conversaoEuro(valorReal);
                    break;
                case 3:
                    realParaPesoArgentino.conversaoPesoArgentino(valorReal);
                    break;
                case 4:
                    ConversaroRealDolar.ConverteRealParaDolarCanadense(valorReal);
                case 5:
                    ConversaoRealRupia.Conver
                default:
                    Console.WriteLine("Opcao invalida");
                    break;
            }
        }
    }
}
