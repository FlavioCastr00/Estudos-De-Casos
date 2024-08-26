using System;

class ContaBancaria
{
    private double saldo; //variável privada. Só pode ser acessada e manipulada pelos métodos abaixo
    double quantidade;
    
    public ContaBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
    }
    
    public void SacarDinheiro()
    {
        Console.Write("Digite a quantidade que deseja sacar: ");
        quantidade = Convert.ToDouble(Console.ReadLine());
        
        if (quantidade <= 0 || (saldo - quantidade) < 0)
        {
            while (quantidade <= 0 || (saldo - quantidade) < 0)
            {
                Console.Write("Não é possível sacar essa quantia. Digite um outro valor: ");
                quantidade = Convert.ToDouble(Console.ReadLine());
            }
        }
        else
        {
            saldo -= quantidade;
            Console.WriteLine("Saque concluido.");
        }
    }
    
    public void DepositarDinheiro()
    {
        Console.Write("Digite a quantidade que deseja depositar: ");
        quantidade = Convert.ToDouble(Console.ReadLine());
        
        if (quantidade <= 0)
        {
            while (quantidade <= 0)
            {
                Console.Write("Não é possível sacar essa quantia. Digite um outro valor: ");
                quantidade = Convert.ToDouble(Console.ReadLine());
            }
        }
        else
        {
            saldo += quantidade;
            Console.WriteLine("Depósito concluído.");
        }
    }
    
    public double getSaldo()
    {
        return saldo;
    }
}