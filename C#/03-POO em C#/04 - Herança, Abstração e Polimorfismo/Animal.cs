using System;

/*Uma classe abstrata não pode ser usada para criar objetos.
Para que suas propriedades e métodos sejam usados ela deve ser herdada por outras classes*/

abstract class Animal 
{
    //O modificador de acesso "protected" da acesso apenas à própria classe e às classes herdadas
    protected string nome;
    protected int idade;
    
    public Animal(string nome, int idade) //Este constutor sofrerá "override" para atender outras propriedades
    {
        this.nome = nome;
        this.idade = idade;
    }
    
    //Métodos do tipo "abstract" não possuem um "corpo" e devem sofrer "override" nas classes herdadas para terem uma função.
    public abstract void Apresentar();
    public abstract string Falar();
}