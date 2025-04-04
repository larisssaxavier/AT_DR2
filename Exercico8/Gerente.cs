using System;

public class Gerente : Funcionario
{
	public Gerente(string nome, decimal salarioBase)
        : base(nome, "Gerente", salarioBase)
	{
    }
    public override decimal CalculoSalario()
    {
        return SalarioBase * 1.2m;
    }
    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"\nSalário Gerente (adicional 20%): {CalculoSalario():F2}");
    }
}
