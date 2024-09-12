using System;

class HelloWorld
{
  static void Main()
  {
    string[] values = {"12.3", "45", "ABC", "11", "DEF"};
    double sum = 0, number;
    string message = "";
    
    foreach (string element in values)
    {
        if (double.TryParse(element, out number))
        {
            sum = sum + number;
        }
        else
        {
            message = message + element;
        }
    }
    
    Console.WriteLine($"Message: {message}\nTotal: {sum}");
  }
}