using System;
using System.Linq; //implementa o "System.Linq" namespace

namespace OrdenandoArrays
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] arrayNumeros = new int[5];
            
            Console.WriteLine("Escreva cinco números para preencher o Array:");
            for (int i = 0; i < arrayNumeros.Length; i++) //carrega o array através da estrutura "for()"
            {
              arrayNumeros[i] = Convert.ToInt32(Console.ReadLine());  
            }
            
            Console.WriteLine($"Maior número: {arrayNumeros.Max()}"); //retorna o maior número no Array
            Console.WriteLine($"Menor número: {arrayNumeros.Min()}"); //retorna o menor número no Array
            Console.WriteLine($"Soma de todos os números: {arrayNumeros.Sum()}"); //retorna a soma de todos os elementos do Array
        }
    }
}