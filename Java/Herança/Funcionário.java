class Funcionário{
    private String nome, endereço, cargo;
    private double salário;
    
    public Funcionário(String nome, String endereço, String cargo, double salário){
        this.nome = nome;
        this.endereço = endereço;
        this.cargo = cargo;
        this.salário = salário;
    }
    
    public String getNome(){return nome;}
    public String getEndereço(){return endereço;}
    public String getCargo(){return cargo;}
    public double getSalário(){return salário;}
    
    public double calculoBonus(){return getSalário() * 0.0;}
    public String gerarAnálise(){return ("Gerando análise como empregado...");}
}