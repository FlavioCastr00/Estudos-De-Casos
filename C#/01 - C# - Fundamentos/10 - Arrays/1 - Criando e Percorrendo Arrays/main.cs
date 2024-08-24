using System;

namespace Arrays
{
    class Program
    {
        static void Main(String[] args)
        {
            //cria um array com um número determinado de elementos, neste caso cinco
            int[] números = new int[5]{1, 2, 3, 4, 5};
            //array sem um número determinado de elementos
            string[] times = new string[]{"Red Bull", "Mercedes", "Ferrari", "Aston Martin", "Williams"};
            
            //percorrendo um array usando "for()":
            for (int i = 0; i < números.Length; i++) //cada elemento de um array é agregado a um índice, neste caso "i" representa este índice
            {
                Console.WriteLine(números[i]);
            }
            
            //percorrendo um array usando "foreach()":
            foreach (string w in times) //executa o bloco de código para cada elemento do array
            {
                Console.WriteLine(w);
            }
        }
    }
}