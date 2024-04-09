using System;

class Program
{
    const int HORAS_MINIMAS = 40;
    static void Main(string[] args)
    {
        const int HORARIO_MAXIMO = 60;
        int horasTrabalhadas = 0;
        do
        {
            horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            if(horasTrabalhadas <= HORARIO_MAXIMO && horasTrabalhadas >= HORAS_MINIMAS)
            {
                break;
            }
            System.Console.WriteLine("Horario não permitido, tente novamente...");
        }
        while(horasTrabalhadas > HORARIO_MAXIMO || horasTrabalhadas < HORAS_MINIMAS);
        int valorTotal = CalcularSalario(horasTrabalhadas);
        System.Console.WriteLine(valorTotal + ",00 R$");
    }

    static int CalcularSalario(int horasTrabalhadas)
    {
        const int VALOR_HORA = 15;
        const int ACRECIMO = 10;
        int valor = horasTrabalhadas * VALOR_HORA;
        int horaExtra = horasTrabalhadas - HORAS_MINIMAS;
        int valorExtra = horaExtra * ACRECIMO;
        int valorTotal = valor + valorExtra;
        return valorTotal;
    }
}