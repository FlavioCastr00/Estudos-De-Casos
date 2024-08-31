using System;

namespace UserInput
{
    class Programa
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Digie o seu nome: ");
            string nome = Console.ReadLine(); //o comando "Console.ReadLine()" é usado para inputs, retornando uma string
            Console.WriteLine("Olá, " + nome + "!!!");
            
            Console.WriteLine("Digite a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine()); //para obter valores de outros tipos, precisamos convertê-los
            Console.WriteLine("Então, seu nome é " + nome + " e você tem " + idade + " anos, ok!");
        }
    }
}