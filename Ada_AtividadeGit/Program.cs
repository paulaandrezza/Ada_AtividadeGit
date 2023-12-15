﻿namespace Ada_AtividadeGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tCONVERSÃO DE MOEDAS");
            Console.WriteLine("Grupo: Laura, Paula, Charles, Luana e Yuri\n");

            ConversaoRealEuro converterEuro = new ConversaoRealEuro();
            double valorConvertido = converterEuro.ConversaoEuro();

            ConversaoRealPeso converterPesoArgentino = new ConversaoRealPeso();
            double valorConvertido = converterPesoArgentino.ConversaoPesoArgentino();          

            ConversaoRealIene conversor = new ConversaoRealIene();
            conversor.Converter();

            ConversaroRealDolar.ConverteRealParaDolarCanadense();
        }
    }
}