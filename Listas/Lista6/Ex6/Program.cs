using System;

class Program
{
    static void Main(string[]args)
    {
        const int TAMANHO = 4;
        int[,] numeros = new int[TAMANHO,TAMANHO];
        for(int i = 0; i < TAMANHO; i++)
        {
            for(int j = 0; j < TAMANHO; j++)
            {
                numeros[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int acao = Convert.ToInt32(Console.ReadLine());
        if(acao == 1)
        {
            for(int i = 0; i < TAMANHO; i++)
            {
                for(int j = 0; j < TAMANHO; j++)
                {
                    System.Console.WriteLine(numeros[i,j]);
                }
            }
        }
        else if(acao == 2)
        {
            int somatorio = 0;
            for(int i = 0; i < TAMANHO; i++)
            {
                for(int j = 0; j < TAMANHO; j++)
                {
                    somatorio += numeros[i,j];
                }
            }
            System.Console.WriteLine(somatorio);
        }
        else if(acao == 3)
        {
            int somatorio = 0;
            for(int i = 0; i < TAMANHO; i++)
            {
                somatorio += numeros[2,i];
            }
            System.Console.WriteLine(somatorio);
        }
        else if(acao == 4)
        {
            int somatorio = 0;
            for(int i = 0; i < TAMANHO; i++)
            {
                somatorio += numeros[i,i];
            }
            System.Console.WriteLine(somatorio);
        }
        else if(acao == 5)
        {
            int somatorio = 0;
            for(int i = 0; i < TAMANHO; i++)
            {
                if(numeros[i,1] % 2 == 0)
                {
                    somatorio += numeros[i,1];
                }
            }
            System.Console.WriteLine(somatorio);
        }
        else
        {
            System.Console.WriteLine("acao nao encontrada...");
        }
    }
}