using System;

namespace IfElse
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Digite uma letra: ");
            char letra = Convert.ToChar(Console.ReadLine());
            
            //Verifica condição:
            if (letra >='A' && letra <= 'Z') //se a condição for atendida...
            {
                Console.WriteLine("A letra está em Caixa Alta"); //executa este bloco de código.
            }
            else if (letra >= 'a' && letra <= 'z') //caso contrário...
            {
                Console.WriteLine("A letra está em Caixa Baixa"); //executa este outro bloco de código.
            }
        }
    }
}