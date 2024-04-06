using System;

struct Jogo
{
    public int id;
    public String nome;
    public double preco;
}

class Program
{
	public static void Main(string[] args)
	{
        Jogo jogo1 = new Jogo();
        jogo1 = LerDados(jogo1);
        ImprimirDados(jogo1);
	}
	
	static Jogo LerDados(Jogo jogo1)
	{
        jogo1.id = Convert.ToInt32(Console.ReadLine());
        jogo1.nome = Console.ReadLine();
        jogo1.preco = Convert.ToDouble(Console.ReadLine());
        return jogo1;
	}
	
	static void ImprimirDados(Jogo jogo1)
	{
        Console.WriteLine(jogo1.id);
        Console.WriteLine(jogo1.nome);
        Console.WriteLine(jogo1.preco);
	}
}