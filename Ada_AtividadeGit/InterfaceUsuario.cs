﻿using System;
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
            var realParaIene = new ConversaoRealIene();
            int opcao = int.Parse(Console.ReadLine());
            var realParaEuro = new YuriClasse();
            var realParaPesoArgentino = new LauraClasse();
            switch (opcao)
            {
                case 1:
                    realParaIene.Converter();
                    break;
                case 2:
                    Console.WriteLine("Informe o valor que deseja converter: ");
                    double real_euro = double.Parse(Console.ReadLine());
                    realParaEuro.conversaoEuro(real_euro);
                    break;
                case 3:
                    Console.WriteLine("Informe o valor que deseja converter: ");
                    double real_peso = double.Parse(Console.ReadLine());
                    realParaPesoArgentino.conversaoPesoArgentino(real_peso);
                    break;
                default:
                    Console.WriteLine("Opcao invalida");
                    break;
            }
        }
    }
}