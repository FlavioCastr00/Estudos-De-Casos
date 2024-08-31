// See https://aka.ms/new-console-template for more information

class Program
{
    static string CalcularMédia(double n1, double n2, double n3) //Cria a função e define seus parâmetros. NOTE: "string" significa que esta função deverá retornar uma string.
    {
        double média = (n1 + n2 + n3) / 3;
        
        if (média >= 6)
        {
            return "Média: " + média + "\nAprovado!!"; //retorna o valor
        }
        else
        {
            return "Média: " + média + "Reprovado :()"; //retorna o valor
        }
    }

    
    static void Main(string[] args)
    {
        Console.WriteLine("Digite as três notas do aluno:");

        double nota1 = Convert.ToDouble(Console.ReadLine());
        double nota2 = Convert.ToDouble(Console.ReadLine());
        double nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(CalcularMédia(nota1, nota2, nota3)); //chamando a função dentro do código "Main()". Os parâmetros devem ser atribuidos durante a chamada.
    }
}