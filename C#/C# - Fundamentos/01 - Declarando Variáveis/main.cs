using System;

namespace TiposPrimitivos
{
    class Programa
    {
        static void Main(String[] args)
        {
            //Variáveis de tipo primitivos:
            string primeiroNome = "John ";
            string ultimoNome = "Marston";
            string nomeCompleto = primeiroNome + ultimoNome;
            int idade = 28;
            int x = 7, y = 15; 
            double numeroDouble = 13.45;
            const char caractere = 'Y'; //"const" declara a variável como constante
            bool booleano = true;
            
            //Chamando variáveis em um comando Console.WriteLine():
            Console.WriteLine("Nome: " + nomeCompleto + " - Idade: " + idade);
            Console.WriteLine("\nSoma x + y: " + (x + y) +
                              "\nNúmero double: " + numeroDouble +
                              "\nCaractere: " + caractere +
                              "\nValor booleano: " + booleano);
        }
    }
}