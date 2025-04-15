using System;
using System.IO;

public class Persistencia
{
    private static string arquivoEstoque = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\estoque.txt");

    public Persistencia()
    {
        if (!File.Exists(arquivoEstoque))
        {
            File.Create(arquivoEstoque).Close();
        }
    }

    public static void Executar()
    {
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
                    InserirProduto();
                    break;

                case "2":
                    ListarProdutos();
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

    private static void InserirProduto()
    {
        try
        {
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine() ?? string.Empty;

            Console.Write("Quantidade: ");
            string? inputQuantidade = Console.ReadLine();
            if (!int.TryParse(inputQuantidade, out int quantidade))
            {
                Console.WriteLine("Quantidade inválida!");
                return;
            }

            Console.Write("Preço unitário: ");
            string? inputPreco = Console.ReadLine();
            if (!decimal.TryParse(inputPreco, out decimal preco))
            {
                Console.WriteLine("Preço inválido!");
                return;
            }

            using (StreamWriter sw = File.AppendText(arquivoEstoque))
            {
                sw.WriteLine($"{nome},{quantidade},{preco.ToString("0.00")}");
            }

            Console.WriteLine("Produto cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao cadastrar produto: {ex.Message}");
        }
    }

    private static void ListarProdutos()
    {
        try
        {
            if (!File.Exists(arquivoEstoque))
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            string[] linhas = File.ReadAllLines(arquivoEstoque);

            if (linhas.Length == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            Console.WriteLine("\nPRODUTOS CADASTRADOS:");
            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');

                if (dados.Length >= 3)
                {
                    string nome = dados[0].Trim();
                    string quantidadeStr = dados[1].Trim();
                    string precoStr = string.Join(",", dados, 2, dados.Length - 2).Trim(); 

                    if (int.TryParse(quantidadeStr, out int quantidade) &&
                        decimal.TryParse(precoStr.Replace('.', ','), out decimal preco))
                    {
                        Console.WriteLine($"Produto: {nome} | Quantidade: {quantidade} | Preço: R$ {preco:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Erro ao interpretar dados da linha:");
                        Console.WriteLine(linha);
                    }
                }
                else
                {
                    Console.WriteLine("Linha com formato inválido:");
                    Console.WriteLine(linha);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler produtos: {ex.Message}");
        }
    }
}