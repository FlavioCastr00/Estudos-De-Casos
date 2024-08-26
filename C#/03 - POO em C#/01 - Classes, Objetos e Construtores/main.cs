using System;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Clark", 23); //inicializa um objeto
        Console.WriteLine($"Exemplo 1:\nNome: {p1.getNome()} - Idade: {p1.getIdade()}");
        
        Console.WriteLine("\nExemplo 2:\nEscreva o nome e a idade:");
        Pessoa p2 = new Pessoa(Console.ReadLine(), Convert.ToInt16(Console.ReadLine())); //inicializa um novo objeto
        Console.WriteLine($"Nome: {p2.getNome()} - Idade: {p2.getIdade()}");
    }
}