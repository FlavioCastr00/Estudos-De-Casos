using System;

class Cachorro : Animal //herda a classe abstrata "Animal"
{
    private string raça;
    
    public Cachorro(string nome, int idade, string raça) : base(nome, idade) //Override no construtor
    {
        this.raça = raça;
    }
    
    //Override nos métodos:
    public override void Apresentar()
    {
        Console.WriteLine($"O nome do cachorro é {nome}. Sua idade é {idade}. E sua raça é {raça}.");
    }
    
    public override string Falar()
    {
        return "O cachorro late...";
    }
}