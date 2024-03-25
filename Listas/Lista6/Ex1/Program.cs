using System;

class Program
{
    static void Main(string[]args)
    {
        const int PESSOAS = 10;
        string[] nomes = new string[PESSOAS];

        for(int i = 0; i < PESSOAS; i++)
        {
            nomes[i] = Console.ReadLine();
        }
        string buscarNome = Console.ReadLine();
        bool temNome = false;
        for(int i = 0; i < PESSOAS; i++)
        {
            if(buscarNome == nomes[i])
            {
                temNome = true;
            }
        }
        if(temNome == true)
        {
            System.Console.WriteLine("ACHEI");
        }
        else
        {
            System.Console.WriteLine("NAO ACHEI");
        }
    }
}