using System;

class Program
{
	static void Main(string[] args)
	{
	  const int TAMANHO = 4;
		int[,] numero = new int[TAMANHO, TAMANHO];
		int soma = 0;
		
		for(int i = 0; i < TAMANHO; i++)
		{
		  for(int j = 0; j < TAMANHO; j++)
		  {
		    numero[i,j] = int.Parse(Console.ReadLine());
		    soma += numero[i,j];
		  }
		}
		
		Console.WriteLine("A soma de todos os elementos da matriz eh: " + soma);
	}
}