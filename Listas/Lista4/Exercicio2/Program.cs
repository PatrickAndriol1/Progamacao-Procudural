using System;

class Program
{
    static void Main(string[]args)
    {
        int numero;

        do
        {
            System.Console.Write("Digite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 1 || numero > 9)
            {
                System.Console.WriteLine("altura invalida, insira uma altura entre 1 e 9");
            }
        } 
        while (numero < 1 || numero > 9);

        for(int i = 1; i <= numero; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                System.Console.Write(j);
            }
            System.Console.WriteLine();
        }       
    }
}