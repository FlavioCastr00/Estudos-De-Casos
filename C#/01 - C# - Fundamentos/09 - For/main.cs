using System;

namespace UsandoFor
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Escolha um número:");
            int num = Convert.ToInt32(Console.ReadLine());
            int aux = 1;
            
            for (int i = num; i > 1; i--) //recebe três argumentos: for(inicializador, condição, incremento/decremento)
            {
                //executará esse bloco de código enquanto a condição for atendida
                aux = aux * num;
                num -= 1;
            }
            
            Console.WriteLine($"O fatorial é {aux}");
        }
    }
}