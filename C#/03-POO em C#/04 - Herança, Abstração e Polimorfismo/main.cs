using System;

class Program
{
    static void Main(string[] args)
    {
        Cachorro c1 = new Cachorro("Layka", 16, "Labrador");
        c1.Apresentar();
        Console.WriteLine(c1.Falar());
        
        Gato g1 = new Gato("Alex", 6, "Laranja");
        g1.Apresentar();
        Console.WriteLine(g1.Falar());
    }
}