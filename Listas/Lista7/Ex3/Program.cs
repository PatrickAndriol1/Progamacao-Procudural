using System;

class Program
{
	public static void Main(string[] args)
	{
		int idade = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(ClassificarNadador(idade));
	}
	
	static string ClassificarNadador(int idade)
	{
		if(idade < 12)
		{
			return "Infantil";
		}
		else if(idade < 15)
		{
			return "Juvenil A";
		}
		else if(idade < 18)
		{
			return "Juvenil B";
		}
		else
		{
			return "Adulto";
		}
	}
}