using System;

class Program
{
	static void Main(string[] args)
	{
		char[,] letras = new char[3,3];
		
		for(int i = 0; i < 3; i++)
		{
		  for(int j = 0; j < 3; j++)
		  {
		    letras[i,j] = char.Parse(Console.ReadLine());
		  }
		}

        for(int i = 2; i >= 0; i--)
		{
		  for(int j = 2; j >=0; j--)
		  {
		    Console.WriteLine(letras[i,j]);
		  }
        Console.WriteLine();
		}
	}
}