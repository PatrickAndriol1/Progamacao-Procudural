using System;

class Program
{
	public static void Main(string[] args)
	{
	    const int TAMANHO_TREM = 12;
        int[] trem = new int[TAMANHO_TREM];
        PreencherVagoes(trem);
        VerificarPesoVagoes(trem);
	}
	
	static void PreencherVagoes(int[] trem)
	{
        for(int i = 0; i < trem.Length; i++)
        {
            trem[i] = Convert.ToInt32(Console.ReadLine());
        }
	}
	
	static void VerificarPesoVagoes(int[] trem)
	{
        const int CARGA_MAXIMA = 50;
        for(int i = 0; i < trem.Length; i++)
        {
            if(trem[i] > CARGA_MAXIMA)
            {
                Console.WriteLine((i + 1) + "° vagao ultrapassou o limite de peso");
            }
        }
	}
}
