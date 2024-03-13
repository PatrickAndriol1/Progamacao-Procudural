using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();

        const int FILEIRA0 = 0;

        const int FILEIRA7 = 7;

        for(int linha = FILEIRA0; linha <= FILEIRA7; linha++)
        {
            for(int coluna = FILEIRA0; coluna <= FILEIRA7; coluna++)
            {
                if(linha == FILEIRA0 || linha == FILEIRA7 || coluna == FILEIRA0 || coluna == FILEIRA7)
                {
                    Tabuleiro.Adicionar(linha, coluna, "s");
                }
            }
        }

        Tabuleiro.ImprimeTabuleiro();
    }
}