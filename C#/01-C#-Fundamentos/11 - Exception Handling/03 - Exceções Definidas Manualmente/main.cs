using System;

class Program
{
    //Método pra a divisão:
    double Divisão(double numerador, double denominador)
    {
        if (denominador == 0) //"joga" uma exceção quando o denominador é igual a zero.
        {
            throw new DivisãoPorZero();
        }
        else
        {
            return numerador / denominador;
        }
    }
    //código Main:
    static void Main(string[] args)
    {
        Program obj = new Program();
        double num = 32, den = 0, coeficiente;
        
        try //bloco de código que pode causar uma exceção:
        {
            coeficiente = obj.Divisão(num, den);
            Console.WriteLine("O coeficiente é " + coeficiente);    
        }
        catch (Exception ex) //"pega" a exceção:
        {
            Console.Write(ex.Message);
        }
    }
}