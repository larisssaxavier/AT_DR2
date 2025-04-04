public class Program
{
    static void Main(string[] args)
    {
        ContaBancaria contaLarissa = new ContaBancaria("Larissa", 25);
        Console.WriteLine("Bem-vindo ao sistema bancário!\n");
        Console.WriteLine($"Titular: {contaLarissa.Titular}\n");

        contaLarissa.Depositar(256.56m);
        contaLarissa.ExibirSaldo();

        contaLarissa.Sacar(340.56m);
        contaLarissa.ExibirSaldo();

        contaLarissa.Sacar(100.50m);
        contaLarissa.ExibirSaldo();

        contaLarissa.Depositar(-100.50m);
        contaLarissa.ExibirSaldo();

    }
}