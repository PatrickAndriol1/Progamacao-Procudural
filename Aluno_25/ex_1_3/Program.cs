using System;

class Program
{
    static void Main(string[] args)
    {
        const int QUANTIDADE_NOTAS = 4;
        double somatorio = 0;
        for(int i = 0; i < QUANTIDADE_NOTAS; i++)
        {
            double nota = Convert.ToDouble(Console.ReadLine());
            somatorio += nota;
        }
        double notaFinal = somatorio/QUANTIDADE_NOTAS;
        VerificarNota(notaFinal);
    }

    static void VerificarNota(double notaFinal)
    {
        if(notaFinal >= 5)
        {
            System.Console.WriteLine("Aluno aprovado");
        }
        else if(notaFinal >= 3)
        {
            System.Console.WriteLine("Aluno em recuperacao");
        }
        else
        {
            System.Console.WriteLine("Aluno reprovado");
        }
    }
}