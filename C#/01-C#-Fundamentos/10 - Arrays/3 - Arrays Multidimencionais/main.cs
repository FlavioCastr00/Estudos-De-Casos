using System;

namespace ArraysMultidimencionais
{
    class Program
    {
        static void Main(String[] args)
        {
            //Lembre-se: Array Multidimencional = Matriz
            int[,] matriz = new int[2, 3]; //cria uma matriz vazia
            
            //para percorrer a matriz precisamos usar dois "for()":
            for (int i = 0; i < matriz.GetLength(0); i++) //este "for()" indica a linha da matriz
            {
                for (int z = 0; z < matriz.GetLength(1); z++) //este "for()" indica a coluna da matriz
                {
                    matriz[i, z] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Imprimindo a matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int z = 0; z < matriz.GetLength(1); z++)
                {
                    Console.Write($"{matriz[i, z]} ");
                }
                Console.Write("\n");
            }
        }
    }
}