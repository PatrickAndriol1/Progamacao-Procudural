using System;

class Program
{
	public static void Main(string[] args)
	{
	    const int TAMANHO_TABULEIRO = 4;
		int[,] tabuleiro = new int[TAMANHO_TABULEIRO, TAMANHO_TABULEIRO];
		PreencherTabuleiro(tabuleiro);
		if(VerificarBalista(tabuleiro))
		{
		    Console.WriteLine("Fique atento! existem balistas no tabuleiro");
		}
		else
		{
		    Console.WriteLine("nao ha balistas no tabuleiro");
		}
	}
	
	static void PreencherTabuleiro(int[,] matriz)
	{
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
	}
	
	static bool VerificarBalista(int[,] matriz)
	{
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                if(matriz[i,j] == 0)
                {
                    return true;
                }
            }
        }
        return false;
	}
}