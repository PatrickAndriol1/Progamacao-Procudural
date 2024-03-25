using System;

class Program
{
    static int x = 0;
    static int y = 0;
    static int pontoX;
    static int pontoY;
    static int pontosCapturados = 0;
    static bool pontoCapturado = true;

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Random random = new Random();

        while (true)
        {
            Console.Clear();
            DesenharQuadrado();
            if (pontoCapturado)
            {
                GerarNovoPonto(random);
            }
            DesenharPonto();

            if (x == pontoX && y == pontoY)
            {
                pontoCapturado = true;
                pontosCapturados++;
                if (pontosCapturados >= 10)
                {
                    Console.Clear();
                    Console.WriteLine("Game win!");
                    return;
                }
            }
            else
            {
                pontoCapturado = false;
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (y > 0)
                        y--;
                    break;
                case ConsoleKey.DownArrow:
                    if (y < Console.WindowHeight - 3)
                        y++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (x > 0)
                        x--;
                    break;
                case ConsoleKey.RightArrow:
                    if (x < Console.WindowWidth - 4)
                        x++;
                    break;
                case ConsoleKey.Escape:
                    return;
            }
        }
    }

    static void DesenharQuadrado()
    {
        Console.SetCursorPosition(x, y);
        Console.Write("+---+");
        Console.SetCursorPosition(x, y + 1);
        Console.Write("|   |");
        Console.SetCursorPosition(x, y + 2);
        Console.Write("+---+");
    }

    static void GerarNovoPonto(Random random)
    {
        pontoX = random.Next(0, Console.WindowWidth - 4);
        pontoY = random.Next(0, Console.WindowHeight - 3);
        Console.SetCursorPosition(pontoX, pontoY);
        Console.Write("o");
        pontoCapturado = false;
    }

    static void DesenharPonto()
    {
        if (!pontoCapturado)
        {
            Console.SetCursorPosition(pontoX, pontoY);
            Console.Write("o");
        }
    }
}