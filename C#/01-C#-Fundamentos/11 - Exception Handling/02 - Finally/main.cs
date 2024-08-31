using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {45, 0, 14, 7};
        
        try
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i] / array[i + 1]);
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Uma exceção ocorreu: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Uma exceção ocorreu: {ex.Message}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Uma exceção ocorreu: {ex.Message}");
        }
        finally //executa este bloco de código independente de uma exceção ter sido criada ou não.
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
        }
    }
}