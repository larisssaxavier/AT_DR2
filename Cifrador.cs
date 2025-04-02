using System;

namespace AT_DR2
{
    class Cifrador
    {
        public static string CifrarNome(string nome)
        {
            char[] caracteres = nome.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (char.IsLetter(caracteres[i])) 
                {
                    char baseLetra = char.IsUpper(caracteres[i]) ? 'A' : 'a';
                    caracteres[i] = (char)(baseLetra + (caracteres[i] - baseLetra + 2) % 26);
                }
            }

            return new string(caracteres);
        }
        public static void Executar()
        {
            Console.WriteLine("Digite seu nome:");
            var nomeCifrado = CifrarNome(Console.ReadLine());
            Console.WriteLine($"Nome cifrado: {nomeCifrado}");
        }
    }
}