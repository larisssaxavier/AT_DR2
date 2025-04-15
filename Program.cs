// See https://aka.ms/new-console-template for more information
using AT_DR2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual exercicio deseja executar?");
        Console.WriteLine("Exercicio 1 - Primeiro programa");
        Console.WriteLine("Exercicio 2 - Cifrador");
        Console.WriteLine("Exercicio 3 - Calculadora de matemática");
        Console.WriteLine("Exercicio 4 - Dias até o próximo aniversário");
        Console.WriteLine("Exercicio 5 - Dias restantes para formatura");
        Console.WriteLine("Exercicio 6 - Cadastro de Alunos");
        Console.WriteLine("Exercicio 7 - Banco Digital");
        Console.WriteLine("Exercicio 8 - Cadastro de Funcionários");
        Console.WriteLine("Exercicio 9 - Controle de Estoque via Linha de Comando");
        Console.WriteLine("Exercicio 10 - Jogo de advinhação");
        Console.WriteLine("Exercicio 11 - Manipulação de Arquivos - Cadastro e Listagem de Contatos");
        Console.WriteLine("Exercicio 12 - Manipulação de Arquivos com Herança e Polimorfismo - Formatos de Exibição");

        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                PrimeiroPrograma.Executar();
                break;
            case "2":
                Cifrador.Executar();
                break;
            case "3":
                CalculadoraMatematica.Executar();
                break;
            case "4":
                ManipulacaoDatas.Executar();
                break;
            case "5":
                DiferencaDatas.Executar();
                break;
            case "6":
                CadastroAluno.Executar();
                break;
            case "7":
                BancoDigital.Executar();
                break;
            case "8":
                CadastroFuncionario.Executar();
                break;
            case "9":
                ControleEstoque.Executar();
                break;
            case "10":
                JogoAdvinhacao.Executar();
                break;
            case "11":
                ManipulacaoArquivoExibicao.Executar();
                break;
            case "12":
                ManipulacaoArquivos.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}