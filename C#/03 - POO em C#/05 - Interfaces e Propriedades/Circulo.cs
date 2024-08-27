using System;

class Circulo : IForma
{
    private double raio;
    
    //Define uma Propriedade para classe, com métodos get e set. Isso nos permite acessar e manipular variaveis privadas
    public double Raio
    {
        get {return raio;}
        set {raio = value;}
    }
    
    public double Area //propriedade herdada da interface:
    {
        get
        {
            return Math.PI * (Raio * Raio);
        
        }
    }
    
    public string Desenhar() //método herdado da interface:
    {
        return "Desenhado um circulo...";
    }
}