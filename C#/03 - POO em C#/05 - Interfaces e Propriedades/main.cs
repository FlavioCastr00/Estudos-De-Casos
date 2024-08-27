using System;

class Program
{
    static void Main(string[] args)
    {
        Circulo c1 = new Circulo();
        c1.Raio = 3.5; //manipulando variável através da propriedade "Raio"
        
        Console.WriteLine($"O circulo tem raio {c1.Raio} e área {c1.Area}");
        Console.WriteLine(c1.Desenhar());
        
        Retangulo r1 = new Retangulo {Largura = 12, Altura = 6}; //outra maneira de utilizar propriedades.
        
        Console.WriteLine($"O retangulo tem largura {r1.Largura}, altura {r1.Altura} e área {r1.Area}");
        Console.WriteLine(r1.Desenhar());
    }
}