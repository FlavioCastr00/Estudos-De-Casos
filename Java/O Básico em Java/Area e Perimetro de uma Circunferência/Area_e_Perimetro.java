import java.util.Scanner; //Importa a classe Scanner

public class Area_e_Perimetro
{
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        float raio;
        
        System.out.print("Digite o raio da circunferência: ");
        raio = scan.nextFloat(); //lê input do usuário
        
        System.out.println("O perimetro é: " + 2.0 * Math.PI * raio + "\nA área é: " + Math.PI * (raio * raio));
        
    }
}