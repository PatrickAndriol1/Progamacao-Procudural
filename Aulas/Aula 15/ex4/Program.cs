using System;

class Program
{
    static void Main(string[] args)
    {
        int valor = Convert.ToInt32(Console.ReadLine());
        int[] notas = {100, 50, 20, 10, 5, 2, 1};
        int quantidadeNotas;

        for(int i = 0; i < notas.Length; i++)
        {
            quantidadeNotas = valor / notas[i];
            System.Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {notas[i]},00");
            valor = valor % notas[i];
        }
    }
}