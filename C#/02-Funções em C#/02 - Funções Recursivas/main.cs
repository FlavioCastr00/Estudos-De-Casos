using System;

namespace FunçãoRecursiva
{
    class Program
    {
        static int CalcularFatorial(int número) //função recursiva que chama a si mesma
        {
            if (número == 0) //caso que impedirá a função de ser chamada mais vezes
            {
                return 1;
            }
            else //caso que chamará a função mais vezes
            {
                return número * CalcularFatorial(número - 1);
            }
        }
        
        static void Main(String[] args)
        {
            Console.Write("Escolha um número inteiro: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"O fatorial de {n} é " + CalcularFatorial(n));
        }
    }
}