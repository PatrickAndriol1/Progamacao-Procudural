using System;

class Program
{
    static void Main(string[]args)
    {
        for(int segundos = 3; segundos > 0; segundos--)
        {
            System.Console.WriteLine(segundos);
            Thread.Sleep(1000);
        }
        System.Console.WriteLine("Feliz ano novo!!!");
    }
}