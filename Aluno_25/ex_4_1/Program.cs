using System;

class Program
{
    static void Main(string[] args)
    {
        double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());
        double temperaturaFahrenheit = ConverterTemperatura(temperaturaCelsius);
        System.Console.WriteLine(temperaturaFahrenheit);
    }

    static double ConverterTemperatura(double celsius)
    {
        double fahrenheit = ((9.0 / 5.0) * celsius) + 32;
        return fahrenheit;
    }
}