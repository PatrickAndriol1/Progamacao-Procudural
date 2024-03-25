using System;

class Program
{
    static void Main(string[]args)
    {
        const int TAMANHO = 3;
        int[,] numeros = new int[TAMANHO,TAMANHO];
        
        for(int i = 0; i < TAMANHO; i++)
        {
            for(int j = 0; j < TAMANHO; j++)
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                if(i + j == 2)
                {
                    numeros[i,j] = numero * 2;
                }
                else
                {
                    numeros[i,j] = numero;
                }
            }
        }
        for(int i = 0; i < TAMANHO; i++)
        {
            for(int j = 0; j < TAMANHO; j++)
            {
                Console.Write(numeros[i,j] + "|");
            }
            System.Console.WriteLine();
        }
    }
}