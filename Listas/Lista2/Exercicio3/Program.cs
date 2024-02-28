using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Nome da crianca: ");
        string nomeCrianca = Console.ReadLine();

        if (nomeCrianca == "Filomena")
        {
            System.Console.WriteLine("Rotina de Filomena:");
            System.Console.WriteLine("1. Escola das 7h as 12h");
            System.Console.WriteLine("2. Almoco das 12h as 13h");
            System.Console.WriteLine("3. Futebol das 14h as 16h");
            System.Console.WriteLine("4. Dever de casa das 16h as 18h");
        }
        else if (nomeCrianca == "Joselito")
        {
            System.Console.WriteLine("Rotina de Joselito:");
            System.Console.WriteLine("1. Escola das 7h as 12h30");
            System.Console.WriteLine("2. Almoco das 13h as 14h");
            System.Console.WriteLine("3. Natacao das 14h as 16h");
            System.Console.WriteLine("4. Reforco escolar das 16h as 19h");
        }
        else
        {
            System.Console.WriteLine("Nome nao identificado...");
        }
    }
}
