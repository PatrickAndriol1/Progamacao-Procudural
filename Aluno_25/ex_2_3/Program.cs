using System;

public struct Jogador
{
    public String nome;
    public double rating;
}

class Program
{
    const int NUMERO_JOGADORES = 5;
    static void Main(string[] args)
    {
        Jogador[] jogadores = new Jogador[NUMERO_JOGADORES];
        ReceberDados(jogadores);
        CalcularMediaRating(jogadores);
        EscolherMelhorJogador(jogadores);
        CalcularMenorRating(jogadores);
    }

    static void ReceberDados(Jogador[] jogadores)
    {
        for(int i = 0; i < NUMERO_JOGADORES; i++)
        {
            jogadores[i].nome = Console.ReadLine();
            jogadores[i].rating = Convert.ToDouble(Console.ReadLine());
        }
    }

    static void CalcularMediaRating(Jogador[] jogadores)
    {
        double somatorio = 0;
        for(int i = 0; i < NUMERO_JOGADORES; i++)
        {
            somatorio += jogadores[i].rating;
        }
        double media = somatorio / NUMERO_JOGADORES;
        System.Console.WriteLine("Media de rating: " + Math.Round(media, 1));
    }

    static void EscolherMelhorJogador(Jogador[] jogadores)
    {
        int melhorJogador = 0;
        double rating = int.MinValue;
        for(int i = 0; i < NUMERO_JOGADORES; i++)
        {
            if(jogadores[i].rating > rating)
            {
                rating = jogadores[i].rating;
                melhorJogador = i;
            }
        }
        System.Console.WriteLine("Primeiro tabuleiro: " + jogadores[melhorJogador].nome);
    }

    static void CalcularMenorRating(Jogador[] jogadores)
    {
        double menor = int.MaxValue;
        for(int i = 0; i < NUMERO_JOGADORES; i++)
        {
            if(jogadores[i].rating < menor)
            {
                menor = jogadores[i].rating;
            }
        }
        System.Console.WriteLine("Menor rating: " + menor);
    }
}