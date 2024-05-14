class Programador extends Desenvolvedor{
    public Programador(String nome, String endereço, String cargo, double salário, String linguagemDeProgramação){
        super(nome, endereço, cargo, salário, linguagemDeProgramação);
    }
    
    public void debugProjeto(){
        System.out.println(getNome() + "está performando debugging de um projeto na linguagem " + getLinguagemProgramação());
    }
    
    public double calculoBonus(){return getSalário() * 0.10;}
    public String gerarAnálise(){return ("Gerando análise do programador " + getNome() + ": Excelente!!");}
}