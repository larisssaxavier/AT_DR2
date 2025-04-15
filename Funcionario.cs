using System;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public decimal SalarioBase { get; set; }

    public Funcionario(string nome, string cargo, decimal salarioBase)
	{
        Nome = nome;
        Cargo = cargo;
        SalarioBase = salarioBase;
    }
    public virtual decimal CalculoSalario()
    {
        return SalarioBase;
    }
    public virtual void ExibirDados()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário Base: {SalarioBase:F2}");
    }
}
