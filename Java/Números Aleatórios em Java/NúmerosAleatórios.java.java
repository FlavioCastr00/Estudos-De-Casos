import java.util.Random;

public class NúmerosAleatórios
{
    public static void main(String[] args)
    {
        Random rand = new Random();
        
        //Gerando um número inteiro aleatório
        System.out.println("Inteiro aleatório gerado: " + rand.nextInt(100));
        
        //Gerando um número do tipo double aleatório
        System.out.println("Double aleatório gerado: " + rand.nextDouble() * 100);
    }
}