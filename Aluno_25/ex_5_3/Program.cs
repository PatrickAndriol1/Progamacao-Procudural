using System;

class Program
{
    static void Main(string[] args)
    {
        char[] palavra = {'K','a','r','p','o','v'};
        System.Console.WriteLine("dica: Ja foi campeao mundial de Xadrez");
        char[] forca = new char[6];
        CriarForca(forca);
        ImprimirForca(forca);
        Jogar(palavra, forca);
    }

    static void CriarForca(char[] forca)
    {
        for(int i = 0; i < forca.Length; i++)
        {
            forca[i] = '-';
        }
    }

    static void Jogar(char[] palavra, char[] forca)
    {
        int erro = 0;
        while(Comparar(palavra, forca))
        {
            char resposta = Convert.ToChar(Console.ReadLine());
            bool tentativa = VerificarResposta(resposta, palavra);
            if(tentativa)
            {
                PreencherForca(palavra, forca, resposta);
            }
            else
            {
                erro++;
            }
            ImprimirForca(forca);
            if(erro == 3)
            {
                System.Console.WriteLine("Voce perdeu...");
                break;
            }
        }
        if(erro < 3)
        {
            System.Console.WriteLine("Voce ganhou!!");
        }
    }

    static bool Comparar(char[] palavra, char[] forca)
    {
        int contador = 0;
        for(int i = 0; i < palavra.Length; i++)
        {
            if(palavra[i] == forca[i])
            {
                contador++;
            }
        }
        if(contador == 6)
        {
            return false;
        }
        return true;
    }

    static void PreencherForca(char[] palavra, char[] forca, char resposta)
    {
        for(int i = 0; i < palavra.Length; i++)
        {
            if(resposta == palavra[i])
            {
                forca[i] = resposta;
            }
        }
    }

    static void ImprimirForca(char[] forca)
    {
        for(int i = 0; i < forca.Length; i++)
        {
            System.Console.Write(forca[i]);
        }
        System.Console.WriteLine();
    }

    static bool VerificarResposta(char resposta, char[] palavra)
    {
        for(int i = 0; i < palavra.Length; i++)
        {
            if(resposta == palavra[i])
            {
                return true;
            }
        }
        return false;
    }
}