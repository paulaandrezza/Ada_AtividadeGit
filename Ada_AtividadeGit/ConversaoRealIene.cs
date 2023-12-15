using System;

public class ConversaoRealIene
{
	public ConversaoRealIene()
	{
        double taxaCambioRealParaIene = 20.5;
        public void Converter()
        {
            double valorEmReal;
            Console.Write("Insira o valor em real que deseja converter para Iene: R$ ")

            if (double.TryParse(Console.ReadLine(), out double valorEmReal))
            {
                double valorEmIene = valorEmReal * taxaCambioRealParaIene;
                Console.WriteLine($"Valor em Iene: ¥ {valorEmIene}");
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor válido.");
            }
        }
    }
}
