using System;

class Program
{
    static void Main(string[] args)
    {
        const int MAXIMO_TABUADA = 10;

        for(int i = 1; i <= MAXIMO_TABUADA; i++)
        {
            for(int j = 1; j <= MAXIMO_TABUADA; j++)
            {
                System.Console.WriteLine($"{i} x {j} = {i*j}");
            }
            System.Console.WriteLine();
        }
    }
}