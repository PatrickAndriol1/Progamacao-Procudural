using System;

class Program 
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 5;
        bool[,] vagas = new bool[TAMANHO_MATRIZ, TAMANHO_MATRIZ];
        PreencherMatriz(vagas);
        int vagasLivres = VerificarVagasLivres(vagas);
        System.Console.WriteLine($"Existem {vagasLivres} vagas livres");
    }

    static void PreencherMatriz(bool[,] vagas)
    {
        for(int i = 0; i < vagas.GetLength(0); i++)
        {
            for (int j = 0; j < vagas.GetLength(1); j++)
            {
                vagas[i,j] = Convert.ToBoolean(Console.ReadLine());
            }
        }
    }

    static int VerificarVagasLivres(bool[,] vagas)
    {
        int vagasLivres = 0;
        for (int i = 0; i < vagas.GetLength(0); i++)
        {
            for (int j = 0; j < vagas.GetLength(1); j++)
            {
                if(vagas[i,j] == false)
                {
                    vagasLivres++;
                }
            }
        }
        return vagasLivres;
    }
}