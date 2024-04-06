using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO = 3;
        char[,] tabuleiro = new char[TAMANHO, TAMANHO];
        InicializarTabuleiro(tabuleiro);
        ImprimirTabuleiro(tabuleiro);
        for(int i = 0; i < 5; i++)
        {
            RealizarJogada(tabuleiro, 1);
            ImprimirTabuleiro(tabuleiro);
            RealizarJogada(tabuleiro, 2);
            ImprimirTabuleiro(tabuleiro);
        }
    }

    static void InicializarTabuleiro(char[,] tabuleiro)
    {
        for(int linha = 0; linha < tabuleiro.GetLength(0); linha++)
        {
            for(int coluna = 0; coluna < tabuleiro.GetLength(1); coluna++)
            {
                tabuleiro[linha, coluna] = '-';
            }
        }
    }

    static void ImprimirTabuleiro(char[,] tabuleiro)
    {
        for(int linha = 0; linha < tabuleiro.GetLength(0); linha++)
        {
            for(int coluna = 0; coluna < tabuleiro.GetLength(1); coluna++)
            {
                System.Console.Write(tabuleiro[linha, coluna]);
            }
            System.Console.WriteLine();
        }
    }

    static bool RealizarJogada(char[,] tabuleiro, int idJogador)
    {
        int linha = 0;
        int coluna = 0;
        System.Console.WriteLine("Coordenadas da jogada: ");
        do
        {
            linha = Convert.ToInt32(Console.ReadLine());
            coluna = Convert.ToInt32(Console.ReadLine());
            if(linha >= 0 && linha <= 2 && coluna >= 0 && coluna <= 2 && tabuleiro[linha, coluna] == '-')
            {
                break;
            }
            System.Console.WriteLine("Jogada inválida, tente novamente...");
        }
        while(true);
        System.Console.WriteLine("Jogada válida: ");
        if(idJogador == 1)
        {
            tabuleiro[linha, coluna] = 'X';
        }
        else
        {
            tabuleiro[linha, coluna] = 'O';
        }
        return VerificarVitoria(tabuleiro);
    }

    static bool VerificarVitoria(char[,] tabuleiro)
    {
        if(tabuleiro[0,0] == tabuleiro[0,1] && tabuleiro[0,0] == tabuleiro[0,2] && tabuleiro[0,0] != '-')
        {
            return true;
        }
        if(tabuleiro[1,0] == tabuleiro[1,1] && tabuleiro[1,0] == tabuleiro[1,2] && tabuleiro[1,0] != '-')
        {
            return true;
        }
        if(tabuleiro[2,0] == tabuleiro[2,1] && tabuleiro[2,0] == tabuleiro[2,2] && tabuleiro[2,0] != '-')
        {
            return true;
        }
        if(tabuleiro[0,0] == tabuleiro[1,0] && tabuleiro[0,0] == tabuleiro[2,0] && tabuleiro[0,0] != '-')
        {
            return true;
        }
        if(tabuleiro[0,1] == tabuleiro[1,1] && tabuleiro[0,1] == tabuleiro[2,1] && tabuleiro[0,1] != '-')
        {
            return true;
        }
        if(tabuleiro[0,2] == tabuleiro[1,2] && tabuleiro[0,2] == tabuleiro[2,2] && tabuleiro[0,2] != '-')
        {
            return true;
        }
        if(tabuleiro[0,0] == tabuleiro[1,1] && tabuleiro[0,0] == tabuleiro[2,2] && tabuleiro[0,0] != '-')
        {
            return true;
        }
        if(tabuleiro[0,2] == tabuleiro[1,1] && tabuleiro[0,2] == tabuleiro[2,0] && tabuleiro[0,2] != '-')
        {
            return true;
        }
        return false;
    }
}