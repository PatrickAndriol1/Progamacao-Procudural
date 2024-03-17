using System;

class Program
{
	static void Main(string[] args)
	{
		for(int i = 1; i <= 9; i++)
		{
		  for(int j = 9; j >= i; j--)
		  {
		    Console.Write("*");
		  }
		  Console.WriteLine();
		}
	}
}