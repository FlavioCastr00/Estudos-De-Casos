using System;

class Gato : Animal //herda a classe abstrata "Animal"
{
    private string cor;
    
    public Gato(string nome, int idade, string cor) : base(nome, idade) //Override no construtor
    {
        this.cor = cor;
    }
    
    //Override nos métodos:
    public override void Apresentar()
    {
        Console.WriteLine($"O nome do gato é {nome}. Sua idade é {idade}. E sua cor é {cor}.");
    }
    
    public override string Falar()
    {
        return "O gato mia...";
    }
}