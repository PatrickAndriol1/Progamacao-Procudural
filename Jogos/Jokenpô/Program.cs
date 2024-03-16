using System;

class Program
{
    static void Main(string[]args)
    {
        System.Console.WriteLine("Jokenpô");
        System.Console.Write("[1] - Pedra\n[2] - Papel\n[3] - Tesoura\nDigite sua jogada: ");
        int jogador = int.Parse(Console.ReadLine());

        Random n = new Random();
        n.Next(1,4);
        int maquina = Convert.ToInt32(n.Next(1,4));

        if (jogador == maquina)
        {
            System.Console.WriteLine($"O computador jogou: {maquina}\nEmpate!");
        }
        if ((jogador == 1 && maquina == 2) || (jogador == 2 && maquina == 3) || (jogador == 3 && maquina == 1))
        {
            System.Console.WriteLine($"O computador jogou: {maquina}\nVoce Perdeu!");
        }
        if ((jogador == 2 && maquina == 1) || (jogador == 3 && maquina == 2) || (jogador == 1 && maquina == 3))
        {
            System.Console.WriteLine($"O computador jogou: {maquina}\nVoce Ganhou!");
        }
    }
}
