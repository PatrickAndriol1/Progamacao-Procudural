using System;

class Program
{
    static void Main(string[] args)
    {
        const int PESSOAS = 10;
        string[] nomes = new string[PESSOAS];

        for(int i = 0; i < PESSOAS; i++)
        {
            nomes[i] = Console.ReadLine();
        }
        for(int i = (PESSOAS - 1); i >= 0; i--)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}