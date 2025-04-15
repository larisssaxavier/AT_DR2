using System;

public class ContaBancaria
{
	public string Titular { get; set; }
	private decimal saldo;

    public ContaBancaria(string titular, decimal saldoInicial = 0)
	{
        Titular = titular;
        saldo = saldoInicial;
    }
    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("\nValor de depósito deve ser maior que zero.");
            Console.WriteLine($"Tentativa de depósito no valor de: R${valor}");
            return;
        }
        saldo += valor;
        Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso.");
    }
    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("\nValor de saque deve ser maior que zero.");
            return;
        }
        if (valor > saldo)
        {
            Console.WriteLine("\nSaldo insuficiente para realizar o saque.");
            Console.WriteLine($"Valor de saque R${valor:F2} maior que o saldo atual.");
            return;
        }
        saldo -= valor;
        Console.WriteLine($"\nSaque de {valor:F2} realizado com sucesso.");
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: R${saldo:F2}");
    }
}
