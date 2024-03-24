using System;

class Program
{
	static void Main(string[] args)
	{
		string[,] dados = new string[4,3];
		
		for(int i = 0; i < 4; i++)
		{
		  for(int j = 0; j < 3; j++)
		  {
		    dados[i,j] = Console.ReadLine();
		  }
		}
		
		for(int i = 3; i >=0; i--)
		{
		  for(int j = 0; j < 3; j++)
		  {
		    Console.WriteLine(dados[i,j]);
		  }
		}
	}
}