public class Markdown : Formatador
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("## Lista de Contatos\n");
        foreach (var contato in contatos)
        {
            Console.WriteLine($"- Nome: {contato.Nome}\n");
            Console.WriteLine($"- Telefone: {contato.Telefone}\n");
            Console.WriteLine($"- Email: {contato.Email}\n");
            Console.WriteLine();
        }
    }
}
