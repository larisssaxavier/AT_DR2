class ControleEstoque
{
    public static void Executar()
    {
        Console.WriteLine("Bem-vindo ao sistema de controle de estoque!");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1. Usar Arrays");
        Console.WriteLine("2. Usar Persistência em Arquivo");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine() ?? string.Empty;

        switch (opcao)
        {
            case "1":
                Arrays.Executar();
                break;
            case "2":
                Persistencia.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}