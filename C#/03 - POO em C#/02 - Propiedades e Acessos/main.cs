using System;

class Program
{
    static void Main(String[] args)
    {
        //Instancia a classe e inicializa o objeto
        ProdutoEletrônico p1 = new ProdutoEletrônico(123, "Lap Top", 939.99);
        
        //Usando métodos da classe:
        Console.WriteLine(p1.Detalhes());
        Console.WriteLine($"Preço do produto com desconto: {p1.FazerDesconto(0.25)}");
        
        //Inicializa outro objeto:
        ProdutoEletrônico p2 = new ProdutoEletrônico(442, "SmartWatch", 300.00);
        
        Console.WriteLine(p2.Detalhes());
        Console.WriteLine($"Preço do produto com desconto: {p2.FazerDesconto(0.125)}");
    }
}