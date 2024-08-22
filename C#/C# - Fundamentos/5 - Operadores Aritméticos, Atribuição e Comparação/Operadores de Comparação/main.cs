using System;

namespace OperadoresDeComparação
{
    class Programa
    {
        static void Main(String[] args)
        {
            int x = 5, y = 7;
            
            Console.WriteLine(x > y);  //retorna falso se x não é maior que y
            Console.WriteLine(x < y);  //retorna verdadeiro se x é menor que y
            Console.WriteLine(x == y); //retorna falso se x não é igual a y
            Console.WriteLine(x != y); //retorna verdadeiro se x não é igual a y
        }
    }
}