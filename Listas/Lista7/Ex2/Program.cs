using System;

class Program
{
	public static void Main(string[] args)
	{
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		int num3 = Convert.ToInt32(Console.ReadLine());
		int resultado = VerificarMaior(num1, num2, num3);
		Console.WriteLine(resultado);
	}

	static int VerificarMaior(int num1, int num2, int num3)
	{
		int maiorValor = Int32.MinValue;
		if(num1 > num2 && num1 > num3)
		{
			maiorValor = num1;
		}
		else if(num2 > num1 && num2 > num3)
		{
			maiorValor = num2;
		}
		else
		{
			maiorValor = num3;
		}
		return maiorValor;
	}
}