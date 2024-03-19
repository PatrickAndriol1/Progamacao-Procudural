using System;

class Program
{
    static void Main(string[]args)
    {
        for(int i = 0, j = 200; i <= 100; i += 2, j -= 4)
        {
            System.Console.WriteLine($"{i} - {j}");
        }
    }
}
