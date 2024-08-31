using System;

class Retangulo : IForma
{
    //Propriedades:
    public double Largura {get; set;}
    public double Altura {get; set;}
    
    public double Area //propriedade herdada da interface:
    {
        get
        {
            return Largura * Altura;
        }
    }
    
    public string Desenhar() //método herdado da interface:
    {
        return "Desenhando um retangulo...";
    }
}