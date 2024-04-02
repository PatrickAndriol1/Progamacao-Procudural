using System;

class Program
{
    static void Imprimir(int numero)
    {
        if(numero < 0)
        {
            return;
        }
        System.Console.WriteLine(numero);
        numero -= 3;
        Imprimir(numero);
    }

    static void Main(string[] args)
    {
        Imprimir(100);
    }
}