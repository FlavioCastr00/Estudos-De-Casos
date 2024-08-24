using System;

namespace UsandoWhile
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Digite um número positivo:");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            
            Console.WriteLine("\nImprimindo tabela de multiplicação...");
            while (i <= 10) //repetira o bloco de código enquanto a condição for atendida.
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
                i++;
            }
        }
    }
}