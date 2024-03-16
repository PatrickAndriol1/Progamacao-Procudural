using System;

class Program
{
	static void Main(string[] args)
	{
		for(int tempo = 120; tempo >= 0; tempo--)
		{
		  int minuto = tempo / 60;
		  int segundo = tempo % 60;
		  
		  Console.WriteLine($"{minuto}:{segundo}");
		}
	}
}
