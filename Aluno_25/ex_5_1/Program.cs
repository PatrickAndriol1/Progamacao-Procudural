using System;

class Program 
{
    static void Main(string[] args)
    {
        int maximo = Convert.ToInt32(Console.ReadLine());
        int proximo = 0;
        int atual = proximo;
        int anterior;
        while (proximo < maximo)
        {
            System.Console.Write(proximo + " ");
            anterior = atual;
            atual = proximo;
            if (proximo == 0)
            {
                proximo++;
            }
            else
            {
                proximo = atual + anterior;
            }
        }
        System.Console.WriteLine();
    }
}