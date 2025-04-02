using System;

namespace AT_DR2
{
    class CalculadoraMatematica
    {
        public static double somar(double a, double b)
        {
            return a + b;
        }
        public static double subtrair(double a, double b)
        {
            return a - b;
        }
        public static double multiplicar(double a, double b)
        {
            return a * b;
        }
        public static double dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Não é possível dividir por zero");
                return 0;
            }
            return a / b;
        }
        public static double verificaNumero(string entrada)
        {
            if (!double.TryParse(entrada, out double valor))
            {
                Console.WriteLine("Digite um número válido");
                return verificaNumero(Console.ReadLine());
            }
            return valor;
        }
        public static void opcoes(int operacao, double numero1, double numero2)
        {
            double resultado = 0;
            Console.WriteLine($"Número 1: {numero1}, Número 2: {numero2}");
            switch (operacao)
            {
                case 1:
                    resultado = somar(numero1, numero2);
                    break;
                case 2:
                    resultado = subtrair(numero1, numero2);
                    break;
                case 3:
                    resultado = multiplicar(numero1, numero2);
                    break;
                case 4:
                    resultado = dividir(numero1, numero2); 
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
            Console.WriteLine($"Resultado: {resultado}");
        }
                

        public static void Executar()
        {
            Console.WriteLine("Digite o primeiro número: ");
            double numero1 = verificaNumero(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double numero2 = verificaNumero(Console.ReadLine());

            Console.WriteLine("Digite a operação desejada: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            if (!int.TryParse(Console.ReadLine(), out int operacao))
            {
                Console.WriteLine("Operação inválida.");
                return;
            }

            opcoes(operacao, numero1, numero2);

        }
    }
}
