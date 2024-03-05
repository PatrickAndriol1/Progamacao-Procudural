using System;
using System.Net.Http.Headers;
class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_HABITANTES = 20;
        double somaFilhos = 0;
        double somaSalario = 0;
        double maiorSalario = 0;

        for (int i = 1; i <= NUMERO_HABITANTES; i++)
        {
            Console.WriteLine("\nHabitante [" + i + "]:");
            Console.Write("Digite o seu salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            somaSalario += salario;

            Console.Write("Digite quantos filhos voce tem: ");
            double filhos = Convert.ToDouble(Console.ReadLine());

            somaFilhos += filhos;

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }
        }

        double mediaSalario = somaSalario / NUMERO_HABITANTES;
        double mediaFilhos = somaFilhos / NUMERO_HABITANTES;

        Console.WriteLine("\nA media de salario da populacao eh: " + Math.Round(mediaSalario, 2) + " reais");
        Console.WriteLine("A media de filhos da populacao eh: " + Math.Round(mediaFilhos, 2));
        Console.WriteLine("O maior salario registrado foi: " + maiorSalario + " reais");
    }
}
