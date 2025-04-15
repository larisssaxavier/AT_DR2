using System;

public class Arrays
{
    public static void Executar()
    {
        string[] nomes = new string[5];
        int[] quantidades = new int[5];
        decimal[] precos = new decimal[5];
        int totalProdutos = 0;

        while (true)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Inserir Produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine() ?? string.Empty;

            switch (opcao)
            {
                case "1":
                    if (totalProdutos >= 5)
                    {
                        Console.WriteLine("Limite de produtos atingido!");
                        break;
                    }

                    Console.Write("Nome do produto: ");
                    nomes[totalProdutos] = Console.ReadLine() ?? string.Empty;

                    Console.Write("Quantidade: ");
                    if (!int.TryParse(Console.ReadLine(), out quantidades[totalProdutos]))
                    {
                        Console.WriteLine("Quantidade inválida!");
                        continue;
                    }
                    Console.Write("Preço unitário (ex.: 12,56): ");
                    if (!decimal.TryParse(Console.ReadLine(), out precos[totalProdutos]))
                    {
                        Console.WriteLine("Quantidade inválida!");
                        continue;
                    }

                    totalProdutos++;
                    Console.WriteLine("Produto cadastrado com sucesso!");
                    break;

                case "2":
                    if (totalProdutos == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                        break;
                    }

                    Console.WriteLine("\nPRODUTOS CADASTRADOS:");
                    for (int i = 0; i < totalProdutos; i++)
                    {
                        Console.WriteLine($"Produto: {nomes[i]} | Quantidade: {quantidades[i]} | Preço: R$ {precos[i]:F2}");
                    }
                    break;

                case "3":
                    Console.WriteLine("Saindo do sistema...");
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
