﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno
        {
            Nome = "Larissa Xavier",
            Matricula = "2025001",
            Curso = "Engenharia da Computação",
            MediaNotas = 6.5
        };

        aluno.ExibirDados();

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}