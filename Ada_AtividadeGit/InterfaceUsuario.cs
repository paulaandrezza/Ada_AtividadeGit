using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    public class InterfaceUsuario
    {
        public void MenuUsuario()
        {
            Console.WriteLine("Bem vindo ao conversor de moedas!");
            Console.WriteLine("Selecione abaixo a opcao desejada: ");
            Console.WriteLine("1 - Real para Iene");
            Console.WriteLine("2 - Real para Euro");
            Console.WriteLine("3 - Real para Peso Argentino");
            Console.WriteLine("4 - Dolar Canadense");
            Console.WriteLine("5 - Real para Peso Argentino");

            string opcao = Console.ReadLine();
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
                case "1":
                    Double Iene = realParaIene.Converter(valorReal);
                    Console.WriteLine($"{valorReal} reais para ienes = {Iene}");
                    break;
                case "2":
                    Double Euro = realParaEuro.Converter(valorReal);
                    Console.WriteLine($"{valorReal} reais para euros = {Euro}");
                    break;
                case "3":
                    Double Peso = realParaPesoArgentino.Converter(valorReal);
                    Console.WriteLine($"{valorReal} reais para pesos = {Peso}");
                    break;
                case "4": // Problemas de conversão aqui
                    Double DolarCanadense = realParaDolarCanadense.Converter(valorReal);
                    Console.WriteLine($"{valorReal} reais para dolares canadenses = {DolarCanadense}");
                    break;
                case "5":
                    Double Rupia = realParaRupia.Converter(valorReal);
                    Console.WriteLine($"{valorReal} reais para rupias = {Rupia}");
                    break;
                default:
                    Console.WriteLine("Opcao invalida");
                    break;
            }
        }
    }
}
