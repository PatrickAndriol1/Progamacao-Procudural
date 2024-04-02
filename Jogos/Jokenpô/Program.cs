using System;

class Program
{
    static void Main(string[]args)
    {
        System.Console.WriteLine("Jokenpô");
        System.Console.Write("[1] - Pedra\n[2] - Papel\n[3] - Tesoura\nDigite sua jogada: ");
        int jogador = int.Parse(Console.ReadLine());

        Random n = new Random();
        int maquina = n.Next(1,4)

        string computador = "";
        if(maquina == 1)
        {
            computador = "Pedra";
        }
        if(maquina == 2)
        {
            computador = "Papel";
        }
        if(maquina == 3)
        {
            computador = "Tesoura";
        }

        if (jogador == maquina)
        {
            System.Console.WriteLine($"O computador jogou: {computador}\nEmpate!");
        }
        if ((jogador == 1 && maquina == 2) || (jogador == 2 && maquina == 3) || (jogador == 3 && maquina == 1))
        {
            System.Console.WriteLine($"O computador jogou: {computador}\nVoce Perdeu!");
        }
        if ((jogador == 2 && maquina == 1) || (jogador == 3 && maquina == 2) || (jogador == 1 && maquina == 3))
        {
            System.Console.WriteLine($"O computador jogou: {computador}\nVoce Ganhou!");
        }
    }
}
