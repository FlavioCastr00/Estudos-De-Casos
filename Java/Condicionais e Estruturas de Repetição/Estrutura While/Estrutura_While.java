import java.util.Random;
import java.util.Scanner;

public class Estrutura_While
{
    public static void main(String[] args)
    {
        Random rand = new Random();
        Scanner scan = new Scanner(System.in);
        
        int número = 0, numEscolhido;
        
        System.out.print("Escolha um número de 0 a 10: ");
        numEscolhido = scan.nextInt();
        
        //Estrutura de repetição while:
        while (número != numEscolhido)
        {
            número = rand.nextInt(11);
            System.out.println(número);
        }
    }
}