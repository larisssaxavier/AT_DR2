public class Tabela : Formatador
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("| Nome           | Telefone       | Email              |");
        Console.WriteLine("----------------------------------------");
        foreach (var contato in contatos)
        {
            Console.WriteLine($"| {contato.Nome,-14} | {contato.Telefone,-12} | {contato.Email,-18} |");
        }
        Console.WriteLine("----------------------------------------");
    }
}