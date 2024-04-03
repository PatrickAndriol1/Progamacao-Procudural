using System;

class Program
{
	public static void Main(string[] args)
	{
		int num = Convert.ToInt32(Console.ReadLine());
		bool resultado = VerificarPar(num);
		Console.WriteLine(resultado);
	}
	
	static bool VerificarPar(int numero)
  {
    bool ehPar = false;
    if(numero % 2 == 0)
    {
      ehPar = true;
    }
    return ehPar;
  }
}