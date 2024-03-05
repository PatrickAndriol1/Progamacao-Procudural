using System;
class Program
{
    static void Main(string[] args)
    {
        double mediaAltura = 0;
        double maisAlto = 0;
        const int NUMERO_JOGADORES = 5;

        for (int i = 1; i <= NUMERO_JOGADORES; i++)
        {
            System.Console.Write("Altura do " + i + "° jogador: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            mediaAltura += altura;

            if (altura > maisAlto)
            {
                maisAlto = altura;
            }
        }
        mediaAltura /= NUMERO_JOGADORES;
        System.Console.WriteLine("A media de altura registrada foi: " + Math.Round(mediaAltura, 2) + "m");
        System.Console.WriteLine("A altura mais alta registrada foi: " + Math.Round(maisAlto, 2) + "m");
    }
}
