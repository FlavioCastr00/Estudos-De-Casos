using System;

namespace DataTypes
{
    class Programa
    {
        static void Main(String[] args)
        {
            int num = 10000; //Variáveis inteiras suportam valores entre -2147483648 à 2147483647
            Console.WriteLine(num);
            
            long longNum = 1700000000000000L; //Variáveis do tipo "long" suportam entre -9223372036854775808 à 9223372036854775807
            Console.WriteLine(longNum);
            
            float floatNum = 3.92F; //ao declarar uma variável do tipo float, deve-se terminar o valor com "F" no final
            Console.WriteLine(floatNum);
            
            double doubleNum = 17.33D; //ao declarar uma variável do tipo double, deve-se terminar o valor com "D" no final
            Console.WriteLine(doubleNum);
            
            /*Variáveis do tipo float possuem entre 6 e 7 digitos decimais. Variáveis do tipo double possuem 15. Por conta disso, é 
              preferível usar double para a maioria dos calculos.*/
        }
    }
}