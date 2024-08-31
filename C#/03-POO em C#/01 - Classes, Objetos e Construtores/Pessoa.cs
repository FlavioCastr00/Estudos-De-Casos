class Pessoa //uma classe funciona como um "blueprint" para a criação de objetos
{
    //Atributos:
    private string pessoaNome;
    private int pessoaIdade;
    
    public Pessoa(string nome, int idade) //construtores são métodos especiais usados na inicialização do objeto
    {
        pessoaNome = nome;
        pessoaIdade = idade;
    }
    
    //Métodos
    public string getNome()
    {
        return pessoaNome;
    }
    
    public int getIdade()
    {
        return pessoaIdade;
    }
}
