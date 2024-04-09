using System;

class Program 
{
    static void Main(string[] args)
    {
        int tamanho = ReceberTamanho();
        string[,] ampulheta = new string[tamanho, tamanho];
        GerarAmpulheta(tamanho, ampulheta);
        ImprimirAmpulheta(tamanho, ampulheta);
    }

    static int ReceberTamanho()
    {
        int tamanho = 0;
        while (tamanho % 2 == 0 || tamanho <= 1)
        {
            tamanho = Convert.ToInt32(Console.ReadLine());
            if(tamanho % 2 == 1 && tamanho > 1)
            {
                break;
            }
            System.Console.WriteLine("O numero digitado deve ser impar e maior que 1");
        }
        return tamanho;
    }

    static void GerarAmpulheta(int tamanho, string[,] ampulheta)
    {
        for(int i = 0; i < ampulheta.GetLength(0); i++)
        {
            for(int j = 0; j < ampulheta.GetLength(1); j++)
            {
                if(i == j)
                {
                    ampulheta[i,j] = "\\";
                }
                if(i + j == tamanho - 1)
                {
                    ampulheta[i,j] = "/";
                }
                if(i == tamanho/2 && i == j)
                {
                    ampulheta[i,j] = "X";
                }
                if(ampulheta[i,j] == null)
                {
                    ampulheta[i,j] = " ";
                }
            }
        }
    }

    static void ImprimirAmpulheta(int tamanho, string[,] ampulheta)
    {
        ImprimirBase(tamanho);
        for(int i = 0; i < ampulheta.GetLength(0); i++)
        {
            for(int j = 0; j < ampulheta.GetLength(1); j++)
            {
                System.Console.Write(ampulheta[i,j]);
            }
            System.Console.WriteLine();
        }
        ImprimirBase(tamanho);
    }

    static void ImprimirBase(int tamanho)
    {
        for(int i = 0; i < tamanho; i++)
        {
            System.Console.Write("-");
        }
        System.Console.WriteLine();
    }
}