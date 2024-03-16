using System;

class Program
{
	static void Main(string[] args)
	{
		int numero = int.Parse(Console.ReadLine());
		
		if (numero == 0)
		{
		  Console.WriteLine("nada a fazer aqui");
		}
		else if(numero > 0)
		{
		  int impar = 0;
		  for (int i = 1; i <= numero; i++)
		  {
		    if (i % 2 == 1)
			  {
			    impar += i;
			  }
		  }
		  Console.WriteLine("O somatorio de todos numeros impares eh: " + impar);
		}
		else
		{
		  for(int i = 0; i >= numero; i--)
		  {
		    if(i % 2 == 0)
		    {
		      Console.WriteLine(i);
		    }
		  }
		}
	}
}
