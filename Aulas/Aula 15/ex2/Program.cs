using System;

struct Enxadrista
{
    public int id;
    public String nome;
    public int rating;
}

class Program
{
	static void Main(string[] args)
	{
        const int TAMANHO_VETOR = 4;
        Enxadrista[] enxadristas = new Enxadrista[TAMANHO_VETOR];
        PreencherVetor(enxadristas);
        ImprimirVetor(enxadristas);
	}

    static void PreencherVetor(Enxadrista[] enxadristas)
    {
        for(int i = 0; i < enxadristas.Length; i++)
        {
            enxadristas[i].id = Convert.ToInt32(Console.ReadLine());
            enxadristas[i].nome = Console.ReadLine();
            enxadristas[i].rating = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void ImprimirVetor(Enxadrista[] enxadristas)
    {
        for(int i = enxadristas.Length - 1; i >= 0 ; i--)
        {
            System.Console.WriteLine(enxadristas[i].id);
            System.Console.WriteLine(enxadristas[i].nome);
            System.Console.WriteLine(enxadristas[i].rating);
        }
    }
}