using System;

class Program
{
    static void Main (string[] args)
    {
        System.Console.Write("Nota Primeiro Bimestre: ");
        double nota1 = double.Parse(Console.ReadLine());

        System.Console.Write("Nota Segundo Bimestre: ");
        double nota2 = double.Parse(Console.ReadLine());

        System.Console.Write("Nota Terceiro Bimestre: ");
        double nota3 = double.Parse(Console.ReadLine());

        System.Console.Write("Nota Quarto Bimestre: ");
        double nota4 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

        if (media >= 5.0)
        {
            System.Console.WriteLine("Aluno aprovado");
        }
        else if (media < 5.0 && media >= 3.0)
        {
            System.Console.WriteLine("Aluno em recuperacao");
        }
        else
        {
            System.Console.WriteLine("Aluno reprovado");
        }
    }
}
