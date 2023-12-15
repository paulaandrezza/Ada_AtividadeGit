﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada_AtividadeGit
{
    internal class ConversaoRealIene
    {
        private double taxaCambioRealParaIene = 20.5;
        public void Converter()
        {
            double valorEmReal;
            Console.Write("Insira o valor em real que deseja converter para Iene: R$ ");

            if (double.TryParse(Console.ReadLine(), out valorEmReal))
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