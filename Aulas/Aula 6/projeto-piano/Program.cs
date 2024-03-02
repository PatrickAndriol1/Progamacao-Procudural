class Program 
{
    static void Main(string[] args)
    {
        const int CONTADOR = 7;
        int oitava = 1;
        int nota = 1;

        while (nota <= CONTADOR)
        {
            Piano.ReproduzTecla(oitava,nota);
            nota++;
        }
    }
}