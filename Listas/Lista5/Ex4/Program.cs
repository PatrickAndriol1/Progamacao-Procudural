using System;

class Progra
{
    static void Main(string[]args)
    {
        int somatorio = 0;
        while(true)
        {
            System.Console.Write("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero < 0)
            {
                break;
            }
            if(numero % 2 == 1)
            {
                somatorio += numero;
            }
        }
        System.Console.WriteLine("O somatorio de impares eh: " + somatorio);
    }
}