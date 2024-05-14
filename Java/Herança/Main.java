public class Main{
    public static void main(String[] args){
        
        Gestor g1 = new Gestor("Daniela", "Rua A.", "Gestora", 8240.0, 6);
        Desenvolvedor d1 = new Desenvolvedor("Alan", "Rua B.", "Desenvolvedor", 3455.0, "Java");
        Programador p1 = new Programador("Renato", "Rua C.", "Programador", 2774.0, "Python");
        
        System.out.println("Bonus do gestor: " + String.format("%.2f", g1.calculoBonus()));
        System.out.println("Bonus do desenvolvedor: " + String.format("%.2f", d1.calculoBonus()));
        System.out.println("Bonus do programador: " + String.format("%.2f", p1.calculoBonus()));
        
        System.out.println("\n" +g1.gerarAnálise());
        System.out.println(d1.gerarAnálise());
        System.out.println(p1.gerarAnálise() + "\n");
        
        g1.gestarProjeto();
        d1.desenvolverProjeto();
        p1.debugProjeto();
    }
}
