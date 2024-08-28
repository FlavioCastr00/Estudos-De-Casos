using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {1, 2, 3, 4, 5};
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(array[i]);
        }
        
        try //tenta executar este bloco de código e "joga" uma exceção, se acaso for encontrada.
        {
            Console.WriteLine(array[7]);    
        }
        catch (IndexOutOfRangeException ex) //"pega" a exceção "jogada" do tipo específico e mostra o erro para o usuário:
        {
            Console.WriteLine($"Uma exceção ocorreu: {ex.Message}");
        }
    }
}