using System;
using System.Globalization;

namespace AT_DR2
{
    class DiferencaDatas
    { 
       public static DateTime validaData()
        {
            DateTime dataValidada;
            while (true)
            {
                Console.WriteLine("Digite uma data no formato dd/mm/aaaa :");
                string input = Console.ReadLine();

                if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataValidada))
                {
                    if (dataValidada.Year < 1900 || dataValidada.Year > 2100)
                    {
                        Console.WriteLine("Erro: O ano deve estar entre 1900 e 2100. Tente novamente.");
                        continue;
                    }
                    return dataValidada;
                }
                else
                {
                    Console.WriteLine("Erro: Data inválida. Use o formato dd/mm/aaaa. Tente novamente.");
                }
            }

        }
        public static int diferencaDatas(DateTime dataAtual, DateTime dataFormatura)
        {
            if (dataAtual > DateTime.Now)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                return;
            }

            if (dataAtual > dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
                return;
            }

            TimeSpan diferenca = dataFormatura - dataAtual;
            int diasRestantes = diferenca.Days;

            if (diasRestantes > 36500)
            {
                Console.WriteLine("Erro: A diferença de datas está muito grande. Verifique os valores inseridos.");
                return -1;
            }

            if (diasRestantes < 0)
            {
                return;
            }

            if (diasRestantes < 180)
            {
                int meses = diasRestantes / 30;
                int dias = diasRestantes % 30;
                Console.WriteLine($"Faltam {meses} meses e {dias} dias para sua formatura!");
                Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
            }
            else
            {
                Console.WriteLine($"Faltam {diasRestantes} dias para a sua formatura.");
            }
        }
        public static void Executar()
        {
            Console.WriteLine("Digite a data atual (dd/mm/aaaa): ");
            DateTime dataAtual = validaData();
            Console.WriteLine("Digite a data da sua formatura (dd/mm/aaaa): ");
            DateTime dataFormatura = validaData();

            int diasRestantes = diferencaDatas(dataAtual, dataFormatura);
            Console.WriteLine($"Faltam {diasRestantes} dias para a sua formatura.");

        }

    }
}
