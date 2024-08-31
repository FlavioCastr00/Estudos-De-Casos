using System;

namespace TypeCasting
{
    class Programa
    {
        static void Main(String[] args)
        {
            //Implicito (feito automáticamente, passando de um tipo com menos números decimais para outro com mais):
            int intNum1 = 44;
            double doubleNum1 = intNum1; //Tipo automático de casting (int para double)
            Console.WriteLine("Inteiro: " + intNum1 + " - Double: " + doubleNum1);
            
            //Explicito (feito manualmente, usando parenteses entre e o tipo de variável antes de passar o valor):
            double doubleNum2 = 33.33;
            int intNum2 = (int) doubleNum2; //Tipo manual de casting (double para int)
            Console.WriteLine("Inteiro: " + intNum2 + " - Double: " + doubleNum2);
            
            //Convertendo valores usando métodos:
            int intNum3 = 12;
            double doubleNum3 = 3.11;
            bool booleano = false;
            
            Console.WriteLine(Convert.ToString(intNum3));    //converte int para string
            Console.WriteLine(Convert.ToDouble(intNum3));    //converte int para double
            Console.WriteLine(Convert.ToInt32(doubleNum3));  //converte double para int
            Console.WriteLine(Convert.ToString(booleano));   //converte bool para string
        }
    }
}