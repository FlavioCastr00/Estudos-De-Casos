import java.util.Scanner;
import java.util.Arrays;

public class Invertendo_Elementos_De_Um_Array
{
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        
        int tamanho;
        
        System.out.print("Defina o tamanho do array: ");
        tamanho = scan.nextInt();
        
        int array[] = new int[tamanho];
        int novoArray[] = new int[tamanho];
        
        for (int i = 0; i < tamanho; i++)
        {
            array[i] = scan.nextInt();
        }
        
        for (int i = 0; i < tamanho; i++)
        {
            if (i == 0)
            {
                novoArray[i] = array[array.length - 1];
            }
            else
            {
                if (i == tamanho - 1)
                {
                    novoArray[i] = array[0];
                }
                else
                {
                    novoArray[i] = array[i];
                }
            }
        }
        
        System.out.println("Array original: " + Arrays.toString(array));
        System.out.println("Array copiado com primeiro e último elementos invertidos: " + Arrays.toString(novoArray));
    }
}