import java.util.Scanner;

public class Conversão_Binarios
{
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        int numero, ponteiro = 0, aux;
        int sobra[] = new int[100];
        
        System.out.println("Qual número deseja converter?");
        numero = scan.nextInt();
        
        while (numero != 0)
        {
            sobra[ponteiro] = numero % 2;
            numero = numero / 2;
            ponteiro ++;
        }
        
        System.out.print("O número em binario é: ");
        for (aux = ponteiro - 1; aux > -1; aux--)
        {
            System.out.print(sobra[aux]);
        }
    }
}