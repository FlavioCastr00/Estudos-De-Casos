using System;

class Program
{
    static void Main()
    {
        ContaBancaria c1 = new ContaBancaria(1000);
        
        Console.WriteLine(c1.getSaldo());
        c1.DepositarDinheiro();
        Console.WriteLine(c1.getSaldo());
        c1.SacarDinheiro();
        Console.WriteLine(c1.getSaldo());
        
        //"c1.saldo = 1000000;" -> este comando não funcionará, pois o saldo só pode ser manipulado de dentro da classe "ContaBancaria".
    }
}