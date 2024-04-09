using System;

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        String[,] acentos = new String[4,4];
        PreencherMatriz(acentos);
        ImprimirMatriz(acentos);
    }

    static void PreencherMatriz(String[,] acentos)
    {
        for(int i = 0; i < acentos.GetLength(0); i++)
        {
            for(int j = 0; j < acentos.GetLength(1); j++)
            {
                if(i == 0)
                {
                    acentos[i,j] = "Vip";
                }
                if(i > 0)
                {
                    acentos[i,j] = "Associado";
                }
                if(i == j)
                {
                    acentos[i,j] = "Sorteado";
                }
            }
        }
    }

    static void ImprimirMatriz(String[,] acentos)
    {
        for (int i = 0; i < acentos.GetLength(0); i++)
        {
            for (int j = 0; j < acentos.GetLength(1); j++)
            {
                System.Console.Write(acentos[i,j] + " ");
            }
            System.Console.WriteLine();
        }
    }
}