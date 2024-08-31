using System;

namespace MétodoMath
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("O maior valor entre 4 e 7 é " + Math.Max(4, 7));     //maior valor entre dois números
            Console.WriteLine("O menor valor entre 8 e 5 é " + Math.Min(8, 5));     //menor valor entre dois números
            Console.WriteLine("A raiz quadrada de 81 é " + Math.Sqrt(81));          //retorna a raiz quadrada de um número
            Console.WriteLine("O valor absoluto de -12.3 é " + Math.Abs(-12.3));    //retorna o valor absoluto de número
            Console.WriteLine("O valor arredondado de 8.75 é " + Math.Round(8.75)); //retorna o valor arredondado de um número
        }
    }
}