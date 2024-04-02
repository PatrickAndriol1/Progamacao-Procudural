using System;

class Program
{
    static double Delta(double a, double b, double c)
    {
        return Math.Pow(b,2) -4 * a * c;
    }
    static double[] Bhaskara(double a, double b, double c)
    {
        double[] resultado = new double[2];

        resultado[0] = (-b + Math.Sqrt(Delta(a, b, c))) / 2 * a;
        resultado[1] = (-b - Math.Sqrt(Delta(a, b, c))) / 2 * a;

        return resultado;
    }

    static void Main(string[] args)
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double[] raizes = Bhaskara(a, b, c);

        System.Console.WriteLine(raizes[0]);
        System.Console.WriteLine(raizes[1]);
    }
}