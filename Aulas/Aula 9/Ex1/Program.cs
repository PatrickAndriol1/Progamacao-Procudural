using System;

class Program
{
	static void Main(string[] args)
	{
		const int MAXIMO = 50;
		const int MINIMO = 0;
		
		int i = MINIMO;
		int j = MAXIMO;
		
		while(i <= MAXIMO && j >= MINIMO)
		{
		  Console.WriteLine($"{i} - {j}");
		  i++;
		  j--;
		}
	}
}
