﻿// See https://aka.ms/new-console-template for more information
using AT_DR2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual exercicio deseja executar?");
        Console.WriteLine("Exercicio 1 - Primeiro programa");
        Console.WriteLine("Exercicio 2 - Cifrador");
        Console.WriteLine("Exercicio 3 - Calculadora de matemática");
        Console.WriteLine("Exercicio 4 - Dias até o próximo aniversário");
        Console.WriteLine("Exercicio 5 - Dias restantes para formatura");

        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                PrimeiroPrograma.Executar();
                break;
            case "2":
                Cifrador.Executar();
                break;
            case "3":
                CalculadoraMatematica.Executar();
                break;
            case "4":
                ManipulacaoDatas.Executar();
                break;
            case "5":
                DiferencaDatas.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}