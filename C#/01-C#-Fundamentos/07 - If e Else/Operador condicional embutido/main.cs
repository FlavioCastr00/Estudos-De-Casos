using System;

class HelloWorld 
{
  static void Main() 
  {
      Console.Write("Input the value: ");
      double value = Convert.ToDouble(Console.ReadLine());
      
      //Operador condicional embutido na variável:
      double discount = value > 1000 ? 100 : 50;
      value -= discount;
      
      Console.WriteLine($"Dicsount: {discount}$\nFinal Price: {value}$");
  }
}