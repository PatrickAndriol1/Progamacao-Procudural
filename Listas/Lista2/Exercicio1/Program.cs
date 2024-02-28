using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Nome de usuario: ");
        string login = Console.ReadLine();

        System.Console.Write("Senha: ");
        string senha = Console.ReadLine();

        if (login == "admin" && senha == "123senha")
        {
            System.Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            System.Console.WriteLine("Credenciais invalidas... ");
        }
    }
}
