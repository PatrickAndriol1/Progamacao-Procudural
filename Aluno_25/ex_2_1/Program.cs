using System;

class Program
{
    static void Main(string[] args)
    {
        const int PRECO_KM = 25;
        double quilometragem = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("O preco final da sua expedicao eh: " + Math.Round(quilometragem * PRECO_KM, 2));
    }
}