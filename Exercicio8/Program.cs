class Program
{
    public static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario("Larissa", "Estagiaria", 3000m);
        Console.WriteLine("Dados do Funcionário:");
        Console.WriteLine("--Staff--");
        funcionario.ExibirDados();

        Console.WriteLine("\nDados do Funcionário:");
        Console.WriteLine("--Gerente--");
        Gerente gerente = new Gerente("Carlos", 9000m);
        gerente.ExibirDados();
    }
}