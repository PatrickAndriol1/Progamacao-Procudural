using System;

class Program 
{
    static void Main(string[] args)
    {
        int altura = Convert.ToInt32(Console.ReadLine());
        int largura = altura;
        int espaco = altura - 1;
        for (int i = 0; i < altura; i++)
        {
            for(int j = 0; j < largura; j++)
            {
                if(j < espaco)
                {
                    System.Console.Write(" ");
                }
                else
                {
                    System.Console.Write("*");
                }
            }
            System.Console.WriteLine();
            espaco--;
            largura++;
        }
    }
}