using System;

//Exceção definida manualmente. Herda a classe "Exception".
class DivisãoPorZero : Exception
{
    public DivisãoPorZero() //construtor
    {
        Console.WriteLine("Uma exceção ocorreu: ");
    }
}