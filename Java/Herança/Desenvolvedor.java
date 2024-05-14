class Desenvolvedor extends Funcionário{
    private String linguagemDeProgramação;
    
    public Desenvolvedor(String nome, String endereço, String cargo, double salário, String linguagemDeProgramação){
        super(nome, endereço, cargo, salário);
        this.linguagemDeProgramação = linguagemDeProgramação;
    }
    
    public String getLinguagemProgramação(){return linguagemDeProgramação;}
    
    public void desenvolverProjeto(){
        System.out.println(getNome() + "está desenvolvendo projeto na linguagem " + getLinguagemProgramação());
    }
    
    public double calculoBonus(){return getSalário() * 0.12;}
    public String gerarAnálise(){return ("Gerando análise do desenvolvedor " + getNome() + ": Ótimo!!");}
}