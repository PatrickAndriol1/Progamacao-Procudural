using System;
using System.Data;

class Program
{
    static void Main(string[]args)
    {
        const int TAMANHO = 3;
        int[,] numeros = new int[TAMANHO,TAMANHO];
        int somatorio = 0;
        
        for(int i = 0; i < TAMANHO; i++)
        {
            for(int j = 0; j < TAMANHO; j++)
            {
                numeros[i,j] = Convert.ToInt32(Console.ReadLine());
                if(i == j)
                {
                    somatorio += numeros[i,j];
                }
            }
        }
        System.Console.WriteLine(somatorio);
    }
}