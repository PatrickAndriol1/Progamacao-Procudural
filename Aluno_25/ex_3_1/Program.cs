using System;

class Program
{
    static void Main(string[] args)
    {
        const int DIAS_ANO = 360;
        int diasVividos = Convert.ToInt32(Console.ReadLine());
        int anos = diasVividos / DIAS_ANO;
        System.Console.WriteLine($"Essa pessoa viveu {anos} ano(s)");
    }
}