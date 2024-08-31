using System;

namespace OperadoresAritméticos
{
    class Programa
    {
        static void Main(String[] args)
        {
            double num1, num2;
            
            Console.WriteLine("Digite dois números:");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Soma: " + (num1 + num2));
            Console.WriteLine("Subtração: " + (num1 - num2));
            Console.WriteLine("Multiplicação: " + (num1 * num2));
            Console.WriteLine("Divisão: " + (num1 / num2));
            Console.WriteLine("Sobra da divisão: " + (num1 % num2));
        }
    }
}