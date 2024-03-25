using System;

class Program
{
    static void Main(string[]args)
    {
        const int MAXIMO = 10;
        int[] numeros = new int[MAXIMO];
        int i = 0;
        while(i < MAXIMO)
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            if(numero > 9 && numero < 51)
            {
                numeros[i] = numero;
                i++;
            }
        }
        for(int j = 0; j < MAXIMO; j++)
        {
            Console.WriteLine(numeros[j]);
        }
    }
}