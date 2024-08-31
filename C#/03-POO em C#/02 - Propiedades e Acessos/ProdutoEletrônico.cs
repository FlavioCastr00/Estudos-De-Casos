class ProdutoEletrônico
{
    //acessos privados podem ser acessados pela própria classe ou por classes que são herdadas da classe original
    private int produtoID;
    //acessos públicos podem ser acessadas por todas as classes
    public string produtoNome;
    public double produtoPreço;
    
    public ProdutoEletrônico(int ID, string nome, double preço)
    {
        produtoID = ID;
        produtoNome = nome;
        produtoPreço = preço;
    }
    
    //Métodos:
    public string Detalhes()
    {
        return "ID: " + produtoID + " - Nome: " + produtoNome + " - Preço: " + produtoPreço;
    }
    
    public double FazerDesconto(double desconto)
    {
        return produtoPreço - (produtoPreço * desconto);
    }
}