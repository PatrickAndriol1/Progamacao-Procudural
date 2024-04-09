using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = LerNumeros();
        System.Console.WriteLine(numero);
    }

    static int LerNumeros()
    {
        const int QUANTIDADE_NUMEROS = 3;
        int menor = int.MaxValue;
        for(int i = 0; i < QUANTIDADE_NUMEROS; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if(num < menor)
            {
                menor = num;
            }
        }
        return menor;
    }
}