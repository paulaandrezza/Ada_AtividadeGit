using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    internal class InterfaceUsuario
    {
        public void MenuUsuario()
        {
            Console.WriteLine("Bem vindo ao conversor de moedas!");
            Console.WriteLine("Selecione abaixo a opcao desejada: ");
            Console.WriteLine("1 - Real para Iene");
            Console.WriteLine("2 - Real para Euro");
            Console.WriteLine("3 - Real para Peso Argentino");
            Console.WriteLine("4 - Real para Dolar Canadense");
            Console.WriteLine("5 - Real para Rupia");
            int opcao = int.Parse(Console.ReadLine());
            var realParaIene = new ConversaoRealIene();
            var realParaEuro = new ConversaoRealEuro();
            var realParaPesoArgentino = new ConversaoRealPeso();
            var realParaDolarCanadense = new ConversaoRealDolar();
            var realParaRupia = new ConversaoRealRupia();
            double valorReal;
            Console.WriteLine("Informe o valor que deseja converter: ");
            try
            {
                valorReal = double.Parse(Console.ReadLine());
                if (valorReal < 0)
                {
                    Console.WriteLine("Valor precisa ser positivo");
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Valor invalido");
                return;
            }
            switch (opcao)
            {
                case 1:
                    realParaIene.Converter(valorReal);
                    break;
                case 2:
                    realParaEuro.Converter(valorReal);
                    break;
                case 3:
                    realParaPesoArgentino.Converter(valorReal);
                    break;
                case 4:
                    realParaDolarCanadense.Converter(valorReal);
                    break;
                case 5:
                    realParaRupia.Converter(valorReal);
                    break;
                default:
                    Console.WriteLine("Opcao invalida");
                    break;
            }
        }
    }
}
