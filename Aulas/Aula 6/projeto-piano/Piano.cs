using System;
using NAudio.Wave;


class Piano
{

    const int TEMPO_PADRAO = 500;
    public static void ReproduzTecla(int numeroOitava, int numeroTecla)
    {
        ReproduzTecla(numeroOitava, numeroTecla, TEMPO_PADRAO);
    }

    public static void ReproduzTecla(int numeroOitava, int numeroTecla, int tempoEmMilissegundos)
    {
        if (numeroOitava == 0)
        {
            Pausa(tempoEmMilissegundos);
            return;
        }

        string filePath = "assets/keyboard/" + 
            numeroOitava.ToString() + "-" + numeroTecla.ToString() + ".mp3"; 

        using (var audioFile = new AudioFileReader(filePath))
        using (var outputDevice = new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            Thread.Sleep(tempoEmMilissegundos);
        }
    }

    

    private static void Pausa(int tempoEmMilissegundos)
    {
        Thread.Sleep(tempoEmMilissegundos);
    }

    public static void TocarAsaBranca()
    {
        ReproduzTecla(1,5,400);
        ReproduzTecla(1,6,400);
        ReproduzTecla(1,7,800);
        ReproduzTecla(2,2,800);
        ReproduzTecla(2,2,800);
        ReproduzTecla(1,7,900);
        ReproduzTecla(2,1,800);
        ReproduzTecla(2,1,1300);

        ReproduzTecla(0,0,400);

        ReproduzTecla(1,5,400);
        ReproduzTecla(1,6,400);
        ReproduzTecla(1,7,800);
        ReproduzTecla(2,2,800);
        ReproduzTecla(2,2,800);
        ReproduzTecla(2,1,800);
        ReproduzTecla(1,7,1600);

        ReproduzTecla(0,0,200);

        ReproduzTecla(1,5,400);
        ReproduzTecla(1,5,400);
        ReproduzTecla(1,6,400);
        ReproduzTecla(1,7,900);
        ReproduzTecla(2,2,1400);

        ReproduzTecla(2,2,400);
        ReproduzTecla(2,1,400);
        ReproduzTecla(1,7,400);
        ReproduzTecla(1,5,900);
        ReproduzTecla(2,1,1400);

        ReproduzTecla(1,7,400);
        ReproduzTecla(1,7,400);
        ReproduzTecla(1,6,400);
        ReproduzTecla(1,6,900);
        ReproduzTecla(1,7,1400);

        ReproduzTecla(1,6,400);
        ReproduzTecla(1,6,400);
        ReproduzTecla(1,5,400);
        ReproduzTecla(1,5,1600);    
    }

    public static void TocarTwinkleTwinkle()
{
    ReproduzTecla(1, 1, 400); // Dó
    ReproduzTecla(1, 1, 400); // Dó
    ReproduzTecla(1, 5, 400); // Sol
    ReproduzTecla(1, 5, 400); // Sol
    ReproduzTecla(1, 6, 400); // Lá
    ReproduzTecla(1, 6, 400); // Lá
    ReproduzTecla(1, 5, 800); // Sol

    ReproduzTecla(1, 4, 400); // Fá
    ReproduzTecla(1, 4, 400); // Fá
    ReproduzTecla(1, 3, 400); // Mi
    ReproduzTecla(1, 3, 400); // Mi
    ReproduzTecla(1, 2, 400); // Ré
    ReproduzTecla(1, 2, 400); // Ré
    ReproduzTecla(1, 1, 800); // Dó

    ReproduzTecla(1, 5, 400); // Sol
    ReproduzTecla(1, 5, 400); // Sol
    ReproduzTecla(1, 4, 400); // Fá
    ReproduzTecla(1, 4, 400); // Fá
    ReproduzTecla(1, 3, 400); // Mi
    ReproduzTecla(1, 3, 400); // Mi
    ReproduzTecla(1, 2, 800); // Ré

    ReproduzTecla(1, 5, 400); // Sol
    ReproduzTecla(1, 5, 400); // Sol
    ReproduzTecla(1, 4, 400); // Fá
    ReproduzTecla(1, 4, 400); // Fá
    ReproduzTecla(1, 3, 400); // Mi
    ReproduzTecla(1, 3, 400); // Mi
    ReproduzTecla(1, 2, 800); // Ré

    ReproduzTecla(1, 1, 400); // Dó
    ReproduzTecla(1, 1, 400); // Dó
    ReproduzTecla(1, 5, 400); // Sol
    ReproduzTecla(1, 5, 400); // Sol
    ReproduzTecla(1, 6, 400); // Lá
    ReproduzTecla(1, 6, 400); // Lá
    ReproduzTecla(1, 5, 800); // Sol

    ReproduzTecla(1, 4, 400); // Fá
    ReproduzTecla(1, 4, 400); // Fá
    ReproduzTecla(1, 3, 400); // Mi
    ReproduzTecla(1, 3, 400); // Mi
    ReproduzTecla(1, 2, 400); // Ré
    ReproduzTecla(1, 2, 400); // Ré
    ReproduzTecla(1, 1, 800); // Dó
}

}
