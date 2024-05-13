import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;

class aluno{
    Scanner scan_aluno = new Scanner(System.in);
    
    //variáveis privadas da classe:
    private int id;
    private String nome;
    private List notas = new ArrayList<>();
    
    //métodos getters e setters da classe:
    public int get_id() {return id;}
    public void set_id(int id) {this.id = id;}
    
    public String get_nome() {return nome;}
    public void set_nome(String nome) {this.nome = nome;}
    
    public List get_notas() {return notas;}
    
    public void set_notas(double nota) {
        if (nota < 0 || nota > 10){
            while (nota < 0 || nota > 10){
                System.out.println("Nota inválida! Digite novamente: ");
                nota = scan_aluno.nextDouble();
            }
            notas.add(nota);
        }
        else{
            notas.add(nota);
        }
        System.out.println("Nota adcionada!!");
    }
}