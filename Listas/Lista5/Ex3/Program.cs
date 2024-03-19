using System;

class Program
{
    static void Main(string[]args)
    {
        System.Console.Write("Insira a altura do retangulo: ");
        int alturaRetangulo = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Insira a base do retangulo: ");
        int baseRetangulo = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < alturaRetangulo; i++)
        {
            for(int j = 0; j < baseRetangulo; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}
