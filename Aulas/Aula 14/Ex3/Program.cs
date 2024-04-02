using System;

class Program
{
	public static void Main(string[] args)
	{
		int[] exercitoA = new int[5];
		int[] exercitoB = new int[5];
		
		PosicionarExercito(exercitoA);
		PosicionarExercito(exercitoB);
		
		Batalhar(exercitoA, exercitoB);
		
		Imprimir(exercitoA);
		Imprimir(exercitoB);
		
		Vencedor(exercitoA, exercitoB);
	}
	
	static void PosicionarExercito(int[] exercito)
	{
	  for(int i = 0; i < exercito.GetLength(0); i++)
	  {
	    exercito[i] = Convert.ToInt32(Console.ReadLine());
	  }
	}
	
	static void Batalhar(int[] exercitoA, int[] exercitoB)
	{
	  for(int i = 0; i < exercitoA.GetLength(0); i++)
	  {
	    if(exercitoA[i] > exercitoB[i])
	    {
	      exercitoB[i] = 0;
	    }
	    else if(exercitoA[i] < exercitoB[i])
	    {
	      exercitoA[i] = 0;
	    }
	  }
	}
	
	static void Imprimir(int[] exercito)
	{
	  for(int i = 0; i < exercito.GetLength(0); i++)
	  {
	    Console.Write(exercito[i] + "|");
	  }
	  Console.WriteLine();
	}
	
	static void Vencedor(int[] exercitoA, int[] exercitoB)
	{
	  int mortesA = 0;
	  int mortesB = 0;
	  for(int i = 0; i < exercitoA.GetLength(0); i++)
	  {
	    if(exercitoA[i] == 0)
	    {
	      mortesA++;
	    }
	    else if(exercitoB[i] == 0)
	    {
	      mortesB++;
	    }
	  }
	  
	  if(mortesA < mortesB)
	  {
	    Console.WriteLine("Vitoria do exercito A");
	  }
	  else if(mortesB < mortesA)
	  {
	    Console.WriteLine("Vitoria do exercito B");
	  }
	  else
	  {
      Console.WriteLine("Empate");
	  }
	}
}