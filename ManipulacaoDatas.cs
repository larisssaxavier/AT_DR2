using System;

namespace AT_DR2
{
    class ManipulacaoDatas
    {
        public static string calculoData(string? data)
        {
            if (string.IsNullOrWhiteSpace(data))
                return "Data inválida. Digite novamente no formato dd/mm/aaaa.";

            if (DateTime.TryParse(data, out DateTime dataNascimento))
            {
                DateTime hoje = DateTime.Today;
                DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

                if (proximoAniversario < hoje)
                {
                    proximoAniversario = proximoAniversario.AddYears(1);
                }
                TimeSpan diferenca = proximoAniversario - hoje;
                int diasRestantes = diferenca.Days;

                if (diasRestantes < 7 && diasRestantes > 0)
                {
                    return $"Está chegando seu aniversário, faltam apenas {diasRestantes} dias para o seu aniversário!)";
                }
                else if (diasRestantes == 0)
                {
                    return "Parabéns hoje é seu aniversário!";
                }
                else
                {
                    return$"Faltam {diasRestantes} dias para o seu aniversário!";
                }

            }
            else
            {
                return "Data inválida. Digite novamente no formato dd/mm/aaaa.";
            }
        }    
        public static void Executar()
        {
            Console.WriteLine("Digite sua data de nascimento (dd/mm/aaaa): ");
            string dataAniversario = calculoData(Console.ReadLine());
            Console.WriteLine(dataAniversario);
        }
    }
}
