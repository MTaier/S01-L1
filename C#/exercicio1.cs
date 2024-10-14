using System;

public class Cachorro
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Cachorro(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void MostrarNome()
    {
        Console.WriteLine(Nome);
    }

    public virtual void MostrarIdade()
    {
        Console.WriteLine(Idade);
    }
}

public class CachorroPequeno : Cachorro
{
    public CachorroPequeno(string nome, int idade) : base(nome, idade) { }

    public override void MostrarIdade()
    {
        Console.WriteLine($"{Idade} anos");
    }
}

public class CachorroGrande : Cachorro
{
    public string Tamanho { get; private set; } = "0";

    public CachorroGrande(string nome, int idade) : base(nome, idade) { }

    public override void MostrarIdade()
    {
        Console.WriteLine($"{Idade} anos");
    }

    public void DefinirTamanho(string tamanho)
    {
        Tamanho = tamanho;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var cachorro = new Cachorro("Nala", 3);
        cachorro.MostrarNome();
        cachorro.MostrarIdade();

        var cachorroPequeno = new CachorroPequeno("Thor", 7);
        cachorroPequeno.MostrarNome();
        cachorroPequeno.MostrarIdade();

        var cachorroGrande = new CachorroGrande("Rex", 9);
        cachorroGrande.MostrarNome();
        cachorroGrande.MostrarIdade();

        Console.WriteLine(cachorroGrande.Tamanho);
        cachorroGrande.DefinirTamanho("Grande");
        Console.WriteLine(cachorroGrande.Tamanho);
    }
}
