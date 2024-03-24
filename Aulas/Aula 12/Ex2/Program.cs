using System;

class Program
{
	static void Main(string[] args)
	{
		const int TAMANHO = 8;
		int[,] matriz = new int[TAMANHO,TAMANHO];
		
		for(int i = 0; i < TAMANHO; i++)
		{
		  matriz[i,i] = 1;
		}
		
		for(int i = 0; i < TAMANHO; i++)
		{
		  for(int j = 0; j < TAMANHO; j++)
		  {
		    Console.Write(matriz[i,j]);
		  }
		  Console.WriteLine();
		}
	}
}