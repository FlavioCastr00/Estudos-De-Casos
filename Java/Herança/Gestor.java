class Gestor extends Funcionário{
    
    private int numeroDeFuncionários;
    
    public Gestor(String nome, String endereço, String cargo, double salário, int numeroDeFuncionários){
        super (nome, endereço, cargo, salário);
        this.numeroDeFuncionários = numeroDeFuncionários;
    }
    
    public int getNumFuncionários(){return numeroDeFuncionários;}
    
    public void gestarProjeto(){
        System.out.println(getNome() + "está gestando o projeto...");
    }
    
    public double calculoBonus(){return getSalário() * 0.15;}
    public String gerarAnálise(){return ("Gerando análise do gestor " + getNome() + ": muito bom!");}
}