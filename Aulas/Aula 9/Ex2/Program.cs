using System;

class Program
{
	static void Main(string[] args)
	{
	  int positivo = 0;
	  int negativo = 0;
	  int zero = 0;
	  
		for(int i = 0; i < 10; i++)
		{
		  int n = int.Parse(Console.ReadLine());
		  
		  if (n > 0)
		  {
		    positivo++;
		  }
		  else if(n < 0)
		  {
		    negativo++;
		  }
		  else
		  {
		    zero++;
		  }
		}
		
		Console.WriteLine("Numeros positivos: " + positivo);
		Console.WriteLine("Numeros negativos: " + negativo);
		Console.WriteLine("Zero(s): " + zero);
	}
}
