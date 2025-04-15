class ManipulacaoArquivos
{
    private static string ArquivoContatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\arquivoContatos.txt");

    public static void Executar()
    {
        CriarArquivoSeNaoExistir();

        while (true)
        {
            ExibirMenu();
            string opcao = Console.ReadLine() ?? string.Empty;

            switch (opcao)
            {
                case "1":
                    AdicionarContato();
                    break;
                case "2":
                    ListarContatos();
                    break;
                case "3":
                    Console.WriteLine("Encerrando programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void CriarArquivoSeNaoExistir()
    {
        if (!File.Exists(ArquivoContatos))
        {
            File.Create(ArquivoContatos).Close();
        }
    }

    static void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("=== Gerenciador de Contatos ===");
        Console.WriteLine("1 - Adicionar novo contato");
        Console.WriteLine("2 - Listar contatos cadastrados");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
    }

    static void AdicionarContato()
    {
        try
        {
            Console.WriteLine("\n-- Novo Contato --");

            Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? string.Empty;

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine() ?? string.Empty;

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Erro: Todos os campos são obrigatórios!");
                return;
            }

            string linhaContato = $"{nome},{telefone},{email}";

            using (StreamWriter sw = File.AppendText(ArquivoContatos))
            {
                sw.WriteLine(linhaContato);
            }

            Console.WriteLine("\nContato cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao cadastrar contato: {ex.Message}");
        }
    }

    static void ListarContatos()
    {
        try
        {
            string[] linhas = File.ReadAllLines(ArquivoContatos);

            if (linhas.Length == 0)
            {
                Console.WriteLine("\nNenhum contato cadastrado.");
                return;
            }

            Console.WriteLine("\nContatos cadastrados:");
            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');
                if (dados.Length == 3)
                {
                    Console.WriteLine($"Nome: {dados[0]} | Telefone: {dados[1]} | Email: {dados[2]}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler contatos: {ex.Message}");
        }
    }
}