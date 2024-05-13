import java.util.Scanner;

public class Main{
    public static void main(String[] avgs){
        Scanner scan = new Scanner(System.in);
        
        aluno a1 = new aluno(); //Cria o objeto dentro da classe Main.
        
        //Utilização dos métodos da classe:
        a1.set_id(107);
        
        System.out.print("Digite o nome do aluno: ");
        a1.set_nome(scan.nextLine());
        
        System.out.println("Digite três notas:");
        for(int i = 0; i < 3; i++){
         a1.set_notas(scan.nextDouble());
        }
        
        System.out.println("\nId: " + a1.get_id() + "\nNome: " + a1.get_nome() + "\nNotas: " + a1.get_notas());
    }
}