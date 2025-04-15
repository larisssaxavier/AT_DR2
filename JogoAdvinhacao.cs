class JogoAdvinhacao
{
    public static void Executar()
    {
        Random random = new Random();
        int numeroAdvinhar = random.Next(1, 51);
        int tentativasRestantes = 5;
        bool acertou = false;

        Console.WriteLine("Tente adivinhar um número entre 1 e 50.");
        Console.WriteLine($"Você tem {tentativasRestantes} tentativas.\n");

        while (tentativasRestantes > 0 && !acertou)
        {
            try
            {
                Console.Write($"Tentativa {6 - tentativasRestantes}: Digite um número: ");
                if (!int.TryParse(Console.ReadLine(), out int palpite))
                {
                    Console.WriteLine("Valor inválido! Digite um número.");
                    continue;
                }

                if (palpite < 1 || palpite > 50)
                {
                    Console.WriteLine("Erro: O número deve estar entre 1 e 50!\n");
                    continue;
                }

                if (palpite == numeroAdvinhar)
                {
                    acertou = true;
                    Console.WriteLine("\nParabéns! Você acertou o número secreto!");
                }
                else
                {
                    tentativasRestantes--;
                    string dica = palpite < numeroAdvinhar ? "maior" : "menor";
                    Console.WriteLine($"Errou! O número secreto é {dica} que {palpite}.");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Por favor, digite apenas números inteiros!\n");
            }
        }

        if (!acertou)
        {
            Console.WriteLine($"\nSuas tentativas acabaram! O número era: {numeroAdvinhar}");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}