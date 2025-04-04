class Program
{
    private static string arquivoContatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\contatos.txt");

    static void Main()
    {
        List<Contato> contatos = CarregarContatos();

        while (true)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Inserir Contato");
            Console.WriteLine("2. Listar Contatos");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    InserirContato(contatos);
                    break;
                case "2":
                    EscolherFormato(contatos);
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

    static void InserirContato(List<Contato> contatos)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        contatos.Add(new Contato { Nome = nome, Telefone = telefone, Email = email });
        SalvarContatos(contatos);
        Console.WriteLine("Contato salvo com sucesso!");
    }

    static void EscolherFormato(List<Contato> contatos)
    {
        Console.WriteLine("\nEscolha o formato de exibição:");
        Console.WriteLine("1. Markdown");
        Console.WriteLine("2. Tabela");
        Console.WriteLine("3. Texto Puro");
        Console.Write("Opção: ");

        string escolha = Console.ReadLine();
        Formatador formatter;

        switch (escolha)
        {
            case "1":
                formatter = new Markdown();
                break;
            case "2":
                formatter = new Tabela();
                break;
            case "3":
                formatter = new Texto();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        formatter.ExibirContatos(contatos);
    }

    static List<Contato> CarregarContatos()
    {
        List<Contato> contatos = new List<Contato>();
        if (File.Exists(arquivoContatos))
        {
            string[] linhas = File.ReadAllLines(arquivoContatos);
            foreach (var linha in linhas)
            {
                string[] dados = linha.Split(',');
                if (dados.Length == 3)
                {
                    contatos.Add(new Contato { Nome = dados[0], Telefone = dados[1], Email = dados[2] });
                }
            }
        }
        return contatos;
    }

    static void SalvarContatos(List<Contato> contatos)
    {
        using (StreamWriter sw = new StreamWriter(arquivoContatos))
        {
            foreach (var contato in contatos)
            {
                sw.WriteLine($"{contato.Nome},{contato.Telefone},{contato.Email}");
            }
        }
    }
}