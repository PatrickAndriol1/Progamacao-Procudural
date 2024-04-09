using System;

class Program
{
    static void Main(string[] args)
    {
        String palavra = Console.ReadLine();
        for(int i = 0; i < 3; i++)
        {
            System.Console.Write($"{palavra}... ");
        }
        System.Console.WriteLine();
    }
}