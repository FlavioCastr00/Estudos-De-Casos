/*Escreva um programa que receba dois números e imprima "True" se um deles for negativo e o outro positivo.*/
using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite dois números:");
    int n1 = Convert.ToInt32(Console.ReadLine());
    int n2 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Checando se há um numero negativo e outro positivo: ");
    Console.WriteLine((n1 > 0 && n2 < 0) || (n1 < 0 && n2 > 0));
  }
}